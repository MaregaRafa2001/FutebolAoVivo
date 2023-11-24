using System.Text.Json.Serialization;

const string bearerToken = "Bearer test_04753ef0590ab043e049f2edab9bfa";
var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddHttpClient();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000") // Replace with your React app's URL
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Use CORS middleware
app.UseCors();

app.MapGet("/api/campeonatos", async (IHttpClientFactory httpClientFactory) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}", async (IHttpClientFactory httpClientFactory, int campeonato_id) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}/tabela", async (IHttpClientFactory httpClientFactory, int campeonato_id) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}/tabela");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}/artilharia", async (IHttpClientFactory httpClientFactory, int campeonato_id) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}/artilharia");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}/fases", async (IHttpClientFactory httpClientFactory, int campeonato_id) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}/fases");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}/fases/{fase_id}", async (IHttpClientFactory httpClientFactory, int campeonato_id, int fase_id) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}/fases/{fase_id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}/rodadas", async (IHttpClientFactory httpClientFactory, int campeonato_id) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}/rodadas");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}/rodadas/{rodada}", async (IHttpClientFactory httpClientFactory, int campeonato_id, int rodada) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}/rodadas/{rodada}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/campeonatos/{campeonato_id}/partidas", async (IHttpClientFactory httpClientFactory, int campeonato_id) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"campeonatos/{campeonato_id}/partidas");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content, statusCode: 200);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/ao-vivo", async (IHttpClientFactory httpClientFactory) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"ao-vivo");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/times", async (IHttpClientFactory httpClientFactory) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"times");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.MapGet("/api/time/{id}", async (string id, IHttpClientFactory httpClientFactory) =>
{
    try
    {
        var httpClient = httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

        var response = await httpClient.GetAsync($"times/{id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        return Results.Json(content);
    }
    catch (Exception ex)
    {
        return Results.StatusCode(500);
    }
});

app.Run();