namespace Prog1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IpxModelSave : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ipxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DecimalNumber = c.String(),
                        ProgramName = c.String(),
                        Subject = c.String(),
                        DocumentUsage = c.String(),
                        Letter = c.String(),
                        Author = c.String(),
                        Organization = c.String(),
                        Producer = c.String(),
                        Owner = c.String(),
                        ResponsiblePerson = c.String(),
                        HeadOfBmd = c.String(),
                        SetupDisc = c.String(),
                        SourceDisc = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DecimalNumber = c.String(),
                        ProgramName = c.String(),
                        DocumentCode = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        VolumeSequenceNumber = c.String(),
                        SetupDisc = c.String(),
                        SourceDisc = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Labels");
            DropTable("dbo.Ipxes");
        }
    }
}
