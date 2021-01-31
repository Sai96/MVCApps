namespace Vidly.com.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genretypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Drama/Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Action/Sci-fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Comedy/Family')");
            
        }
        
        public override void Down()
        {
        }
    }
}
