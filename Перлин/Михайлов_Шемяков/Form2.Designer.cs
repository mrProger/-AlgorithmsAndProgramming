
namespace Михайлов_Шемяков
{
    partial class Form2
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
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сменитьРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наВесьЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Location = new System.Drawing.Point(2, 70);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "1";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьРисунокToolStripMenuItem,
            this.наВесьЭкранToolStripMenuItem,
            this.вернутьРазмерToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сменитьРисунокToolStripMenuItem
            // 
            this.сменитьРисунокToolStripMenuItem.Name = "сменитьРисунокToolStripMenuItem";
            this.сменитьРисунокToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.сменитьРисунокToolStripMenuItem.Text = "Сменить рисунок";
            // 
            // наВесьЭкранToolStripMenuItem
            // 
            this.наВесьЭкранToolStripMenuItem.Name = "наВесьЭкранToolStripMenuItem";
            this.наВесьЭкранToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.наВесьЭкранToolStripMenuItem.Text = "На весь экран";
            // 
            // вернутьРазмерToolStripMenuItem
            // 
            this.вернутьРазмерToolStripMenuItem.Name = "вернутьРазмерToolStripMenuItem";
            this.вернутьРазмерToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.вернутьРазмерToolStripMenuItem.Text = "Вернуть размер";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сменитьРисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наВесьЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьРазмерToolStripMenuItem;
    }
}