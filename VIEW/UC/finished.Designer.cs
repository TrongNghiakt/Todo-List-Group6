namespace todolist.VIEW.UC
{
    partial class finished
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwMyPlan = new System.Windows.Forms.ListView();
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpMyPlan = new System.Windows.Forms.DateTimePicker();
            this.chkSelectUnselect = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lvwMyPlan);
            this.panel1.Location = new System.Drawing.Point(57, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 355);
            this.panel1.TabIndex = 57;
            // 
            // lvwMyPlan
            // 
            this.lvwMyPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lvwMyPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwMyPlan.CheckBoxes = true;
            this.lvwMyPlan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StartTime,
            this.EndTime,
            this.Description,
            this.Priority});
            this.lvwMyPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMyPlan.GridLines = true;
            this.lvwMyPlan.HideSelection = false;
            this.lvwMyPlan.LabelEdit = true;
            this.lvwMyPlan.Location = new System.Drawing.Point(0, 0);
            this.lvwMyPlan.Margin = new System.Windows.Forms.Padding(2);
            this.lvwMyPlan.Name = "lvwMyPlan";
            this.lvwMyPlan.Size = new System.Drawing.Size(675, 355);
            this.lvwMyPlan.TabIndex = 45;
            this.lvwMyPlan.UseCompatibleStateImageBehavior = false;
            this.lvwMyPlan.View = System.Windows.Forms.View.Details;
            this.lvwMyPlan.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwMyPlan_ItemChecked);
            this.lvwMyPlan.SelectedIndexChanged += new System.EventHandler(this.lvwMyPlan_SelectedIndexChanged);
            // 
            // StartTime
            // 
            this.StartTime.Tag = "StartTime";
            this.StartTime.Text = "StartTime";
            this.StartTime.Width = 120;
            // 
            // EndTime
            // 
            this.EndTime.Text = "EndTime";
            this.EndTime.Width = 120;
            // 
            // Description
            // 
            this.Description.Tag = "Description";
            this.Description.Text = "Description";
            this.Description.Width = 350;
            // 
            // Priority
            // 
            this.Priority.Tag = "Priority";
            this.Priority.Text = "Priority";
            this.Priority.Width = 100;
            // 
            // dtpMyPlan
            // 
            this.dtpMyPlan.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpMyPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMyPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMyPlan.Location = new System.Drawing.Point(666, 21);
            this.dtpMyPlan.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMyPlan.Name = "dtpMyPlan";
            this.dtpMyPlan.Size = new System.Drawing.Size(98, 20);
            this.dtpMyPlan.TabIndex = 56;
            this.dtpMyPlan.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chkSelectUnselect
            // 
            this.chkSelectUnselect.AutoSize = true;
            this.chkSelectUnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chkSelectUnselect.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSelectUnselect.CheckedState.BorderRadius = 0;
            this.chkSelectUnselect.CheckedState.BorderThickness = 0;
            this.chkSelectUnselect.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSelectUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectUnselect.Location = new System.Drawing.Point(396, 21);
            this.chkSelectUnselect.Name = "chkSelectUnselect";
            this.chkSelectUnselect.Size = new System.Drawing.Size(170, 19);
            this.chkSelectUnselect.TabIndex = 49;
            this.chkSelectUnselect.Text = "Select all/ Unselect all";
            this.chkSelectUnselect.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSelectUnselect.UncheckedState.BorderRadius = 0;
            this.chkSelectUnselect.UncheckedState.BorderThickness = 0;
            this.chkSelectUnselect.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSelectUnselect.UseVisualStyleBackColor = false;
            this.chkSelectUnselect.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::todolist.Properties.Resources.wt___Copy7;
            this.pictureBox16.Location = new System.Drawing.Point(228, 16);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(35, 32);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 55;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::todolist.Properties.Resources.wt___Copy5;
            this.pictureBox15.Location = new System.Drawing.Point(177, 15);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(35, 32);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 54;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::todolist.Properties.Resources.wt___Copy4;
            this.pictureBox14.Location = new System.Drawing.Point(138, 16);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(35, 32);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 53;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::todolist.Properties.Resources.wt___Copy;
            this.pictureBox13.Location = new System.Drawing.Point(277, 16);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(33, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 52;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::todolist.Properties.Resources.wt___Copy2;
            this.pictureBox12.Location = new System.Drawing.Point(91, 13);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(43, 42);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 51;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::todolist.Properties.Resources.wt___Copy3;
            this.pictureBox11.Location = new System.Drawing.Point(57, 16);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 50;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::todolist.Properties.Resources.wt___Copy1;
            this.pictureBox10.Location = new System.Drawing.Point(18, 16);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 49;
            this.pictureBox10.TabStop = false;
            // 
            // finished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.chkSelectUnselect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpMyPlan);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Name = "finished";
            this.Size = new System.Drawing.Size(809, 427);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpMyPlan;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ListView lvwMyPlan;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Priority;
        private Guna.UI2.WinForms.Guna2CheckBox chkSelectUnselect;
        private System.Windows.Forms.ColumnHeader EndTime;
    }
}
