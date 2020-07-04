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
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            //InitializeComponent();
            //foreach (var line in rtbTitle.Lines)
            //{
            //    //line.selectionAlignment = HorizontalAlignment.Center;
            //}        
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
