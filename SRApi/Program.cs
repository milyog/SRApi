
using SRApi.Services;

namespace SRApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddHttpClient("SverigesRadioApi", client =>
            {
                client.BaseAddress = new Uri("http://api.sr.se/api/v2/");
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json") );
                //client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            builder.Services.AddScoped<SverigesRadioApiService>();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            builder.Services.AddControllers();
      
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseCors("AllowAll");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();       

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
