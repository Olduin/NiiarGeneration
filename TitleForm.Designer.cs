using System.Windows.Forms;

namespace NiiarGeneration
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            this.rtbTitle = new System.Windows.Forms.RichTextBox();
            this.btForward = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTitle
            // 
            this.rtbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTitle.Location = new System.Drawing.Point(0, 0);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbTitle.Size = new System.Drawing.Size(800, 478);
            this.rtbTitle.TabIndex = 0;
            this.rtbTitle.Text = resources.GetString("rtbTitle.Text");
            // 
            // btForward
            // 
            this.btForward.Location = new System.Drawing.Point(608, 443);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(87, 23);
            this.btForward.TabIndex = 1;
            this.btForward.Text = "Продолжить";
            this.btForward.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(701, 443);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // TitleForm
            // 
            this.AcceptButton = this.btForward;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.rtbTitle);
            this.Name = "TitleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTitle;
        private Button btForward;
        private Button btExit;
    }
}