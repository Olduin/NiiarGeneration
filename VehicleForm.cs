using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiiarGeneration
{
    public partial class VehicleForm : Form
    {
        private VehicleEditContext vehicleEditContext;

        public VehicleForm(VehicleEditContext vehicleEditContext)
        {
            this.vehicleEditContext = vehicleEditContext;
            InitializeComponent();

            this.dgVehicle.DataSource = vehicleEditContext.Vehincles;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

        
}
