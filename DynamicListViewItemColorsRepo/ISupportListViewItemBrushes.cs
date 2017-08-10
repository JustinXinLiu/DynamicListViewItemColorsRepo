using Windows.UI.Xaml.Media;

namespace DynamicListViewItemColorsRepo
{
    public interface ISupportListViewItemBrushes
    {
        SolidColorBrush PointerOverBrush { get; set; }
    }
}
