using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTraining2.Entity
{
    public class BaseEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime AddDate { get; set; }= DateTime.Now;

        public override string ToString()
        {
            return Name;
        }
    }
}
