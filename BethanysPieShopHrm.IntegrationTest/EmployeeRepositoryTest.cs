using Microsoft.Extensions.Configuration;
using Xunit.Abstractions;

namespace BethanysPieShopHrm.IntegrationTest
{
	//[Collection("Database Collection")]
	public class EmployeeRepositoryTest
	{
		//private readonly DatabaseFixture _fixture;
		private readonly IConfiguration _config;
		private readonly ITestOutputHelper outputHelper;

		public EmployeeRepositoryTest(ITestOutputHelper outputHelper)
		{
			//_fixture = fixture;
			_config = InitConfiguration();
			this.outputHelper = outputHelper;
		}

		[Fact]
		public void Should_create_Database()
		{
			outputHelper.WriteLine("connection string is =================" + GetConnectionString(_config["Database:UseLocalDatabase"] == "true"));
			Assert.True(true);
		}
		private static IConfiguration InitConfiguration()
		{
			return new ConfigurationBuilder()
							.AddJsonFile("appsettings.test.json")
						   .AddEnvironmentVariables()
						   .Build();
		}
		private string GetConnectionString(bool useLocalDatabase)
		{

			if (useLocalDatabase)
			{
				return "Server=(localdb)\\mssqllocaldb;Database=BethanysPieShopHRMTest;Trusted_Connection=True;MultipleActiveResultSets=true;";
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
	}
}
