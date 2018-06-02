using Dreambook.Asset_Function;
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
        private DreamList DreamList;
        public Dreambook()
        {
            InitializeComponent();
        }
        
        private void ShowDreamList()
        {
            var db = new DreamDBEntities1();
            this.dtManage.DataSource = db.DreamLists.ToList();
        }

        private void Dreambook_Load(object sender, EventArgs e, DreamList DreamList)
        {
            this.DreamList = DreamList;
            this.ShowDreamList();
            DreamDBEntities1 db = new DreamDBEntities1();
            txtName.Text = DreamList.Name;
            txtTarget.Text = DreamList.Target;
            dTPDateCrt.Value = DreamList.DateCreated.Value;

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
                var row = this.dtManage.SelectedRows[0];
                var item = (DreamList)row.DataBoundItem;


                tabControl1.SelectTab(tabDetail);
                this.ShowDreamList();
            }
        }

        private void btnbtnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabHome);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ShowDreamList();
        }
    }
}

