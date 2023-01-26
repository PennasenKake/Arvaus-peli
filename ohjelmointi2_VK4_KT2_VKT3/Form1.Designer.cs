namespace ohjelmointi2_VK4_KT2_VKT3
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslbArvaukset = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbIlmoitus = new System.Windows.Forms.ToolStripStatusLabel();
            this.atusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbIlmoitss = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnArvaa = new System.Windows.Forms.Button();
            this.tbLuku = new System.Windows.Forms.TextBox();
            this.lbArvattavaLuku = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbArvaukset,
            this.tsslbIlmoitus,
            this.atusLabel1,
            this.tsslbIlmoitss});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslbArvaukset
            // 
            this.tsslbArvaukset.Name = "tsslbArvaukset";
            this.tsslbArvaukset.Size = new System.Drawing.Size(99, 25);
            this.tsslbArvaukset.Text = "Arvaukset: ";
            this.tsslbArvaukset.Click += new System.EventHandler(this.tsslbArvaukset_Click);
            // 
            // tsslbIlmoitus
            // 
            this.tsslbIlmoitus.Name = "tsslbIlmoitus";
            this.tsslbIlmoitus.Size = new System.Drawing.Size(0, 25);
            // 
            // atusLabel1
            // 
            this.atusLabel1.Name = "atusLabel1";
            this.atusLabel1.Size = new System.Drawing.Size(0, 25);
            // 
            // tsslbIlmoitss
            // 
            this.tsslbIlmoitss.Name = "tsslbIlmoitss";
            this.tsslbIlmoitss.Size = new System.Drawing.Size(85, 25);
            this.tsslbIlmoitss.Text = "Ilmoitus: ";
            this.tsslbIlmoitss.Click += new System.EventHandler(this.tsslbIlmoitss_Click);
            // 
            // btnArvaa
            // 
            this.btnArvaa.Location = new System.Drawing.Point(233, 147);
            this.btnArvaa.Name = "btnArvaa";
            this.btnArvaa.Size = new System.Drawing.Size(100, 31);
            this.btnArvaa.TabIndex = 1;
            this.btnArvaa.Text = "Arvaa";
            this.btnArvaa.UseVisualStyleBackColor = true;
            this.btnArvaa.Click += new System.EventHandler(this.btnArvaa_Click);
            // 
            // tbLuku
            // 
            this.tbLuku.Location = new System.Drawing.Point(233, 90);
            this.tbLuku.Name = "tbLuku";
            this.tbLuku.Size = new System.Drawing.Size(100, 26);
            this.tbLuku.TabIndex = 2;
            this.tbLuku.TextChanged += new System.EventHandler(this.tbLuku_TextChanged);
            this.tbLuku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLuku_KeyPress);
            this.tbLuku.Leave += new System.EventHandler(this.tbLuku_Leave);
            // 
            // lbArvattavaLuku
            // 
            this.lbArvattavaLuku.AutoSize = true;
            this.lbArvattavaLuku.Location = new System.Drawing.Point(71, 95);
            this.lbArvattavaLuku.Name = "lbArvattavaLuku";
            this.lbArvattavaLuku.Size = new System.Drawing.Size(115, 20);
            this.lbArvattavaLuku.TabIndex = 3;
            this.lbArvattavaLuku.Text = "Arvattava Luku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 275);
            this.Controls.Add(this.lbArvattavaLuku);
            this.Controls.Add(this.tbLuku);
            this.Controls.Add(this.btnArvaa);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnArvaa;
        private System.Windows.Forms.TextBox tbLuku;
        private System.Windows.Forms.Label lbArvattavaLuku;
        private System.Windows.Forms.ToolStripStatusLabel tsslbArvaukset;
        private System.Windows.Forms.ToolStripStatusLabel tsslbIlmoitus;
        private System.Windows.Forms.ToolStripStatusLabel atusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslbIlmoitss;
    }
}

