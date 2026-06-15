using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MinimolApiMacacosEBananasV1.Interfaces;
using MinimolApiMacacosEBananasV1.Repositories;
using MinimolApiMacacosEBananasV1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IMacacoRepository, MacacoRepository>();
builder.Services.AddSingleton<IMacacoService, MacacoService>();


var app = builder.Build();

app.UseSwagger();

app.MapGet("/macacos", (IMacacoService macacoService) => macacoService.ListarMacacos());

app.MapPost("macacos/transferirbananas/{idRemetente}/{idDestinatario}/{quantidade}", (int idRemetente, int idDestinatario, int quantidade, IMacacoService macacoService) => macacoService.DarBanana(idRemetente, idDestinatario, quantidade));

app.MapPost("macacos/criar/{nome}/{bananas}", (string nome, int bananas, IMacacoService macacoService) => 
    macacoService.CriarMacaco(nome, bananas));

app.MapDelete("macacos/deletar/{id}", (int id, IMacacoService macacoService) => macacoService.Excluir(id));

app.UseSwaggerUI();

app.Run();
