using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model
{
    public class Macchiato : ICoffee
    {
        private const string _name = "Макиато";
        private const string _description = "Готовится из одной порции эспрессо, в которую добавляется небольшое количество молока";
        private double cost;

        private Dictionary<double, double> _price = new Dictionary<double, double>()
        {
            { 0.2, 60 },
            {0.5, 85 },
            { 0.7, 110}
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
