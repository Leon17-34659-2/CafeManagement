namespace CafeManagement.Views
{
    partial class RegConfirmFrom
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonProcced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(134, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(485, 43);
            this.label4.TabIndex = 23;
            this.label4.Text = "Registration Successfull";
            // 
            // buttonProcced
            // 
            this.buttonProcced.Location = new System.Drawing.Point(310, 185);
            this.buttonProcced.Name = "buttonProcced";
            this.buttonProcced.Size = new System.Drawing.Size(80, 30);
            this.buttonProcced.TabIndex = 24;
            this.buttonProcced.Text = "Proceed";
            this.buttonProcced.UseVisualStyleBackColor = true;
            this.buttonProcced.Click += new System.EventHandler(this.ProceedBtn_Click);
            // 
            // RegConfirmFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProcced);
            this.Controls.Add(this.label4);
            this.Name = "RegConfirmFrom";
            this.Text = "RegConfirmFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonProcced;
    }
}