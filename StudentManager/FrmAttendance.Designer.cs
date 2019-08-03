namespace StudentManager
{
    partial class FrmAttendance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendance));
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmTime = new System.Windows.Forms.Label();
            this.lblPmTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCarNm = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.timer_Click = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.Black;
            this.lblYear.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.Red;
            this.lblYear.Location = new System.Drawing.Point(23, 22);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(66, 30);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "2019";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.Black;
            this.lblMonth.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.Red;
            this.lblMonth.Location = new System.Drawing.Point(139, 22);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 30);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "07";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(95, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(188, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "月";
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.Black;
            this.lblDay.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDay.ForeColor = System.Drawing.Color.Red;
            this.lblDay.Location = new System.Drawing.Point(232, 22);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(43, 30);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "07";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(281, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "日";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(325, 22);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "12:30:30";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(482, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "星期";
            // 
            // lblWeek
            // 
            this.lblWeek.BackColor = System.Drawing.Color.Black;
            this.lblWeek.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblWeek.ForeColor = System.Drawing.Color.Red;
            this.lblWeek.Location = new System.Drawing.Point(551, 22);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(51, 30);
            this.lblWeek.TabIndex = 0;
            this.lblWeek.Text = "07";
            this.lblWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(23, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "上午时间";
            // 
            // lblAmTime
            // 
            this.lblAmTime.BackColor = System.Drawing.Color.White;
            this.lblAmTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmTime.ForeColor = System.Drawing.Color.Black;
            this.lblAmTime.Location = new System.Drawing.Point(142, 88);
            this.lblAmTime.Name = "lblAmTime";
            this.lblAmTime.Size = new System.Drawing.Size(174, 30);
            this.lblAmTime.TabIndex = 2;
            this.lblAmTime.Text = "8：00--11：30";
            this.lblAmTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPmTime
            // 
            this.lblPmTime.BackColor = System.Drawing.Color.White;
            this.lblPmTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPmTime.ForeColor = System.Drawing.Color.Black;
            this.lblPmTime.Location = new System.Drawing.Point(503, 88);
            this.lblPmTime.Name = "lblPmTime";
            this.lblPmTime.Size = new System.Drawing.Size(189, 30);
            this.lblPmTime.TabIndex = 2;
            this.lblPmTime.Text = "13：00--17：30";
            this.lblPmTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(82, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 30);
            this.lblName.TabIndex = 2;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(252, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "学号";
            // 
            // lblClassName
            // 
            this.lblClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblClassName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblClassName.ForeColor = System.Drawing.Color.Black;
            this.lblClassName.Location = new System.Drawing.Point(551, 150);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(139, 30);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(486, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "班级";
            // 
            // lblStudentId
            // 
            this.lblStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStudentId.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblStudentId.ForeColor = System.Drawing.Color.Black;
            this.lblStudentId.Location = new System.Drawing.Point(316, 150);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(139, 30);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(363, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "下午时间";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(23, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 29);
            this.label13.TabIndex = 3;
            this.label13.Text = "卡号";
            // 
            // txtCarNm
            // 
            this.txtCarNm.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtCarNm.Location = new System.Drawing.Point(87, 214);
            this.txtCarNm.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtCarNm.Multiline = true;
            this.txtCarNm.Name = "txtCarNm";
            this.txtCarNm.Size = new System.Drawing.Size(134, 30);
            this.txtCarNm.TabIndex = 4;
            this.txtCarNm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(325, 215);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(113, 29);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "打卡信息";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.skinButton1.Location = new System.Drawing.Point(550, 212);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(140, 35);
            this.skinButton1.TabIndex = 5;
            this.skinButton1.Text = "结束打卡";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.SkinButton1_Click);
            // 
            // timer_Click
            // 
            this.timer_Click.Enabled = true;
            this.timer_Click.Interval = 1000;
            this.timer_Click.Tick += new System.EventHandler(this.Timer_Click_Tick);
            // 
            // FrmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 271);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.txtCarNm);
            this.Controls.Add(this.lblPmTime);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAmTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[考勤打卡]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAttendance_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAmTime;
        private System.Windows.Forms.Label lblPmTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCarNm;
        private System.Windows.Forms.Label lblResult;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.Timer timer_Click;
    }
}