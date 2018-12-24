using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Net.Mail;
using System.Threading;

namespace lab4spp
{
    public partial class FilterForm : Form
    {
        private DataTable RssTable;
        private DataTable RssTableFilter;
        private DataSet RssSetFilter;
        private List<string> EmailsList = new List<string>();
        private List<Thread> EmailsThreadList = new List<Thread>();
        object locker = new object();

        public FilterForm(DataTable _RssTable)
        {
            RssTable = _RssTable;
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            comboBoxTitle.Items.Clear();
            RssTableFilter.Rows.Clear();
            Thread thread = new Thread(() => FindSubstring());
            thread.Start();
            thread.Join();
            foreach (DataRow row in RssTableFilter.Rows)
            {
                comboBoxTitle.Items.Add(row["Title"]);
            }
        }


        private void FindSubstring()
        {
            foreach (DataRow row in RssTable.Rows)
            {
                string pattern = textBoxFind.Text;
                string input = row["Title"].ToString();
                Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (m.Success)
                {
                    //comboBoxTitle.Items.Add(input);
                    DataRow FilterRow = RssTableFilter.NewRow();

                    FilterRow["Title"] = row["Title"];
                    FilterRow["Descryption"] = row["Descryption"];
                    FilterRow["Link"] = row["Link"];
                    FilterRow["PublishTime"] = row["PublishTime"];
                    FilterRow["Category"] = row["Category"];

                    RssTableFilter.Rows.Add(FilterRow);
                }
            }
        }


        private void FilterForm_Load(object sender, EventArgs e)
        {
            RssSetFilter = new DataSet("RssSetFilter");
            RssTableFilter = new DataTable("RssTableFilter");

            RssSetFilter.Tables.Add(RssTableFilter);
            DataColumn Title = new DataColumn("Title", typeof(string));
            DataColumn Descryption = new DataColumn("Descryption", typeof(string));
            DataColumn Link = new DataColumn("Link", typeof(string));
            DataColumn PublishTime = new DataColumn("PublishTime", typeof(string));
            DataColumn Category = new DataColumn("Category", typeof(string));

            RssTableFilter.Columns.AddRange(new DataColumn[] { Title, Descryption, Link, PublishTime, Category });

            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
            EmailsList.Add("basalygaeugene@gmail.com");
        }

        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxDescryption.Text = RssTableFilter.Rows[comboBoxTitle.SelectedIndex]["Descryption"].ToString() +
    "\n" + RssTableFilter.Rows[comboBoxTitle.SelectedIndex]["Category"].ToString() + "\n" + RssTableFilter.Rows[comboBoxTitle.SelectedIndex]["PublishTime"].ToString();
            linkLabel.Text = RssTableFilter.Rows[comboBoxTitle.SelectedIndex]["Link"].ToString();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(linkLabel.Text);
            }
            catch
            {

            }
        }

        private void emailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailsForm frm = new EmailsForm(EmailsList);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {

            }
        }


        private string CombineContent()
        {
            string body = string.Empty;
            foreach (DataRow row in RssTableFilter.Rows)
            {
                body += row["Descryption"] + "\n";
                body += "-------------------------------------------------------------------------------------------------------\n";
            }
            return body;
        }

        //private void SendEmail(object state)
        //{
        //    lock (locker)
        //    {
        //        object[] array = state as object[];
        //        string To = array[0] as string;
        //        string body = array[1] as string;
        //        MailMessage mail = new MailMessage("zhekabas@gmail.com", To, "Rss", body);
        //        SmtpClient client = new SmtpClient
        //        {
        //            Port = 587,
        //            Host = "smtp.gmail.com",
        //            EnableSsl = true,
        //            DeliveryMethod = SmtpDeliveryMethod.Network,
        //            UseDefaultCredentials = false,
        //            Credentials = new System.Net.NetworkCredential("gmail", "password")
        //        };
        //        client.SendAsync(mail, null);
        //        //client.Send(mail);
        //    }
        //}


        private void SendEmail(string email, string body)
        {
            lock (locker)
            {
                MailMessage mail = new MailMessage("zhekabas@gmail.com", email, "Rss", body);
                SmtpClient client = new SmtpClient
                {
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("gmail", "password")
                };
                client.SendAsync(mail, null);
                //client.Send(mail);
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = CombineContent();
            foreach (string email in EmailsList)
            {
                //ThreadPool.QueueUserWorkItem(SendEmail, new object[] { email, str });
                WaitCallback p = state => SendEmail(email, str);
                ThreadPool.QueueUserWorkItem(p);

                //EmailsThreadList.Add(new Thread(() => SendEmail(email, str)));
                //EmailsThreadList[EmailsThreadList.Count - 1].Start();
            }
        }
    }
}
