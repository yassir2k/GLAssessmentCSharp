using SimpleCalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISimpleCalculatorClassLibrary
{
    //Here, I assume the implementation would happen in the same project soultion containing the class library for the interface "ISimpleCalculator".
    //I am assuming that though this implementation can be done in a separate project soultion (by exporting the class library as a .dll file and 
    //importing it in a new project), for the sake of simplicity here, I decided to do everything within the same project solution.
    public class ImplementISimpleCalculator : ISimpleCalculator
    {
        //This class here implements and overrides the interfaces declared in the ISimpleCalculatorClassLibrary.cs class library

        //For both functions, it is assumed start is the left operand and amount is the right operand
        public int Add(int start, int amount)
        {
            return (start + amount);
        }
        public int Subtract(int start, int amount)
        {
            return (start - amount);
        }
    }
}
