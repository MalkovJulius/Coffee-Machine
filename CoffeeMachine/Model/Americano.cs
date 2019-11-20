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
        private const string _description = "Это классический эспрессо, в который добавляется горячая вода.";
        private double cost;

        private Dictionary<double, double> _price = new Dictionary<double, double>()
        {
            { 0.2, 25 },
            {0.5, 35 },
            { 0.7, 50}
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
