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

        public string PrintInfo()
        {
            return ($"Køretøjet: {Køretøj()} \nPris: {Pris()}");
        }
    }
}
