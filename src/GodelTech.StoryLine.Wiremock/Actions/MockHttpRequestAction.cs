using System;
using GodelTech.StoryLine.Contracts;
using GodelTech.StoryLine.Wiremock.Builders;
using GodelTech.StoryLine.Wiremock.Services.Contracts;

namespace GodelTech.StoryLine.Wiremock.Actions
{
    public class MockHttpRequestAction : IAction
    {
        private readonly IApiStubState _state;

        public MockHttpRequestAction(IApiStubState state)
        {
            _state = state ?? throw new ArgumentNullException(nameof(state));
        }

        public void Execute(IActor actor)
        {
            if (actor == null)
                throw new ArgumentNullException(nameof(actor));

            Config.Client.Create(new Mapping
            {
                Request = _state.RequestState,
                Response = _state.ResponseState
            });
        }
    }
}