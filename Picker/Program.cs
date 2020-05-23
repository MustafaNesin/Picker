namespace Picker
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Windows.Forms;
    using Forms;
    using Properties;

    internal static class Program
    {
        /// <summary>
        ///     Uygulama için ana giriş noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            #region Language Check
            /*
             * Uygulamada kullanılmak üzere Türkçe ve İngilizce olmak üzere iki dil seçeneği var.
             * Kullanıcının seçtiği ve uygulamada kullanılan dil ayarlar dosyasında saklanır.
             *
             * [if]
             * Kullanıcı uygulamayı ilk çalıştırdığında ayarlar dosyası varsayılan değerlere sahip
             * olacağı için uygulamanın dil ayarı (CultureInfo) da varsayılan değere
             * (InvariantCulture) sahip olacaktır. Bu durumda uygulamanın dil ayarı Windows'un
             * çalıştırıldığı dil yapılır ve uygulamanın ayarlarına kaydedilir.
             *
             * [else]
             * Bir sonraki çalıştırmalarda da uygulamanın dili ayarlara kaydedilmiş dil yapılır.
             */
            {
                if (Settings.Default.CultureInfo.Equals(CultureInfo.InvariantCulture))
                {
                    Settings.Default.CultureInfo = Thread.CurrentThread.CurrentUICulture;
                    Settings.Default.Save();
                }
                else
                    Thread.CurrentThread.CurrentUICulture = Settings.Default.CultureInfo;
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}