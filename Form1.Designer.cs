namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbOb = new System.Windows.Forms.TextBox();
            this.btnOb = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVid = new System.Windows.Forms.Button();
            this.btnRoz = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.btnPer = new System.Windows.Forms.Button();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbL = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(574, 480);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.LocationChanged += new System.EventHandler(this.chart1_Click);
            this.chart1.RightToLeftChanged += new System.EventHandler(this.chart1_Click);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(848, 418);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(120, 47);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Записати";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(768, 234);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 164);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "50";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(694, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "50";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(630, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Додати \r\nзначення";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbOb
            // 
            this.tbOb.Location = new System.Drawing.Point(834, 17);
            this.tbOb.Name = "tbOb";
            this.tbOb.Size = new System.Drawing.Size(45, 22);
            this.tbOb.TabIndex = 6;
            this.tbOb.Text = "90";
            // 
            // btnOb
            // 
            this.btnOb.Location = new System.Drawing.Point(823, 46);
            this.btnOb.Name = "btnOb";
            this.btnOb.Size = new System.Drawing.Size(123, 38);
            this.btnOb.TabIndex = 7;
            this.btnOb.Text = "Обертання";
            this.btnOb.UseVisualStyleBackColor = true;
            this.btnOb.Click += new System.EventHandler(this.btnOb_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ОУ",
            "ОХ",
            "y = x",
            "y = -x"});
            this.comboBox1.Location = new System.Drawing.Point(607, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // btnVid
            // 
            this.btnVid.Location = new System.Drawing.Point(607, 180);
            this.btnVid.Name = "btnVid";
            this.btnVid.Size = new System.Drawing.Size(133, 35);
            this.btnVid.TabIndex = 9;
            this.btnVid.Text = "Відображення";
            this.btnVid.UseVisualStyleBackColor = true;
            this.btnVid.Click += new System.EventHandler(this.btnVid_Click);
            // 
            // btnRoz
            // 
            this.btnRoz.Location = new System.Drawing.Point(823, 180);
            this.btnRoz.Name = "btnRoz";
            this.btnRoz.Size = new System.Drawing.Size(145, 38);
            this.btnRoz.TabIndex = 12;
            this.btnRoz.Text = "Розтягнення";
            this.btnRoz.UseVisualStyleBackColor = true;
            this.btnRoz.Click += new System.EventHandler(this.btnRoz_Click);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(901, 141);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(45, 22);
            this.tbB.TabIndex = 11;
            this.tbB.Text = "50";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(823, 141);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(45, 22);
            this.tbA.TabIndex = 10;
            this.tbA.Text = "50";
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(607, 61);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(157, 38);
            this.btnPer.TabIndex = 15;
            this.btnPer.Text = "Перенос";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(694, 12);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(45, 22);
            this.tbM.TabIndex = 14;
            this.tbM.Text = "50";
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(607, 12);
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(45, 22);
            this.tbL.TabIndex = 13;
            this.tbL.Text = "50";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(708, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 47);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "градусів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Х";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "У";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "а";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(952, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "l";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 504);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.btnRoz);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.btnVid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnOb);
            this.Controls.Add(this.tbOb);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbOb;
        private System.Windows.Forms.Button btnOb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnVid;
        private System.Windows.Forms.Button btnRoz;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

