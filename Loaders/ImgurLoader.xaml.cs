using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Loaders
{
    /// <summary>
    /// Interaction logic for ImgurLoader.xaml
    /// </summary>
    public partial class ImgurLoader : UserControl
    {
        public static readonly DependencyProperty RingsThicknessProperty = DependencyProperty.Register(
            "RingsThickness", 
            typeof (double), 
            typeof (ImgurLoader), 
            new PropertyMetadata(10d)
        );

        public double RingsThickness
        {
            get { return (double) GetValue(RingsThicknessProperty); }
            set { SetValue(RingsThicknessProperty, value); }
        }


        public static readonly DependencyProperty RingsBrushProperty = DependencyProperty.Register(
            "RingsBrush", typeof (Brush), typeof (ImgurLoader), new PropertyMetadata(default(Brush)));

        public Brush RingsBrush
        {
            get { return (Brush) GetValue(RingsBrushProperty); }
            set { SetValue(RingsBrushProperty, value); }
        }

        public ImgurLoader()
        {
            InitializeComponent();
        }
    }
}
