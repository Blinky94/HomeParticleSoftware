using System.Windows;
using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour ScaleInterpolatorControl.xaml
    /// </summary>
    public partial class ScaleInterpolatorControl : UserControl
    {
        public ScaleInterpolatorControl()
        {
            InitializeComponent();
            ScaleMin.MainLabel.Text = "Start";
            ScaleMax.MainLabel.Text = "End";
            ScaleMin.Label1.Text = "X";
            ScaleMin.Label2.Text = "Y";
            ScaleMax.Label1.Text = "X";
            ScaleMax.Label2.Text = "Y";
        }
    }
}
