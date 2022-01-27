using Clase7.Debugging;

namespace Clase7
{
    public class Clase7Consts
    {
        public const string LocalizationSourceName = "Clase7";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4bb99dc923864888a16eae008d866e84";
    }
}
