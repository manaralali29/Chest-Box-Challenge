using System;

namespace ChestState
{
    class Program
    {
        enum ChestState
        {
            Open,
            Closed,
            Locked
        }

        static void Main(string[] args)
        {
          
            ChestState currentState = ChestState.Locked;

           
            Console.WriteLine("Welcome to Manar's ChestBox Challenge for Programming! In this challenge you will unlock the chest box using multiple states: lock, unlock, open, close, and exit");
            Console.WriteLine("To move between states, use the following logic: \n");
            Console.WriteLine("unlock : Locked ==> Closed");
            Console.WriteLine("lock   : Closed ==> Lock");
            Console.WriteLine("open   : Closed ==> Open");
            Console.WriteLine("close  : Open ==> Closed");
            Console.WriteLine("exit   : To exit the whole program");

            Console.WriteLine("\nNow that you know the rules, have fun opening the box :))");

            Console.WriteLine("====================================================================");

          
            Console.WriteLine("The chest is now locked. What do you want to do?");

            while (true)
            {
               
                string command = Console.ReadLine().ToLower(); 

                switch (command)
                {
                    case "lock":
                        if (currentState == ChestState.Closed)
                        {
                            currentState = ChestState.Locked;
                            Console.WriteLine("The chest is now locked. What do you want to do?");
                        }
                        else
                        {
                            Console.WriteLine("You can't lock the chest. It must be closed first.");
                        }
                        break;

                    case "unlock":
                        if (currentState == ChestState.Locked)
                        {
                            currentState = ChestState.Closed;
                            Console.WriteLine("\nThe chest is now unlocked. What do you want to do?");
                        }
                        else
                        {
                            Console.WriteLine("You can't unlock the chest. It must be locked first.");
                        }
                        break;

                    case "open":
                        if (currentState == ChestState.Closed)
                        {
                            currentState = ChestState.Open;
                            Console.WriteLine("\nThe chest is now open. What do you want to do?");
                        }
                        else if (currentState == ChestState.Locked)
                        {
                            Console.WriteLine("You can't open the chest. It is locked.");
                        }
                        else
                        {
                            Console.WriteLine("The chest is already open.");
                        }
                        break;

                    case "close":
                        if (currentState == ChestState.Open)
                        {
                            currentState = ChestState.Closed;
                            Console.WriteLine("\nThe chest is now closed. What do you want to do?");
                        }
                        else
                        {
                            Console.WriteLine("You can't close the chest. It is not open.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Exiting Manar's Chest Program. Hope it was a great adventure, goobye!");
                        return;

                    default:
                        Console.WriteLine("Invalid command. Please enter a valid command (lock, unlock, open, close, exit).");
                        break;
                }
            }
        }
    }
}
