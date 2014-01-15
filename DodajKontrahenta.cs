using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Kontrahenci;


namespace ObslugaMagazynu
{
    public partial class DodajKontrahenta : Form
    {
        public DodajKontrahenta()
        {
            InitializeComponent();
        }
        Kontrahent editedItem = null;
        public DodajKontrahenta(Kontrahent t)
            : this()
        {
            if (t != null)
            {
                editedItem = t;
                textBox1.Text = editedItem.Nazwa.ToString();
                textBox2.Text = editedItem.Adres.ToString();
                textBox3.Text = editedItem.Nip.ToString();
                textBox4.Text = editedItem.Regon.ToString();
                textBox5.Text = editedItem.Pesel.ToString();
                textBox7.Text = editedItem.Nr_kontaktowy.ToString();

            }
            button1.Text = "Edytuj";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Dodaj")
            {
                bool flag = true;
                ListaKontrahentow lista = ListaKontrahentow.Instance;
                Kontrahent k = new Kontrahent();
                try
                {

                    k.Nazwa = textBox1.Text.ToString();
                    k.Adres = textBox2.Text.ToString();
                    if (textBox3.Text.ToString() != "") k.Nip = Convert.ToInt64(textBox3.Text.ToString());
                    if (textBox4.Text.ToString()!="") k.Regon = Convert.ToInt64(textBox4.Text.ToString());
                    k.Pesel = Convert.ToInt64(textBox5.Text.ToString());
                    k.Nr_kontaktowy = textBox7.Text.ToString();
                    k.DataRejestracji = DateTime.Now.ToString();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message.ToString());
                    flag = false;
                }
                if (flag)
                {

                    if (lista.dodaj(k))
                    {
                        MessageBox.Show("Dodano kontrahenta!");
                    }
                    else
                    {
                        MessageBox.Show("Nie dodano kontrahenta! Wystąpił niezidentyfikowany błąd");
                    }
                    this.Close();
                }
            }
            else if (button1.Text== "Edytuj")
            {
                bool flag = true;
                ListaKontrahentow lista = ListaKontrahentow.Instance;
                Kontrahent k = new Kontrahent();
                try
                {
                    k.Nazwa = textBox1.Text.ToString();
                    k.Adres = textBox2.Text.ToString();
                    if (Convert.ToInt64(textBox3.Text.ToString()) > 0) k.Nip = Convert.ToInt64(textBox3.Text.ToString());
                    if (Convert.ToInt64(textBox4.Text.ToString())>0) k.Regon = Convert.ToInt64(textBox4.Text.ToString());
                    k.Pesel = Convert.ToInt64(textBox5.Text.ToString());
                    k.Nr_kontaktowy = textBox7.Text.ToString();
                    k.DataRejestracji = DateTime.Now.ToString();
                    k.Id = editedItem.Id;
                }

                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message.ToString());
                    flag = false;
                }
                if (flag)
                {
                    if (lista.edytuj(k))
                    {
                        MessageBox.Show("Zmieniono kontrahenta!");
                    }
                    else
                    {
                        MessageBox.Show("Nie dodano kontrahenta! Wystąpił niezidentyfikowany błąd");
                    }
                    this.Close();
                }
                
            }
        }
    }
    }

