using FluentMigrator.Runner;
using HomeWork.DAL;
using HomeWork.DAL.Rapositories;
using HomeWork.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
//using System.Data.SQLite;

namespace HomeWork
{
    public class Startup : DbContext
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HomeWork", Version = "v1" });
            });

            //регистрация сервиса dataContext
            //services.AddDbContext<DataContext>(options => 
            //{
            //    //использование postgres (UseNpgsql)
            //    //строку коннекта передаем через конфигурацию (строка прописанна в appsettings.json)
            //    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
            //        assembly =>
            //            assembly.MigrationsAssembly("HomeWork.Migrations"));    //путь сохранения миграций (лямбда для сохранения новым проектом)
            //});

            //sqlite
            //ConfigureServiceConnection(services);   //подключаение бд и миграции

            services.AddSingleton<IEmployeeRepository<Employee>, EmployeeRepository>();
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=CompanyDB;Username=Manager;Password=123");
        }

        //sqlite
        //private void ConfigureServiceConnection(IServiceCollection services)
        //{
        //    const string connectionString = "Data Source=Company.db;Version=3;Pooling=true;Max Pool Size=100;";
        //    var connection = new SQLiteConnection(connectionString);
        //    connection.Open();

        //    services.AddFluentMigratorCore().ConfigureRunner(builder => builder
        //        //добавляем поддержку SQLite
        //        .AddSQLite()
        //        //устанавливаем сроку подключения
        //        .WithGlobalConnectionString(connectionString)
        //        //подсказываем где искать классы с миграциями
        //        .ScanIn(typeof(Startup).Assembly).For.Migrations())
        //        .AddLogging(lb => lb.AddFluentMigratorConsole());
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //, IMigrationRunner migrationRunner
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomeWork v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //sqlite
            ////запуск миграции
            //migrationRunner.MigrateUp(1);
        }
    }
}
