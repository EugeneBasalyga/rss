using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace lab4spp
{
    public partial class MainForm : Form
    {

        private DataSet RssSet;
        private DataTable RssTable;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Readbutton_Click(object sender, EventArgs e)
        {
            try
            {
                RssTable.Rows.Clear();
                comboBoxTitle.Items.Clear();
                string url = RSSurltextBox.Text;
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                foreach (SyndicationItem item in feed.Items)
                {
                    DataRow dataRow = RssTable.NewRow();
                    dataRow["Title"] = item.Title.Text;
                    comboBoxTitle.Items.Add(item.Title.Text);
                    string summary = item.Summary.Text;
                    summary = Regex.Replace(summary, "<[^>]+>", string.Empty);
                    dataRow["Descryption"] = summary;
                    dataRow["Link"] = item.Id;
                    dataRow["PublishTime"] = item.PublishDate.LocalDateTime;
                    dataRow["Category"] = item.Categories[0].Name;
                    RssTable.Rows.Add(dataRow);
                    dataRow = null;
                }
            }
            catch
            {
                MessageBox.Show("Check RSS URI");
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RssSet = new DataSet("RssSet");
            RssTable = new DataTable("RssTable");

            RssSet.Tables.Add(RssTable);
            DataColumn Title = new DataColumn("Title", typeof(string));
            DataColumn Descryption = new DataColumn("Descryption", typeof(string));
            DataColumn Link = new DataColumn("Link", typeof(string));
            DataColumn PublishTime = new DataColumn("PublishTime", typeof(string));
            DataColumn Category = new DataColumn("Category", typeof(string));

            RssTable.Columns.AddRange(new DataColumn[] { Title, Descryption, Link, PublishTime, Category });
        }

        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxDescryption.Text = RssTable.Rows[comboBoxTitle.SelectedIndex]["Descryption"].ToString() + 
                "\n" + RssTable.Rows[comboBoxTitle.SelectedIndex]["Category"].ToString() + "\n" + RssTable.Rows[comboBoxTitle.SelectedIndex]["PublishTime"].ToString();
            linkLabel.Text = RssTable.Rows[comboBoxTitle.SelectedIndex]["Link"].ToString();
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

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm frm = new FilterForm(RssTable);
            frm.Show();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //}
            //else
            //{

            //}
        }
    }
}
