using System;
using SingletonPattern;
using Command.Receiver;
using Command.Invoker;
using Command.Commands;
using FacadePattern;

namespace Client
{
    class Program
    {
        private static void SingletonPattern()
        {
            Console.WriteLine("Singleton Pattern");
            var singleton = Singleton.Instance;
            Console.WriteLine("Created new instance of Singleton: {0}", nameof(singleton));
            do
            {
                var newSingleton = Singleton.Instance;
                Console.WriteLine("Accessing Singleton with {0}", nameof(newSingleton));
                Console.WriteLine("Accessing Singleton again shows it is the same instance as the created Singleton: {0} == {1}: {2}", nameof(singleton), nameof(newSingleton), singleton == newSingleton);
                Console.WriteLine("Press Q to move onto the Command Pattern or any other key to continue accessing the Singleton");
            }
            while (Console.ReadLine().ToUpper() != "Q");
        }

        private static void CommandPattern()
        {
            Console.WriteLine("\nCommand Pattern");
            IRadio radio = new Radio();
            TurnRadioUpCommand radioUpCommand = new TurnRadioUpCommand(radio);
            TurnRadioDownCommand radioDownCommand = new TurnRadioDownCommand(radio);

            Console.WriteLine("Press '+' to turn the volume up");
            Console.WriteLine("Press '-' to turn the volume down");
            Console.WriteLine("Press any other key to move onto the Facade Pattern");

            string key = "";
            do
            {
                if (key == "+")
                {
                    RadioButton radioButton = new RadioButton(radioUpCommand);
                    radioButton.RadioButtonPressed();
                }
                if (key == "-")
                {
                    RadioButton radioButton = new RadioButton(radioDownCommand);
                    radioButton.RadioButtonPressed();
                }
                key = Console.ReadLine();
            }
            while (key == "+" || key == "-");
        }

        private static void FacadePattern()
        {
            Console.WriteLine("\nFacade Pattern");
            BankAccountFacade bank = new BankAccountFacade("TestUserName", "TestUserPassword", 123456);
            Console.WriteLine("Attempting to withdraw $500");
            bank.WithdrawCash(500);
            Console.WriteLine("Attempting to withdraw $300");
            bank.WithdrawCash(300);
            Console.WriteLine("Attempting to withdraw $400");
            bank.WithdrawCash(400);
        }

        static void Main(string[] args)
        {
            SingletonPattern();
            CommandPattern();
            FacadePattern();
            Console.WriteLine("Design Patterns have finished");
            Console.Read();
        }
    }
}
