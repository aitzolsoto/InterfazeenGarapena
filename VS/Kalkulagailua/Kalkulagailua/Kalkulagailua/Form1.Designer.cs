namespace Kalkulagailua
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
            this.btnGehitu = new System.Windows.Forms.Button();
            this.textZenb1 = new System.Windows.Forms.TextBox();
            this.textZenb2 = new System.Windows.Forms.TextBox();
            this.btnKen = new System.Windows.Forms.Button();
            this.btnBidertu = new System.Windows.Forms.Button();
            this.btnZatitu = new System.Windows.Forms.Button();
            this.btnItxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGehitu
            // 
            this.btnGehitu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGehitu.Location = new System.Drawing.Point(184, 178);
            this.btnGehitu.Name = "btnGehitu";
            this.btnGehitu.Size = new System.Drawing.Size(119, 53);
            this.btnGehitu.TabIndex = 0;
            this.btnGehitu.Text = "+";
            this.btnGehitu.UseVisualStyleBackColor = true;
            this.btnGehitu.Click += new System.EventHandler(this.buttonEragiketa);
            // 
            // textZenb1
            // 
            this.textZenb1.Location = new System.Drawing.Point(141, 73);
            this.textZenb1.Name = "textZenb1";
            this.textZenb1.Size = new System.Drawing.Size(162, 23);
            this.textZenb1.TabIndex = 1;
            this.textZenb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textZenb1_KeyPress);
            // 
            // textZenb2
            // 
            this.textZenb2.Location = new System.Drawing.Point(477, 73);
            this.textZenb2.Name = "textZenb2";
            this.textZenb2.Size = new System.Drawing.Size(162, 23);
            this.textZenb2.TabIndex = 2;
            this.textZenb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textZenb2_KeyPress);
            // 
            // btnKen
            // 
            this.btnKen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKen.Location = new System.Drawing.Point(477, 178);
            this.btnKen.Name = "btnKen";
            this.btnKen.Size = new System.Drawing.Size(119, 53);
            this.btnKen.TabIndex = 3;
            this.btnKen.Text = "-";
            this.btnKen.UseVisualStyleBackColor = true;
            this.btnKen.Click += new System.EventHandler(this.buttonEragiketa);
            // 
            // btnBidertu
            // 
            this.btnBidertu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBidertu.Location = new System.Drawing.Point(184, 308);
            this.btnBidertu.Name = "btnBidertu";
            this.btnBidertu.Size = new System.Drawing.Size(119, 53);
            this.btnBidertu.TabIndex = 4;
            this.btnBidertu.Text = "X";
            this.btnBidertu.UseVisualStyleBackColor = true;
            this.btnBidertu.Click += new System.EventHandler(this.buttonEragiketa);
            // 
            // btnZatitu
            // 
            this.btnZatitu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZatitu.Location = new System.Drawing.Point(477, 308);
            this.btnZatitu.Name = "btnZatitu";
            this.btnZatitu.Size = new System.Drawing.Size(119, 53);
            this.btnZatitu.TabIndex = 5;
            this.btnZatitu.Text = "/";
            this.btnZatitu.UseVisualStyleBackColor = true;
            this.btnZatitu.Click += new System.EventHandler(this.buttonEragiketa);
            // 
            // btnItxi
            // 
            this.btnItxi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItxi.Location = new System.Drawing.Point(336, 401);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(119, 53);
            this.btnItxi.TabIndex = 6;
            this.btnItxi.Text = "Itxi";
            this.btnItxi.UseVisualStyleBackColor = true;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.btnZatitu);
            this.Controls.Add(this.btnBidertu);
            this.Controls.Add(this.btnKen);
            this.Controls.Add(this.textZenb2);
            this.Controls.Add(this.textZenb1);
            this.Controls.Add(this.btnGehitu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGehitu;
        private TextBox textZenb1;
        private TextBox textZenb2;
        private Button btnKen;
        private Button btnBidertu;
        private Button btnZatitu;
        private Button btnItxi;
    }
}