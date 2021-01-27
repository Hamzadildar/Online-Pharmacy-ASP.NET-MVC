namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        A_Name = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        A_UserName = c.String(nullable: false),
                        A_Password = c.String(nullable: false, maxLength: 100),
                        A_Cnic = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        M_Name = c.String(),
                        U_Name = c.String(nullable: false),
                        U_Contact = c.String(nullable: false),
                        U_Address = c.String(nullable: false),
                        M_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalBill = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                        PaymentMethod = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        Branch = c.String(nullable: false),
                        Message = c.String(maxLength: 500),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        M_Name = c.String(nullable: false),
                        Image = c.String(nullable: false),
                        M_Company = c.String(nullable: false),
                        M_Type = c.String(nullable: false),
                        M_Potency = c.String(nullable: false),
                        M_Details = c.String(nullable: false),
                        M_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SignUps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SignUps");
            DropTable("dbo.Medicines");
            DropTable("dbo.Contacts");
            DropTable("dbo.Carts");
            DropTable("dbo.Admins");
        }
    }
}
