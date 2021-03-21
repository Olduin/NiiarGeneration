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
    public partial class CustomerForm : Form
    {
        private CustomerEditContext customerEditContext;

        int currentCustomer;

        private BindingSource bindingSource;

        public CustomerForm(CustomerEditContext customerEditContext)
        {
            this.customerEditContext = customerEditContext;
            InitializeComponent();

            bindingSource = new BindingSource(customerEditContext, "Customers");
            this.dgCustomers.DataSource = bindingSource;
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            customerEditContext.Customers.Add(new Customer());
            bindingSource.ResetBindings(false);
        }

        private void LoadData()
        {

            this.dgCustomers.DataSource = customerEditContext.Customers;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            long delitedRowId = Convert.ToInt64(dgCustomers.CurrentRow.Cells[0].Value);


            Customer delitedTp = customerEditContext.Customers.FirstOrDefault(cm => cm.Id == delitedRowId);

            customerEditContext.Customers.Remove(delitedTp);

            dgCustomers.DataSource = customerEditContext.Customers;
            dgCustomers.Refresh();
        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentCustomer = e.RowIndex;
            CustomerEditForm customerEditForm= new CustomerEditForm(customerEditContext, currentCustomer);
            customerEditForm.ShowDialog();
        }
    }
}
