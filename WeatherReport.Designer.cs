namespace WindowsFormsApp1
{
    partial class WeatherReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherReport));
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.katastasi = new System.Windows.Forms.Label();
            this.periliptika = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taxitita_anemoy = new System.Windows.Forms.Label();
            this.piesi = new System.Windows.Forms.Label();
            this.thermokrasia = new System.Windows.Forms.Label();
            this.metritis_taxititas = new System.Windows.Forms.Label();
            this.metritis_piesis = new System.Windows.Forms.Label();
            this.metritis_therm = new System.Windows.Forms.Label();
            this.contition_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ygrasia = new System.Windows.Forms.Label();
            this.metritis_ygrasia = new System.Windows.Forms.Label();
            this.Country_lbl = new System.Windows.Forms.Label();
            this.metritis_country = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(231, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name:";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Black;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.search_btn.Location = new System.Drawing.Point(482, 129);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(120, 34);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.search_box.Location = new System.Drawing.Point(182, 129);
            this.search_box.Multiline = true;
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(263, 34);
            this.search_box.TabIndex = 2;
            this.search_box.Text = "Please enter the city name!";
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // katastasi
            // 
            this.katastasi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.katastasi.AutoSize = true;
            this.katastasi.BackColor = System.Drawing.Color.Transparent;
            this.katastasi.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
            this.katastasi.ForeColor = System.Drawing.Color.Yellow;
            this.katastasi.Location = new System.Drawing.Point(132, 232);
            this.katastasi.Name = "katastasi";
            this.katastasi.Size = new System.Drawing.Size(142, 35);
            this.katastasi.TabIndex = 3;
            this.katastasi.Text = "Condition";
            // 
            // periliptika
            // 
            this.periliptika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.periliptika.AutoSize = true;
            this.periliptika.BackColor = System.Drawing.Color.Transparent;
            this.periliptika.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.periliptika.ForeColor = System.Drawing.Color.Yellow;
            this.periliptika.Location = new System.Drawing.Point(354, 273);
            this.periliptika.Name = "periliptika";
            this.periliptika.Size = new System.Drawing.Size(53, 26);
            this.periliptika.TabIndex = 4;
            this.periliptika.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(124, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // taxitita_anemoy
            // 
            this.taxitita_anemoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taxitita_anemoy.AutoSize = true;
            this.taxitita_anemoy.BackColor = System.Drawing.Color.Transparent;
            this.taxitita_anemoy.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.taxitita_anemoy.ForeColor = System.Drawing.Color.Yellow;
            this.taxitita_anemoy.Location = new System.Drawing.Point(354, 310);
            this.taxitita_anemoy.Name = "taxitita_anemoy";
            this.taxitita_anemoy.Size = new System.Drawing.Size(141, 26);
            this.taxitita_anemoy.TabIndex = 6;
            this.taxitita_anemoy.Text = "Wind Speed:";
            // 
            // piesi
            // 
            this.piesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.piesi.AutoSize = true;
            this.piesi.BackColor = System.Drawing.Color.Transparent;
            this.piesi.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.piesi.ForeColor = System.Drawing.Color.Yellow;
            this.piesi.Location = new System.Drawing.Point(354, 346);
            this.piesi.Name = "piesi";
            this.piesi.Size = new System.Drawing.Size(103, 26);
            this.piesi.TabIndex = 7;
            this.piesi.Text = "Pressure:";
            // 
            // thermokrasia
            // 
            this.thermokrasia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thermokrasia.AutoSize = true;
            this.thermokrasia.BackColor = System.Drawing.Color.Transparent;
            this.thermokrasia.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.thermokrasia.ForeColor = System.Drawing.Color.Yellow;
            this.thermokrasia.Location = new System.Drawing.Point(354, 384);
            this.thermokrasia.Name = "thermokrasia";
            this.thermokrasia.Size = new System.Drawing.Size(148, 26);
            this.thermokrasia.TabIndex = 8;
            this.thermokrasia.Text = "Temperature:";
            // 
            // metritis_taxititas
            // 
            this.metritis_taxititas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metritis_taxititas.AutoSize = true;
            this.metritis_taxititas.BackColor = System.Drawing.Color.Transparent;
            this.metritis_taxititas.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.metritis_taxititas.ForeColor = System.Drawing.Color.Yellow;
            this.metritis_taxititas.Location = new System.Drawing.Point(496, 310);
            this.metritis_taxititas.Name = "metritis_taxititas";
            this.metritis_taxititas.Size = new System.Drawing.Size(53, 26);
            this.metritis_taxititas.TabIndex = 9;
            this.metritis_taxititas.Text = "N/A";
            // 
            // metritis_piesis
            // 
            this.metritis_piesis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metritis_piesis.AutoSize = true;
            this.metritis_piesis.BackColor = System.Drawing.Color.Transparent;
            this.metritis_piesis.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.metritis_piesis.ForeColor = System.Drawing.Color.Yellow;
            this.metritis_piesis.Location = new System.Drawing.Point(463, 346);
            this.metritis_piesis.Name = "metritis_piesis";
            this.metritis_piesis.Size = new System.Drawing.Size(53, 26);
            this.metritis_piesis.TabIndex = 10;
            this.metritis_piesis.Text = "N/A";
            // 
            // metritis_therm
            // 
            this.metritis_therm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metritis_therm.AutoSize = true;
            this.metritis_therm.BackColor = System.Drawing.Color.Transparent;
            this.metritis_therm.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.metritis_therm.ForeColor = System.Drawing.Color.Yellow;
            this.metritis_therm.Location = new System.Drawing.Point(503, 384);
            this.metritis_therm.Name = "metritis_therm";
            this.metritis_therm.Size = new System.Drawing.Size(53, 26);
            this.metritis_therm.TabIndex = 11;
            this.metritis_therm.Text = "N/A";
            // 
            // contition_lbl
            // 
            this.contition_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contition_lbl.AutoSize = true;
            this.contition_lbl.BackColor = System.Drawing.Color.Transparent;
            this.contition_lbl.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.contition_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.contition_lbl.Location = new System.Drawing.Point(165, 267);
            this.contition_lbl.Name = "contition_lbl";
            this.contition_lbl.Size = new System.Drawing.Size(53, 26);
            this.contition_lbl.TabIndex = 12;
            this.contition_lbl.Text = "N/A";
            this.contition_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(485, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Details";
            // 
            // ygrasia
            // 
            this.ygrasia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ygrasia.AutoSize = true;
            this.ygrasia.BackColor = System.Drawing.Color.Transparent;
            this.ygrasia.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ygrasia.ForeColor = System.Drawing.Color.Yellow;
            this.ygrasia.Location = new System.Drawing.Point(569, 346);
            this.ygrasia.Name = "ygrasia";
            this.ygrasia.Size = new System.Drawing.Size(112, 26);
            this.ygrasia.TabIndex = 14;
            this.ygrasia.Text = "Humidity:";
            // 
            // metritis_ygrasia
            // 
            this.metritis_ygrasia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metritis_ygrasia.AutoSize = true;
            this.metritis_ygrasia.BackColor = System.Drawing.Color.Transparent;
            this.metritis_ygrasia.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.metritis_ygrasia.ForeColor = System.Drawing.Color.Yellow;
            this.metritis_ygrasia.Location = new System.Drawing.Point(687, 346);
            this.metritis_ygrasia.Name = "metritis_ygrasia";
            this.metritis_ygrasia.Size = new System.Drawing.Size(53, 26);
            this.metritis_ygrasia.TabIndex = 15;
            this.metritis_ygrasia.Text = "N/A";
            // 
            // Country_lbl
            // 
            this.Country_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Country_lbl.AutoSize = true;
            this.Country_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Country_lbl.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Country_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.Country_lbl.Location = new System.Drawing.Point(569, 310);
            this.Country_lbl.Name = "Country_lbl";
            this.Country_lbl.Size = new System.Drawing.Size(98, 26);
            this.Country_lbl.TabIndex = 16;
            this.Country_lbl.Text = "Country:";
            // 
            // metritis_country
            // 
            this.metritis_country.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metritis_country.AutoSize = true;
            this.metritis_country.BackColor = System.Drawing.Color.Transparent;
            this.metritis_country.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.metritis_country.ForeColor = System.Drawing.Color.Yellow;
            this.metritis_country.Location = new System.Drawing.Point(673, 310);
            this.metritis_country.Name = "metritis_country";
            this.metritis_country.Size = new System.Drawing.Size(53, 26);
            this.metritis_country.TabIndex = 17;
            this.metritis_country.Text = "N/A";
            // 
            // WeatherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 468);
            this.Controls.Add(this.metritis_country);
            this.Controls.Add(this.Country_lbl);
            this.Controls.Add(this.metritis_ygrasia);
            this.Controls.Add(this.ygrasia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contition_lbl);
            this.Controls.Add(this.metritis_therm);
            this.Controls.Add(this.metritis_piesis);
            this.Controls.Add(this.metritis_taxititas);
            this.Controls.Add(this.thermokrasia);
            this.Controls.Add(this.piesi);
            this.Controls.Add(this.taxitita_anemoy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.periliptika);
            this.Controls.Add(this.katastasi);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherReport";
            this.Text = "Weather Report App (by Apostolos Petrokokkinos)";
            this.Load += new System.EventHandler(this.WeatherReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label katastasi;
        private System.Windows.Forms.Label periliptika;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label taxitita_anemoy;
        private System.Windows.Forms.Label piesi;
        private System.Windows.Forms.Label thermokrasia;
        private System.Windows.Forms.Label metritis_taxititas;
        private System.Windows.Forms.Label metritis_piesis;
        private System.Windows.Forms.Label metritis_therm;
        private System.Windows.Forms.Label contition_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ygrasia;
        private System.Windows.Forms.Label metritis_ygrasia;
        private System.Windows.Forms.Label Country_lbl;
        private System.Windows.Forms.Label metritis_country;
    }
}

