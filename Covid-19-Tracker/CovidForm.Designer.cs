namespace Covid_19_Tracker
{
    partial class CovidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CovidForm));
            this.bg_container = new System.Windows.Forms.Panel();
            this.country_flag_picbox = new System.Windows.Forms.PictureBox();
            this.connection_lbl = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.version_lbl = new System.Windows.Forms.Label();
            this.recovered_txt_box = new System.Windows.Forms.Label();
            this.recovered_lbl = new System.Windows.Forms.Label();
            this.fatal_txt_box = new System.Windows.Forms.Label();
            this.deaths_lbl = new System.Windows.Forms.Label();
            this.confirm_txt_box = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.help_btn = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.export_data_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.display_data_btn = new System.Windows.Forms.Button();
            this.province_lbl = new System.Windows.Forms.Label();
            this.country_lbl = new System.Windows.Forms.Label();
            this.province_dd = new System.Windows.Forms.ComboBox();
            this.country_dd = new System.Windows.Forms.ComboBox();
            this.confirm_lbl = new System.Windows.Forms.Label();
            this.bg_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.country_flag_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_container
            // 
            this.bg_container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg_container.BackgroundImage")));
            this.bg_container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg_container.Controls.Add(this.country_flag_picbox);
            this.bg_container.Controls.Add(this.connection_lbl);
            this.bg_container.Controls.Add(this.status_lbl);
            this.bg_container.Controls.Add(this.version_lbl);
            this.bg_container.Controls.Add(this.recovered_txt_box);
            this.bg_container.Controls.Add(this.recovered_lbl);
            this.bg_container.Controls.Add(this.fatal_txt_box);
            this.bg_container.Controls.Add(this.deaths_lbl);
            this.bg_container.Controls.Add(this.confirm_txt_box);
            this.bg_container.Controls.Add(this.label3);
            this.bg_container.Controls.Add(this.help_btn);
            this.bg_container.Controls.Add(this.close_button);
            this.bg_container.Controls.Add(this.export_data_btn);
            this.bg_container.Controls.Add(this.logo);
            this.bg_container.Controls.Add(this.display_data_btn);
            this.bg_container.Controls.Add(this.province_lbl);
            this.bg_container.Controls.Add(this.country_lbl);
            this.bg_container.Controls.Add(this.province_dd);
            this.bg_container.Controls.Add(this.country_dd);
            this.bg_container.Controls.Add(this.confirm_lbl);
            this.bg_container.Cursor = System.Windows.Forms.Cursors.Default;
            this.bg_container.Location = new System.Drawing.Point(0, 0);
            this.bg_container.Margin = new System.Windows.Forms.Padding(4);
            this.bg_container.Name = "bg_container";
            this.bg_container.Size = new System.Drawing.Size(679, 526);
            this.bg_container.TabIndex = 6;
            this.bg_container.Paint += new System.Windows.Forms.PaintEventHandler(this.bg_container_Paint);
            this.bg_container.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bg_container_MouseClick);
            this.bg_container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bg_container_MouseDown);
            this.bg_container.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bg_container_MouseMove);
            this.bg_container.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bg_container_MouseUp);
            // 
            // country_flag_picbox
            // 
            this.country_flag_picbox.BackColor = System.Drawing.Color.Transparent;
            this.country_flag_picbox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("country_flag_picbox.ErrorImage")));
            this.country_flag_picbox.Image = ((System.Drawing.Image)(resources.GetObject("country_flag_picbox.Image")));
            this.country_flag_picbox.Location = new System.Drawing.Point(160, 109);
            this.country_flag_picbox.Name = "country_flag_picbox";
            this.country_flag_picbox.Size = new System.Drawing.Size(64, 64);
            this.country_flag_picbox.TabIndex = 13;
            this.country_flag_picbox.TabStop = false;
            // 
            // connection_lbl
            // 
            this.connection_lbl.BackColor = System.Drawing.Color.Transparent;
            this.connection_lbl.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.connection_lbl.Location = new System.Drawing.Point(107, 497);
            this.connection_lbl.Name = "connection_lbl";
            this.connection_lbl.Size = new System.Drawing.Size(85, 27);
            this.connection_lbl.TabIndex = 12;
            this.connection_lbl.Text = "Online";
            this.connection_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // status_lbl
            // 
            this.status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.status_lbl.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.status_lbl.Location = new System.Drawing.Point(3, 497);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(133, 27);
            this.status_lbl.TabIndex = 12;
            this.status_lbl.Text = "Status : ";
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // version_lbl
            // 
            this.version_lbl.BackColor = System.Drawing.Color.Transparent;
            this.version_lbl.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.version_lbl.Location = new System.Drawing.Point(423, 497);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(256, 27);
            this.version_lbl.TabIndex = 12;
            this.version_lbl.Text = "Covid-19 Tracker V 1.1";
            this.version_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recovered_txt_box
            // 
            this.recovered_txt_box.BackColor = System.Drawing.Color.Transparent;
            this.recovered_txt_box.Font = new System.Drawing.Font("Courier New", 34F, System.Drawing.FontStyle.Bold);
            this.recovered_txt_box.ForeColor = System.Drawing.Color.Chartreuse;
            this.recovered_txt_box.Location = new System.Drawing.Point(443, 284);
            this.recovered_txt_box.Name = "recovered_txt_box";
            this.recovered_txt_box.Size = new System.Drawing.Size(221, 129);
            this.recovered_txt_box.TabIndex = 11;
            this.recovered_txt_box.Text = "NAN";
            this.recovered_txt_box.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recovered_txt_box.TextChanged += new System.EventHandler(this.confirm_txt_box_TextChanged);
            // 
            // recovered_lbl
            // 
            this.recovered_lbl.AutoSize = true;
            this.recovered_lbl.BackColor = System.Drawing.Color.Transparent;
            this.recovered_lbl.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.recovered_lbl.ForeColor = System.Drawing.Color.White;
            this.recovered_lbl.Location = new System.Drawing.Point(477, 257);
            this.recovered_lbl.Name = "recovered_lbl";
            this.recovered_lbl.Size = new System.Drawing.Size(138, 27);
            this.recovered_lbl.TabIndex = 10;
            this.recovered_lbl.Text = "Recovered";
            // 
            // fatal_txt_box
            // 
            this.fatal_txt_box.BackColor = System.Drawing.Color.Transparent;
            this.fatal_txt_box.Font = new System.Drawing.Font("Courier New", 34F, System.Drawing.FontStyle.Bold);
            this.fatal_txt_box.ForeColor = System.Drawing.Color.Yellow;
            this.fatal_txt_box.Location = new System.Drawing.Point(235, 284);
            this.fatal_txt_box.Name = "fatal_txt_box";
            this.fatal_txt_box.Size = new System.Drawing.Size(221, 129);
            this.fatal_txt_box.TabIndex = 9;
            this.fatal_txt_box.Text = "NAN";
            this.fatal_txt_box.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fatal_txt_box.TextChanged += new System.EventHandler(this.confirm_txt_box_TextChanged);
            // 
            // deaths_lbl
            // 
            this.deaths_lbl.AutoSize = true;
            this.deaths_lbl.BackColor = System.Drawing.Color.Transparent;
            this.deaths_lbl.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.deaths_lbl.ForeColor = System.Drawing.Color.White;
            this.deaths_lbl.Location = new System.Drawing.Point(296, 257);
            this.deaths_lbl.Name = "deaths_lbl";
            this.deaths_lbl.Size = new System.Drawing.Size(82, 27);
            this.deaths_lbl.TabIndex = 8;
            this.deaths_lbl.Text = "Fatal";
            // 
            // confirm_txt_box
            // 
            this.confirm_txt_box.BackColor = System.Drawing.Color.Transparent;
            this.confirm_txt_box.Font = new System.Drawing.Font("Courier New", 34F, System.Drawing.FontStyle.Bold);
            this.confirm_txt_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.confirm_txt_box.Location = new System.Drawing.Point(23, 284);
            this.confirm_txt_box.Name = "confirm_txt_box";
            this.confirm_txt_box.Size = new System.Drawing.Size(221, 129);
            this.confirm_txt_box.TabIndex = 7;
            this.confirm_txt_box.Text = "NAN";
            this.confirm_txt_box.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirm_txt_box.TextChanged += new System.EventHandler(this.confirm_txt_box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 25.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(139, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Covid-19 Tracker";
            // 
            // help_btn
            // 
            this.help_btn.AutoSize = true;
            this.help_btn.BackColor = System.Drawing.Color.Transparent;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.help_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.help_btn.Location = new System.Drawing.Point(574, 0);
            this.help_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(41, 39);
            this.help_btn.TabIndex = 5;
            this.help_btn.Text = "?";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // close_button
            // 
            this.close_button.AutoSize = true;
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.close_button.Location = new System.Drawing.Point(635, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(41, 39);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // export_data_btn
            // 
            this.export_data_btn.AutoSize = true;
            this.export_data_btn.BackColor = System.Drawing.Color.Transparent;
            this.export_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.export_data_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.export_data_btn.Location = new System.Drawing.Point(459, 437);
            this.export_data_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.export_data_btn.Name = "export_data_btn";
            this.export_data_btn.Size = new System.Drawing.Size(192, 39);
            this.export_data_btn.TabIndex = 5;
            this.export_data_btn.Text = "Export Data";
            this.export_data_btn.UseVisualStyleBackColor = false;
            this.export_data_btn.Click += new System.EventHandler(this.export_data_btn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Covid_19_Tracker.Properties.Resources.virus_logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(51, 26);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(73, 68);
            this.logo.TabIndex = 0;
            // 
            // display_data_btn
            // 
            this.display_data_btn.AutoSize = true;
            this.display_data_btn.BackColor = System.Drawing.Color.Transparent;
            this.display_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.display_data_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.display_data_btn.Location = new System.Drawing.Point(51, 437);
            this.display_data_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display_data_btn.Name = "display_data_btn";
            this.display_data_btn.Size = new System.Drawing.Size(173, 39);
            this.display_data_btn.TabIndex = 5;
            this.display_data_btn.Text = "Display Data";
            this.display_data_btn.UseVisualStyleBackColor = false;
            this.display_data_btn.Click += new System.EventHandler(this.display_data_btn_Click);
            // 
            // province_lbl
            // 
            this.province_lbl.AutoSize = true;
            this.province_lbl.BackColor = System.Drawing.Color.Transparent;
            this.province_lbl.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province_lbl.ForeColor = System.Drawing.Color.White;
            this.province_lbl.Location = new System.Drawing.Point(12, 204);
            this.province_lbl.Name = "province_lbl";
            this.province_lbl.Size = new System.Drawing.Size(124, 27);
            this.province_lbl.TabIndex = 0;
            this.province_lbl.Text = "Province";
            // 
            // country_lbl
            // 
            this.country_lbl.AutoSize = true;
            this.country_lbl.BackColor = System.Drawing.Color.Transparent;
            this.country_lbl.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_lbl.ForeColor = System.Drawing.Color.White;
            this.country_lbl.Location = new System.Drawing.Point(12, 125);
            this.country_lbl.Name = "country_lbl";
            this.country_lbl.Size = new System.Drawing.Size(110, 27);
            this.country_lbl.TabIndex = 0;
            this.country_lbl.Text = "Country";
            // 
            // province_dd
            // 
            this.province_dd.BackColor = System.Drawing.Color.Black;
            this.province_dd.DropDownHeight = 150;
            this.province_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.province_dd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.province_dd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.province_dd.ForeColor = System.Drawing.Color.Red;
            this.province_dd.FormattingEnabled = true;
            this.province_dd.IntegralHeight = false;
            this.province_dd.Location = new System.Drawing.Point(246, 201);
            this.province_dd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.province_dd.Name = "province_dd";
            this.province_dd.Size = new System.Drawing.Size(393, 31);
            this.province_dd.TabIndex = 1;
            this.province_dd.SelectedIndexChanged += new System.EventHandler(this.province_dd_SelectedIndexChanged);
            // 
            // country_dd
            // 
            this.country_dd.BackColor = System.Drawing.Color.Black;
            this.country_dd.DropDownHeight = 200;
            this.country_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_dd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.country_dd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_dd.ForeColor = System.Drawing.Color.Red;
            this.country_dd.FormattingEnabled = true;
            this.country_dd.IntegralHeight = false;
            this.country_dd.Location = new System.Drawing.Point(246, 125);
            this.country_dd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.country_dd.Name = "country_dd";
            this.country_dd.Size = new System.Drawing.Size(393, 31);
            this.country_dd.TabIndex = 1;
            this.country_dd.SelectedIndexChanged += new System.EventHandler(this.country_dd_SelectedIndexChanged);
            // 
            // confirm_lbl
            // 
            this.confirm_lbl.AutoSize = true;
            this.confirm_lbl.BackColor = System.Drawing.Color.Transparent;
            this.confirm_lbl.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.confirm_lbl.ForeColor = System.Drawing.Color.White;
            this.confirm_lbl.Location = new System.Drawing.Point(77, 257);
            this.confirm_lbl.Name = "confirm_lbl";
            this.confirm_lbl.Size = new System.Drawing.Size(96, 27);
            this.confirm_lbl.TabIndex = 0;
            this.confirm_lbl.Text = "Active";
            // 
            // CovidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 526);
            this.Controls.Add(this.bg_container);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CovidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19 Tracker - HaseeB Mir";
            this.Load += new System.EventHandler(this.CovidForm_Load);
            this.bg_container.ResumeLayout(false);
            this.bg_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.country_flag_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label country_lbl;
        private System.Windows.Forms.ComboBox country_dd;
        private System.Windows.Forms.Label confirm_lbl;
        private System.Windows.Forms.Button display_data_btn;
        private System.Windows.Forms.Button export_data_btn;
        private System.Windows.Forms.Panel bg_container;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label confirm_txt_box;
        private System.Windows.Forms.Label recovered_txt_box;
        private System.Windows.Forms.Label recovered_lbl;
        private System.Windows.Forms.Label fatal_txt_box;
        private System.Windows.Forms.Label deaths_lbl;
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label province_lbl;
        private System.Windows.Forms.ComboBox province_dd;
        private System.Windows.Forms.PictureBox country_flag_picbox;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label connection_lbl;
    }
}

