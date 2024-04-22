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
        //lists and variables to store cloud information for the animation
        List<Point> cloudList = new List<Point>();
        List<int> cloudSpeedList = new List<int>();
        List<List<Color>> cloudColours = new List<List<Color>>();
        int cloudAmountRandNum;
        int cloudDarkness;

        //lists and variables to store rain information for the animation
        List<Point> rainList = new List<Point>();
        List<int> rainSpeedList = new List<int>();
        int rainAmountRandNum = 0;
        Color precipitationColour;

        //lists of forecast on screen components
        Label[] dateLabels = new Label[6];
        Label[] minLabels = new Label[6];
        Label[] maxLabels = new Label[6];
        PictureBox[] iconBoxes = new PictureBox[6];
        Label[] containers = new Label[6];

        //icons
        Image sunny = Properties.Resources._3_removebg_preview;
        Image partlyCloudy = Properties.Resources._1_removebg_preview;
        Image cloudy = Properties.Resources.Paomedia_Small_N_Flat_Cloud_256;
        Image rainy = Properties.Resources._0_removebg_preview;

        Image currentImage;

        public CurrentScreen()
        {
            InitializeComponent();

            //organize parenting and locations of labels
            InitializeLabels();

            //interpret the value given by API (cloudy, partly cloudy, raining, etc.)
            InterpretCondition();

            //display current info
            DisplayCurrent();

            //display forecast info
            DisplayForecast();

            Refresh();
        }

        private void InterpretCondition()
        {
            //find how much clouds, cloud darkness, rain amount, rain color, etc.

            //clouds
            if (Convert.ToInt32(Form1.days[0].condition) <= 804 && Convert.ToInt32(Form1.days[0].condition) >= 800)
            {
                rainAmountRandNum = 0;

                if (Convert.ToInt32(Form1.days[0].condition) == 800)
                {
                    cloudAmountRandNum = 0;

                    currentImage = sunny;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 801)
                {
                    cloudAmountRandNum = 5;
                    cloudDarkness = 255;

                    currentImage = sunny;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 802)
                {
                    cloudAmountRandNum = 10;
                    cloudDarkness = 230;

                    currentImage = partlyCloudy;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 803)
                {
                    cloudAmountRandNum = 15;
                    cloudDarkness = 220;

                    currentImage = cloudy;
                }
                else if (Convert.ToInt32(Form1.days[0].condition) == 804)
                {
                    cloudAmountRandNum = 30;
                    cloudDarkness = 120;

                    currentImage = cloudy;
                }
            }
            //precipitation
            else if (Convert.ToInt32(Form1.days[0].condition) <= 700 && Convert.ToInt32(Form1.days[0].condition) >= 200)
            {
                rainAmountRandNum = 80;
                cloudAmountRandNum = 30;
                cloudDarkness = 120;

                currentImage = rainy;

                precipitationColour = Color.FromArgb(0, 0, 200);


                if (Convert.ToInt32(Form1.days[0].condition) <= 700 && Convert.ToInt32(Form1.days[0].condition) >= 600)
                {
                    precipitationColour = Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void InitializeLabels()
        {
            //current components
            dayLabel.Parent = currentContainer;
            dayLabel.Location = new Point(2, 10);
            minLabel.Parent = currentContainer;
            minLabel.Location = new Point(2, 40);
            maxLabel.Parent = currentContainer;
            maxLabel.Location = new Point(43, 40);
            tempLabel.Parent = currentContainer;
            tempLabel.Location = new Point(140, 10);
            currentPictureBox.Parent = currentContainer;
            currentPictureBox.Location = new Point(92, 10);

            currentContainer.BackColor = Color.FromArgb(150, 50, 50, 50);

            //forecast
            //put labels into arrays
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

            iconBoxes[0] = iconBox1;
            iconBoxes[1] = iconBox2;
            iconBoxes[2] = iconBox3;
            iconBoxes[3] = iconBox4;
            iconBoxes[4] = iconBox5;
            iconBoxes[5] = iconBox6;

            containers[0] = container1;
            containers[1] = container2;
            containers[2] = container3;
            containers[3] = container4;
            containers[4] = container5;
            containers[5] = container6;

            //organize labels on screen
            for (int i = 0; i < 6; i++)
            {
                dateLabels[i].Parent = containers[i];
                dateLabels[i].Location = new Point(10, 10);
                minLabels[i].Parent = containers[i];
                minLabels[i].Location = new Point(10, 40);
                maxLabels[i].Parent = containers[i];
                maxLabels[i].Location = new Point(35, 40);
                iconBoxes[i].Parent = containers[i];
                iconBoxes[i].Location = new Point(62, 32);

                containers[i].BackColor = Color.FromArgb(150, 50, 50, 50);
            }
        }

        public void DisplayCurrent()
        {
            //location
            cityLabel.Text = Form1.days[0].location;

            //decimal remover is a variable for temporary storage of data so that less decimals can be shown
            //temperatures
            double decimalRemover = Convert.ToDouble(Form1.days[0].currentTemp);
            tempLabel.Text = decimalRemover.ToString("0°");

            decimalRemover = Convert.ToDouble(Form1.days[0].tempLow);
            minLabel.Text = decimalRemover.ToString("0°");

            decimalRemover = Convert.ToDouble(Form1.days[0].tempHigh);
            maxLabel.Text = decimalRemover.ToString("0°");

            //icon
            currentPictureBox.BackgroundImage = currentImage;

            //date
            if(DateTime.Now.Month == 1)
            {
                dayLabel.Text = "Jan.";
            }
            else if (DateTime.Now.Month == 2)
            {
                dayLabel.Text = "Feb. ";
            }
            else if (DateTime.Now.Month == 3)
            {
                dayLabel.Text = "Mar. ";
            }
            else if (DateTime.Now.Month == 4)
            {
                dayLabel.Text = "Apr. ";
            }
            else if (DateTime.Now.Month == 5)
            {
                dayLabel.Text = "May ";
            }
            else if (DateTime.Now.Month == 6)
            {
                dayLabel.Text = "Jun. ";
            }
            else if (DateTime.Now.Month == 7)
            {
                dayLabel.Text = "Jul. ";
            }
            else if (DateTime.Now.Month == 8)
            {
                dayLabel.Text = "Aug. ";
            }
            else if (DateTime.Now.Month == 9)
            {
                dayLabel.Text = "Sep. ";
            }
            else if (DateTime.Now.Month == 10)
            {
                dayLabel.Text = "Oct. ";
            }
            else if (DateTime.Now.Month == 11)
            {
                dayLabel.Text = "Nov. ";
            }
            else if (DateTime.Now.Month == 12)
            {
                dayLabel.Text = "Dec. ";
            }

            dayLabel.Text += DateTime.Now.Day.ToString();

        }

        public void DisplayForecast()
        {
            //for the next six days display info
            for(int i = 0; i < 6; i++)
            {
                //decimal remover is a variable for temporary storage of data so that less decimals can be shown
                //Temperatures
                double decimalRemover = Convert.ToDouble(Form1.days[i + 1].tempLow);
                minLabels[i].Text = decimalRemover.ToString("0°");

                decimalRemover = Convert.ToDouble(Form1.days[i + 1].tempHigh);
                maxLabels[i].Text = decimalRemover.ToString("0°");

                //find the day of the week
                string[] partsOfDate = Form1.days[i + 1].date.Split('-');
                int year = Convert.ToInt32(partsOfDate[0]);
                int month = Convert.ToInt32(partsOfDate[1]);
                int day = Convert.ToInt32(partsOfDate[2]);

                DateTime date = new DateTime(year, month, day);
                DayOfWeek dayOfWeek = date.DayOfWeek;

                dateLabels[i].Text = dayOfWeek.ToString();

                //find the icons needed for each day
                Image image = null;
                if (Convert.ToInt32(Form1.days[i + 1].condition) <= 804 && Convert.ToInt32(Form1.days[i + 1].condition) >= 800)
                {
                    if (Convert.ToInt32(Form1.days[i + 1].condition) == 800)
                    {
                        image = sunny;
                    }
                    else if (Convert.ToInt32(Form1.days[i + 1].condition) == 801)
                    {
                        image = sunny;
                    }
                    else if (Convert.ToInt32(Form1.days[i + 1].condition) == 802)
                    {
                        image = partlyCloudy;
                    }
                    else if (Convert.ToInt32(Form1.days[i + 1].condition) == 803)
                    {
                        image = cloudy;
                    }
                    else if (Convert.ToInt32(Form1.days[i + 1].condition) == 804)
                    {
                        image = cloudy;
                    }
                }
                else
                {
                   image = rainy;
                }

                iconBoxes[i].BackgroundImage = image;
            }
        }

        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            //cloud animation
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

            //rain animation
            int rainSize = 5;
            for (int i = 0; i < rainList.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(100, precipitationColour)), rainList[i].X, rainList[i].Y, rainSize, rainSize + 10);
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form1.days.Clear();
            
            Form1.searchInputText = searchInput.Text;

            //try to change all the data, but if it doesnt work, display error and do nothing
            try
            {
                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                InterpretCondition();
                DisplayCurrent();
                DisplayForecast();
                searchInput.Text = "Search";
            }
            catch
            {
                searchInput.Text = "ERROR";
            }

            Refresh();
        }
    }
}
