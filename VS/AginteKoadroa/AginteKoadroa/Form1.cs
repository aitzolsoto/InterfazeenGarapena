using AginteKoadroa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2Grafikoa;

namespace AginteKoadroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new SalmentaDbContext())
            {
                var bezeroaData = db.Bezeroa
                    .Include("Saltzailea")
                .GroupBy(b => b.Saltzailea.Izena)
                .ToDictionary(g => g.Key, g => g.Count());
                if (bezeroaData != null)
                {
                    if (bezeroaData.Count > 0)
                    {
                        chart1.DataSource = bezeroaData;
                        chart1.Series[0].YValueMembers = "Value";
                        chart1.Series[0].XValueMember = "Key";
                        chart1.DataBind();
                    }
                }

                //bigarren grafikoa
                var salmentaData = db.Salmenta
                .GroupBy(b => b.BezeroaId)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.Zenbatekoa));
                if (salmentaData != null)
                {
                    if (salmentaData.Count > 0)
                    {
                        var kontrolak = grafikoa2.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var kontrola in kontrolak)
                        {
                            kontrola.Titles[0].Text = "SALMENTA GEHIENGO BEZEROAK";
                            kontrola.DataSource = salmentaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
