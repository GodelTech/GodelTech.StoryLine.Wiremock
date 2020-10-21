using GodelTech.StoryLine.Wiremock.Services;
using GodelTech.StoryLine.Wiremock.Services.Contracts;

namespace GodelTech.StoryLine.Wiremock.Builders
{
    public interface IApiStubState
    {
        Request RequestState { get; }
        Response ResponseState { get; }
        ITimes RequestCount { get; set; }
    }
}