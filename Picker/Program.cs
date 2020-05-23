namespace Picker
{
    using System;
    using System.Windows.Forms;
    using Forms;

    internal static class Program
    {
        /// <summary>
        ///     Uygulama için ana giriş noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserForm());
        }
    }
}