using EFTraining2.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTraining2.Forms
{
    public partial class SearchUserForm : Form
    {
        public SearchUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebUserContext db = new WebUserContext();

            int searchId = Convert.ToInt32(textBoxSearch.Text);
            User user = db.Users.Find(searchId);

            labelFullName.Text=user.FirstName+ " " + user.LastName;
            labelEmail.Text=user.Email;
            labelPhone.Text=user.Phone;

        }
    }
}
