using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Base
    {
        //Properties af Pris og køretøj
        //Laves abstract da de skal overrides
        public abstract decimal Pris();
        public abstract string Køretøj();
        public DateTime Dato { get; set; }
        public abstract string _nummerplade { get; set; }

        public string PrintInfo()
        {
            return ($"Dato: {Dato}\nKøretøjet: {Køretøj()} \nPris: {Pris()}");
        }
    }
}
