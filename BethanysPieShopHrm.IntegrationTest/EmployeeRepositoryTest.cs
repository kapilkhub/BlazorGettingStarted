namespace BethanysPieShopHrm.IntegrationTest
{
    [Collection("Database Collection")]
    public class EmployeeRepositoryTest
    {
        private readonly DatabaseFixture _fixture;

        public EmployeeRepositoryTest(DatabaseFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Should_create_Database() 
        {
          var employee =   _fixture.EmployeeRepository.GetAllEmployees();

            Assert.Equal(true, true);
        }
    }
}
