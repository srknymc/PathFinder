using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PathFinder.Models;

namespace PathFinder
{
    public partial class MainForm : Form
    {
        MyImage _Image;
        bool isStartPointSet = false, isEndPointSet = false;
        bool selectMode = false;
        string FileName = "";

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormSettings();
            AddHandlers();
        }
        private void FormSettings()
        {
            _Image = new MyImage();
            _Image.StartPoint = new Point(-1, -1);
            _Image.EndPoint = new Point(-1, -1);
            pnlImage.AutoScroll = true;
        }
        private void AddHandlers()
        {
            btnSelectPic.Click += BtnSelectPic_Click;
            picBoxMainImage.Click += PicBoxMainImage_Click;
            btnAstarArr.Click += BtnAstarArr_Click;
            btnAstarHeap.Click += BtnAstarHeap_Click;
            btnBFSArr.Click += BtnBFSArr_Click;
            btnBFSHeap.Click += BtnBFSHeap_Click;
            btnSelectStartPoint.Click += BtnSelectStartPoint_Click;
            btnSelectEndPoint.Click += BtnSelectEndPoint_Click;
        }

        private void BtnSelectEndPoint_Click(object sender, EventArgs e)
        {
            if (_Image.ImageData == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçiniz");
            }
            else
            {
                MessageBox.Show("Lütfen resim üzerinden mouse ile bir bitiş noktası belirleyiniz!");
                selectMode = true;
            }
        }

        private void BtnSelectStartPoint_Click(object sender, EventArgs e)
        {
            if (_Image.ImageData == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçiniz");
            }
            else
            {
                MessageBox.Show("Lütfen resim üzerinden mouse ile bir başlangıç noktası belirleyiniz!");
                selectMode = true;
            }


        }

        private void BtnBFSHeap_Click(object sender, EventArgs e)
        {
            if (_Image.StartPoint == new Point(-1, -1) || _Image.EndPoint == new Point(-1, -1))
            {
                MessageBox.Show("Lütfen Noktaları Belirle menüsünden başlangıç ve bitiş noktalarını seçiniz!");
                return;
            }
            else
            {
                _Image.Heap = new Heap();
                _Image.Visited = new Dictionary<Point, Point>();
                MessageBox.Show("Tamam butonuna basınca Algoritma çalışmaya başlayacaktır ve Sonuç yeni bir pencerede Açılacaktır! İşlem Uzun sürebilir lütfen bekleyin...");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Algorithms.BFS_Heap(_Image);
                watch.Stop();
                ResultForm f1 = new ResultForm(_Image, new Bitmap(FileName), watch, AppHelper.MaxSize, AppHelper.PopCount) { Text = "Best First Search With HEAP" };
                f1.Show();

            }
        }

        private void BtnBFSArr_Click(object sender, EventArgs e)
        {
            if (_Image.StartPoint == new Point(-1, -1) || _Image.EndPoint == new Point(-1, -1))
            {
                MessageBox.Show("Lütfen Noktaları Belirle menüsünden başlangıç ve bitiş noktalarını seçiniz!");
                return;
            }
            else
            {
                _Image._Array = new Models.Array();
                _Image.Visited = new Dictionary<Point, Point>();
                MessageBox.Show("Tamam butonuna basınca Algoritma çalışmaya başlayacaktır ve Sonuç yeni bir pencerede Açılacaktır! İşlem Uzun sürebilir lütfen bekleyin...");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Algorithms.BFS_Arr(_Image);
                watch.Stop();
                ResultForm f1 = new ResultForm(_Image, new Bitmap(FileName), watch,AppHelper.MaxSize,AppHelper.PopCount) { Text = "Best First Search With ARRAY" };
                f1.Show();


            }
        }

        private void BtnAstarHeap_Click(object sender, EventArgs e)
        {
            if (_Image.StartPoint == new Point(-1, -1) || _Image.EndPoint == new Point(-1, -1))
            {
                MessageBox.Show("Lütfen Noktaları Belirle menüsünden başlangıç ve bitiş noktalarını seçiniz!");
                return;
            }
            else
            {
                _Image.Heap = new Heap();
                _Image.Visited = new Dictionary<Point, Point>();
                MessageBox.Show("Tamam butonuna basınca Algoritma çalışmaya başlayacaktır ve Sonuç yeni bir pencerede Açılacaktır! İşlem Uzun sürebilir lütfen bekleyin...");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Algorithms.AStar_Heap(_Image);
                watch.Stop();
                ResultForm f1 = new ResultForm(_Image, new Bitmap(FileName), watch, AppHelper.MaxSize, AppHelper.PopCount) { Text = "AStar With HEAP" };
                f1.Show();

            }
        }

        private void BtnAstarArr_Click(object sender, EventArgs e)
        {
            if (_Image.StartPoint == new Point(-1, -1) || _Image.EndPoint == new Point(-1, -1))
            {
                MessageBox.Show("Lütfen Noktaları Belirle menüsünden başlangıç ve bitiş noktalarını seçiniz!");
                return;
            }
            else
            {
                _Image._Array = new Models.Array();
                _Image.Visited = new Dictionary<Point, Point>();
                MessageBox.Show("Tamam butonuna basınca Algoritma çalışmaya başlayacaktır ve Sonuç yeni bir pencerede Açılacaktır! İşlem Uzun sürebilir lütfen bekleyin...");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Algorithms.AStar_Arr(_Image);
                watch.Stop();
                ResultForm f1 = new ResultForm(_Image, new Bitmap(FileName), watch, AppHelper.MaxSize, AppHelper.PopCount) { Text = "AStar With ARRAY" };
                f1.Show();

            }

        }

        private void PicBoxMainImage_Click(object sender, EventArgs e)
        {
            if (selectMode)
            {
                MouseEventArgs eventArgs = e as MouseEventArgs;
                Point point = eventArgs.Location;
                if (!isStartPointSet)
                {
                    _Image.StartPoint = point;
                    isStartPointSet = true;
                    MessageBox.Show("Başlangıç Noktası Seçildi: " + point.ToString());
                    selectMode = false;
                }
                else if (!isEndPointSet)
                {
                    _Image.EndPoint = point;
                    isEndPointSet = true;
                    MessageBox.Show("Bitiş Noktası Seçildi: " + point.ToString());
                    selectMode = false;
                }
            }


        }

        private void BtnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); // filedialog to select image
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _Image.ImageData = new Bitmap(fileDialog.FileName);
                FileName = fileDialog.FileName;
                picBoxMainImage.Image = _Image.ImageData;
                isEndPointSet = false;
                isStartPointSet = false;
            }
        }
    }
}
