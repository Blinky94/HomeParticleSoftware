using System.Windows;
using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour VortexModifierControl.xaml
    /// </summary>
    public partial class VortexModifierControl : UserControl
    {
        public VortexModifierControl()
        {
            InitializeComponent();
            Position.MainLabel.Text = "Position";
            Position.Label1.Text = "X";
            Position.Label2.Text = "Y";

            MaxSpeed.MainTitleBlock.Text = "MaxSpeed";
            Mass.MainTitleBlock.Text = "Mass";
        }
    }
}
