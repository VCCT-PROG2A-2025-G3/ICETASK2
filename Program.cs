using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the current directory
            string currentDirectory = Directory.GetCurrentDirectory();

            // Load WAV files
            Music[] musicFiles = new Music[3];
            musicFiles[0] = new Music(Path.Combine(currentDirectory, "Option1.wav"));
            musicFiles[1] = new Music(Path.Combine(currentDirectory, "Option2.wav"));
            musicFiles[2] = new Music(Path.Combine(currentDirectory, "Option3.wav"));

            // Display options to the user
            Console.WriteLine("Select a WAV file to play:");
            Console.WriteLine("1. Rap 1");
            Console.WriteLine("2. Rap 2");
            Console.WriteLine("3. Rap 3");

            // Get user input
            int choice = int.Parse(Console.ReadLine());

            // Play the selected file
            if (choice >= 1 && choice <= 3)
            {
                musicFiles[choice - 1].Play();
                Console.WriteLine("Playing file " + choice);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            // Wait for user to stop the program
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}
