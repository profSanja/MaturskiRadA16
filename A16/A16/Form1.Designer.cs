namespace A16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPPrijava = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cBKategorija = new System.Windows.Forms.ComboBox();
            this.cBIzlozba = new System.Windows.Forms.ComboBox();
            this.cBPas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TPStat = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btIzadji = new System.Windows.Forms.Button();
            this.btPrikazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBIzlozba2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TPAApl = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TPIzlaz = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.TPPrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TPStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TPAApl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPPrijava);
            this.tabControl1.Controls.Add(this.TPStat);
            this.tabControl1.Controls.Add(this.TPAApl);
            this.tabControl1.Controls.Add(this.TPIzlaz);
            this.tabControl1.Location = new System.Drawing.Point(13, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // TPPrijava
            // 
            this.TPPrijava.BackColor = System.Drawing.Color.LightGray;
            this.TPPrijava.Controls.Add(this.label5);
            this.TPPrijava.Controls.Add(this.label4);
            this.TPPrijava.Controls.Add(this.button2);
            this.TPPrijava.Controls.Add(this.button1);
            this.TPPrijava.Controls.Add(this.pictureBox1);
            this.TPPrijava.Controls.Add(this.cBKategorija);
            this.TPPrijava.Controls.Add(this.cBIzlozba);
            this.TPPrijava.Controls.Add(this.cBPas);
            this.TPPrijava.Controls.Add(this.label3);
            this.TPPrijava.Controls.Add(this.label2);
            this.TPPrijava.Controls.Add(this.label1);
            this.TPPrijava.Location = new System.Drawing.Point(4, 22);
            this.TPPrijava.Name = "TPPrijava";
            this.TPPrijava.Padding = new System.Windows.Forms.Padding(3);
            this.TPPrijava.Size = new System.Drawing.Size(767, 373);
            this.TPPrijava.TabIndex = 0;
            this.TPPrijava.Text = "Unesi prijavu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zatvori aplikaciju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prijava";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::A16.Properties.Resources.iskljDugme;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(197, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::A16.Properties.Resources.plus_icons;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(63, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A16.Properties.Resources.slikaMacaKuca;
            this.pictureBox1.Location = new System.Drawing.Point(433, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cBKategorija
            // 
            this.cBKategorija.FormattingEnabled = true;
            this.cBKategorija.Location = new System.Drawing.Point(112, 113);
            this.cBKategorija.Name = "cBKategorija";
            this.cBKategorija.Size = new System.Drawing.Size(121, 21);
            this.cBKategorija.TabIndex = 5;
            // 
            // cBIzlozba
            // 
            this.cBIzlozba.FormattingEnabled = true;
            this.cBIzlozba.Location = new System.Drawing.Point(112, 69);
            this.cBIzlozba.Name = "cBIzlozba";
            this.cBIzlozba.Size = new System.Drawing.Size(121, 21);
            this.cBIzlozba.TabIndex = 4;
            // 
            // cBPas
            // 
            this.cBPas.FormattingEnabled = true;
            this.cBPas.Location = new System.Drawing.Point(112, 32);
            this.cBPas.Name = "cBPas";
            this.cBPas.Size = new System.Drawing.Size(121, 21);
            this.cBPas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izlozba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pas";
            // 
            // TPStat
            // 
            this.TPStat.BackColor = System.Drawing.Color.LightGray;
            this.TPStat.Controls.Add(this.chart1);
            this.TPStat.Controls.Add(this.btIzadji);
            this.TPStat.Controls.Add(this.btPrikazi);
            this.TPStat.Controls.Add(this.dataGridView1);
            this.TPStat.Controls.Add(this.label8);
            this.TPStat.Controls.Add(this.label7);
            this.TPStat.Controls.Add(this.label10);
            this.TPStat.Controls.Add(this.label9);
            this.TPStat.Controls.Add(this.cBIzlozba2);
            this.TPStat.Controls.Add(this.label6);
            this.TPStat.Location = new System.Drawing.Point(4, 22);
            this.TPStat.Name = "TPStat";
            this.TPStat.Padding = new System.Windows.Forms.Padding(3);
            this.TPStat.Size = new System.Drawing.Size(767, 373);
            this.TPStat.TabIndex = 1;
            this.TPStat.Text = "Statistika";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(461, 24);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Takmicenje";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // btIzadji
            // 
            this.btIzadji.Location = new System.Drawing.Point(239, 319);
            this.btIzadji.Name = "btIzadji";
            this.btIzadji.Size = new System.Drawing.Size(129, 34);
            this.btIzadji.TabIndex = 9;
            this.btIzadji.Text = "Izadji";
            this.btIzadji.UseVisualStyleBackColor = true;
            this.btIzadji.Click += new System.EventHandler(this.btIzadji_Click);
            // 
            // btPrikazi
            // 
            this.btPrikazi.Location = new System.Drawing.Point(47, 319);
            this.btPrikazi.Name = "btPrikazi";
            this.btPrikazi.Size = new System.Drawing.Size(134, 34);
            this.btPrikazi.TabIndex = 8;
            this.btPrikazi.Text = "Prikazi";
            this.btPrikazi.UseVisualStyleBackColor = true;
            this.btPrikazi.Click += new System.EventHandler(this.btPrikazi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 162);
            this.dataGridView1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ukupan broj pasa koji se takmičio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ukupan broj pasa koji je prijavljen:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "0";
            // 
            // cBIzlozba2
            // 
            this.cBIzlozba2.FormattingEnabled = true;
            this.cBIzlozba2.Location = new System.Drawing.Point(120, 24);
            this.cBIzlozba2.Name = "cBIzlozba2";
            this.cBIzlozba2.Size = new System.Drawing.Size(212, 21);
            this.cBIzlozba2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Izlozba";
            // 
            // TPAApl
            // 
            this.TPAApl.BackColor = System.Drawing.Color.LightGray;
            this.TPAApl.Controls.Add(this.richTextBox1);
            this.TPAApl.Location = new System.Drawing.Point(4, 22);
            this.TPAApl.Name = "TPAApl";
            this.TPAApl.Padding = new System.Windows.Forms.Padding(3);
            this.TPAApl.Size = new System.Drawing.Size(767, 373);
            this.TPAApl.TabIndex = 2;
            this.TPAApl.Text = "O aplikaciji";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(761, 367);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // TPIzlaz
            // 
            this.TPIzlaz.Location = new System.Drawing.Point(4, 22);
            this.TPIzlaz.Name = "TPIzlaz";
            this.TPIzlaz.Padding = new System.Windows.Forms.Padding(3);
            this.TPIzlaz.Size = new System.Drawing.Size(767, 373);
            this.TPIzlaz.TabIndex = 3;
            this.TPIzlaz.Text = "Izlaz";
            this.TPIzlaz.UseVisualStyleBackColor = true;
            this.TPIzlaz.Click += new System.EventHandler(this.TPIzlaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TPPrijava.ResumeLayout(false);
            this.TPPrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TPStat.ResumeLayout(false);
            this.TPStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TPAApl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPPrijava;
        private System.Windows.Forms.TabPage TPStat;
        private System.Windows.Forms.TabPage TPAApl;
        private System.Windows.Forms.TabPage TPIzlaz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cBKategorija;
        private System.Windows.Forms.ComboBox cBIzlozba;
        private System.Windows.Forms.ComboBox cBPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btIzadji;
        private System.Windows.Forms.Button btPrikazi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBIzlozba2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

