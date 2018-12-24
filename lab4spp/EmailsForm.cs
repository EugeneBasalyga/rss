using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4spp
{
    public partial class EmailsForm : Form
    {

        private List<string> EmailsList;

        public EmailsForm(List<string> _EmailsList)
        {
            EmailsList = _EmailsList;
            InitializeComponent();
        }

        private void EmailsForm_Load(object sender, EventArgs e)
        {
            foreach(var email in EmailsList)
            {
                var item = new ListViewItem(email);
                listViewEmails.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EmailsList.Add(textBoxEmail.Text);
            var item = new ListViewItem(textBoxEmail.Text);
            listViewEmails.Items.Add(item);
        }
    }
}
