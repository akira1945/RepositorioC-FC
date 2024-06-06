using Click.Vende;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

List<Client> clients = new List<Client>();
int currentId =1;

app.MapPost("/clients",(Client client) =>
{
    client.Id = currentId++;
    clients.Add(client);
    return Results.Created($"/clients/{client.Id}", client);
});

app.MapGet("/clients/{Id}",(int id) => 
{
    var client = clients.FirstOrDefault(c => c.Id == id);
    return client is not null ? Results.Ok(client) : Results.NotFound();
});

app.MapGet("/clients", () =>
{
    return Results.Ok(clients);
});

app.MapPut("/clients/{id}", (int id, Client updateClient) =>
{
    var index = clients.FindIndex(c => c.Id == id);
    if (index == -1) return Results.NotFound();

    var client = clients[index];
    ToClient(updateClient, client);

    return Results.Ok(client);
});

app.MapDelete("/clients/{Id}", (int id ) =>
{
    var index = clients.FindIndex(c => c.Id == id);
    if (index == -1) return Results.NotFound();

    clients.RemoveAt(index);
    return Results.Ok(clients);
});

void ToClient(Client updateClient, Client client)
{
    client.Name = updateClient.Name;
    client.CPF = updateClient.CPF;
    client.Email = updateClient.Email;
    client.andress = updateClient.andress;
}

app.Run();