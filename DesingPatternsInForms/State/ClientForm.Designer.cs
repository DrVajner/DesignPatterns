namespace DesingPatternsInForms.State
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
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonPressSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBulb
            // 
            this.textBoxState.Location = new System.Drawing.Point(12, 12);
            this.textBoxState.Name = "textBoxBulb";
            this.textBoxState.Size = new System.Drawing.Size(203, 20);
            this.textBoxState.TabIndex = 0;
            // 
            // buttonPressSwitch
            // 
            this.buttonPressSwitch.Location = new System.Drawing.Point(115, 38);
            this.buttonPressSwitch.Name = "buttonPressSwitch";
            this.buttonPressSwitch.Size = new System.Drawing.Size(100, 23);
            this.buttonPressSwitch.TabIndex = 1;
            this.buttonPressSwitch.Text = "Press Switch";
            this.buttonPressSwitch.UseVisualStyleBackColor = true;
            this.buttonPressSwitch.Click += new System.EventHandler(this.buttonPressSwitch_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 70);
            this.Controls.Add(this.buttonPressSwitch);
            this.Controls.Add(this.textBoxState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonPressSwitch;
    }
}