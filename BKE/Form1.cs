using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKE
{
    public partial class Form1 : Form
    {
        private static Form1 form = null;
        private dynamic spel = new Spel1Speler(); // Dynamisch omdat het uit 2 verschillende classes geinstantieerd kan worden

        private delegate void EnableDelegateElementenTonen(String element);
        private delegate void EnableDelegateTitelWijzigen(String tekst);
        private delegate void EnableDelegateComputerZetPlaatsen();
        private delegate void EnableDelegateScoreWijzigen(String element, int score);

        public Form1()
        {
            InitializeComponent();

            form = this;

            spel.NaarMenu();
        }

        public static void StaticComputerZetPlaatsen()
        {
            if (form != null)
            {
                Random rnd = new Random();
                int scnds = rnd.Next(250, 1000); // Laat computer tussen een halve en 2 seconden wachten alvorens hij zet doet

                System.Timers.Timer timer = new System.Timers.Timer(scnds);
                timer.Elapsed += new System.Timers.ElapsedEventHandler((sender, e) => OnTimedEvent(sender, e, timer));
                timer.Enabled = true;

                //form.ComputerZetPlaatsen();
            }
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e, System.Timers.Timer timer)
        {
            timer.Stop();
            form.ComputerZetPlaatsen();
        }

        public void ComputerZetPlaatsen()
        {
            if (InvokeRequired)
            {
                this.Invoke(new EnableDelegateComputerZetPlaatsen(ComputerZetPlaatsen), new object[] { });
                return;
            }

            PictureBox veld = new PictureBox();

            int computerZet = spel.GeefComputerZet();

            switch (computerZet)
            {
                case 0:
                    veld = pictureBoxVeld1;
                    break;
                case 1:
                    veld = pictureBoxVeld2;
                    break;
                case 2:
                    veld = pictureBoxVeld3;
                    break;
                case 3:
                    veld = pictureBoxVeld4;
                    break;
                case 4:
                    veld = pictureBoxVeld5;
                    break;
                case 5:
                    veld = pictureBoxVeld6;
                    break;
                case 6:
                    veld = pictureBoxVeld7;
                    break;
                case 7:
                    veld = pictureBoxVeld8;
                    break;
                case 8:
                    veld = pictureBoxVeld9;
                    break;
            }

            char veldChar = spel.ZetPlaatsen(Convert.ToInt16(computerZet));

            switch (veldChar)
            {
                case 'X':
                    veld.Image = Properties.Resources.veld_x;
                    break;
                case 'O':
                    veld.Image = Properties.Resources.veld_o;
                    break;
            }
        }

        public static void StaticElementenTonen(String element)
        {
            if (form != null)
                form.ElementenTonen(element);
        }

        public void ElementenTonen(String element)
        {
            if (InvokeRequired)
            {
                this.Invoke(new EnableDelegateElementenTonen(ElementenTonen), new object[] { element });
                return;
            }

            // Verberg eerst alle elementen van de form
            form.link1Speler.Visible = false;
            form.link2Spelers.Visible = false;

            form.pictureBoxMenu.Visible = false;
            form.pictureBoxHerstarten.Visible = false;
            form.pictureBoxAfsluiten.Visible = false;

            form.linkKarakterX.Visible = false;
            form.linkKarakterO.Visible = false;
            form.labelKarakterOf.Visible = false;

            form.labelWinX.Visible = false;
            form.labelGelijk.Visible = false;
            form.labelWinO.Visible = false;

            pictureBoxVeld1.Visible = false;
            pictureBoxVeld2.Visible = false;
            pictureBoxVeld3.Visible = false;
            pictureBoxVeld4.Visible = false;
            pictureBoxVeld5.Visible = false;
            pictureBoxVeld6.Visible = false;
            pictureBoxVeld7.Visible = false;
            pictureBoxVeld8.Visible = false;
            pictureBoxVeld9.Visible = false;


            // Toon per scenario de juiste elementen
            switch (element)
            {
                case "menu":
                    form.link1Speler.Visible = true;
                    form.link2Spelers.Visible = true;
                    break;
                case "karakterKiezen":
                    form.linkKarakterX.Visible = true;
                    form.linkKarakterO.Visible = true;
                    form.labelKarakterOf.Visible = true;

                    form.pictureBoxMenu.Visible = true;
                    form.pictureBoxAfsluiten.Visible = true;
                    break;
                case "bord":
                    form.labelWinX.Visible = true;
                    form.labelGelijk.Visible = true;
                    form.labelWinO.Visible = true;
                    
                    pictureBoxVeld1.Visible = true;
                    pictureBoxVeld2.Visible = true;
                    pictureBoxVeld3.Visible = true;
                    pictureBoxVeld4.Visible = true;
                    pictureBoxVeld5.Visible = true;
                    pictureBoxVeld6.Visible = true;
                    pictureBoxVeld7.Visible = true;
                    pictureBoxVeld8.Visible = true;
                    pictureBoxVeld9.Visible = true;

                    form.pictureBoxMenu.Visible = true;
                    form.pictureBoxHerstarten.Visible = true;
                    form.pictureBoxAfsluiten.Visible = true;
                    break;
            }
        }

        public static void StaticTitelWijzigen(String tekst)
        {
            if (form != null)
                form.TitelWijzigen(tekst);
        }

        public void TitelWijzigen(String tekst)
        {
            if (InvokeRequired)
            {
                this.Invoke(new EnableDelegateTitelWijzigen(TitelWijzigen), new object[] { tekst });
                return;
            }

            form.labelTitel.Text = tekst;
        }

        public static void StaticScoreWijzigen(String element, int score)
        {
            if (form != null)
                form.ScoreWijzigen(element, score);
        }

        public void ScoreWijzigen(String element, int score)
        {
            if (InvokeRequired)
            {
                this.Invoke(new EnableDelegateScoreWijzigen(ScoreWijzigen), new object[] { element, score });
                return;
            }

            switch (element)
            {
                case "X":
                    labelWinX.Text = "X: " + Convert.ToString(score);
                    break;
                case "gelijk":
                    labelGelijk.Text = "Gelijk: " + Convert.ToString(score);
                    break;
                case "O":
                    labelWinO.Text = "O: " + Convert.ToString(score);
                    break;
            }
        }

        private void LinkSpelerVsSpelerClickEventHandler(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Start Speler vs Speler, gebruik de class: Spel2Spelers
            spel = new Spel2Spelers();
            spel.Starten();
        }

        private void LinkSpelerVsCompClickEventHandler(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Start Speler vs Computer, gebruik de class: Spel1Speler
            spel = new Spel1Speler();
            spel.KarakterKiezen();
        }

        private void LinkKarakterClickEventHandler(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel karakterKeuze = (LinkLabel)sender;

            spel.KaraktersToewijzen(Convert.ToString(karakterKeuze.Tag));
        }

        private void MenuClickEventHandler(object sender, EventArgs e)
        {
            form.labelWinX.Text = "X: 0";
            form.labelGelijk.Text = "Gelijk: 0";
            form.labelWinO.Text = "O: 0";
            
            // Leeg alle velden
            pictureBoxVeld1.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld2.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld3.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld4.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld5.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld6.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld7.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld8.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld9.Image = Properties.Resources.veld_leeg;
            
            // Keer terug naar menu
            spel.NaarMenu();
        }

        private void HerstartenClickEventHandler(object sender, EventArgs e)
        {
            // Leeg alle velden
            pictureBoxVeld1.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld2.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld3.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld4.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld5.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld6.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld7.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld8.Image = Properties.Resources.veld_leeg;
            pictureBoxVeld9.Image = Properties.Resources.veld_leeg;

            // Herstart spel -> velden legen etc.
            spel.Herstarten();
        }

        private void AfsluitenClickEventHandler(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Weet u zeker dat u de toepassing wilt verlaten?", "Verzoek voor bevestiging", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void VeldClickEventHandler(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            char veldChar = ' ';

            if (spel is Spel1Speler) // Als speler tegen computer speelt moet hij aan de beurt zijn
            {
                if(!spel.IsComputerAanBeurt())
                {
                    veldChar = spel.ZetPlaatsen(Convert.ToInt16(pb.Tag));
                }
            }
            else
            {
                veldChar = spel.ZetPlaatsen(Convert.ToInt16(pb.Tag));
            }

            switch(veldChar)
            {
                case 'X':
                    pb.Image = Properties.Resources.veld_x;
                    break;
                case 'O':
                    pb.Image = Properties.Resources.veld_o;
                    break;
            }
        }
    }
}