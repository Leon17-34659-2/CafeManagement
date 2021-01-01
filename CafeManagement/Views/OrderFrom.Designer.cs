namespace CafeManagement.Views
{
    partial class OrderFrom
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
            this.AllItemdataGridView = new System.Windows.Forms.DataGridView();
            this.Item_id = new System.Windows.Forms.Label();
            this.numericUpDown_order_id = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.richTextBox_OrderDetails = new System.Windows.Forms.RichTextBox();
            this.buttonConfirmOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllItemdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_order_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // AllItemdataGridView
            // 
            this.AllItemdataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllItemdataGridView.Location = new System.Drawing.Point(-1, 1);
            this.AllItemdataGridView.Name = "AllItemdataGridView";
            this.AllItemdataGridView.RowHeadersWidth = 51;
            this.AllItemdataGridView.RowTemplate.Height = 24;
            this.AllItemdataGridView.Size = new System.Drawing.Size(463, 335);
            this.AllItemdataGridView.TabIndex = 0;
            // 
            // Item_id
            // 
            this.Item_id.AutoSize = true;
            this.Item_id.Location = new System.Drawing.Point(35, 368);
            this.Item_id.Name = "Item_id";
            this.Item_id.Size = new System.Drawing.Size(49, 17);
            this.Item_id.TabIndex = 1;
            this.Item_id.Text = "Item Id";
            // 
            // numericUpDown_order_id
            // 
            this.numericUpDown_order_id.Location = new System.Drawing.Point(101, 363);
            this.numericUpDown_order_id.Name = "numericUpDown_order_id";
            this.numericUpDown_order_id.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown_order_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(252, 363);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown_quantity.TabIndex = 4;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(101, 405);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(216, 32);
            this.buttonOrder.TabIndex = 5;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // richTextBox_OrderDetails
            // 
            this.richTextBox_OrderDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox_OrderDetails.Location = new System.Drawing.Point(462, 1);
            this.richTextBox_OrderDetails.Name = "richTextBox_OrderDetails";
            this.richTextBox_OrderDetails.Size = new System.Drawing.Size(337, 335);
            this.richTextBox_OrderDetails.TabIndex = 6;
            this.richTextBox_OrderDetails.Text = "You Have not Ordered anything yet.";
            // 
            // buttonConfirmOrder
            // 
            this.buttonConfirmOrder.Location = new System.Drawing.Point(553, 362);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(151, 37);
            this.buttonConfirmOrder.TabIndex = 7;
            this.buttonConfirmOrder.Text = "Confirm Order";
            this.buttonConfirmOrder.UseVisualStyleBackColor = true;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.buttonConfirmOrder_Click);
            // 
            // OrderFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.buttonConfirmOrder);
            this.Controls.Add(this.richTextBox_OrderDetails);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_order_id);
            this.Controls.Add(this.Item_id);
            this.Controls.Add(this.AllItemdataGridView);
            this.Name = "OrderFrom";
            this.Text = "OrderFrom";
            ((System.ComponentModel.ISupportInitialize)(this.AllItemdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_order_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllItemdataGridView;
        private System.Windows.Forms.Label Item_id;
        private System.Windows.Forms.NumericUpDown numericUpDown_order_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.RichTextBox richTextBox_OrderDetails;
        private System.Windows.Forms.Button buttonConfirmOrder;
    }
}