using EFTraining2.Entity;
using EFTraining2.Service;

namespace EFTraining2
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }




        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            WebUserContext db = new WebUserContext();

            City city = cmbCities.SelectedItem as City;
            db.Users.Add(new User()
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Password = textBoxPassword.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxPhone.Text,
                CityId = city.Id
            });

            db.SaveChanges();
            MessageBox.Show($"{textBoxFirstName.Text} {textBoxLastName.Text} was added succesfully");
        }


        private void NewUserForm_Load(object sender, EventArgs e)
        {
            List<City> cities = CityService.GetAll();
            cmbCities.DataSource= cities;


        }
    }


}