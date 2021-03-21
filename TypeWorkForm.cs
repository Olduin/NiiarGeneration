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
    public partial class TypeWorkForm : Form
    {
      
        private VehicleEditContext vehicleEditContext;

        private TypeWorkContext typeWorkContext;

        int currentTypeWork;

        private BindingSource bindingSource;

        public TypeWorkForm(TypeWorkContext typeWorkContext)
        {
            this.typeWorkContext = typeWorkContext;
            InitializeComponent();

            bindingSource = new BindingSource(typeWorkContext, "TypeWorks");
            this.dgTypeWorks.DataSource = bindingSource;

        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            typeWorkContext.TypeWorks.Add(new TypeWork());
            bindingSource.ResetBindings(false);
        }

        private void dgTypeWorks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentTypeWork = e.RowIndex;
            TypeWorkEditForm typeWorkEditForm = new TypeWorkEditForm(typeWorkContext, e.RowIndex);
            typeWorkEditForm.ShowDialog();
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {

            this.dgTypeWorks.DataSource = typeWorkContext.TypeWorks;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            long delitedRowId = Convert.ToInt64(dgTypeWorks.CurrentRow.Cells[0].Value);


            TypeWork delitedTp = typeWorkContext.TypeWorks.FirstOrDefault(tp => tp.Id == delitedRowId);

            typeWorkContext.TypeWorks.Remove(delitedTp);

            dgTypeWorks.DataSource = typeWorkContext.TypeWorks;
            dgTypeWorks.Refresh();
        }
    }
}
        
