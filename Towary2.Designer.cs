namespace ObslugaMagazynu
{
    partial class Towary2
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TowaryTabela = new System.Windows.Forms.DataGridView();
            this.Zaznacz = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edytuj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrkatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaTowarowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.StanT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SzukajT = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TowaryTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTowarowBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TowaryTabela, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 325);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // TowaryTabela
            // 
            this.TowaryTabela.AllowUserToAddRows = false;
            this.TowaryTabela.AllowUserToDeleteRows = false;
            this.TowaryTabela.AutoGenerateColumns = false;
            this.TowaryTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TowaryTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zaznacz,
            this.Edytuj,
            this.Usun,
            this.Id,
            this.nazwaDataGridViewTextBoxColumn,
            this.jmDataGridViewTextBoxColumn,
            this.nrkatDataGridViewTextBoxColumn,
            this.stanDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.Type,
            this.grupaDataGridViewTextBoxColumn});
            this.TowaryTabela.DataSource = this.listaTowarowBindingSource;
            this.TowaryTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TowaryTabela.Location = new System.Drawing.Point(3, 3);
            this.TowaryTabela.Name = "TowaryTabela";
            this.TowaryTabela.Size = new System.Drawing.Size(992, 269);
            this.TowaryTabela.TabIndex = 3;
            this.TowaryTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Zaznacz
            // 
            this.Zaznacz.FillWeight = 60F;
            this.Zaznacz.HeaderText = "Zaznacz";
            this.Zaznacz.Name = "Zaznacz";
            this.Zaznacz.Width = 60;
            // 
            // Edytuj
            // 
            this.Edytuj.FillWeight = 50F;
            this.Edytuj.HeaderText = "Edytuj";
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseColumnTextForButtonValue = true;
            this.Edytuj.Width = 50;
            // 
            // Usun
            // 
            this.Usun.FillWeight = 50F;
            this.Usun.HeaderText = "Usuń";
            this.Usun.Name = "Usun";
            this.Usun.Text = "Usuń";
            this.Usun.UseColumnTextForButtonValue = true;
            this.Usun.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 300;
            // 
            // jmDataGridViewTextBoxColumn
            // 
            this.jmDataGridViewTextBoxColumn.DataPropertyName = "Jm";
            this.jmDataGridViewTextBoxColumn.HeaderText = "Jednostka";
            this.jmDataGridViewTextBoxColumn.Name = "jmDataGridViewTextBoxColumn";
            this.jmDataGridViewTextBoxColumn.ReadOnly = true;
            this.jmDataGridViewTextBoxColumn.Width = 60;
            // 
            // nrkatDataGridViewTextBoxColumn
            // 
            this.nrkatDataGridViewTextBoxColumn.DataPropertyName = "Nr_kat";
            this.nrkatDataGridViewTextBoxColumn.HeaderText = "Numer Katalogowy";
            this.nrkatDataGridViewTextBoxColumn.Name = "nrkatDataGridViewTextBoxColumn";
            this.nrkatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stanDataGridViewTextBoxColumn
            // 
            this.stanDataGridViewTextBoxColumn.DataPropertyName = "Stan";
            this.stanDataGridViewTextBoxColumn.HeaderText = "Stan";
            this.stanDataGridViewTextBoxColumn.Name = "stanDataGridViewTextBoxColumn";
            this.stanDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanDataGridViewTextBoxColumn.Width = 50;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaDataGridViewTextBoxColumn.Width = 50;
            // 
            // vatDataGridViewTextBoxColumn
            // 
            this.vatDataGridViewTextBoxColumn.DataPropertyName = "Vat";
            this.vatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
            this.vatDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatDataGridViewTextBoxColumn.Width = 30;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Typ";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grupaDataGridViewTextBoxColumn
            // 
            this.grupaDataGridViewTextBoxColumn.DataPropertyName = "Grupa";
            this.grupaDataGridViewTextBoxColumn.HeaderText = "Grupa";
            this.grupaDataGridViewTextBoxColumn.Name = "grupaDataGridViewTextBoxColumn";
            this.grupaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listaTowarowBindingSource
            // 
            this.listaTowarowBindingSource.DataSource = typeof(ObslugaMagazynuLib.Towary.ListaTowarow);
            this.listaTowarowBindingSource.CurrentChanged += new System.EventHandler(this.listaTowarowBindingSource_CurrentChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.StanT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.SzukajT);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wyszukaj braki w stanie :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Sprawdz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StanT
            // 
            this.StanT.Location = new System.Drawing.Point(446, 27);
            this.StanT.Name = "StanT";
            this.StanT.Size = new System.Drawing.Size(73, 20);
            this.StanT.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wynik wyszukiwania :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(657, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Wyczysc wyszukiwanie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SzukajT
            // 
            this.SzukajT.Location = new System.Drawing.Point(339, 2);
            this.SzukajT.Name = "SzukajT";
            this.SzukajT.Size = new System.Drawing.Size(180, 20);
            this.SzukajT.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(525, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Szukaj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Wybierz towary!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodaj nowy towar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.button1_Click);
            // 
            // Towary2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Towary2";
            this.Text = "Towary";
            this.Load += new System.EventHandler(this.Towary2_Load);
            this.Shown += new System.EventHandler(this.Towary2_Shown);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TowaryTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTowarowBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView TowaryTabela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource listaTowarowBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zaznacz;
        private System.Windows.Forms.DataGridViewButtonColumn Edytuj;
        private System.Windows.Forms.DataGridViewButtonColumn Usun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrkatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox SzukajT;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox StanT;


    }
}