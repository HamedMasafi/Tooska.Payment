namespace Tooska;

public class Options
{
    public class Payment
    {
        public class Global
        {
            public static string CallbackUrl { get; set; } = "";
            public static string DashboardUrl { get; set; }
        }

        public class Behpardakht
        {
            public static long terminalId;
            public static string userName;
            public static string userPassword;
        }
    }
}