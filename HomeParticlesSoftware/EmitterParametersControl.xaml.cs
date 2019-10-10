using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour EmitterParametersControl.xaml
    /// </summary>
    public partial class EmitterParametersControl : UserControl
    {
        public EmitterParametersControl()
        {
            InitializeComponent();

            //Colors Parameters titles
            ColorEmitterParametersMin.MainTitleBLock.Text = "COLOR";
 
            //Mass Paramters titles
            MassEmitterParametersMinMax.MainLabel.Text = "MASS";
            MassEmitterParametersMinMax.Label1.Text = "Min";
            MassEmitterParametersMinMax.Label2.Text = "Max";

            //Opacity Parameters titles
            OpacityEmitterParametersMinMax.MainLabel.Text = "OPACITY";
            OpacityEmitterParametersMinMax.Label1.Text = "Min";
            OpacityEmitterParametersMinMax.Label2.Text = "Max";

            //Quantity Paramters titles
            QuantityEmitterParametersMinMax.MainLabel.Text = "QUANTITY";
            QuantityEmitterParametersMinMax.Label1.Text = "Min";
            QuantityEmitterParametersMinMax.Label2.Text = "Max";

            //Rotation Parameters titles
            RotationEmitterParametersMinMax.MainLabel.Text = "ROTATION";
            RotationEmitterParametersMinMax.Label1.Text = "Min";
            RotationEmitterParametersMinMax.Label2.Text = "Max";

            //Scale Paramters titles
            ScaleEmitterParametersMinMax.MainLabel.Text = "SCALE";
            ScaleEmitterParametersMinMax.Label1.Text = "Min";
            ScaleEmitterParametersMinMax.Label2.Text = "Max";

            //Speed Paramters titles
            SpeedEmitterParametersMinMax.MainLabel.Text = "SPEED";
            SpeedEmitterParametersMinMax.Label1.Text = "Min";
            SpeedEmitterParametersMinMax.Label2.Text = "Max";
        }
    }
}
