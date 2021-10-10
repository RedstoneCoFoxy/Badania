﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadaniaNFZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime localDate = DateTime.Now;
        bool Debug = true;
        int NextFreeAdress = 0;
        int PotrzebnyAdress = 0;
        string WybranaData = "";
        string WybraneImie = "";
        string WybraneNazwa = "";

        public class Badania
        {
            public int Adres { get; set; }
            public int AdresNext { get; set; }
            public int AdresPrev { get; set; }
            public string Data { get; set; }
            public string Imie { get; set; }
            public string Nazwa { get; set; }
            public override string ToString()
            {
                return Adres + " / " + Data + " " + Imie + " " + Nazwa;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Badania objBadanie = obj as Badania;
                if (objBadanie == null) return false;
                else return Equals(objBadanie);
            }
            public override int GetHashCode()
            {
                return Adres;
            }
            public bool Equals(Badania other)
            {
                if (other == null) return false;
                return (this.Adres.Equals(other.Adres));
            }
        }/// ================================================================
        List<Badania> WszystkieBadania = new List<Badania>();
        // https://docs.microsoft.com/pl-pl/dotnet/api/system.collections.generic.list-1?view=net-5.0#definition
        



        void WriteDebug()
        {
            if (Debug) { DebugText.Text = WybranaData + " | " + WybraneImie + " " + WybraneNazwa; };
        }

        double ReturnTimeDate(string date)
        {          
            DateTime DataZmienna;
            double WypiszDate = 0;
            DataZmienna = DateTime.Parse(date);
            WypiszDate = Math.Ceiling((DataZmienna.Subtract(localDate).TotalDays));
            return WypiszDate;

        }
        void UpdateQueue()
        {
            double Dni;
            if (WszystkieBadania.Contains(new Badania { Adres = PotrzebnyAdress }))
            {
                ObecneBadanie.Text = WszystkieBadania.Find(x => x.Adres.Equals(PotrzebnyAdress)).ToString();
                Dni=ReturnTimeDate(WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == PotrzebnyAdress)].Data);
                ObecneDni.Text = "/";
                ObecneDni.ForeColor = Color.Black;
                ObecneDni.Font = new Font(ObecneDni.Font, ObecneDni.Font.Style & ~FontStyle.Italic);
                if (Dni > 0)
                {
                    ObecneDni.Text ="Za:"+ Dni.ToString() + " dni";
                    ObecneDni.Font = new Font(ObecneDni.Font, ObecneDni.Font.Style & ~FontStyle.Italic & ~FontStyle.Bold);
                }
                if (Dni < 0)
                {
                    Dni = Dni * -1;
                    ObecneDni.Text ="Bylo:" + Dni.ToString() + " dni";
                    ObecneDni.Font = new Font(ObecneDni.Font, ObecneDni.Font.Style & ~FontStyle.Italic);
                }
                if (Dni == 0)
                {
                    ObecneDni.Text = "Dzis";
                    ObecneDni.ForeColor = Color.Red;
                    ObecneDni.Font = new Font(ObecneDni.Font, ObecneDni.Font.Style & ~FontStyle.Italic & ~FontStyle.Bold);
                }

            }
            else
            {
                ObecneBadanie.Text = "/";
                ObecneDni.Text = "/";
                ObecneDni.ForeColor = Color.Black;
            }

            if (WszystkieBadania.Contains(new Badania { Adres = PotrzebnyAdress - 1 }))
            {
                PoprzednieBadanie.Text = WszystkieBadania.Find(x => x.Adres.Equals(PotrzebnyAdress - 1)).ToString();
                Dni = ReturnTimeDate(WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == PotrzebnyAdress - 1)].Data);
                PoprzednieDni.Text = "/";
                PoprzednieDni.ForeColor = Color.Black;
                PoprzednieDni.Font = new Font(PoprzednieDni.Font, PoprzednieDni.Font.Style & ~FontStyle.Italic);
                if (Dni > 0)
                {
                    PoprzednieDni.Text = "Za: " + Dni.ToString()+" dni";
                    PoprzednieDni.Font = new Font(PoprzednieDni.Font, PoprzednieDni.Font.Style & ~FontStyle.Italic & ~FontStyle.Bold);
                }
                if (Dni < 0)
                {
                    Dni = Dni * -1;
                    PoprzednieDni.Text = "Bylo: " + Dni.ToString() + " dni";
                    PoprzednieDni.Font = new Font(PoprzednieDni.Font, PoprzednieDni.Font.Style & ~FontStyle.Italic);
                }
                if (Dni == 0)
                {
                    PoprzednieDni.Text = "Dzis";
                    PoprzednieDni.ForeColor = Color.Red;
                    PoprzednieDni.Font = new Font(PoprzednieDni.Font, PoprzednieDni.Font.Style & ~FontStyle.Italic & ~FontStyle.Bold);
                }
            }
            else
            {
                PoprzednieBadanie.Text = "/";
                PoprzednieDni.Text = "/";
                PoprzednieDni.ForeColor = Color.Black;
            }

            if (WszystkieBadania.Contains(new Badania { Adres = PotrzebnyAdress + 1 }))
            {
                NastepneBadanie.Text = WszystkieBadania.Find(x => x.Adres.Equals(PotrzebnyAdress + 1)).ToString();
                Dni = ReturnTimeDate(WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == PotrzebnyAdress + 1)].Data);
                NastepneDni.Text = "/";
                NastepneDni.ForeColor = Color.Black;
                NastepneDni.Font = new Font(NastepneDni.Font, NastepneDni.Font.Style & ~FontStyle.Italic);
                if (Dni > 0)
                {
                    NastepneDni.Text = "Za:" + Dni.ToString() + " dni";
                    NastepneDni.Font = new Font(NastepneDni.Font, NastepneDni.Font.Style & ~FontStyle.Italic & ~FontStyle.Bold);
                }
                if (Dni < 0)
                {
                    Dni = Dni * -1;
                    NastepneDni.Text = "Bylo:" + Dni.ToString() + " dni";
                    NastepneDni.Font = new Font(NastepneDni.Font, NastepneDni.Font.Style & ~FontStyle.Italic);
                }
                if (Dni == 0)
                {
                    NastepneDni.Text = "Dzis";
                    NastepneDni.ForeColor = Color.Red;
                    NastepneDni.Font = new Font(NastepneDni.Font, NastepneDni.Font.Style & ~FontStyle.Italic & ~FontStyle.Bold);
                }
            }
            else
            {
                NastepneBadanie.Text = "/";
                NastepneDni.Text = "/";
                NastepneDni.ForeColor = Color.Black;
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NoweBadanie_Imie_TextChanged(object sender, EventArgs e)
        {
            WybraneImie = NoweBadanie_Imie.Text;
            WybraneNazwa = NoweBadanie_Nazwa.Text;
            WybranaData = NoweBadanie_Datomierz.Value.ToString("dd-MM-yyyy");
            WriteDebug();
        }

        private void NoweBadanie_Nazwa_TextChanged(object sender, EventArgs e)
        {
            WybraneImie = NoweBadanie_Imie.Text;
            WybraneNazwa = NoweBadanie_Nazwa.Text;
            WybranaData = NoweBadanie_Datomierz.Value.ToString("dd-MM-yyyy");
            WriteDebug();
        }

        private void NoweBadanie_Datomierz_ValueChanged(object sender, EventArgs e)
        {
            WybraneImie = NoweBadanie_Imie.Text;
            WybraneNazwa = NoweBadanie_Nazwa.Text;
            WybranaData = NoweBadanie_Datomierz.Value.ToString("dd-MM-yyyy");
            WriteDebug();
        }

        private void DodajBadanie_Click(object sender, EventArgs e)
        {
            if (WybranaData!="" && WybraneImie!="" && WybraneNazwa!="") { 
            WszystkieBadania.Add(new Badania() { Adres = NextFreeAdress, AdresNext = NextFreeAdress+1, AdresPrev = NextFreeAdress - 1, Data=WybranaData,Imie=WybraneImie,Nazwa=WybraneNazwa }); ;
            NextFreeAdress= NextFreeAdress+1;
            WybranaData = "";
            WybraneImie = "";
            WybraneNazwa = "";
            WriteDebug();
            }
        }

        private void Sekundownik10_Tick(object sender, EventArgs e)
        {
            UpdateQueue();
            localDate = DateTime.Now;
            DataCzasLabel.Text = localDate.ToString("dd-MM-yyyy | HH-mm");
        }

        private void ButtonPoprzednieBadanie_Click(object sender, EventArgs e)
        {
            if (PotrzebnyAdress!=0) { PotrzebnyAdress = PotrzebnyAdress - 1; };
            LabelWybranaPozycja.Text = PotrzebnyAdress.ToString();
            UpdateQueue();
        }

        private void ButtonNastepneBadanie_Click(object sender, EventArgs e)
        {
            PotrzebnyAdress = PotrzebnyAdress + 1;
            LabelWybranaPozycja.Text = PotrzebnyAdress.ToString();
            UpdateQueue();
        }

        private void ButtonUsunBadanie_Click(object sender, EventArgs e)
        {
            int UsuwanieLicznik = PotrzebnyAdress;
            //WszystkieBadania.Find(x => x.Adres.Equals(PotrzebnyAdress)).ToString();
            //WszystkieBadania.Contains(new Badania { Adres = PotrzebnyAdress })

            WszystkieBadania.Remove(new Badania() { Adres = PotrzebnyAdress });
            UsuwanieLicznik = UsuwanieLicznik + 1;
            while(WszystkieBadania.Contains(new Badania { Adres = UsuwanieLicznik }))
            {
                
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == UsuwanieLicznik)].AdresNext = UsuwanieLicznik;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == UsuwanieLicznik)].AdresPrev = UsuwanieLicznik - 2;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == UsuwanieLicznik)].Adres = UsuwanieLicznik - 1;
                UsuwanieLicznik = UsuwanieLicznik + 1;
            }
            UpdateQueue();
        }

        private void ButtonMoveUp1_Click(object sender, EventArgs e)
        {
            int EdycjaLicznik = PotrzebnyAdress;
            if (WszystkieBadania.Contains(new Badania { Adres = EdycjaLicznik })&& WszystkieBadania.Contains(new Badania { Adres = EdycjaLicznik+1 }))
            {
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik)].AdresNext = -1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik)].AdresPrev = -1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik)].Adres = -1;

                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik + 1)].AdresNext = EdycjaLicznik+1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik + 1)].AdresPrev = EdycjaLicznik-1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik + 1)].Adres = EdycjaLicznik;

                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == - 1)].AdresNext = EdycjaLicznik + 2;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == - 1)].AdresPrev = EdycjaLicznik;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == - 1)].Adres = EdycjaLicznik+1;

                PotrzebnyAdress = PotrzebnyAdress + 1;
            }
            UpdateQueue();
        }

        private void ButtonMoveDown1_Click(object sender, EventArgs e)
        {
            int EdycjaLicznik = PotrzebnyAdress;
            if (WszystkieBadania.Contains(new Badania { Adres = EdycjaLicznik }) && WszystkieBadania.Contains(new Badania { Adres = EdycjaLicznik - 1 }))
            {
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik)].AdresNext = -1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik)].AdresPrev = -1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik)].Adres = -1;

                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik-1)].AdresNext = EdycjaLicznik+1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik-1)].AdresPrev = EdycjaLicznik-1;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == EdycjaLicznik-1)].Adres = EdycjaLicznik;

                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == -1)].AdresNext = EdycjaLicznik;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == -1)].AdresPrev = EdycjaLicznik - 2;
                WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == -1)].Adres = EdycjaLicznik - 1;

                PotrzebnyAdress = PotrzebnyAdress - 1;
            }
            UpdateQueue();
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            if (FileName.Text != "")
            {
                    string text = "";
                    int licznik = 0;
                    while (WszystkieBadania.Contains(new Badania { Adres = licznik })|| WszystkieBadania.Contains(new Badania { Adres = licznik+1 }) || WszystkieBadania.Contains(new Badania { Adres = licznik+2 }) || WszystkieBadania.Contains(new Badania { Adres = licznik+3 })) { 
                    if(WszystkieBadania.Contains(new Badania { Adres = licznik })) {

                        text = text + WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == licznik)].Adres + " " + WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == licznik)].Data + " " + WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == licznik)].Imie + " " + WszystkieBadania[WszystkieBadania.FindIndex(a => a.Adres == licznik)].Nazwa + " " + "\n";
                    }
                    else
                    {
                       text = text + "/" + "\n";
                    }
                        licznik = licznik + 1;
                    }
                    string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName.Text+".txt");
                    File.WriteAllText(destPath, text.ToString());
            }
        }

        private void ObecneDni_Click(object sender, EventArgs e)
        {

        }

        private void PoprzednieDni_Click(object sender, EventArgs e)
        {

        }

        private void NastepneDni_Click(object sender, EventArgs e)
        {

        }
    }
}
