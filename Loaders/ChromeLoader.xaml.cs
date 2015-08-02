using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Expression.Media;

namespace Loaders
{
    /// <summary>
    /// Interaction logic for ChromeLoader.xaml
    /// </summary>
    public partial class ChromeLoader : UserControl
    {
        public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.Register(
            "IsLoading", 
            typeof (bool), 
            typeof (ChromeLoader), 
            new PropertyMetadata(default(bool))
        );

        public bool IsLoading
        {
            get { return (bool) GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }


        public static readonly DependencyProperty BrushProperty = DependencyProperty.Register(
            "Brush",
            typeof(Brush),
            typeof(ChromeLoader),
            new PropertyMetadata(new SolidColorBrush(Colors.DodgerBlue))
        );

        public Brush Brush
        {
            get { return (Brush)GetValue(BrushProperty); }
            set { SetValue(BrushProperty, value); }
        }


        public static readonly DependencyProperty ThicknessUnitProperty = DependencyProperty.Register(
            "ThicknessUnit", typeof (UnitType), typeof (ChromeLoader), new PropertyMetadata(UnitType.Percent));

        public UnitType ThicknessUnit
        {
            get { return (UnitType) GetValue(ThicknessUnitProperty); }
            set { SetValue(ThicknessUnitProperty, value); }
        }


        public static readonly DependencyProperty ThicknessProperty = DependencyProperty.Register(
            "Thickness", typeof (double), typeof (ChromeLoader), new PropertyMetadata(0.25));

        public double Thickness
        {
            get { return (double) GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public ChromeLoader()
        {
            InitializeComponent();
        }
    }
}
