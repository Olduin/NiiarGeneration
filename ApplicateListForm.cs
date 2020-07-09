using NiiarGeneration.Models;
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
    public partial class ApplicateListForm : Form
    {
        private Repository repository;

        public ApplicateListForm(Repository repository)
        {
            this.repository = repository;
            InitializeComponent();
            this.dgApplications.DataSource = repository.ApplicatGetList();
        }

        private void btAddApplicat_Click(object sender, EventArgs e)
        {
            Applicat applicat = new Applicat();

            using (ApplicatEditForm editApplicatForm = new ApplicatEditForm(applicat))
            {
                editApplicatForm.ShowDialog();

                if( editApplicatForm.DialogResult == DialogResult.OK)
                {
                    repository.ApplicateAdd(applicat);
                }
            }
        }

        private void dgApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgApplications.Rows[e.RowIndex];

            long id = Convert.ToInt64(row.Cells[0].Value.ToString());

            Applicat applicat = repository.ApplicatGet(id);

            using (ApplicatEditForm editApplicatForm = new ApplicatEditForm(applicat))
            {
                editApplicatForm.ShowDialog();

                if (editApplicatForm.DialogResult == DialogResult.OK)
                {
                    repository.ApplicateSave(applicat);
                }
            }

        }

    }
}
