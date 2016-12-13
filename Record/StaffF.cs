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
    public partial class StaffF : Form
    {
        UserCl uobj = new UserCl();
        DocumentCl dobj = new DocumentCl();
        string user;

        public StaffF()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void staff_document_showbtn_Click(object sender, EventArgs e)
        {

        }



        private void staff_logout_btn_Click(object sender, EventArgs e)
        {

        }

        private void staff_upload_savebtn_Click(object sender, EventArgs e)
        {

        }
        public void start(string user, string usertype)
        {
            uobj.setuser(user);
            dobj.setUser(user);
            this.user = user;

            label11.Text = uobj.UserName();
            label12.Text = uobj.UserId();
            label13.Text = uobj.department();
            label14.Text = uobj.emailId();

            string picturePath = uobj.showProfilePicture();
            Image img = Image.FromFile(picturePath);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = img;
            string a = uobj.UserId();


        }

       
    }
}
