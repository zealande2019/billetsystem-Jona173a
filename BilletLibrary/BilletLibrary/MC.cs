using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Base
    {
        //public string Nummerplade()
        //{
        //    if (Nummerplade > 7)
        //    {

        //    }
        //}
        public override decimal Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }


    }
}
