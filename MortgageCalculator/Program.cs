using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calculate the monthly payments of a fixed term mortgage over given Nth terms at a given interest rate. 
//Also figure out how long it will take the user to pay back the loan. 
//For added complexity, add an option for users to select the compounding interval (Monthly, Weekly, Daily, Continually).

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MortgageCalculator
    {
        public enum Interval
        {
            Yearly,
            Monthly,
            Weekly,
            Daily
        };

        public int Calculator(int mortgageValue, int interestRate)
        {
            return 0;
        }

        public int ComplexCalculator(int mortgageValue, int interestRate, Interval)
        {
            return 0;
        }
    }
}
