using System.Windows.Forms;
namespace BKE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitel = new System.Windows.Forms.Label();
            this.link2Spelers = new System.Windows.Forms.LinkLabel();
            this.pictureBoxVeld1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVeld9 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHerstarten = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxAfsluiten = new System.Windows.Forms.PictureBox();
            this.link1Speler = new System.Windows.Forms.LinkLabel();
            this.linkKarakterX = new System.Windows.Forms.LinkLabel();
            this.labelKarakterOf = new System.Windows.Forms.Label();
            this.linkKarakterO = new System.Windows.Forms.LinkLabel();
            this.labelWinX = new System.Windows.Forms.Label();
            this.labelGelijk = new System.Windows.Forms.Label();
            this.labelWinO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHerstarten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfsluiten)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.BackColor = System.Drawing.Color.Transparent;
            this.labelTitel.Font = new System.Drawing.Font("Raleway", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitel.ForeColor = System.Drawing.Color.White;
            this.labelTitel.Location = new System.Drawing.Point(0, 10);
            this.labelTitel.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelTitel.MinimumSize = new System.Drawing.Size(300, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(300, 22);
            this.labelTitel.TabIndex = 12;
            this.labelTitel.Text = "Boter, Kaas & Eieren";
            this.labelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link2Spelers
            // 
            this.link2Spelers.ActiveLinkColor = System.Drawing.Color.White;
            this.link2Spelers.AutoSize = true;
            this.link2Spelers.Font = new System.Drawing.Font("Raleway", 24F);
            this.link2Spelers.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link2Spelers.LinkColor = System.Drawing.Color.White;
            this.link2Spelers.Location = new System.Drawing.Point(21, 182);
            this.link2Spelers.Name = "link2Spelers";
            this.link2Spelers.Size = new System.Drawing.Size(258, 38);
            this.link2Spelers.TabIndex = 13;
            this.link2Spelers.TabStop = true;
            this.link2Spelers.Text = "Speler vs Speler";
            this.link2Spelers.Visible = false;
            this.link2Spelers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSpelerVsSpelerClickEventHandler);
            // 
            // pictureBoxVeld1
            // 
            this.pictureBoxVeld1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld1.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld1.Location = new System.Drawing.Point(15, 40);
            this.pictureBoxVeld1.Name = "pictureBoxVeld1";
            this.pictureBoxVeld1.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld1.TabIndex = 14;
            this.pictureBoxVeld1.TabStop = false;
            this.pictureBoxVeld1.Tag = "0";
            this.pictureBoxVeld1.Visible = false;
            this.pictureBoxVeld1.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld2
            // 
            this.pictureBoxVeld2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld2.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld2.Location = new System.Drawing.Point(105, 40);
            this.pictureBoxVeld2.Name = "pictureBoxVeld2";
            this.pictureBoxVeld2.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld2.TabIndex = 22;
            this.pictureBoxVeld2.TabStop = false;
            this.pictureBoxVeld2.Tag = "1";
            this.pictureBoxVeld2.Visible = false;
            this.pictureBoxVeld2.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld3
            // 
            this.pictureBoxVeld3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld3.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld3.Location = new System.Drawing.Point(195, 40);
            this.pictureBoxVeld3.Name = "pictureBoxVeld3";
            this.pictureBoxVeld3.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld3.TabIndex = 15;
            this.pictureBoxVeld3.TabStop = false;
            this.pictureBoxVeld3.Tag = "2";
            this.pictureBoxVeld3.Visible = false;
            this.pictureBoxVeld3.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld4
            // 
            this.pictureBoxVeld4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld4.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld4.Location = new System.Drawing.Point(15, 130);
            this.pictureBoxVeld4.Name = "pictureBoxVeld4";
            this.pictureBoxVeld4.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld4.TabIndex = 20;
            this.pictureBoxVeld4.TabStop = false;
            this.pictureBoxVeld4.Tag = "3";
            this.pictureBoxVeld4.Visible = false;
            this.pictureBoxVeld4.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld5
            // 
            this.pictureBoxVeld5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld5.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld5.Location = new System.Drawing.Point(105, 130);
            this.pictureBoxVeld5.Name = "pictureBoxVeld5";
            this.pictureBoxVeld5.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld5.TabIndex = 19;
            this.pictureBoxVeld5.TabStop = false;
            this.pictureBoxVeld5.Tag = "4";
            this.pictureBoxVeld5.Visible = false;
            this.pictureBoxVeld5.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld6
            // 
            this.pictureBoxVeld6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld6.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld6.Location = new System.Drawing.Point(195, 130);
            this.pictureBoxVeld6.Name = "pictureBoxVeld6";
            this.pictureBoxVeld6.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld6.TabIndex = 21;
            this.pictureBoxVeld6.TabStop = false;
            this.pictureBoxVeld6.Tag = "5";
            this.pictureBoxVeld6.Visible = false;
            this.pictureBoxVeld6.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld7
            // 
            this.pictureBoxVeld7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld7.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld7.Location = new System.Drawing.Point(15, 220);
            this.pictureBoxVeld7.Name = "pictureBoxVeld7";
            this.pictureBoxVeld7.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld7.TabIndex = 17;
            this.pictureBoxVeld7.TabStop = false;
            this.pictureBoxVeld7.Tag = "6";
            this.pictureBoxVeld7.Visible = false;
            this.pictureBoxVeld7.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld8
            // 
            this.pictureBoxVeld8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld8.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld8.Location = new System.Drawing.Point(105, 220);
            this.pictureBoxVeld8.Name = "pictureBoxVeld8";
            this.pictureBoxVeld8.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld8.TabIndex = 18;
            this.pictureBoxVeld8.TabStop = false;
            this.pictureBoxVeld8.Tag = "7";
            this.pictureBoxVeld8.Visible = false;
            this.pictureBoxVeld8.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxVeld9
            // 
            this.pictureBoxVeld9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVeld9.Image = global::BKE.Properties.Resources.veld_leeg;
            this.pictureBoxVeld9.Location = new System.Drawing.Point(195, 220);
            this.pictureBoxVeld9.Name = "pictureBoxVeld9";
            this.pictureBoxVeld9.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxVeld9.TabIndex = 16;
            this.pictureBoxVeld9.TabStop = false;
            this.pictureBoxVeld9.Tag = "8";
            this.pictureBoxVeld9.Visible = false;
            this.pictureBoxVeld9.Click += new System.EventHandler(this.VeldClickEventHandler);
            // 
            // pictureBoxHerstarten
            // 
            this.pictureBoxHerstarten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHerstarten.Image = global::BKE.Properties.Resources.herstarten;
            this.pictureBoxHerstarten.Location = new System.Drawing.Point(137, 368);
            this.pictureBoxHerstarten.Name = "pictureBoxHerstarten";
            this.pictureBoxHerstarten.Size = new System.Drawing.Size(26, 25);
            this.pictureBoxHerstarten.TabIndex = 23;
            this.pictureBoxHerstarten.TabStop = false;
            this.pictureBoxHerstarten.Visible = false;
            this.pictureBoxHerstarten.Click += new System.EventHandler(this.HerstartenClickEventHandler);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenu.Image = global::BKE.Properties.Resources.menu;
            this.pictureBoxMenu.Location = new System.Drawing.Point(46, 368);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(28, 20);
            this.pictureBoxMenu.TabIndex = 24;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Visible = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.MenuClickEventHandler);
            // 
            // pictureBoxAfsluiten
            // 
            this.pictureBoxAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAfsluiten.Image = global::BKE.Properties.Resources.afsluiten;
            this.pictureBoxAfsluiten.Location = new System.Drawing.Point(228, 368);
            this.pictureBoxAfsluiten.Name = "pictureBoxAfsluiten";
            this.pictureBoxAfsluiten.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAfsluiten.TabIndex = 25;
            this.pictureBoxAfsluiten.TabStop = false;
            this.pictureBoxAfsluiten.Visible = false;
            this.pictureBoxAfsluiten.Click += new System.EventHandler(this.AfsluitenClickEventHandler);
            // 
            // link1Speler
            // 
            this.link1Speler.ActiveLinkColor = System.Drawing.Color.White;
            this.link1Speler.AutoSize = true;
            this.link1Speler.Font = new System.Drawing.Font("Raleway", 24F);
            this.link1Speler.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link1Speler.LinkColor = System.Drawing.Color.White;
            this.link1Speler.Location = new System.Drawing.Point(49, 92);
            this.link1Speler.Name = "link1Speler";
            this.link1Speler.Size = new System.Drawing.Size(203, 38);
            this.link1Speler.TabIndex = 26;
            this.link1Speler.TabStop = true;
            this.link1Speler.Text = "Speler vs PC";
            this.link1Speler.Visible = false;
            this.link1Speler.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSpelerVsCompClickEventHandler);
            // 
            // linkKarakterX
            // 
            this.linkKarakterX.ActiveLinkColor = System.Drawing.Color.White;
            this.linkKarakterX.AutoSize = true;
            this.linkKarakterX.Font = new System.Drawing.Font("Raleway", 44F);
            this.linkKarakterX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkKarakterX.LinkColor = System.Drawing.Color.White;
            this.linkKarakterX.Location = new System.Drawing.Point(15, 141);
            this.linkKarakterX.Name = "linkKarakterX";
            this.linkKarakterX.Size = new System.Drawing.Size(60, 69);
            this.linkKarakterX.TabIndex = 27;
            this.linkKarakterX.TabStop = true;
            this.linkKarakterX.Tag = "X";
            this.linkKarakterX.Text = "X";
            this.linkKarakterX.Visible = false;
            this.linkKarakterX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkKarakterClickEventHandler);
            // 
            // labelKarakterOf
            // 
            this.labelKarakterOf.AutoSize = true;
            this.labelKarakterOf.BackColor = System.Drawing.Color.Transparent;
            this.labelKarakterOf.Font = new System.Drawing.Font("Raleway", 30F);
            this.labelKarakterOf.ForeColor = System.Drawing.Color.White;
            this.labelKarakterOf.Location = new System.Drawing.Point(105, 152);
            this.labelKarakterOf.MaximumSize = new System.Drawing.Size(90, 0);
            this.labelKarakterOf.MinimumSize = new System.Drawing.Size(90, 0);
            this.labelKarakterOf.Name = "labelKarakterOf";
            this.labelKarakterOf.Size = new System.Drawing.Size(90, 47);
            this.labelKarakterOf.TabIndex = 28;
            this.labelKarakterOf.Text = "of";
            this.labelKarakterOf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKarakterOf.Visible = false;
            // 
            // linkKarakterO
            // 
            this.linkKarakterO.ActiveLinkColor = System.Drawing.Color.White;
            this.linkKarakterO.AutoSize = true;
            this.linkKarakterO.Font = new System.Drawing.Font("Raleway", 44F);
            this.linkKarakterO.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkKarakterO.LinkColor = System.Drawing.Color.White;
            this.linkKarakterO.Location = new System.Drawing.Point(210, 141);
            this.linkKarakterO.Name = "linkKarakterO";
            this.linkKarakterO.Size = new System.Drawing.Size(91, 69);
            this.linkKarakterO.TabIndex = 29;
            this.linkKarakterO.TabStop = true;
            this.linkKarakterO.Tag = "O";
            this.linkKarakterO.Text = "O";
            this.linkKarakterO.Visible = false;
            this.linkKarakterO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkKarakterClickEventHandler);
            // 
            // labelWinX
            // 
            this.labelWinX.AutoSize = true;
            this.labelWinX.BackColor = System.Drawing.Color.Transparent;
            this.labelWinX.Font = new System.Drawing.Font("Raleway", 14F);
            this.labelWinX.ForeColor = System.Drawing.Color.White;
            this.labelWinX.Location = new System.Drawing.Point(15, 324);
            this.labelWinX.MaximumSize = new System.Drawing.Size(90, 0);
            this.labelWinX.MinimumSize = new System.Drawing.Size(90, 0);
            this.labelWinX.Name = "labelWinX";
            this.labelWinX.Size = new System.Drawing.Size(90, 22);
            this.labelWinX.TabIndex = 30;
            this.labelWinX.Text = "X: 0";
            this.labelWinX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWinX.Visible = false;
            // 
            // labelGelijk
            // 
            this.labelGelijk.AutoSize = true;
            this.labelGelijk.BackColor = System.Drawing.Color.Transparent;
            this.labelGelijk.Font = new System.Drawing.Font("Raleway", 14F);
            this.labelGelijk.ForeColor = System.Drawing.Color.White;
            this.labelGelijk.Location = new System.Drawing.Point(105, 324);
            this.labelGelijk.MaximumSize = new System.Drawing.Size(90, 0);
            this.labelGelijk.MinimumSize = new System.Drawing.Size(90, 0);
            this.labelGelijk.Name = "labelGelijk";
            this.labelGelijk.Size = new System.Drawing.Size(90, 22);
            this.labelGelijk.TabIndex = 31;
            this.labelGelijk.Text = "Gelijk: 0";
            this.labelGelijk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGelijk.Visible = false;
            // 
            // labelWinO
            // 
            this.labelWinO.AutoSize = true;
            this.labelWinO.BackColor = System.Drawing.Color.Transparent;
            this.labelWinO.Font = new System.Drawing.Font("Raleway", 14F);
            this.labelWinO.ForeColor = System.Drawing.Color.White;
            this.labelWinO.Location = new System.Drawing.Point(195, 324);
            this.labelWinO.MaximumSize = new System.Drawing.Size(90, 0);
            this.labelWinO.MinimumSize = new System.Drawing.Size(90, 0);
            this.labelWinO.Name = "labelWinO";
            this.labelWinO.Size = new System.Drawing.Size(90, 44);
            this.labelWinO.TabIndex = 32;
            this.labelWinO.Text = "O: 0";
            this.labelWinO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWinO.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(300, 404);
            this.Controls.Add(this.labelWinO);
            this.Controls.Add(this.labelGelijk);
            this.Controls.Add(this.labelWinX);
            this.Controls.Add(this.linkKarakterO);
            this.Controls.Add(this.labelKarakterOf);
            this.Controls.Add(this.linkKarakterX);
            this.Controls.Add(this.link1Speler);
            this.Controls.Add(this.pictureBoxAfsluiten);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.pictureBoxHerstarten);
            this.Controls.Add(this.link2Spelers);
            this.Controls.Add(this.pictureBoxVeld2);
            this.Controls.Add(this.pictureBoxVeld6);
            this.Controls.Add(this.pictureBoxVeld4);
            this.Controls.Add(this.pictureBoxVeld5);
            this.Controls.Add(this.pictureBoxVeld8);
            this.Controls.Add(this.pictureBoxVeld7);
            this.Controls.Add(this.pictureBoxVeld9);
            this.Controls.Add(this.pictureBoxVeld3);
            this.Controls.Add(this.pictureBoxVeld1);
            this.Controls.Add(this.labelTitel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 443);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 443);
            this.Name = "Form1";
            this.Text = "Boter, Kaas & Eieren";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeld9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHerstarten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfsluiten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.LinkLabel link2Spelers;
        private System.Windows.Forms.PictureBox pictureBoxVeld1;
        private System.Windows.Forms.PictureBox pictureBoxVeld3;
        private System.Windows.Forms.PictureBox pictureBoxVeld9;
        private System.Windows.Forms.PictureBox pictureBoxVeld7;
        private System.Windows.Forms.PictureBox pictureBoxVeld8;
        private System.Windows.Forms.PictureBox pictureBoxVeld5;
        private System.Windows.Forms.PictureBox pictureBoxVeld4;
        private System.Windows.Forms.PictureBox pictureBoxVeld6;
        private System.Windows.Forms.PictureBox pictureBoxVeld2;
        private PictureBox pictureBoxHerstarten;
        private PictureBox pictureBoxMenu;
        private PictureBox pictureBoxAfsluiten;
        private LinkLabel link1Speler;
        private LinkLabel linkKarakterX;
        private Label labelKarakterOf;
        private LinkLabel linkKarakterO;
        private Label labelWinX;
        private Label labelGelijk;
        private Label labelWinO;
    }
}