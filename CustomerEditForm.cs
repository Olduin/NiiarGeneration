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
    public partial class CustomerEditForm : Form
    {
        private CustomerEditContext customerEditContext;

        private Customer customer;

        public CustomerEditForm(CustomerEditContext customerEditContext, int rowIndex)
        {
            this.customerEditContext = customerEditContext;
            this.customer = customerEditContext.Customers[rowIndex];
            InitializeComponent();
            LoadData();
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            tbName.Text = customer.Name;
            tbResponsible.Text = customer.Responsible;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void SaveData()
        {
            customer.Name = tbName.Text;
            customer.Responsible = tbResponsible.Text;

        }
    }
}
