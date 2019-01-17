namespace AdsProGroup.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Middlename = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        Street_Id = c.Int(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Streets", t => t.Street_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Street_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street1 = c.String(),
                        Street2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Value = c.String(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Value = c.String(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Emails", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "Street_Id", "dbo.Streets");
            DropIndex("dbo.Phones", new[] { "Customer_Id" });
            DropIndex("dbo.Emails", new[] { "Customer_Id" });
            DropIndex("dbo.Addresses", new[] { "Customer_Id" });
            DropIndex("dbo.Addresses", new[] { "Street_Id" });
            DropTable("dbo.Phones");
            DropTable("dbo.Emails");
            DropTable("dbo.Streets");
            DropTable("dbo.Addresses");
            DropTable("dbo.Customers");
        }
    }
}
