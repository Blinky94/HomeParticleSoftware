using System.Windows;
using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour LineAndSprayControl.xaml
    /// </summary>
    public partial class LineAndSprayControl : UserControl
    {
        public double XValue { get; internal set; }
        public LineAndSprayControl()
        {
            InitializeComponent();
            Vector2Controls.Slider1.Minimum = -1;
            Vector2Controls.Slider2.Minimum = -1;
            Vector2Controls.Slider1.Maximum = 1;
            Vector2Controls.Slider2.Maximum = 1;
            Vector2Controls.Slider1.Value = 0;
            Vector2Controls.Slider2.Value = 0;
            LengthOrSpreadControl.Slider.Minimum = 0;
            LengthOrSpreadControl.Slider.Maximum = 7;
            Vector2Controls.Slider1.ValueChanged += Slider1_ValueChanged;
        }

        private void Slider1_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            XValue = Vector2Controls.Slider1.Value;
        }
    }
}
