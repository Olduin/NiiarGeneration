using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiiarGeneration;

namespace NiiarGeneration
{
    public partial class TitleForm : Form
    {
        public TitleForm() 
        {            
            InitializeComponent();
            rtbTitle.SelectAll();
            rtbTitle.SelectionAlignment = HorizontalAlignment.Center;
            rtbTitle.DeselectAll();
            
               
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btForward_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
        }
    }
}
