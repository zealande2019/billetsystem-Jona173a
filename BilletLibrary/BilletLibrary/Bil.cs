using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Base
    {
        /// <summary>
        /// Metode som gør at nummerpladen maks kan have 7 tegn.
        /// </summary>
        public string BilNummerplade
        {
            get { return BilNummerplade; }
            set
            {
                if (BilNummerplade.Length <= 8)
                {
                    BilNummerplade = value;
                }
                else
                {
                    throw new ArgumentException($"sdffsdx - du skev {value}");
                }
            }
        }

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
