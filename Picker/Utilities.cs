namespace Picker
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;

    public static class Utilities
    {
        public static TValue GetAttributeValue<TAttribute, TValue>(this Type type,
            Func<TAttribute, TValue> valueSelector)
            where TAttribute : Attribute
        {
            var customAttributes = type.GetCustomAttributes(typeof(TAttribute), true);

            if (customAttributes.FirstOrDefault() is TAttribute att)
                return valueSelector(att);

            return default;
        }

        public static string GetCopyright()
            => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location)
                .LegalCopyright;

        public static string GetDisplayName(this Type type)
            => type.GetAttributeValue<DisplayNameAttribute, string>(attribute
                => attribute.DisplayName);

        public static int GetPumpRate(string memoryType)
            => memoryType != null
                ? memoryType.ToUpper() switch
                {
                    "SDR" => 1,
                    "HBM" => 2,
                    "HBM2" => 2,
                    "DDR" => 2,
                    "DDR2" => 2,
                    "DDR3" => 2,
                    "DDR4" => 2,
                    "GDDR" => 2,
                    "GDDR2" => 2,
                    "GDDR3" => 2,
                    "GDDR4" => 2,
                    "GDDR5" => 4,
                    "GDDR5X" => 8,
                    "GDDR6" => 8,
                    _ => throw new ArgumentException(nameof(memoryType))
                }
                : throw new ArgumentNullException(nameof(memoryType));

        public static string GetVersionString()
            => Assembly.GetExecutingAssembly().GetName().Version.GetVersionString();

        public static string GetVersionString(this Version version)
        {
            if (version.Build == -1)
                return version.ToString(version.Minor == 0 ? 1 : 2);

            if (version.Revision != -1 && version.Revision != 0)
                return version.ToString(4);

            return version.Build != 0
                ? version.ToString(3)
                : version.ToString(version.Minor == 0 ? 1 : 2);
        }

        public static void ShowError(string text) => ShowError(text, MessageBoxButtons.OK);

        public static DialogResult ShowError(string text, MessageBoxButtons buttons)
            => MessageBox.Show(text, "Hata", buttons, MessageBoxIcon.Error);

        public static void ShowInformation(string text)
            => ShowInformation(text, MessageBoxButtons.OK);

        public static DialogResult ShowInformation(string text, MessageBoxButtons buttons)
            => MessageBox.Show(text, "Bilgi", buttons, MessageBoxIcon.Information);

        public static void ShowWarning(string text) => ShowWarning(text, MessageBoxButtons.OK);

        public static DialogResult ShowWarning(string text, MessageBoxButtons buttons)
            => MessageBox.Show(text, "Uyarı", buttons, MessageBoxIcon.Warning);

        public static string ToTitleCase(this string str)
            => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
    }
}

namespace System
{
    using Threading.Tasks;

    /// <summary>Provides a mechanism for releasing unmanaged resources asynchronously.</summary>
    internal interface IAsyncDisposable
    {
        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or
        ///     resetting unmanaged resources asynchronously.
        /// </summary>
        ValueTask DisposeAsync();
    }
}