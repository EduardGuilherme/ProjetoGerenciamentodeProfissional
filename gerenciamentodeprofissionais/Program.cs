using gerenciamentodeprofissionais.Data;
using gerenciamentodeprofissionais.Repository.Interfaces;
using gerenciamentodeprofissionais.Repository;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace gerenciamentodeprofissionais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            Batteries.Init();
            builder.Services.AddDbContext<ProfiDbContext>(options =>
               options.UseSqlite(builder.Configuration.GetConnectionString("Connection")));

            builder.Services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}