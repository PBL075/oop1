using System;

namespace audi
{
    class Audi
    {
        public string model = "";
        public string culoare = "";
        public int pret;
        public static int count = 0;

        public Audi(string _model , string _culoare , int _pret)
        {
            model = _model;
            culoare = _culoare;
            pret = _pret;
            count++;
        }
        public void setDate()
        {
            Console.WriteLine(" Model la audi: " + model + " culoarea " + culoare + " pretul in euro " + pret);
        }
    }
}