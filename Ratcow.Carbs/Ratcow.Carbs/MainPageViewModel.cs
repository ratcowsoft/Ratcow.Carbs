using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ratcow.Carbs
{
    public interface IMainPageViewModel : INotifyPropertyChanged
    {
        ICommand Calculate { get; }
        ICommand Clear { get; }

        float Carbs { get; set; }
        float Weight { get; set; }
        float NewWeight { get; set; }
        float Result { get; set; }
    }

    public class MainPageViewModel : BaseViewModel, IMainPageViewModel
    {
        public MainPageViewModel()
        {
            Calculate = new Command(
                () => 
                {
                    if(weight > 0 && carbs > 0)
                    {
                        Result = (carbs / weight) * newWeight;
                    }
                });

            Clear = new Command(() => 
            {
                Result = 0F;
                Weight = 0F;
                Carbs = 0F;
                NewWeight = 0F;
            });
        }

        public ICommand Calculate { get; private set; } = null;
        public ICommand Clear { get; private set; } = null;

        float carbs = 0F;
        public float Carbs
        {
            get => carbs;
            set
            {
                carbs = value;
                OnPropertyChanged();
            }
        }

        float weight = 0F;
        public float Weight
        {
            get => weight;
            set
            {
                weight = value;
                OnPropertyChanged();
                OnPropertyChanged("Calculate");
            }
        }

        float newWeight = 0F;
        public float NewWeight
        {
            get => newWeight;
            set
            {
                newWeight = value;
                OnPropertyChanged();
                OnPropertyChanged("Calculate");
            }
        }

        float result = 0F;
        public float Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }
    }
}
