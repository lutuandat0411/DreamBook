namespace Dreambook.Asset_Function
{
    partial class EditDream
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.dTPDateCrt = new System.Windows.Forms.DateTimePicker();
            this.dTPDateEx = new System.Windows.Forms.DateTimePicker();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.btnbtnSave = new System.Windows.Forms.Button();
            this.btnbtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Created";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Expired";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Splitphase";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(58, 60);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(133, 20);
            this.txtTarget.TabIndex = 6;
            // 
            // dTPDateCrt
            // 
            this.dTPDateCrt.Location = new System.Drawing.Point(90, 105);
            this.dTPDateCrt.Name = "dTPDateCrt";
            this.dTPDateCrt.Size = new System.Drawing.Size(200, 20);
            this.dTPDateCrt.TabIndex = 7;
            // 
            // dTPDateEx
            // 
            this.dTPDateEx.Location = new System.Drawing.Point(90, 149);
            this.dTPDateEx.Name = "dTPDateEx";
            this.dTPDateEx.Size = new System.Drawing.Size(200, 20);
            this.dTPDateEx.TabIndex = 8;
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(90, 183);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(100, 20);
            this.txtSplit.TabIndex = 9;
            // 
            // btnbtnSave
            // 
            this.btnbtnSave.Location = new System.Drawing.Point(115, 285);
            this.btnbtnSave.Name = "btnbtnSave";
            this.btnbtnSave.Size = new System.Drawing.Size(106, 49);
            this.btnbtnSave.TabIndex = 10;
            this.btnbtnSave.Text = "Save";
            this.btnbtnSave.UseVisualStyleBackColor = true;
            this.btnbtnSave.Click += new System.EventHandler(this.btnbtnSave_Click);
            // 
            // btnbtnCancel
            // 
            this.btnbtnCancel.Location = new System.Drawing.Point(227, 285);
            this.btnbtnCancel.Name = "btnbtnCancel";
            this.btnbtnCancel.Size = new System.Drawing.Size(104, 49);
            this.btnbtnCancel.TabIndex = 11;
            this.btnbtnCancel.Text = "Cancel";
            this.btnbtnCancel.UseVisualStyleBackColor = true;
            this.btnbtnCancel.Click += new System.EventHandler(this.btnbtnCancel_Click);
            // 
            // EditDream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 346);
            this.Controls.Add(this.btnbtnCancel);
            this.Controls.Add(this.btnbtnSave);
            this.Controls.Add(this.txtSplit);
            this.Controls.Add(this.dTPDateEx);
            this.Controls.Add(this.dTPDateCrt);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditDream";
            this.Text = "EditDream";
            this.Load += new System.EventHandler(this.EditDream_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.DateTimePicker dTPDateCrt;
        private System.Windows.Forms.DateTimePicker dTPDateEx;
        private System.Windows.Forms.TextBox txtSplit;
        private System.Windows.Forms.Button btnbtnSave;
        private System.Windows.Forms.Button btnbtnCancel;
    }
}