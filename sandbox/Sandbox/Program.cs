using System;
using System.Collections;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        
        List<SmartDevice> livingRoom = new List<SmartDevice>();

        SmartLight philipsHueBulb1 = new SmartLight();
        philipsHueBulb1.deviceName = "Philips Hue Bulb 1";
        philipsHueBulb1.brightnessPercent = 100;

        livingRoom.Add(philipsHueBulb1);


        // toggle all devices proof of concept
        foreach (SmartDevice thingy in livingRoom) { 
            if (thingy.onState == true) {
                thingy.toggleOnState();
            }
        }

        
        while(true) {
            Console.WriteLine("Welcome to the smart home. Select an option");
            Console.WriteLine("1. Control a device");
            Console.WriteLine("2. Add a device");
            Console.WriteLine("3. Remove a device");
            Console.WriteLine("4. Quit");

            userChoice = Console.ReadLine();

            switch(userChoice) {
                case "1":
                    Console.WriteLine("1 selected");
                    break;
                case "2":
                    Console.WriteLine("2 selected");
                    break;
                case "3": 
                    Console.WriteLine("3 selected");
                    break;
                case "4":
                    Console.WriteLine("4 selected");
                    return;
            }
        
        }

    }
}