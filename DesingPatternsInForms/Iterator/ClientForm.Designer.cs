namespace DesingPatternsInForms.Iterator
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
            this.labelCustomerCode = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCode = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.buttonGetByIndex = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(7, 22);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(85, 13);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // labelCustomerCode
            // 
            this.labelCustomerCode.AutoSize = true;
            this.labelCustomerCode.Location = new System.Drawing.Point(10, 48);
            this.labelCustomerCode.Name = "labelCustomerCode";
            this.labelCustomerCode.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerCode.TabIndex = 0;
            this.labelCustomerCode.Text = "Customer Code:";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(56, 82);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(36, 13);
            this.labelIndex.TabIndex = 0;
            this.labelIndex.Text = "Index:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(98, 19);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(318, 20);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // textBoxCustomerCode
            // 
            this.textBoxCustomerCode.Location = new System.Drawing.Point(98, 45);
            this.textBoxCustomerCode.Name = "textBoxCustomerCode";
            this.textBoxCustomerCode.Size = new System.Drawing.Size(318, 20);
            this.textBoxCustomerCode.TabIndex = 1;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(98, 79);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(213, 20);
            this.textBoxIndex.TabIndex = 1;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerCode);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerCode);
            this.groupBoxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(420, 73);
            this.groupBoxCustomer.TabIndex = 2;
            this.groupBoxCustomer.TabStop = false;
            // 
            // buttonGetByIndex
            // 
            this.buttonGetByIndex.Location = new System.Drawing.Point(317, 77);
            this.buttonGetByIndex.Name = "buttonGetByIndex";
            this.buttonGetByIndex.Size = new System.Drawing.Size(99, 23);
            this.buttonGetByIndex.TabIndex = 3;
            this.buttonGetByIndex.Text = "Get By Index";
            this.buttonGetByIndex.UseVisualStyleBackColor = true;
            this.buttonGetByIndex.Click += new System.EventHandler(this.buttonGetByIndex_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(179, 105);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(98, 105);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 3;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(260, 105);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(341, 105);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 134);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonGetByIndex);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerCode;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerCode;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Button buttonGetByIndex;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
    }
}