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
        private ICoffee coffee;
        private string name;
        private string description;
        private double cost;
        private double volume;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }      

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public double Cost
        {
            get => cost;
            set
            {
                cost = value;
                OnPropertyChanged();
            }
                      
            //TODO: передать данные volume, для вычисления цены           
        }

        public ICommand Espresso
        {
            get
            {
                return new ActionCommand(x => {
                    coffee = new Espresso();
                    FillInData(coffee);
                    });
            }
        }

        public ICommand BlackCoffee
        {
            get
            {
                return new ActionCommand(x => {
                    coffee = new BlackCoffe();
                    FillInData(coffee);
                });
            }
        }

        public ICommand Americano
        {
            get
            {
                return new ActionCommand(x => {
                    coffee = new Americano();
                    FillInData(coffee);
                });
            }
        }

        public ICommand Cappuccino
        {
            get
            {
                return new ActionCommand(x => {
                    coffee = new Cappuccino();
                    FillInData(coffee);
                });
            }
        }

        public ICommand Latte
        {
            get
            {
                return new ActionCommand(x => {
                    coffee = new Latte();
                    FillInData(coffee);
                });
            }
        }

        public ICommand Macchiato
        {
            get
            {                
                return new ActionCommand(x => {
                    coffee = new Macchiato();
                    FillInData(coffee);
                });
            }
        }

        public ICommand Finished
        {
            get
            {
                return new ActionCommand(x => {
                    coffee = null;
                    FillInData(coffee);
                });
            }
        }

        private void FillInData(ICoffee coffee)
        {
            if (coffee == null)
            {
                Name = null;
                Description = null;               
            }
            else
            {
                Name = coffee.Name();
                Description = coffee.Name();
            }            
            OnPropertyChanged();
        }
    }
}
