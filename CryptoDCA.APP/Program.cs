using CryptoDCA.DataAccess;
using CryptoDCA.DataAccess.Crypto.Retriever;
using CryptoDCA.DataAccess.Currency.Retriever;
using CryptoDCA.DataAccess.Investments.Modifier;
using CryptoDCA.DataAccess.Investments.Retriever;
using CryptoDCA.DataAccess.Period.Retriever;
using CryptoDCA.DataModel.Integrations;
using CryptoDCA.DomainLogic.Currency.Retriever;
using CryptoDCA.DomainLogic.Investments.Modifier;
using CryptoDCA.DomainLogic.Investments.Retriever;
using CryptoDCA.DomainLogic.Period.Retriever;
using CryptoDCA.DomainLogic.Services;
using CryptoDCA.Integration.Coinmarketcap;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace CryptoDCA.APP
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.
                builder.Services.AddRazorPages();
                builder.Services.AddServerSideBlazor();

            builder.Services.AddBlazorBootstrap();


            // Register the services
            builder.Services.AddScoped<ICryptoService, CryptoService>();
                builder.Services.AddScoped<ICryptoRetrieverDao, CryptoRetrieverDao>();
                builder.Services.AddScoped<ICoinMarketCapService, CoinMarketCapService>();
                builder.Services.AddScoped<IInvestmentModifierDao, InvestmentModifierDao>();
                builder.Services.AddScoped<IInvestmentModifier, InvestmentModifier>();
                builder.Services.AddScoped<IInvestmentModifierDao, InvestmentModifierDao>();
                builder.Services.AddScoped<ICurrencyRetrieverDao, CurrencyRetrieverDao>();
                builder.Services.AddScoped<ICurrencyRetriever, CurrencyRetriever>();
                builder.Services.AddScoped<IInvestmentRetriever, InvestmentRetriever>();
                builder.Services.AddScoped<IInvestmentRetrieverDao, InvestmentRetrieverDao>();
                builder.Services.AddScoped<IPeriodRetriever, PeriodRetriever>();
                builder.Services.AddScoped<IPeriodRetrieverDao, PeriodRetrieverDao>();

                // Add HttpClient for CoinMarketCapService
                builder.Services.AddHttpClient<CoinMarketCapService>();

                // Bind the CoinMarketCapSettings from appsettings.json
                builder.Services.Configure<CoinMarketCapSettingsDto>(builder.Configuration.GetSection("IntegrationsCredentials:CoinMarketCap"));


                // Register CoinMarketCapSettingsDto as an IOptions service
                builder.Services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<CoinMarketCapSettingsDto>>().Value);

                // add in-memory cache
                builder.Services.AddMemoryCache();

                // Configure the cache options
                builder.Services.AddSingleton(new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromMinutes(5), // cache will expire if not accessed in 5 minutes
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1) // total lifetime of the cache
                });

               



            // Getting the database connection string from appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

                // Make connection between API and database
                builder.Services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(connectionString));


                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }

                app.UseHttpsRedirection();

                app.UseStaticFiles();

                app.UseRouting();

                app.MapBlazorHub();
                app.MapFallbackToPage("/_Host");

                app.Run();
            }
        }
    }
