using System.Windows.Controls;

namespace HomeParticlesSoftware
{
    public partial class CircleAndRingProfilControl : UserControl
    {

        public CircleAndRingProfilControl()
        {
            InitializeComponent();
            radius.MainTitleBlock.Text = "Radius";
            Label.Content = "Radiate";
        }
    }
}
