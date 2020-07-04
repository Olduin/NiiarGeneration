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
    }
}
