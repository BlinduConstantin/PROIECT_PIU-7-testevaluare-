using System.Numerics;

class domeniu
{
    string name = "";
    float scor = 0.0f;
    float highscore = 0.0f;
    short streak = 0;
    int[] intrebare = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    ///int nr_intrebari = intrebare.Length; ///10
    ///public domeniu(string nume);
    public domeniu(string nume)
    {

    }
    public void afisare_detalii()
    {
        Console.WriteLine(name, scor, highscore, streak, intrebare);
    }
}

class jucator
{
    string nume = "";
    float highscore_1 = 0.0f; ///test 1
    float highscore_2 = 0.0f;
    float highscore_3 = 0.0f;
    float highscore_4 = 0.0f; ///test 4

}

class Program
{
    static void Main()
    {
        ///domeniu p;
        ///p.afisare_detalii;
    }
}