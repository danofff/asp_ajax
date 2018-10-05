namespace asp_ajax.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AddDataToTables : DbMigration
    {
        public override void Up()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (db.Independent.Count() != 0)
            {
                Sql("TRUNCATE TABLE Independents");
            }
            Sql(@"SET IDENTITY_INSERT [dbo].[Independents] ON
INSERT INTO [dbo].[Independents] ([Id], [Value], [Definition]) VALUES (1, N'X1', N'MIBK(X1)')
INSERT INTO [dbo].[Independents] ([Id], [Value], [Definition]) VALUES (2, N'X2', N'NIPR(X2)')
SET IDENTITY_INSERT [dbo].[Independents] OFF");

            if (db.Responses.Count() != 0)
            {
                Sql("TRUNCATE TABLE Responses");
            }
            Sql(@"
SET IDENTITY_INSERT [dbo].[Responses] ON
INSERT INTO [dbo].[Responses] ([Id], [Value], [Definition]) VALUES (1, N'Y1', N'TEMP(Y1)')
INSERT INTO [dbo].[Responses] ([Id], [Value], [Definition]) VALUES (2, N'Y2', N'PRES(Y2)')
INSERT INTO [dbo].[Responses] ([Id], [Value], [Definition]) VALUES (3, N'Y3', N'CONC(Y3)')
SET IDENTITY_INSERT [dbo].[Responses] OFF
");
            if (db.MathFunction.Count() != 0)
            {
                Sql("TRUNCATE TABLE MathFunctions");
            }
            Sql(@"
SET IDENTITY_INSERT [dbo].[MathFunctions] ON
INSERT INTO [dbo].[MathFunctions] ([Id], [Value]) VALUES (1, N'ABS')
INSERT INTO [dbo].[MathFunctions] ([Id], [Value]) VALUES (2, N'SIN')
INSERT INTO [dbo].[MathFunctions] ([Id], [Value]) VALUES (3, N'COS')
SET IDENTITY_INSERT [dbo].[MathFunctions] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
