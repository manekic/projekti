using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskaRecepcija
{
    public partial class Naslovnica : Form
    {
        public Naslovnica()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void noviGostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoviGost novi = new NoviGost();
            novi.ShowDialog();
        }

        private void popisGostijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopisGostiju popis = new PopisGostiju();
            popis.ShowDialog();
        }

        private void izdajRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Racun racun = new Racun();
            racun.ShowDialog();
        }

        private void dostupneSobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DostupneSobe sobe = new DostupneSobe();
            sobe.ShowDialog();
        }

        private void noćenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nocenja nocenja = new Nocenja();
            nocenja.ShowDialog();
        }

        private void rasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspored raspored = new Raspored();
            raspored.ShowDialog();
        }

        private void popisUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopisUsluga usluge = new PopisUsluga();
            usluge.ShowDialog();
        }

        private void rezervacijaUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervacijaUsluge rezUsluge = new RezervacijaUsluge();
            rezUsluge.ShowDialog();
        }

        private void naplatiUsluguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NaplatiUslugu naplati = new NaplatiUslugu();
            naplati.ShowDialog();
        }

        private void popisRezerviranihUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezerviraneUsluge rez = new RezerviraneUsluge();
            rez.ShowDialog();
        }

        private void novoZaduženjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromjenaZaduženja promjena = new PromjenaZaduženja();
            promjena.ShowDialog();
        }


        private void noviZaposlenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajZaposlenika novi = new DodajZaposlenika();
            novi.ShowDialog();
        }

        private void karakteristikeSobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KarakteristikeSoba karakteristike = new KarakteristikeSoba();
            karakteristike.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu slastice = new Menu();
            slastice.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
