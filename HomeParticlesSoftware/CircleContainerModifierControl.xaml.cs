using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour CircleContainerModifierControl.xaml
    /// </summary>
    public partial class CircleContainerModifierControl : UserControl
    {
        public CircleContainerModifierControl()
        {
            InitializeComponent();
            Label.Content = "Inside";
            Radius.MainTitleBlock.Text = "Radius";
            RestitutionCoefficient.MainTitleBlock.Text = "Coef";
        }
    }
}
