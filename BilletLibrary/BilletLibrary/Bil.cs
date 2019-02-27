using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Base
    {
        /// <summary>
        /// Metode som gør at nummerpladen maks kan have 7 tegn.
        /// </summary>
        public string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Du har skrevet for mange tegn!");
                }
                else
                {
                    _nummerplade = value;
                }
            }
        }

        /// <summary>
        /// Override af Pris og køretøj
        /// </summary>
        /// <returns></returns>
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
