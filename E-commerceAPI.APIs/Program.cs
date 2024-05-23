using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using E_CommerceProject.DAL;
using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.Data.Context;
using E_CommerceProject.BL;
using Microsoft.AspNetCore.Identity;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();
builder.Services.AddBLServices();
builder.Services.AddDALServices(builder.Configuration);
#endregion

#region Identity
builder.Services.AddIdentityCore<User>(options =>
{
    options.User.RequireUniqueEmail = true;

    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
})
    .AddEntityFrameworkStores<ECommerceContext>();
#endregion

#region Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "MyDefault";
    options.DefaultChallengeScheme = "MyDefault";
})
    .AddJwtBearer("MyDefault", options =>
    {
        var secretKey = builder.Configuration.GetValue<string>(Constants.AppSettings.SecretKey)!;
        var keyInBytes = Encoding.ASCII.GetBytes(secretKey);
        var key = new SymmetricSecurityKey(keyInBytes);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = key,
        };
    });
#endregion

#region Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminsOnly", policy => policy.RequireClaim("role", "admin"));
});
#endregion

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var assetsDirectoryPath = Path.Combine(builder.Environment.ContentRootPath, "assets");
Directory.CreateDirectory(assetsDirectoryPath);
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(assetsDirectoryPath),
    RequestPath = "/assets"
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

