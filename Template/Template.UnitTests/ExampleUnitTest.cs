using AutoFixture.Xunit2;
using Moq;
using Xunit;
using Youtube_Playlist_Manager;

namespace Template.UnitTests
{
    public class ExampleUnitTest
    {
        //delete this function(its from template)
        //[Theory]
        //[AutoDomainData]        //doesn't put any values into variables a, b, c, expected
        //[InlineAutoMoqData(2, 3, 5)]
        //public void SyncerOn_GoesThrought_AllMethods(int a, int b, int c,
        //    [Frozen] Mock<IExampleSumTool> sumTool, [Frozen] ExampleClass sut)
        //{
        //    //example of how to use services or config (usually for integration tests)
        //    //var services = ServiceConfigurator.ConfigureServices(
        //    //    ServiceConfigurator.SetupConfiguration());
        //    //var serviceProvider = services.BuildServiceProvider();
        //    //var config = serviceProvider.GetService<IOptions<AppSettingsOptions>>()?.Value;       //delete this line (its from template)

        //    sumTool
        //        .Setup(s => s.Sum(It.IsAny<int>(), It.IsAny<int>()))
        //        .Returns(c);
        //    var result = sut.UseSumTool(a, b);

        //    Assert.Equal(5, result);
        //}
    }
}
