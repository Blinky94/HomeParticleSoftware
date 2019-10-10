using System.Windows;
using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour HueInterpolatorControl.xaml
    /// </summary>
    public partial class HueInterpolatorControl : UserControl
    {
        public HueInterpolatorControl()
        {
            InitializeComponent();
            HueMin.MainTitleBlock.Text = "Start";
            HueMax.MainTitleBlock.Text = "End";
        }
    }
}
