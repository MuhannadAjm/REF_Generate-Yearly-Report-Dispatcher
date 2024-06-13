using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace REF_GenerateYearlyReportDispatcher
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
<<<<<<< HEAD
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
=======
            _ = new System.Type[]{typeof(UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.Testing.API.ITestingService)};
>>>>>>> 5cb34c5e4b2c503c1b1d30e78841e907ecb46715
        }

        protected UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService office365 { get => serviceContainer.Resolve<UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService>() ; }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>() ; }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>() ; }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>() ; }
    }
}