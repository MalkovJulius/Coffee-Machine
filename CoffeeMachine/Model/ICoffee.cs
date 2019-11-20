using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model
{
    interface ICoffee
    {
        double Cost(double volum);
        string Description();
        string Name();        
    }
}
