using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTraining2.Entity
{
    public class User:BaseEntity
    {



        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected string Name
        {
            get { return Name; }
            set { Name = FirstName + " " + LastName; }
        }

        public string Phone { get; set; }
        public string Email { get; set; }
        
        public string Password { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }

    }
}
