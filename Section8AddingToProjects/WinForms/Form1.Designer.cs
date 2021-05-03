
namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloText = new System.Windows.Forms.Label();
            this.goodbyeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloText
            // 
            this.helloText.AutoSize = true;
            this.helloText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloText.Location = new System.Drawing.Point(60, 94);
            this.helloText.Name = "helloText";
            this.helloText.Size = new System.Drawing.Size(90, 37);
            this.helloText.TabIndex = 0;
            this.helloText.Text = "label1";
            // 
            // goodbyeText
            // 
            this.goodbyeText.AutoSize = true;
            this.goodbyeText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goodbyeText.Location = new System.Drawing.Point(60, 169);
            this.goodbyeText.Name = "goodbyeText";
            this.goodbyeText.Size = new System.Drawing.Size(90, 37);
            this.goodbyeText.TabIndex = 1;
            this.goodbyeText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 460);
            this.Controls.Add(this.goodbyeText);
            this.Controls.Add(this.helloText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloText;
        private System.Windows.Forms.Label goodbyeText;
    }
}

