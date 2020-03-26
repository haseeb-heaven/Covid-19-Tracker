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
            this.label1 = new System.Windows.Forms.Label();
            this.country_dd = new System.Windows.Forms.ComboBox();
            this.active_cb = new System.Windows.Forms.CheckBox();
            this.fatal_cb = new System.Windows.Forms.CheckBox();
            this.recovered_cb = new System.Windows.Forms.CheckBox();
            this.track_data_btn = new System.Windows.Forms.Button();
            this.confirm_lbl = new System.Windows.Forms.Label();
            this.deaths_lbl = new System.Windows.Forms.Label();
            this.recovered_lbl = new System.Windows.Forms.Label();
            this.confirm_txt_box = new System.Windows.Forms.TextBox();
            this.deaths_txt_box = new System.Windows.Forms.TextBox();
            this.recovered_txt_box = new System.Windows.Forms.TextBox();
            this.global_cb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.display_data_btn = new System.Windows.Forms.Button();
            this.generate_data_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country";
            // 
            // country_dd
            // 
            this.country_dd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.country_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_dd.FormattingEnabled = true;
            this.country_dd.Location = new System.Drawing.Point(181, 32);
            this.country_dd.Name = "country_dd";
            this.country_dd.Size = new System.Drawing.Size(222, 24);
            this.country_dd.TabIndex = 1;
            this.country_dd.SelectedIndexChanged += new System.EventHandler(this.country_dd_SelectedIndexChanged);
            // 
            // active_cb
            // 
            this.active_cb.AutoSize = true;
            this.active_cb.BackColor = System.Drawing.Color.Transparent;
            this.active_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.active_cb.ForeColor = System.Drawing.Color.Silver;
            this.active_cb.Location = new System.Drawing.Point(43, 106);
            this.active_cb.Name = "active_cb";
            this.active_cb.Size = new System.Drawing.Size(75, 22);
            this.active_cb.TabIndex = 2;
            this.active_cb.Text = "Active";
            this.active_cb.UseVisualStyleBackColor = false;
            // 
            // fatal_cb
            // 
            this.fatal_cb.AutoSize = true;
            this.fatal_cb.BackColor = System.Drawing.Color.Transparent;
            this.fatal_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.fatal_cb.ForeColor = System.Drawing.Color.Silver;
            this.fatal_cb.Location = new System.Drawing.Point(181, 106);
            this.fatal_cb.Name = "fatal_cb";
            this.fatal_cb.Size = new System.Drawing.Size(67, 22);
            this.fatal_cb.TabIndex = 2;
            this.fatal_cb.Text = "Fatal";
            this.fatal_cb.UseVisualStyleBackColor = false;
            // 
            // recovered_cb
            // 
            this.recovered_cb.AutoSize = true;
            this.recovered_cb.BackColor = System.Drawing.Color.Transparent;
            this.recovered_cb.ForeColor = System.Drawing.Color.Silver;
            this.recovered_cb.Location = new System.Drawing.Point(315, 106);
            this.recovered_cb.Name = "recovered_cb";
            this.recovered_cb.Size = new System.Drawing.Size(99, 21);
            this.recovered_cb.TabIndex = 2;
            this.recovered_cb.Text = "Recovered";
            this.recovered_cb.UseVisualStyleBackColor = false;
            // 
            // track_data_btn
            // 
            this.track_data_btn.BackColor = System.Drawing.Color.Transparent;
            this.track_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.track_data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.track_data_btn.ForeColor = System.Drawing.Color.Silver;
            this.track_data_btn.Location = new System.Drawing.Point(43, 449);
            this.track_data_btn.Name = "track_data_btn";
            this.track_data_btn.Size = new System.Drawing.Size(379, 37);
            this.track_data_btn.TabIndex = 3;
            this.track_data_btn.Text = "Track Data";
            this.track_data_btn.UseVisualStyleBackColor = false;
            this.track_data_btn.Click += new System.EventHandler(this.corona_data_btn_Click);
            // 
            // confirm_lbl
            // 
            this.confirm_lbl.AutoSize = true;
            this.confirm_lbl.BackColor = System.Drawing.Color.Transparent;
            this.confirm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.confirm_lbl.ForeColor = System.Drawing.Color.Silver;
            this.confirm_lbl.Location = new System.Drawing.Point(42, 157);
            this.confirm_lbl.Name = "confirm_lbl";
            this.confirm_lbl.Size = new System.Drawing.Size(53, 18);
            this.confirm_lbl.TabIndex = 0;
            this.confirm_lbl.Text = "Active";
            // 
            // deaths_lbl
            // 
            this.deaths_lbl.AutoSize = true;
            this.deaths_lbl.BackColor = System.Drawing.Color.Transparent;
            this.deaths_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.deaths_lbl.ForeColor = System.Drawing.Color.Silver;
            this.deaths_lbl.Location = new System.Drawing.Point(42, 224);
            this.deaths_lbl.Name = "deaths_lbl";
            this.deaths_lbl.Size = new System.Drawing.Size(45, 18);
            this.deaths_lbl.TabIndex = 0;
            this.deaths_lbl.Text = "Fatal";
            // 
            // recovered_lbl
            // 
            this.recovered_lbl.AutoSize = true;
            this.recovered_lbl.BackColor = System.Drawing.Color.Transparent;
            this.recovered_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.recovered_lbl.ForeColor = System.Drawing.Color.Silver;
            this.recovered_lbl.Location = new System.Drawing.Point(42, 295);
            this.recovered_lbl.Name = "recovered_lbl";
            this.recovered_lbl.Size = new System.Drawing.Size(89, 18);
            this.recovered_lbl.TabIndex = 0;
            this.recovered_lbl.Text = "Recovered";
            // 
            // confirm_txt_box
            // 
            this.confirm_txt_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.confirm_txt_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm_txt_box.Enabled = false;
            this.confirm_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_txt_box.Location = new System.Drawing.Point(181, 157);
            this.confirm_txt_box.Name = "confirm_txt_box";
            this.confirm_txt_box.Size = new System.Drawing.Size(222, 24);
            this.confirm_txt_box.TabIndex = 4;
            // 
            // deaths_txt_box
            // 
            this.deaths_txt_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deaths_txt_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deaths_txt_box.Enabled = false;
            this.deaths_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deaths_txt_box.Location = new System.Drawing.Point(181, 221);
            this.deaths_txt_box.Name = "deaths_txt_box";
            this.deaths_txt_box.Size = new System.Drawing.Size(222, 24);
            this.deaths_txt_box.TabIndex = 4;
            // 
            // recovered_txt_box
            // 
            this.recovered_txt_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.recovered_txt_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recovered_txt_box.Enabled = false;
            this.recovered_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.recovered_txt_box.Location = new System.Drawing.Point(181, 295);
            this.recovered_txt_box.Name = "recovered_txt_box";
            this.recovered_txt_box.Size = new System.Drawing.Size(222, 24);
            this.recovered_txt_box.TabIndex = 4;
            // 
            // global_cb
            // 
            this.global_cb.AutoSize = true;
            this.global_cb.BackColor = System.Drawing.Color.Transparent;
            this.global_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.global_cb.ForeColor = System.Drawing.Color.Silver;
            this.global_cb.Location = new System.Drawing.Point(181, 62);
            this.global_cb.Name = "global_cb";
            this.global_cb.Size = new System.Drawing.Size(189, 22);
            this.global_cb.TabIndex = 2;
            this.global_cb.Text = "Global (All countries)";
            this.global_cb.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 0;
            // 
            // display_data_btn
            // 
            this.display_data_btn.AutoSize = true;
            this.display_data_btn.BackColor = System.Drawing.Color.Transparent;
            this.display_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.display_data_btn.ForeColor = System.Drawing.Color.Silver;
            this.display_data_btn.Location = new System.Drawing.Point(43, 372);
            this.display_data_btn.Name = "display_data_btn";
            this.display_data_btn.Size = new System.Drawing.Size(159, 37);
            this.display_data_btn.TabIndex = 5;
            this.display_data_btn.Text = "Display Data";
            this.display_data_btn.UseVisualStyleBackColor = false;
            this.display_data_btn.Click += new System.EventHandler(this.display_data_btn_Click);
            // 
            // generate_data_btn
            // 
            this.generate_data_btn.AutoSize = true;
            this.generate_data_btn.BackColor = System.Drawing.Color.Transparent;
            this.generate_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.generate_data_btn.ForeColor = System.Drawing.Color.Silver;
            this.generate_data_btn.Location = new System.Drawing.Point(244, 372);
            this.generate_data_btn.Name = "generate_data_btn";
            this.generate_data_btn.Size = new System.Drawing.Size(159, 37);
            this.generate_data_btn.TabIndex = 5;
            this.generate_data_btn.Text = "Generate Data";
            this.generate_data_btn.UseVisualStyleBackColor = false;
            this.generate_data_btn.Click += new System.EventHandler(this.generate_data_btn_Click);
            // 
            // CovidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.BackgroundImage = global::Covid_19_Tracker.Properties.Resources.app_bg;
            this.ClientSize = new System.Drawing.Size(458, 517);
            this.Controls.Add(this.generate_data_btn);
            this.Controls.Add(this.display_data_btn);
            this.Controls.Add(this.recovered_txt_box);
            this.Controls.Add(this.deaths_txt_box);
            this.Controls.Add(this.confirm_txt_box);
            this.Controls.Add(this.track_data_btn);
            this.Controls.Add(this.recovered_cb);
            this.Controls.Add(this.global_cb);
            this.Controls.Add(this.fatal_cb);
            this.Controls.Add(this.active_cb);
            this.Controls.Add(this.country_dd);
            this.Controls.Add(this.recovered_lbl);
            this.Controls.Add(this.deaths_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_lbl);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CovidForm";
            this.Text = "Covid-19 Tracker - HaseeB Mir";
            this.Load += new System.EventHandler(this.CovidForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox country_dd;
        private System.Windows.Forms.CheckBox active_cb;
        private System.Windows.Forms.CheckBox fatal_cb;
        private System.Windows.Forms.CheckBox recovered_cb;
        private System.Windows.Forms.Button track_data_btn;
        private System.Windows.Forms.Label confirm_lbl;
        private System.Windows.Forms.Label deaths_lbl;
        private System.Windows.Forms.Label recovered_lbl;
        private System.Windows.Forms.TextBox confirm_txt_box;
        private System.Windows.Forms.TextBox deaths_txt_box;
        private System.Windows.Forms.TextBox recovered_txt_box;
        private System.Windows.Forms.CheckBox global_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button display_data_btn;
        private System.Windows.Forms.Button generate_data_btn;
    }
}

