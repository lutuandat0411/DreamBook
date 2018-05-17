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
            DList addnew = new DList();
            addnew.Name = txtName.Text;
            addnew.Target = txtTarget.Text;
            addnew.Splitphase = Convert.ToInt32(txtSplit);
            addnew.DateCreated = dateTPBegin.Value;
            addnew.DateExpired = dateTPExpired.Value;
            try
            {
                var db = new DreamDBEntities();
                db.DLists.Add(addnew);
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
