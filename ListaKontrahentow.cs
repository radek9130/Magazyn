using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObslugaMagazynuLib;
using ObslugaMagazynuLib.Towary;
using System.Windows.Forms;


namespace ObslugaMagazynuLib.Kontrahenci
{
    public class ListaKontrahentow : List<Kontrahent>
    {
        private static ListaKontrahentow instance;
        protected List<Kontrahent> _list = new List<Kontrahent>();
        /// <summary>
        /// konstruktor klasy wypełniający liste danymi pobranymi z bazy danych za pomocą metody wczytajZDB(), metoda prywatna, dostęp przez metode instance.
        /// </summary>
        private ListaKontrahentow()
        { this.wczytajZDB(); 
        }
        /// <summary>
        /// metoda zwracająca utworzoną listę, lub jeżeli lista nie istnieje wywołująca konstruktor
        /// </summary>
        public static ListaKontrahentow Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListaKontrahentow();
                }
                return instance;
            }
        }        
        /// <summary>
        /// metoda przyjmująca jako argument obiekt klasy kontrahent a następnie zapisująca go do bazy danych
        /// </summary>

        public bool dodaj(Kontrahent k)
        {
            if (k.Id == 0)
            {
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("INSERT INTO kontrahenci(kontrahent_nazwa, kontrahent_adres, kontrahent_nip, kontrahent_regon, kontrahent_pesel, kontrahent_nr_kontaktowy, kontrahent_data_rejestracji) VALUES('" + k.Nazwa + "','" + k.Adres + "','" + k.Nip + "','" + k.Regon + "','" + k.Pesel + "','" + k.Nr_kontaktowy + "','" + k.DataRejestracji + "')");
                if (flag != null)
                {
                   this.Clear();
                   this.wczytajZDB();
                    return true;
                   

                }
                else
                {
                    throw new KontrahenciException("Nie można dodać Kontrahenta");
                }
            }

            return false;
        }
        /// <summary>
        /// Zapisuje zmiany dokonane na obiekcie kontrahenta
        /// </summary>

        public bool edytuj(Kontrahent k)
        {
            
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("UPDATE kontrahenci SET kontrahent_nazwa='" + k.Nazwa + "', kontrahent_adres='" + k.Adres + "', kontrahent_nip='" + k.Nip + "', kontrahent_regon='" + k.Regon + "', kontrahent_pesel='" + k.Pesel + "', kontrahent_nr_kontaktowy='" + k.Nr_kontaktowy + "' WHERE kontrahent_id=" + k.Id + " LIMIT 1");
                if (flag != null)
                {
                    this.Clear();
                    this.wczytajZDB();
                    return true;


                }
                else
                {
                    throw new KontrahenciException("Nie można zmienić Kontrahenta");
                }
            

            
        }
        /// <summary>
        /// wczytuje z bazy kontrahenta o podanym id, zwraca obiekt klasy kontrahent
        /// </summary>

        public Kontrahent Wczytaj(int id)
        {
           
            MySQL sql = MySQL.Instance;
            
            int? flag = sql.Query("SELECT * from kontrahenci where kontrahent_id="+id.ToString()+" LIMIT 1");
            if (flag != null)
            {
                Kontrahent k = new Kontrahent();
                k.Id = Convert.ToInt32(sql.RowByName("kontrahent_id", flag));
                k.Nazwa = sql.RowByName("kontrahent_nazwa", flag);
                k.Adres = sql.RowByName("kontrahent_adres", flag);
                if (Convert.ToInt64(sql.RowByName("kontrahent_nip", flag)) > 0) k.Nip = Convert.ToInt64(sql.RowByName("kontrahent_nip", flag));
                if (Convert.ToInt64(sql.RowByName("kontrahent_regon", flag)) > 0) k.Regon = Convert.ToInt64(sql.RowByName("kontrahent_regon", flag));
                k.Pesel = Convert.ToInt64(sql.RowByName("kontrahent_pesel", flag));
                k.Nr_kontaktowy = sql.RowByName("kontrahent_nr_kontaktowy", flag);
                k.DataRejestracji = sql.RowByName("kontrahent_data_rejestracji", flag);

                return k;
            }
            return null;
        }
        /// <summary>
        /// metoda nadpisuje dane kontrahenta przekazanego jako argumnet danymi z bazy danych dla jednakowego ID
        /// </summary>

        public Kontrahent Wczytaj(Kontrahent ko)
        {
            Kontrahent temp = new Kontrahent();
            temp=Wczytaj( Convert.ToInt32(ko.Id));
            return temp;

        }
        /// <summary>
        /// Wczytanie wszystkich kontrahentów do listy kontrahentów
        /// </summary>
        public  void wczytajZDB()
        {
            this.Clear();
            MySQL sql = MySQL.Instance;
            int? flag = sql.Query("SELECT * FROM kontrahenci");
            if (flag != null)
            {
                while (sql.Fetch(flag))
                {
                    Kontrahent k = new Kontrahent();
                       k.Id=Convert.ToInt32(sql.RowByName("kontrahent_id", flag));
                       k.Nazwa=sql.RowByName("kontrahent_nazwa", flag);
                       k.Adres=sql.RowByName("kontrahent_adres", flag);
                       if (Convert.ToInt64(sql.RowByName("kontrahent_nip", flag))>0) k.Nip = Convert.ToInt64(sql.RowByName("kontrahent_nip", flag));
                       if (Convert.ToInt64(sql.RowByName("kontrahent_regon", flag))>0) k.Regon = Convert.ToInt64(sql.RowByName("kontrahent_regon", flag));
                       k.Pesel=Convert.ToInt64(sql.RowByName("kontrahent_pesel", flag));
                       k.Nr_kontaktowy=sql.RowByName("kontrahent_nr_kontaktowy", flag);
                       k.DataRejestracji=sql.RowByName("kontrahent_data_rejestracji", flag);
                   

                    this.Add(k);
                }
            }
        }
        /// <summary>
        /// Nadpisanie istniejących rekordów w bazie rekordami z listy kontrahentow oraz dodanie nowchy pozycji
        /// </summary>
        public  void zapiszDoDB()
        {
            foreach (Kontrahent k in _list)
            {
                if (k.Id != 0 && k.ChangedFlag == true)
                {
                    MySQL sql = MySQL.Instance;
                    int? flaga = sql.Query("UPDATE kontrahenci SET  WHERE kontrahent_id =" + k.Id.ToString());
                    if (flaga != null)
                    {
                        throw new KontrahenciException("Nie udało się zaktualizować bazy kontrahentów.");
                    }

                }
                else if (k.Id == 0)
                {
                    MySQL sql = MySQL.Instance;
                    int? flaga = sql.Query("INSERT INTO kontrahenci(kontrahent_nazwa, kontrahent_adres, kontrahent_nip, kontrahent_regon, kontrahent_pesel, kontrahent_nr_kontaktowy, kontrahent_data_rejestracji) VALUES('" + k.Nazwa + "','" + k.Adres + "','" + k.Nip + "','" + k.Regon + "','" + k.Pesel + "','" + k.Nr_kontaktowy + "','" + k.DataRejestracji + "')");
                    if (flaga != null)
                    {
                        throw new KontrahenciException("Nie udało się zaktualizować bazy kontrahentów.");
                    }
                }
                else throw new KontrahenciException("Nie udało się zaktualizować bazy kontrahentów.");
            }
        }

        /// <summary>
        /// skasowanie z listy kontrahenta o wskazanym Id (nie kasuje to faktur wystawionych na tą osobę.
        /// </summary>
   
        public bool usun(int id)
        {
            MySQL sql = MySQL.Instance;
         
                int? flag = sql.Query("DELETE FROM kontrahenci WHERE kontrahent_id = " + id.ToString());
                if (flag == null)
                {
                    return false;
                }
                else
                {
                    this.Clear();
                    this.wczytajZDB();
                    return true;
                }
            
          
          
        }
        /// <summary>
        /// kasuje podany obiekt wywołując metodę usun(int id)
        /// </summary>

        public bool usun(Kontrahent k)
        {
            bool flag = usun(k.Id);
            if (flag == true)
            {
              return true;

            }
            else throw new KontrahenciException("Wystąpił błąd. Operacja nieudana!");
            

        }
/// <summary>
/// usunięcie kontrahenta z listy kontrahentów, nie jest jednoznaczne z usunięciem wpisu z bazy
/// </summary>
        public void Pop(Kontrahent k)
        {
            foreach (Kontrahent kon in this)
            {
                if (k.Equals(kon))
                {
                    this.Remove(kon);
                    this.Rebind();
                                   }
            }
        }
        /// <summary>
        /// zwraca kontrahenta o podanym id z listy nie usuwając go jednak z listy
        /// </summary>

        public Kontrahent Pick(int n)
        {
            List<Kontrahent> temp = new List<Kontrahent>();
            foreach (Kontrahent kon in this)
            {
                if (kon.Id == n) { temp.Add(kon); }
            }
            if (temp.Count == 1) return temp[0];
            else throw new KontrahenciException("Wystąpił problem ze zgodnością danych.");
        }

/// <summary>
/// funkcja służąca do odświeżenia dancyh w DataGridView
/// </summary>
        public void Rebind()
        {
            getBindingSource().DataSource = null;
            getBindingSource().DataSource = this;
        }

        /// <summary>
        /// bindowanie dancyh do DGV
        /// </summary>
        BindingSource s = null;
        public BindingSource getBindingSource()
        {

            if (s == null)
            {
                s = new BindingSource();
                s.DataSource = this;
            }
            return s;
        }

    }
}
