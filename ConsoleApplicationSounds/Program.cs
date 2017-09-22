using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Speech.Synthesis;

namespace ConsoleApplicationSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            BeepAtMe();
            SpeakToMe();
        }

        static void BeepAtMe()
        {
            Console.Beep(37, 1000);
            Console.Beep(32767, 1000);
            Console.Read();

            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
                System.Threading.Thread.Sleep(1000);
            }

            Console.Beep();
            Console.Beep();
            Console.Read();
        }

        static void SpeakToMe()
        {
            // see: https://stackoverflow.com/a/14460543/63100

            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();
            synth.Rate = 0;

            // Speak a string.
            synth.Speak("Hello World");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
