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
    /// Logique d'interaction pour ComboBoxContainersModifierControl.xaml
    /// </summary>
    public partial class ComboBoxContainersModifierControl : UserControl
    {

        public bool IsCircleContainerModifierInside { get; internal set; }
        public float CircleContainerModifierRadius { get; internal set; }
        public float CircleContainerModifierCoef { get; internal set; }

        public int RectangleContainerModifierWidth { get; internal set; }
        public int RectangleContainerModifierHeight { get; internal set; }
        public float RectangleContainerModifierCoef { get; internal set; }

        public int RectangleLoopContainerModifierWidth { get; internal set; }
        public int RectangleLoopContainerModifierHeight { get; internal set; }

        public ComboBoxContainersModifierControl()
        {
            InitializeComponent();
        }

        private void CircleContainerModifier_Selected(object sender, RoutedEventArgs e)
        {
            //circleContainerModifier = new CircleContainerModifierControl();
            //Grid.SetColumn(circleContainerModifier, 0);
            //Grid.SetRow(circleContainerModifier, 2);
            //Grid.SetColumnSpan(circleContainerModifier, 3);
            //Grid.Children.Add(circleContainerModifier);
            //circleContainerModifier.Inside.ComboBox.SelectionChanged += ComboBox_SelectionChanged;
            //circleContainerModifier.Radius.Slider.ValueChanged += Slider_ValueChanged;
            //circleContainerModifier.RestitutionCoefficient.Slider.ValueChanged += Slider_ValueChanged1; ;
        }

        private void Slider_ValueChanged1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //CircleContainerModifierCoef = (float)circleContainerModifier.RestitutionCoefficient.Slider.Value;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //CircleContainerModifierRadius = (float)circleContainerModifier.Radius.Slider.Value;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if(circleContainerModifier.Inside.ComboBox.SelectedItem.ToString() == "True")
            //    IsCircleContainerModifierInside = true;
            //if (circleContainerModifier.Inside.ComboBox.SelectedItem.ToString() == "False")
            //    IsCircleContainerModifierInside = false;
        }

        private void RectangleContainerModifier_Selected(object sender, RoutedEventArgs e)
        {
            //rectangleContainerModifier = new RectangleContainerModifierControl();
            //rectangleContainerModifier.RestitutionCoefficient.Visibility = Visibility.Visible;
            //Grid.SetColumn(rectangleContainerModifier, 0);
            //Grid.SetRow(rectangleContainerModifier, 2);
            //Grid.SetColumnSpan(rectangleContainerModifier, 3);
            //Grid.Children.Add(rectangleContainerModifier);
        }

        private void RectangleLoopContainerModifier_Selected(object sender, RoutedEventArgs e)
        {
            //rectangleLoopContainerModifier = new RectangleContainerModifierControl();
            //rectangleLoopContainerModifier.RestitutionCoefficient.Visibility = Visibility.Hidden;
            //Grid.SetColumn(rectangleLoopContainerModifier, 0);
            //Grid.SetRow(rectangleLoopContainerModifier, 2);
            //Grid.SetColumnSpan(rectangleLoopContainerModifier, 3);
            //Grid.Children.Add(rectangleLoopContainerModifier);
        }
    }
}
