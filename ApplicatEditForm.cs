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
    public partial class ApplicatEditForm : Form
    {
        Applicat applicat;

        public ApplicatEditForm(Applicat applicat)
        {
            this.applicat = applicat;
            InitializeComponent();

            tbId.DataBindings.Add("Text", applicat, "Id");

            mkApplicate.DataBindings.Add("Text", applicat, "Date");

            cbTypeApplicate.DisplayMember = "тип";
            cbTypeApplicate.ValueMember = "Id";
            cbTypeApplicate.DataSource = applicat.Type;



            this.dgApplicat.DataSource = applicat.ApplicatItems;
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
