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
        
        public ApplicatItemsForm(ApplicatEditContext applicatEditContext)
        {
            this.applicatEditContext = applicatEditContext;
            InitializeComponent();

            tbId.DataBindings.Add("Text", applicatEditContext.Applicat, "Id");

            mkApplicate.DataBindings.Add("Text", applicatEditContext.Applicat, "Date");

            cbTypeApplicate.DisplayMember = "Name";
            cbTypeApplicate.ValueMember = "Id";
            cbTypeApplicate.DataSource = applicatEditContext.Types;



            this.dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
        }

        
        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void dgApplicat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                        
            ApplicateEditForm applicateEditForm = new ApplicateEditForm(applicatEditContext, e.RowIndex);
            applicateEditForm.ShowDialog();

        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            /*ApplicatItem applicatItem = new ApplicatItem();
                        ApplicateEditForm applicateEditForm = new ApplicateEditForm(applicatEditContext);
                        applicateEditForm.ShowDialog();
                        */

            applicatEditContext.Applicat.ApplicatItems.Add(new ApplicatItem());
            
        }

        private void cbTypeApplicate_SelectedIndexChanged(object sender, EventArgs e)
        {
            applicatEditContext.Applicat.Type = cbTypeApplicate.SelectedItem as TypeApplicat;
        }
    }
}
