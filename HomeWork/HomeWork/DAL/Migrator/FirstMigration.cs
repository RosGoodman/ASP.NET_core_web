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
            //человек
            Create.Table("person")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("firstName").AsString()
                .WithColumn("secondName").AsString()
                .WithColumn("gender").AsBoolean()
                .WithColumn("birthday").AsDate();
            //должность
            Create.Table("posts")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("description").AsString()
                .WithColumn("rate").AsDecimal();
            //заказчик
            Create.Table("customers")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("idPerson").AsInt64()
                .WithColumn("idRequisites").AsString();
            //контракт
            Create.Table("contracts")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("idCustomer").AsInt64()
                .WithColumn("contractDate").AsDate()
                .WithColumn("contractText").AsString()
                .WithColumn("paymentOneTime").AsBoolean()
                .WithColumn("price").AsDecimal()
                .WithColumn("idContractStatus").AsInt32();
            //накладная
            Create.Table("invoices")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("idContract").AsInt64()
                .WithColumn("startDate").AsDate()
                .WithColumn("endDate").AsDate()
                .WithColumn("idStatus").AsBoolean();
            //регистратор задач
            Create.Table("taskRegistrator")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("idInvoice").AsInt64()
                .WithColumn("idTask").AsInt32()
                .WithColumn("idEmployee").AsInt64()
                .WithColumn("HoursCount").AsInt32()
                .WithColumn("hourlyPayment").AsBoolean()
                .WithColumn("idStatus").AsInt32();
            //задачи
            Create.Table("tasks")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("description").AsString()
                .WithColumn("priceOneTime").AsBoolean();
            //сотрудники
            Create.Table("employees")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("idPerson").AsInt64()
                .WithColumn("idPost").AsInt32();
            //реквизиты
            Create.Table("requisites")
                .WithColumn("id").AsInt64().PrimaryKey().Identity()
                .WithColumn("companyName").AsString()
                .WithColumn("fullCompanyName").AsString()
                .WithColumn("nameOfTheBank").AsString()
                .WithColumn("currentAccountNumber").AsString()
                .WithColumn("assress").AsString()
                .WithColumn("idPerson").AsInt64();
            //статус задачи / инвойса
            Create.Table("invoiceStatus")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("description").AsString();
            //статус контракта
            Create.Table("contractStatus")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("description").AsString();
        }
    }
}
