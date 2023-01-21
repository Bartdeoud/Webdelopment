var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";  

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>  
{  
    options.AddPolicy(name: MyAllowSpecificOrigins,  
                      policy  =>  
                      {  
                          policy.WithOrigins("http://localhost:3000"); // add the allowed origins  
                      });  
}); 

void testDatabase(){

var _gebruiker =  new Gebruiker(){ Email = "SIM@email.com",Naam = "Sin", Wachtwoord = "Lokaal", UserID = 1000};
GebruikerHandler.addGebruikerAsync(_gebruiker);

List<Gebruiker> ayaya = GebruikerHandler.getListGebruiker();
foreach (var i in ayaya)
{
    Console.WriteLine(i);
}
}

testDatabase();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(MyAllowSpecificOrigins);  
app.Run();
