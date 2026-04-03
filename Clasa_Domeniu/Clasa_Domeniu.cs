using System.Numerics;

namespace Clasa_Domeniu
{
    public enum Dificultate
    {
        usor = 1,
        mediu = 2,
        greu = 3
    }
    public enum timp_sugerat
    {
        sec60 = 1,
        sec90 = 2,
        sec120 = 3
    }
    public class domeniu // (????? public class?)
    {
        
        
        string name;
        float highscore ;
        short streak;
        int[] intrebare;
        int nr_intrebari; ///intrebare.Length10
                               ///public domeniu(string nume);
        public domeniu()
        {
            name = string.Empty;
            highscore = 0.0f;
            streak = 0;
            intrebare = null; ///vector gol?
            nr_intrebari = 0;
        }
        public domeniu(string nume)
        {
            name = nume;
            highscore = 0.0f;
            streak = 0;
            intrebare = null; ///vector gol?
            nr_intrebari = 0;
        }

        public void afisare_detalii()
        {
            Console.WriteLine(name, highscore, streak, intrebare);
        }
        public string Name { get { return name; } set { name = value; } } // VALUE = INPUT FOR METHOD ( supposedly ) !
        public float Highscore { get { return highscore; } set { highscore = value; } }
        public short Streak { get; set; }
        public int[] Intrebare { get; set; }
        public int Nr_intrebari { get; set; }


        public void SetIntrebari(char[] _intrebari)
        {
            intrebare = new int[_intrebari.Length];
            _intrebari.CopyTo(intrebare, 0);
        }

        public static domeniu CitiredomeniuTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();
            domeniu x = new domeniu(nume);
            Console.Write("Introduceti numarul de intrebari: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            x.nr_intrebari = nr; //setter de mai sus


            ///setam un vector de siruri de caractere pentru a retine intrebarile urmatoare:
            char[] copie_intrebari= { };
            int copie_numar = 0;
            for (int i=0;i<nr;i++)
            {
                ///sirul pe care il punem in vectorul de siruri:
                string l;
                Console.Write($"Intrebarea {i + 1}: ");
                l = Console.ReadLine();
                copie_intrebari[copie_numar] = Convert.ToChar(l); ///CANNOT IMPLICITLY CONVERT STRING TO CHAR~! 
                copie_numar++;
            }
            x.SetIntrebari(copie_intrebari);
            return x;
        }





    }
}


///de ce alta clasa program  (Main reference)?
class program
{
    static void Main()
    {

    }
}