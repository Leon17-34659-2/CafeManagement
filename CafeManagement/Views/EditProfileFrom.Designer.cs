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
            this.buttonChng.Location = new System.Drawing.Point(9, 31);
            this.buttonChng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChng.Name = "buttonChng";
            this.buttonChng.Size = new System.Drawing.Size(152, 38);
            this.buttonChng.TabIndex = 15;
            this.buttonChng.Text = "  Change Name  ";
            this.buttonChng.UseVisualStyleBackColor = false;
            this.buttonChng.Click += new System.EventHandler(this.ChngBtn_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Enabled = false;
            this.textBoxNewName.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(172, 37);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(137, 23);
            this.textBoxNewName.TabIndex = 16;
            // 
            // buttonSaveName
            // 
            this.buttonSaveName.BackColor = System.Drawing.Color.Green;
            this.buttonSaveName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveName.ForeColor = System.Drawing.Color.White;
            this.buttonSaveName.Location = new System.Drawing.Point(322, 37);
            this.buttonSaveName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveName.Name = "buttonSaveName";
            this.buttonSaveName.Size = new System.Drawing.Size(136, 26);
            this.buttonSaveName.TabIndex = 17;
            this.buttonSaveName.Text = "Save Name";
            this.buttonSaveName.UseVisualStyleBackColor = false;
            this.buttonSaveName.Click += new System.EventHandler(this.buttonSaveName_Click);
            // 
            // buttonSavePass
            // 
            this.buttonSavePass.BackColor = System.Drawing.Color.Green;
            this.buttonSavePass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePass.ForeColor = System.Drawing.Color.White;
            this.buttonSavePass.Location = new System.Drawing.Point(462, 83);
            this.buttonSavePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSavePass.Name = "buttonSavePass";
            this.buttonSavePass.Size = new System.Drawing.Size(72, 28);
            this.buttonSavePass.TabIndex = 20;
            this.buttonSavePass.Text = "Save Password";
            this.buttonSavePass.UseVisualStyleBackColor = false;
            this.buttonSavePass.Click += new System.EventHandler(this.buttonSavePass_Click);
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPass.Location = new System.Drawing.Point(172, 87);
            this.textBoxOldPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '*';
            this.textBoxOldPass.Size = new System.Drawing.Size(137, 23);
            this.textBoxOldPass.TabIndex = 19;
            // 
            // buttonChngPass
            // 
            this.buttonChngPass.BackColor = System.Drawing.Color.Teal;
            this.buttonChngPass.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChngPass.ForeColor = System.Drawing.Color.White;
            this.buttonChngPass.Location = new System.Drawing.Point(9, 79);
            this.buttonChngPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChngPass.Name = "buttonChngPass";
            this.buttonChngPass.Size = new System.Drawing.Size(152, 36);
            this.buttonChngPass.TabIndex = 18;
            this.buttonChngPass.Text = "Change Password";
            this.buttonChngPass.UseVisualStyleBackColor = false;
            this.buttonChngPass.Click += new System.EventHandler(this.buttonChngPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Old Password";
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(321, 87);
            this.textBoxNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.PasswordChar = '*';
            this.textBoxNewPass.Size = new System.Drawing.Size(137, 23);
            this.textBoxNewPass.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "New Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Delete Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // EditProfileFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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