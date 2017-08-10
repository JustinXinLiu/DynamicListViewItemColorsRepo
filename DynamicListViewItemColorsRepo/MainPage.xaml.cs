using System.Collections.ObjectModel;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace DynamicListViewItemColorsRepo
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            MyItems.Add(new BasicItem { PointerOverBrush = new SolidColorBrush(Colors.LightBlue) });
            MyItems.Add(new BasicItem { PointerOverBrush = new SolidColorBrush(Colors.LightPink) });
            MyItems.Add(new BasicItem { PointerOverBrush = new SolidColorBrush(Colors.LightGoldenrodYellow) });
            MyItems.Add(new BasicItem { PointerOverBrush = new SolidColorBrush(Colors.LightSalmon) });
            MyItems.Add(new BasicItem { PointerOverBrush = new SolidColorBrush(Colors.LightGreen) });
        }

        private ObservableCollection<BasicItem> MyItems { get; } = new ObservableCollection<BasicItem>();
    }
}
