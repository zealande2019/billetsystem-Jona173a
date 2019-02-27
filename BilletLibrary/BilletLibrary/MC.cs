using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Base
    {
        /// <summary>
        /// Metode som gør at nummerpladen maks kan have 7 tegn.
        /// </summary>
        public override string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length > 8)
                {
                    Nummerplade = value;
                    throw new ArgumentException("Du har skrevet for mange tegn!");
                }
                else
                {
                    _nummerplade = value;
                }
            }
        }
        /// <summary>
        /// Override af Pris og Køretøj
        /// </summary>
        /// <returns></returns>

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
