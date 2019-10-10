using System.Windows;
using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour ColorInterpolatorControl.xaml
    /// </summary>
    public partial class ColorInterpolatorControl : UserControl
    {
        public ColorInterpolatorControl()
        {
            InitializeComponent();
            ColorMin.MainTitleBLock.Text = "Min";
            ColorMax.MainTitleBLock.Text = "Max";
        }
    }
}
