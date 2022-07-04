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
    public partial class SettingsSPO
    {
        [Inject] AppState appState { get; set; }
        protected override void OnInitialized()
        {
            CheckState();
        }
        public void ResetDate()
        {
            appState.SPODate = null;
        }
        public void ResetIssue()
        {
            appState.SPOIssues = null;
        }
        public void CheckState()
        {
            if (appState.SPOState == "Running")
            {
                ResetDate();
                ResetIssue();
            }
        }
    }
}
