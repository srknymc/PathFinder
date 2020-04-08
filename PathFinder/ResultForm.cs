using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PathFinder.Models;

namespace PathFinder
{
    public partial class ResultForm : Form
    {
        Bitmap resultData;
        MyImage img;
        Stopwatch watch;
        int maxSize, PopCount;
        public ResultForm(MyImage img,Bitmap result,Stopwatch watch,int maxsize,int popcount)
        {
            resultData = result;
            this.img = img;
            this.watch = watch;
            maxSize = maxsize;
            PopCount = popcount;
            InitializeComponent();
            this.Load += ResultForm_Load;
            this.Shown += ResultForm_Shown;
        }

        private void ResultForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Süre(ms): " + watch.ElapsedMilliseconds.ToString() + "\n Maksimum Stack Boyutu: " + maxSize + "\n" + "Toplam Silinen Eleman Sayısı: " + PopCount, this.Text);

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = resultData;
            Point p = img.EndPoint;
            Node n = new Node() { Point = img.EndPoint };
            List<Point> path = new List<Point>();
            //Trace back from end node to start node with using visited dictionary <Node,Parent>
            do
            {
                resultData.SetPixel(p.X, p.Y, Color.Green);
                p = img.Visited[p];
            } while (img.StartPoint != p);
            pictureBox1.Image = null;
            pictureBox1.Image = resultData;
        }
    }
}
