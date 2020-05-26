namespace Picker.Presenters
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Models;
    using Views;

    internal sealed class BuildListPresenter : IListPresenter<ListForm<Build>, Build>
    {
        public Dictionary<Build, ListItemControl<Build>> Items { get; }
        public ListForm<Build> View { get; }
        public DialogResult ViewResult { get; private set; }

        public BuildListPresenter()
        {
            Items = new Dictionary<Build, ListItemControl<Build>>();
            View = (ListForm<Build>)Activator.CreateInstance(typeof(ListForm<Build>), this);
        }

        public void AddItem(Build entity)
        {
            var control = new ListItemControl<Build>(entity, true) { Dock = DockStyle.Top };
            Invoke(() => View.listPanel.Controls.Add(control));
            Items.Add(entity, control);
        }

        public void ClearItems()
        {
            foreach (var control in Items.Values)
                control.Dispose();

            Items.Clear();
        }

        public async Task FormLoad() => await LoadItems();

        public object Invoke(Action action) => View.Invoke(action);

        public async Task LoadItems()
        {
            ClearItems();

            using var context = new ComputerDatabaseContext();

            // Filtreleme
            var entities = context.Builds.Take(10); // Yalnız ilk çalıştırma

            // Listeleme
            await entities.ForEachAsync(AddItem);
        }

        public DialogResult ShowView() => ViewResult = View.ShowDialog();

        public ValueTask DisposeAsync()
        {
            ClearItems();
            View?.Close();
            View?.Dispose();

            return default;
        }
    }
}