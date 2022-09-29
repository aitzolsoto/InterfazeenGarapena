namespace Ariketa1
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
            this.textEsaldia = new System.Windows.Forms.TextBox();
            this.btnEsaldi1 = new System.Windows.Forms.Button();
            this.btnEsaldi2 = new System.Windows.Forms.Button();
            this.btnEsaldi3 = new System.Windows.Forms.Button();
            this.btnEsaldi4 = new System.Windows.Forms.Button();
            this.btnEsaldi5 = new System.Windows.Forms.Button();
            this.btnLotu = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnItxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEsaldia
            // 
            this.textEsaldia.Location = new System.Drawing.Point(237, 37);
            this.textEsaldia.Multiline = true;
            this.textEsaldia.Name = "textEsaldia";
            this.textEsaldia.Size = new System.Drawing.Size(339, 119);
            this.textEsaldia.TabIndex = 0;
            // 
            // btnEsaldi1
            // 
            this.btnEsaldi1.Location = new System.Drawing.Point(82, 207);
            this.btnEsaldi1.Name = "btnEsaldi1";
            this.btnEsaldi1.Size = new System.Drawing.Size(108, 43);
            this.btnEsaldi1.TabIndex = 1;
            this.btnEsaldi1.Text = "Esaldi 1";
            this.btnEsaldi1.UseVisualStyleBackColor = true;
            this.btnEsaldi1.Click += new System.EventHandler(this.btnEsaldia);
            // 
            // btnEsaldi2
            // 
            this.btnEsaldi2.Location = new System.Drawing.Point(346, 204);
            this.btnEsaldi2.Name = "btnEsaldi2";
            this.btnEsaldi2.Size = new System.Drawing.Size(108, 43);
            this.btnEsaldi2.TabIndex = 2;
            this.btnEsaldi2.Text = "Esaldi 2";
            this.btnEsaldi2.UseVisualStyleBackColor = true;
            this.btnEsaldi2.Click += new System.EventHandler(this.btnEsaldia);
            // 
            // btnEsaldi3
            // 
            this.btnEsaldi3.Location = new System.Drawing.Point(601, 204);
            this.btnEsaldi3.Name = "btnEsaldi3";
            this.btnEsaldi3.Size = new System.Drawing.Size(108, 43);
            this.btnEsaldi3.TabIndex = 3;
            this.btnEsaldi3.Text = "Esaldi 3";
            this.btnEsaldi3.UseVisualStyleBackColor = true;
            this.btnEsaldi3.Click += new System.EventHandler(this.btnEsaldia);
            // 
            // btnEsaldi4
            // 
            this.btnEsaldi4.Location = new System.Drawing.Point(82, 315);
            this.btnEsaldi4.Name = "btnEsaldi4";
            this.btnEsaldi4.Size = new System.Drawing.Size(108, 43);
            this.btnEsaldi4.TabIndex = 4;
            this.btnEsaldi4.Text = "Esaldi 4";
            this.btnEsaldi4.UseVisualStyleBackColor = true;
            this.btnEsaldi4.Click += new System.EventHandler(this.btnEsaldia);
            // 
            // btnEsaldi5
            // 
            this.btnEsaldi5.Location = new System.Drawing.Point(346, 315);
            this.btnEsaldi5.Name = "btnEsaldi5";
            this.btnEsaldi5.Size = new System.Drawing.Size(108, 43);
            this.btnEsaldi5.TabIndex = 5;
            this.btnEsaldi5.Text = "Esaldi 5";
            this.btnEsaldi5.UseVisualStyleBackColor = true;
            this.btnEsaldi5.Click += new System.EventHandler(this.btnEsaldia);
            // 
            // btnLotu
            // 
            this.btnLotu.Location = new System.Drawing.Point(601, 315);
            this.btnLotu.Name = "btnLotu";
            this.btnLotu.Size = new System.Drawing.Size(108, 43);
            this.btnLotu.TabIndex = 6;
            this.btnLotu.Text = "Lotu";
            this.btnLotu.UseVisualStyleBackColor = true;
            this.btnLotu.Click += new System.EventHandler(this.btnEsaldia);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(237, 424);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(108, 43);
            this.btnGarbitu.TabIndex = 7;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnItxi
            // 
            this.btnItxi.Location = new System.Drawing.Point(468, 424);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(108, 43);
            this.btnItxi.TabIndex = 8;
            this.btnItxi.Text = "Itxi";
            this.btnItxi.UseVisualStyleBackColor = true;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 506);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnLotu);
            this.Controls.Add(this.btnEsaldi5);
            this.Controls.Add(this.btnEsaldi4);
            this.Controls.Add(this.btnEsaldi3);
            this.Controls.Add(this.btnEsaldi2);
            this.Controls.Add(this.btnEsaldi1);
            this.Controls.Add(this.textEsaldia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textEsaldia;
        private Button btnEsaldi1;
        private Button btnEsaldi2;
        private Button btnEsaldi3;
        private Button btnEsaldi4;
        private Button btnEsaldi5;
        private Button btnLotu;
        private Button btnGarbitu;
        private Button btnItxi;
    }
}