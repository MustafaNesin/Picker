namespace Picker
{
    using System;
    using System.Data.Entity;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Models;
    using Presenters;

    internal partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        /// <summary>
        ///     Uygulama için ana giriş noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!CheckDatabase())
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static bool CheckDatabase()
        {
            try
            {
                using var context = new ComputerDatabaseContext();

                if (!context.Database.Exists())
                    context.Database.Create();
                else if (!context.Database.CompatibleWithModel(false))
                {
                    var result = Utilities.ShowError(
                        "Mevcut veri tabanı eski ve programda kullanılan modelle uyuşmuyor.\r\n" +
                        "Yeni bir veri tabanı oluşturmak için eski veri tabanı silinsin mi?",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                        return false;

                    context.Database.Delete();
                    context.Database.Create();
                }

                return true;
            }
            catch (SqlException e) when (e.Number == 3702)
            {
                Utilities.ShowError("Veri tabanı şu anda kullanıldığı için silinemiyor. " +
                                    "Diğer bağlantıları kapattıktan sonra veri tabanını silin.");

                return false;
            }
        }

        private async void contextButtons_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            // ReSharper disable once PossibleNullReferenceException
            if (!(button.Tag is Type type))
                return;

            if (type != typeof(Build))
                return;

            await using var presenter = new BuildListPresenter();
            presenter.ShowView();
        }

        public async Task InitializeAsync()
        {
            copyrightLabel.Text = Utilities.GetCopyright();
            versionLabel.Text = "v" + Utilities.GetVersionString();

            using var context = new ComputerDatabaseContext();
            var motherboardsCount = await context.Motherboards.CountAsync();
            var processorsCount = await context.Processors.CountAsync();
            var graphicsCount = await context.Graphics.CountAsync();
            var memoriesCount = await context.Memories.CountAsync();

            SetCountToolTip(buildsButton, await context.Builds.CountAsync());
            SetCountToolTip(motherboardsButton, motherboardsCount);
            SetCountToolTip(processorsButton, processorsCount);
            SetCountToolTip(graphicsButton, graphicsCount);
            SetCountToolTip(memoriesButton, memoriesCount);
            SetCountToolTip(brandsButton, await context.Brands.CountAsync());
            SetCountToolTip(chipsetsButton, await context.Chipsets.CountAsync());
            SetCountToolTip(socketsButton, await context.Sockets.CountAsync());

            SetCountToolTip(productsGroupBox,
                motherboardsCount + processorsCount + graphicsCount + memoriesCount);
        }

        private async void MainForm_Load(object sender, EventArgs e) => await InitializeAsync();

        public void SetCountToolTip(Control control, int entityCount)
        {
            if (!(control.Tag is Type type))
                return;

            var modelName = type.GetDisplayName();
            var caption = entityCount == 0
                ? $"Veri tabanında {modelName} yok."
                : $"Veri tabanında {entityCount} adet {modelName} bulunuyor.";

            countToolTip.SetToolTip(control, caption);
        }
    }
}