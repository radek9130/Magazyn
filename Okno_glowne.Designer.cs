namespace Magazyn
{
    partial class Okno_glowne
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1382, 736);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button1ToolStripMenuItem,
            this.button2ToolStripMenuItem,
            this.button3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1ToolStripMenuItem
            // 
            this.button1ToolStripMenuItem.Name = "button1ToolStripMenuItem";
            this.button1ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.button1ToolStripMenuItem.Text = "button1";
            this.button1ToolStripMenuItem.Click += new System.EventHandler(this.button1ToolStripMenuItem_Click);
            // 
            // button2ToolStripMenuItem
            // 
            this.button2ToolStripMenuItem.Name = "button2ToolStripMenuItem";
            this.button2ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.button2ToolStripMenuItem.Text = "button2";
            // 
            // button3ToolStripMenuItem
            // 
            this.button3ToolStripMenuItem.Name = "button3ToolStripMenuItem";
            this.button3ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.button3ToolStripMenuItem.Text = "button3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Magazyn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem button1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button3ToolStripMenuItem;
    }
}

