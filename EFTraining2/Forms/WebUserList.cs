using EFTraining2.Dtos;
using EFTraining2.Entity;
using EFTraining2.Service;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using User = EFTraining2.Entity.User;

namespace EFTraining2.Forms
{
    public partial class WebUserListForm : Form
    {
        public WebUserListForm()
        {
            InitializeComponent();
        }
        public void LoadData()

        {
     
            WebUserContext db = new WebUserContext();
            var UsersCombined = from user in db.Users
                          join city in db.Cities on user.CityId equals city.Id
                          select new
                          {
                              cityId = city.Id,
                              cityName = city.Name,
                              userId = user.Id,
                              userPhone = user.Phone,
                              userEmail = user.Email
                          };


            List<User> allusers = WebUserService.GetAll();

            List<UserGridDto> data = new List<UserGridDto>();

            foreach (var user in allusers)
            {
                UserGridDto model = new UserGridDto();

                model.Id = user.Id;
                var x = user.City;
                var y = user.CityId;
                model.FullName = user.FirstName + " " + user.LastName;
                model.Email = user.Email;
                model.Phone = user.Phone;
                model.CityName = user.City?.Name;
                data.Add(model);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UsersCombined.ToList();
        }

        private void WebUserListForm_Load(object sender, EventArgs e)
        {

            LoadData();
        }




        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // UserGridDto user = (UserGridDto)dataGridView1.CurrentRow.DataBoundItem;
                var user = dataGridView1.CurrentRow.DataBoundItem as UserGridDto;
                textBoxFullName.Text = user?.FullName;

                textBoxPhone.Text = user?.Phone;
                textBoxEmail.Text = user?.Email;



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UserGridDto user = (UserGridDto)dataGridView1.CurrentRow.DataBoundItem;

            textBoxFullName.Text = user.FullName;

            textBoxPhone.Text = user.Phone;
            textBoxEmail.Text = user.Email;
            int UserId = user.Id;

            WebUserContext db = new WebUserContext();

            var selectedUser = db.Users.Find(UserId);
            selectedUser.Phone = textBoxPhone.Text;
            selectedUser.Email = textBoxEmail.Text;


            db.SaveChanges();

            MessageBox.Show($"{selectedUser} is updated");
            LoadData();

        }
    }
}
