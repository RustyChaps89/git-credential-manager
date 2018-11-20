namespace Microsoft.Git.CredentialManager
{
    public static class Constants
    {
        public const string GcmVersion = "1.0";
        public const string PersonalAccessTokenUserName = "PersonalAccessToken";

        public static class EnvironmentVariables
        {
            public const string GcmTrace        = "GCM_TRACE";
            public const string GcmTraceSecrets = "GCM_TRACE_SECRETS";
            public const string GcmDebug        = "GCM_DEBUG";
        }

        public static readonly string GcmProgramNameFormat = "Git Credential Manager Core (version {0}, {1})";

        public static string GetProgramHeader()
        {
            string os = PlatformUtils.GetOSInfo();

            return string.Format(GcmProgramNameFormat, GcmVersion, os);
        }
    }
}
