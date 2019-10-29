using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model
{
    interface ICoffee
    {
        //Enum  ? I need to think about it
        double Cost();
        string Description();
        string Name();        
    }


    //Эспрессо
    //Американо
    //Капучино
    //Латте
    //Макиато
    //Чёрный Кофе
}
