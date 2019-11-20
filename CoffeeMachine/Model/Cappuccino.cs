using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model
{
    public class Cappuccino : ICoffee
    {
        private const string _name = "Капучино";
        private const string _description = "Это двойной эспрессо, горячее молоко и взбитая молочная пена.";
        private double cost;

        private Dictionary<double, double> _price = new Dictionary<double, double>()
        {
            { 0.2, 50 },
            {0.5, 75 },
            { 0.7, 100}
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
