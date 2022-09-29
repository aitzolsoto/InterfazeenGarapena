namespace Ariketa2_Zerrenda
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
            this.textZenb = new System.Windows.Forms.TextBox();
            this.labelZenbakia = new System.Windows.Forms.Label();
            this.btnHurrengoa = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnItxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textZenb
            // 
            this.textZenb.Location = new System.Drawing.Point(277, 89);
            this.textZenb.Name = "textZenb";
            this.textZenb.Size = new System.Drawing.Size(249, 23);
            this.textZenb.TabIndex = 0;
            // 
            // labelZenbakia
            // 
            this.labelZenbakia.AutoSize = true;
            this.labelZenbakia.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelZenbakia.Location = new System.Drawing.Point(200, 92);
            this.labelZenbakia.Name = "labelZenbakia";
            this.labelZenbakia.Size = new System.Drawing.Size(64, 15);
            this.labelZenbakia.TabIndex = 1;
            this.labelZenbakia.Text = "1.Zenbakia";
            // 
            // btnHurrengoa
            // 
            this.btnHurrengoa.Location = new System.Drawing.Point(107, 298);
            this.btnHurrengoa.Name = "btnHurrengoa";
            this.btnHurrengoa.Size = new System.Drawing.Size(100, 46);
            this.btnHurrengoa.TabIndex = 2;
            this.btnHurrengoa.Text = "Hurrengoa";
            this.btnHurrengoa.UseVisualStyleBackColor = true;
            this.btnHurrengoa.Click += new System.EventHandler(this.btnHurrengoa_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(336, 298);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(100, 46);
            this.btnGarbitu.TabIndex = 3;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnItxi
            // 
            this.btnItxi.Location = new System.Drawing.Point(543, 298);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(100, 46);
            this.btnItxi.TabIndex = 4;
            this.btnItxi.Text = "Itxi";
            this.btnItxi.UseVisualStyleBackColor = true;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnHurrengoa);
            this.Controls.Add(this.labelZenbakia);
            this.Controls.Add(this.textZenb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textZenb;
        private Label labelZenbakia;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnItxi;
    }
}