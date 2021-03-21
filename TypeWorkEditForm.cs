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
    public partial class TypeWorkEditForm : Form
    {
        TypeWorkContext typeWorkContext;
        TypeWork typeWork;

        public TypeWorkEditForm(TypeWorkContext typeWorkContext, int rowIndex)
        {
            this.typeWorkContext = typeWorkContext;
            this.typeWork = typeWorkContext.TypeWorks[rowIndex];
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            tbName.Text = typeWork.Name;
        }

        private void SaveData()
        {
            typeWork.Name = tbName.Text;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
