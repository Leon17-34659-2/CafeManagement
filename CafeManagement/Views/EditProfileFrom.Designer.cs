namespace CafeManagement.Views
{
    partial class EditProfileFrom
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
            this.buttonChngName = new System.Windows.Forms.Button();
            this.buttonDelAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChngName
            // 
            this.buttonChngName.BackColor = System.Drawing.SystemColors.Info;
            this.buttonChngName.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChngName.ForeColor = System.Drawing.Color.Green;
            this.buttonChngName.Location = new System.Drawing.Point(257, 163);
            this.buttonChngName.Name = "buttonChngName";
            this.buttonChngName.Size = new System.Drawing.Size(191, 43);
            this.buttonChngName.TabIndex = 5;
            this.buttonChngName.Text = "Change Name";
            this.buttonChngName.UseVisualStyleBackColor = false;
            // 
            // buttonDelAcc
            // 
            this.buttonDelAcc.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDelAcc.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelAcc.ForeColor = System.Drawing.Color.Green;
            this.buttonDelAcc.Location = new System.Drawing.Point(257, 114);
            this.buttonDelAcc.Name = "buttonDelAcc";
            this.buttonDelAcc.Size = new System.Drawing.Size(191, 43);
            this.buttonDelAcc.TabIndex = 4;
            this.buttonDelAcc.Text = "Delete Account";
            this.buttonDelAcc.UseVisualStyleBackColor = false;
            this.buttonDelAcc.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditProfileFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChngName);
            this.Controls.Add(this.buttonDelAcc);
            this.Name = "EditProfileFrom";
            this.Text = "EditProfileFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChngName;
        private System.Windows.Forms.Button buttonDelAcc;
    }
}