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
    public partial class ApplicateEditForm : Form
    {
        
        private ApplicatEditContext applicationEditContext;

        private ApplicatItem applicatItem;
      
        public ApplicateEditForm(ApplicatEditContext applicationEditContext, int rowIndex)
        {
            this.applicationEditContext = applicationEditContext;
                        
            this.applicatItem = applicationEditContext.Applicat.ApplicatItems[rowIndex] ;
            InitializeComponent();

            LoadData();
        }

        public ApplicateEditForm(ApplicatEditContext applicationEditContext)
        {
            this.applicationEditContext = applicationEditContext;
            //this.applicatItem = applicationEditContext.Applicat.ApplicatItems.Add(new applicatItem);
            applicationEditContext.Applicat.ApplicatItems.Add(applicatItem);
            InitializeComponent();

            LoadData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK;            
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadData()
        {
            tbIdItem.Text = applicatItem.Id.ToString();
            
            tbResponsibleCustomer.Text = applicatItem.Responsible_Customer;
            tbDescriptionWork.Text = applicatItem.Description_Work;
                        
            tbDeliveryAddress.Text = applicatItem.Delivery_Address;
            tbDuration_Of_Use.Text = applicatItem.Duration_Of_Use.ToString();

            cbVehicle.SelectedText = applicatItem.Vehicle?.Name;                    
            cbVehicle.DisplayMember = "Name";
            cbVehicle.ValueMember = "id";
            cbVehicle.DataSource = applicationEditContext.Vehincles;

            tbStateNumber.Text = applicatItem.Vehicle?.state_Number;


            if (applicatItem.Time_Of_Filing != null)
            {
                dtTime_Of_Filing.Value = (DateTime)applicatItem.Time_Of_Filing;
            }
            else
            {
                dtTime_Of_Filing.Value = DateTime.Now;
            }


        }

        private void SaveData()
        {
            applicatItem.Responsible_Customer = tbResponsibleCustomer.Text;
            applicatItem.Description_Work = tbResponsibleCustomer.Text;
            applicatItem.Vehicle = cbVehicle.SelectedItem as Vehicle;
            //applicatItem.Vehicle.state_Number 
            applicatItem.Time_Of_Filing = dtTime_Of_Filing.Value;
            applicatItem.Duration_Of_Use = Convert.ToInt32(tbDuration_Of_Use.Text);
            applicatItem.Delivery_Address = tbDeliveryAddress.Text;
        }
        
    }
}

