namespace Picker
{
    using System;
    using System.Data.Entity;
    using System.Diagnostics;
    using System.Globalization;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal partial class MainForm : Form
    {
        private const string ToolTipCaption = "Veri tabanında {0} adet {1} bulunuyor.";
        private const string ToolTipNoEntityCaption = "Veri tabanında {0} yok.";

        public MainForm() => InitializeComponent();

        /// <summary>
        ///     Uygulama için ana giriş noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            if (!DatabaseUtilities.CheckDatabase())
                return;

            DatabaseUtilities.CheckAssets();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private async void brandsButton_Click(object sender, EventArgs e)
        {
            Hide();

            await using (var presenter = new BrandListPresenter(true))
                presenter.ShowView();

            await SetCountToolTips();
            Show();
        }

        private async void buildsButton_Click(object sender, EventArgs e)
        {
            Hide();

            /*await using (var presenter = new BuildListPresenter(true))
                presenter.ShowView();*/

            await SetCountToolTips();
            Show();
        }

        private async void chipsetsButton_Click(object sender, EventArgs e)
        {
            Hide();

            await using (var presenter = new ChipsetListPresenter(true))
                presenter.ShowView();

            await SetCountToolTips();
            Show();
        }

        private void copyrightLabel_Click(object sender, EventArgs e)
            => Process.Start("https://github.com/MustafaNesin/Picker");

        private void exitButton_Click(object sender, EventArgs e) => Close();

        private async void graphicsCardButton_Click(object sender, EventArgs e)
        {
            Hide();

            /*await using (var presenter = new GraphicsCardListPresenter(true))
                presenter.ShowView();*/

            await SetCountToolTips();
            Show();
        }

        public async Task InitializeAsync()
        {
            copyrightLabel.Text = Utilities.GetCopyright();
            versionLabel.Text = "v" + Utilities.GetVersionString();

            await SetCountToolTips();
        }

        private async void MainForm_Load(object sender, EventArgs e) => await InitializeAsync();

        private async void memoriesButton_Click(object sender, EventArgs e)
        {
            Hide();

            await using (var presenter = new MemoryListPresenter(true))
                presenter.ShowView();

            await SetCountToolTips();
            Show();
        }

        private async void motherboardsButton_Click(object sender, EventArgs e)
        {
            Hide();

            /*await using (var presenter = new MotherboardListPresenter(true))
                presenter.ShowView();*/

            await SetCountToolTips();
            Show();
        }

        private async void processorsButton_Click(object sender, EventArgs e)
        {
            Hide();

            /*await using (var presenter = new ProcessorListPresenter(true))
                presenter.ShowView();*/

            await SetCountToolTips();
            Show();
        }

        public void SetCountToolTip(Control control, string modelName, int entityCount)
            => countToolTip.SetToolTip(control,
                entityCount == 0
                    ? string.Format(ToolTipNoEntityCaption, modelName)
                    : string.Format(ToolTipCaption, entityCount, modelName));

        public async Task SetCountToolTips()
        {
            using var context = new ComputerDatabaseContext();
            var brandsCount = await context.Brands.CountAsync();
            var buildsCount = await context.Builds.CountAsync();
            var chipsetsCount = await context.Chipsets.CountAsync();
            var graphicsCardsCount = await context.GraphicsCards.CountAsync();
            var memoriesCount = await context.Memories.CountAsync();
            var motherboardsCount = await context.Motherboards.CountAsync();
            var processorsCount = await context.Processors.CountAsync();
            var socketsCount = await context.Sockets.CountAsync();
            var productsCount = motherboardsCount + processorsCount + graphicsCardsCount +
                                memoriesCount;

            SetCountToolTip(brandsButton, "marka", brandsCount);
            SetCountToolTip(buildsButton, "bilgisayar", buildsCount);
            SetCountToolTip(chipsetsButton, "yonga seti", chipsetsCount);
            SetCountToolTip(graphicsCardButton, "ekran kartı", graphicsCardsCount);
            SetCountToolTip(memoriesButton, "bellek", memoriesCount);
            SetCountToolTip(motherboardsButton, "anakart", motherboardsCount);
            SetCountToolTip(processorsButton, "işlemci", processorsCount);
            SetCountToolTip(socketsButton, "soket", socketsCount);
            SetCountToolTip(productsGroupBox, "ürün", productsCount);
        }

        private async void socketsButton_Click(object sender, EventArgs e)
        {
            Hide();

            await using (var presenter = new SocketListPresenter(true))
                presenter.ShowView();

            await SetCountToolTips();
            Show();
        }
    }
}