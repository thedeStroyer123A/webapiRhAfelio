



using Microsoft.IdentityModel.Tokens;
using ProjectRh_BLL.Interfaces;
using ProjectRh_BLL.Services;
using System.Text;
var MyAllowSpecificOrigins = "_MyAllowSubdomainPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => {
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy => policy
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => true)
            .AllowCredentials());
});

// Add services to the container.

/*builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("https://localhost:7283", "http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
            ///policy.WithOrigins("https://localhost:4200", "http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        });
});*/

//Add Controller
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmployesService,Employes_Services>();
builder.Services.AddScoped<IAffectation_MaterialService, Affectation_MaterielService>();
builder.Services.AddScoped<IAffectation_PersonnelService, Affectation_PersonnelService>();
builder.Services.AddScoped<IControlCheckService, ControlCheckService>();
builder.Services.AddScoped<ITraining_SectionService, Training_Section_Services>();
builder.Services.AddScoped<IHumanRessourceDepService,HumanRessourceDep_Services>();
builder.Services.AddScoped<IMaterialService, Material_Services>();





/*object p = builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(option =>
        {
            option.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidIssuer = JwtTokenManager.issuer,
                ValidateAudience = true,
                ValidAudience = JwtTokenManager.audience,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenManager.secret))
            };
        });*/
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
    options.AddPolicy("Auth", policy => policy.RequireAuthenticatedUser());
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();