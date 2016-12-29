using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKE
{
    class Veld
    {
        #region Properties

        private Mogelijkheden veldStatus = Mogelijkheden.L;

        #endregion

        #region Getters and Setters
        public Mogelijkheden VeldStatus
        {
            get
            {
                return veldStatus;
            }
            set
            {
                veldStatus = value;
            }
        }

        #endregion
    }
}
