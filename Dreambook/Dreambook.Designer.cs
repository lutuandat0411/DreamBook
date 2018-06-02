namespace Dreambook
{
    partial class Dreambook
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtManage = new System.Windows.Forms.DataGridView();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.btnbtnBack = new System.Windows.Forms.Button();
            this.btnbtnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPDateEx = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPDateCrt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtManage)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabManage);
            this.tabControl1.Controls.Add(this.tabDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(541, 367);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.btnRefresh);
            this.tabManage.Controls.Add(this.btnDelete);
            this.tabManage.Controls.Add(this.btnAdd);
            this.tabManage.Controls.Add(this.dtManage);
            this.tabManage.Location = new System.Drawing.Point(4, 22);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(541, 367);
            this.tabManage.TabIndex = 1;
            this.tabManage.Text = "Manage";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(234, 315);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 49);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Reload";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(393, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtManage
            // 
            this.dtManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtManage.Location = new System.Drawing.Point(3, 3);
            this.dtManage.Name = "dtManage";
            this.dtManage.Size = new System.Drawing.Size(535, 305);
            this.dtManage.TabIndex = 0;
            this.dtManage.DoubleClick += new System.EventHandler(this.dtManage_DoubleClick);
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.btnbtnBack);
            this.tabDetail.Controls.Add(this.btnbtnSave);
            this.tabDetail.Controls.Add(this.label5);
            this.tabDetail.Controls.Add(this.dTPDateEx);
            this.tabDetail.Controls.Add(this.label4);
            this.tabDetail.Controls.Add(this.dTPDateCrt);
            this.tabDetail.Controls.Add(this.label3);
            this.tabDetail.Controls.Add(this.label2);
            this.tabDetail.Controls.Add(this.label1);
            this.tabDetail.Controls.Add(this.txtSplit);
            this.tabDetail.Controls.Add(this.txtTarget);
            this.tabDetail.Controls.Add(this.txtName);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(541, 367);
            this.tabDetail.TabIndex = 3;
            this.tabDetail.Text = "Detail";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // btnbtnBack
            // 
            this.btnbtnBack.Location = new System.Drawing.Point(396, 300);
            this.btnbtnBack.Name = "btnbtnBack";
            this.btnbtnBack.Size = new System.Drawing.Size(114, 50);
            this.btnbtnBack.TabIndex = 11;
            this.btnbtnBack.Text = "Back";
            this.btnbtnBack.UseVisualStyleBackColor = true;
            // 
            // btnbtnSave
            // 
            this.btnbtnSave.Location = new System.Drawing.Point(244, 300);
            this.btnbtnSave.Name = "btnbtnSave";
            this.btnbtnSave.Size = new System.Drawing.Size(115, 50);
            this.btnbtnSave.TabIndex = 10;
            this.btnbtnSave.Text = "Save";
            this.btnbtnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SliptPhase";
            // 
            // dTPDateEx
            // 
            this.dTPDateEx.Location = new System.Drawing.Point(123, 165);
            this.dTPDateEx.Name = "dTPDateEx";
            this.dTPDateEx.Size = new System.Drawing.Size(219, 20);
            this.dTPDateEx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Expired";
            // 
            // dTPDateCrt
            // 
            this.dTPDateCrt.Location = new System.Drawing.Point(123, 119);
            this.dTPDateCrt.Name = "dTPDateCrt";
            this.dTPDateCrt.Size = new System.Drawing.Size(219, 20);
            this.dTPDateCrt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(123, 220);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(92, 20);
            this.txtSplit.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(88, 79);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(171, 20);
            this.txtTarget.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 0;
            // 
            // Dreambook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dreambook";
            this.Text = "Dreambook";
            this.Load += new System.EventHandler(this.Dreambook_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtManage)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.tabDetail.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.DataGridView dtManage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSplit;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPDateCrt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPDateEx;
        private System.Windows.Forms.Button btnbtnSave;
        private System.Windows.Forms.Button btnbtnBack;
        private System.Windows.Forms.Button btnRefresh;
    }
}