using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour MinMaxRGBColorControl.xaml
    /// </summary>
    public partial class MinMaxRGBColorControl : UserControl
    {
        private byte RColorValue, GColorValue, BColorValue;
    
        private void SetHSLColor(System.Windows.Shapes.Rectangle rectangle, byte R, byte G, byte B)
        {
            if (rectangle != null)
                rectangle.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        public MinMaxRGBColorControl()
        {
            InitializeComponent();
        }    

        private void TextBoxRColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxRColor.Text))
            {
                RColorValue = Convert.ToByte(TextBoxRColor.Text);
                SetHSLColor(RectangleRGBColor, RColorValue, GColorValue, BColorValue);
            }
            else
            {
                RColorValue = byte.MinValue;
                SetHSLColor(RectangleRGBColor, RColorValue, GColorValue, BColorValue);
            }
        }

        private void TextBoxGColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxGColor.Text))
            {
                GColorValue = Convert.ToByte(TextBoxGColor.Text);
                SetHSLColor(RectangleRGBColor, RColorValue, GColorValue, BColorValue);
            }
            else
            {
                BColorValue = byte.MinValue;
                SetHSLColor(RectangleRGBColor, RColorValue, GColorValue, BColorValue);
            }
        }

        private void TextBoxBColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxBColor.Text))
            {
                BColorValue = Convert.ToByte(TextBoxBColor.Text);
                SetHSLColor(RectangleRGBColor, RColorValue, GColorValue, BColorValue);
            }
            else
            {
                BColorValue = byte.MinValue;
                SetHSLColor(RectangleRGBColor, RColorValue, GColorValue, BColorValue);
            }
        }
    }
}
