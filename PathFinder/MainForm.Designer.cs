namespace PathFinder
{
    partial class MainForm
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
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picBoxMainImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSelectPic = new System.Windows.Forms.ToolStripMenuItem();
            this.noktalarıBelirleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectStartPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectEndPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAstarArr = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAstarHeap = new System.Windows.Forms.ToolStripMenuItem();
            this.bestFirstSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBFSArr = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBFSHeap = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImage.AutoScroll = true;
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Controls.Add(this.picBoxMainImage);
            this.pnlImage.Location = new System.Drawing.Point(12, 27);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(759, 598);
            this.pnlImage.TabIndex = 0;
            // 
            // picBoxMainImage
            // 
            this.picBoxMainImage.Location = new System.Drawing.Point(3, 3);
            this.picBoxMainImage.Name = "picBoxMainImage";
            this.picBoxMainImage.Size = new System.Drawing.Size(609, 383);
            this.picBoxMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxMainImage.TabIndex = 0;
            this.picBoxMainImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectPic,
            this.noktalarıBelirleToolStripMenuItem,
            this.aToolStripMenuItem,
            this.bestFirstSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(69, 20);
            this.btnSelectPic.Text = "ResimSeç";
            // 
            // noktalarıBelirleToolStripMenuItem
            // 
            this.noktalarıBelirleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectStartPoint,
            this.btnSelectEndPoint});
            this.noktalarıBelirleToolStripMenuItem.Name = "noktalarıBelirleToolStripMenuItem";
            this.noktalarıBelirleToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.noktalarıBelirleToolStripMenuItem.Text = "Noktaları Belirle";
            // 
            // btnSelectStartPoint
            // 
            this.btnSelectStartPoint.Name = "btnSelectStartPoint";
            this.btnSelectStartPoint.Size = new System.Drawing.Size(188, 22);
            this.btnSelectStartPoint.Text = "Başlangıç Noktası Seç";
            // 
            // btnSelectEndPoint
            // 
            this.btnSelectEndPoint.Name = "btnSelectEndPoint";
            this.btnSelectEndPoint.Size = new System.Drawing.Size(188, 22);
            this.btnSelectEndPoint.Text = "Bitiş Noktası Seç";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAstarArr,
            this.btnAstarHeap});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(32, 20);
            this.aToolStripMenuItem.Text = "A*";
            // 
            // btnAstarArr
            // 
            this.btnAstarArr.Name = "btnAstarArr";
            this.btnAstarArr.Size = new System.Drawing.Size(102, 22);
            this.btnAstarArr.Text = "Dizi";
            // 
            // btnAstarHeap
            // 
            this.btnAstarHeap.Name = "btnAstarHeap";
            this.btnAstarHeap.Size = new System.Drawing.Size(102, 22);
            this.btnAstarHeap.Text = "Heap";
            // 
            // bestFirstSearchToolStripMenuItem
            // 
            this.bestFirstSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBFSArr,
            this.btnBFSHeap});
            this.bestFirstSearchToolStripMenuItem.Name = "bestFirstSearchToolStripMenuItem";
            this.bestFirstSearchToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.bestFirstSearchToolStripMenuItem.Text = "Best First Search";
            // 
            // btnBFSArr
            // 
            this.btnBFSArr.Name = "btnBFSArr";
            this.btnBFSArr.Size = new System.Drawing.Size(102, 22);
            this.btnBFSArr.Text = "Dizi";
            // 
            // btnBFSHeap
            // 
            this.btnBFSHeap.Name = "btnBFSHeap";
            this.btnBFSHeap.Size = new System.Drawing.Size(102, 22);
            this.btnBFSHeap.Text = "Heap";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(777, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 598);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlImage);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Path Finder";
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMainImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox picBoxMainImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSelectPic;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAstarArr;
        private System.Windows.Forms.ToolStripMenuItem btnAstarHeap;
        private System.Windows.Forms.ToolStripMenuItem bestFirstSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBFSArr;
        private System.Windows.Forms.ToolStripMenuItem btnBFSHeap;
        private System.Windows.Forms.ToolStripMenuItem noktalarıBelirleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSelectStartPoint;
        private System.Windows.Forms.ToolStripMenuItem btnSelectEndPoint;
        private System.Windows.Forms.Panel panel1;
    }
}

