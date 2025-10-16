using System.IO;

namespace vaja6 {

    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

    class Igralec {
        private int id;
        private string u_ime;
        private string u_geslo;
        private static int stIg = 1;

        // Konstruktor
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        // Lastnost ID
        public int Id {
            get
            {
                return id;
            }
        }

        // Lastnost U_ime
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        //LAstnost U_geslo
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        //Statična lastnost StIg
        public static int StIg
        {
            get { return stIg; }
        }
    }

    // Razred vaja
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
