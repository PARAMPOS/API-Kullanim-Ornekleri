using service_param;
using TP_KS;
using TurkPosWSTEST;
using WebMvc.Repository;
using WebMvc.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSession();
builder.Services.AddScoped<Iservice_paramAsyncRepository>(provider => new service_paramAsyncRepository(new service_paramSoapClient(service_paramSoapClient.EndpointConfiguration.service_paramSoap12)));
builder.Services.AddScoped<ITP_KSAsyncRepository>(provider => new TP_KSAsyncRepository(new TP_KSSoapClient(TP_KSSoapClient.EndpointConfiguration.TP_KSSoap12)));
builder.Services.AddScoped<ITurkPosWSTESTAsyncRepository>(provider => new TurkPosWSTESTAsyncRepository(new TurkPosWSTESTSoapClient(TurkPosWSTESTSoapClient.EndpointConfiguration.TurkPos_x0020_WS_x0020_TESTSoap12)));
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();