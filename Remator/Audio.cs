using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Speech.Synthesis;

namespace Remator
{
	public partial class Audio : Form
	{
		public Audio()
		{
			InitializeComponent();
		}

		private void Audio_Load(object sender, EventArgs e)
		{

			var enumerator = new MMDeviceEnumerator();

			//MMDevice selectedDevice = null;
			var defaultCapture = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
			Dictionary<MMDevice, string> inputs = new Dictionary<MMDevice, string>();
			foreach (MMDevice device in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
			{
				inputs.Add(device, device.FriendlyName);
				//if (device.ID == defaultDevice.ID)
				//{
				//	selectedDevice = device;
				//}
			}

			//Console.WriteLine(defaultCapture.FriendlyName);
			//enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);

			comboInputDevice.DataSource = new BindingSource(inputs, null);
			comboInputDevice.DisplayMember = "Value";
			comboInputDevice.ValueMember = "Key";
			comboInputDevice.SelectedItem = defaultCapture;
			//Console.WriteLine(comboInputDevice.SelectedIndex);


			var defaultRender = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
			Dictionary<MMDevice, string> outputs = new Dictionary<MMDevice, string>();
			foreach (MMDevice device in enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
			{
				outputs.Add(device, device.FriendlyName);
			}
			comboOutputDevice.DataSource = new BindingSource(outputs, null);
			comboOutputDevice.DisplayMember = "Value";
			comboOutputDevice.ValueMember = "Key";
			comboOutputDevice.SelectedItem = defaultRender;


			Dictionary<VoiceInfo, string> voices = new Dictionary<VoiceInfo, string>();
			using (var synth = new SpeechSynthesizer())
			{
				foreach (var voice in synth.GetInstalledVoices())
				{
					voices.Add(voice.VoiceInfo, voice.VoiceInfo.Name);
				}
			}
			comboOutputVoice.DataSource = new BindingSource(voices, null);
			comboOutputVoice.DisplayMember = "Value";
			comboOutputVoice.ValueMember = "Key";

			//comboInputDevice.Items.Add(devices.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications).DeviceFriendlyName);


		}

		private void comboInputDevice_Format(object sender, ListControlConvertEventArgs e)
		{
			
		}
	}
}
