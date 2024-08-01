namespace todolist.VIEW.UC
{
    partial class today
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
            this.lvwToday = new System.Windows.Forms.ListView();
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwToday
            // 
            this.lvwToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lvwToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwToday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StartTime,
            this.EndTime,
            this.Description,
            this.Priority});
            this.lvwToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwToday.GridLines = true;
            this.lvwToday.HideSelection = false;
            this.lvwToday.LabelEdit = true;
            this.lvwToday.Location = new System.Drawing.Point(10, 63);
            this.lvwToday.Margin = new System.Windows.Forms.Padding(2);
            this.lvwToday.Name = "lvwToday";
            this.lvwToday.Size = new System.Drawing.Size(518, 348);
            this.lvwToday.TabIndex = 44;
            this.lvwToday.UseCompatibleStateImageBehavior = false;
            this.lvwToday.View = System.Windows.Forms.View.Details;
            this.lvwToday.SelectedIndexChanged += new System.EventHandler(this.lvwToday_SelectedIndexChanged);
            // 
            // StartTime
            // 
            this.StartTime.Tag = "StartTime";
            this.StartTime.Text = "StartTime";
            this.StartTime.Width = 150;
            // 
            // Description
            // 
            this.Description.Tag = "Description";
            this.Description.Text = "Description";
            this.Description.Width = 250;
            // 
            // Priority
            // 
            this.Priority.Tag = "Priority";
            this.Priority.Text = "Priority";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::todolist.Properties.Resources.wt___Copy7;
            this.pictureBox16.Location = new System.Drawing.Point(208, 17);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(35, 32);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 41;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::todolist.Properties.Resources.wt___Copy5;
            this.pictureBox15.Location = new System.Drawing.Point(169, 17);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(35, 32);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 40;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::todolist.Properties.Resources.wt___Copy4;
            this.pictureBox14.Location = new System.Drawing.Point(129, 19);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(35, 32);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 39;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::todolist.Properties.Resources.wt___Copy;
            this.pictureBox13.Location = new System.Drawing.Point(247, 18);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(33, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 38;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::todolist.Properties.Resources.wt___Copy2;
            this.pictureBox12.Location = new System.Drawing.Point(82, 9);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(43, 42);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 37;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::todolist.Properties.Resources.wt___Copy3;
            this.pictureBox11.Location = new System.Drawing.Point(44, 16);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 36;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::todolist.Properties.Resources.wt___Copy1;
            this.pictureBox10.Location = new System.Drawing.Point(10, 16);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel8.Controls.Add(this.dtpEndTime);
            this.panel8.Controls.Add(this.lbEndTime);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.btnAddUpdate);
            this.panel8.Controls.Add(this.rdo4);
            this.panel8.Controls.Add(this.rdo3);
            this.panel8.Controls.Add(this.rdo2);
            this.panel8.Controls.Add(this.rdo1);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.dtpStartTime);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.txtDescription);
            this.panel8.Location = new System.Drawing.Point(548, 63);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(266, 348);
            this.panel8.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Description :";
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(170, 322);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnAddUpdate.TabIndex = 3;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo4.Location = new System.Drawing.Point(221, 298);
            this.rdo4.Margin = new System.Windows.Forms.Padding(2);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(41, 19);
            this.rdo4.TabIndex = 43;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "IV";
            this.rdo4.UseVisualStyleBackColor = true;
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo3.Location = new System.Drawing.Point(182, 298);
            this.rdo3.Margin = new System.Windows.Forms.Padding(2);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(42, 19);
            this.rdo3.TabIndex = 42;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "III";
            this.rdo3.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo2.Location = new System.Drawing.Point(145, 298);
            this.rdo2.Margin = new System.Windows.Forms.Padding(2);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(36, 19);
            this.rdo2.TabIndex = 41;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "II";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1.Location = new System.Drawing.Point(108, 298);
            this.rdo1.Margin = new System.Windows.Forms.Padding(2);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(30, 19);
            this.rdo1.TabIndex = 40;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "I";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 295);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Priority:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(93, 19);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(163, 20);
            this.dtpStartTime.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Start at:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(18, 59);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(238, 193);
            this.txtDescription.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(549, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Details:";
            // 
            // picDelete
            // 
            this.picDelete.Image = global::todolist.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.picDelete.Location = new System.Drawing.Point(500, 19);
            this.picDelete.Margin = new System.Windows.Forms.Padding(2);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(28, 23);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 43;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.pictureBox24_Click);
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndTime.Location = new System.Drawing.Point(19, 266);
            this.lbEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(60, 17);
            this.lbEndTime.TabIndex = 48;
            this.lbEndTime.Text = "End at:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(93, 266);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(163, 20);
            this.dtpEndTime.TabIndex = 49;
            // 
            // EndTime
            // 
            this.EndTime.Tag = "EndTime";
            this.EndTime.Text = "EndTime";
            this.EndTime.Width = 150;
            // 
            // today
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lvwToday);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picDelete);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "today";
            this.Size = new System.Drawing.Size(825, 427);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwToday;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.ColumnHeader EndTime;
    }
}
