using System.Windows;
using System.Windows.Controls;

namespace Loaders
{
    /// <summary>
    /// Imgur inspired loader
    /// </summary>
    public partial class ImgurLoader : UserControl
    {
        #region IsIndeterminate
        public static readonly DependencyProperty IsIndeterminateProperty = DependencyProperty.Register(
            "IsIndeterminate",
            typeof (bool),
            typeof (ImgurLoader),
            new PropertyMetadata(default(bool))
            );

        public bool IsIndeterminate
        {
            get { return (bool) GetValue(IsIndeterminateProperty); }
            set { SetValue(IsIndeterminateProperty, value); }
        }
        #endregion
        
        #region RingsThickness
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
        #endregion


        public ImgurLoader()
        {
            InitializeComponent();
        }
    }
}
