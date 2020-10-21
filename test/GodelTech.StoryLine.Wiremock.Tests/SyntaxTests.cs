using GodelTech.StoryLine.Wiremock.Actions;
using GodelTech.StoryLine.Wiremock.Expectations;

namespace GodelTech.StoryLine.Wiremock.Tests
{
    public class SyntaxTests
    {
        //[Fact]
        public void Test()
        {
            Config.SetBaseAddress("http://localhost:32769");

            Scenario.New()
                .When()
                    .Performs<MockHttpRequest>(x => x
                        .Request(req => req
                            .Url("/xxx")
                            .Method("GET"))
                        .Response(res => res
                            .Status(200)
                            .Body("Text")))
                .Then()
                    .Expects<HttpRequestMock>(x => x
                        .Request(req => req
                            .Url("/dragon"))
                        .Called(c => c.AtLeastOnce()))
                .Run();


            Config.ResetAll();
        }
    }
}
