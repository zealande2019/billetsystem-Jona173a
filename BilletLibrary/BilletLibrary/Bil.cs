using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Base
    {
        public override decimal Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
