using Xunit.Abstractions;

namespace BethanysPieShopHrm.IntegrationTest
{
	[Collection("Database Collection")]
	public class EmployeeRepositoryTest
	{
		private readonly DatabaseFixture _fixture;
		private readonly ITestOutputHelper _testOutputHelper;

		public EmployeeRepositoryTest(DatabaseFixture fixture, ITestOutputHelper testOutputHelper)
		{
			_fixture = fixture;
			_testOutputHelper = testOutputHelper;
		}

		[Fact]
		public void Should_create_Database()
		{
			_testOutputHelper.WriteLine("Connetion string is" + _fixture.Connectionstring);
			var employee = _fixture.EmployeeRepository.GetAllEmployees();

			Assert.Single(employee);
		}
	
	}
}
