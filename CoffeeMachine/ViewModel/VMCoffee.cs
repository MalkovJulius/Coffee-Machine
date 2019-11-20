using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using CoffeeMachine.Model;
using CoffeeMachine.Support;

namespace CoffeeMachine.ViewModel
{
    public class VMCoffee:INotifyPropertyChanged
    {        
        private ICoffee coffee;
        private string name;
        private string description;

        private double cost;
        private double volume;
        private List<double> list;

        private readonly CollectionView collectionView; 
        public VMCoffee()
        {
            list = new List<double>();
            list.Add(0.2);
            list.Add(0.5);
            list.Add(0.7);
            collectionView = new CollectionView(list);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        
        public CollectionView CollectionView
        {
            get => collectionView;
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
        }

        public double Volume
        {
            get => volume;
            set
            {
                volume = value;
                if(coffee!=null)
                    Cost = coffee.Cost(volume);
                OnPropertyChanged();
            }
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

        public ICommand Doppio
        {
            get
            {
                return new ActionCommand(x => {
                    coffee = new Doppio();
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
                Cost = 0;
            }
            else
            {
                Name = coffee.Name();
                Description = coffee.Description();
                Cost = coffee.Cost(volume);
            }            
            OnPropertyChanged();
        }
    }
}
