
namespace Hotels_1.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bron = new System.Windows.Forms.Button();
            this.uslugi = new System.Windows.Forms.Button();
            this.sale = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bron
            // 
            this.bron.BackColor = System.Drawing.Color.White;
            this.bron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bron.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bron.Location = new System.Drawing.Point(-23, 94);
            this.bron.Name = "bron";
            this.bron.Size = new System.Drawing.Size(293, 69);
            this.bron.TabIndex = 0;
            this.bron.Text = "Бронирование";
            this.bron.UseVisualStyleBackColor = false;
            this.bron.Click += new System.EventHandler(this.bron_Click);
            // 
            // uslugi
            // 
            this.uslugi.BackColor = System.Drawing.Color.White;
            this.uslugi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uslugi.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uslugi.Location = new System.Drawing.Point(-23, 168);
            this.uslugi.Name = "uslugi";
            this.uslugi.Size = new System.Drawing.Size(293, 69);
            this.uslugi.TabIndex = 1;
            this.uslugi.Text = "Услуги";
            this.uslugi.UseVisualStyleBackColor = false;
            this.uslugi.Click += new System.EventHandler(this.uslugi_Click);
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.Color.White;
            this.sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sale.Location = new System.Drawing.Point(-23, 242);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(293, 69);
            this.sale.TabIndex = 2;
            this.sale.Text = "Акции";
            this.sale.UseVisualStyleBackColor = false;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(-23, 316);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(293, 69);
            this.info.TabIndex = 3;
            this.info.Text = "Мой профиль";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.White;
            this.contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contact.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contact.Location = new System.Drawing.Point(-23, 390);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(293, 69);
            this.contact.TabIndex = 5;
            this.contact.Text = "Контакты";
            this.contact.UseVisualStyleBackColor = false;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(148, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "The Continental Hotels";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.BurlyWood;
            this.panelControl.Controls.Add(this.info);
            this.panelControl.Controls.Add(this.bron);
            this.panelControl.Controls.Add(this.contact);
            this.panelControl.Controls.Add(this.uslugi);
            this.panelControl.Controls.Add(this.sale);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(270, 662);
            this.panelControl.TabIndex = 7;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 97);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(107, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Azure;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(270, 97);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(851, 565);
            this.panelForm.TabIndex = 9;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 662);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "The Continental";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bron;
        private System.Windows.Forms.Button uslugi;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}