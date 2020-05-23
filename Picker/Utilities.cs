namespace Picker
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Resources;
    using System.Threading;
    using System.Windows.Forms;
    using Properties;

    public static class Utilities
    {
        public static void ChangeLanguage(bool turkish)
        {
            var turkishCulture = CultureInfo.GetCultureInfo("tr-TR");
            var englishCulture = CultureInfo.GetCultureInfo("en-US");
            var savedCulture = Settings.Default.CultureInfo;
            var wasTurkish = savedCulture.Equals(turkishCulture);

            if (turkish == wasTurkish)
                return;

            Thread.CurrentThread.CurrentUICulture = turkish ? turkishCulture : englishCulture;

            foreach (Form form in Application.OpenForms)
            {
                var manager = new ComponentResourceManager(form.GetType());
                manager.ApplyResources(form, "$this");
                manager.ApplyToolTipResources(form);
                manager.ApplyResources(form.Controls);
            }
        }

        private static void ApplyResources(this ComponentResourceManager manager,
            IEnumerable controls)
        {
            foreach (Control control in controls)
            {
                manager.ApplyResources(control, control.Name);

                if (control is ContainerControl container)
                    manager.ApplyToolTipResources(container);

                if (control is ToolStrip toolStrip)
                    foreach (ToolStripItem item in toolStrip.Items)
                        manager.ApplyResources(item, item.Name);
                else
                    manager.ApplyResources(control.Controls);
            }
        }

        private static void ApplyToolTipResources(this ResourceManager manager,
            ContainerControl container)
        {
            foreach (var toolTip in container.GetToolTips())
            foreach (var control in toolTip.GetControls())
            {
                var newCaption = manager.GetString($"{control.Name}.ToolTip") ??
                                 manager.GetString($"{control.Name}.ToolTipText");

                if (newCaption != null)
                    toolTip.SetToolTip(control, newCaption);
            }
        }

        private static IContainer GetComponents(this ContainerControl control)
            => (IContainer)control.GetType().GetFieldValue(control, "components");

        private static IEnumerable<TResult> GetComponentsOfType<TResult>(
            this ContainerControl control)
        {
            var components = control.GetComponents();

            return components == null
                ? Array.Empty<TResult>()
                : components.Components.OfType<TResult>();
        }

        private static IEnumerable<Control> GetControls(this ToolTip toolTip)
        {
            var hashtable = (Hashtable)toolTip.GetType().GetFieldValue(toolTip, "tools");
            var controls = new Control[hashtable.Keys.Count];
            hashtable.Keys.CopyTo(controls, 0);
            return controls;
        }

        private static object GetFieldValue(this IReflect reflect, object instance, string name)
            => reflect.GetField(name, (BindingFlags)36).GetValue(instance);

        private static IEnumerable<ToolTip> GetToolTips(this ContainerControl container)
            => container.GetComponentsOfType<ToolTip>();
    }
}

namespace System
{
    using Threading.Tasks;

    /// <summary>Provides a mechanism for releasing unmanaged resources asynchronously.</summary>
    public interface IAsyncDisposable
    {
        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or
        ///     resetting unmanaged resources asynchronously.
        /// </summary>
        ValueTask DisposeAsync();
    }
}