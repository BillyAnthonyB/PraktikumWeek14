namespace PraktikumWeek14
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonUrutkan = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(144, 137);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(167, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(141, 121);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Input";
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(144, 175);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonReverse.TabIndex = 2;
            this.buttonReverse.Text = "REVERSE";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonUrutkan
            // 
            this.buttonUrutkan.Location = new System.Drawing.Point(236, 173);
            this.buttonUrutkan.Name = "buttonUrutkan";
            this.buttonUrutkan.Size = new System.Drawing.Size(75, 23);
            this.buttonUrutkan.TabIndex = 3;
            this.buttonUrutkan.Text = "URUTKAN";
            this.buttonUrutkan.UseVisualStyleBackColor = true;
            this.buttonUrutkan.Click += new System.EventHandler(this.buttonUrutkan_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(141, 218);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonUrutkan);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxNama);
            this.Name = "Form1";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonUrutkan;
        private System.Windows.Forms.Label labelOutput;
    }
}

