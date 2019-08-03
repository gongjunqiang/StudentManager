namespace StudentManager
{
    partial class FrmScoreQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreQuery));
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLServerDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.SuspendLayout();
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
            this.StudentName,
            this.ClassName,
            this.CSharp,
            this.SQLServerDB});
            this.dgvScoreList.Location = new System.Drawing.Point(12, 46);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.Size = new System.Drawing.Size(485, 234);
            this.dgvScoreList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "学员班级：";
            // 
            // cbbClass
            // 
            this.cbbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(71, 14);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(121, 20);
            this.cbbClass.TabIndex = 6;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.CbbClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "按C#成绩快速浏览： C# >";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(382, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(66, 21);
            this.txtScore.TabIndex = 7;
            this.txtScore.TextChanged += new System.EventHandler(this.TxtScore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "分";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(423, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(11, 289);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(98, 23);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.Text = "显示全部成绩";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 80;
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
            // FrmScoreQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 323);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvScoreList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmScoreQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试成绩快速浏览";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmScoreQuery_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLServerDB;
    }
}