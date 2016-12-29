using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKE
{
    abstract class Spel
    {
        #region Properties

        protected Bord bord = new Bord();
        protected Mogelijkheden beurt = Mogelijkheden.X;

        protected int aantalWinX = 0;
        protected int aantalWinO = 0;
        protected int aantalGelijk = 0;

        #endregion

        #region Methods
        
        public void NaarMenu()
        {
            bord.VeldenLegen();
            
            Form1.StaticElementenTonen("menu"); // Toon elementen van het hoofdmenu
            Form1.StaticTitelWijzigen("Boter, Kaas & Eieren");

            aantalWinX = 0;
            aantalWinO = 0;
            aantalGelijk = 0;
        }

        public void BeurtWisselen()
        {
            if (beurt == Mogelijkheden.X)
                beurt = Mogelijkheden.O;
            else
                beurt = Mogelijkheden.X;

            Form1.StaticTitelWijzigen(Convert.ToString(beurt) + " is aan de beurt..");
        }

        public void WinnaarChecken()
        {
            if (bord.IsWinnaar())
            {
                Form1.StaticTitelWijzigen(Convert.ToString(beurt) + " heeft gewonnen!");
                
                if(beurt == Mogelijkheden.X)
                {
                    aantalWinX++;
                    Form1.StaticScoreWijzigen(Convert.ToString(beurt), aantalWinX);
                }
                else if (beurt == Mogelijkheden.O)
                {
                    aantalWinO++;
                    Form1.StaticScoreWijzigen(Convert.ToString(beurt), aantalWinO);
                }
            }
        }

        public void GelijkspelChecken()
        {
            if (bord.IsGelijkspel())
            {
                Form1.StaticTitelWijzigen("Het is een gelijkspel");
                aantalGelijk++;
                Form1.StaticScoreWijzigen("gelijk", aantalGelijk);
            }
        }

        #endregion
    }
}