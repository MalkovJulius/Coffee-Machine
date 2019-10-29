using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model
{
    public class Americano : ICoffee
    {
        private const string _name = "Американо";
        private const string _description = "";
        private double cost;

        private Dictionary<double, double> _price = new Dictionary<double, double>()
        {
            { 0.2, 50 },
            {0.5, 75 },
            { 1, 100}
        };
        

        public double Cost()
        {
            throw new NotImplementedException();
        }

        public string Description()
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            return _name;
        }
    }
}
