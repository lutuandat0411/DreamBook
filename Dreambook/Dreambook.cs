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
        public Dreambook()
        {
            InitializeComponent();
        }
        
        private void ShowDreamList()
        {
            var db = new DreamDBEntities();
            this.dtManage.DataSource = db.DLists.ToList();
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
            var db = new DreamDBEntities();
            for (int i = 0; i < this.dtManage.SelectedRows.Count; i++)
            {
                var row = this.dtManage.SelectedRows[i];
                var item = (DList)row.DataBoundItem;
                try
                {
                    var delete = db.DLists.Find(item.idDream);
                    db.DLists.Remove(delete);
                    db.SaveChanges();
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
                var item = (DList)row.DataBoundItem;


                tabControl1.SelectTab(tabDetail);
                this.ShowDreamList();
            }
        }

        private void btnbtnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabHome);
        }
    }
}

