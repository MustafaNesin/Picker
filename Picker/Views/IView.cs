namespace Picker.Views
{
    using System;
    using Models;

    internal interface IView<TEntity>
        where TEntity : IEntity
    {
        void FormLoad(object sender, EventArgs e);
    }
}