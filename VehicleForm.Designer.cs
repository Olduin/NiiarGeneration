
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
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(133, 266);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(113, 23);
            this.btDelete.TabIndex = 26;
            this.btDelete.Text = "Удалить строку";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btAddItem
            // 
            this.btAddItem.Location = new System.Drawing.Point(14, 266);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(113, 23);
            this.btAddItem.TabIndex = 25;
            this.btAddItem.Text = "Добавить строку";
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // dgVehicle
            // 
            this.dgVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehicle.Location = new System.Drawing.Point(0, 0);
            this.dgVehicle.Name = "dgVehicle";
            this.dgVehicle.Size = new System.Drawing.Size(849, 253);
            this.dgVehicle.TabIndex = 24;
            this.dgVehicle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehicle_CellContentClick);
            // 
            // btCansel
            // 
            this.btCansel.Location = new System.Drawing.Point(750, 266);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 23);
            this.btCansel.TabIndex = 22;
            this.btCansel.Text = "Отмена";
            this.btCansel.UseVisualStyleBackColor = true;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(647, 266);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 308);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddItem);
            this.Controls.Add(this.dgVehicle);
            this.Controls.Add(this.btCansel);
            this.Controls.Add(this.btSave);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.DataGridView dgVehicle;
        private System.Windows.Forms.Button btCansel;
        private System.Windows.Forms.Button btSave;
    }
}