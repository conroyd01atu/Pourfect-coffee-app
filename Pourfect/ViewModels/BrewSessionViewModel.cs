using System.ComponentModel;

namespace Pourfect.ViewModels
{
    public class BrewSessionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _waterAmount;
        public double WaterAmount
        {
            get => _waterAmount;
            set
            {
                _waterAmount = value;
                OnPropertyChanged(nameof(WaterAmount));
            }
        }

        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}