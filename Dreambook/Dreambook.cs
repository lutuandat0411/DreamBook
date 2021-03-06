﻿using Dreambook.Asset_Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreambook
{
    public partial class Dreambook : Form
    {
        
        public Dreambook()
        {
            InitializeComponent();
        }
        
        private void ShowDreamList()
        {
            var db = new DreamDBEntities1();
            
            this.dtManage.DataSource = db.DreamLists.ToList();
            this.dtManage.Columns["idDream"].Visible = false;
            this.dtManage.Columns["status"].Visible = false;
            this.dtHome.DataSource = db.DreamLists.ToList();
            this.dtHome.Columns["idDream"].Visible = false;
            this.dtHome.Columns["splitphase"].Visible = false;
            this.dtHome.Columns["DateCreated"].Visible = false;
            this.dtHome.Columns["DateExpired"].Visible = false;
        }

        private void Dreambook_Load(object sender, EventArgs e)
        {
            this.ShowDreamList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var add = new AddDream();
            add.Show();
            this.ShowDreamList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.dtManage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var db = new DreamDBEntities1();
            for (int i = 0; i < this.dtManage.SelectedRows.Count; i++)
            {
                var row = this.dtManage.SelectedRows[i];
                var item = (DreamList)row.DataBoundItem;
                try
                {
                    var delete = db.DreamLists.Find(item.idDream);
                    db.DreamLists.Remove(delete);
                    db.SaveChanges();
                    this.ShowDreamList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dtManage_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtManage.SelectedRows.Count == 1)
            {
                this.tabControl1.SelectedTab = tabDetail;
                var row = this.dtManage.SelectedRows[0];
                var item = (DreamList)row.DataBoundItem;

                var form = new EditDream(item);
                form.ShowDialog();
                this.tabControl1.SelectedTab = tabManage;
                this.ShowDreamList();
            }
        }

        private object EditDream(DreamList item)
        {
            throw new NotImplementedException();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ShowDreamList();
        }
    }
}

