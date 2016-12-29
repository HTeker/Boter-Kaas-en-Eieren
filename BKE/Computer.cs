using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKE
{
    class Computer
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

        #region Methods
        public int ZetBerekenen(Veld[] velden, List<int> beschikbareVelden, List<int> dekWinMogelijkheden)
        {
            Random rnd = new Random();

            int hoekDekken = HoekDekken(velden, beschikbareVelden);

            if (WinnendeZet(velden) != -1)
                return WinnendeZet(velden);         // Eerste prioriteit: eigen win
            else if (dekWinMogelijkheden.Count != 0) // Tweede prioriteit: winmogelijkheid speler dekken
                return dekWinMogelijkheden[rnd.Next(0, dekWinMogelijkheden.Count)];
            else if (hoekDekken != -1)          // Derde prioriteit: hoek dekken
                return hoekDekken;
            else                                 // Vierde prioriteit: hoogste winkans spelen
                return HoogsteWinkansBerekenen(beschikbareVelden);
        }

        public int WinnendeZet(Veld[] velden)
        {
            // Plaats winnende zet als computer kan winnen
            int computerZet = -1;

            if (velden[0].VeldStatus == Mogelijkheden.L
                && ((velden[1].VeldStatus == karakter && velden[1].VeldStatus == velden[2].VeldStatus)
                || (velden[3].VeldStatus == karakter && velden[3].VeldStatus == velden[6].VeldStatus)
                || (velden[4].VeldStatus == karakter && velden[4].VeldStatus == velden[8].VeldStatus)))
            {
                // veld 0 is een winmogelijkheid
                computerZet = 0;
            }

            if (velden[1].VeldStatus == Mogelijkheden.L
                && ((velden[0].VeldStatus == karakter && velden[0].VeldStatus == velden[2].VeldStatus)
                || (velden[4].VeldStatus == karakter && velden[4].VeldStatus == velden[7].VeldStatus)))
            {
                // veld 1 is een winmogelijkheid
                computerZet = 1;
            }

            if (velden[2].VeldStatus == Mogelijkheden.L
                && ((velden[0].VeldStatus == karakter && velden[0].VeldStatus == velden[1].VeldStatus)
                || (velden[5].VeldStatus == karakter && velden[5].VeldStatus == velden[8].VeldStatus)
                || (velden[4].VeldStatus == karakter && velden[4].VeldStatus == velden[6].VeldStatus)))
            {
                // veld 2 is een winmogelijkheid
                computerZet = 2;
            }

            if (velden[3].VeldStatus == Mogelijkheden.L
                && ((velden[4].VeldStatus == karakter && velden[4].VeldStatus == velden[5].VeldStatus)
                || (velden[0].VeldStatus == karakter && velden[0].VeldStatus == velden[6].VeldStatus)))
            {
                // veld 3 is een winmogelijkheid
                computerZet = 3;
            }

            if (velden[4].VeldStatus == Mogelijkheden.L
                && ((velden[3].VeldStatus == karakter && velden[3].VeldStatus == velden[5].VeldStatus)
                || (velden[1].VeldStatus == karakter && velden[1].VeldStatus == velden[7].VeldStatus)
                || (velden[0].VeldStatus == karakter && velden[0].VeldStatus == velden[8].VeldStatus)
                || (velden[2].VeldStatus == karakter && velden[2].VeldStatus == velden[6].VeldStatus)))
            {
                // veld 4 is een winmogelijkheid
                computerZet = 4;
            }

            if (velden[5].VeldStatus == Mogelijkheden.L
                && ((velden[3].VeldStatus == karakter && velden[3].VeldStatus == velden[4].VeldStatus)
                || (velden[2].VeldStatus == karakter && velden[2].VeldStatus == velden[8].VeldStatus)))
            {
                // veld 5 is een winmogelijkheid
                computerZet = 5;
            }

            if (velden[6].VeldStatus == Mogelijkheden.L
                && ((velden[0].VeldStatus == karakter && velden[0].VeldStatus == velden[3].VeldStatus)
                || (velden[7].VeldStatus == karakter && velden[7].VeldStatus == velden[8].VeldStatus)
                || (velden[2].VeldStatus == karakter && velden[2].VeldStatus == velden[4].VeldStatus)))
            {
                // veld 6 is een winmogelijkheid
                computerZet = 6;
            }

            if (velden[7].VeldStatus == Mogelijkheden.L
                && ((velden[6].VeldStatus == karakter && velden[6].VeldStatus == velden[8].VeldStatus)
                || (velden[1].VeldStatus == karakter && velden[1].VeldStatus == velden[4].VeldStatus)))
            {
                // veld 7 is een winmogelijkheid
                computerZet = 7;
            }

            if (velden[8].VeldStatus == Mogelijkheden.L
                && ((velden[6].VeldStatus == karakter && velden[6].VeldStatus == velden[7].VeldStatus)
                || (velden[2].VeldStatus == karakter && velden[2].VeldStatus == velden[5].VeldStatus)
                || (velden[0].VeldStatus == karakter && velden[0].VeldStatus == velden[4].VeldStatus)))
            {
                // veld 8 is een winmogelijkheid
                computerZet = 8;
            }

            return computerZet;
        }

        public int HoekDekken(Veld[] velden, List <int> beschikbareVelden)
        {
            // Als de speler in tegengestelde hoeken heeft geplaatst, plaats NIET in een hoek

            int computerZet = -1;
            Boolean tegengesteldeHoek = false;

            if (velden[0].VeldStatus != karakter && velden[0].VeldStatus != Mogelijkheden.L && velden[0].VeldStatus == velden[8].VeldStatus)
                tegengesteldeHoek = true;
            if (velden[2].VeldStatus != karakter && velden[2].VeldStatus != Mogelijkheden.L && velden[2].VeldStatus == velden[6].VeldStatus)
                tegengesteldeHoek = true;

            if(tegengesteldeHoek)
            {
                // Selecteer een beschikbare veld
                Random rnd = new Random();
                Boolean geenHoek = false;

                while (!geenHoek) // Herhaal zolang gekozen veld een hoek is
                {
                    computerZet = beschikbareVelden[rnd.Next(0, beschikbareVelden.Count)];

                    if (computerZet != 0 && computerZet != 2 && computerZet != 6 && computerZet != 8)
                        geenHoek = true;
                }
            }

            return computerZet;
        }

        public int HoogsteWinkansBerekenen(List<int> beschikbareVelden)
        {
            Random rnd = new Random();
            List<int> hoogsteSelectieVelden = new List<int>();

            int[] winKansVelden = new int[9];
            winKansVelden[0] = 3;
            winKansVelden[1] = 2;
            winKansVelden[2] = 3;

            winKansVelden[3] = 2;
            winKansVelden[4] = 4;
            winKansVelden[5] = 2;

            winKansVelden[6] = 3;
            winKansVelden[7] = 2;
            winKansVelden[8] = 3;

            Boolean eenKeer = true;
            int laatsteSelectie = 0;
            int hoogsteWinkans = 0;
            int hoogsteWinkansVeld = 0;

            for (int i = 0; i < beschikbareVelden.Count; i++)
            {
                int selectie = beschikbareVelden[i];

                if (winKansVelden[selectie] > hoogsteWinkans)
                {
                    hoogsteWinkans = winKansVelden[selectie];
                    hoogsteWinkansVeld = selectie;
                    laatsteSelectie = i;
                }
                else if (winKansVelden[selectie] == hoogsteWinkans)
                {
                    if (eenKeer)
                    {
                        eenKeer = false;
                        hoogsteSelectieVelden.Add(beschikbareVelden[laatsteSelectie]);
                    }

                    hoogsteSelectieVelden.Add(beschikbareVelden[i]);
                }
            }

            if (hoogsteSelectieVelden.Count != 0)
                if (winKansVelden[hoogsteSelectieVelden[0]] < hoogsteWinkans)
                    hoogsteSelectieVelden = new List<int>();

            if(hoogsteSelectieVelden.Count == 0)
                return hoogsteWinkansVeld;
            else
                return hoogsteSelectieVelden[rnd.Next(0, hoogsteSelectieVelden.Count)];
        }

        #endregion
    }
}