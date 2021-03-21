
namespace NiiarGeneration
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.btCansel = new System.Windows.Forms.Button();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btSave);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btDelete);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btAddItem);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btCansel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgCustomers);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(719, 287);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripContainer1.Size = new System.Drawing.Size(719, 312);
            this.toolStripContainer1.TabIndex = 28;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btSave
            // 
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(543, 284);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 1);
            this.btSave.TabIndex = 31;
            this.btSave.Text = "Сохранить";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDelete.Location = new System.Drawing.Point(113, 284);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(113, 1);
            this.btDelete.TabIndex = 30;
            this.btDelete.Text = "Списать технику";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAddItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAddItem.Location = new System.Drawing.Point(0, 284);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(113, 1);
            this.btAddItem.TabIndex = 29;
            this.btAddItem.Text = "Добавить технику";
            this.btAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // btCansel
            // 
            this.btCansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCansel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCansel.Location = new System.Drawing.Point(630, 284);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(87, 1);
            this.btCansel.TabIndex = 28;
            this.btCansel.Text = "Отмена";
            this.btCansel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCansel.UseVisualStyleBackColor = true;
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // dgCustomers
            // 
            this.dgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.Size = new System.Drawing.Size(717, 284);
            this.dgCustomers.TabIndex = 24;
            this.dgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentClick);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 312);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "Заявители";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.Button btCansel;
        private System.Windows.Forms.DataGridView dgCustomers;
    }
}