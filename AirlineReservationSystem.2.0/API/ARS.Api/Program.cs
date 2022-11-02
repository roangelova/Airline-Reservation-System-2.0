using ARS.Api.Middlewares;
using ARS.Api.ServiceExtensions;
using ARS.Common.Configurations;
using ARS.Common.Entities;
using ARS.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("DefaultConnection")));

var jwtConfig = builder.Configuration.GetSection("Jwt");
builder.Services.Configure<JwtTokenConfigurationModel>(jwtConfig);



builder.Services.AddIdentityCore<User>(options =>
{
    options.User.RequireUniqueEmail = true;
})
                .AddRoles<Role>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddAuthentication();
builder.Services.AddAuthorization();


builder.Services.AddApplicationServices();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("ARS", new OpenApiInfo
    {
        Title = "ARS",
        Version = "v2"
    });
});

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/ARS/swagger.json", "ARS");
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
