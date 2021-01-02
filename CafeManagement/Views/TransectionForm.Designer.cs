namespace CafeManagement.Views
{
    partial class TransectionForm
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
            this.TransectiondataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TransectiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TransectiondataGridView
            // 
            this.TransectiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransectiondataGridView.Location = new System.Drawing.Point(1, 25);
            this.TransectiondataGridView.Name = "TransectiondataGridView";
            this.TransectiondataGridView.RowHeadersWidth = 51;
            this.TransectiondataGridView.RowTemplate.Height = 24;
            this.TransectiondataGridView.Size = new System.Drawing.Size(803, 393);
            this.TransectiondataGridView.TabIndex = 0;
            // 
            // TransectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TransectiondataGridView);
            this.Name = "TransectionForm";
            this.Text = "TransectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.TransectiondataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransectiondataGridView;
    }
}