using FluentMigrator.Runner;
using HomeWork.DAL.Rapositories;
using HomeWork.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HomeWork
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HomeWork", Version = "v1" });
            });

            services.AddSingleton<IEmployeeRepository<Employee>, EmployeeRepository>();
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
        }

        private void ConfigureServiceConnection(IServiceCollection services)
        {
            const string connectionString = "Data Source=Company.db;Version=3;Pooling=true;Max Pool Size=100;";
            var connection = new SqliteConnection(connectionString);
            connection.Open();

            services.AddFluentMigratorCore().ConfigureRunner(builder => builder
                .AddSQLite()
                .WithGlobalConnectionString(connectionString)
                .ScanIn(typeof(Startup).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
        }
    }
}
