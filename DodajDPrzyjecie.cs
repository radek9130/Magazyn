using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Dokumenty;
using ObslugaMagazynuLib.Kontrahenci;
using ObslugaMagazynuLib.Towary;
using ObslugaMagazynu;


namespace ObslugaMagazynu
{
    public partial class DodajDPrzyjecie : Form
    {

        private BindingList<Towar> _source = null;

        public DodajDPrzyjecie()
        {
            InitializeComponent();
            _source = new BindingList<Towar>();
        }


        Form2 chooseClient = new Form2(true);
        int clientId = 0;
        ListaKontrahentow listaKontrahentow = ListaKontrahentow.Instance;

        List<int> chooseProductsList = new List<int>();
        ListaTowarow listaTowarow = ListaTowarow.Instance;


        private void button3_Click(object sender, EventArgs e)
        {
            Towary2 chooseProducts = new Towary2(chooseProductsList);
            chooseProducts.ShowDialog(this);

            _source.Clear();

            foreach (int i in chooseProductsList)
            {
                Towar temp = new Towar(
                    listaTowarow.Pick(i).Nazwa,
                    listaTowarow.Pick(i).Cena,
                    listaTowarow.Pick(i).Vat,
                    listaTowarow.Pick(i).Jm,
                    listaTowarow.Pick(i).Nr_kat,
                    listaTowarow.Pick(i).Stan,
                    listaTowarow.Pick(i).Id
                    );
                _source.Add(temp);
            }


            dataGridView1.DataSource = _source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("Numer nie może być pusty");
                if (textBox2.Text == "") throw new Exception("Seria nie może być pusta");

                if (button1.Text == "Przyjmij")
                {
                    bool flag = true; 
                    DokPrzyjecie k = new DokPrzyjecie();
                    try
                    {

                        k.Id = Convert.ToInt32(textBox1.Text);
                        k.Series = Convert.ToInt32(textBox2.Text.ToString());
                        k.Date = dateTimePicker1.Value;
                        k.Year = dateTimePicker1.Value.Year;

                        int tempCounter = 0;
                        foreach(int i in chooseProductsList)
                        {                            
                            Towar temp = new Towar(
                                listaTowarow.Pick(i).Nazwa,
                                listaTowarow.Pick(i).Cena,
                                listaTowarow.Pick(i).Vat,
                                listaTowarow.Pick(i).Jm,
                                listaTowarow.Pick(i).Nr_kat,
                                Convert.ToInt32(dataGridView1.Rows[tempCounter].Cells[3].Value),
                                listaTowarow.Pick(i).Id
                                );                             
                            k.Elements._towarList.Add(temp);
                            tempCounter++;
                        }

                        k.ClientName = "Magazyn";



                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.Message.ToString());
                        flag = false;
                    }
                    if (flag)
                    {  
                        k.Execute();
                        MessageBox.Show("Przyjęto towary!");
                        ListaTowarow.Instance.MarkAsChanged();
                        this.Close();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Błąd! " + err.Message);
            }


        }



       
    }
}
