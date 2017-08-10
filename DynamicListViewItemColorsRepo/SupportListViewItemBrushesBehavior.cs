using Windows.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;

namespace DynamicListViewItemColorsRepo
{
    public class SupportListViewItemBrushesBehavior : Behavior<ListView>
    {
        #region Overrides

        protected override void OnAttached()
        {
            AssociatedObject.ContainerContentChanging += OnContainerContentChanging;

            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            AssociatedObject.ContainerContentChanging -= OnContainerContentChanging;

            base.OnDetaching();
        }

        #endregion

        #region Event Handlers

        private void OnContainerContentChanging(ListViewBase sender, ContainerContentChangingEventArgs args)
        {
            if (!args.InRecycleQueue && 
                args.ItemContainer is ListViewItem container && 
                args.Item is ISupportListViewItemBrushes brushes)
            {
                Helper.SetPointerOverBackground(container, brushes.PointerOverBrush);
            }
        }

        #endregion
    }
}