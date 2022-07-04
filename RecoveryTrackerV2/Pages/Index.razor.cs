using Microsoft.AspNetCore.Components;

namespace RecoveryTrackerV2.Pages
{
    public partial class Index
    {
        [Inject] AppState appState { get; set; }

        public DateTime dateToday = DateTime.Today;
        public DateTime? dateSinceMajorDowntime;
        public double daysSinceLastMajorOutage = 0;
        public double hoursSinceLastMajorOutage = 0;
        public double minutesSinceLastMajorOutage = 0;
        public double secondsSinceLastMajorOutage = 0;
        public bool anyIssues = false;
        private Timer? timer;
        public string timeMessage;

        public TimeSpan? span;

        protected override async Task OnInitializedAsync()
        {
            if (!String.IsNullOrEmpty(appState.ERPIssues) || !String.IsNullOrEmpty(appState.CEIssues) || !String.IsNullOrEmpty(appState.BizIssues) || !String.IsNullOrEmpty(appState.ECMIssues) || !String.IsNullOrEmpty(appState.SPOIssues))
            {
                anyIssues = true;
            }

            dateSinceMajorDowntime = appState.LastOutage;

            timer = new Timer((_) =>
            {
                span = (DateTime.Now - appState.LastOutage);
                timeMessage = String.Format("{0} days, {1} hours, {2} minutes, {3} seconds",
                        span.Value.Days, span.Value.Hours, span.Value.Minutes, span.Value.Seconds);
                StateHasChanged();
            }, new AutoResetEvent(true), 1000, 1000);
        }
    }
}