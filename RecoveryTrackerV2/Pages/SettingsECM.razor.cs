using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using RecoveryTrackerV2;
using RecoveryTrackerV2.Shared;
using MudBlazor;

namespace RecoveryTrackerV2.Pages
{
    public partial class SettingsECM
    {
        protected override void OnInitialized()
        {
            CheckState();
        }
        public void ResetDate()
        {
            AppState.ECMDate = null;
        }
        public void ResetIssue()
        {
            AppState.ECMIssues = null;
        }
        public void CheckState()
        {
            if (AppState.ECMState == "Running")
            {
                ResetDate();
                ResetIssue();
            }
        }
    }
}
