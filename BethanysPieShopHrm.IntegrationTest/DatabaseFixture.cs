using BethanysPieShopHRM.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShopHrm.IntegrationTest
{
	public class DatabaseFixture : IDisposable
	{
		AppDbContext _context;
		private IConfiguration _config;
		private readonly ServiceProvider _serviceProvider;
		public IEmployeeRepository EmployeeRepository => _serviceProvider.GetRequiredService<IEmployeeRepository>();
		public IJobCategoryRepository JobCategoryRepository => _serviceProvider.GetRequiredService<IJobCategoryRepository>();
		public ICountryRepository CountryRepository => _serviceProvider.GetRequiredService<ICountryRepository>();
		public IBenefitRepository BenefitRepository => _serviceProvider.GetRequiredService<IBenefitRepository>();

		
		public DatabaseFixture()
		{
			_config = InitConfiguration();
			var serviceColletion = new ServiceCollection()
			.AddScoped<ICountryRepository, CountryRepository>()
			.AddScoped<IJobCategoryRepository, JobCategoryRepository>()
			.AddScoped<IEmployeeRepository, EmployeeRepository>()
			.AddScoped<IBenefitRepository, BenefitRepository>()
			.AddEntityFrameworkSqlServer()
			.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer(
					GetConnectionString(_config["Database:UseLocalDatabase"] == "true"))
					.UseInternalServiceProvider(_serviceProvider);
			});

			_serviceProvider = serviceColletion.BuildServiceProvider();
			
			_context = _serviceProvider.GetRequiredService<AppDbContext>();
			_context.Database.EnsureCreated();
			
		}

		private string GetConnectionString(bool useLocalDatabase) 
		{
		
			if (useLocalDatabase)
			{
				return  "Server=(localdb)\\mssqllocaldb;Database=BethanysPieShopHRMTest;Trusted_Connection=True;MultipleActiveResultSets=true;";
			}
			else
			{

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
				string serverName = _config["Database:ServerName"] + "," + _config["Database:Port"]; ;
				string databaseName = _config["Database:DatabaseName"];
				string userName = _config["Database:UserName"];
				string password = _config["Database:Password"];
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
			   return "Server=" + serverName + ";Database=" + databaseName + ";User Id=" + userName + ";Password=" + password;
			}

		}

		private static IConfiguration InitConfiguration()
		{
			return new ConfigurationBuilder()
							.AddJsonFile("appsettings.test.json")
						   .AddEnvironmentVariables()
						   .Build();
		}


		public void Dispose()
		{
			_context.Database.EnsureDeleted();
		}
	}
}
