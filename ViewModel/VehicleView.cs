using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiiarGeneration.Models;


namespace NiiarGeneration.ViewModel
{
    public class VehicleView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Vehicle selectedVehicle;

        private VehicleEditContext vehicleEditContext;

        public List<Vehicle> Vehicles { get; set; }

        //public Vehicle SelectedVehicle
        //{
        //    get { return selectedVehicle; }
        //    set
        //    {
        //        selectedVehicle = value;


        //}

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VehicleView(VehicleEditContext vehicleEditContext)
        {
            this.vehicleEditContext = vehicleEditContext;
        }
    }
}
