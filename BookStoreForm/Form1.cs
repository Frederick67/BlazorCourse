using RazorLibrary;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using BookStoreApp.Blazor.Server.UI.Services.Authentication;
using BookStoreApp.Blazor.Server.UI.Services.Base;
using BookStoreApp.Blazor.Server.UI.Services.Authors;
using BookStoreApp.API.Providers;
using BookStoreApp.Blazor.Server.UI.Services.Books;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using BookStoreApp.Blazor.Server.UI.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.Circuits;

namespace BookStoreForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddWindowsFormsBlazorWebView();
            //serviceCollection.AddBlazorWebView();
            serviceCollection.AddServerSideBlazor();
            serviceCollection.AddBlazoredLocalStorage();
            serviceCollection.AddAuthenticationCore();
            serviceCollection.AddAutoMapper(typeof(MapperConfig));
            serviceCollection.AddHttpClient<IClient, Client>(cl => cl.BaseAddress = new Uri("https://localhost:7236"));
            serviceCollection.AddScoped<IAuthenticationService, AuthenticationService>();
            serviceCollection.AddScoped<IAuthorService, AuthorService>();
            serviceCollection.AddScoped<IBookService, BookService>();
            serviceCollection.AddScoped<ApiAuthenticantionStateProvider>();
            serviceCollection.AddScoped<AuthenticationStateProvider>(p => p.GetRequiredService<ApiAuthenticantionStateProvider>());

            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
        }
    }
}
