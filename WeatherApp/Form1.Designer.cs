namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labCity = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunrise2 = new System.Windows.Forms.Label();
            this.labSunset2 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labPressure2 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.labWindSpeed2 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labDetails2 = new System.Windows.Forms.Label();
            this.labCondition2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.BackColor = System.Drawing.Color.Transparent;
            this.labCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labCity.ForeColor = System.Drawing.Color.Yellow;
            this.labCity.Location = new System.Drawing.Point(173, 140);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(55, 28);
            this.labCity.TabIndex = 0;
            this.labCity.Text = "City:";
            this.labCity.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBCity.Location = new System.Drawing.Point(288, 137);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(182, 36);
            this.TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearch.Location = new System.Drawing.Point(547, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labCondition.ForeColor = System.Drawing.Color.Yellow;
            this.labCondition.Location = new System.Drawing.Point(170, 369);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(103, 28);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labDetails.ForeColor = System.Drawing.Color.Yellow;
            this.labDetails.Location = new System.Drawing.Point(170, 425);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(79, 28);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Details";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSunrise.ForeColor = System.Drawing.Color.Yellow;
            this.labSunrise.Location = new System.Drawing.Point(170, 497);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(88, 28);
            this.labSunrise.TabIndex = 5;
            this.labSunrise.Text = "Sunrise:";
            this.labSunrise.Click += new System.EventHandler(this.labSunrise_Click);
            // 
            // labSunrise2
            // 
            this.labSunrise2.AutoSize = true;
            this.labSunrise2.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSunrise2.ForeColor = System.Drawing.Color.White;
            this.labSunrise2.Location = new System.Drawing.Point(295, 497);
            this.labSunrise2.Name = "labSunrise2";
            this.labSunrise2.Size = new System.Drawing.Size(48, 28);
            this.labSunrise2.TabIndex = 6;
            this.labSunrise2.Text = "N/A";
            this.labSunrise2.Click += new System.EventHandler(this.LABsUNRİSE2_Click);
            // 
            // labSunset2
            // 
            this.labSunset2.AutoSize = true;
            this.labSunset2.BackColor = System.Drawing.Color.Transparent;
            this.labSunset2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSunset2.ForeColor = System.Drawing.Color.White;
            this.labSunset2.Location = new System.Drawing.Point(295, 549);
            this.labSunset2.Name = "labSunset2";
            this.labSunset2.Size = new System.Drawing.Size(48, 28);
            this.labSunset2.TabIndex = 9;
            this.labSunset2.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSunset.ForeColor = System.Drawing.Color.Yellow;
            this.labSunset.Location = new System.Drawing.Point(170, 549);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(82, 28);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "Sunset:";
            // 
            // labPressure2
            // 
            this.labPressure2.AutoSize = true;
            this.labPressure2.BackColor = System.Drawing.Color.Transparent;
            this.labPressure2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labPressure2.ForeColor = System.Drawing.Color.White;
            this.labPressure2.Location = new System.Drawing.Point(633, 553);
            this.labPressure2.Name = "labPressure2";
            this.labPressure2.Size = new System.Drawing.Size(48, 28);
            this.labPressure2.TabIndex = 13;
            this.labPressure2.Text = "N/A";
            this.labPressure2.Click += new System.EventHandler(this.label3_Click);
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labPressure.ForeColor = System.Drawing.Color.Yellow;
            this.labPressure.Location = new System.Drawing.Point(524, 553);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(100, 28);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "Pressure:";
            // 
            // labWindSpeed2
            // 
            this.labWindSpeed2.AutoSize = true;
            this.labWindSpeed2.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labWindSpeed2.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed2.Location = new System.Drawing.Point(659, 497);
            this.labWindSpeed2.Name = "labWindSpeed2";
            this.labWindSpeed2.Size = new System.Drawing.Size(48, 28);
            this.labWindSpeed2.TabIndex = 11;
            this.labWindSpeed2.Text = "N/A";
            this.labWindSpeed2.Click += new System.EventHandler(this.label5_Click);
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.Yellow;
            this.labWindSpeed.Location = new System.Drawing.Point(524, 497);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(133, 28);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "Wind Speed:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(175, 211);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(224, 130);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 14;
            this.picIcon.TabStop = false;
            // 
            // labDetails2
            // 
            this.labDetails2.AutoSize = true;
            this.labDetails2.BackColor = System.Drawing.Color.Transparent;
            this.labDetails2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labDetails2.ForeColor = System.Drawing.Color.White;
            this.labDetails2.Location = new System.Drawing.Point(295, 421);
            this.labDetails2.Name = "labDetails2";
            this.labDetails2.Size = new System.Drawing.Size(48, 28);
            this.labDetails2.TabIndex = 16;
            this.labDetails2.Text = "N/A";
            // 
            // labCondition2
            // 
            this.labCondition2.AutoSize = true;
            this.labCondition2.BackColor = System.Drawing.Color.Transparent;
            this.labCondition2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labCondition2.ForeColor = System.Drawing.Color.White;
            this.labCondition2.Location = new System.Drawing.Point(295, 369);
            this.labCondition2.Name = "labCondition2";
            this.labCondition2.Size = new System.Drawing.Size(48, 28);
            this.labCondition2.TabIndex = 15;
            this.labCondition2.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 635);
            this.Controls.Add(this.labDetails2);
            this.Controls.Add(this.labCondition2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure2);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindSpeed2);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.labSunset2);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise2);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.labCity);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "WeatherApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunrise2;
        private System.Windows.Forms.Label labSunset2;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labPressure2;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labWindSpeed2;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labDetails2;
        private System.Windows.Forms.Label labCondition2;
    }
}

