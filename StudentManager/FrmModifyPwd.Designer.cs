namespace StudentManager
{
    partial class FrmModifyPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyPwd));
            this.txtNewPwdConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // txtNewPwdConfirm
            // 
            this.txtNewPwdConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPwdConfirm.Location = new System.Drawing.Point(120, 80);
            this.txtNewPwdConfirm.Name = "txtNewPwdConfirm";
            this.txtNewPwdConfirm.Size = new System.Drawing.Size(120, 21);
            this.txtNewPwdConfirm.TabIndex = 10;
            this.txtNewPwdConfirm.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "新密码确认：";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPwd.Location = new System.Drawing.Point(120, 50);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(120, 21);
            this.txtNewPwd.TabIndex = 9;
            this.txtNewPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(52, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "新密码：";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPwd.Location = new System.Drawing.Point(120, 23);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(120, 21);
            this.txtOldPwd.TabIndex = 7;
            this.txtOldPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "原密码：";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModify.DownBack = null;
            this.btnModify.Location = new System.Drawing.Point(54, 112);
            this.btnModify.MouseBack = null;
            this.btnModify.Name = "btnModify";
            this.btnModify.NormlBack = null;
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "确认修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(165, 112);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 163);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtNewPwdConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifyPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改登录密码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModifyPwd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNewPwdConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton btnModify;
        private CCWin.SkinControl.SkinButton btnCancel;
    }
}