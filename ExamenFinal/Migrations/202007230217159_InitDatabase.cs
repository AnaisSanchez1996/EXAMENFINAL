namespace ExamenFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cuenta", "SaldoInicial", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cuenta", "SaldoInicial", c => c.Double(nullable: false));
        }
    }
}
