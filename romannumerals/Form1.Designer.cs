namespace romannumerals
{
    partial class Form1
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
            this.inputLB = new System.Windows.Forms.Label();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.outputLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLB
            // 
            this.inputLB.Location = new System.Drawing.Point(12, 9);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(100, 29);
            this.inputLB.TabIndex = 0;
            this.inputLB.Text = "Input a number between 1 and 10";
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(12, 41);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(100, 20);
            this.InputTB.TabIndex = 1;
            this.InputTB.TextChanged += new System.EventHandler(this.InputTB_TextChanged);
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(146, 25);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(149, 13);
            this.outputLB.TabIndex = 2;
            this.outputLB.Text = "The corasponding numeral is: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 73);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.InputTB);
            this.Controls.Add(this.inputLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLB;
        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.Label outputLB;
    }
}

