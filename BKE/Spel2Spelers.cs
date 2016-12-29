using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKE
{
    class Spel2Spelers:Spel
    {
        #region Methods
        public void Starten()
        {
            Form1.StaticElementenTonen("bord"); // Toon alle elementen van het bord
            Form1.StaticTitelWijzigen("X begint..");
        }

        public void Herstarten()
        {
            BeurtWisselen();

            Form1.StaticTitelWijzigen(Convert.ToString(beurt) + " kan beginnen");

            bord.VeldenLegen();
        }

        public char ZetPlaatsen(int veldPos)
        {
            char veldChar;

            // Als het veld beschikbaar is en geen winnaar is plaats dan de zet
            if (bord.IsVeldBeschikbaar(veldPos) && !bord.IsWinnaar())
            {
                bord.ZetPlaatsen(veldPos, beurt);
                WinnaarChecken();
                GelijkspelChecken();

                if (beurt == Mogelijkheden.X)
                    veldChar = 'X';
                else
                    veldChar = 'O';

                if (!bord.IsWinnaar() && !bord.IsGelijkspel())
                    BeurtWisselen(); // Voer enkel uit als spel doorgaat
            }
            else
                veldChar = '-';

            return veldChar;
        }

        #endregion
    }
}
