using System.Net;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using ClinicAPI.CustomActionFilters;
using ClinicAPI.Data;
using ClinicAPI.Models.Domain; // <-- Make sure this is included for UserModel
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ClinicAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerDocumentation();
            builder.Services.AddAutoMapper(typeof(Mapper));
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("con")));


            builder.Services.AddIdentity<UserApplication, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 1;
                options.SignIn.RequireConfirmedEmail = true; // Optional for email confirmation
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
            });



            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
      .AddJwtBearer(options =>
      {
          options.TokenValidationParameters = new TokenValidationParameters
          {
              ValidateLifetime = true,
              ValidateIssuer = true,
              ValidateAudience = true,
              ValidateIssuerSigningKey = true,
              ValidIssuer = builder.Configuration["Jwt:Issuer"],
              ValidAudience = builder.Configuration["Jwt:Audience"],
              IssuerSigningKey = new SymmetricSecurityKey(
                  Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
              RoleClaimType = ClaimTypes.Role
          };

          options.Events = new JwtBearerEvents
          {
              OnChallenge = context =>
              {
                  // Skip the default logic.
                  context.HandleResponse();
                  context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                  context.Response.ContentType = "application/json";
                  return context.Response.WriteAsync("{\"error\": \"Unauthorized\"}");
              },
              OnForbidden = context =>
              {
                  context.Response.StatusCode = StatusCodes.Status401Unauthorized; // or 403, up to you
                  context.Response.ContentType = "application/json";
                  return context.Response.WriteAsync("{\"error\": \"Forbidden - you do not have access\"}");
              }
          };
      });



            builder.Services.AddScoped<ITokenRepository, TokenRepository>();
            builder.Services.AddScoped<IDoctorRepository, SqlDoctorRepository>();
            builder.Services.AddScoped<IAppointmentRepository, SqlAppointmentRepository>();

            var app = builder.Build();
            app.UseCors("AllowAllOrigins");
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
