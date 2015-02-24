namespace DesingPatternsInForms.Strategy
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 64);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(93, 64);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(75, 23);
            this.buttonSubstract.TabIndex = 0;
            this.buttonSubstract.Text = "Substract";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(12, 12);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(156, 20);
            this.textBoxNumber1.TabIndex = 1;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(12, 38);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(156, 20);
            this.textBoxNumber2.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 93);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(156, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 122);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonAdd);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}