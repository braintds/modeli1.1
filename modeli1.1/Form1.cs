using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeli1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    const int matOjidanie = 3;
        //    const double veroyatnost = 0.15; //получили на random.org
        //    const double n = 0.2; //посчитали заранее

        //    Random rnd = new Random();
        //    double p = (double)rnd.Next(100, 200) / 1000;//от 0,1 до 0,2
        //    double ksi = (double)rnd.Next(0, 100) / 100; //от 0 1
        //    double veroyatnost1 = (double)rnd.Next(100, 200) / 1000;//от 0,1 до 0,2
        //    int k = 0;
        //    double[] arr = new double[200];
        //    for (int i = 0; i < 200; i++)
        //    {

        //        if (veroyatnost < ksi)
        //        {
        //            arr[k] = ksi;
        //            ++k;
        //        }
        //        ksi = (double)rnd.Next(0, 100) / 100;
        //    }

        //    Graphics graphics = pictureBox1.CreateGraphics();
        //    Pen pen = new Pen(Color.Black, 3f);

        //    Point[] points = new Point[k];
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        points[i] = new Point(i, arr[i]);
        //    }
        //}


        private void Form1_Load(object sender, EventArgs e)
        {
            const int matOjidanie = 3;
            const double veroyatnost = 0.15; //получили на random.org
            const double n = 0.2; //посчитали заранее

            Random rnd = new Random();
            double p = (double)rnd.Next(100, 200) / 1000;//от 0,1 до 0,2
            double ksi = (double)rnd.Next(0, 100) / 100; //от 0 1
            double veroyatnost1 = (double)rnd.Next(100, 200) / 1000;//от 0,1 до 0,2
            int k = 0;
            double[] arr = new double[200];
            for (int i = 0; i < 200; i++)
            {

                if (veroyatnost < ksi)
                {
                    arr[k] = ksi;
                    ++k;
                }
                ksi = (double)rnd.Next(0, 100) / 100;
            }

            Chart myChart = new Chart();
            myChart.Parent = this;
            myChart.Dock = DockStyle.Fill;
            myChart.ChartAreas.Add(new ChartArea("Math functions"));
            Series mySeriesOfPoint = new Series("Sinus");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Math functions";
            for (int i = 0; i < k; i++)
            {
                mySeriesOfPoint.Points.AddXY(i, arr[i]);
            }
            myChart.Series.Add(mySeriesOfPoint);

        }
    }
}
