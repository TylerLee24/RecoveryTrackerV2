namespace RecoveryTrackerV2.Pages
{
    public partial class Index
    {
        public DateTime dateToday = DateTime.Today;
        public DateTime dateSinceMajorDowntime = new DateTime(2022, 06, 18);
        public int daysSinceLastMajorOutage = 0;
        public bool anyIssues = false;

        protected override async Task<Task> OnInitializedAsync()
        {
            SettingsBiz settingsBiz = new SettingsBiz();
            SettingsCE settingsCE = new SettingsCE();
            SettingsECM settingsECM = new SettingsECM();
            SettingsERP settingsERP = new SettingsERP();
            SettingsSPO settingsSPO = new SettingsSPO();

            settingsBiz.CheckState();
            settingsCE.CheckState();
            settingsECM.CheckState();
            settingsERP.CheckState();
            settingsSPO.CheckState();

            if (!String.IsNullOrEmpty(AppState.ERPIssues) || !String.IsNullOrEmpty(AppState.CEIssues) || !String.IsNullOrEmpty(AppState.BizIssues) || !String.IsNullOrEmpty(AppState.ECMIssues) || !String.IsNullOrEmpty(AppState.SPOIssues))
            {
                anyIssues = true;
            }

            base.OnInitialized();
            var timer = new Timer((_) =>
            {
                InvokeAsync(async () =>
                {
                    // Add your update logic here
                    daysSinceLastMajorOutage = dateToday.Subtract((DateTime)AppState.LastOutage).Days;
                    // Update the UI
                    StateHasChanged();
                });
            }, null, 0, 1000);
            return Task.CompletedTask;
        }
    }
}