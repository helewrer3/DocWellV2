using DocWellV2.Components;
using DocWellV2.Data;
using DocWellV2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default") ??
                       throw new NullReferenceException("Default connection string Not Found!");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddTransient<PatientService>();
builder.Services.AddTransient<VisitService>();
builder.Services.AddDbContextFactory<AppDbContext>((DbContextOptionsBuilder optionsBuilder) => 
    optionsBuilder.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();