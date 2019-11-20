using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model
{
    public class Doppio : ICoffee
    {
        private const string _name = "Доппио";
        private const string _description = "Это двойной эспрессо";
        private double cost;

        private Dictionary<double, double> _price = new Dictionary<double, double>()
        {
            { 0.2, 75 },
            {0.5, 100 },
            { 0.7, 125}
        };
        
        public double Cost(double volum)
        {
            return _price[volum];
        }

        public string Description()
        {
            return _description;
        }

        public string Name()
        {
            return _name;
        }
    }
}
