using System.Numerics;

namespace Clasa_Domeniu
{
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


       /* public static domeniu CitireTastatura()
        {

            return this;
        }*/

    }
}


///de ce alta clasa program  (Main reference)?
class program
{
    static void Main()
    {

    }
}