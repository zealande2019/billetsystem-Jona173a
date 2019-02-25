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
        public string MCNummerplade
        {
            get { return MCNummerplade; }
            set
            {
                if (MCNummerplade.Length <= 8)
                {
                    MCNummerplade = value;
                }
                else
                {
                    throw new ArgumentException("sdffsdx");
                }
            }
        }

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
