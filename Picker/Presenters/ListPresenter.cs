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

    internal sealed class ListPresenter<TEntity> : IListPresenter<ListForm<TEntity>, TEntity>
        where TEntity : IEntity
    {
        public Dictionary<TEntity, ListItemControl<TEntity>> Items { get; }
        public ListForm<TEntity> View { get; }
        public DialogResult ViewResult { get; private set; }

        public ListPresenter()
        {
            Items = new Dictionary<TEntity, ListItemControl<TEntity>>();
            View = (ListForm<TEntity>)Activator.CreateInstance(typeof(ListForm<TEntity>), this);
        }

        public void AddItem(TEntity entity)
        {
            var control = new ListItemControl<TEntity>(entity, true) { Dock = DockStyle.Top };
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
            var entities = context.Builds.Take(10).Cast<TEntity>(); // Yalnız ilk çalıştırma

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