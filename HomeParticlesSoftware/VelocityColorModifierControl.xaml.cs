using System.Windows;
using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour VelocityColorModifierControl.xaml
    /// </summary>
    public partial class VelocityColorModifierControl : UserControl
    {
        public VelocityColorModifierControl()
        {
            InitializeComponent();
            StationaryColor.MainTitleBLock.Text = "Stat.Color";
            VelocityColor.MainTitleBLock.Text = "Veloc.Color";
            VelocityThreshold.MainTitleBlock.Text = "Thresh";
        }
    }
}
