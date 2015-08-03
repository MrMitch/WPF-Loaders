using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Loaders
{
    /// <summary>
    /// Interaction logic for GooglePlus.xaml
    /// </summary>
    public partial class GooglePlus : UserControl
    {
        public static readonly DependencyProperty Color1Property = DependencyProperty.Register(
            "Color1", 
            typeof (Color), 
            typeof (GooglePlus), 
            new PropertyMetadata(Color.FromRgb(58,123,247))
        );

        public Color Color1
        {
            get { return (Color) GetValue(Color1Property); }
            set { SetValue(Color1Property, value); }
        }


        public static readonly DependencyProperty Color2Property = DependencyProperty.Register(
            "Color2", 
            typeof (Color), 
            typeof (GooglePlus), 
            new PropertyMetadata(Color.FromRgb(222,74,66))
        );

        public Color Color2
        {
            get { return (Color) GetValue(Color2Property); }
            set { SetValue(Color2Property, value); }
        }


        public static readonly DependencyProperty Color3Property = DependencyProperty.Register(
            "Color3", 
            typeof (Color), 
            typeof (GooglePlus), 
            new PropertyMetadata(Color.FromRgb(255, 214, 74))
        );

        public Color Color3
        {
            get { return (Color) GetValue(Color3Property); }
            set { SetValue(Color3Property, value); }
        }
        

        public static readonly DependencyProperty Color4Property = DependencyProperty.Register(
            "Color4", 
            typeof (Color), 
            typeof (GooglePlus), 
            new PropertyMetadata(Color.FromRgb(33, 173, 100))
        );

        public Color Color4
        {
            get { return (Color) GetValue(Color4Property); }
            set { SetValue(Color4Property, value); }
        }

        public GooglePlus()
        {
            InitializeComponent();
        }
    }
}
