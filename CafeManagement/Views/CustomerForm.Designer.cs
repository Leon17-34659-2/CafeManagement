namespace CafeManagement.Views
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdditem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(254, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Customer Page";
            // 
            // buttonAdditem
            // 
            this.buttonAdditem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdditem.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdditem.ForeColor = System.Drawing.Color.White;
            this.buttonAdditem.Location = new System.Drawing.Point(342, 159);
            this.buttonAdditem.Name = "buttonAdditem";
            this.buttonAdditem.Size = new System.Drawing.Size(215, 43);
            this.buttonAdditem.TabIndex = 2;
            this.buttonAdditem.Text = "Order Food";
            this.buttonAdditem.UseVisualStyleBackColor = false;
            this.buttonAdditem.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(342, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(342, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "View Cafe";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdditem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdditem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}