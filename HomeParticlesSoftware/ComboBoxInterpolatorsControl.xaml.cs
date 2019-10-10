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

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour ComboBoxInterpolatorsControl.xaml
    /// </summary>
    public partial class ComboBoxInterpolatorsControl : UserControl
    {
        ColorInterpolatorControl colorInterpolator;
        HueInterpolatorControl hueInterpolator, opacityInterpolator, rotationInterpolator;
        ScaleInterpolatorControl scaleInterpolator;

        public double ColorMinRColor { get; private set; }
        public double ColorMinGColor { get; private set; }
        public double ColorMinBColor { get; private set; }

        public double ColorMaxRColor { get; private set; }
        public double ColorMaxGColor { get; private set; }
        public double ColorMaxBColor { get; private set; }

        public double HueMinValue { get; private set; }
        public double HueMaxValue { get; private set; }

        public double OpacityMinValue { get; private set; }
        public double OpacityMaxValue { get; private set; }

        public double RotationMaxValue { get; private set; }
        public double RotationMinValue { get; private set; }

        public double ScaleMinX { get; private set; }
        public double ScaleMinY { get; private set; }
        public double ScaleMaxX { get; private set; }
        public double ScaleMaxY { get; private set; }

        public ComboBoxInterpolatorsControl()
        {
            InitializeComponent();
        }

        private void ColorMinSliderRColor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {        
            ColorMinRColor = colorInterpolator.ColorMin.SliderRColor.Value;
        }

        private void ColorMinSliderGColor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorMinGColor = colorInterpolator.ColorMin.SliderGColor.Value;
        }

        private void ColorMinSliderBColor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorMinBColor = colorInterpolator.ColorMin.SliderBColor.Value;
        }
     
        private void ColorInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            colorInterpolator = new ColorInterpolatorControl();
            Grid.SetColumn(colorInterpolator, 0);
            Grid.SetColumnSpan(colorInterpolator, 3);
            Grid.SetRow(colorInterpolator, 1);
            Grid.Children.Add(colorInterpolator);

            colorInterpolator.ColorMin.SliderRColor.ValueChanged += ColorMinSliderRColor_ValueChanged;
            colorInterpolator.ColorMin.SliderGColor.ValueChanged += ColorMinSliderGColor_ValueChanged;
            colorInterpolator.ColorMin.SliderBColor.ValueChanged += ColorMinSliderBColor_ValueChanged;        
        }

        private void HueInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            hueInterpolator = new HueInterpolatorControl();
            Grid.SetColumn(hueInterpolator, 0);
            Grid.SetColumnSpan(hueInterpolator, 3);
            Grid.SetRow(hueInterpolator, 1);
            Grid.Children.Add(hueInterpolator);

            hueInterpolator.HueMin.Slider.ValueChanged += HueInterpolatorMinSlider_ValueChanged;
            hueInterpolator.HueMax.Slider.ValueChanged += HueInterpolatorMaxSlider_ValueChanged;
        }

        private void HueInterpolatorMinSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HueMinValue = hueInterpolator.HueMin.Slider.Value;
        }

        private void HueInterpolatorMaxSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HueMaxValue = hueInterpolator.HueMax.Slider.Value;
        }

        private void OpacityInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            opacityInterpolator = new HueInterpolatorControl();
            Grid.SetColumn(opacityInterpolator, 0);
            Grid.SetColumnSpan(opacityInterpolator, 3);
            Grid.SetRow(opacityInterpolator, 1);
            Grid.Children.Add(opacityInterpolator);

            opacityInterpolator.HueMin.Slider.ValueChanged += OpacityInterpolatorMinSlider_ValueChanged;
            opacityInterpolator.HueMax.Slider.ValueChanged += OpacityInterpolatorMaxSlider_ValueChanged;
        }

        private void OpacityInterpolatorMinSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            OpacityMinValue = opacityInterpolator.HueMin.Slider.Value;
        }

        private void OpacityInterpolatorMaxSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            OpacityMaxValue = opacityInterpolator.HueMax.Slider.Value;
        }

        private void RotationInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            rotationInterpolator = new HueInterpolatorControl();
            Grid.SetColumn(rotationInterpolator, 0);
            Grid.SetColumnSpan(rotationInterpolator, 3);
            Grid.SetRow(rotationInterpolator, 1);
            Grid.Children.Add(rotationInterpolator);

            rotationInterpolator.HueMin.Slider.ValueChanged += RotationInterpolatorMinSlider_ValueChanged;
            rotationInterpolator.HueMax.Slider.ValueChanged += RotationInterpolatorMaxSlider_ValueChanged;
        }

        private void RotationInterpolatorMinSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RotationMinValue = rotationInterpolator.HueMin.Slider.Value;
        }

        private void RotationInterpolatorMaxSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RotationMaxValue = rotationInterpolator.HueMax.Slider.Value;
        }

        private void ScaleInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            scaleInterpolator = new ScaleInterpolatorControl();
            Grid.SetColumn(scaleInterpolator, 0);
            Grid.SetColumnSpan(scaleInterpolator, 3);
            Grid.SetRow(scaleInterpolator, 1);
            Grid.Children.Add(scaleInterpolator);

            scaleInterpolator.ScaleMin.Slider1.ValueChanged += scaleInterpolatorMinSliderX_ValueChanged;
            scaleInterpolator.ScaleMin.Slider2.ValueChanged += scaleInterpolatorMinSliderY_ValueChanged;
            scaleInterpolator.ScaleMax.Slider1.ValueChanged += scaleInterpolatorMaxSliderX_ValueChanged;
            scaleInterpolator.ScaleMax.Slider2.ValueChanged += scaleInterpolatorMaxSliderY_ValueChanged;
        }

        private void scaleInterpolatorMinSliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ScaleMinX = scaleInterpolator.ScaleMin.Slider1.Value;
        }

        private void scaleInterpolatorMinSliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ScaleMinY = scaleInterpolator.ScaleMin.Slider2.Value;
        }

        private void scaleInterpolatorMaxSliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ScaleMaxX = scaleInterpolator.ScaleMax.Slider1.Value;
        }

        private void scaleInterpolatorMaxSliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ScaleMaxY = scaleInterpolator.ScaleMax.Slider2.Value;
        }
    }
}
