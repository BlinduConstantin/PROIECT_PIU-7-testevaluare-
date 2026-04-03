namespace Clasa_Player
{
    public enum varsta
    {
        v0_18=1,
        v18_35=2,
        v35_60=3,
        vp60=4
    }
    class player
    {
        string nume = "";
        float scor_1_recent = 0.0f;///ultima incercare scor test 1 
        float scor_2_recent = 0.0f;
        float scor_3_recent = 0.0f;
        float scor_4_recent = 0.0f;///ultima incercare scor test 4

        public player()
        {   
            nume = string.Empty;
            scor_1_recent = 0.0f;
            scor_2_recent = 0.0f;
            scor_3_recent = 0.0f;
            scor_4_recent = 0.0f;
        }
        public player(string name)
        {
            nume = name;
            scor_1_recent = 0.0f;
            scor_2_recent = 0.0f;
            scor_3_recent = 0.0f;
            scor_4_recent = 0.0f;
        }
        public player(string nume = "",
                    float scor_1_recent = 0.0f,
                    float scor_2_recent = 0.0f,
                    float scor_3_recent = 0.0f,
                    float scor_4_recent = 0.0f)
        {
            this.nume = nume;
            this.scor_1_recent = scor_1_recent;
            this.scor_2_recent = scor_2_recent;
            this.scor_3_recent = scor_3_recent;
            this.scor_4_recent = scor_4_recent;
        }
        public void setter_nume(string nume_dat)
        {
            nume = nume_dat;
        }
        public string getter_nume()
        {
            return nume;
        }
    }
}


class program
{
    static void Main()
    {

    }
}