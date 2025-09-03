using MotivationalAPI.TestDB;
using MotivationalAPI.UserServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddScoped<IDatabase, TestsDb>(); // asking for IDatabase - giving TestsDb.
builder.Services.AddScoped<UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	//install dotnet sdk.
	app.UseSwagger();
	app.UseSwaggerUI();

}

app.UseHttpsRedirection();

app.MapGet("/getUsers", (UserService userService) =>
	{
		//new UserService(new TestsDb()).GetAllUsers() = _userService.GetAllUsers()
		return userService.GetAllUsers();
	})
	.WithName("GetAllUsers");

app.Run();

