using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rechnung_Rechner
{
    public partial class rechnungRechner : Form
    {
        public rechnungRechner()
        {
            InitializeComponent();
        }

        int incrementNummer = 0;
        string savePath = @"C:\Users\b.wood\Desktop\Entwicklung\SaveFile.txt";

        //Preise
        List<double> preis = new List<double>();

        //Steuerrate
        double steuerRate = 0;

        //Steuer
        double steuer = 0;

        //


        public void addieren()
        {
            //need to catch non-numbers

            if (!(string.IsNullOrEmpty(preisTxtBox.Text)))
            {
                double tempPreis = Convert.ToDouble(preisTxtBox.Text);

                if (!(string.IsNullOrEmpty(multiplikatorTxtBox.Text)))
                {
                    tempPreis = tempPreis * Convert.ToDouble(multiplikatorTxtBox.Text);
                    multiplikatorTxtBox.Text = "";
                }
                preisTxtBox.Text = "";

                //Speichern Preis in List
                preis.Insert(incrementNummer, tempPreis);
                incrementNummer = incrementNummer + 1;

                ausgeben();
            }        
        }





        public void ausgeben()
            {
                preisListeTxtBox.Text = "";
                for ( int i = 0; i < incrementNummer; i++ )
                {
                    string tempString = Convert.ToString(preis[i]);
                    if (!(tempString.Contains(",") || tempString.Contains(".")))
                    {
                        tempString = tempString + ".00";
                    }
                    if ((tempString.IndexOf(',') == tempString.Length - 2) || (tempString.IndexOf('.') == tempString.Length - 2))
                    {
                         tempString = tempString + "0";
                    }
                 
                
                    preisListeTxtBox.AppendText(tempString + Environment.NewLine);
                }
                totalPreisTxtBox.Text = Convert.ToString(preis.Sum());
                
            }

        public void errechnen()
            {
                if (!(String.IsNullOrEmpty(steuerRateTxtBox.Text)))
                {
                    steuerRate = Convert.ToDouble(steuerRateTxtBox.Text);
                }

                steuer = preis.Sum() * (steuerRate / 100);

                double gesamtPreisMitSteuer = steuer + preis.Sum();

                outputLbl.Text = "Preis ist " + preis.Sum() + Environment.NewLine + Environment.NewLine +
                    "Steuer Rate ist: " + steuerRate + "%" + Environment.NewLine + Environment.NewLine
                    + "Steuer Preis ist " + steuer + Environment.NewLine + Environment.NewLine
                    + "Gesamt Preis ist " + gesamtPreisMitSteuer;

            }



        public void saveToFile()
        {
            savePath = @"C:\Users\b.wood\Desktop\Entwicklung\SaveFile.txt";

            using (StreamWriter sw = new StreamWriter(savePath))
            {

                for (int i = 0; i < preis.Count; i++)
                {
                    sw.WriteLine(preis[i]);
                }                
            }
        }

        public void load()
        {
            string[] loadValues = File.ReadAllLines(savePath);
            double[] doubleArray = new double[loadValues.Length];
            for (int i = 0; i < loadValues.Length; i++)
            {
                doubleArray[i] = double.Parse(loadValues[i]);
            }
            preis = doubleArray.ToList();

            incrementNummer = preis.Count;

            ausgeben();



        }


       
        private void errechnenBtn_Click(object sender, EventArgs e)
        {
            errechnen();
        }

        private void preisTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addieren();
            }
        }

        private void preisAddierenBtn_Click(object sender, EventArgs e)
        {
            addieren();
        }

        private void multiplikatorTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addieren();
                preisTxtBox.Focus();
            }
        }

        private void steuerRateTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errechnen();
            }
        }

        private void preisLbl_Click(object sender, EventArgs e)
        {

        }

        private void saveToFileBtn_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
