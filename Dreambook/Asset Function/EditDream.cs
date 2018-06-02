using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreambook.Asset_Function
{
    public partial class EditDream : Form
    {
        private DreamList DreamList;
        public EditDream(DreamList DreamList)
        {
            InitializeComponent();
            this.DreamList = DreamList;

        }

        private void EditDream_Load(object sender, EventArgs e)
        {
           
            DreamDBEntities1 db = new DreamDBEntities1();
            txtName.Text = DreamList.Name;
            txtTarget.Text = DreamList.Target;
            txtSplit.Text = Convert.ToString(DreamList.Splitphase);
            dTPDateCrt.Value = DreamList.DateCreated.Value;
            dTPDateEx.Value = DreamList.DateExpired;

        }

        private void btnbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int spt = int.Parse(txtSplit.Text);
                var db = new DreamDBEntities1();
                DreamList editDream = db.DreamLists.Find(DreamList.idDream);
                editDream.Name = txtName.Text;
                editDream.Target = txtTarget.Text;
                editDream.Splitphase = spt;
                editDream.DateCreated = dTPDateCrt.Value.Date;
                editDream.DateExpired = dTPDateEx.Value.Date;

                db.Entry(editDream).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 