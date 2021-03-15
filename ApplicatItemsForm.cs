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
    public partial class ApplicatItemsForm : Form
    {
        private ApplicatEditContext applicatEditContext;

        private BindingSource bindingSource;

        public ApplicatItemsForm(ApplicatEditContext applicatEditContext)
        {
            this.applicatEditContext = applicatEditContext;
            InitializeComponent();

            tbId.DataBindings.Add("Text", applicatEditContext.Applicat, "Id");

            mkApplicate.DataBindings.Add("Text", applicatEditContext.Applicat, "Date");

            cbTypeApplicate.DisplayMember = "Name";
            cbTypeApplicate.ValueMember = "Id";
            cbTypeApplicate.DataSource = applicatEditContext.Types;



            //this.dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
            bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");
            this.dgApplicat.DataSource = bindingSource;
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
         
            /*ApplicatItem applicatItem = new ApplicatItem();
                        ApplicateEditForm applicateEditForm = new ApplicateEditForm(applicatEditContext);
                        applicateEditForm.ShowDialog();
                        */
            if(applicatEditContext.Applicat == null)
            {
                applicatEditContext.Applicat = new Applicat();
            }

            applicatEditContext.Applicat.ApplicatItems.Add(new ApplicatItem());

           // dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
            bindingSource.ResetBindings(false);
           

        }

        private void cbTypeApplicate_SelectedIndexChanged(object sender, EventArgs e)
        {
            applicatEditContext.Applicat.Type = cbTypeApplicate.SelectedItem as TypeApplicat;
        }

        private void btDelete_Click(object sender, EventArgs e, DataGridViewCellEventArgs d)
        {
            /*DataGridViewRow row = dgApplicat.Rows[d.RowIndex];
            applicatEditContext.Applicat.ApplicatItems.Remove(applicatEditContext.Applicat.ApplicatItems[Convert.ToInt32(row.ToString())]);
            */
            bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");
            bindingSource.Remove(dgApplicat.Rows[d.RowIndex]);

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            long delitedRowId = Convert.ToInt64(dgApplicat.CurrentRow.Cells[0].Value);

            
            ApplicatItem delitedAI = applicatEditContext.Applicat.ApplicatItems.FirstOrDefault(ai => ai.Id == delitedRowId);

            applicatEditContext.Applicat.ApplicatItems.Remove(delitedAI);

            dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
            dgApplicat.Refresh();
        }

        private void ApplicatItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void dgApplicat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplicateEditForm applicateEditForm = new ApplicateEditForm(applicatEditContext, e.RowIndex);
            applicateEditForm.ShowDialog();
        }
    }
}
