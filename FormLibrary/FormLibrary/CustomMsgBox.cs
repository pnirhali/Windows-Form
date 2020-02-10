using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLibrary.DTO;

namespace FormLibrary
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(MsgBoxReq msgBoxReq)
        {
            InitializeComponent();
            CreateButttons();
            SetImage(msgBoxReq);
            SetMessageBoxData(msgBoxReq);

        }

        private void SetImage(MsgBoxReq msgBoxReq)
        {
            switch (msgBoxReq.Image)
            {
                case ImageAction.Warning:
                    this.pictureBox1.Image = Properties.Resources.sign_warning_icon1;
                    break;
                case ImageAction.Error:
                    this.pictureBox1.Image = Properties.Resources.Close_icon;
                    break;
                case ImageAction.Info:
                    this.pictureBox1.Image = Properties.Resources.Button_Info_icon;
                    break;
                default:
                    break;

            }

        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void SetMessageBoxData(MsgBoxReq msgBoxReq)
        {

            this.lblTitle.Text = msgBoxReq.Caption;
            this.richTextBox1.Text = "this is awosom pciture.";
            LinkLabel link = new LinkLabel();
            link.Text = "something";
            link.LinkClicked += new LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            LinkLabel.Link data = new LinkLabel.Link();
            data.LinkData = @"http://www.google.com";
            link.Links.Add(data);
            link.AutoSize = true;
            link.Location =
                this.richTextBox1.GetPositionFromCharIndex(this.richTextBox1.TextLength);
            this.richTextBox1.Controls.Add(link);
            this.richTextBox1.AppendText(link.Text + "   ");
            this.richTextBox1.AppendText(" after text  ");

            this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;

        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        private void CreateButttons()
        {

            Button newButton = new Button();
            this.Controls.Add(newButton);
            newButton.Text = "Created Button";
            newButton.Location = new Point(70, 70);
            newButton.Size = new Size(50, 100);
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        public static void Show(MsgBoxReq msgBoxReq)
        {



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // this.Parent.close();
            //e.Cancel = true;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
