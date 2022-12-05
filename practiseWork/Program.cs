// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilLibrary;

String comand = "";
//prompt user to enter a command
Console.WriteLine("Enter a command");
//read the command
comand = Console.ReadLine();

if (comand == "version")
{
    Console.WriteLine("Version 1.0");
    Console.WriteLine("By Ilya");
}
else if (comand == "run")
{
    String lab = "";
    Console.WriteLine("Enter a lab number");
    lab = Console.ReadLine();
    if (lab == "1")
    {
        LabOne labOne = new LabOne();
        labOne.execute();
    }
    else if (lab == "2")
    {
        LabTwo labTwo = new LabTwo();
        labTwo.Execute();
    }
    else if(lab == "3")
    {
        LabThree labThree = new LabThree();
        labThree.execute();
    }
    
    else
    {
        Console.WriteLine("No such lab");
    }
   }

else if (comand == "help")
{
    Console.WriteLine("run - run the program");
    Console.WriteLine("version - shows the version of the program");
    Console.WriteLine("help - shows the list of commands");
    Console.WriteLine("exit - exits the program");
}
else if (comand == "exit")
{
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Unknown command");
}

    