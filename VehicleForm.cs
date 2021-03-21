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
using NiiarGeneration.ViewModel;

namespace NiiarGeneration
{
    public partial class VehicleForm : Form
    {
        private VehicleEditContext vehicleEditContext;

     
        int currentVehicle;

        private BindingSource bindingSource;

        public VehicleForm(VehicleEditContext vehicleEditContext)
        {
            this.vehicleEditContext = vehicleEditContext;
            InitializeComponent();

            bindingSource = new BindingSource(vehicleEditContext, "Vehincles");
            this.dgVehicle.DataSource = bindingSource;

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
            bindingSource.ResetBindings(false);            
        }
                  
        private void LoadData()
        {

            this.dgVehicle.DataSource = vehicleEditContext.Vehincles;
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }

        private void btCansel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btDelete_(object sender, DataGridViewCellEventArgs c)
        {
            this.vehicleEditContext = vehicleEditContext;
            DataGridViewRow row = dgVehicle.Rows[c.RowIndex];

            vehicleEditContext.Vehincles.Remove(vehicleEditContext.Vehincles[Convert.ToInt32(row)]);

            // vehicleEditContext.reposi //repository.DeleteVehile(vehicleEditContext, Convert.ToInt32(currentVehicle));

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
                long delitedRowId = Convert.ToInt64(dgVehicle.CurrentRow.Cells[0].Value);


                Vehicle delitedVh = vehicleEditContext.Vehincles.FirstOrDefault(vh => vh.Id == delitedRowId);

                vehicleEditContext.Vehincles.Remove(delitedVh);

                dgVehicle.DataSource = vehicleEditContext.Vehincles;
                dgVehicle.Refresh();
            }
        }

        /* private void btDelete_Click(object sender, EventArgs e)
         {
             this.Click += btDelete_(this.btDelete_Click);
         }*/
    

}
