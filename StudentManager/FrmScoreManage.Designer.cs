﻿namespace StudentManager
{
    partial class FrmScoreManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreManage));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.LblDBAvg = new System.Windows.Forms.Label();
            this.LblCSharpAvg = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAttendCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblList = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLServerDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学员班级：";
            // 
            // cbbClass
            // 
            this.cbbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(79, 16);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(121, 20);
            this.cbbClass.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(361, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "统计全校考试信息";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.Id,
            this.ClassId,
            this.StudentName,
            this.ClassName,
            this.CSharp,
            this.SQLServerDB,
            this.UpdateTime});
            this.dgvScoreList.Location = new System.Drawing.Point(15, 49);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.Size = new System.Drawing.Size(481, 150);
            this.dgvScoreList.TabIndex = 3;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.LblDBAvg);
            this.gbInfo.Controls.Add(this.LblCSharpAvg);
            this.gbInfo.Controls.Add(this.lblCount);
            this.gbInfo.Controls.Add(this.lblAttendCount);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Location = new System.Drawing.Point(15, 210);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(288, 110);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "全校考试成绩统计";
            // 
            // LblDBAvg
            // 
            this.LblDBAvg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDBAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDBAvg.Location = new System.Drawing.Point(216, 71);
            this.LblDBAvg.Name = "LblDBAvg";
            this.LblDBAvg.Size = new System.Drawing.Size(59, 25);
            this.LblDBAvg.TabIndex = 0;
            this.LblDBAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCSharpAvg
            // 
            this.LblCSharpAvg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCSharpAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCSharpAvg.Location = new System.Drawing.Point(76, 71);
            this.LblCSharpAvg.Name = "LblCSharpAvg";
            this.LblCSharpAvg.Size = new System.Drawing.Size(59, 25);
            this.LblCSharpAvg.TabIndex = 0;
            this.LblCSharpAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(216, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 25);
            this.lblCount.TabIndex = 0;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAttendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendCount.Location = new System.Drawing.Point(76, 32);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(59, 25);
            this.lblAttendCount.TabIndex = 0;
            this.lblAttendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "DB平均分：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "C#平均分：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "缺考总人数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "参考总人数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblList);
            this.groupBox2.Location = new System.Drawing.Point(309, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缺考人员名单";
            // 
            // lblList
            // 
            this.lblList.FormattingEnabled = true;
            this.lblList.ItemHeight = 12;
            this.lblList.Location = new System.Drawing.Point(16, 22);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(157, 76);
            this.lblList.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(432, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭按钮";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 80;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ScoreId";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "ClassId";
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            this.ClassId.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 80;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 80;
            // 
            // CSharp
            // 
            this.CSharp.DataPropertyName = "CSharp";
            this.CSharp.HeaderText = "C#成绩";
            this.CSharp.Name = "CSharp";
            this.CSharp.ReadOnly = true;
            this.CSharp.Width = 80;
            // 
            // SQLServerDB
            // 
            this.SQLServerDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SQLServerDB.DataPropertyName = "SQLServerDB";
            this.SQLServerDB.HeaderText = "数据库成绩";
            this.SQLServerDB.Name = "SQLServerDB";
            this.SQLServerDB.ReadOnly = true;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "UpdateTime";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Visible = false;
            // 
            // FrmScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvScoreList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScoreManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[成绩查询]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmScoreManage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label LblDBAvg;
        private System.Windows.Forms.Label LblCSharpAvg;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAttendCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lblList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLServerDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
    }
}