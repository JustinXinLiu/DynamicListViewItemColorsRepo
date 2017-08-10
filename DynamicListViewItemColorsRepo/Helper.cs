using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace DynamicListViewItemColorsRepo
{
    public static class Helper
    {
        public static Brush GetPointerOverBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(PointerOverBackgroundProperty);
        }
        public static void SetPointerOverBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(PointerOverBackgroundProperty, value);
        }
        public static readonly DependencyProperty PointerOverBackgroundProperty =
            DependencyProperty.RegisterAttached("PointerOverBackground", typeof(Brush), typeof(Helper), new PropertyMetadata(null));
    }
}