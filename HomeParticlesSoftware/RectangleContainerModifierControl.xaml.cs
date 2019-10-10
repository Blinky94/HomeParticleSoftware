using System.Windows;
using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour RectangleContainerModifierControl.xaml
    /// </summary>
    public partial class RectangleContainerModifierControl : UserControl
    {
        public RectangleContainerModifierControl()
        {
            InitializeComponent();
            WidthAndHeight.Label1.Text = "Width";
            WidthAndHeight.Label2.Text = "Height";

            RestitutionCoefficient.MainTitleBlock.Text = "Coef";
        }
    }
}
