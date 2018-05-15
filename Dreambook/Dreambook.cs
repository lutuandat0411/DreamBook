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
    }
}
