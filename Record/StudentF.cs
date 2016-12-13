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
    public partial class StudentF : Form
    {
        UserCl uobj = new UserCl();
        DocumentCl dobj = new DocumentCl();

        string user;

        public StudentF()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void teacher_logoutbtn_Click(object sender, EventArgs e)
        {

        }

        private void teacher_document_showbtn_Click(object sender, EventArgs e)
        {

        }

        private void teacher_upload_fileopen_btn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Teacher_upload_pathtxt.Text = ofd.FileName;
                Teacher_uploadfile_nametxt.Text = ofd.SafeFileName;

            }
        }

        private void teacher_upload_savebtn_Click(object sender, EventArgs e)
        {

        }

        private void teacher_share_savebtn_Click(object sender, EventArgs e)
        {

        }

        private void teacher_share_openfilebtn_Click(object sender, EventArgs e)
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
