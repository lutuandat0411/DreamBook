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
    public partial class AddDream : Form
    {
        public AddDream()
        {
            InitializeComponent();
        }

        private void btnbtnAdd_Click(object sender, EventArgs e)
        {
            int sptphase = int.Parse(txtSplit.Text);
            DreamList addnew = new DreamList();
            addnew.Name = txtName.Text;
            addnew.Target = txtTarget.Text;
            addnew.Splitphase = sptphase;
            addnew.DateCreated = dateTPBegin.Value;
            addnew.DateExpired = dateTPExpired.Value;
            try
            {
                var db = new DreamDBEntities1();
                db.DreamLists.Add(addnew);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
