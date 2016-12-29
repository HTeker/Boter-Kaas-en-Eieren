using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKE
{
    class Spel1Speler:Spel
    {
        #region Properties
        private Speler speler = new Speler();
        private Computer computer = new Computer();
        #endregion

        #region Methods

        public void Starten()
        {
            Form1.StaticElementenTonen("bord");
            Form1.StaticTitelWijzigen("X begint..");

            if (computer.Karakter == beurt)
                Form1.StaticComputerZetPlaatsen();
        }

        public void Herstarten()
        {
            BeurtWisselen();

            Form1.StaticTitelWijzigen(Convert.ToString(beurt) + " kan beginnen");

            bord.VeldenLegen();

            if (computer.Karakter == beurt)
                Form1.StaticComputerZetPlaatsen();
        }

        public void KarakterKiezen()
        {
            Form1.StaticElementenTonen("karakterKiezen");

            Form1.StaticTitelWijzigen("Kies uw karakter");
        }

        public void KaraktersToewijzen(string karakterKeuze)
        {
            if (karakterKeuze == "X")
            {
                speler.Karakter = Mogelijkheden.X;
                computer.Karakter = Mogelijkheden.O;
            }
            else
            {
                speler.Karakter = Mogelijkheden.O;
                computer.Karakter = Mogelijkheden.X;
            }

            Starten();
        }

        public char ZetPlaatsen(int veldPos)
        {
            char veldChar = ' ';

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

                // Laat computer zet plaatsen wanneer de speler een zet plaatst
                if (IsComputerAanBeurt())
                    Form1.StaticComputerZetPlaatsen();
            }
            else
                veldChar = '-';

            return veldChar;
        }

        public int GeefComputerZet()
        {
            return computer.ZetBerekenen(bord.GeefVelden() ,bord.GeefAlleBeschikbareVelden(), bord.GeefWinMogelijkheden());
        }

        public Boolean IsComputerAanBeurt()
        {
            if (computer.Karakter == beurt)
                return true;
            else
                return false;
        }

        #endregion
    }
}
