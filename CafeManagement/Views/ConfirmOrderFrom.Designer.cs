namespace CafeManagement.Views
{
    partial class ConfirmOrderFrom
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFinishOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanks For your Order\r\nYour Order is Confirm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "We will Contact You soon";
            // 
            // buttonFinishOrder
            // 
            this.buttonFinishOrder.Location = new System.Drawing.Point(306, 246);
            this.buttonFinishOrder.Name = "buttonFinishOrder";
            this.buttonFinishOrder.Size = new System.Drawing.Size(75, 29);
            this.buttonFinishOrder.TabIndex = 2;
            this.buttonFinishOrder.Text = "Proceed";
            this.buttonFinishOrder.UseVisualStyleBackColor = true;
            this.buttonFinishOrder.Click += new System.EventHandler(this.buttonFinishOrder_Click);
            // 
            // ConfirmOrderFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.buttonFinishOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmOrderFrom";
            this.Text = "ConfirmOrderFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFinishOrder;
    }
}