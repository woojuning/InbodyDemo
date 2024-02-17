namespace Inbody.usercontrols.Overview
{
    partial class UC_DashBoard
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pn_bodyFatBorder = new System.Windows.Forms.Panel();
            this.pn_bodyFat = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbl_bodyFat = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_bodyFatTop = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pn_muscleBorder = new System.Windows.Forms.Panel();
            this.pn_muscleMass = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbl_muscleMass = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lbl_muscleMassTop = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_weightBorder = new System.Windows.Forms.Panel();
            this.pn_weight = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_weightTop = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pn_bodyFatBorder.SuspendLayout();
            this.pn_bodyFat.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_muscleBorder.SuspendLayout();
            this.pn_muscleMass.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_weightBorder.SuspendLayout();
            this.pn_weight.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "인바디검사 요약";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 73);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 122);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel5.Controls.Add(this.pn_bodyFatBorder);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(320, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.panel5.Size = new System.Drawing.Size(160, 122);
            this.panel5.TabIndex = 2;
            // 
            // pn_bodyFatBorder
            // 
            this.pn_bodyFatBorder.BackColor = System.Drawing.Color.White;
            this.pn_bodyFatBorder.Controls.Add(this.pn_bodyFat);
            this.pn_bodyFatBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_bodyFatBorder.Location = new System.Drawing.Point(19, 0);
            this.pn_bodyFatBorder.Name = "pn_bodyFatBorder";
            this.pn_bodyFatBorder.Padding = new System.Windows.Forms.Padding(4);
            this.pn_bodyFatBorder.Size = new System.Drawing.Size(122, 122);
            this.pn_bodyFatBorder.TabIndex = 2;
            // 
            // pn_bodyFat
            // 
            this.pn_bodyFat.BackColor = System.Drawing.Color.White;
            this.pn_bodyFat.Controls.Add(this.panel12);
            this.pn_bodyFat.Controls.Add(this.panel9);
            this.pn_bodyFat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_bodyFat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_bodyFat.Location = new System.Drawing.Point(4, 4);
            this.pn_bodyFat.Name = "pn_bodyFat";
            this.pn_bodyFat.Size = new System.Drawing.Size(114, 114);
            this.pn_bodyFat.TabIndex = 9;
            this.pn_bodyFat.Click += new System.EventHandler(this.InbodyPanelClick);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbl_bodyFat);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 33);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(114, 54);
            this.panel12.TabIndex = 2;
            // 
            // lbl_bodyFat
            // 
            this.lbl_bodyFat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bodyFat.Font = new System.Drawing.Font("Pretendard SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_bodyFat.Location = new System.Drawing.Point(0, 0);
            this.lbl_bodyFat.Name = "lbl_bodyFat";
            this.lbl_bodyFat.Size = new System.Drawing.Size(114, 54);
            this.lbl_bodyFat.TabIndex = 0;
            this.lbl_bodyFat.Text = "85.6";
            this.lbl_bodyFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_bodyFat.Click += new System.EventHandler(this.InbodyLabelClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbl_bodyFatTop);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(114, 33);
            this.panel9.TabIndex = 1;
            // 
            // lbl_bodyFatTop
            // 
            this.lbl_bodyFatTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bodyFatTop.Font = new System.Drawing.Font("Pretendard Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_bodyFatTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(126)))));
            this.lbl_bodyFatTop.Location = new System.Drawing.Point(0, 0);
            this.lbl_bodyFatTop.Name = "lbl_bodyFatTop";
            this.lbl_bodyFatTop.Size = new System.Drawing.Size(114, 33);
            this.lbl_bodyFatTop.TabIndex = 0;
            this.lbl_bodyFatTop.Text = "체지방률 (kg)";
            this.lbl_bodyFatTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_bodyFatTop.Click += new System.EventHandler(this.InbodyLabelClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pn_muscleBorder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(160, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.panel4.Size = new System.Drawing.Size(160, 122);
            this.panel4.TabIndex = 1;
            // 
            // pn_muscleBorder
            // 
            this.pn_muscleBorder.BackColor = System.Drawing.Color.White;
            this.pn_muscleBorder.Controls.Add(this.pn_muscleMass);
            this.pn_muscleBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_muscleBorder.Location = new System.Drawing.Point(19, 0);
            this.pn_muscleBorder.Name = "pn_muscleBorder";
            this.pn_muscleBorder.Padding = new System.Windows.Forms.Padding(4);
            this.pn_muscleBorder.Size = new System.Drawing.Size(122, 122);
            this.pn_muscleBorder.TabIndex = 1;
            // 
            // pn_muscleMass
            // 
            this.pn_muscleMass.BackColor = System.Drawing.Color.White;
            this.pn_muscleMass.Controls.Add(this.panel14);
            this.pn_muscleMass.Controls.Add(this.panel15);
            this.pn_muscleMass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_muscleMass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_muscleMass.Location = new System.Drawing.Point(4, 4);
            this.pn_muscleMass.Name = "pn_muscleMass";
            this.pn_muscleMass.Size = new System.Drawing.Size(114, 114);
            this.pn_muscleMass.TabIndex = 9;
            this.pn_muscleMass.Click += new System.EventHandler(this.InbodyPanelClick);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.lbl_muscleMass);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 33);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(114, 54);
            this.panel14.TabIndex = 2;
            // 
            // lbl_muscleMass
            // 
            this.lbl_muscleMass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_muscleMass.Font = new System.Drawing.Font("Pretendard SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_muscleMass.Location = new System.Drawing.Point(0, 0);
            this.lbl_muscleMass.Name = "lbl_muscleMass";
            this.lbl_muscleMass.Size = new System.Drawing.Size(114, 54);
            this.lbl_muscleMass.TabIndex = 0;
            this.lbl_muscleMass.Text = "85.6";
            this.lbl_muscleMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muscleMass.Click += new System.EventHandler(this.InbodyLabelClick);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.lbl_muscleMassTop);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(114, 33);
            this.panel15.TabIndex = 1;
            // 
            // lbl_muscleMassTop
            // 
            this.lbl_muscleMassTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_muscleMassTop.Font = new System.Drawing.Font("Pretendard Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_muscleMassTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(126)))));
            this.lbl_muscleMassTop.Location = new System.Drawing.Point(0, 0);
            this.lbl_muscleMassTop.Name = "lbl_muscleMassTop";
            this.lbl_muscleMassTop.Size = new System.Drawing.Size(114, 33);
            this.lbl_muscleMassTop.TabIndex = 0;
            this.lbl_muscleMassTop.Text = "골격근량 (kg)";
            this.lbl_muscleMassTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muscleMassTop.Click += new System.EventHandler(this.InbodyLabelClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pn_weightBorder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.panel3.Size = new System.Drawing.Size(160, 122);
            this.panel3.TabIndex = 0;
            // 
            // pn_weightBorder
            // 
            this.pn_weightBorder.BackColor = System.Drawing.Color.White;
            this.pn_weightBorder.Controls.Add(this.pn_weight);
            this.pn_weightBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_weightBorder.Location = new System.Drawing.Point(19, 0);
            this.pn_weightBorder.Name = "pn_weightBorder";
            this.pn_weightBorder.Padding = new System.Windows.Forms.Padding(4);
            this.pn_weightBorder.Size = new System.Drawing.Size(122, 122);
            this.pn_weightBorder.TabIndex = 0;
            // 
            // pn_weight
            // 
            this.pn_weight.BackColor = System.Drawing.Color.White;
            this.pn_weight.Controls.Add(this.panel10);
            this.pn_weight.Controls.Add(this.panel6);
            this.pn_weight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_weight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_weight.Location = new System.Drawing.Point(4, 4);
            this.pn_weight.Name = "pn_weight";
            this.pn_weight.Size = new System.Drawing.Size(114, 114);
            this.pn_weight.TabIndex = 1;
            this.pn_weight.Click += new System.EventHandler(this.InbodyPanelClick);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lbl_weight);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 33);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(114, 54);
            this.panel10.TabIndex = 1;
            // 
            // lbl_weight
            // 
            this.lbl_weight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_weight.Font = new System.Drawing.Font("Pretendard SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_weight.Location = new System.Drawing.Point(0, 0);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(114, 54);
            this.lbl_weight.TabIndex = 0;
            this.lbl_weight.Text = "85.6";
            this.lbl_weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_weight.Click += new System.EventHandler(this.InbodyLabelClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_weightTop);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 33);
            this.panel6.TabIndex = 0;
            // 
            // lbl_weightTop
            // 
            this.lbl_weightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_weightTop.Font = new System.Drawing.Font("Pretendard Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_weightTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(126)))));
            this.lbl_weightTop.Location = new System.Drawing.Point(0, 0);
            this.lbl_weightTop.Name = "lbl_weightTop";
            this.lbl_weightTop.Size = new System.Drawing.Size(114, 33);
            this.lbl_weightTop.TabIndex = 0;
            this.lbl_weightTop.Text = "체중 (kg)";
            this.lbl_weightTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_weightTop.Click += new System.EventHandler(this.InbodyLabelClick);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 205);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(480, 16);
            this.panel7.TabIndex = 6;
            // 
            // chart
            // 
            chartArea2.AxisX.IsReversed = true;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.LightGray;
            chartArea2.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.CursorX.LineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(10, 221);
            this.chart.Margin = new System.Windows.Forms.Padding(15);
            this.chart.Name = "chart";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series4.MarkerBorderColor = System.Drawing.Color.Red;
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "series_weight";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series5.MarkerBorderColor = System.Drawing.Color.Red;
            series5.MarkerColor = System.Drawing.Color.Red;
            series5.MarkerSize = 8;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "series_muscleMass";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Silver;
            series6.MarkerBorderColor = System.Drawing.Color.Red;
            series6.MarkerColor = System.Drawing.Color.Red;
            series6.MarkerSize = 8;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "series_bodyFat";
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(480, 322);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart1";
            title2.Name = "Title1";
            this.chart.Titles.Add(title2);
            this.chart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_MouseClick);
            // 
            // UC_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_DashBoard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(500, 553);
            this.Load += new System.EventHandler(this.UC_DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pn_bodyFatBorder.ResumeLayout(false);
            this.pn_bodyFat.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pn_muscleBorder.ResumeLayout(false);
            this.pn_muscleMass.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pn_weightBorder.ResumeLayout(false);
            this.pn_weight.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel pn_weightBorder;
        private System.Windows.Forms.Panel pn_weight;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_weightTop;
        private System.Windows.Forms.Panel pn_bodyFatBorder;
        private System.Windows.Forms.Panel pn_bodyFat;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lbl_bodyFat;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_bodyFatTop;
        private System.Windows.Forms.Panel pn_muscleBorder;
        private System.Windows.Forms.Panel pn_muscleMass;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lbl_muscleMass;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lbl_muscleMassTop;
    }
}
