using System.Text;

using ARS.Api.Middlewares;
using ARS.Api.ServiceExtensions;
using ARS.Common.Configurations;
using ARS.Common.Entities;
using ARS.Persistance.Context;

using ARS.Persistance.Seed;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("DefaultConnection")));

var jwtConfig = builder.Configuration.GetSection("Jwt");
builder.Services.Configure<JwtTokenConfigurationModel>(jwtConfig);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "React",
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                             .AllowAnyHeader()
                             .AllowAnyMethod();
                      });

});

builder.Services.AddIdentityCore<User>(options =>
{
    options.User.RequireUniqueEmail = true;

    options.Lockout.AllowedForNewUsers = true;
    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);

})
                .AddRoles<Role>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(options =>
                 {
                     options.TokenValidationParameters = new TokenValidationParameters
                     {
                         ValidateIssuer = true,
                         ValidateAudience = true,
                         ValidateLifetime = true,
                         ValidateIssuerSigningKey = true,
                         ValidIssuer = builder.Configuration["Jwt:Issuer"],
                         ValidAudience = builder.Configuration["Jwt:Audience"],
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                     };
                 });

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
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new string[] {}
        }
    });

});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var DbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        DbContext.Database.Migrate();
        await DbInitializer.SeedInitialData(DbContext, scope);
    }
    catch (Exception)
    {
        throw;
    }

}


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

app.UseCors("React");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
