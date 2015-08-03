using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Loaders
{
    /// <summary>
    /// A Google+ inspired loader
    /// </summary>
    public partial class GooglePlusLoader : UserControl
    {
        #region Color1
        public static readonly DependencyProperty Color1Property = DependencyProperty.Register(
            "Color1",
            typeof(Color),
            typeof(GooglePlusLoader),
            new PropertyMetadata(Color.FromRgb(58, 123, 247))
        );

        public Color Color1
        {
            get { return (Color)GetValue(Color1Property); }
            set { SetValue(Color1Property, value); }
        }

        #endregion

        #region Color2
        public static readonly DependencyProperty Color2Property = DependencyProperty.Register(
            "Color2",
            typeof(Color),
            typeof(GooglePlusLoader),
            new PropertyMetadata(Color.FromRgb(222, 74, 66))
        );

        public Color Color2
        {
            get { return (Color)GetValue(Color2Property); }
            set { SetValue(Color2Property, value); }
        } 
        #endregion

        #region Color3
        public static readonly DependencyProperty Color3Property = DependencyProperty.Register(
            "Color3",
            typeof(Color),
            typeof(GooglePlusLoader),
            new PropertyMetadata(Color.FromRgb(255, 214, 74))
        );

        public Color Color3
        {
            get { return (Color)GetValue(Color3Property); }
            set { SetValue(Color3Property, value); }
        } 
        #endregion

        #region Color4
        public static readonly DependencyProperty Color4Property = DependencyProperty.Register(
            "Color4",
            typeof(Color),
            typeof(GooglePlusLoader),
            new PropertyMetadata(Color.FromRgb(33, 173, 100))
        );

        public Color Color4
        {
            get { return (Color)GetValue(Color4Property); }
            set { SetValue(Color4Property, value); }
        } 
        #endregion

        #region SpeedRatio
        public static readonly DependencyProperty SpeedRatioProperty = DependencyProperty.Register(
            "SpeedRatio",
            typeof(double),
            typeof(GooglePlusLoader),
            new PropertyMetadata(1d)
        );

        public double SpeedRatio
        {
            get { return (double)GetValue(SpeedRatioProperty); }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("SpeedRatio must be greater than 0", nameof(value));
                }
                SetValue(SpeedRatioProperty, value);
            }
        }
        #endregion

        public GooglePlusLoader()
        {
            InitializeComponent();
        }
    }
}
