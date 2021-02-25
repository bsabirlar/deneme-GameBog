using GameBog.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Entity
{
    public class GamerCustomer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTimeBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
