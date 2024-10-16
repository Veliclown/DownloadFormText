var builder = WebApplication.CreateBuilder(args);

// ���������� �������� � ���������.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ��������� ��������� HTTP-��������.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "file",
    pattern: "{controller=File}/{action=DownloadFile}/{id?}");



app.MapControllerRoute(
    name: "home",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
