using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Towary;

namespace ObslugaMagazynu
{
    public partial class Towary2 : FormAbstract
    {
        public Towary2()
        {
            InitializeComponent();
        }

        public Towary2(List<int> listIn)
            : this()
        {
            list.Clear();
            list = listIn;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            (new DodajTowar()).ShowDialog();
            ListaTowarow list = ListaTowarow.Instance;
            list.Rebind();
        }

        private void Towary2_Load(object sender, EventArgs e)
        {
           
            ListaTowarow lista = ListaTowarow.Instance;

            lista.wczytajZDB();

            TowaryTabela.DataSource = lista.getBindingSource();

            if (Owner is DodajTowar || Owner is DodajDFaktura || Owner is DodajDPrzyjecie || Owner is DodajDWydanie)
            {
                TowaryTabela.Columns["Id"].Visible = false;
                TowaryTabela.Columns["Edytuj"].Visible = false;
                TowaryTabela.Columns["Usun"].Visible = false;
                if (list.Count > 0)
                {
                    foreach (int i in list)
                    {
                        foreach (DataGridViewRow r in TowaryTabela.Rows)
                        {
                            if ((int)r.Cells["Id"].Value == i)
                            {
                                r.Cells["Zaznacz"].Value = true;
                            }
                        }
                    }
                }
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1)))
            if (TowaryTabela.Columns[e.ColumnIndex].Name == "Usun")
            {
                DialogResult flag = MessageBox.Show("Czy na pewno chcesz usunąć ten towar ?", "Usuwanie towaru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (flag == DialogResult.Yes)
                {
                    ListaTowarow list = ListaTowarow.Instance;
                    int i = Convert.ToInt32(TowaryTabela.Rows[e.RowIndex].Cells["Id"].Value);
                    list.usun(i);
                    list.Rebind();
                    TowaryTabela.Refresh();
                }
            }else if(TowaryTabela.Columns[e.ColumnIndex].Name == "Edytuj"){
                ListaTowarow list = ListaTowarow.Instance;
                int i = Convert.ToInt32(TowaryTabela.Rows[e.RowIndex].Cells["Id"].Value);
                (new DodajTowar(list.Edit(i))).ShowDialog();
                TowaryTabela.Refresh();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaTowarow list = ListaTowarow.Instance;
            int i = TowaryTabela.FirstDisplayedScrollingRowIndex;
            if (TowaryTabela.Rows.Count == 0)
            {
                list.Rebind();
            }
            TowaryTabela.Refresh();
            
            if (i != -1)
            {
                timer1.Enabled = false;
                TowaryTabela.FirstDisplayedScrollingRowIndex = i;
            }
        }

        private void Towary2_Shown(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        public List<int> list = new List<int>();
        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
            foreach (DataGridViewRow r in TowaryTabela.Rows)
            {
                if ((bool)r.Cells["Zaznacz"].EditedFormattedValue == true)
                {
                    list.Add((int)r.Cells["Id"].Value);
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listaTowarowBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            int w = 0;
            string szukaj = SzukajT.Text;
            if (TowaryTabela.Rows.Count > 0)
            {
                for (int i = 0; i < TowaryTabela.Rows.Count - 1; i++)
                {
                    for (int j = 4; j < 12; j++)
                    {
                        if (TowaryTabela.Rows[i].Cells[j].Value.ToString().ToLower() == szukaj.ToLower())
                        {
                            TowaryTabela.Rows[i].Selected = true;
                            w = w + 1;
                            break;
                        }
                    }

                }
            }
            label1.Text = w.ToString();
            if (w == 0)
            {
                MessageBox.Show("Brak dokumenty w bazie.Sprawdz czy poprawnie wprowadziłes dane", "Błąd wyszukiwania");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in TowaryTabela.Rows)
            {
                row.Selected = false;
                label1.Text = "0";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int w = 0;
            int szukaj;
            szukaj = Convert.ToInt32(StanT.Text);
            int twr;
            if (TowaryTabela.Rows.Count > 0)
            {
                for (int i = 0; i < TowaryTabela.Rows.Count; i++)
                {
                    for (int j = 7; j < 8; j++)
                    {
                        twr = Convert.ToInt32(TowaryTabela.Rows[i].Cells[j].Value);
                        if ( twr <= szukaj) 
                        {
                            TowaryTabela.Rows[i].Selected = true;
                            w = w + 1;
                            break;
                        }
                    }

                }
            }
            label1.Text = w.ToString();
            if (w == 0)
            {
                MessageBox.Show("Wszystkie towary posiadają stan wiekszy od podanego minimum.","Informacja");
            }

        }

      
         
       
        
    }
}
