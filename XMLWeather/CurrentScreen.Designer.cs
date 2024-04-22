namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cityLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.cloudTimer = new System.Windows.Forms.Timer(this.components);
            this.rainTimer = new System.Windows.Forms.Timer(this.components);
            this.currentContainer = new System.Windows.Forms.Label();
            this.container1 = new System.Windows.Forms.Label();
            this.container2 = new System.Windows.Forms.Label();
            this.container4 = new System.Windows.Forms.Label();
            this.container3 = new System.Windows.Forms.Label();
            this.container6 = new System.Windows.Forms.Label();
            this.container5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.max4 = new System.Windows.Forms.Label();
            this.min4 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.max5 = new System.Windows.Forms.Label();
            this.min5 = new System.Windows.Forms.Label();
            this.date5 = new System.Windows.Forms.Label();
            this.max6 = new System.Windows.Forms.Label();
            this.min6 = new System.Windows.Forms.Label();
            this.date6 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.iconBox3 = new System.Windows.Forms.PictureBox();
            this.iconBox2 = new System.Windows.Forms.PictureBox();
            this.iconBox4 = new System.Windows.Forms.PictureBox();
            this.iconBox5 = new System.Windows.Forms.PictureBox();
            this.iconBox6 = new System.Windows.Forms.PictureBox();
            this.iconBox1 = new System.Windows.Forms.PictureBox();
            this.currentPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(15, 16);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(166, 55);
            this.cityLabel.TabIndex = 22;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(85, 148);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(85, 40);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(33, 151);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(75, 40);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(196, 209);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(33, 20);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(209, 106);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(131, 82);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "CT";
            // 
            // dayLabel
            // 
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.White;
            this.dayLabel.Location = new System.Drawing.Point(33, 106);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(133, 43);
            this.dayLabel.TabIndex = 40;
            this.dayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(15, 219);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(331, 43);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "6 Day Forecast";
            // 
            // cloudTimer
            // 
            this.cloudTimer.Enabled = true;
            this.cloudTimer.Interval = 50;
            this.cloudTimer.Tick += new System.EventHandler(this.cloudTimer_Tick);
            // 
            // rainTimer
            // 
            this.rainTimer.Enabled = true;
            this.rainTimer.Interval = 25;
            this.rainTimer.Tick += new System.EventHandler(this.rainTimer_Tick);
            // 
            // currentContainer
            // 
            this.currentContainer.BackColor = System.Drawing.Color.Black;
            this.currentContainer.Location = new System.Drawing.Point(18, 90);
            this.currentContainer.Name = "currentContainer";
            this.currentContainer.Size = new System.Drawing.Size(328, 119);
            this.currentContainer.TabIndex = 42;
            // 
            // container1
            // 
            this.container1.BackColor = System.Drawing.Color.Black;
            this.container1.Location = new System.Drawing.Point(18, 273);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(148, 99);
            this.container1.TabIndex = 43;
            // 
            // container2
            // 
            this.container2.BackColor = System.Drawing.Color.Black;
            this.container2.Location = new System.Drawing.Point(198, 273);
            this.container2.Name = "container2";
            this.container2.Size = new System.Drawing.Size(148, 99);
            this.container2.TabIndex = 44;
            // 
            // container4
            // 
            this.container4.BackColor = System.Drawing.Color.Black;
            this.container4.Location = new System.Drawing.Point(198, 387);
            this.container4.Name = "container4";
            this.container4.Size = new System.Drawing.Size(148, 99);
            this.container4.TabIndex = 46;
            // 
            // container3
            // 
            this.container3.BackColor = System.Drawing.Color.Black;
            this.container3.Location = new System.Drawing.Point(18, 387);
            this.container3.Name = "container3";
            this.container3.Size = new System.Drawing.Size(148, 99);
            this.container3.TabIndex = 45;
            // 
            // container6
            // 
            this.container6.BackColor = System.Drawing.Color.Black;
            this.container6.Location = new System.Drawing.Point(198, 500);
            this.container6.Name = "container6";
            this.container6.Size = new System.Drawing.Size(152, 99);
            this.container6.TabIndex = 48;
            // 
            // container5
            // 
            this.container5.BackColor = System.Drawing.Color.Black;
            this.container5.Location = new System.Drawing.Point(18, 500);
            this.container5.Name = "container5";
            this.container5.Size = new System.Drawing.Size(148, 99);
            this.container5.TabIndex = 47;
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(29, 282);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(141, 32);
            this.date1.TabIndex = 49;
            this.date1.Text = "Date";
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.Transparent;
            this.min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.ForeColor = System.Drawing.Color.White;
            this.min1.Location = new System.Drawing.Point(30, 328);
            this.min1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(34, 32);
            this.min1.TabIndex = 50;
            this.min1.Text = "min";
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.ForeColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(63, 329);
            this.max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(36, 32);
            this.max1.TabIndex = 51;
            this.max1.Text = "max";
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.ForeColor = System.Drawing.Color.White;
            this.max2.Location = new System.Drawing.Point(241, 329);
            this.max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(36, 32);
            this.max2.TabIndex = 55;
            this.max2.Text = "max";
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.Transparent;
            this.min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2.ForeColor = System.Drawing.Color.White;
            this.min2.Location = new System.Drawing.Point(208, 328);
            this.min2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(34, 32);
            this.min2.TabIndex = 54;
            this.min2.Text = "min";
            // 
            // date2
            // 
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(207, 282);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(141, 32);
            this.date2.TabIndex = 53;
            this.date2.Text = "Date";
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.ForeColor = System.Drawing.Color.White;
            this.max3.Location = new System.Drawing.Point(63, 444);
            this.max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(36, 32);
            this.max3.TabIndex = 59;
            this.max3.Text = "max";
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.Transparent;
            this.min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.ForeColor = System.Drawing.Color.White;
            this.min3.Location = new System.Drawing.Point(30, 443);
            this.min3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(34, 32);
            this.min3.TabIndex = 58;
            this.min3.Text = "min";
            // 
            // date3
            // 
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(29, 397);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(141, 32);
            this.date3.TabIndex = 57;
            this.date3.Text = "Date";
            // 
            // max4
            // 
            this.max4.BackColor = System.Drawing.Color.Transparent;
            this.max4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max4.ForeColor = System.Drawing.Color.White;
            this.max4.Location = new System.Drawing.Point(246, 444);
            this.max4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max4.Name = "max4";
            this.max4.Size = new System.Drawing.Size(36, 32);
            this.max4.TabIndex = 63;
            this.max4.Text = "max";
            // 
            // min4
            // 
            this.min4.BackColor = System.Drawing.Color.Transparent;
            this.min4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min4.ForeColor = System.Drawing.Color.White;
            this.min4.Location = new System.Drawing.Point(213, 443);
            this.min4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min4.Name = "min4";
            this.min4.Size = new System.Drawing.Size(34, 32);
            this.min4.TabIndex = 62;
            this.min4.Text = "min";
            // 
            // date4
            // 
            this.date4.BackColor = System.Drawing.Color.Transparent;
            this.date4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date4.ForeColor = System.Drawing.Color.White;
            this.date4.Location = new System.Drawing.Point(212, 397);
            this.date4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(141, 32);
            this.date4.TabIndex = 61;
            this.date4.Text = "Date";
            // 
            // max5
            // 
            this.max5.BackColor = System.Drawing.Color.Transparent;
            this.max5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max5.ForeColor = System.Drawing.Color.White;
            this.max5.Location = new System.Drawing.Point(63, 559);
            this.max5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max5.Name = "max5";
            this.max5.Size = new System.Drawing.Size(36, 32);
            this.max5.TabIndex = 67;
            this.max5.Text = "max";
            // 
            // min5
            // 
            this.min5.BackColor = System.Drawing.Color.Transparent;
            this.min5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min5.ForeColor = System.Drawing.Color.White;
            this.min5.Location = new System.Drawing.Point(30, 558);
            this.min5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min5.Name = "min5";
            this.min5.Size = new System.Drawing.Size(34, 32);
            this.min5.TabIndex = 66;
            this.min5.Text = "min";
            // 
            // date5
            // 
            this.date5.BackColor = System.Drawing.Color.Transparent;
            this.date5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date5.ForeColor = System.Drawing.Color.White;
            this.date5.Location = new System.Drawing.Point(29, 512);
            this.date5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(141, 32);
            this.date5.TabIndex = 65;
            this.date5.Text = "Date";
            // 
            // max6
            // 
            this.max6.BackColor = System.Drawing.Color.Transparent;
            this.max6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max6.ForeColor = System.Drawing.Color.White;
            this.max6.Location = new System.Drawing.Point(246, 559);
            this.max6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max6.Name = "max6";
            this.max6.Size = new System.Drawing.Size(36, 32);
            this.max6.TabIndex = 71;
            this.max6.Text = "max";
            // 
            // min6
            // 
            this.min6.BackColor = System.Drawing.Color.Transparent;
            this.min6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min6.ForeColor = System.Drawing.Color.White;
            this.min6.Location = new System.Drawing.Point(213, 558);
            this.min6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min6.Name = "min6";
            this.min6.Size = new System.Drawing.Size(34, 32);
            this.min6.TabIndex = 70;
            this.min6.Text = "min";
            // 
            // date6
            // 
            this.date6.BackColor = System.Drawing.Color.Transparent;
            this.date6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date6.ForeColor = System.Drawing.Color.White;
            this.date6.Location = new System.Drawing.Point(212, 512);
            this.date6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date6.Name = "date6";
            this.date6.Size = new System.Drawing.Size(141, 32);
            this.date6.TabIndex = 69;
            this.date6.Text = "Date";
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.ForeColor = System.Drawing.Color.Silver;
            this.searchInput.Location = new System.Drawing.Point(188, 25);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(129, 39);
            this.searchInput.TabIndex = 80;
            this.searchInput.Text = "Search";
            this.searchInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = global::XMLWeather.Properties.Resources.search_icon;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(323, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(49, 55);
            this.searchButton.TabIndex = 81;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // iconBox3
            // 
            this.iconBox3.BackColor = System.Drawing.Color.White;
            this.iconBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox3.Location = new System.Drawing.Point(117, 432);
            this.iconBox3.Name = "iconBox3";
            this.iconBox3.Size = new System.Drawing.Size(49, 44);
            this.iconBox3.TabIndex = 79;
            this.iconBox3.TabStop = false;
            // 
            // iconBox2
            // 
            this.iconBox2.BackColor = System.Drawing.Color.White;
            this.iconBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox2.Location = new System.Drawing.Point(291, 316);
            this.iconBox2.Name = "iconBox2";
            this.iconBox2.Size = new System.Drawing.Size(49, 44);
            this.iconBox2.TabIndex = 78;
            this.iconBox2.TabStop = false;
            // 
            // iconBox4
            // 
            this.iconBox4.BackColor = System.Drawing.Color.White;
            this.iconBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox4.Location = new System.Drawing.Point(291, 432);
            this.iconBox4.Name = "iconBox4";
            this.iconBox4.Size = new System.Drawing.Size(49, 44);
            this.iconBox4.TabIndex = 77;
            this.iconBox4.TabStop = false;
            // 
            // iconBox5
            // 
            this.iconBox5.BackColor = System.Drawing.Color.White;
            this.iconBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox5.Location = new System.Drawing.Point(117, 547);
            this.iconBox5.Name = "iconBox5";
            this.iconBox5.Size = new System.Drawing.Size(49, 44);
            this.iconBox5.TabIndex = 76;
            this.iconBox5.TabStop = false;
            // 
            // iconBox6
            // 
            this.iconBox6.BackColor = System.Drawing.Color.White;
            this.iconBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox6.Location = new System.Drawing.Point(297, 555);
            this.iconBox6.Name = "iconBox6";
            this.iconBox6.Size = new System.Drawing.Size(49, 44);
            this.iconBox6.TabIndex = 75;
            this.iconBox6.TabStop = false;
            // 
            // iconBox1
            // 
            this.iconBox1.BackColor = System.Drawing.Color.White;
            this.iconBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox1.Location = new System.Drawing.Point(117, 317);
            this.iconBox1.Name = "iconBox1";
            this.iconBox1.Size = new System.Drawing.Size(49, 44);
            this.iconBox1.TabIndex = 74;
            this.iconBox1.TabStop = false;
            // 
            // currentPictureBox
            // 
            this.currentPictureBox.BackColor = System.Drawing.Color.White;
            this.currentPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentPictureBox.Location = new System.Drawing.Point(188, 106);
            this.currentPictureBox.Name = "currentPictureBox";
            this.currentPictureBox.Size = new System.Drawing.Size(76, 82);
            this.currentPictureBox.TabIndex = 73;
            this.currentPictureBox.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.currentPictureBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.iconBox3);
            this.Controls.Add(this.iconBox2);
            this.Controls.Add(this.iconBox4);
            this.Controls.Add(this.iconBox5);
            this.Controls.Add(this.iconBox6);
            this.Controls.Add(this.iconBox1);
            this.Controls.Add(this.max6);
            this.Controls.Add(this.min6);
            this.Controls.Add(this.date6);
            this.Controls.Add(this.max5);
            this.Controls.Add(this.min5);
            this.Controls.Add(this.date5);
            this.Controls.Add(this.max4);
            this.Controls.Add(this.min4);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.container6);
            this.Controls.Add(this.container5);
            this.Controls.Add(this.container4);
            this.Controls.Add(this.container3);
            this.Controls.Add(this.container2);
            this.Controls.Add(this.container1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.currentContainer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(375, 615);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrentScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Timer cloudTimer;
        private System.Windows.Forms.Timer rainTimer;
        private System.Windows.Forms.Label currentContainer;
        private System.Windows.Forms.Label container1;
        private System.Windows.Forms.Label container2;
        private System.Windows.Forms.Label container4;
        private System.Windows.Forms.Label container3;
        private System.Windows.Forms.Label container6;
        private System.Windows.Forms.Label container5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label max4;
        private System.Windows.Forms.Label min4;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label max5;
        private System.Windows.Forms.Label min5;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label max6;
        private System.Windows.Forms.Label min6;
        private System.Windows.Forms.Label date6;
        private System.Windows.Forms.PictureBox currentPictureBox;
        private System.Windows.Forms.PictureBox iconBox1;
        private System.Windows.Forms.PictureBox iconBox6;
        private System.Windows.Forms.PictureBox iconBox5;
        private System.Windows.Forms.PictureBox iconBox4;
        private System.Windows.Forms.PictureBox iconBox2;
        private System.Windows.Forms.PictureBox iconBox3;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
    }
}
