using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        List<Point> cloudList = new List<Point>();
        List<int> cloudSpeedList = new List<int>();
        List<List<Color>> cloudColours = new List<List<Color>>();

        int cloudAmountRandNum;
        int cloudDarkness;

        List<Point> rainList = new List<Point>();
        List<int> rainSpeedList = new List<int>();
        int rainAmountRandNum = 0;

        Label[] dateLabels = new Label[6];
        Label[] minLabels = new Label[6];
        Label[] maxLabels = new Label[6];
        Label[] containers = new Label[6];

        public CurrentScreen()
        {
            InitializeComponent();

            dayLabel.Parent = currentContainer;
            dayLabel.Location = new Point(10, 10); 
            minLabel.Parent = currentContainer;
            minLabel.Location = new Point(10, 40); 
            maxLabel.Parent = currentContainer;
            maxLabel.Location = new Point(55, 40); 
            tempLabel.Parent = currentContainer;
            tempLabel.Location = new Point(130, 10);

            currentContainer.BackColor = Color.FromArgb(150, 50, 50, 50);

            dateLabels[0] = date1;
            dateLabels[1] = date2;
            dateLabels[2] = date3;
            dateLabels[3] = date4;
            dateLabels[4] = date5;
            dateLabels[5] = date6;

            minLabels[0] = min1;
            minLabels[1] = min2;
            minLabels[2] = min3;
            minLabels[3] = min4;
            minLabels[4] = min5;
            minLabels[5] = min6;

            maxLabels[0] = max1;
            maxLabels[1] = max2;
            maxLabels[2] = max3;
            maxLabels[3] = max4;
            maxLabels[4] = max5;
            maxLabels[5] = max6;

            containers[0] = container1;
            containers[1] = container2;
            containers[2] = container3;
            containers[3] = container4;
            containers[4] = container5;
            containers[5] = container6;

            for(int i = 0; i < 6; i++)
            {
                dateLabels[i].Parent = containers[i];
                dateLabels[i].Location = new Point(10, 10);
                minLabels[i].Parent = containers[i];
                minLabels[i].Location = new Point(10, 40);
                maxLabels[i].Parent = containers[i];
                maxLabels[i].Location = new Point(40, 40);
                //current1.Parent = container1;
                //current1.Location = new Point(50, 10);

                containers[i].BackColor = Color.FromArgb(150, 50, 50, 50);
            }

            DisplayCurrent();
            DisplayForecast();


            //clouds
            if (Convert.ToInt32(Form1.days[0].condition) <= 804 && Convert.ToInt32(Form1.days[0].condition) >= 800)
            {
                rainAmountRandNum = 0;

                if (Convert.ToInt32(Form1.days[0].condition) == 800)
                {
                    cloudAmountRandNum = 0;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 801)
                {
                    cloudAmountRandNum = 5;
                    cloudDarkness = 255;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 802)
                {
                    cloudAmountRandNum = 10;
                    cloudDarkness = 230;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 803)
                {
                    cloudAmountRandNum = 15;
                    cloudDarkness = 220;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 804)
                {
                    cloudAmountRandNum = 30;
                    cloudDarkness = 120;
                }
            }
            //precipitation
            else if (Convert.ToInt32(Form1.days[0].condition) <= 700 && Convert.ToInt32(Form1.days[0].condition) >= 200)
            {
                rainAmountRandNum = 80;
                cloudAmountRandNum = 30;
                cloudDarkness = 120;
            }
        }

        public void DisplayCurrent()
        {
            cityLabel.Text = Form1.days[0].location;

            double decimalRemover = Convert.ToDouble(Form1.days[0].currentTemp);
            tempLabel.Text = decimalRemover.ToString("0");

            decimalRemover = Convert.ToDouble(Form1.days[0].tempLow);
            minLabel.Text = decimalRemover.ToString("0");

            decimalRemover = Convert.ToDouble(Form1.days[0].tempHigh);
            maxLabel.Text = decimalRemover.ToString("0");

            Refresh();
        }

        public void DisplayForecast()
        {
            for(int i = 0; i < 6; i++)
            {
                double decimalRemover = Convert.ToDouble(Form1.days[i + 1].tempLow);
                minLabels[i].Text = decimalRemover.ToString("0");

                decimalRemover = Convert.ToDouble(Form1.days[i + 1].tempHigh);
                maxLabels[i].Text = decimalRemover.ToString("0");

                string[] partsOfDate = Form1.days[i + 1].date.Split('-');
                int year = Convert.ToInt32(partsOfDate[0]);
                int month = Convert.ToInt32(partsOfDate[1]);
                int day = Convert.ToInt32(partsOfDate[2]);

                DateTime date = new DateTime(year, month, day);
                DayOfWeek dayOfWeek = date.DayOfWeek;

                dateLabels[i].Text = dayOfWeek.ToString();
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            int cloudSize = 50;
            for (int i = 0; i < cloudList.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][0]), cloudList[i].X, cloudList[i].Y, cloudSize, cloudSize);
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][1]), cloudList[i].X + 40, cloudList[i].Y, cloudSize + 20, cloudSize + 20);
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][2]), cloudList[i].X + 90, cloudList[i].Y, cloudSize, cloudSize);
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][3]), cloudList[i].X + 50, cloudList[i].Y + 20, cloudSize + 20, cloudSize + 20);
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][4]), cloudList[i].X + 80, cloudList[i].Y + 20, cloudSize, cloudSize);
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][5]), cloudList[i].X + 30, cloudList[i].Y + 40, cloudSize, cloudSize);
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][6]), cloudList[i].X + 60, cloudList[i].Y + 40, cloudSize + 20, cloudSize + 20);
                e.Graphics.FillEllipse(new SolidBrush(cloudColours[i][7]), cloudList[i].X + 90, cloudList[i].Y + 40, cloudSize, cloudSize);
            }

            int rainSize = 5;
            for (int i = 0; i < rainList.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(100, 0, 0, 255)), rainList[i].X, rainList[i].Y, rainSize, rainSize + 10);
            }
      }

        private void cloudTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            //make new clouds
            int randNum = random.Next(1, 101);
            if (randNum < cloudAmountRandNum)
            {
                int y = random.Next(-100, this.Height);
                int x = -200;

                Point cloud = new Point(x, y);
                cloudList.Add(cloud);
                cloudSpeedList.Add(random.Next(1, 3));
                
                List<Color> colors = new List<Color>();

                Random rand = new Random();

                for (int i = 0; i < 8; i++)
                {
                    colors.Add(Color.FromArgb(rand.Next(100, 255), cloudDarkness, cloudDarkness, cloudDarkness));
                }
                cloudColours.Add(colors);
            }

            //move clouds
            for (int i = 0; i < cloudList.Count; i++)
            {
                int x = cloudList[i].X + cloudSpeedList[i];
                int y = cloudList[i].Y;
                cloudList[i] = new Point(x, y);
            }

            //delete clouds
            for (int i = 0; i < cloudList.Count; i++)
            {
                if ((cloudList[i].X > this.Width))
                {
                    cloudList.RemoveAt(i);
                    cloudSpeedList.RemoveAt(i);
                    cloudColours.RemoveAt(i);
                }
            }

            this.Refresh();
        }

        private void rainTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            //make new rain
            int randNum = random.Next(1, 101);
            if (randNum < rainAmountRandNum)
            {
                int y = -100;
                int x = random.Next(0, this.Width);

                Point cloud = new Point(x, y);
                rainList.Add(cloud);
                rainSpeedList.Add(random.Next(5, 16));
            }

            //move rain
            for (int i = 0; i < rainList.Count; i++)
            {
                int x = rainList[i].X;
                int y = rainList[i].Y + rainSpeedList[i];
                rainList[i] = new Point(x, y);
            }

            //delete rain
            for (int i = 0; i < rainList.Count; i++)
            {
                if (rainList[i].Y > this.Height)
                {
                    rainList.RemoveAt(i);
                    rainSpeedList.RemoveAt(i);
                }
            }

            this.Refresh();
        }
    }
}
