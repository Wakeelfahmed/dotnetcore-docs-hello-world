var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.Use(async (context, next) =>
{
    // Set the content type of the response
    context.Response.ContentType = "text/plain";
    
    // Set the status code of the response
    context.Response.StatusCode = 200;
    
    // Write the response body
    await context.Response.WriteAsync("Hello, world!");
});
// app.UseHttpsRedirection();

app.UseStaticFiles(); // Serve static files from the wwwroot folder

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
