﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.VisualStudio.LanguageServices.ProjectSystem;

namespace Microsoft.VisualStudio.ProjectSystem.LanguageServices.Handlers
{
    internal abstract class AbstractLanguageServiceRuleHandler : ILanguageServiceRuleHandler
    {
        public abstract RuleHandlerType HandlerType { get; }

        public abstract string RuleName { get; }

        public virtual bool ReceiveUpdatesWithEmptyProjectChange => false;

        public virtual Task HandleAsync(IProjectVersionedValue<IProjectSubscriptionUpdate> e, IProjectChangeDescription projectChange, IWorkspaceProjectContext context, bool isActiveContext)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnContextReleasedAsync(IWorkspaceProjectContext context)
        {
            return Task.CompletedTask;
        }
    }
}
