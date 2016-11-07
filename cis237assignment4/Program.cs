using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciates some a queue and a stack for each type of droid
            DroidQueue<IDroid> queue = new DroidQueue<IDroid>();
            DroidStack<IDroid> protocolStack = new DroidStack<IDroid>();
            DroidStack<IDroid> utilityStack = new DroidStack<IDroid>();
            DroidStack<IDroid> astromechStack = new DroidStack<IDroid>();
            DroidStack<IDroid> janitorStack = new DroidStack<IDroid>();

            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);

            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection,queue, astromechStack, janitorStack, utilityStack, protocolStack);

           

            droidCollection.Add("Carbonite", "Protocol", "Gold", 7);
            droidCollection.Add("Vanadium", "Protocol", "Silver", 10);
            droidCollection.Add("Vanadium", "Astromech", "Silver", true, false, true, true, 5);
            droidCollection.Add("Carbonite", "Astromech", "Gold", false, true, true, true, 3);
            droidCollection.Add("Carbonite", "Utility", "Gold", false, true, false);
            droidCollection.Add("Vanadium", "Utility", "Silver", true, false, true);
            droidCollection.Add("Carbonite", "Janitorial", "Gold", true, false, true, false, true);
            droidCollection.Add("Vanadium", "Janitorial", "Silver", true, true, false, false, true);


            //Display the main greeting for the program
            userInterface.DisplayGreeting();

            //Display the main menu for the program
            userInterface.DisplayMainMenu();

            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            //While the choice is not equal to 3, continue to do work with the program
            while (choice != 5)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;
                    case 3:
                        userInterface.SortDroidListByModel();
                        break;
                    case 4:
                        userInterface.SortDroidListByCost();
                        break;
                }
                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }


        }
    }
}
