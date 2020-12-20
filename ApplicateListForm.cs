﻿using NiiarGeneration.Models;
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

            LoadCbTypes();
            
        }

        
        private void dgApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgApplications.Rows[e.RowIndex];

            long id = Convert.ToInt64(row.Cells[0].Value.ToString());

            ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
            
            applicationEditContext.Applicat = repository.ApplicatGet(id);

            using (ApplicatItemsForm editApplicatForm = new ApplicatItemsForm(applicationEditContext))
            {
                editApplicatForm.ShowDialog();

                if (editApplicatForm.DialogResult == DialogResult.OK)
                {
                    repository.ApplicateSave(applicationEditContext.Applicat);
                }
            }

        }

        private void btAddApplicat_Click_1(object sender, EventArgs e)
        {
            ApplicatEditContext applicatEditContext = new ApplicatEditContext(repository);

            applicatEditContext.Applicat = new Applicat();
                       
            using (ApplicatItemsForm ApplicatItemsForm = new ApplicatItemsForm(applicatEditContext))
            {
                ApplicatItemsForm.ShowDialog();

                if (ApplicatItemsForm.DialogResult == DialogResult.OK)
                {
                    repository.ApplicateAdd(applicatEditContext.Applicat);
                }
            }
        }

        private void btVehicles_Click(object sender, EventArgs e)
        {
            VehicleEditContext vehicleEditContext = new VehicleEditContext(repository);

            vehicleEditContext.Vehincles = repository.VehicleGetList();

            using (VehicleForm vehicleForm = new VehicleForm(vehicleEditContext))
            {
                vehicleForm.ShowDialog();

                /* if (vehicleForm.DialogResult == DialogResult.OK)
                {
                    repository.VehicleSave(vehicleEditContext.Vehincle);
                }*/
            }
        }

        private void LoadCbTypes()
        {
            ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
            cbType.SelectedIndex = -1;
            cbType.ComboBox.DisplayMember = "Name";
            cbType.ComboBox.ValueMember = "Id";
            cbType.ComboBox.DataSource = applicationEditContext.Types;
        }

        private void cbType_Click(object sender, EventArgs e)
        {
            ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
            //repository.ApplicatGet();
        }

        private void btType_Click(object sender, EventArgs e)
        {
            TypeContext typeContext = new TypeContext(repository);
            typeContext.Types = repository.GetTypesList();

            using (TypeForm typeForm = new TypeForm(typeContext))
            {
                typeForm.ShowDialog();

                if(typeForm.DialogResult == DialogResult.OK)
                {
                   // repository.ty
                }
            }
        }




        /* private void OpenApplicatEditForm(ApplicatItem applicatItem)
         {
             ApplicationEditContext applicationEditContext = new ApplicationEditContext
             {
                 ApplicatItems = applicatItem;}
                 //Vehincles = 
                 //VehinlesRepository.GetVehincles();
             }
         */
    }
}

