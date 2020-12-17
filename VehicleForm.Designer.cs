
namespace NiiarGeneration
{
    partial class VehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.dgVehicle = new System.Windows.Forms.DataGridView();
            this.btCansel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbTypeApplicate = new System.Windows.Forms.ComboBox();
            this.lbTypeApplicat = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(133, 345);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(113, 23);
            this.btDelete.TabIndex = 26;
            this.btDelete.Text = "Удалить строку";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btAddItem
            // 
            this.btAddItem.Location = new System.Drawing.Point(14, 345);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(113, 23);
            this.btAddItem.TabIndex = 25;
            this.btAddItem.Text = "Добавить строку";
            this.btAddItem.UseVisualStyleBackColor = true;
            // 
            // dgVehicle
            // 
            this.dgVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehicle.Location = new System.Drawing.Point(0, 68);
            this.dgVehicle.Name = "dgVehicle";
            this.dgVehicle.Size = new System.Drawing.Size(849, 253);
            this.dgVehicle.TabIndex = 24;
            // 
            // btCansel
            // 
            this.btCansel.Location = new System.Drawing.Point(750, 345);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 23);
            this.btCansel.TabIndex = 22;
            this.btCansel.Text = "Отмена";
            this.btCansel.UseVisualStyleBackColor = true;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(647, 345);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbTypeApplicate
            // 
            this.cbTypeApplicate.FormattingEnabled = true;
            this.cbTypeApplicate.Location = new System.Drawing.Point(107, 23);
            this.cbTypeApplicate.Name = "cbTypeApplicate";
            this.cbTypeApplicate.Size = new System.Drawing.Size(164, 21);
            this.cbTypeApplicate.TabIndex = 20;
            // 
            // lbTypeApplicat
            // 
            this.lbTypeApplicat.AutoSize = true;
            this.lbTypeApplicat.Location = new System.Drawing.Point(114, 7);
            this.lbTypeApplicat.Name = "lbTypeApplicat";
            this.lbTypeApplicat.Size = new System.Drawing.Size(26, 13);
            this.lbTypeApplicat.TabIndex = 18;
            this.lbTypeApplicat.Text = "Тип";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(7, 7);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(80, 13);
            this.lbId.TabIndex = 17;
            this.lbId.Text = "Номер заявки";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(10, 23);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(91, 20);
            this.tbId.TabIndex = 16;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 379);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddItem);
            this.Controls.Add(this.dgVehicle);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbTypeApplicate);
            this.Controls.Add(this.lbTypeApplicat);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.DataGridView dgVehicle;
        private System.Windows.Forms.Button btCansel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbTypeApplicate;
        private System.Windows.Forms.Label lbTypeApplicat;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
    }
}