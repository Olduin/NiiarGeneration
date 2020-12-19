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
    public partial class VehicleForm : Form
    {
        private VehicleEditContext vehicleEditContext;
     
        int currentVehicle;

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

        private void dgVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentVehicle = e.RowIndex;
            VehicleEditForm vehicleEditForm = new VehicleEditForm(vehicleEditContext, e.RowIndex);
            vehicleEditForm.ShowDialog();
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            vehicleEditContext.Vehincles.Add(new Vehicle() );
            //LoadCbTypes();
            dgVehicle.Refresh();
            
        }

        
        private void btDelete_Click_1(object sender, EventArgs e)
        {
            this.vehicleEditContext = vehicleEditContext;
            //DataGridViewRow row = dgVehicle.Rows[c.RowIndex];

            //vehicleEditContext.Vehincles.Remove(vehicleEditContext.Vehincles[ Convert.ToInt32(row)]);
             
              // vehicleEditContext.reposi //repository.DeleteVehile(vehicleEditContext, Convert.ToInt32(currentVehicle));

        }

        private void LoadData()
        {

            this.dgVehicle.DataSource = vehicleEditContext.Vehincles;
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }
    }

}
