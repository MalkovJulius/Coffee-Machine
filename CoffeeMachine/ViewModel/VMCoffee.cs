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
        private double amount;
        private ICoffee coffee;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public ICommand Finished
        {
            get
            {
                return new ActionCommand(x=> {
                    amount = 0;
                    coffee = null;
                    });
            }
        }     

        public double Amount
        {
            get => amount;  //привязать к методу сумма каждого класса, через интейфейс
            set
            {
                amount = value;
                OnPropertyChanged();
            }
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
    }
}
