using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class MedicineContext : DbContext

    {
        public DbSet<Admin>  Admins { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Medicine> Medicines { get; set; }


        public DbSet<SignUp> SignUps { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        
       
    }
}