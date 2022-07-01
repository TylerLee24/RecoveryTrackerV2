namespace RecoveryTrackerV2
{
    public static class AppState
    {
        public static DateTime? LastOutage { get; set; } = new DateTime(2022, 06, 18);
        public static DateTime? ERPDate { get; set; }
        public static string? ERPState { get; set; } = "Running";
        public static string? ERPIssues { get; set; }
        public static DateTime? CEDate { get; set; }
        public static string? CEState { get; set; } = "Running";
        public static string? CEIssues { get; set; }
        public static DateTime? BizDate { get; set; }
        public static string? BizState { get; set; } = "Running";
        public static string? BizIssues { get; set; }
        public static DateTime? ECMDate { get; set; }
        public static string? ECMState { get; set; } = "Running";
        public static string? ECMIssues { get; set; }
        public static DateTime? SPODate { get; set; }
        public static string? SPOState { get; set; } = "Running";
        public static string? SPOIssues { get; set; }

    }
}
