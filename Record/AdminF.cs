using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Record
{
    public partial class AdminF : Form
    {   
        UserCl uobj = new UserCl();
        DocumentCl dobj = new DocumentCl();
        string user;

        public AdminF()
        {
            InitializeComponent();
         
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void admin_document_showbtn_Click(object sender, EventArgs e)
        {

        }

        private void admin_upload_openfolder_btn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = ofd.FileName;
                textBox3.Text = ofd.SafeFileName;

            }
        }

        private void admin_upload_savebtn_Click(object sender, EventArgs e)
        {

        }

        private void admin_looutbtn_Click(object sender, EventArgs e)
        {

        }

        private void admin_share_openfolder_Click(object sender, EventArgs e)
        {

        }

        private void admin_share_savebtn_Click(object sender, EventArgs e)
        {

        }
        public void start(string user, string usertype)
        {
            uobj.setuser(user);
            dobj.setUser(user);
            this.user = user;

            label15.Text = uobj.UserName();
            label16.Text = uobj.UserId();
            label17.Text = uobj.department();
            label18.Text = uobj.emailId();

            string picturePath = uobj.showProfilePicture();
            Image img = Image.FromFile(picturePath);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = img;
            string a = uobj.UserId();


        }
   
    }
}
