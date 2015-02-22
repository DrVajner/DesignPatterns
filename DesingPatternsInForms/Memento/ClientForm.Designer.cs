namespace DesingPatternsInForms.Memento
{
    partial class ClientForm
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
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelCustomerCode = new System.Windows.Forms.Label();
            this.textBoxCustomerCode = new System.Windows.Forms.TextBox();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(22, 15);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(85, 13);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(113, 12);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(156, 20);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(194, 90);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(113, 90);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelCustomerCode
            // 
            this.labelCustomerCode.AutoSize = true;
            this.labelCustomerCode.Location = new System.Drawing.Point(25, 41);
            this.labelCustomerCode.Name = "labelCustomerCode";
            this.labelCustomerCode.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerCode.TabIndex = 0;
            this.labelCustomerCode.Text = "Customer Code:";
            // 
            // textBoxCustomerCode
            // 
            this.textBoxCustomerCode.Location = new System.Drawing.Point(113, 38);
            this.textBoxCustomerCode.Name = "textBoxCustomerCode";
            this.textBoxCustomerCode.Size = new System.Drawing.Size(156, 20);
            this.textBoxCustomerCode.TabIndex = 1;
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Location = new System.Drawing.Point(12, 67);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(95, 13);
            this.labelCustomerAddress.TabIndex = 0;
            this.labelCustomerAddress.Text = "Customer Address:";
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(113, 64);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(156, 20);
            this.textBoxCustomerAddress.TabIndex = 1;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 120);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.labelCustomerAddress);
            this.Controls.Add(this.textBoxCustomerCode);
            this.Controls.Add(this.labelCustomerCode);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelCustomerCode;
        private System.Windows.Forms.TextBox textBoxCustomerCode;
        private System.Windows.Forms.Label labelCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
    }
}