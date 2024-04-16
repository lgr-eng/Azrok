using System;
using System.IO;
using Server;
using Server.Accounting;
using System.Text.RegularExpressions;

//namespace Server.Commands
//{
//    public class CombatLogging
//    {
//        private static StreamWriter m_Output;
//        private static bool m_Enabled = true;

//        public static bool Enabled
//        {
//            get { return m_Enabled; }
//            set { m_Enabled = value; }
//        }

//        public static StreamWriter Output
//        {
//            get { return m_Output; }
//        }

//        public static void Initialize()
//        {
//            if (!Directory.Exists("Data/Logs"))
//                Directory.CreateDirectory("Data/Logs");

//            string directory = "Data/Logs/Combat";

//            if (!Directory.Exists(directory))
//                Directory.CreateDirectory(directory);

//            try
//            {
//                m_Output = new StreamWriter(
//                    Path.Combine(
//                        directory,
//                        String.Format("{0}.log", DateTime.Now.ToLongDateString())
//                    ),
//                    true
//                );

//                m_Output.AutoFlush = true;

//                m_Output.WriteLine("##############################");
//                m_Output.WriteLine("Log started on {0}", DateTime.Now);
//                m_Output.WriteLine();
//            }
//            catch { }
//        }

//        public static object Format(object o)
//        {
//            if (o is Mobile)
//            {
//                Mobile m = (Mobile)o;

//                if (m.Account == null)
//                    return String.Format("{0} (no account)", m);
//                else
//                    return String.Format("{0} ('{1}')", m, m.Account.Username);
//            }
//            else if (o is Item)
//            {
//                Item item = (Item)o;

//                return String.Format("0x{0:X} ({1})", item.Serial.Value, item.GetType().Name);
//            }

//            return o;
//        }

//        public static void WriteLine(Mobile from, string format, params object[] args)
//        {
//            if (!m_Enabled)
//                return;

//            WriteLine(from, String.Format(format, args));
//        }

//        public static void WriteLine(Mobile from, string text)
//        {
//            if (!m_Enabled)
//                return;

//            try
//            {
//                m_Output.WriteLine("{0} {1} {2}", DateTime.Now, from.NetState, text);

//                string path = Core.BaseDirectory;

//                Account acct = from.Account as Account;

//                string name = (acct == null ? from.Name : acct.Username);

//                AppendPath(ref path, "Data/Logs");
//                AppendPath(ref path, "Combat");
//                AppendPath(ref path, from.AccessLevel.ToString());
//                path = Path.Combine(path, String.Format("{0}.log", name));

//                using (StreamWriter sw = new StreamWriter(path, true))
//                    sw.WriteLine("{0} {1} {2}", DateTime.Now, from.NetState, text);
//            }
//            catch { }
//        }

//        private static char[] m_NotSafe = new char[]
//        {
//            '\\',
//            '/',
//            ':',
//            '*',
//            '?',
//            '"',
//            '<',
//            '>',
//            '|'
//        };

//        public static void AppendPath(ref string path, string toAppend)
//        {
//            path = Path.Combine(path, toAppend);

//            if (!Directory.Exists(path))
//                Directory.CreateDirectory(path);
//        }

//        public static string Safe(string ip)
//        {
//            if (ip == null)
//                return "null";

//            ip = ip.Trim();

//            if (ip.Length == 0)
//                return "empty";

//            bool isSafe = true;

//            for (int i = 0; isSafe && i < m_NotSafe.Length; ++i)
//                isSafe = (ip.IndexOf(m_NotSafe[i]) == -1);

//            if (isSafe)
//                return ip;

//            System.Text.StringBuilder sb = new System.Text.StringBuilder(ip);

//            for (int i = 0; i < m_NotSafe.Length; ++i)
//                sb.Replace(m_NotSafe[i], '_');

//            return sb.ToString();
//        }

//        public static void LogDamageTaken(Mobile from, int amount, Mobile source, string location, string map)
//        {
//            string characterName = ExtractName(from);
//            string sourceName = ExtractName(source);
//            string formattedLocation = FormatLocation(location);

//            // Custom WriteLine handling complex objects and formatted strings
//            WriteLine(
//                from, // Assuming the method uses this for additional context/logging details
//                "{0} {1} {2} {3} {4}",
//                characterName,
//                amount,
//                sourceName,
//                formattedLocation,
//                map
//            );
//        }

//        private static string FormatLocation(string location)
//        {
//            // Remove all characters except digits and comma
//            return Regex.Replace(location, "[^0-9,]", "");
//        }

//        // Extracts the name by trimming the first occurrence of quotes
//        private static string ExtractName(Mobile mobile)
//        {
//            string result = mobile.ToString();
//            int quotePosition = result.IndexOf('\"');
//            if (quotePosition != -1)
//            {
//                result = result.Substring(quotePosition + 1);
//                quotePosition = result.IndexOf('\"');
//                if (quotePosition != -1)
//                {
//                    result = result.Substring(0, quotePosition);
//                }
//            }
//            return result;
//        }
//    }
//}

namespace Server.Commands
{
    public static class CombatLogging
    {
        private static StreamWriter m_Output;
        private static bool m_Enabled = true;

        public static bool Enabled
        {
            get { return m_Enabled; }
            set { m_Enabled = value; }
        }

        public static void Initialize()
        {
            string baseDirectory = "Data/Logs/Combat";
            if (!Directory.Exists(baseDirectory))
                Directory.CreateDirectory(baseDirectory);

            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".csv";
            string logFilePath = Path.Combine(baseDirectory, logFileName);

            m_Output = new StreamWriter(logFilePath, true);
            m_Output.AutoFlush = true;

            // Check if the file is new and write headers
            FileInfo fileInfo = new FileInfo(logFilePath);
            if (fileInfo.Length == 0)
            {
                m_Output.WriteLine("Timestamp,IP,Account,Character,Damage,Attacker,LocationX,LocationY,LocationZ,Map,Region");
            }
        }

        public static void LogDamageTaken(Mobile from, int amount, Mobile source, string location, string map, string region)
        {
            if (!m_Enabled || m_Output == null)
                return;

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string ip = (from.NetState != null) ? from.NetState.ToString() : "Disconnected";
            string accountName = from.Account.Username;
            string username = from.Name;
            string attackerName = ExtractAttackerName(source);
            string[] coords = FormatLocation(location).Split(',');
            string formattedLocation = string.Join(",", coords); // Ensure it's CSV-compatible

            string csvLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                timestamp, EscapeCsv(ip), EscapeCsv(accountName), EscapeCsv(username), amount, EscapeCsv(attackerName),
                coords[0], coords[1], coords[2], EscapeCsv(map), EscapeCsv(region));

            m_Output.WriteLine(csvLine);
            WritePlayerSpecificLog(from, csvLine);
        }

        private static void WritePlayerSpecificLog(Mobile from, string csvLine)
        {
            if (from.Account == null)
                return; // If the account is not associated with the mobile, exit

            // Sanitize account name to remove invalid characters from the path
            string sanitizedAccountName = SanitizeFileName(from.Account.Username);

            string combatDirectory = "Data/Logs/Combat"; // Base combat directory
            string playerDirectory = Path.Combine(combatDirectory, "Player"); // Player directory under combat

            if (!Directory.Exists(playerDirectory))
                Directory.CreateDirectory(playerDirectory);

            string logFilePath = Path.Combine(playerDirectory, string.Format("{0}.csv", sanitizedAccountName));

            using (StreamWriter playerLog = new StreamWriter(logFilePath, true))
            {
                FileInfo fileInfo = new FileInfo(logFilePath);
                if (fileInfo.Length == 0)
                {
                    playerLog.WriteLine("Timestamp,IP,Account,Character,Damage,Attacker,LocationX,LocationY,LocationZ,Map,Region");
                }
                playerLog.WriteLine(csvLine);
            }
        }

        // SanitizeFileName method to remove invalid characters from the player's name
        private static string SanitizeFileName(string fileName)
        {
            string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            string sanitizedFileName = string.Join("_", fileName.Split(invalidChars.ToCharArray()));
            return sanitizedFileName;
        }

        private static string EscapeCsv(string data)
        {
            return "\"" + data.Replace("\"", "\"\"") + "\"";
        }

        private static string FormatLocation(string location)
        {
            return Regex.Replace(location, "[^0-9,]", "");
        }

        private static string ExtractAttackerName(Mobile mobile)
        {
            string result = mobile.ToString();
            int quotePosition = result.IndexOf('\"');
            if (quotePosition != -1)
            {
                result = result.Substring(quotePosition + 1);
                quotePosition = result.IndexOf('\"');
                if (quotePosition != -1)
                {
                    result = result.Substring(0, quotePosition);
                }
            }
            return result;
        }
    }
}