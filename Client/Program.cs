using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using Syncfusion.Blazor;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzkzNDc4QDMyMzAyZTM0MmUzMGM1ZG1WT2N6ZHBaSGNWQzhEalpKTFFqNlhkZjMxTC9ncVN2WHhLUUMwalU9;NzkzNDc5QDMyMzAyZTM0MmUzMGJnNXdhSml4dDZxSW1WU1h6OTkzc2tWSjl5UEtPcDJhYm00ZHRoVW16dzQ9");
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddScoped<GoogleMapClickEventArgs>();
builder.Services.AddScoped<GoogleMapPosition>();
await builder.Build().RunAsync();
