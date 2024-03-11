using Box.FKs.Debugging;

namespace Box.FKs
{
    public class FKsConsts
    {
        public const string LocalizationSourceName = "FKs";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5d2e655202784102b43f2f84daa39f08";
    }
}
