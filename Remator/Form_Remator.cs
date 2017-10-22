using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Diagnostics;
using NAudio;
using NAudio.Wave;

namespace Remator
{
	public partial class Form_Remator : Form
	{
		private PerformanceCounter cpuUpdateCounter = new PerformanceCounter(
			"Process", "% Processor Time",
			Process.GetCurrentProcess().ProcessName
		);

		private static SpeechRecognitionEngine engine;

		private static Dictionary<string, MethodInfo> commandDictionary = new Dictionary<string, MethodInfo>();

		private static Dictionary<string, MethodInfo> speech_GetCommands()
		{
			if (commandDictionary.Count == 0)
			{
				var methods = typeof(Commands).GetMethods(
					BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance
				);

				var speechAttributeMethods = methods.Where(
					y => y.GetCustomAttributes().OfType<CommandAttribute>().Any()
				);

				foreach (var speechAttributeMethod in speechAttributeMethods)
				{
					foreach (var attribute in speechAttributeMethod.GetCustomAttributes(true))
					{
						commandDictionary.Add(
							((CommandAttribute)attribute).CommandValue, speechAttributeMethod
						);
					}
				}
			}

			return commandDictionary;
		}

		private static MethodInfo speech_GetMethod(string Command)
		{
			return speech_GetCommands()[Command];
		}

		private void speech_Setup()
		{
			engine = new SpeechRecognitionEngine();
			engine.SetInputToDefaultAudioDevice();
			engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speech_Recognized);

			var commandBuilder = new GrammarBuilder();
			var commandBuilderWithInput = new GrammarBuilder();

			var triggers = new Choices();
			triggers.Add(new SemanticResultValue("mator", 1));
			triggers.Add(new SemanticResultValue("alexa", 2));
			commandBuilder.Append(new SemanticResultKey("trigger", triggers));
			commandBuilderWithInput.Append(new SemanticResultKey("trigger", triggers));

			var commands = new Choices(speech_GetCommands().Keys.ToArray());
			commandBuilder.Append(new SemanticResultKey("command", commands));
			commandBuilderWithInput.Append(new SemanticResultKey("command", commands));

			var input = new Choices();
			input.Add(new SemanticResultValue("30 minutes", 30));
			input.Add(new SemanticResultValue("next", "next"));
			commandBuilderWithInput.AppendWildcard();
			commandBuilderWithInput.Append(new SemanticResultKey("input", input));

			Grammar grammar = new Grammar(commandBuilder);
			Grammar grammarWithInput = new Grammar(commandBuilderWithInput);

			engine.LoadGrammar(grammar);
			engine.LoadGrammar(grammarWithInput);

			engine.RecognizeAsync(RecognizeMode.Multiple);
		}

		static void speech_Recognized(object ob, SpeechRecognizedEventArgs args)
		{
			int semanticTrigger = 0;
			string semanticCommand = "";
			object semanticInput = null;

			if (args.Result.Semantics.ContainsKey("trigger"))
			{
				semanticTrigger = (int)args.Result.Semantics["trigger"].Value;
			}
			if (args.Result.Semantics.ContainsKey("command"))
			{
				semanticCommand = (string)args.Result.Semantics["command"].Value;
			}
			if (args.Result.Semantics.ContainsKey("input"))
			{
				semanticInput = args.Result.Semantics["input"].Value;
			}

			Console.WriteLine(string.Format("speech_Recognized: \"{0}\"", args.Result.Text));
			Console.WriteLine(string.Format(
				"{0:P2} - Trigger: '{1}', Command: '{2}', Input: '{3}'",
				args.Result.Confidence,
				semanticTrigger.ToString(),
				semanticCommand,
				semanticInput
			));

			if (!string.IsNullOrEmpty(semanticCommand))
			{
				speech_GetMethod(semanticCommand).Invoke(Commands.list, new Object[] { args });
			}
		}

		public static void synth_SpeechCompleted(object obj, SpeakCompletedEventArgs args)
		{
			engine.RecognizeAsync(RecognizeMode.Multiple);
		}

		public static void synth_SynthesizeSpeech(string speechText)
		{
			var synth = new SpeechSynthesizer();
			//synth.SelectVoice()
			synth.SetOutputToDefaultAudioDevice();
			synth.SpeakAsync(speechText);
			engine.RecognizeAsyncCancel();
			synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeechCompleted);
		}

		public Form_Remator()
		{
			InitializeComponent();
		}

		private void Remator_Load(object sender, EventArgs e)
		{
			speech_Setup();

			startupCheckBox.Checked = Properties.Settings.Default.LaunchOnStartup;
			StartupManager.SetStartupStatus(startupCheckBox.Checked);

			hideFromTaskbarCheckBox.Checked = Properties.Settings.Default.HideFromTaskbar;
			ShowInTaskbar = !hideFromTaskbarCheckBox.Checked;
		}

		private void audioButton_Click(object sender, EventArgs e)
		{
			var audioForm = new Form_Audio();
			audioForm.ShowDialog();
		}

		private void commandsButton_Click(object sender, EventArgs e)
		{
			var commandsForm = new Form_Commands();
			commandsForm.ShowDialog();
		}

		private void cpuUpdateTimer_Tick(object sender, EventArgs e)
		{
			cpuUsageLabelInfo.Text = string.Format("{0:0.##}%", cpuUpdateCounter.NextValue());
		}

		private void hideFromTaskbarCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ShowInTaskbar = !hideFromTaskbarCheckBox.Checked;
			Properties.Settings.Default.HideFromTaskbar = hideFromTaskbarCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void startupCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			StartupManager.SetStartupStatus(startupCheckBox.Checked);
			Properties.Settings.Default.LaunchOnStartup = startupCheckBox.Checked;
			Properties.Settings.Default.Save();
		}
	}
}
