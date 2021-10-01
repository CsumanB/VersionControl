using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usermaintenance.Entities;

namespace Usermaintenance
{
    BindingList<User> users = new BindingList<User>();
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
            lblLastName.Text = Resource1.LastName; // label1
            lblFirstName.Text = Resource1.FirstName; // label2
            btnAdd.Text = Resource1.Add; // button1
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text
            };
            users.Add(u);
        }
    }
}
