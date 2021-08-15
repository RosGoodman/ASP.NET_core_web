using FluentMigrator;

namespace HomeWork.DAL.Migrator
{
    [Migration(1)]
    public class FirstMigration : Migration
    {
        public override void Down()
        {
            Delete.Table("person");

            Delete.Table("posts");
            Delete.Table("customers");
            Delete.Table("contracts");
            Delete.Table("invoices");
            Delete.Table("taskRegistrator");
            Delete.Table("tasks");
            Delete.Table("employees");
            Delete.Table("requisites");
            Delete.Table("status");
            Delete.Table("contractStatus");
        }

        public override void Up()
        {
            Create.Table("person")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("firstName").AsString()
                .WithColumn("secondName").AsString()
                .WithColumn("gender").AsBoolean()
                .WithColumn("birthday").AsDate();
            Create.Table("posts")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("description").AsString()
                .WithColumn("rate").AsDecimal();
            Create.Table("customers")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("idPerson").AsInt64()
                .WithColumn("idRequisites").AsString();
            Create.Table("contracts")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("idCustomer").AsInt64()
                .WithColumn("contractDate").AsDate()
                .WithColumn("contractText").AsString()
                .WithColumn("paymentOneTime").AsBoolean()
                .WithColumn("price").AsDecimal()
                .WithColumn("idContractStatus").AsInt32();
            //Create.Table("invoices")
            //    .WithColumn("id").AsInt64().PrimaryKey().Identity()
            //Create.Table("taskRegistrator")
            //    .WithColumn("id").AsInt64().PrimaryKey().Identity()
            //Create.Table("tasks")
            //    .WithColumn("id").AsInt32().PrimaryKey().Identity()
            //Create.Table("employees")
            //    .WithColumn("id").AsInt64().PrimaryKey().Identity()
            //Create.Table("requisites")
            //    .WithColumn("id").AsInt64().PrimaryKey().Identity()
            //Create.Table("status")
            //    .WithColumn("id").AsInt32().PrimaryKey().Identity()
            //Create.Table("contractStatus")
            //    .WithColumn("id").AsInt32().PrimaryKey().Identity()
        }
    }
}
