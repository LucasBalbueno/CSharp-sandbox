using LifeCycles.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Ciclos de vida (3 tipos)
builder.Services.AddSingleton<FirstOperation>(); // Esse id nunca vai mudar
builder.Services.AddScoped<SecondOperation>(); // Sempre o mesmo objeto dentro da mesma requisição. Esse id vai mudar toda a vez que a requisição mudar 
builder.Services.AddTransient<ThirdOperation>(); // Sempre será uma nova instância do objeto. Vai mudar sempre

var app = builder.Build();

app.MapGet("/", (FirstOperation firstOperation, SecondOperation secondOperation, ThirdOperation thirdOperation) =>
    new
    {
        Id = Guid.NewGuid(),
        FirstOperationId = firstOperation.Id,
        SecondOperation = new
        {
            Id = secondOperation.Id,
            FirstOperationId = secondOperation.FistOperationID
        },
        ThirdOperation = new
        {
            Id = thirdOperation.Id,
            FirstOperationId = thirdOperation.FirstOperationId,
            SecondOperationId = thirdOperation.SecondOperationId,
            thirdOperation = thirdOperation.SecondOperationNewInstanceId
        }
    });

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();