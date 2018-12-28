using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ratcow.Carbs
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
          => this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
          => this.PropertyChanged?.Invoke(this, e);
    }
}
