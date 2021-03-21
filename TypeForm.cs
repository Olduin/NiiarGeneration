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
    public partial class TypeForm : Form
    {
        private TypeContext typeContext;

        int currentType;

        private BindingSource bindingSource;

        public TypeForm(TypeContext typeContext)
        {
            this.typeContext = typeContext;
            InitializeComponent();

            bindingSource = new BindingSource(typeContext, "Types");
            this.dgType.DataSource = bindingSource;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            typeContext.Types.Add(new TypeApplicat());
            bindingSource.ResetBindings(false);
        }

        private void LoadData()
        {

            this.dgType.DataSource = typeContext.Types;
        }

        private void dgType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentType = e.RowIndex;
            TypeEditForm typeEditForm = new TypeEditForm(typeContext, currentType);
            typeEditForm.ShowDialog();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            long delitedRowId = Convert.ToInt64(dgType.CurrentRow.Cells[0].Value);


           TypeApplicat delitedTp = typeContext.Types.FirstOrDefault(tp => tp.Id == delitedRowId);

            typeContext.Types.Remove(delitedTp);

            dgType.DataSource = typeContext.Types;
            dgType.Refresh();
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
