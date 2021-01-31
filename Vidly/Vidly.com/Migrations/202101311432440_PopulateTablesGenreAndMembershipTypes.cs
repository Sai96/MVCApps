namespace Vidly.com.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTablesGenreAndMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (1,'Pay As you Go',0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly',30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Quarterly',90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name,SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annual',300, 12, 20)");
            Sql("SET IDENTITY_INSERT Customers ON");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (1,'Barney Stinson',0, NULL, 1)");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (2,'Ted Mosby',1, NULL, 2)");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (3,'Marshall Erikson',0, NULL, 3)");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (4,'Lily Aldrin',1, NULL, 4)");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (5,'Carl',1, NULL, 1)");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (6,'Wendy',1, NULL, 2)");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (7,'Sandy Rivers',0, NULL, 3)");
            Sql("INSERT INTO Customers (Id, Name,IsSubscribedToNewsLetter,BirthDate,MembershipTypeId) VALUES (8,'Patrice',0, NULL, 4)");
            Sql("SET IDENTITY_INSERT Customers OFF");
        }

        public override void Down()
        {
        }
    }
}
