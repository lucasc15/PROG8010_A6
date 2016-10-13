using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KineticEnergy
{
    class ViewModel : ObservableObject
    {
        private string _mass;
        public string mass
        {
            get { return _mass; }
            set { _mass = value; OnPropertyChanged(); }
        }
        private string _velocity;
        public string velocity
        {
            get { return _velocity; }
            set { _velocity = value; OnPropertyChanged(); }
        }
        private string _kineticEnergy;
        public string kineticEnergy
        {
            get { return _kineticEnergy; }
            set { _kineticEnergy = value; OnPropertyChanged(); }
        }

        public void calcKineticEnergy()
        {
            double kineticEnergyF;
            double massF = double.Parse(_mass);
            double velocityF = double.Parse(_velocity);
            kineticEnergyF = Math.Pow(velocityF, 2) * massF * 0.5;
            kineticEnergy = kineticEnergyF.ToString() + " (J)";
        }
    }
}
