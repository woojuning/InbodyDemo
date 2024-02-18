using Inbody.Controller;
using Inbody.Models;
using Inbody.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Inbody.usercontrols.Overview
{
    public partial class UC_DashBoard : UserControl
    {
        private string _memberNum;

        // dataCase 1 : 체중, 2 : 골격근량, 3: 체지방률
        private int dataCase = 1;

        private OverviewUseCase _overViewUseCase;
        private List<UserAnalysisModel> _userAnalysises;
        //private DataPoint _selectedPoint;
        private int _selectedPointIdx = -1;


        public UC_DashBoard(string memberNum)
        {
            InitializeComponent();
            this._memberNum = memberNum;
            _overViewUseCase = new OverviewUseCase();
            _userAnalysises = new List<UserAnalysisModel>();
        }

        #region EventHandler

        #region Load
        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            _userAnalysises = _overViewUseCase.GetAnalysisById(_memberNum).Reverse<UserAnalysisModel>().ToList();
            // string형태의 날짜 포맷을 DateTime으로 변경 후 다시 double형으로 변경.
            foreach (var item in _userAnalysises)
            {
                item.MeasureTimeDouble = DateTime.Parse(item.MeasureTime).ToOADate();
            }
            InitChartData();
            InitChart();
            ChangeAxisXLabel(dataCase);
        }


        #endregion

        #region Panel
        //panel click
        private void InbodyPanelClick(object sender, EventArgs e)
        {
            var pnName = (sender as Panel).Name;
            
            if (pnName == "pn_weight")
            {
                dataCase = 1;
            }
            else if (pnName == "pn_muscleMass")
            {
                dataCase = 2;
            }
            else
            {
                dataCase = 3;
            }

            ShowChartData(dataCase);
            ChangePanelBorder(dataCase);
            InitWeightChartAxisLabel(dataCase);
            ClearSelectedDataPointLabel();
            ChangeAxisXLabel(dataCase);
        }

        
        #endregion

        #region Label
        private void InbodyLabelClick(object sender, EventArgs e)
        {
            var lblName = (sender as Label).Name;
            if (lblName == "lbl_weightTop" || lblName == "lbl_weight")
            {
                dataCase = 1;
            }
            else if (lblName == "lbl_muscleMassTop" || lblName == "lbl_muscleMass")
            {
                dataCase = 2;
            }
            else
            {
                dataCase = 3;
            }

            ShowChartData(dataCase);
            ChangePanelBorder(dataCase);
            InitWeightChartAxisLabel(dataCase);
            ClearSelectedDataPointLabel();
            ChangeAxisXLabel(dataCase);

        }

        #endregion

        #endregion

        #region Application Logic
        private void ChangePanelBorder(int dataCase)
        {
            pn_weightBorder.BackColor = Color.White;
            pn_muscleBorder.BackColor = Color.White;
            pn_bodyFatBorder.BackColor = Color.White;

            switch (dataCase)
            {
                case 1:
                    pn_weightBorder.BackColor = Pallete.InbodyRed;
                    break;
                case 2:
                    pn_muscleBorder.BackColor = Pallete.InbodyRed;
                    break;
                case 3:
                    pn_bodyFatBorder.BackColor = Pallete.InbodyRed;
                    break;
                default:
                    break;
            }
        }

        #region Chart
        private void ChangeAxisXLabel(int dataCase)
        {
            var points = dataCase == 1 ? chart.Series["series_weight"].Points
                                     : dataCase == 2 ? chart.Series["series_muscleMass"].Points
                                     : chart.Series["series_bodyFat"].Points;

            foreach (var point in points)
            {
                //point.AxisLabel = DateTime.FromOADate(point.XValue).ToString("yy.MM.dd hh:mm");
                point.AxisLabel = _userAnalysises[int.Parse(point.XValue.ToString())].MeasureTime;
            }
        }

        private void InitChartData()
        {
            //var reversedUserAnalysis = _userAnalysises.Reverse<UserAnalysisModel>();

            // 몸무게
            var cnt = 0;
            foreach (var item in _userAnalysises)
            {
                chart.Series["series_weight"].Points.AddXY(cnt, item.Weight);
                //chart.Series["series_weight"].Points.AddXY(item.MeasureTime, item.Weight);
                //chart.Series["series_weight"].Points.AddXY(item.MeasureTimeDouble, item.Weight);
                cnt++;
            }
            // 근육량
            cnt = 0;
            foreach (var item in _userAnalysises)
            {
                chart.Series["series_muscleMass"].Points.AddXY(cnt, item.SkeletalMuscleMass);
                //chart.Series["series_muscleMass"].Points.AddXY(item.MeasureTimeDouble, item.SkeletalMuscleMass);
                cnt++;
            }
            // 체지방
            cnt = 0;
            foreach (var item in _userAnalysises)
            {
                chart.Series["series_bodyFat"].Points.AddXY(cnt, item.BodyFatMass);
                //chart.Series["series_bodyFat"].Points.AddXY(item.MeasureTimeDouble, item.BodyFatMass);
                cnt++;
            }

            chart.Series["series_muscleMass"].Enabled = false;
            chart.Series["series_bodyFat"].Enabled = false;
        }

        private void InitChart()
        {
            #region 그리도 불투명하게
            int red = Convert.ToInt32("dd", 16);
            int green = Convert.ToInt32("e1", 16);
            int blue = Convert.ToInt32("e4", 16);
            int alpha = 150;

            Color gridColor = Color.FromArgb(alpha, red, green, blue);

            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = gridColor;

            chart.ChartAreas[0].AxisY.LineColor = gridColor;
            chart.ChartAreas[0].AxisY.LineColor = gridColor;
            #endregion

            #region x축 그리드 안보이게
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            #endregion

            #region 클릭된 패널 보더색상
            pn_weightBorder.BackColor = Pallete.InbodyRed;
            #endregion
        }

        private void ShowChartData(int dataCase)
        {
            // 1) 모든 Chart의 Series의 Enable을 false로 변경해준 뒤 
            // 2) 각 케이스에 맞는 Series를 true로 변경해주면됨.
            foreach (var series in chart.Series)
            {
                series.Enabled = false;
            }

            switch (dataCase)
            {
                case 1: //체중
                    chart.Series["series_weight"].Enabled = true;
                    break;
                case 2: //골격근량
                    chart.Series["series_muscleMass"].Enabled = true;
                    break;
                case 3: //체지방률
                    chart.Series["series_bodyFat"].Enabled = true;
                    break;
                default:
                    break;
            }
        }

        //차트 전환 시 선택했던 데이터 label 초기화
        private void ClearSelectedDataPointLabel()
        {

            if (_selectedPointIdx == -1)
            {
                lbl_measureTime.Text = "";
                lbl_measureValue.Text = "";
            }
            else
            {
                var value = dataCase == 1 ? _userAnalysises[_selectedPointIdx].Weight
                                               : dataCase == 2 ? _userAnalysises[_selectedPointIdx].SkeletalMuscleMass
                                               : _userAnalysises[_selectedPointIdx].BodyFatMass;

                lbl_measureTime.Text = _userAnalysises[_selectedPointIdx].MeasureTime;
                lbl_measureValue.Text = dataCase == 3 ? $"{value.ToString()}%"
                                                              : $"{value.ToString()}kg";
            }
        }

        private void InitWeightChartAxisLabel(int dataCase)
        {
            double minYValue = 0;
            double maxYValue = 0;
            switch (dataCase)
            {
                case 1: //체중
                    minYValue = _userAnalysises.Select(x => x.Weight).Min();
                    maxYValue = _userAnalysises.Select(x => x.Weight).Max();
                    break;
                case 2: //골격근량
                    minYValue = _userAnalysises.Select(x => x.SkeletalMuscleMass).Min();
                    maxYValue = _userAnalysises.Select(x => x.SkeletalMuscleMass).Max();
                    break;
                case 3: //체지방률
                    minYValue = _userAnalysises.Select(x => x.BodyFatMass).Min();
                    maxYValue = _userAnalysises.Select(x => x.BodyFatMass).Max();
                    break;
                default:
                    break;
            }

            chart.ChartAreas[0].AxisY.Minimum = minYValue - 3;
            chart.ChartAreas[0].AxisY.Maximum = maxYValue + 3;
            chart.ChartAreas[0].AxisY.LabelStyle.Interval = 3;
        }

        #endregion
        #endregion

        #region Test
        private void button1_Click(object sender, EventArgs e)
        {
            Series ser2 = chart.Series.Add("line");
            ser2.ChartType = SeriesChartType.Spline;
            chart.Series["line"].BorderWidth = 5;
            chart.Series["line"].Color = ColorTranslator.FromHtml("#dde1e4");

            int cnt = 0;

            foreach (var item in _userAnalysises.Reverse<UserAnalysisModel>())
            {
                ser2.Points.AddXY(cnt, item.Weight);
                cnt++;
            }

            double minYValue = _userAnalysises.Select(x => x.Weight).Min();
            double maxYValue = _userAnalysises.Select(x => x.Weight).Max();

            chart.ChartAreas[0].AxisY.Minimum = minYValue - 3;
            chart.ChartAreas[0].AxisY.Maximum = maxYValue + 3;
            //chart1.ChartAreas[0].AxisY.Interval = 5;
            chart.ChartAreas[0].AxisY.LabelStyle.Interval = 3;

            chart.Series["line"].MarkerStyle = MarkerStyle.Circle;
            chart.Series["line"].MarkerSize = 10;
            chart.Series["line"].MarkerColor = Color.Red;
            var date = DateTime.Now;

            var translatedDate = date.ToOADate();

            MessageBox.Show(translatedDate.ToString());

            MessageBox.Show(DateTime.FromOADate(translatedDate).ToString());
            chart.Series["series_weight"].Points[0].AxisLabel = "안녕하세요";
        }
        #endregion

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            //double xValue = chart1.ChartAreas["ChartArea1"].AxisX.PixelPositionToValue(e.X);
            //double yValue = chart1.ChartAreas["ChartArea1"].AxisY.PixelPositionToValue(e.Y);

            //DataPoint closestPoint = null;

            //foreach (Series series in chart1.Series)
            //{
            //    foreach (DataPoint point in series.Points)
            //    {
            //        double diff = Math.Abs(point.XValue - xValue);
            //        if (closestPoint == null || diff < Math.Abs(closestPoint.XValue - xValue))
            //        {
            //            closestPoint = point;
            //        }
            //    }
            //}

            //chart1.ChartAreas["ChartArea1"].CursorX.SetCursorPixelPosition(new Point(e.X, e.Y), true);
            //chart1.ChartAreas["ChartArea1"].CursorX.Position = xValue;

            //double closestXValue = closestPoint.XValue;
            //double closestYValue = closestPoint.YValues[0];

            ////tooltip.Show($"X : {xValue}, Y : {yValue}", chart1, e.Location.X + 15, e.Location.Y);
            //tooltip.Show($"X : {closestXValue}, Y : {closestYValue}", chart1, e.Location.X + 15, e.Location.Y);
        }

        private void chart_MouseClick(object sender, MouseEventArgs e)
        {
            //if (_graphics != null && _pen != null)
            //{
            //    _graphics.Dispose();
            //    _pen.Dispose();
            //    //_graphics = null;
            //    //_pen = null;
            //}

            int mouseX = e.X; // 마우스 클릭된 X 픽셀 좌표
            int mouseY = e.Y; // 마우스 클릭된 Y 픽셀 좌표

            DataPoint nearestDataPoint = null;
            double minDistance = double.MaxValue;
            var points = dataCase == 1 ? chart.Series["series_weight"].Points
                                            : dataCase == 2 ? chart.Series["series_muscleMass"].Points
                                            : chart.Series["series_bodyFat"].Points;

            foreach (DataPoint point in points)
            {
                // 데이터 포인트의 화면 픽셀 좌표 가져오기
                int pointX = (int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(point.XValue);
                int pointY = (int)chart.ChartAreas[0].AxisY.ValueToPixelPosition(point.YValues[0]); // 단일 Series의 경우

                // 마우스 클릭된 픽셀 좌표와 데이터 포인트의 픽셀 좌표 사이의 거리 계산
                double distance = Math.Sqrt(Math.Pow(mouseX - pointX, 2) + Math.Pow(mouseY - pointY, 2));

                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestDataPoint = point;
                }
            }

            // 현재 선택된 DataPoint의 index값을 필드변수 _selectedPointIdx 에 저장
            _selectedPointIdx = int.Parse(nearestDataPoint.XValue.ToString());

            if (nearestDataPoint != null)
            {
                //// 가장 가까운 데이터 포인트의 값을 가져옵니다.
                double xValue = nearestDataPoint.XValue;
                double yValue = nearestDataPoint.YValues[0]; // 첫 번째 Y값 (단일 Series의 경우)

                //// 값을 출력하거나 사용합니다.
                ////MessageBox.Show($"Nearest DataPoint - X: {DateTime.FromOADate(xValue).ToString()}, Y: {yValue}");

                //lbl_measureTime.Text = DateTime.FromOADate(xValue).ToString();
                //lbl_measureValue.Text = dataCase == 3 ? $"{yValue.ToString()}%"
                //                                              : $"{yValue.ToString()}kg";

                lbl_measureTime.Text = _userAnalysises[int.Parse(xValue.ToString())].MeasureTime;
                lbl_measureValue.Text = dataCase == 3 ? $"{yValue.ToString()}%"
                                                              : $"{yValue.ToString()}kg";

                //double xPoistion = chart.ChartAreas[0].AxisX.ValueToPosition(xValue);
                //double xPoistion2 = chart.ChartAreas[0].AxisX.ValueToPixelPosition(xValue);
                //int pointX2 = (int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(xValue);

                //chart.ChartAreas[0].CursorX.SetCursorPixelPosition(new Point(pointX2, 0), true);
                //Console.WriteLine(chart.ChartAreas[0].CursorX.Position);
                //Console.WriteLine(xPoistion);
                //Console.WriteLine(xPoistion2);
                //chart.ChartAreas[0].CursorX.Position = xPoistion;

            }
            else
            {
                MessageBox.Show("No data point found near the click position.");
            }

            ////여기서 vertical line그리기
            //_selectedPoint = nearestDataPoint;
            //Graphics graphics = chart.CreateGraphics();
            //Pen pen = new Pen(Color.White);

            ////Rectangle rect = chart.ClientRectangle;
            ////_graphics.FillRectangle(new SolidBrush(chart.BackColor), rect);

            //double xValue2 = nearestDataPoint.XValue;
            //int pointX2 = (int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(xValue2);

            //int xAxisStartY = (int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(chart.ChartAreas[0].AxisX.Minimum);
            //int xAxisEndY = (int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(chart.ChartAreas[0].AxisX.Maximum);


            //graphics.DrawLine(pen, pointX2, xAxisStartY, pointX2, xAxisEndY);

            //graphics.Dispose();
            //pen.Dispose();

        }


    }
}
