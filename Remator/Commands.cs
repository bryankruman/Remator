using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Remator
{
	public class Commands
	{
		public static Commands list = new Commands();


		// =================
		//  Custom Commands
		// =================

		public class Custom
		{
			public enum CommandType
			{
				Execute = 1,
				Speech = 2
			}

			public CommandType type { get; set; }
			public string name { get; set; }
			public string phrase { get; set; }
			public string response { get; set; }
		}


		// ===============
		//  Date Commands
		// ===============

		[Command("what's the current date")]
		[Command("what's the date")]
		[Command("tell me the date")]
		[Command("tell me the day")]
		[Command("what day is it")]
		public void GetDate(SpeechRecognizedEventArgs args)
		{
			Form_Remator.synth_SynthesizeSpeech(DateTime.Now.ToString("dddd, MMMM d"));
		}

		public class Date
		{
			public static Date date = new Date();

			public bool enabled { get; set; }
		}


		// ====================
		//  Listening Commands
		// ====================

		[Command("stop listening")]
		[Command("disable listening")]
		public void StopListening(SpeechRecognizedEventArgs args)
		{
			if (!Listen.listen.enabled) { return; }
			// TODO: disable listening
		}

		public class Listen
		{
			public static Listen listen = new Listen();

			public bool enabled { get; set; }
		}


		// ===============
		//  Nest Commands
		// ===============

		[Command("lower the temperature")]
		[Command("make it colder")]
		[Command("turn on the AC")]
		[Command("turn up the AC")]
		[Command("turn on the air conditioning")]
		[Command("turn up the air conditioning")]
		public void Nest_CoolDown(SpeechRecognizedEventArgs args)
		{
			Console.WriteLine(args.Result.Semantics["trigger"].Value.ToString());
		}

		[Command("raise the temperature")]
		[Command("make it warmer")]
		[Command("turn on the heat")]
		[Command("turn up the heat")]
		[Command("turn on the heater")]
		[Command("turn up the heater")]
		public void Nest_HeatUp(SpeechRecognizedEventArgs args)
		{
			
		}

		[Command("what temperature is it")]
		[Command("what temperature is it inside")]
		[Command("what's the temperature inside")]
		[Command("what's the temperature")]
		[Command("what's the humidity")]
		[Command("what's the humidity inside")]
		[Command("how humid is it")]
		[Command("how humid is it inside")]
		public void Nest_CheckInfo(SpeechRecognizedEventArgs args)
		{

		}

		public class Nest
		{
			public static Nest nest = new Nest();

			public bool enabled { get; set; }
			public bool enableTempControl { get; set; }
			public string accessToken { get; set; }
			public string deviceID { get; set; }
			public string unit { get; set; }
		}


		// ==================
		//  Sony TV Commands
		// ==================

		[Command("turn off the TV")]
		public void SonyTV_TurnOff(SpeechRecognizedEventArgs args)
		{

		}

		[Command("turn on the TV")]
		public void SonyTV_TurnOn(SpeechRecognizedEventArgs args)
		{

		}

		[Command("set a sleep timer")]
		[Command("extend my sleep timer")]
		public void SonyTV_SetSleep(SpeechRecognizedEventArgs args)
		{

		}

		[Command("cancel that sleep timer")]
		public void SonyTV_CancelSleep(SpeechRecognizedEventArgs args)
		{

		}

		public class SonyTV
		{
			public static SonyTV sonyTV = new SonyTV();
			
			public bool enabled { get; set; }
			// TODO: Add settings for sony TV api
		}

		// ===============
		//  Time Commands
		// ===============

		[Command("what's the current time")]
		[Command("tell me the time")]
		[Command("what time is it")]
		[Command("what's the time")]
		public void GetTime(SpeechRecognizedEventArgs args)
		{
			Form_Remator.synth_SynthesizeSpeech(DateTime.Now.ToString("hh:mm tt"));
			Console.WriteLine(DateTime.Now.ToString("hh:mm tt"));
		}

		public class Time
		{
			public static Time time = new Time();

			public bool enabled { get; set; }
		}


		// ==================
		//  Weather Commands
		// ==================

		[Command("what's the weather like")]
		[Command("what temperature is it outside")]
		[Command("what's the temperature outside")]
		[Command("what's the outside temperature")]
		[Command("what's the humidity outside")]
		[Command("what's the outside humidity")]
		[Command("how humid is it outside")]
		public void GetWeather(SpeechRecognizedEventArgs args)
		{
			if (!Weather.weather.enabled) { return; }

			Console.WriteLine(args.Result.Text);
			Form_Remator.synth_SynthesizeSpeech("It's currently 65 degrees outside");
		}

		public class Weather
		{
			public static Weather weather = new Weather();

			public bool enabled { get; set; }
			public string location { get; set; }
			public int unit { get; set; }
		}



		/*[Command("mator")]
		[Command("")]
		public void Mator()
		{
			Remator.synth_SynthesizeSpeech("I didn't catch that, try again?");
			//Console.WriteLine("mator!!!!!");
		}*/
	}

	[System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = true)]
	public class CommandAttribute : System.Attribute
	{
		public string CommandValue { get; set; }

		public CommandAttribute(string textValue)
		{
			CommandValue = textValue;
		}
	}
}
