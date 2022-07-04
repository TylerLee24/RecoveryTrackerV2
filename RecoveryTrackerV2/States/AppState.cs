namespace RecoveryTrackerV2
{
    public class AppState
    {
        public DateTime? LastOutage { get; set; } = new DateTime(2022, 06, 18);
        public DateTime? ERPDate { get; set; }
        public string? ERPState { get; set; } = "Running";
        public string? ERPIssues { get; set; }
        public DateTime? CEDate { get; set; }
        public string? CEState { get; set; } = "Running";
        public string? CEIssues { get; set; }
        public DateTime? BizDate { get; set; }
        public string? BizState { get; set; } = "Running";
        public string? BizIssues { get; set; }
        public DateTime? ECMDate { get; set; }
        public string? ECMState { get; set; } = "Running";
        public string? ECMIssues { get; set; }
        public DateTime? SPODate { get; set; }
        public string? SPOState { get; set; } = "Running";
        public string? SPOIssues { get; set; }

    }
}
