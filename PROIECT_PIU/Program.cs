using System.Numerics;
using Clasa_Domeniu;
using Clasa_Player;
using Clasa_Highscore;
///for me : ^ Contains numeric types that complement the numeric primitives, such as Byte, Double, and Int32, that are defined by .NET.
 





class Program
{
    static int Main()
    {
        domeniu? DomeniuNou=null;

        List<domeniu> DOMENII = new List<domeniu>();
        /// creezi o lista de DOMENII prin sintaxa :List<#nume_clasa_de_obiecte#> NUME_LISTA = new List<#nume_clasa_obiecte>();
        string optiune = string.Empty;
        do
        {
            Console.WriteLine("C. Citirea informatiilor pentru domeniu de la tastatura");
            Console.WriteLine("I. Afisarea informatiilor despre ultimul domeniu introdus");
            Console.WriteLine("A. Afisare domeniu din lista");
            Console.WriteLine("S. Salvare domeniu in lista");
            Console.WriteLine("X. Inchidere program");
            Console.WriteLine("Alegeti o optiune");
            optiune = Console.ReadLine()?.ToUpper();
            switch(optiune)
            {
                case "C":
                    ////CS0176: Static member 'member' cannot be accessed with an instance reference;
                    ////qualify it with a type name instead
                    
                    DomeniuNou=domeniu.CitiredomeniuTastatura();
                    ///Am incercat sa accesez metoda statica dintr-o instanta de obiect
                    ///PEntru a accesa metoda statica, ne folosim de NUMELE CLASEI !
                    break;
                case "I":
                    Console.WriteLine(DomeniuNou);
                    break;
                case "A":
                    break;
                case "S":
                    break;
                case "X":
                    return 0;
                default:
                    Console.WriteLine("Optiune inexistenta");
                    break;
            }

        } while (true);

        return 0;
    }
}