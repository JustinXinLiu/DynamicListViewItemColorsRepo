using Windows.UI.Xaml.Media;

namespace DynamicListViewItemColorsRepo
{
    public class BasicItem : ISupportListViewItemBrushes
    {
        public SolidColorBrush PointerOverBrush { get; set; }
    }
}