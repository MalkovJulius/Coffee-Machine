using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CoffeeMachine.Model;

namespace CoffeeMachine.ViewModel
{
    public class VMCoffee:INotifyPropertyChanged
    {
        private double volume;
        private ICoffee coffee;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        /*double Cost();
        string Description();
        string Name();*/
        public string Name
        {
            get => (coffee != null) ? coffee.Name() :"";
        }      

        public string Description
        {
            get => (coffee != null) ? coffee.Description() : "";
        }

        public double Cost
        {
            get => (coffee != null) ? coffee.Cost() : 0;
                      
            //TODO: передать данные volume, для вычисления цены           
        }

        public ICommand Espresso
        {
            get
            {
                return new ActionCommand(x => coffee = new Espresso());
            }
        }

        public ICommand BlackCoffee
        {
            get
            {
                return new ActionCommand(x => coffee = new BlackCoffe());
            }
        }

        public ICommand Americano
        {
            get
            {
                return new ActionCommand(x => coffee = new Americano());
            }
        }

        public ICommand Cappuccino
        {
            get
            {
                return new ActionCommand(x => coffee = new Cappuccino());
            }
        }

        public ICommand Latte
        {
            get
            {
                return new ActionCommand(x => coffee = new Latte());
            }
        }

        public ICommand Macchiato
        {
            get
            {
                return new ActionCommand(x => coffee = new Macchiato());
            }
        }

        public ICommand Finished
        {
            get
            {
                return new ActionCommand(x => {                    
                    coffee = null;
                });
            }
        }
    }
}
