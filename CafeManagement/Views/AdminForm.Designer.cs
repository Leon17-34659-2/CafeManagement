namespace CafeManagement.Views
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdditem = new System.Windows.Forms.Button();
            this.buttonShowUser = new System.Windows.Forms.Button();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.buttonViewTransection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Admin Page";
            // 
            // buttonAdditem
            // 
            this.buttonAdditem.BackColor = System.Drawing.Color.Teal;
            this.buttonAdditem.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdditem.ForeColor = System.Drawing.Color.White;
            this.buttonAdditem.Location = new System.Drawing.Point(23, 74);
            this.buttonAdditem.Name = "buttonAdditem";
            this.buttonAdditem.Size = new System.Drawing.Size(241, 43);
            this.buttonAdditem.TabIndex = 1;
            this.buttonAdditem.Text = "Add Item";
            this.buttonAdditem.UseVisualStyleBackColor = false;
            this.buttonAdditem.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // buttonShowUser
            // 
            this.buttonShowUser.BackColor = System.Drawing.Color.Teal;
            this.buttonShowUser.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowUser.ForeColor = System.Drawing.Color.White;
            this.buttonShowUser.Location = new System.Drawing.Point(23, 123);
            this.buttonShowUser.Name = "buttonShowUser";
            this.buttonShowUser.Size = new System.Drawing.Size(241, 43);
            this.buttonShowUser.TabIndex = 2;
            this.buttonShowUser.Text = "Show All User";
            this.buttonShowUser.UseVisualStyleBackColor = false;
            this.buttonShowUser.Click += new System.EventHandler(this.AllUserBtn_click);
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.Color.Teal;
            this.buttonSearchUser.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchUser.ForeColor = System.Drawing.Color.White;
            this.buttonSearchUser.Location = new System.Drawing.Point(23, 172);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(241, 43);
            this.buttonSearchUser.TabIndex = 3;
            this.buttonSearchUser.Text = "Search User";
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            this.buttonSearchUser.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // buttonViewTransection
            // 
            this.buttonViewTransection.BackColor = System.Drawing.Color.Teal;
            this.buttonViewTransection.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTransection.ForeColor = System.Drawing.Color.White;
            this.buttonViewTransection.Location = new System.Drawing.Point(23, 221);
            this.buttonViewTransection.Name = "buttonViewTransection";
            this.buttonViewTransection.Size = new System.Drawing.Size(241, 43);
            this.buttonViewTransection.TabIndex = 4;
            this.buttonViewTransection.Text = "View Transection";
            this.buttonViewTransection.UseVisualStyleBackColor = false;
            this.buttonViewTransection.Click += new System.EventHandler(this.buttonViewTransection_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewTransection);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.buttonShowUser);
            this.Controls.Add(this.buttonAdditem);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdditem;
        private System.Windows.Forms.Button buttonShowUser;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Button buttonViewTransection;
    }
}