using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyGame myGame;
        private List<MyGame> listMyGame = new List<MyGame>();
        private string fileName;
        private string texturePath;
        const string fileEmpty = @"D:\GameDevelop\ParticlesEngineMine\WpfApp1\WpfApp1\xml\Empty.xml";
        private string imagesFolder = @"D:\GameDevelop\ParticlesEngineMine\WpfApp1\WpfApp1\Textures\";
      
        //Informations
        private TextControl NameInformations, AuthorInformation, DescriptionInformation, VersionInformation;

        //Definitions
        private TextControl NameDefinition;
        private TextControlWithBorwser TextureRegionDefinition;
        private SliderIntControl sliderCapacityDefinitions;
        private SliderFloatControl sliderLifeSpanDefinitions;

        //ProfilDefinition
        private bool IsProfilPointSelected = false;
        private BoxProfils profilBoxFill, profilBox, profilBoxUniform;
        private CircleAndRingProfilControl profilCircle, profilRing;
        private LineAndSprayControl profilLine, profilSpray;

        //Emitter parameters
        private EmitterParametersControl emitterParameters;

        public MainWindow()
        {
            InitializeComponent(); 
            ImageList();
            TextBoxTexturesBrowser.Text = imagesFolder;

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            //Add TextControl informations
            NameInformations = new TextControl();
            NameInformations.Label.Content = "Name";
            NameInformations.CheckBox.Visibility = Visibility.Hidden;
            Grid.SetColumn(NameInformations, 0);
            Grid.SetRow(NameInformations, 0);
            InformationDetails.Children.Add(NameInformations);

            AuthorInformation = new TextControl();
            AuthorInformation.Label.Content = "Author";
            AuthorInformation.CheckBox.Visibility = Visibility.Hidden;
            Grid.SetColumn(AuthorInformation, 0);
            Grid.SetRow(AuthorInformation, 1);
            InformationDetails.Children.Add(AuthorInformation);

            DescriptionInformation = new TextControl();
            DescriptionInformation.Label.Content = "Description";
            DescriptionInformation.CheckBox.Visibility = Visibility.Hidden;
            Grid.SetColumn(DescriptionInformation, 0);
            Grid.SetRow(DescriptionInformation, 2);
            InformationDetails.Children.Add(DescriptionInformation);

            VersionInformation = new TextControl();
            VersionInformation.Label.Content = "Version";
            VersionInformation.CheckBox.Visibility = Visibility.Hidden;
            Grid.SetColumn(VersionInformation, 0);
            Grid.SetRow(VersionInformation, 3);
            InformationDetails.Children.Add(VersionInformation);

            //Add TextControl Definitions
            NameDefinition = new TextControl();
            NameDefinition.Label.Content = "Name";
            NameDefinition.CheckBox.Visibility = Visibility.Hidden;
            Grid.SetColumn(NameDefinition, 0);
            Grid.SetRow(NameDefinition, 0);
            DefinitionsDetails.Children.Add(NameDefinition);

            //Add TextControlWithBrowser Definitions
            TextureRegionDefinition = new TextControlWithBorwser();
            TextureRegionDefinition.Label.Content = "Texture";
            TextureRegionDefinition.TextBox.IsEnabled = false;
            TextureRegionDefinition.TextBox.Background = Brushes.LightGray;
            TextureRegionDefinition.TextBox.TextChanged += MyGame_TextChanged;
            Grid.SetColumn(TextureRegionDefinition, 0);
            Grid.SetRow(TextureRegionDefinition, 1);
            DefinitionsDetails.Children.Add(TextureRegionDefinition);

            //Add Slider Capacity Definitions
            sliderCapacityDefinitions = new SliderIntControl();
            sliderCapacityDefinitions.MainTitleBlock.Text = "Capt.";
            SliderCapacityAndLifeSpanDefinitions.Children.Add(sliderCapacityDefinitions);
            sliderCapacityDefinitions.Slider.Maximum = 5000;
            sliderCapacityDefinitions.Slider.ValueChanged += MyGame_ValueChanged;

            //Add Slider LifeSpan Definitions
            sliderLifeSpanDefinitions = new SliderFloatControl();
            sliderLifeSpanDefinitions.MainTitleBlock.Text = "Life";
            SliderCapacityAndLifeSpanDefinitions.Children.Add(sliderLifeSpanDefinitions);
            sliderLifeSpanDefinitions.Slider.ValueChanged += MyGame_ValueChanged;

            //Add EmitterParameterControls
            emitterParameters = new EmitterParametersControl();
            Grid.SetColumn(emitterParameters, 0);
            Grid.SetRow(emitterParameters, 0);
            EmitterParameterControlsGrid.Children.Add(emitterParameters);
            //EmitterParameters COLOR
            emitterParameters.ColorEmitterParametersMin.SliderRColor.ValueChanged += MyGame_ValueChanged;
            emitterParameters.ColorEmitterParametersMin.SliderGColor.ValueChanged += MyGame_ValueChanged;
            emitterParameters.ColorEmitterParametersMin.SliderBColor.ValueChanged += MyGame_ValueChanged;
            //EmitterParameters MASS
            emitterParameters.MassEmitterParametersMinMax.Slider1.ValueChanged += MyGame_ValueChanged;
            emitterParameters.MassEmitterParametersMinMax.Slider2.ValueChanged += MyGame_ValueChanged;
            //EmitterParameters OPACITY
            emitterParameters.OpacityEmitterParametersMinMax.Slider1.ValueChanged += MyGame_ValueChanged;
            emitterParameters.OpacityEmitterParametersMinMax.Slider2.ValueChanged += MyGame_ValueChanged;
            //EmitterParameters QUANTITY
            emitterParameters.QuantityEmitterParametersMinMax.Slider1.Maximum = 5000;
            emitterParameters.QuantityEmitterParametersMinMax.Slider2.Maximum = 5000;
            emitterParameters.QuantityEmitterParametersMinMax.Slider1.ValueChanged += MyGame_ValueChanged;
            emitterParameters.QuantityEmitterParametersMinMax.Slider2.ValueChanged += MyGame_ValueChanged;
            //EmitterParameters ROTATION
            emitterParameters.RotationEmitterParametersMinMax.Slider1.Minimum = -1;
            emitterParameters.RotationEmitterParametersMinMax.Slider2.Minimum = -1;
            emitterParameters.RotationEmitterParametersMinMax.Slider1.Maximum = 1;
            emitterParameters.RotationEmitterParametersMinMax.Slider2.Maximum = 1;
            emitterParameters.RotationEmitterParametersMinMax.Slider1.ValueChanged += MyGame_ValueChanged;
            emitterParameters.RotationEmitterParametersMinMax.Slider2.ValueChanged += MyGame_ValueChanged;
            //EmitterParameters SCALE
            emitterParameters.ScaleEmitterParametersMinMax.Slider1.Minimum = -100;
            emitterParameters.ScaleEmitterParametersMinMax.Slider2.Minimum = -100;
            emitterParameters.ScaleEmitterParametersMinMax.Slider1.Maximum = 100;
            emitterParameters.ScaleEmitterParametersMinMax.Slider2.Maximum = 100;
            emitterParameters.ScaleEmitterParametersMinMax.Slider1.ValueChanged += MyGame_ValueChanged;
            emitterParameters.ScaleEmitterParametersMinMax.Slider2.ValueChanged += MyGame_ValueChanged;
            //EmitterParameters SPEED
            emitterParameters.SpeedEmitterParametersMinMax.Slider1.Maximum = 5000;
            emitterParameters.SpeedEmitterParametersMinMax.Slider2.Maximum = 5000;
            emitterParameters.SpeedEmitterParametersMinMax.Slider1.ValueChanged += MyGame_ValueChanged;
            emitterParameters.SpeedEmitterParametersMinMax.Slider2.ValueChanged += MyGame_ValueChanged;

            //AgeModifier
            //ComboBoxInterpolatorsModifierControl.ComboBox.SelectionChanged += MyGame_SelectionChanged;

            //Add DragModifier Controls
            DragModifierModifierControl.HueMin.MainTitleBlock.Text = "Coeff";
            DragModifierModifierControl.HueMax.MainTitleBlock.Text = "Density";
            DragModifierModifierControl.HueMin.Slider.ValueChanged += MyGame_ValueChanged;
            DragModifierModifierControl.HueMax.Slider.ValueChanged += MyGame_ValueChanged;

            //LinearGravityModifier Control
            LinearGravityModifierControl.Vector2Controls.MainLabel.Text = "Direct";
            LinearGravityModifierControl.Vector2Controls.Label1.Text = "X";
            LinearGravityModifierControl.Vector2Controls.Label2.Text = "Y";
            LinearGravityModifierControl.LengthOrSpreadControl.MainTitleBlock.Text = "Stgth";
            LinearGravityModifierControl.Vector2Controls.Slider1.ValueChanged += MyGame_ValueChanged;
            LinearGravityModifierControl.Vector2Controls.Slider2.ValueChanged += MyGame_ValueChanged;
            LinearGravityModifierControl.Vector2Controls.Slider1.Value = -0;
            LinearGravityModifierControl.Vector2Controls.Slider2.Value = 0;
            LinearGravityModifierControl.Vector2Controls.Slider1.Minimum = -100;
            LinearGravityModifierControl.Vector2Controls.Slider2.Minimum = -100;
            LinearGravityModifierControl.Vector2Controls.Slider1.Maximum = 100;
            LinearGravityModifierControl.Vector2Controls.Slider2.Maximum = 100;
            LinearGravityModifierControl.LengthOrSpreadControl.Slider.Maximum = 100;
            LinearGravityModifierControl.LengthOrSpreadControl.Slider.ValueChanged += MyGame_ValueChanged;
            LinearGravityModifierControlDuration.Slider.Maximum = 1000f;
            LinearGravityModifierControlDuration.Slider.Value = 0f;
            LinearGravityModifierControlDuration.MainTitleBlock.Text = "Duration";
            LinearGravityModifierControlDuration.Slider.ValueChanged += MyGame_ValueChanged;
            LinearGravityModifierControlSizeBuffer.Slider.Maximum = 1000;
            LinearGravityModifierControlSizeBuffer.Slider.Value = 0;
            LinearGravityModifierControlSizeBuffer.MainTitleBlock.Text = "Buffer";
            LinearGravityModifierControlSizeBuffer.Slider.ValueChanged += MyGame_ValueChanged;

            //OpacityFastFadeModifierControl
            OpacityFastFadeModifierControlDuration.Slider.Maximum = 1000f;
            OpacityFastFadeModifierControlDuration.Slider.Value = 0f;
            OpacityFastFadeModifierControlDuration.MainTitleBlock.Text = "Duration";
            OpacityFastFadeModifierControlDuration.Slider.ValueChanged += MyGame_ValueChanged;
            OpacityFastFadeModifierControlSizeBuffer.Slider.Maximum = 1000;
            OpacityFastFadeModifierControlSizeBuffer.Slider.Value = 0;
            OpacityFastFadeModifierControlSizeBuffer.MainTitleBlock.Text = "Buffer";
            OpacityFastFadeModifierControlSizeBuffer.Slider.ValueChanged += MyGame_ValueChanged;

            //SliderRotationRateRotationModifier
            SliderRotationRateRotationModifier.MainTitleBlock.Text = "Rot.Cf";
            SliderRotationRateRotationModifier.Slider.Minimum = -500;
            SliderRotationRateRotationModifier.Slider.Maximum = 500;
            SliderRotationRateRotationModifier.Slider.Value = 0;
            SliderRotationRateRotationModifier.Slider.ValueChanged += MyGame_ValueChanged;

            //VelocityColorModifier
            VelocityColorModifier.StationaryColor.SliderRColor.ValueChanged += MyGame_ValueChanged;
            VelocityColorModifier.StationaryColor.SliderGColor.ValueChanged += MyGame_ValueChanged;
            VelocityColorModifier.StationaryColor.SliderBColor.ValueChanged += MyGame_ValueChanged;
            VelocityColorModifier.VelocityColor.SliderRColor.ValueChanged += MyGame_ValueChanged;
            VelocityColorModifier.VelocityColor.SliderGColor.ValueChanged += MyGame_ValueChanged;
            VelocityColorModifier.VelocityColor.SliderBColor.ValueChanged += MyGame_ValueChanged;
            VelocityColorModifier.VelocityThreshold.Slider.ValueChanged += MyGame_ValueChanged;

            //VelocityModifier           
            ComboBoxVelocityModifiersInterpolators.SelectionChanged += MyGame_SelectionChanged;

            //VortexModifier
            VortexModifierPosition.MainLabel.Text = "Position";
            VortexModifierPosition.Label1.Text = "X";
            VortexModifierPosition.Label2.Text = "Y";
            VortexModifierMaxSpeed.MainTitleBlock.Text = "MaxSpeed";
            VortexModifierMass.MainTitleBlock.Text = "Mass";
            VortexModifierPosition.Slider1.ValueChanged += MyGame_ValueChanged;
            VortexModifierPosition.Slider2.ValueChanged += MyGame_ValueChanged;
            VortexModifierMaxSpeed.Slider.ValueChanged += MyGame_ValueChanged;
            VortexModifierMass.Slider.ValueChanged += MyGame_ValueChanged;

            //SliderParticleMode
            SliderFloatParticleMode.Slider.Maximum = 50;
            SliderFloatParticleMode.Slider.TickFrequency = 0.1f;
            SliderFloatParticleMode.Slider.ValueChanged += SliderFloatParticleMode_ValueChanged;

            myGame = new MyGame();
            listMyGame.Add(myGame);
            ParticleVisualisation.Children.Add(myGame);
        }

        private void SliderFloatParticleMode_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ActualizeMyGame();
        }

        private void RAZProfilDefinitionsValues()
        {
            myGame.BoxFillWidth = 0;
            myGame.BoxFillHeight = 0;
            myGame.BoxWidth = 0;
            myGame.BoxHeight = 0;
            myGame.BoxUniformWidth = 0;
            myGame.BoxUniformHeight = 0;
            myGame.CircleRadius = 0;
            myGame.CircleRadiate = "";
            myGame.LineAxisX = 0;
            myGame.LineAxisY = 0;
            myGame.LineLength = 0;
            myGame.RingRadius = 0;
            myGame.RingRadiate = "";
            myGame.SprayDirectionX = 0;
            myGame.SprayDirectionY = 0;
            myGame.SpraySpread = 0;
        }

        private void RAZContainersModifierValues()
        {
            myGame.CircleContainerModifierInside = false;         
            myGame.CircleContainerModifierRadius = 0;
            myGame.CircleContainerModifierRestitutionCoefficient = 0;
            myGame.RectangleContainerModifierWidth = 0;
            myGame.RectangleContainerModifierHeight = 0;           
            myGame.RectangleContainerModifierRestitutionCoefficient = 0;
            myGame.RectangleLoopContainerModifierWidth = 0;
            myGame.RectangleLoopContainerModifierHeight = 0;         
        }

        private void RAZAgeModifierInperpolatorsValues()
        {
            myGame.ModifiersInterpolatorsSelectedName = string.Empty;
            myGame.AgeModifierColorInterpolatorStartValue = Microsoft.Xna.Framework.Color.Black;
            myGame.AgeModifierHueInterpolatorStartValue = 0;
            myGame.AgeModifierHueInterpolatorEndValue = 0;
            myGame.AgeModifierOpacityInterpolatorStartValue = 0;
            myGame.AgeModifierOpacityInterpolatorEndValue = 0;
            myGame.AgeModifierRotationInterpolatorStartValue = 0;
            myGame.AgeModifierRotationInterpolatorEndValue = 0;
            myGame.AgeModifierScaleInterpolatorStartValueX = 0;
            myGame.AgeModifierScaleInterpolatorEndValueX = 0;
            myGame.AgeModifierScaleInterpolatorStartValueY = 0;
            myGame.AgeModifierScaleInterpolatorEndValueY = 0;
        }

        private void RAZVelocityColorModifierInterpolatorValues()
        {
            myGame.VelocityModifiersInterpolatorsSelectedName = string.Empty;
            myGame.VelocityModifierColorInterpolatorStartValue = Microsoft.Xna.Framework.Color.Black;
            myGame.VelocityModifierHueInterpolatorStartValue = 0;
            myGame.VelocityModifierHueInterpolatorEndValue = 0;
            myGame.VelocityModifierOpacityInterpolatorStartValue = 0;
            myGame.VelocityModifierOpacityInterpolatorEndValue = 0;
            myGame.VelocityModifierRotationInterpolatorStartValue = 0;
            myGame.VelocityModifierRotationInterpolatorEndValue = 0;
            myGame.VelocityModifierScaleInterpolatorStartValueX = 0;
            myGame.VelocityModifierScaleInterpolatorEndValueX = 0;
            myGame.VelocityModifierScaleInterpolatorStartValueY = 0;
            myGame.VelocityModifierScaleInterpolatorEndValueY = 0;
            myGame.VelocityColorModifierVelocityThreshold = 0;
        }

        private void RAZDragModifierValues()
        {
            myGame.DragModifierDensity = 0;
            myGame.DragModifierDragCoefficient = 0f;
        }

        private void RAZLinearGravityModifierValues()
        {
            myGame.LinearGravityModifierDirectionX = 0;
            myGame.LinearGravityModifierDirectionY = 0;
            myGame.LinearGravityModifierStrength = 0;
            myGame.LinearGravityModifierControlDuration = 0f;
            myGame.LinearGravityModifierControlSizeBuffer = 0;
        }

        private void RAZOpacityFastFadeModifierValues()
        {
            myGame.OpacityFastFadeModifierControlDuration = 0f;
            myGame.OpacityFastFadeModifierControlSizeBuffer = 0;
        }

        private void RAZRotationModifierValues()
        {
            myGame.RotationModifierRotationRate = 0f;
        }

        private void RAZVelocityColorModifierValues()
        {
            myGame.VelocityColorModifierStationaryColor = new Microsoft.Xna.Framework.Color(0, 0, 0);
            myGame.VelocityColorModifierVelocityColor = new Microsoft.Xna.Framework.Color(0, 0, 0);
            myGame.VelocityColorModifierVelocityThreshold = 0f;
        }

        private void RAZVortexModifierValues()
        {
            myGame.VortexModifierPositionX = 0;
            myGame.VortexModifierPositionY = 0;
            myGame.VortexModifierMaxSpeed = 0;
            myGame.VortexModifierMass = 0;
        }

        private void ActualizeMyGame()
        {
            ParticleVisualisation.Children.Clear();

            try
            {
                myGame.ProfileName = (ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString();
                myGame.PointIsPoint = IsProfilPointSelected;

                if ((ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString() == "BoxFill")
                {
                    myGame.BoxFillWidth = (float)profilBoxFill.boxProfils.Slider1.Value;
                    myGame.BoxFillHeight = (float)profilBoxFill.boxProfils.Slider2.Value;
                }

                if ((ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString() == "Box")
                {
                    myGame.BoxWidth = (float)profilBox.boxProfils.Slider1.Value;
                    myGame.BoxHeight = (float)profilBox.boxProfils.Slider2.Value;
                }

                if ((ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString() == "BoxUniform")
                {
                    myGame.BoxUniformWidth = (float)profilBoxUniform.boxProfils.Slider1.Value;
                    myGame.BoxUniformHeight = (float)profilBoxUniform.boxProfils.Slider2.Value;
                }

                if ((ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString() == "Circle")
                {
                    myGame.CircleRadius = (float)profilCircle.radius.Slider.Value;
                    myGame.CircleRadiate = (profilCircle.circleRadiation.SelectedItem as ComboBoxItem).Content.ToString();
                }

                if ((ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString() == "Line")
                {
                   // MessageBox.Show("Line : " + profilLine.Vector2Controls.Slider1.Value.ToString() + ", " + profilLine.Vector2Controls.Slider1.Value.ToString());
                    myGame.LineAxisX = (float)profilLine.Vector2Controls.Slider1.Value;
                    myGame.LineAxisY = (float)profilLine.Vector2Controls.Slider2.Value;
                    myGame.LineLength = (float)profilLine.LengthOrSpreadControl.Slider.Value;
                }

                if ((ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString() == "Ring")
                {
                    myGame.RingRadius = (float)profilRing.radius.Slider.Value;
                    myGame.RingRadiate = (profilRing.circleRadiation.SelectedItem as ComboBoxItem).Content.ToString();
                }

                if ((ComboBoxProfileDefinitions.SelectedItem as ComboBoxItem).Content.ToString() == "Spray")
                {
                    myGame.SprayDirectionX = (float)profilSpray.Vector2Controls.Slider1.Value;
                    myGame.SprayDirectionY = (float)profilSpray.Vector2Controls.Slider2.Value;
                    myGame.SpraySpread = (float)profilSpray.LengthOrSpreadControl.Slider.Value;
                }

                if (CheckBoxCOntainersModifier.IsChecked == true)
                {
                    myGame.IsContainerModifierSelected = true;

                    if (circleContainerModifier != null)
                    {
                        myGame.ContainerModifierSelectedName = ComboBoxContainersModifierControl.SelectionBoxItem.ToString();
                        if ((circleContainerModifier.ComboBox.SelectedItem as ComboBoxItem).Content.ToString() == "True")
                            myGame.CircleContainerModifierInside = true;

                        if ((circleContainerModifier.ComboBox.SelectedItem as ComboBoxItem).Content.ToString() == "False")
                            myGame.CircleContainerModifierInside = false;

                        myGame.CircleContainerModifierRadius = (float)circleContainerModifier.Radius.Slider.Value;
                        myGame.CircleContainerModifierRestitutionCoefficient = (float)circleContainerModifier.RestitutionCoefficient.Slider.Value;
                    }

                    if (rectangleContainerModifier != null)
                    {
                        myGame.ContainerModifierSelectedName = ComboBoxContainersModifierControl.SelectionBoxItem.ToString();
                        myGame.RectangleContainerModifierWidth = (int)rectangleContainerModifier.WidthAndHeight.Slider1.Value;
                        myGame.RectangleContainerModifierHeight = (int)rectangleContainerModifier.WidthAndHeight.Slider2.Value;
                        myGame.RectangleContainerModifierRestitutionCoefficient = (float)rectangleContainerModifier.RestitutionCoefficient.Slider.Value;
                    }

                    if (rectangleLoopContainerModifier != null)
                    {
                        myGame.ContainerModifierSelectedName = ComboBoxContainersModifierControl.SelectionBoxItem.ToString();
                        myGame.RectangleLoopContainerModifierWidth = (int)rectangleLoopContainerModifier.WidthAndHeight.Slider1.Value;
                        myGame.RectangleLoopContainerModifierHeight = (int)rectangleLoopContainerModifier.WidthAndHeight.Slider2.Value;
                    }
                }
                else
                    myGame.IsContainerModifierSelected = false;
                

                if (ClickModeParticleEffect.IsChecked == true)
                    myGame.LifeSpanFromMilliseconds = (float)sliderLifeSpanDefinitions.Slider.Value;
                if(AutoParticleModeEffect.IsChecked == true)
                    myGame.LifeSpanFromMilliseconds = (float)SliderFloatParticleMode.Slider.Value;
                myGame.DefinitionsCapacity = (int)Math.Round(sliderCapacityDefinitions.Slider.Value);
                myGame.DefinitionsTextureRegion = TextureRegionDefinition.FullPathTexture;             
                myGame.ParametersColorMin = new Microsoft.Xna.Framework.Color(                                    
                    (byte)emitterParameters.ColorEmitterParametersMin.SliderRColor.Value,
                    (byte)emitterParameters.ColorEmitterParametersMin.SliderGColor.Value,
                    (byte)emitterParameters.ColorEmitterParametersMin.SliderBColor.Value);             
                myGame.ParametersMassMin = (float)emitterParameters.MassEmitterParametersMinMax.Slider1.Value;
                myGame.ParametersMassMax = (float)emitterParameters.MassEmitterParametersMinMax.Slider2.Value;
                myGame.ParametersOpacityMin = (float)emitterParameters.OpacityEmitterParametersMinMax.Slider1.Value;
                myGame.ParametersOpacityMax = (float)emitterParameters.OpacityEmitterParametersMinMax.Slider2.Value;
                myGame.ParametersQuantityMin = (int)emitterParameters.QuantityEmitterParametersMinMax.Slider1.Value;
                myGame.ParametersQuantityMax = (int)emitterParameters.QuantityEmitterParametersMinMax.Slider2.Value;
                myGame.ParametersRotationMin = (float)emitterParameters.RotationEmitterParametersMinMax.Slider1.Value;
                myGame.ParametersRotationMax = (float)emitterParameters.RotationEmitterParametersMinMax.Slider2.Value;
                myGame.ParametersScaleMin = (float)emitterParameters.ScaleEmitterParametersMinMax.Slider1.Value;
                myGame.ParametersScaleMax = (float)emitterParameters.ScaleEmitterParametersMinMax.Slider2.Value;
                myGame.ParametersSpeedMin = (float)emitterParameters.SpeedEmitterParametersMinMax.Slider1.Value;
                myGame.ParametersSpeedMax = (float)emitterParameters.SpeedEmitterParametersMinMax.Slider2.Value;
             
                if(CheckBoxAgeModifier.IsChecked == true)
                {
                    if(ComboBoxModifiersInterpolators.SelectedItem != null)
                    {
                        string interpolatorName = (ComboBoxModifiersInterpolators.SelectedItem as ComboBoxItem).Content.ToString();
                        myGame.ModifiersInterpolatorsSelectedName = interpolatorName;

                        if (interpolatorName == "ColorInterpolator")
                        {
                            myGame.ModifiersInterpolatorsSelectedName = (ComboBoxModifiersInterpolators.SelectedItem as ComboBoxItem).Content.ToString();
                            myGame.AgeModifierColorInterpolatorStartValue = new Microsoft.Xna.Framework.Color(
                                (byte)modifiersInterpolatorsColorInterpolator.ColorMin.SliderRColor.Value,
                                (byte)modifiersInterpolatorsColorInterpolator.ColorMin.SliderGColor.Value,
                                (byte)modifiersInterpolatorsColorInterpolator.ColorMin.SliderBColor.Value);
                        }
                        if (interpolatorName == "HueInterpolator")
                        {
                            myGame.AgeModifierHueInterpolatorStartValue = (float)modifiersInterpolatorsHueInterpolator.HueMin.Slider.Value;
                            myGame.AgeModifierHueInterpolatorEndValue = (float)modifiersInterpolatorsHueInterpolator.HueMax.Slider.Value;
                        }
                        if (interpolatorName == "OpacityInterpolator")
                        {
                            myGame.AgeModifierOpacityInterpolatorStartValue = (float)modifiersInterpolatorsOpacityInterpolator.HueMin.Slider.Value;
                            myGame.AgeModifierOpacityInterpolatorEndValue = (float)modifiersInterpolatorsOpacityInterpolator.HueMax.Slider.Value;
                        }
                        if (interpolatorName == "RotationInterpolator")
                        {
                            myGame.AgeModifierRotationInterpolatorStartValue = (float)modifiersInterpolatorsRotationInterpolator.HueMin.Slider.Value;
                            myGame.AgeModifierRotationInterpolatorEndValue = (float)modifiersInterpolatorsRotationInterpolator.HueMax.Slider.Value;
                        }
                        if (interpolatorName == "ScaleInterpolator")
                        {
                            myGame.AgeModifierScaleInterpolatorStartValueX = (float)modifiersInterpolatorsScaleInterpolator.ScaleMin.Slider1.Value;
                            myGame.AgeModifierScaleInterpolatorEndValueX = (float)modifiersInterpolatorsScaleInterpolator.ScaleMax.Slider1.Value;
                            myGame.AgeModifierScaleInterpolatorStartValueY = (float)modifiersInterpolatorsScaleInterpolator.ScaleMin.Slider2.Value;
                            myGame.AgeModifierScaleInterpolatorEndValueY = (float)modifiersInterpolatorsScaleInterpolator.ScaleMax.Slider2.Value;
                        }
                    }                 
                }
                
                if(CheckBoxDragModifier.IsChecked == true)
                {
                    myGame.IsDragModifierSelected = true;
                    myGame.DragModifierDragCoefficient = (float)DragModifierModifierControl.HueMin.Slider.Value;
                    myGame.DragModifierDensity = (float)DragModifierModifierControl.HueMax.Slider.Value;
                }
                else
                    myGame.IsDragModifierSelected = false;

                if (CheckBoxLinearGravityModifier.IsChecked == true)
                {
                    myGame.LinearGravityModifierDirectionX = (float)LinearGravityModifierControl.Vector2Controls.Slider1.Value;
                    myGame.LinearGravityModifierDirectionY = (float)LinearGravityModifierControl.Vector2Controls.Slider2.Value;
                    myGame.LinearGravityModifierStrength = (float)LinearGravityModifierControl.LengthOrSpreadControl.Slider.Value;
                    myGame.LinearGravityModifierControlDuration = (float)LinearGravityModifierControlDuration.Slider.Value;
                    myGame.LinearGravityModifierControlSizeBuffer = (int)LinearGravityModifierControlSizeBuffer.Slider.Value;
                    myGame.IsLinearGravityModifierSelected = true;
                }
                else
                    myGame.IsLinearGravityModifierSelected = false;

                if (CheckBoxOpacityFastFadeModifier.IsChecked == true)
                {
                    myGame.OpacityFastFadeModifierControlDuration = (float)OpacityFastFadeModifierControlDuration.Slider.Value;
                    myGame.OpacityFastFadeModifierControlSizeBuffer = (int)OpacityFastFadeModifierControlSizeBuffer.Slider.Value;
                    myGame.IsOpacityFastFadeModifierSelected = true;
                }
                else
                    myGame.IsOpacityFastFadeModifierSelected = false;

                if(CheckBoxRotationModifier.IsChecked == true)
                {
                    myGame.RotationModifierRotationRate = (float)SliderRotationRateRotationModifier.Slider.Value;
                    myGame.IsRotationModifierRotationRate = true;
                }
                else
                    myGame.IsRotationModifierRotationRate = false;

                if(CheckBoxVelocityColorModifier.IsChecked == true)
                {
                    myGame.IsVelocityColorModifierSelected = true;
                    myGame.VelocityColorModifierStationaryColor = new Microsoft.Xna.Framework.Color(               
                        (byte)VelocityColorModifier.StationaryColor.SliderRColor.Value,
                        (byte)VelocityColorModifier.StationaryColor.SliderGColor.Value,
                        (byte)VelocityColorModifier.StationaryColor.SliderBColor.Value);
                    myGame.VelocityColorModifierVelocityColor = new Microsoft.Xna.Framework.Color(
                        (byte)VelocityColorModifier.VelocityColor.SliderRColor.Value,
                        (byte)VelocityColorModifier.VelocityColor.SliderGColor.Value,
                        (byte)VelocityColorModifier.VelocityColor.SliderBColor.Value);
                    myGame.VelocityColorModifierVelocityThreshold = (float)VelocityColorModifier.VelocityThreshold.Slider.Value;
                }
                else
                    myGame.IsVelocityColorModifierSelected = false;

                if (CheckBoxVelocityModifier.IsChecked == true)
                {
                    myGame.IsVelocityModifierInterpolatorSelected = true;
                    if (ComboBoxVelocityModifiersInterpolators.SelectedItem != null)
                    {
                        string interpolatorName = (ComboBoxVelocityModifiersInterpolators.SelectedItem as ComboBoxItem).Content.ToString();
                        myGame.VelocityModifiersInterpolatorsSelectedName = interpolatorName;

                        if (interpolatorName == "ColorInterpolator")
                        {
                            myGame.VelocityModifierColorInterpolatorStartValue = new Microsoft.Xna.Framework.Color(
                                (byte)velocityModifiersInterpolatorsColorInterpolator.ColorMin.SliderRColor.Value,
                                (byte)velocityModifiersInterpolatorsColorInterpolator.ColorMin.SliderGColor.Value,
                                (byte)velocityModifiersInterpolatorsColorInterpolator.ColorMin.SliderBColor.Value);

                            myGame.VelocityModifierColorInterpolatorEndValue = new Microsoft.Xna.Framework.Color(
                                (byte)velocityModifiersInterpolatorsColorInterpolator.ColorMax.SliderRColor.Value,
                                (byte)velocityModifiersInterpolatorsColorInterpolator.ColorMax.SliderGColor.Value,
                                (byte)velocityModifiersInterpolatorsColorInterpolator.ColorMax.SliderBColor.Value);
                        }
                        if (interpolatorName == "HueInterpolator")
                        {
                            myGame.VelocityModifierHueInterpolatorStartValue = (float)velocityModifiersInterpolatorsHueInterpolator.HueMin.Slider.Value;
                            myGame.VelocityModifierHueInterpolatorEndValue = (float)velocityModifiersInterpolatorsHueInterpolator.HueMax.Slider.Value;
                        }
                        if (interpolatorName == "OpacityInterpolator")
                        {
                            myGame.VelocityModifierOpacityInterpolatorStartValue = (float)velocityModifiersInterpolatorsOpacityInterpolator.HueMin.Slider.Value;
                            myGame.VelocityModifierOpacityInterpolatorEndValue = (float)velocityModifiersInterpolatorsOpacityInterpolator.HueMax.Slider.Value;
                        }
                        if (interpolatorName == "RotationInterpolator")
                        {
                            myGame.VelocityModifierRotationInterpolatorStartValue = (float)velocityModifiersInterpolatorsRotationInterpolator.HueMin.Slider.Value;
                            myGame.VelocityModifierRotationInterpolatorEndValue = (float)velocityModifiersInterpolatorsRotationInterpolator.HueMax.Slider.Value;
                        }
                        if (interpolatorName == "ScaleInterpolator")
                        {
                            myGame.VelocityModifierScaleInterpolatorStartValueX = (float)velocityModifiersInterpolatorsScaleInterpolator.ScaleMin.Slider1.Value;
                            myGame.VelocityModifierScaleInterpolatorEndValueX = (float)velocityModifiersInterpolatorsScaleInterpolator.ScaleMax.Slider1.Value;
                            myGame.VelocityModifierScaleInterpolatorStartValueY = (float)velocityModifiersInterpolatorsScaleInterpolator.ScaleMin.Slider2.Value;
                            myGame.VelocityModifierScaleInterpolatorEndValueY = (float)velocityModifiersInterpolatorsScaleInterpolator.ScaleMax.Slider2.Value;
                        }
                        myGame.VelocityModifierVelocityThreshold = (float)VelocityModifierVelocityThreshold.Slider.Value;
                    }
                }
                else
                    myGame.IsVelocityModifierInterpolatorSelected = false;

                if(CheckBoxVortexModifier.IsChecked == true)
                {
                    myGame.IsVortexModifierSelected = true;
                    myGame.VortexModifierPositionX = (float)VortexModifierPosition.Slider1.Value;
                    myGame.VortexModifierPositionY = (float)VortexModifierPosition.Slider2.Value;
                    myGame.VortexModifierMaxSpeed = (float)VortexModifierMaxSpeed.Slider.Value;
                    myGame.VortexModifierMass = (float)VortexModifierMass.Slider.Value;
                }
                else
                    myGame.IsVortexModifierSelected = false;

                ParticleVisualisation.Children.Add(myGame);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }        
        }

        private void MyGame_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ActualizeMyGame();
        }

        private void MyGame_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizeMyGame();
        }

        private void MyGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ActualizeMyGame();
        }

        private void ProfileBoxFill_Selected(object sender, RoutedEventArgs e)
        {
            ProfilDetails.Children.Clear();
            RAZProfilDefinitionsValues();
            profilBoxFill = new BoxProfils();
            profilBoxFill.boxProfils.Slider1.ValueChanged += MyGame_ValueChanged;
            profilBoxFill.boxProfils.Slider2.ValueChanged += MyGame_ValueChanged;
            ProfilDetails.Children.Add(profilBoxFill);
            ProfilDetails.Visibility = Visibility.Visible;
            IsProfilPointSelected = false;
        }

        private void ProfileBox_Selected(object sender, RoutedEventArgs e)
        {
            ProfilDetails.Children.Clear();
            RAZProfilDefinitionsValues();
            profilBox = new BoxProfils();
            profilBox.boxProfils.Slider1.ValueChanged += MyGame_ValueChanged;
            profilBox.boxProfils.Slider2.ValueChanged += MyGame_ValueChanged;
            ProfilDetails.Children.Add(profilBox);
            ProfilDetails.Visibility = Visibility.Visible;
            IsProfilPointSelected = false;
        }

        private void ProfileBoxUniform_Selected(object sender, RoutedEventArgs e)
        {
            ProfilDetails.Children.Clear();
            RAZProfilDefinitionsValues();
            profilBoxUniform = new BoxProfils();
            profilBoxUniform.boxProfils.Slider1.ValueChanged += MyGame_ValueChanged;
            profilBoxUniform.boxProfils.Slider2.ValueChanged += MyGame_ValueChanged;
            ProfilDetails.Children.Add(profilBoxUniform);
            ProfilDetails.Visibility = Visibility.Visible;
            IsProfilPointSelected = false;
        }

        private void ProfileCircle_Selected(object sender, RoutedEventArgs e)
        {
            ProfilDetails.Children.Clear();
            RAZProfilDefinitionsValues();
            profilCircle = new CircleAndRingProfilControl();
            profilCircle.radius.Slider.ValueChanged += MyGame_ValueChanged;
            profilCircle.circleRadiation.SelectionChanged += MyGame_SelectionChanged;
            ProfilDetails.Children.Add(profilCircle);
            ProfilDetails.Visibility = Visibility.Visible;
            IsProfilPointSelected = false;
        }

        private void ProfileLine_Selected(object sender, RoutedEventArgs e)
        {
            ProfilDetails.Children.Clear();
            RAZProfilDefinitionsValues();
            profilLine = new LineAndSprayControl();
            profilLine.Vector2Controls.MainLabel.Text = "Axis";
            profilLine.Vector2Controls.Label1.Text = "X";
            profilLine.Vector2Controls.Label2.Text = "Y";
            profilLine.LengthOrSpreadControl.MainTitleBlock.Text = "Length";
            profilLine.Vector2Controls.Slider1.ValueChanged += MyGame_ValueChanged;
            profilLine.Vector2Controls.Slider2.ValueChanged += MyGame_ValueChanged;
            profilLine.LengthOrSpreadControl.Slider.ValueChanged += MyGame_ValueChanged;
            ProfilDetails.Children.Add(profilLine);
            ProfilDetails.Visibility = Visibility.Visible;
            IsProfilPointSelected = false;
        }

        private void ProfileRing_Selected(object sender, RoutedEventArgs e)
        {
            ProfilDetails.Children.Clear();
            RAZProfilDefinitionsValues();
            profilRing = new CircleAndRingProfilControl();
            profilRing.radius.Slider.ValueChanged += MyGame_ValueChanged;
            profilRing.circleRadiation.SelectionChanged += MyGame_SelectionChanged;
            ProfilDetails.Children.Add(profilRing);
            ProfilDetails.Visibility = Visibility.Visible;
            IsProfilPointSelected = false;
        }

        private void ProfilePoint_Selected(object sender, RoutedEventArgs e)
        {
            if(ProfilDetails != null)
            {
                RAZProfilDefinitionsValues();
                ProfilDetails.Visibility = Visibility.Collapsed;
                IsProfilPointSelected = true;
                ActualizeMyGame();
            }
        }

        private void ProfileSpray_Selected(object sender, RoutedEventArgs e)
        {
            ProfilDetails.Children.Clear();
            RAZProfilDefinitionsValues();
            profilSpray = new LineAndSprayControl();
            profilSpray.Vector2Controls.MainLabel.Text = "Dir";
            profilSpray.Vector2Controls.Label1.Text = "X";
            profilSpray.Vector2Controls.Label2.Text = "Y";
            profilSpray.LengthOrSpreadControl.MainTitleBlock.Text = "Spread";  
            profilSpray.Vector2Controls.Slider1.ValueChanged += MyGame_ValueChanged;
            profilSpray.Vector2Controls.Slider2.ValueChanged += MyGame_ValueChanged;
            profilSpray.LengthOrSpreadControl.Slider.ValueChanged += MyGame_ValueChanged;
            ProfilDetails.Children.Add(profilSpray);
            ProfilDetails.Visibility = Visibility.Visible;
            IsProfilPointSelected = false;
        }

        private CircleContainerModifierControl circleContainerModifier;
        private RectangleContainerModifierControl rectangleContainerModifier, rectangleLoopContainerModifier;

        private void CircleContainerModifier_Selected(object sender, RoutedEventArgs e)
        {
            if(ContainerDetails != null)
            {
                ContainerDetails.Children.Clear();
                RAZContainersModifierValues();
                circleContainerModifier = new CircleContainerModifierControl();
                circleContainerModifier.ComboBox.SelectionChanged += MyGame_SelectionChanged;
                circleContainerModifier.Radius.Slider.ValueChanged += MyGame_ValueChanged;
                circleContainerModifier.RestitutionCoefficient.Slider.ValueChanged += MyGame_ValueChanged;
                ContainerDetails.Children.Add(circleContainerModifier);
                ContainerDetails.Visibility = Visibility.Visible;
            }         
        }

        private void RectangleContainerModifier_Selected(object sender, RoutedEventArgs e)
        {
            if (ContainerDetails != null)
            {
                ContainerDetails.Children.Clear();
                RAZContainersModifierValues();
                rectangleContainerModifier = new RectangleContainerModifierControl();
                rectangleContainerModifier.RestitutionCoefficient.Visibility = Visibility.Visible;
                rectangleContainerModifier.WidthAndHeight.Slider1.ValueChanged += MyGame_ValueChanged;
                rectangleContainerModifier.WidthAndHeight.Slider2.ValueChanged += MyGame_ValueChanged;
                rectangleContainerModifier.RestitutionCoefficient.Slider.ValueChanged += MyGame_ValueChanged;
                ContainerDetails.Children.Add(rectangleContainerModifier);
                ContainerDetails.Visibility = Visibility.Visible;
            }
        }

        private void RectangleLoopContainerModifier_Selected(object sender, RoutedEventArgs e)
        {
            if (ContainerDetails != null)
            {
                ContainerDetails.Children.Clear();
                RAZContainersModifierValues();
                rectangleLoopContainerModifier = new RectangleContainerModifierControl();
                rectangleLoopContainerModifier.RestitutionCoefficient.Visibility = Visibility.Hidden;
                rectangleLoopContainerModifier.WidthAndHeight.Slider1.ValueChanged += MyGame_ValueChanged;
                rectangleLoopContainerModifier.WidthAndHeight.Slider2.ValueChanged += MyGame_ValueChanged;
                ContainerDetails.Children.Add(rectangleLoopContainerModifier);
                ContainerDetails.Visibility = Visibility.Visible;
            }
        }

        public ObservableCollection<Image> imagesCollection = new ObservableCollection<Image>();

        private void NewXml_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous créer un nouveau paramétrage ? (Attention, toutes les données non enregistrées seront perdues !)",
                "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MainWindow mainW = new MainWindow();
                mainW.Show();
                this.Close();
            }
        }

        private void LoadXml_Click(object sender, RoutedEventArgs e)
        {
            var directoryExplore = new Microsoft.Win32.OpenFileDialog() { Filter = "XML Files (*.xml} | *.xml" };
            directoryExplore.InitialDirectory = @"E:\GameDevelop\ParticlesEngineMine\WpfApp1\WpfApp1\xml\";
            var result = directoryExplore.ShowDialog();
            if (result == false) return;

            fileName = directoryExplore.FileName;
        }   
     
        private void SaveXml_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void ButtonBrowseTextureRegionDefinitions_Click(object sender, RoutedEventArgs e)
        {
            var directoryExplore = new Microsoft.Win32.OpenFileDialog() { Filter = "JPG Files (*.jpg} | *.jpg | JPEG Files (*.jpeg} | *.jpeg | BMP Files (*.bmp} | *.bmp | PNG Files (*.png} | *.png" };
            directoryExplore.InitialDirectory = imagesFolder;
            var result = directoryExplore.ShowDialog();
            if (result == false) return;

            string fileName = directoryExplore.FileName;
            texturePath = fileName;
            TextureRegionDefinition.TextBox.Text = GetFileNameOnly(fileName);
            TextureRegionDefinition.TextBox.Background = Brushes.GhostWhite;
            TextureRegionDefinition.TextBox.IsEnabled = true;
        }

        private void CheckBoxNameDefinitions_Checked(object sender, RoutedEventArgs e)
        {
            NameDefinition.TextBox.Background = Brushes.GhostWhite;
            NameDefinition.TextBox.IsEnabled = true;
        }

        private void CheckBoxNameDefinitions_Unchecked(object sender, RoutedEventArgs e)
        {
            NameDefinition.TextBox.Background = Brushes.LightGray;
            NameDefinition.TextBox.IsEnabled = false;
            NameDefinition.TextBox.Text = string.Empty;
        }

        private void CheckBoxTextureRegionDefinitions_Checked(object sender, RoutedEventArgs e)
        {
            TextureRegionDefinition.TextBox.Background = Brushes.GhostWhite;
            TextureRegionDefinition.TextBox.IsEnabled = true;
            TextureRegionDefinition.TextBox.IsEnabled = true;
        }

        private void CheckBoxTextureRegionDefinitions_Unchecked(object sender, RoutedEventArgs e)
        {
            TextureRegionDefinition.TextBox.Background = Brushes.LightGray;
            TextureRegionDefinition.TextBox.IsEnabled = false;
            TextureRegionDefinition.TextBox.Text = string.Empty;
            TextureRegionDefinition.TextBox.IsEnabled = false;
        }
      
        private void CheckBoxDefinition_Checked(object sender, RoutedEventArgs e)
        {
            DefinitionsDetails.Visibility = Visibility.Visible;
        }

        private void CheckBoxDefinition_Unchecked(object sender, RoutedEventArgs e)
        {
            DefinitionsDetails.Visibility = Visibility.Collapsed;
        }

        private void CheckBoxInformation_Checked(object sender, RoutedEventArgs e)
        {
            InformationDetails.Visibility = Visibility.Visible;
        }

        private void CheckBoxInformation_Unchecked(object sender, RoutedEventArgs e)
        {
            InformationDetails.Visibility = Visibility.Collapsed;
        }

        private void CheckBoxEmitterParameters_Checked(object sender, RoutedEventArgs e)
        {
            EmitterParameterBlock.Visibility = Visibility.Visible;
            myGame.IsEmitterParameters = true;
        }

        private void CheckBoxEmitterParameters_Unchecked(object sender, RoutedEventArgs e)
        {
            EmitterParameterBlock.Visibility = Visibility.Collapsed;
        }

        private void CheckBoxAgeModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxAgeModifier.IsChecked == true)           
                GridModifiersInterpolators.Visibility = Visibility.Visible;
            else
            {
                GridModifiersInterpolators.Visibility = Visibility.Collapsed;
                RAZAgeModifierInperpolatorsValues();
            }
            ActualizeMyGame();
        }

        private void CheckBoxDragModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxDragModifier.IsChecked == true)
                DragModifierModifierControl.Visibility = Visibility.Visible;
            else
            {
                DragModifierModifierControl.Visibility = Visibility.Collapsed;
                RAZDragModifierValues();
            }
            ActualizeMyGame();
        }

        private void CheckBoxCOntainersModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxCOntainersModifier.IsChecked == true)
            {
                StackContainersModifiers.Visibility = Visibility.Visible;
            }

            else
            {
                StackContainersModifiers.Visibility = Visibility.Collapsed;
                RAZContainersModifierValues();
            }
            ActualizeMyGame();
        }

        private void CheckBoxEmitterModifiers_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxEmitterModifiers.IsChecked == true)
                EmitterModifiersBlock.Visibility = Visibility.Visible;
            else
                EmitterModifiersBlock.Visibility = Visibility.Collapsed;
            ActualizeMyGame();
        }

        private void CheckBoxLinearGravityModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxLinearGravityModifier.IsChecked == true)
                LinearGravityModifierControlStackPanel.Visibility = Visibility.Visible;          
            else
            {
                LinearGravityModifierControlStackPanel.Visibility = Visibility.Collapsed;
                RAZLinearGravityModifierValues();
            }
            ActualizeMyGame();
        }

        private void CheckBoxOpacityFastFadeModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxOpacityFastFadeModifier.IsChecked == true)
                OpacityFastFadeModifierControlStackPanel.Visibility = Visibility.Visible;
            else
            {
                OpacityFastFadeModifierControlStackPanel.Visibility = Visibility.Collapsed;
                RAZOpacityFastFadeModifierValues();
            }
            ActualizeMyGame();
        }

        private void CheckBoxRotationModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxRotationModifier.IsChecked == true)
                SliderRotationRateRotationModifier.Visibility = Visibility.Visible;
            else
            {
                SliderRotationRateRotationModifier.Visibility = Visibility.Collapsed;
                RAZRotationModifierValues();
            }

            ActualizeMyGame();
        }

        private void CheckBoxVelocityColorModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxVelocityColorModifier.IsChecked == true)
                VelocityColorModifier.Visibility = Visibility.Visible;
            else
            {
                VelocityColorModifier.Visibility = Visibility.Collapsed;
                RAZVelocityColorModifierValues();
            }

            ActualizeMyGame();
        }


        private ColorInterpolatorControl modifiersInterpolatorsColorInterpolator;
        private HueInterpolatorControl modifiersInterpolatorsHueInterpolator, modifiersInterpolatorsOpacityInterpolator, modifiersInterpolatorsRotationInterpolator;
        private ScaleInterpolatorControl modifiersInterpolatorsScaleInterpolator;
       
        private void ModifierColorInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if(ModifierInterpolatorsDetails != null)
            {
                ModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                ModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                modifiersInterpolatorsColorInterpolator = new ColorInterpolatorControl();
                modifiersInterpolatorsColorInterpolator.ColorMin.SliderRColor.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsColorInterpolator.ColorMin.SliderGColor.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsColorInterpolator.ColorMin.SliderBColor.ValueChanged += MyGame_ValueChanged;
                ModifierInterpolatorsDetails.Children.Add(modifiersInterpolatorsColorInterpolator);
            }
        }

        private void ModifierHueInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (ModifierInterpolatorsDetails != null)
            {
                ModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                ModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                modifiersInterpolatorsHueInterpolator = new HueInterpolatorControl();
                modifiersInterpolatorsHueInterpolator.HueMin.Slider.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsHueInterpolator.HueMax.Slider.ValueChanged += MyGame_ValueChanged;
                ModifierInterpolatorsDetails.Children.Add(modifiersInterpolatorsHueInterpolator);
            }
        }

        private void ModifierOpacityInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (ModifierInterpolatorsDetails != null)
            {
                ModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                ModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                modifiersInterpolatorsOpacityInterpolator = new HueInterpolatorControl();
                modifiersInterpolatorsOpacityInterpolator.HueMin.Slider.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsOpacityInterpolator.HueMax.Slider.ValueChanged += MyGame_ValueChanged;
                ModifierInterpolatorsDetails.Children.Add(modifiersInterpolatorsOpacityInterpolator);
            }
        }

        private void ModifierRotationInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (ModifierInterpolatorsDetails != null)
            {
                ModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                ModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                modifiersInterpolatorsRotationInterpolator = new HueInterpolatorControl();
                modifiersInterpolatorsRotationInterpolator.HueMin.Slider.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsRotationInterpolator.HueMax.Slider.ValueChanged += MyGame_ValueChanged;
                ModifierInterpolatorsDetails.Children.Add(modifiersInterpolatorsRotationInterpolator);
            }
        }

        private void ModifierScaleInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (ModifierInterpolatorsDetails != null)
            {
                ModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                ModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                modifiersInterpolatorsScaleInterpolator = new ScaleInterpolatorControl();
                modifiersInterpolatorsScaleInterpolator.ScaleMin.Slider1.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsScaleInterpolator.ScaleMin.Slider2.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsScaleInterpolator.ScaleMax.Slider1.ValueChanged += MyGame_ValueChanged;
                modifiersInterpolatorsScaleInterpolator.ScaleMax.Slider2.ValueChanged += MyGame_ValueChanged;
                ModifierInterpolatorsDetails.Children.Add(modifiersInterpolatorsScaleInterpolator);
            }
        }

        //VelocityModiferInterpolator
        private ScaleInterpolatorControl velocityModifiersInterpolatorsScaleInterpolator;
        private ColorInterpolatorControl velocityModifiersInterpolatorsColorInterpolator;
        private HueInterpolatorControl velocityModifiersInterpolatorsHueInterpolator, velocityModifiersInterpolatorsOpacityInterpolator, velocityModifiersInterpolatorsRotationInterpolator;
        private SliderFloatControl VelocityModifierVelocityThreshold;

        private void VelocityModifierColorInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (VelocityModifierInterpolatorsDetails != null)
            {
                VelocityModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                VelocityModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                velocityModifiersInterpolatorsColorInterpolator = new ColorInterpolatorControl();
                velocityModifiersInterpolatorsColorInterpolator.ColorMin.SliderRColor.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsColorInterpolator.ColorMin.SliderGColor.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsColorInterpolator.ColorMin.SliderBColor.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(velocityModifiersInterpolatorsColorInterpolator);
                VelocityModifierVelocityThreshold = new SliderFloatControl();
                VelocityModifierVelocityThreshold.MainTitleBlock.Text = "Thresh";
                VelocityModifierVelocityThreshold.Slider.Maximum = 500;
                VelocityModifierVelocityThreshold.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(VelocityModifierVelocityThreshold);
            }
        }

        private void VelocityModifierHueInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (VelocityModifierInterpolatorsDetails != null)
            {
                VelocityModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                VelocityModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                velocityModifiersInterpolatorsHueInterpolator = new HueInterpolatorControl();
                velocityModifiersInterpolatorsHueInterpolator.HueMin.Slider.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsHueInterpolator.HueMax.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(velocityModifiersInterpolatorsHueInterpolator);
                VelocityModifierVelocityThreshold = new SliderFloatControl();
                VelocityModifierVelocityThreshold.MainTitleBlock.Text = "Thresh";
                VelocityModifierVelocityThreshold.Slider.Maximum = 500;
                VelocityModifierVelocityThreshold.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(VelocityModifierVelocityThreshold);
            }
        }

        private void VelocityModifierOpacityInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (VelocityModifierInterpolatorsDetails != null)
            {
                VelocityModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                VelocityModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                velocityModifiersInterpolatorsOpacityInterpolator = new HueInterpolatorControl();
                velocityModifiersInterpolatorsOpacityInterpolator.HueMin.Slider.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsOpacityInterpolator.HueMax.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(velocityModifiersInterpolatorsOpacityInterpolator);
                VelocityModifierVelocityThreshold = new SliderFloatControl();
                VelocityModifierVelocityThreshold.MainTitleBlock.Text = "Thresh";
                VelocityModifierVelocityThreshold.Slider.Maximum = 500;
                VelocityModifierVelocityThreshold.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(VelocityModifierVelocityThreshold);
            }
        }

        private void VelocityModifierRotationInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (VelocityModifierInterpolatorsDetails != null)
            {
                VelocityModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                VelocityModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                velocityModifiersInterpolatorsRotationInterpolator = new HueInterpolatorControl();
                velocityModifiersInterpolatorsRotationInterpolator.HueMin.Slider.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsRotationInterpolator.HueMax.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(velocityModifiersInterpolatorsRotationInterpolator);
                VelocityModifierVelocityThreshold = new SliderFloatControl();
                VelocityModifierVelocityThreshold.MainTitleBlock.Text = "Thresh";
                VelocityModifierVelocityThreshold.Slider.Maximum = 500;
                VelocityModifierVelocityThreshold.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(VelocityModifierVelocityThreshold);
            }
        }

        private void VelocityModifierScaleInterpolator_Selected(object sender, RoutedEventArgs e)
        {
            if (ModifierInterpolatorsDetails != null)
            {
                VelocityModifierInterpolatorsDetails.Children.Clear();
                //RAZAgeModifierInperpolatorsValues();
                VelocityModifierInterpolatorsDetails.Visibility = Visibility.Visible;
                velocityModifiersInterpolatorsScaleInterpolator = new ScaleInterpolatorControl();
                velocityModifiersInterpolatorsScaleInterpolator.ScaleMin.Slider1.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsScaleInterpolator.ScaleMin.Slider2.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsScaleInterpolator.ScaleMax.Slider1.ValueChanged += MyGame_ValueChanged;
                velocityModifiersInterpolatorsScaleInterpolator.ScaleMax.Slider2.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(velocityModifiersInterpolatorsScaleInterpolator);
                VelocityModifierVelocityThreshold = new SliderFloatControl();
                VelocityModifierVelocityThreshold.MainTitleBlock.Text = "Thresh";
                VelocityModifierVelocityThreshold.Slider.Maximum = 500;
                VelocityModifierVelocityThreshold.Slider.ValueChanged += MyGame_ValueChanged;
                VelocityModifierInterpolatorsDetails.Children.Add(VelocityModifierVelocityThreshold);
            }
        }

        private void CheckBoxVelocityModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxVelocityModifier.IsChecked == true)
                GridVelocityModifiersInterpolators.Visibility = Visibility.Visible;
            else
            {
                GridVelocityModifiersInterpolators.Visibility = Visibility.Collapsed;
                RAZVelocityColorModifierInterpolatorValues();
            }

            ActualizeMyGame();
        }

        private void CheckBoxVortexModifier_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxVortexModifier.IsChecked == true)
            {
                VortexModifierStackPanel.Visibility = Visibility.Visible;
                VortexModifierPosition.Slider1.Maximum = ParticleVisualisation.ActualWidth;
                VortexModifierPosition.Slider2.Maximum = ParticleVisualisation.ActualHeight;
            }
            else
            {
                VortexModifierStackPanel.Visibility = Visibility.Collapsed;
                RAZVortexModifierValues();
            }

            ActualizeMyGame();
        }

        private void ListViewImagesToPaticles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView list = (ListView)sender;
            Image img = (Image)list.SelectedItem;
            if (img != null)
            {
                string fullImagePath = img.Source.ToString();
                TextureRegionDefinition.TextBox.Text = GetFileNameOnly(fullImagePath);
            }
        }

        private void MouseClickMode_Click(object sender, RoutedEventArgs e)
        {
            ActualizeMyGame();
            myGame.ParticleMode = false;
            if(myGame.ListParticlesEffect.Count > 0)
                myGame.ListParticlesEffect.Clear();
            SliderFloatParticleMode.Slider.IsEnabled = false;
            SliderFloatParticleMode.TextBoxValue.IsEnabled = false;
        }

        private void AutoParticleMode_Click(object sender, RoutedEventArgs e)
        {
            ActualizeMyGame();
            myGame.ParticleMode = true;
            if (myGame.ListParticlesEffect.Count > 0)
                myGame.ListParticlesEffect.Clear();
            SliderFloatParticleMode.Slider.IsEnabled = true;
            SliderFloatParticleMode.TextBoxValue.IsEnabled = true;
        }

        private void ImageList()
        {
            var extensions = new List<string> { ".jpg", ".jpeg", ".bmp", ".png" };
            var filePaths = Directory.GetFiles(imagesFolder).Where(s => extensions.Contains(Path.GetExtension(s)));

            imagesCollection.Clear();

            if (imagesFolder.Length > 0)
            {
                foreach (string file in filePaths)
                {
                    BitmapImage bm = new BitmapImage(new Uri(file));
                    Image im = new Image();
                    im.Source = bm;
                    im.Width = 200;
                    im.Height = 200;
                    imagesCollection.Add(im);
                }
            }

            ListViewImagesToPaticles.DataContext = imagesCollection;
        }

        private string GetFileNameOnly(string fullImagePath)
        {
            if (fullImagePath.Contains("/"))
                return fullImagePath.Substring(fullImagePath.LastIndexOf('/') + 1);
            else if (fullImagePath.Contains("\\"))
                return fullImagePath.Substring(fullImagePath.LastIndexOf('\\') + 1);

            return fullImagePath;
        }

        private void ButtonTexturesBrowser_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = string.Empty;
            TextBoxTexturesBrowser.Text = string.Empty;
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagesFolder = folderBrowserDialog1.SelectedPath;
                ImageList();
                TextBoxTexturesBrowser.Text = folderBrowserDialog1.SelectedPath + '\\' + fileName;
            }
        }
    }
}
