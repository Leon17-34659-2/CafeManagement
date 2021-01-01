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
            this.buttonChng = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonSaveName = new System.Windows.Forms.Button();
            this.buttonSavePass = new System.Windows.Forms.Button();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.buttonChngPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChng
            // 
            this.buttonChng.BackColor = System.Drawing.Color.Teal;
            this.buttonChng.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChng.ForeColor = System.Drawing.Color.White;
            this.buttonChng.Location = new System.Drawing.Point(12, 38);
            this.buttonChng.Name = "buttonChng";
            this.buttonChng.Size = new System.Drawing.Size(202, 47);
            this.buttonChng.TabIndex = 15;
            this.buttonChng.Text = "  Change Name  ";
            this.buttonChng.UseVisualStyleBackColor = false;
            this.buttonChng.Click += new System.EventHandler(this.ChngBtn_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Enabled = false;
            this.textBoxNewName.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(229, 46);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(181, 27);
            this.textBoxNewName.TabIndex = 16;
            // 
            // buttonSaveName
            // 
            this.buttonSaveName.BackColor = System.Drawing.Color.Green;
            this.buttonSaveName.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveName.ForeColor = System.Drawing.Color.White;
            this.buttonSaveName.Location = new System.Drawing.Point(428, 38);
            this.buttonSaveName.Name = "buttonSaveName";
            this.buttonSaveName.Size = new System.Drawing.Size(181, 47);
            this.buttonSaveName.TabIndex = 17;
            this.buttonSaveName.Text = "Save Name";
            this.buttonSaveName.UseVisualStyleBackColor = false;
            this.buttonSaveName.Click += new System.EventHandler(this.buttonSaveName_Click);
            // 
            // buttonSavePass
            // 
            this.buttonSavePass.BackColor = System.Drawing.Color.Green;
            this.buttonSavePass.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePass.ForeColor = System.Drawing.Color.White;
            this.buttonSavePass.Location = new System.Drawing.Point(624, 97);
            this.buttonSavePass.Name = "buttonSavePass";
            this.buttonSavePass.Size = new System.Drawing.Size(153, 44);
            this.buttonSavePass.TabIndex = 20;
            this.buttonSavePass.Text = "Save Password";
            this.buttonSavePass.UseVisualStyleBackColor = false;
            this.buttonSavePass.Click += new System.EventHandler(this.buttonSavePass_Click);
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPass.Location = new System.Drawing.Point(229, 107);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '#';
            this.textBoxOldPass.Size = new System.Drawing.Size(181, 27);
            this.textBoxOldPass.TabIndex = 19;
            // 
            // buttonChngPass
            // 
            this.buttonChngPass.BackColor = System.Drawing.Color.Teal;
            this.buttonChngPass.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChngPass.ForeColor = System.Drawing.Color.White;
            this.buttonChngPass.Location = new System.Drawing.Point(12, 97);
            this.buttonChngPass.Name = "buttonChngPass";
            this.buttonChngPass.Size = new System.Drawing.Size(202, 44);
            this.buttonChngPass.TabIndex = 18;
            this.buttonChngPass.Text = "Change Password";
            this.buttonChngPass.UseVisualStyleBackColor = false;
            this.buttonChngPass.Click += new System.EventHandler(this.buttonChngPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Old Password";
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(428, 107);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(181, 27);
            this.textBoxNewPass.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "New Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "Delete Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // EditProfileFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSavePass);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.buttonChngPass);
            this.Controls.Add(this.buttonSaveName);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.buttonChng);
            this.Name = "EditProfileFrom";
            this.Text = "EditProfileFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChng;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button buttonSaveName;
        private System.Windows.Forms.Button buttonSavePass;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.Button buttonChngPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}