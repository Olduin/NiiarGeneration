namespace NiiarGeneration
{
    partial class ApplicatItemsForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTypeApplicat = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cbTypeApplicate = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCansel = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.mkApplicate = new System.Windows.Forms.MaskedTextBox();
            this.dgApplicat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgApplicat)).BeginInit();
            this.SuspendLayout();
            // 
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(12, 25);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(91, 20);
            this.tbId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(9, 9);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(80, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Номер заявки";
            // 
            // lbTypeApplicat
            // 
            this.lbTypeApplicat.AutoSize = true;
            this.lbTypeApplicat.Location = new System.Drawing.Point(116, 9);
            this.lbTypeApplicat.Name = "lbTypeApplicat";
            this.lbTypeApplicat.Size = new System.Drawing.Size(26, 13);
            this.lbTypeApplicat.TabIndex = 3;
            this.lbTypeApplicat.Text = "Тип";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(276, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(72, 13);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Дата заявки";
            // 
            // cbTypeApplicate
            // 
            this.cbTypeApplicate.FormattingEnabled = true;
            this.cbTypeApplicate.Location = new System.Drawing.Point(109, 25);
            this.cbTypeApplicate.Name = "cbTypeApplicate";
            this.cbTypeApplicate.Size = new System.Drawing.Size(164, 21);
            this.cbTypeApplicate.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(647, 306);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCansel
            // 
            this.btCansel.Location = new System.Drawing.Point(750, 306);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 23);
            this.btCansel.TabIndex = 9;
            this.btCansel.Text = "Отмена";
            this.btCansel.UseVisualStyleBackColor = true;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // mkApplicate
            // 
            this.mkApplicate.Location = new System.Drawing.Point(279, 26);
            this.mkApplicate.Mask = "00/00/0000";
            this.mkApplicate.Name = "mkApplicate";
            this.mkApplicate.Size = new System.Drawing.Size(100, 20);
            this.mkApplicate.TabIndex = 11;
            this.mkApplicate.ValidatingType = typeof(System.DateTime);
            // 
            // dgApplicat
            // 
            this.dgApplicat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApplicat.Location = new System.Drawing.Point(2, 70);
            this.dgApplicat.Name = "dgApplicat";
            this.dgApplicat.Size = new System.Drawing.Size(842, 214);
            this.dgApplicat.TabIndex = 12;
            // 
            // ApplicatEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 341);
            this.Controls.Add(this.dgApplicat);
            this.Controls.Add(this.mkApplicate);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbTypeApplicate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTypeApplicat);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Name = "ApplicatEditForm";
            this.Text = "EditApplicat";
            ((System.ComponentModel.ISupportInitialize)(this.dgApplicat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTypeApplicat;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbTypeApplicate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCansel;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.MaskedTextBox mkApplicate;
        private System.Windows.Forms.DataGridView dgApplicat;
    }
}