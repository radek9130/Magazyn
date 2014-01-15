using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Xml;
using ObslugaMagazynuLib;
using System.Windows.Forms;


namespace ObslugaMagazynu
{
    public partial class LogowanieForm : Form
    {
        public LogowanieForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void frmNewFormThread()
    {

        Application.Run(new Form1());
     

    }
        string linia;
        string linia2;

        public bool SprawdzNazweiHaslo(string uzytkownik, string haslo)
        {


            uzytkownik = loginbox.Text; string source = "server=sql.elewarr.nazwa.pl;User Id=elewarr_7;database=elewarr_7;port=3307;password=magazynsggw1AB";
            MySqlConnection conn = new MySqlConnection(source);
            string sql = "SELECT * FROM logowanie WHERE login LIKE '" + uzytkownik + "'AND haslo LIKE '" + haslo + "'";
            using (MySqlCommand cmm = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmm.Parameters.AddWithValue("@login", uzytkownik);
                MySqlDataReader sdr; sdr = cmm.ExecuteReader();
                while (sdr.Read())
                {


                    linia = (sdr.GetString(0));

                }


                sdr.Close();

                cmm.Parameters.AddWithValue("@haslo", haslo);
                MySqlDataReader sdr2; sdr2 = cmm.ExecuteReader();
                while (sdr2.Read())
                {


                    linia2 = (sdr2.GetString(0));

                }

                sdr2.Close(); conn.Close();
            }


            if (linia == uzytkownik)
            { }
            if (linia2 == haslo)
            { return true; }
            else
                return false;


        }

        private void LogowanieForm_KeyDown(object sender, KeyEventArgs e)
        {
            string uzytkownik = this.loginbox.Text;
            string haslo = this.haslobox.Text;
                
                if (e.KeyCode == Keys.Return)
                {


                    if (SprawdzNazweiHaslo(uzytkownik, haslo))
                    {
                        
                        System.Threading.Thread newThread;
                        Form1 frmNewForm = new Form1();

                        newThread = new System.Threading.Thread(new System.Threading.ThreadStart(frmNewFormThread));
                        this.Close();
                        newThread.SetApartmentState(System.Threading.ApartmentState.STA);
                        newThread.Start();




                    }
                    else
                    {
                        MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Błąd logowania");
                        return;
                    }
                }
            
        }

        private void zalogujbutton_Click_1(object sender, EventArgs e)
        {
            string uzytkownik = this.loginbox.Text;
            string haslo = this.haslobox.Text;

            if (SprawdzNazweiHaslo(uzytkownik, haslo))
            {
               
                System.Threading.Thread newThread;
                Form1 frmNewForm = new Form1();

                newThread = new System.Threading.Thread(new System.Threading.ThreadStart(frmNewFormThread));
                this.Close();
                newThread.SetApartmentState(System.Threading.ApartmentState.STA);
                newThread.Start();




            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Błąd logowania");
                return;
            }

        }

        

       
    

      

    

       
      
    }
}
