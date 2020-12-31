namespace CafeManagement.Views
{
    partial class ItemListForm
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
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonItemAdded = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxItemName.Location = new System.Drawing.Point(214, 92);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(131, 22);
            this.textBoxItemName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPrice.Location = new System.Drawing.Point(214, 148);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(131, 22);
            this.textBoxPrice.TabIndex = 3;
            // 
            // buttonItemAdded
            // 
            this.buttonItemAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonItemAdded.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdded.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonItemAdded.Location = new System.Drawing.Point(214, 185);
            this.buttonItemAdded.Name = "buttonItemAdded";
            this.buttonItemAdded.Size = new System.Drawing.Size(131, 32);
            this.buttonItemAdded.TabIndex = 4;
            this.buttonItemAdded.Text = "Add";
            this.buttonItemAdded.UseVisualStyleBackColor = false;
            this.buttonItemAdded.Click += new System.EventHandler(this.ItemAddBtn_Click);
            // 
            // ItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonItemAdded);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemListForm";
            this.Text = "ItemListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonItemAdded;
    }
}