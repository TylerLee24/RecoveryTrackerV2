using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace RecoveryTrackerV2.Pages
{
    public partial class SettingsBiz
    {
        [Inject] AppState appState { get; set; }

        private string _bizState;
        public string bizState
        {
            get { return _bizState; }
            set
            {
                _bizState = value;
                appState.BizState = value;
                CheckState();
            }
        }

        protected override void OnInitialized()
        {
            bizState = appState.BizState;
        }
        public void ResetDate()
        {
            appState.BizDate = null;
        }
        public void ResetIssue()
        {
            appState.BizIssues = null;
        }
        public async Task CheckState()
        {
            await Task.Delay(500);
            if (appState.BizState == "Running")
            {
                ResetDate();
                ResetIssue();
            }
        }
    }
}
