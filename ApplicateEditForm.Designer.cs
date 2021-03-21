
namespace NiiarGeneration
{
    partial class ApplicateEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicateEditForm));
            this.tbIdItem = new System.Windows.Forms.TextBox();
            this.tbStateNumber = new System.Windows.Forms.TextBox();
            this.tbDeliveryAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.dtTime_Of_Filing = new System.Windows.Forms.DateTimePicker();
            this.btCansel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbTypeWork = new System.Windows.Forms.ComboBox();
            this.dtEnd_time_of_work = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbIdItem
            // 
            this.tbIdItem.Location = new System.Drawing.Point(166, 12);
            this.tbIdItem.Name = "tbIdItem";
            this.tbIdItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIdItem.Size = new System.Drawing.Size(138, 20);
            this.tbIdItem.TabIndex = 0;
            // 
            // tbStateNumber
            // 
            this.tbStateNumber.Location = new System.Drawing.Point(166, 38);
            this.tbStateNumber.Name = "tbStateNumber";
            this.tbStateNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbStateNumber.Size = new System.Drawing.Size(427, 20);
            this.tbStateNumber.TabIndex = 1;
            this.tbStateNumber.Text = "--------";
            // 
            // tbDeliveryAddress
            // 
            this.tbDeliveryAddress.Location = new System.Drawing.Point(166, 194);
            this.tbDeliveryAddress.Name = "tbDeliveryAddress";
            this.tbDeliveryAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDeliveryAddress.Size = new System.Drawing.Size(427, 20);
            this.tbDeliveryAddress.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "№ п/п.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Гос. номер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 67);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Заявитель";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Наименование спецтехнии";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 119);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Описание проводимых работ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 148);
            this.label6.MaximumSize = new System.Drawing.Size(200, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Время подачи автотранспорта";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 168);
            this.label7.MaximumSize = new System.Drawing.Size(150, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Продолжительность использования";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 197);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Адрес подачи автотранспорта";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(167, 91);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbVehicle.Size = new System.Drawing.Size(426, 21);
            this.cbVehicle.TabIndex = 16;
            // 
            // dtTime_Of_Filing
            // 
            this.dtTime_Of_Filing.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime_Of_Filing.Location = new System.Drawing.Point(166, 142);
            this.dtTime_Of_Filing.Name = "dtTime_Of_Filing";
            this.dtTime_Of_Filing.ShowUpDown = true;
            this.dtTime_Of_Filing.Size = new System.Drawing.Size(138, 20);
            this.dtTime_Of_Filing.TabIndex = 17;
            // 
            // btCansel
            // 
            this.btCansel.Location = new System.Drawing.Point(506, 220);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 23);
            this.btCansel.TabIndex = 19;
            this.btCansel.Text = "Отмена";
            this.btCansel.UseVisualStyleBackColor = true;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(403, 220);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 23);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(167, 64);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCustomer.Size = new System.Drawing.Size(426, 21);
            this.cbCustomer.TabIndex = 20;
            // 
            // cbTypeWork
            // 
            this.cbTypeWork.FormattingEnabled = true;
            this.cbTypeWork.Location = new System.Drawing.Point(167, 116);
            this.cbTypeWork.Name = "cbTypeWork";
            this.cbTypeWork.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTypeWork.Size = new System.Drawing.Size(426, 21);
            this.cbTypeWork.TabIndex = 21;
            // 
            // dtEnd_time_of_work
            // 
            this.dtEnd_time_of_work.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtEnd_time_of_work.Location = new System.Drawing.Point(166, 168);
            this.dtEnd_time_of_work.Name = "dtEnd_time_of_work";
            this.dtEnd_time_of_work.ShowUpDown = true;
            this.dtEnd_time_of_work.Size = new System.Drawing.Size(138, 20);
            this.dtEnd_time_of_work.TabIndex = 22;
            // 
            // ApplicateEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 251);
            this.Controls.Add(this.dtEnd_time_of_work);
            this.Controls.Add(this.cbTypeWork);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dtTime_Of_Filing);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDeliveryAddress);
            this.Controls.Add(this.tbStateNumber);
            this.Controls.Add(this.tbIdItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicateEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Редактирование строки";
            this.Load += new System.EventHandler(this.ApplicateEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdItem;
        private System.Windows.Forms.TextBox tbStateNumber;
        private System.Windows.Forms.TextBox tbDeliveryAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.DateTimePicker dtTime_Of_Filing;
        private System.Windows.Forms.Button btCansel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbTypeWork;
        private System.Windows.Forms.DateTimePicker dtEnd_time_of_work;
    }
}