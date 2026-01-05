using Microsoft.EntityFrameworkCore;
using Visit.API.Hubs;
// using Visit.DAL; // اگر Migration مشکل داره، فعلاً کامنت باشه

var builder = WebApplication.CreateBuilder(args);

// ---------------------------
// Services
// ---------------------------

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SignalR
builder.Services.AddSignalR();

// DbContext
// builder.Services.AddDbContext<VisitDbContext>(); // فقط وقتی SQL آماده شد آنکامنت کن

var app = builder.Build();

// ---------------------------
// Migration / Database
// ---------------------------
// فقط وقتی SQL آماده شد و AppPool دسترسی داره آنکامنت کن
/*
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<VisitDbContext>();
    db.Database.Migrate();
}
*/

// ---------------------------
// SignalR Hub
// ---------------------------
app.MapHub<PresenceHub>("/PresenceHub");

// ---------------------------
// Swagger (همیشه فعال روی IIS)
// ---------------------------
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Visit API V1");
});

// ---------------------------
// HTTPS (فعلاً کامنت)
// ---------------------------
// app.UseHttpsRedirection();

// Authorization
app.UseAuthorization();

// Controllers
app.MapControllers();

// Route ساده برای تست IIS
app.MapGet("/", () => "API is running!");

// ---------------------------
// Run
// ---------------------------
app.Run();