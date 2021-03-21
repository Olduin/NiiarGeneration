using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public partial class VehicleEditForm : Form
    {
        private VehicleEditContext vehicleEditContext;

        private Vehicle vehicle;

        public VehicleEditForm(VehicleEditContext vehicleEditContext, int rowIndex)
        {
            this.vehicleEditContext = vehicleEditContext;
            this.vehicle = vehicleEditContext.Vehincles[rowIndex];
            InitializeComponent();
            LoadData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK;
        }
        
        private void LoadData()
        {
            tbName.Text = vehicle.Name;
            tbStateNumber.Text = vehicle.state_Number;
        }
        
        private void SaveData()
        {
            vehicle.Name = tbName.Text;
            vehicle.state_Number = tbStateNumber.Text;
            
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                   
                
    }
}
