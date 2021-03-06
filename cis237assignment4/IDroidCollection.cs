﻿//Jordan Koehler
//November 8th, 2016
//CIS 237 TR 3:30 - 5:00

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Interface that I added to declare what methods MUST be implemeted in any class that implements this interface.
    interface IDroidCollection
    {
        //Various overloaded Add methods to add a new droid to the collection
        bool Add(string Material, string Model, string Color, int NumberOfLanguages);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasTrashCompactor, bool HasVaccum);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasFireExtinguisher, int NumberOfShips);

        
        //I had to add these here to be able to call them inside of the user interface. Tried to keep your program structure the same.
        void ModelSort(DroidQueue<IDroid> queue, DroidStack<IDroid> protocolStack, DroidStack<IDroid> janitorStack, DroidStack<IDroid> utilityStack,
            DroidStack<IDroid> astromechStack);

        //Same as Model Sort, added to allow for use in User Interface.
        void DroidMergeSort();

        //Method to get the data for a droid into a nicely formated string that can be output.
        string GetPrintString();
    }
}
