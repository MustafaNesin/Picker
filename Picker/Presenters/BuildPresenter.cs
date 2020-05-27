namespace Picker.Presenters
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Models;
    using Views;

    internal class BuildPresenter : IEntityPresenter<BuildForm, Build>
    {
        public ComputerDatabaseContext Context { get; }
        public Build Entity { get; }
        public BuildForm View { get; }
        public DialogResult ViewResult { get; private set; }

        public BuildPresenter(Build entity)
        {
            Entity = entity;
            Context = new ComputerDatabaseContext();
            View = (BuildForm)Activator.CreateInstance(typeof(BuildForm), this);
        }

        public Task FormLoad() => throw new NotImplementedException();

        public object Invoke(Action action) => View.Invoke(action);

        public DialogResult ShowView() => ViewResult = View.ShowDialog();

        public async ValueTask DisposeAsync()
        {
            if (ViewResult == DialogResult.OK)
                await Context.SaveChangesAsync();

            Context.Dispose();
            View?.Close();
            View?.Dispose();
        }
    }
}