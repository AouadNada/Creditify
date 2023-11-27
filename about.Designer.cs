namespace projet_dotnet
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nous = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 708);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::projet_dotnet.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 708);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BackgroundImage = global::projet_dotnet.Properties.Resources.bag;
            this.panel2.Controls.Add(this.nous);
            this.panel2.Controls.Add(this.richTextBox3);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(284, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 763);
            this.panel2.TabIndex = 1;
            // 
            // nous
            // 
            this.nous.BackColor = System.Drawing.Color.White;
            this.nous.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nous.Location = new System.Drawing.Point(590, 368);
            this.nous.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nous.Name = "nous";
            this.nous.Size = new System.Drawing.Size(232, 152);
            this.nous.TabIndex = 27;
            this.nous.Text = "Réalisé par:\r\nAOUAD NADA\r\nAHCINE CHAYMAA\r\n\r\n\r\nEncadré par:\r\nPr.AOUATIF AMINE\r\n\r\n";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox3.Location = new System.Drawing.Point(51, 368);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(434, 152);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "Contacter nous:\nsupport@creditify.com\n05 23 07 07 07\n facebook.com/creditify_app\n" +
    "twitter.com/creditify_app";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Location = new System.Drawing.Point(51, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(556, 211);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "about";
            this.Text = "about";
            this.Load += new System.EventHandler(this.about_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label nous;
    }
}