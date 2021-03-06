﻿using GitAutomation.Processes;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace GitAutomation.Repository
{
    public interface IRepositoryAction
    {
        /// <summary>
        /// Type of the action for persistence and translation
        /// </summary>
        string ActionType { get; }

        /// <summary>
        /// Parameters that can be used for persistence and translation to indicate the exact action being performed
        /// </summary>
        ImmutableDictionary<string, string> Parameters { get; }

        /// <summary>
        /// Gets the output for later execution
        /// </summary>
        IObservable<OutputMessage> DeferredOutput { get; }

        /// <summary>
        /// Executes the action
        /// </summary>
        /// <param name="serviceProvider">The services to use to perform the action</param>
        /// <returns>Output of the action</returns>
        IObservable<OutputMessage> PerformAction(IServiceProvider serviceProvider);
    }
}
