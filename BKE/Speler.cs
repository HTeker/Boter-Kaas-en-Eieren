using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKE
{
    class Speler
    {
        #region Properties

        private Mogelijkheden karakter;

        #endregion

        #region Getters and Setters
        public Mogelijkheden Karakter
        {
            get
            {
                return karakter;
            }
            set
            {
                karakter = value;
            }
        }

        #endregion
    }
}
