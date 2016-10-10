﻿using Ignition.Core.Mvc;

namespace Ignition.Core.Factories
{
	public interface IAgentFactory
	{
		TViewAgent CreateAgent<TViewAgent, TViewModel>(AgentContext agentContext)
			where TViewAgent : Agent<TViewModel>
			where TViewModel : BaseViewModel, new();
	}
}
