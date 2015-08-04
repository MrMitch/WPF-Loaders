using System.Windows;
using System.Windows.Controls;
using Microsoft.Expression.Media;

namespace Loaders
{
    /// <summary>
    /// Google Chrome inspired loader
    /// </summary>
    public partial class ChromeLoader : UserControl
    {
        #region IsIndeterminate
        public static readonly DependencyProperty IsIndeterminateProperty = DependencyProperty.Register(
            "IsIndeterminate",
            typeof (bool),
            typeof (ChromeLoader),
            new PropertyMetadata(default(bool))
            );

        public bool IsIndeterminate
        {
            get { return (bool) GetValue(IsIndeterminateProperty); }
            set { SetValue(IsIndeterminateProperty, value); }
        }
        #endregion

        #region ThicknessUnit
        public static readonly DependencyProperty ThicknessUnitProperty = DependencyProperty.Register(
            "ThicknessUnit",
            typeof (UnitType),
            typeof (ChromeLoader),
            new PropertyMetadata(UnitType.Percent)
            );

        public UnitType ThicknessUnit
        {
            get { return (UnitType) GetValue(ThicknessUnitProperty); }
            set { SetValue(ThicknessUnitProperty, value); }
        }
        #endregion
        
        #region Thickness
        public static readonly DependencyProperty ThicknessProperty = DependencyProperty.Register(
            "Thickness",
            typeof (double),
            typeof (ChromeLoader),
            new PropertyMetadata(0.25)
            );

        public double Thickness
        {
            get { return (double) GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }
        #endregion


        public ChromeLoader()
        {
            InitializeComponent();
        }
    }
}
