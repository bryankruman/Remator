using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Remator
{
	public partial class Remator : Form
	{
		public Remator()
		{
			InitializeComponent();
		}

		static SpeechRecognitionEngine engine;
		private void Form1_Load(object sender, EventArgs e)
		{
			engine = new SpeechRecognitionEngine();
			engine.SetInputToDefaultAudioDevice();
			var words = new String[] { "shutdown my computer", "turn up the lights", "mator", "turn down the lights", "what's the weather like?" };
			Choices choices = new Choices(words);
			GrammarBuilder gb = new GrammarBuilder(choices);
			Grammar g = new Grammar(gb);
			engine.LoadGrammar(g);
			engine.RecognizeAsync(RecognizeMode.Multiple);
			engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);
		}

		static void engine_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
		{
			//e.Result.
			Console.WriteLine(string.Format("{0} : {1}", e.Result.Confidence, e.Result.Text));
		}
	}
}
