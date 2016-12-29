using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKE
{
    class Bord
    {
        #region Properties

        public Veld[] velden = new Veld[9];

        #endregion

        #region Constructor
        public Bord()
        {
            for (int i = 0; i < velden.Length; i++)
                velden[i] = new Veld();
        }

        #endregion

        #region Methods

        public void ZetPlaatsen(int veldPos, Mogelijkheden beurt)
        {
            velden[veldPos].VeldStatus = beurt;
        }

        public void VeldenLegen()
        {
            for (int i = 0; i < velden.Length; i++)
                velden[i].VeldStatus = Mogelijkheden.L;
        }

        public Veld[] GeefVelden()
        {
            return velden;
        }

        public List<int> GeefAlleBeschikbareVelden()
        {
            List<int> beschikbareVelden = new List<int>();

            for (int i = 0; i < velden.Length; i++)
            {
                if (velden[i].VeldStatus == Mogelijkheden.L)
                    beschikbareVelden.Add(i);
            }

            return beschikbareVelden;
        }

        public List<int> GeefWinMogelijkheden()
        {
            List<int> winMogelijkheden = new List<int>();

            if (velden[0].VeldStatus == Mogelijkheden.L
                && ((velden[1].VeldStatus != Mogelijkheden.L && velden[1].VeldStatus == velden[2].VeldStatus)
                || (velden[3].VeldStatus != Mogelijkheden.L && velden[3].VeldStatus == velden[6].VeldStatus)
                || (velden[4].VeldStatus != Mogelijkheden.L && velden[4].VeldStatus == velden[8].VeldStatus)))
            {
                // veld 0 is een winmogelijkheid
                winMogelijkheden.Add(0);
            }

            if (velden[1].VeldStatus == Mogelijkheden.L
                && ((velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[2].VeldStatus)
                || (velden[4].VeldStatus != Mogelijkheden.L && velden[4].VeldStatus == velden[7].VeldStatus)))
            {
                // veld 1 is een winmogelijkheid
                winMogelijkheden.Add(1);
            }

            if (velden[2].VeldStatus == Mogelijkheden.L
                && ((velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[1].VeldStatus)
                || (velden[5].VeldStatus != Mogelijkheden.L && velden[5].VeldStatus == velden[8].VeldStatus)
                || (velden[4].VeldStatus != Mogelijkheden.L && velden[4].VeldStatus == velden[6].VeldStatus)))
            {
                // veld 2 is een winmogelijkheid
                winMogelijkheden.Add(2);
            }

            if (velden[3].VeldStatus == Mogelijkheden.L
                && ((velden[4].VeldStatus != Mogelijkheden.L && velden[4].VeldStatus == velden[5].VeldStatus)
                || (velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[6].VeldStatus)))
            {
                // veld 3 is een winmogelijkheid
                winMogelijkheden.Add(3);
            }

            if (velden[4].VeldStatus == Mogelijkheden.L
                && ((velden[3].VeldStatus != Mogelijkheden.L && velden[3].VeldStatus == velden[5].VeldStatus)
                || (velden[1].VeldStatus != Mogelijkheden.L && velden[1].VeldStatus == velden[7].VeldStatus)
                || (velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[8].VeldStatus)
                || (velden[2].VeldStatus != Mogelijkheden.L && velden[2].VeldStatus == velden[6].VeldStatus)))
            {
                // veld 4 is een winmogelijkheid
                winMogelijkheden.Add(4);
            }

            if (velden[5].VeldStatus == Mogelijkheden.L
                && ((velden[3].VeldStatus != Mogelijkheden.L && velden[3].VeldStatus == velden[4].VeldStatus)
                || (velden[2].VeldStatus != Mogelijkheden.L && velden[2].VeldStatus == velden[8].VeldStatus)))
            {
                // veld 5 is een winmogelijkheid
                winMogelijkheden.Add(5);
            }

            if (velden[6].VeldStatus == Mogelijkheden.L
                && ((velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[3].VeldStatus)
                || (velden[7].VeldStatus != Mogelijkheden.L && velden[7].VeldStatus == velden[8].VeldStatus)
                || (velden[2].VeldStatus != Mogelijkheden.L && velden[2].VeldStatus == velden[4].VeldStatus)))
            {
                // veld 6 is een winmogelijkheid
                winMogelijkheden.Add(6);
            }

            if (velden[7].VeldStatus == Mogelijkheden.L
                && ((velden[6].VeldStatus != Mogelijkheden.L && velden[6].VeldStatus == velden[8].VeldStatus)
                || (velden[1].VeldStatus != Mogelijkheden.L && velden[1].VeldStatus == velden[4].VeldStatus)))
            {
                // veld 7 is een winmogelijkheid
                winMogelijkheden.Add(7);
            }

            if (velden[8].VeldStatus == Mogelijkheden.L
                && ((velden[6].VeldStatus != Mogelijkheden.L && velden[6].VeldStatus == velden[7].VeldStatus)
                || (velden[2].VeldStatus != Mogelijkheden.L && velden[2].VeldStatus == velden[5].VeldStatus)
                || (velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[4].VeldStatus)))
            {
                // veld 8 is een winmogelijkheid
                winMogelijkheden.Add(8);
            }

            return winMogelijkheden;
        }

        public Boolean IsVeldBeschikbaar(int veldPos)
        {
            if (velden[veldPos].VeldStatus == Mogelijkheden.L)
                return true;
            return false;
        }

        public Boolean IsWinnaar()
        {
            // Horizontale checks
            if (velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[1].VeldStatus && velden[1].VeldStatus == velden[2].VeldStatus)
                return true;
            if (velden[3].VeldStatus != Mogelijkheden.L && velden[3].VeldStatus == velden[4].VeldStatus && velden[4].VeldStatus == velden[5].VeldStatus)
                return true;
            if (velden[6].VeldStatus != Mogelijkheden.L && velden[6].VeldStatus == velden[7].VeldStatus && velden[7].VeldStatus == velden[8].VeldStatus)
                return true;

            // Verticale checks
            if (velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[3].VeldStatus && velden[3].VeldStatus == velden[6].VeldStatus)
                return true;
            if (velden[1].VeldStatus != Mogelijkheden.L && velden[1].VeldStatus == velden[4].VeldStatus && velden[4].VeldStatus == velden[7].VeldStatus)
                return true;
            if (velden[2].VeldStatus != Mogelijkheden.L && velden[2].VeldStatus == velden[5].VeldStatus && velden[5].VeldStatus == velden[8].VeldStatus)
                return true;

            // Diagonale checks
            if (velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[4].VeldStatus && velden[4].VeldStatus == velden[8].VeldStatus)
                return true;
            if (velden[2].VeldStatus != Mogelijkheden.L && velden[2].VeldStatus == velden[4].VeldStatus && velden[4].VeldStatus == velden[6].VeldStatus)
                return true;

            return false;
        }

        public Boolean IsGelijkspel()
        {
            Boolean vol = true;

            for (int i = 0; i < velden.Length; i++)
            {
                if (velden[i].VeldStatus == Mogelijkheden.L)
                    vol = false;
            }

            return vol;
        }

        #endregion
    }
}