namespace qr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TQrlink = new System.Windows.Forms.TextBox();
            this.TQrnamefile = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.picgenerate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picgenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text or link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qr name file";
            // 
            // TQrlink
            // 
            this.TQrlink.Location = new System.Drawing.Point(131, 37);
            this.TQrlink.Name = "TQrlink";
            this.TQrlink.Size = new System.Drawing.Size(188, 20);
            this.TQrlink.TabIndex = 2;
            // 
            // TQrnamefile
            // 
            this.TQrnamefile.Location = new System.Drawing.Point(131, 84);
            this.TQrnamefile.Name = "TQrnamefile";
            this.TQrnamefile.Size = new System.Drawing.Size(188, 20);
            this.TQrnamefile.TabIndex = 3;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generate.Location = new System.Drawing.Point(91, 138);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(149, 53);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate QR";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // picgenerate
            // 
            this.picgenerate.BackColor = System.Drawing.Color.White;
            this.picgenerate.InitialImage = null;
            this.picgenerate.Location = new System.Drawing.Point(81, 216);
            this.picgenerate.Name = "picgenerate";
            this.picgenerate.Size = new System.Drawing.Size(177, 171);
            this.picgenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picgenerate.TabIndex = 5;
            this.picgenerate.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 418);
            this.Controls.Add(this.picgenerate);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.TQrnamefile);
            this.Controls.Add(this.TQrlink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator QR";
            ((System.ComponentModel.ISupportInitialize)(this.picgenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TQrlink;
        private System.Windows.Forms.TextBox TQrnamefile;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.PictureBox picgenerate;
    }
}

