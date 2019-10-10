//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Controls;
//using System.Xml;

//namespace HomeParticlesSoftware
//{
//    public class XMLFile
//    {
//        private XmlDocument xmlFile;

//        private void RAZDefinitions()
//        {
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxFill']/Width").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxFill']/Height").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Box']/Width").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Box']/Height").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxUniform']/Width").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxUniform']/Height").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Circle']/Radius").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Circle']/Radiate").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Line']/Axis").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Line']/Length").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Point']/IsPoint").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Ring']/Radius").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Ring']/Radiate").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Spray']/Direction").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Spray']/Spread").InnerText = "";
//        }

//        private void RAZContainers()
//        {
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Inside").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Radius").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/RestitutionCoefficient").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Height").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Width").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/RestitutionCoefficient").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Height").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Width").InnerText = "";
//        }

//        private void RAZAgeModifier()
//        {
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText = "";
//        }

//        private void RAZVelocityModifier()
//        {
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/EndValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/Name").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText = "";
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText = "";
//        }

//        public XMLFile(string path)
//        {
//            xmlFile = new XmlDocument();

//            //Load empty template by default
//            xmlFile.Load(path);
//        }

//        public void Load()
//        {
//            //Load Informations datas
//            NameInformations.TextBox.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Name").InnerText;
//            AuthorInformation.TextBox.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Author").InnerText;
//            DescriptionInformation.TextBox.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Description").InnerText;
//            VersionInformation.TextBox.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Version").InnerText;

//            //Load Definitions datas
//            NameDefinition.TextBox.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Name").InnerText;
//            TextureRegionDefinition.TextBox.Text = GetFileNameOnly(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/TextureRegion").InnerText);
//            sliderCapacityDefinitions.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Capacity").InnerText;
//            sliderLifeSpanDefinitions.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/LifeSpan/FromMilliseconds").InnerText;

//            //Load Profiles datas
//            XmlNodeList profilesNodes = xmlFile.SelectNodes("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile");

//            foreach (XmlNode profile in profilesNodes)
//            {
//                if (profile.InnerText != string.Empty)
//                {
//                    switch (profile.SelectSingleNode("@Type").Value)
//                    {
//                        case "BoxFill":
//                            // SetProfileDetailsBoxes("Width", "Height");
//                            foreach (ComboBoxItem type in comboBoxProfils.ComboBoxProfileDefinitions.Items)
//                                if (type.Name == profile.SelectSingleNode("@Type").InnerText)
//                                    comboBoxProfils.ComboBoxProfileDefinitions.SelectedValue = type;

//                            txtBox1.Text = profile.SelectNodes("*")[0].InnerText;
//                            txtBox2.Text = profile.SelectNodes("*")[1].InnerText;
//                            break;
//                        case "Box":
//                            // SetProfileDetailsBoxes("Width", "Height");
//                            foreach (ComboBoxItem type in comboBoxProfils.ComboBoxProfileDefinitions.Items)
//                                if (type.Name == profile.SelectSingleNode("@Type").InnerText)
//                                    comboBoxProfils.ComboBoxProfileDefinitions.SelectedValue = type;

//                            txtBox1.Text = profile.SelectNodes("*")[0].InnerText;
//                            txtBox2.Text = profile.SelectNodes("*")[1].InnerText;
//                            break;
//                        case "BoxUniform":
//                            //  SetProfileDetailsBoxes("Width", "Height");
//                            foreach (ComboBoxItem type in comboBoxProfils.ComboBoxProfileDefinitions.Items)
//                                if (type.Name == profile.SelectSingleNode("@Type").InnerText)
//                                    comboBoxProfils.ComboBoxProfileDefinitions.SelectedValue = type;

//                            txtBox1.Text = profile.SelectNodes("*")[0].InnerText;
//                            txtBox2.Text = profile.SelectNodes("*")[1].InnerText;
//                            break;
//                        case "Circle":
//                            // SetProfileDetailsRingAndCircle("Radius", "Radiate");

//                            foreach (ComboBoxItem type in comboBoxProfils.ComboBoxProfileDefinitions.Items)
//                                if (type.Name == profile.SelectSingleNode("@Type").InnerText)
//                                    comboBoxProfils.ComboBoxProfileDefinitions.SelectedValue = type;
//                            break;
//                        case "Line":
//                            // SetProfileDetailsLineAndSpray("Axis", "Length");

//                            foreach (ComboBoxItem type in comboBoxProfils.ComboBoxProfileDefinitions.Items)
//                                if (type.Name == profile.SelectSingleNode("@Type").InnerText)
//                                    comboBoxProfils.ComboBoxProfileDefinitions.SelectedValue = type;
//                            break;
//                        case "Point":
//                            break;
//                        case "Ring":
//                            //SetProfileDetailsRingAndCircle("Radius", "Radiate");

//                            foreach (ComboBoxItem type in comboBoxProfils.ComboBoxProfileDefinitions.Items)
//                                if (type.Name == profile.SelectSingleNode("@Type").Value)
//                                    comboBoxProfils.ComboBoxProfileDefinitions.SelectedValue = type;
//                            break;
//                        case "Spray":
//                            //SetProfileDetailsLineAndSpray("Direction", "Spread");

//                            foreach (ComboBoxItem type in comboBoxProfils.ComboBoxProfileDefinitions.Items)
//                                if (type.Name == profile.SelectSingleNode("@Type").InnerText)
//                                    comboBoxProfils.ComboBoxProfileDefinitions.SelectedValue = type;
//                            break;
//                    }
//                }
//            }

//            //Load Parameters datas
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Min").InnerText != string.Empty)
//            {
//                emitterParameters.ColorEmitterParametersMin.TextBoxRColor.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Min").InnerText.Split(',')[0];
//                emitterParameters.ColorEmitterParametersMin.TextBoxGColor.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Min").InnerText.Split(',')[1];
//                emitterParameters.ColorEmitterParametersMin.TextBoxBColor.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Min").InnerText.Split(',')[2];
//            }

//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Max").InnerText != string.Empty)
//            {
//                emitterParameters.ColorEmitterParametersMax.TextBoxRColor.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Max").InnerText.Split(',')[0];
//                emitterParameters.ColorEmitterParametersMax.TextBoxGColor.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Max").InnerText.Split(',')[1];
//                emitterParameters.ColorEmitterParametersMax.TextBoxBColor.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Max").InnerText.Split(',')[2];
//            }

//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Min").InnerText))
//                emitterParameters.MassEmitterParametersMin.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Min").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Max").InnerText))
//                emitterParameters.MassEmitterParametersMax.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Max").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Min").InnerText))
//                emitterParameters.OpacityEmitterParametersMin.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Min").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Max").InnerText))
//                emitterParameters.OpacityEmitterParametersMax.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Max").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Min").InnerText))
//                emitterParameters.QuantityEmitterParametersMin.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Min").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Max").InnerText))
//                emitterParameters.QuantityEmitterParametersMax.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Max").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Min").InnerText))
//                emitterParameters.RotationEmitterParametersMin.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Min").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Max").InnerText))
//                emitterParameters.RotationEmitterParametersMax.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Max").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Min").InnerText))
//                emitterParameters.ScaleEmitterParametersMin.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Min").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Max").InnerText))
//                emitterParameters.ScaleEmitterParametersMax.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Max").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Min").InnerText))
//                emitterParameters.SpeedEmitterParametersMin.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Min").InnerText;
//            if (!string.IsNullOrEmpty(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Max").InnerText))
//                emitterParameters.SpeedEmitterParametersMax.TextBoxValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Max").InnerText;

//            //Load Containers datas
//            XmlNodeList containersNodes = xmlFile.SelectNodes("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier");

//            foreach (XmlNode modifier in containersNodes)
//            {
//                if (modifier.InnerText != string.Empty)
//                {
//                    switch (modifier.SelectSingleNode("@Type").Value)
//                    {
//                        case "CircleContainerModifier":

//                            //    foreach (ComboBoxItem type in ComboBoxContainersModifier.Items)
//                            //    if (type.Name == modifier.SelectSingleNode("@Type").InnerText)
//                            //        ComboBoxContainersModifier.SelectedValue = type;
//                            break;
//                        case "RectangleContainerModifier":

//                            // foreach (ComboBoxItem type in ComboBoxContainersModifier.Items)
//                            //     if (type.Name == modifier.SelectSingleNode("@Type").InnerText)
//                            //         ComboBoxContainersModifier.SelectedValue = type;
//                            break;
//                        case "RectangleLoopContainerModifier":

//                            //  foreach (ComboBoxItem type in ComboBoxContainersModifier.Items)
//                            //    if (type.Name == modifier.SelectSingleNode("@Type").InnerText)
//                            //         ComboBoxContainersModifier.SelectedValue = type;
//                            break;
//                    }
//                }
//            }

//            //Load AgeModifier datas
//            XmlNodeList AgeModifierNodes = xmlFile.SelectNodes("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/*");

//            foreach (XmlNode modifier in AgeModifierNodes)
//            {
//                if (modifier.InnerText != string.Empty)
//                {
//                    switch (modifier.SelectSingleNode(".").Name)
//                    {
//                        // case "ColorInterpolator":

//                        //    SetColorsInterpolator();

//                        //  foreach (ComboBoxItem type in AgeModifierInterpolators.Items)
//                        //     if (type.Name == modifier.SelectSingleNode(".").Name)
//                        //        AgeModifierInterpolators.SelectedValue = type;

//                        /*     textBoxColorInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/Name").InnerText;

//                             double val1;
//                             double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/StartValue").InnerText.Split(',')[0], out val1);
//                             sliderStartRed.Value = val1;
//                             double val2;
//                             double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/StartValue").InnerText.Split(',')[1], out val2);
//                             sliderStartGreen.Value = val2;
//                             double val3;
//                             double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/StartValue").InnerText.Split(',')[2], out val3);
//                             sliderStartBlue.Value = val3;

//                             double val4;
//                             double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/EndValue").InnerText.Split(',')[0], out val4);
//                             sliderEndRed.Value = val4;
//                             double val5;
//                             double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/EndValue").InnerText.Split(',')[1], out val5);
//                             sliderEndGreen.Value = val5;
//                             double val6;
//                             double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/EndValue").InnerText.Split(',')[2], out val6);
//                             sliderEndBlue.Value = val6;

//                             break;
//                         case "HueInterpolator":

//                             //    SetHORInterpolator();
//                          //   foreach (ComboBoxItem type in AgeModifierInterpolators.Items)
//                          //       if (type.Name == modifier.SelectSingleNode(".").Name)
//                           //          AgeModifierInterpolators.SelectedValue = type;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/Name").InnerText != string.Empty)
//                                 textBoxHORInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/Name").InnerText;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/StartValue").InnerText != string.Empty)
//                                 textboxHORStartValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/StartValue").InnerText;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/EndValue").InnerText != string.Empty)
//                                 textboxHOREndValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/EndValue").InnerText;

//                             break;
//                         case "OpacityInterpolator":

//                             //    SetHORInterpolator();
//                           //  foreach (ComboBoxItem type in AgeModifierInterpolators.Items)
//                           //      if (type.Name == modifier.SelectSingleNode(".").Name)
//                            //         AgeModifierInterpolators.SelectedValue = type;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/Name").InnerText != string.Empty)
//                                 textBoxHORInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/Name").InnerText;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText != string.Empty)
//                                 textboxHORStartValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText != string.Empty)
//                                 textboxHOREndValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText;

//                             break;
//                         case "RotationInterpolator":

//                             //     SetHORInterpolator();
//                           //  foreach (ComboBoxItem type in AgeModifierInterpolators.Items)
//                          //       if (type.Name == modifier.SelectSingleNode(".").Name)
//                           //          AgeModifierInterpolators.SelectedValue = type;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/Name").InnerText != string.Empty)
//                                 textBoxHORInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/Name").InnerText;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/StartValue").InnerText != string.Empty)
//                                 textboxHORStartValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/StartValue").InnerText;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/EndValue").InnerText != string.Empty)
//                                 textboxHOREndValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/EndValue").InnerText;

//                             break;
//                         case "ScaleInterpolator":

//                             //    SetScaleInterpolator();
//                         //    foreach (ComboBoxItem type in AgeModifierInterpolators.Items)
//                         //        if (type.Name == modifier.SelectSingleNode(".").Name)
//                          //           AgeModifierInterpolators.SelectedValue = type;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/Name").InnerText != string.Empty)
//                                 textBoxScaleInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/Name").InnerText;

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText != string.Empty)
//                             {
//                                 textBoxScaleInterpolatorStartX.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText.Split(',')[0];
//                                 textBoxScaleInterpolatorStartY.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText.Split(',')[1];
//                             }

//                             if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText != string.Empty)
//                             {
//                                 textBoxScaleInterpolatorEndX.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText.Split(',')[0];
//                                 textBoxScaleInterpolatorEndY.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText.Split(',')[1];
//                             }

//                             break;*/
//                    }
//                }
//            }

//            //Load DragModifier
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Name").InnerText != string.Empty)
//            {
//                // TextBoxDragCoefficientName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Name").InnerText;
//                // CheckBoxAllowDragMidifier.IsChecked = true;
//            }

//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/DragCoefficient").InnerText != string.Empty)
//            {
//                // TextBoxDragCoefficientDragModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/DragCoefficient").InnerText;
//                //  CheckBoxAllowDragMidifier.IsChecked = true;
//            }

//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Density").InnerText != string.Empty)
//            {
//                // TextBoxDensityDragModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Density").InnerText;
//                // CheckBoxAllowDragMidifier.IsChecked = true;
//            }

//            //Load LinearGravityModifier
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Name").InnerText != string.Empty)
//            {
//                // TextBoxLinearGravityModifierName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Name").InnerText;
//                // CheckBoxAllowLinearGravityModifier.IsChecked = true;
//            }
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Direction").InnerText != string.Empty)
//            {
//                // TextBoxLinearGravityModifierX.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Direction").InnerText.Split(',')[0];
//                // TextBoxLinearGravityModifierY.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Direction").InnerText.Split(',')[1];
//                //  CheckBoxAllowLinearGravityModifier.IsChecked = true;
//            }
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Strength").InnerText != string.Empty)
//            {
//                // TextBoxStrengthDragModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Strength").InnerText;
//                // CheckBoxAllowLinearGravityModifier.IsChecked = true;
//            }

//            //Load OpacityFastFadeModifier
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='OpacityFastFadeModifier']/Name").InnerText != string.Empty)
//            {
//                // OpacityFastFadeModifierName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='OpacityFastFadeModifier']/Name").InnerText;
//                // CheckBoxAllowOpacityFastFadeModifier.IsChecked = true;
//            }

//            //Load RotationModifier
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/Name").InnerText != string.Empty)
//            {
//                // TextBoxRotationModifierName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/Name").InnerText;
//                // CheckBoxAllowRotationModifier.IsChecked = true;
//            }
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/RotationRate").InnerText != string.Empty)
//            {
//                // TextBoxRotationModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/RotationRate").InnerText;
//                //  CheckBoxAllowRotationModifier.IsChecked = true;
//            }

//            //Load VelocityColorModifier
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/Name").InnerText != string.Empty)
//            {
//                // TextBoxVelocityColorModifierName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/Name").InnerText;
//                // CheckBoxAllowVelocityColorModifier.IsChecked = true;
//            }
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/StationaryColor").InnerText != string.Empty)
//            {
//                // TextBoxRStationaryColorModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/StationaryColor").InnerText.Split(',')[0];
//                //  CheckBoxAllowVelocityColorModifier.IsChecked = true;

//                // TextBoxGStationaryColorModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/StationaryColor").InnerText.Split(',')[1];
//                //  CheckBoxAllowVelocityColorModifier.IsChecked = true;

//                // TextBoxBStationaryColorModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/StationaryColor").InnerText.Split(',')[2];
//                // CheckBoxAllowVelocityColorModifier.IsChecked = true;
//            }
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityColor").InnerText != string.Empty)
//            {
//                //  TextBoxRVelocityColorModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityColor").InnerText.Split(',')[0];
//                //  CheckBoxAllowVelocityColorModifier.IsChecked = true;

//                //  TextBoxGVelocityColorModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityColor").InnerText.Split(',')[1];
//                //  CheckBoxAllowVelocityColorModifier.IsChecked = true;

//                // TextBoxBVelocityColorModifier.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityColor").InnerText.Split(',')[2];
//                // CheckBoxAllowVelocityColorModifier.IsChecked = true;
//            }
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityThreshold").InnerText != string.Empty)
//            {
//                // TextBoxVelocityThreshold.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityThreshold").InnerText;
//                // CheckBoxAllowVelocityColorModifier.IsChecked = true;
//            }
//            /*
//                        //Load VelocityModifier
//                        XmlNodeList VelocityModifierNodes = xmlFile.SelectNodes("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/*");

//                        foreach (XmlNode modifier in VelocityModifierNodes)
//                        {
//                            if (modifier.InnerText != string.Empty)
//                            {
//                                CheckBoxVelocityInterpolators.IsChecked = true;

//                                switch (modifier.SelectSingleNode(".").Name)
//                                {
//                                    case "ColorInterpolator":

//                                       // SetColorsInterpolator(stackPanelVelocityInterpolatorsName, stackPanel1VelocityInterpolatorsModifiers, stackPanel2VelocityInterpolatorsModifiers, stackPanel3VelocityInterpolatorsModifiers, stackPanel4VelocityInterpolatorsModifiers, stackPanel5VelocityInterpolatorsModifiers, stackPanel6VelocityInterpolatorsModifiers, stackPanel7VelocityInterpolatorsModifiers, stackPanel8VelocityInterpolatorsModifiers);

//                                        StackPanel stackPanelHorizontal = new StackPanel();
//                                        stackPanelHorizontal.Orientation = Orientation.Horizontal;

//                                        Label labelVelocityThreshold = new Label();
//                                        labelVelocityThreshold.HorizontalAlignment = HorizontalAlignment.Right;
//                                        labelVelocityThreshold.VerticalAlignment = VerticalAlignment.Center;
//                                        labelVelocityThreshold.Margin = new Thickness(2.5);
//                                        labelVelocityThreshold.Content = "VelocityThreshold";

//                                        stackPanelHorizontal.Children.Add(labelVelocityThreshold);

//                                        textBoxVelocityThreshold = new TextBox();
//                                        textBoxVelocityThreshold.IsReadOnly = false;
//                                        textBoxVelocityThreshold.Width = 100;
//                                        textBoxVelocityThreshold.TextAlignment = TextAlignment.Center;
//                                        textBoxVelocityThreshold.HorizontalAlignment = HorizontalAlignment.Center;
//                                        textBoxVelocityThreshold.VerticalAlignment = VerticalAlignment.Center;
//                                        stackPanelHorizontal.Children.Add(textBoxVelocityThreshold);

//                                        stackPanelVelocityInterpolatorsName.Children.Add(stackPanelHorizontal);

//                                        foreach (ComboBoxItem type in VelocityModifierInterpolators.Items) 
//                                            if ((string)type.Content == modifier.SelectSingleNode(".").Name)
//                                                VelocityModifierInterpolators.SelectedValue = type;

//                                        textBoxColorInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/Name").InnerText;

//                                        double val1;
//                                        double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/StartValue").InnerText.Split(',')[0], out val1);
//                                        sliderStartRed.Value = val1;
//                                        double val2;
//                                        double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/StartValue").InnerText.Split(',')[1], out val2);
//                                        sliderStartGreen.Value = val2;
//                                        double val3;
//                                        double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/StartValue").InnerText.Split(',')[2], out val3);
//                                        sliderStartBlue.Value = val3;

//                                        double val4;
//                                        double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/EndValue").InnerText.Split(',')[0], out val4);
//                                        sliderEndRed.Value = val4;
//                                        double val5;
//                                        double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/EndValue").InnerText.Split(',')[1], out val5);
//                                        sliderEndGreen.Value = val5;
//                                        double val6;
//                                        double.TryParse(xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/EndValue").InnerText.Split(',')[2], out val6);
//                                        sliderEndBlue.Value = val6;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText != string.Empty)
//                                            textBoxVelocityThreshold.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText;
//                                        break;
//                                    case "HueInterpolator":

//                                        SetHORInterpolator(stackPanelVelocityInterpolatorsName, stackPanel1VelocityInterpolatorsModifiers, stackPanel2VelocityInterpolatorsModifiers, stackPanel3VelocityInterpolatorsModifiers, stackPanel4VelocityInterpolatorsModifiers, stackPanel5VelocityInterpolatorsModifiers, stackPanel6VelocityInterpolatorsModifiers, stackPanel7VelocityInterpolatorsModifiers, stackPanel8VelocityInterpolatorsModifiers);

//                                        StackPanel stackPanelHorizontal2 = new StackPanel();
//                                        stackPanelHorizontal2.Orientation = Orientation.Horizontal;

//                                        Label labelVelocityThreshold2 = new Label();
//                                        labelVelocityThreshold2.HorizontalAlignment = HorizontalAlignment.Right;
//                                        labelVelocityThreshold2.VerticalAlignment = VerticalAlignment.Center;
//                                        labelVelocityThreshold2.Margin = new Thickness(2.5);
//                                        labelVelocityThreshold2.Content = "VelocityThreshold";

//                                        stackPanelHorizontal2.Children.Add(labelVelocityThreshold2);

//                                        textBoxVelocityThreshold = new TextBox();
//                                        textBoxVelocityThreshold.IsReadOnly = false;
//                                        textBoxVelocityThreshold.Width = 100;
//                                        textBoxVelocityThreshold.TextAlignment = TextAlignment.Center;
//                                        textBoxVelocityThreshold.HorizontalAlignment = HorizontalAlignment.Center;
//                                        textBoxVelocityThreshold.VerticalAlignment = VerticalAlignment.Center;
//                                        stackPanelHorizontal2.Children.Add(textBoxVelocityThreshold);

//                                        stackPanelVelocityInterpolatorsName.Children.Add(stackPanelHorizontal2);

//                                        foreach (ComboBoxItem type in VelocityModifierInterpolators.Items)
//                                            if ((string)type.Content == modifier.SelectSingleNode(".").Name)
//                                                VelocityModifierInterpolators.SelectedValue = type;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/Name").InnerText != string.Empty)
//                                            textBoxHORInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/Name").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/StartValue").InnerText != string.Empty)
//                                            textboxHORStartValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/StartValue").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/EndValue").InnerText != string.Empty)
//                                            textboxHOREndValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/EndValue").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText != string.Empty)
//                                            textBoxVelocityThreshold.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText;
//                                        break;
//                                    case "OpacityInterpolator":

//                                        SetHORInterpolator(stackPanelVelocityInterpolatorsName, stackPanel1VelocityInterpolatorsModifiers, stackPanel2VelocityInterpolatorsModifiers, stackPanel3VelocityInterpolatorsModifiers, stackPanel4VelocityInterpolatorsModifiers, stackPanel5VelocityInterpolatorsModifiers, stackPanel6VelocityInterpolatorsModifiers, stackPanel7VelocityInterpolatorsModifiers, stackPanel8VelocityInterpolatorsModifiers);

//                                        StackPanel stackPanelHorizontal3 = new StackPanel();
//                                        stackPanelHorizontal3.Orientation = Orientation.Horizontal;

//                                        Label labelVelocityThreshold3 = new Label();
//                                        labelVelocityThreshold3.HorizontalAlignment = HorizontalAlignment.Right;
//                                        labelVelocityThreshold3.VerticalAlignment = VerticalAlignment.Center;
//                                        labelVelocityThreshold3.Margin = new Thickness(2.5);
//                                        labelVelocityThreshold3.Content = "VelocityThreshold";

//                                        stackPanelHorizontal3.Children.Add(labelVelocityThreshold3);

//                                        textBoxVelocityThreshold = new TextBox();
//                                        textBoxVelocityThreshold.IsReadOnly = false;
//                                        textBoxVelocityThreshold.Width = 100;
//                                        textBoxVelocityThreshold.TextAlignment = TextAlignment.Center;
//                                        textBoxVelocityThreshold.HorizontalAlignment = HorizontalAlignment.Center;
//                                        textBoxVelocityThreshold.VerticalAlignment = VerticalAlignment.Center;
//                                        stackPanelHorizontal3.Children.Add(textBoxVelocityThreshold);

//                                        stackPanelVelocityInterpolatorsName.Children.Add(stackPanelHorizontal3);

//                                        foreach (ComboBoxItem type in VelocityModifierInterpolators.Items)
//                                            if ((string)type.Content == modifier.SelectSingleNode(".").Name)
//                                                VelocityModifierInterpolators.SelectedValue = type;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/Name").InnerText != string.Empty)
//                                            textBoxHORInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/Name").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText != string.Empty)
//                                            textboxHORStartValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText != string.Empty)
//                                            textboxHOREndValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText != string.Empty)
//                                            textBoxVelocityThreshold.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText;
//                                        break;
//                                    case "RotationInterpolator":

//                                        SetHORInterpolator(stackPanelVelocityInterpolatorsName, stackPanel1VelocityInterpolatorsModifiers, stackPanel2VelocityInterpolatorsModifiers, stackPanel3VelocityInterpolatorsModifiers, stackPanel4VelocityInterpolatorsModifiers, stackPanel5VelocityInterpolatorsModifiers, stackPanel6VelocityInterpolatorsModifiers, stackPanel7VelocityInterpolatorsModifiers, stackPanel8VelocityInterpolatorsModifiers);

//                                        StackPanel stackPanelHorizontal4 = new StackPanel();
//                                        stackPanelHorizontal4.Orientation = Orientation.Horizontal;

//                                        Label labelVelocityThreshold4 = new Label();
//                                        labelVelocityThreshold4.HorizontalAlignment = HorizontalAlignment.Right;
//                                        labelVelocityThreshold4.VerticalAlignment = VerticalAlignment.Center;
//                                        labelVelocityThreshold4.Margin = new Thickness(2.5);
//                                        labelVelocityThreshold4.Content = "VelocityThreshold";

//                                        stackPanelHorizontal4.Children.Add(labelVelocityThreshold4);

//                                        textBoxVelocityThreshold = new TextBox();
//                                        textBoxVelocityThreshold.IsReadOnly = false;
//                                        textBoxVelocityThreshold.Width = 100;
//                                        textBoxVelocityThreshold.TextAlignment = TextAlignment.Center;
//                                        textBoxVelocityThreshold.HorizontalAlignment = HorizontalAlignment.Center;
//                                        textBoxVelocityThreshold.VerticalAlignment = VerticalAlignment.Center;
//                                        stackPanelHorizontal4.Children.Add(textBoxVelocityThreshold);

//                                        stackPanelVelocityInterpolatorsName.Children.Add(stackPanelHorizontal4);

//                                        foreach (ComboBoxItem type in VelocityModifierInterpolators.Items)
//                                            if ((string)type.Content == modifier.SelectSingleNode(".").Name)
//                                                VelocityModifierInterpolators.SelectedValue = type;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/Name").InnerText != string.Empty)
//                                            textBoxHORInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/Name").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/StartValue").InnerText != string.Empty)
//                                            textboxHORStartValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/StartValue").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/EndValue").InnerText != string.Empty)
//                                            textboxHOREndValue.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/EndValue").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText != string.Empty)
//                                            textBoxVelocityThreshold.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText;
//                                        break;
//                                    case "ScaleInterpolator":

//                                        SetScaleInterpolator(stackPanelVelocityInterpolatorsName, stackPanel1VelocityInterpolatorsModifiers, stackPanel2VelocityInterpolatorsModifiers, stackPanel3VelocityInterpolatorsModifiers, stackPanel4VelocityInterpolatorsModifiers, stackPanel5VelocityInterpolatorsModifiers, stackPanel6VelocityInterpolatorsModifiers, stackPanel7VelocityInterpolatorsModifiers, stackPanel8VelocityInterpolatorsModifiers);

//                                        StackPanel stackPanelHorizontal5 = new StackPanel();
//                                        stackPanelHorizontal5.Orientation = Orientation.Horizontal;

//                                        Label labelVelocityThreshold5 = new Label();
//                                        labelVelocityThreshold5.HorizontalAlignment = HorizontalAlignment.Right;
//                                        labelVelocityThreshold5.VerticalAlignment = VerticalAlignment.Center;
//                                        labelVelocityThreshold5.Margin = new Thickness(2.5);
//                                        labelVelocityThreshold5.Content = "VelocityThreshold";

//                                        stackPanelHorizontal5.Children.Add(labelVelocityThreshold5);

//                                        textBoxVelocityThreshold = new TextBox();
//                                        textBoxVelocityThreshold.IsReadOnly = false;
//                                        textBoxVelocityThreshold.Width = 100;
//                                        textBoxVelocityThreshold.TextAlignment = TextAlignment.Center;
//                                        textBoxVelocityThreshold.HorizontalAlignment = HorizontalAlignment.Center;
//                                        textBoxVelocityThreshold.VerticalAlignment = VerticalAlignment.Center;
//                                        stackPanelHorizontal5.Children.Add(textBoxVelocityThreshold);

//                                        stackPanelVelocityInterpolatorsName.Children.Add(stackPanelHorizontal5);

//                                        foreach (ComboBoxItem type in VelocityModifierInterpolators.Items)
//                                            if ((string)type.Content == modifier.SelectSingleNode(".").Name)
//                                                VelocityModifierInterpolators.SelectedValue = type;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/Name").InnerText != string.Empty)
//                                            textBoxScaleInterpolatorName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/Name").InnerText;

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText != string.Empty)
//                                        {
//                                            textBoxScaleInterpolatorStartX.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText.Split(',')[0];
//                                            textBoxScaleInterpolatorStartY.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText.Split(',')[1];
//                                        }

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText != string.Empty)
//                                        {
//                                            textBoxScaleInterpolatorEndX.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText.Split(',')[0];
//                                            textBoxScaleInterpolatorEndY.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText.Split(',')[1];
//                                        }

//                                        if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText != string.Empty)
//                                            textBoxVelocityThreshold.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText;
//                                            break;
//                                }
//                            }
//                        }
//                        */
//            //Load VortexModifier
//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Name").InnerText != string.Empty)
//            {
//                // TextBoxVortexModifierName.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Name").InnerText;
//                // CheckBoxAllowVortexModifier.IsChecked = true;
//            }

//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Mass").InnerText != string.Empty)
//            {
//                // TextBoxMass.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Mass").InnerText;
//                // CheckBoxAllowVortexModifier.IsChecked = true;
//            }


//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/MaxSpeed").InnerText != string.Empty)
//            {
//                //  TextBoxMaxSpeed.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/MaxSpeed").InnerText;
//                // CheckBoxAllowVortexModifier.IsChecked = true;
//            }

//            if (xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Position").InnerText != string.Empty)
//            {
//                // TextBoxVortexModifierX.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Position").InnerText.Split(',')[0];
//                // TextBoxVortexModifierY.Text = xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Position").InnerText.Split(',')[1];
//                // CheckBoxAllowVortexModifier.IsChecked = true;
//            }
//        }

//        public void Save()
//        {
//            if (fileName == null)
//            {
//                var directoryExplore = new Microsoft.Win32.SaveFileDialog() { Filter = "XML Files (*.xml} | *.xml" };
//                directoryExplore.InitialDirectory = @"E:\GameDevelop\ParticlesEngineMine\WpfApp1\WpfApp1\xml\";
//                var result = directoryExplore.ShowDialog();
//                if (result == false) return;

//                fileName = directoryExplore.FileName;
//                xmlFile = new XmlDocument();

//                string content = File.ReadAllText(fileEmpty);

//                File.WriteAllText(fileName, string.Empty);
//                File.AppendAllText(fileName, content);

//                xmlFile.Load(fileName);
//            }

//            //Save Informations datas
//            xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Name").InnerText = NameInformations.TextBox.Text;
//            xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Author").InnerText = AuthorInformation.TextBox.Text;
//            xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Description").InnerText = DescriptionInformation.TextBox.Text;
//            xmlFile.SelectSingleNode("ParticlesConfiguration/Informations/Version").InnerText = VersionInformation.TextBox.Text;

//            //Save Definitions datas
//            xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Name").InnerText = NameDefinition.TextBox.Text;

//            if (TextureRegionDefinition.TextBox.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/TextureRegion").InnerText = imagesFolder + TextureRegionDefinition.TextBox.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/TextureRegion").InnerText = string.Empty;

//            if (sliderCapacityDefinitions.TextBoxValue.Text != "0")
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Capacity").InnerText = sliderCapacityDefinitions.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Capacity").InnerText = string.Empty;

//            if (sliderLifeSpanDefinitions.TextBoxValue.Text != "0")
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/LifeSpan/FromMilliseconds").InnerText = sliderLifeSpanDefinitions.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/LifeSpan/FromMilliseconds").InnerText = string.Empty;

//            float val = 0f;
//            RAZDefinitions();
//            switch (comboBoxProfils.ComboBoxProfileDefinitions.Text)
//            {
//                case "BoxFill":
//                    if (float.TryParse(txtBoxval1, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxFill']/Width").InnerText = txtBoxval1;

//                    if (float.TryParse(txtBoxval2, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxFill']/Height").InnerText = txtBoxval2;
//                    break;
//                case "Box":
//                    if (float.TryParse(txtBoxval1, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Box']/Width").InnerText = txtBoxval1;

//                    if (float.TryParse(txtBoxval2, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Box']/Height").InnerText = txtBoxval2;
//                    break;
//                case "BoxUniform":
//                    if (float.TryParse(txtBoxval1, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxUniform']/Width").InnerText = txtBoxval1;

//                    if (float.TryParse(txtBoxval2, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='BoxUniform']/Height").InnerText = txtBoxval2;
//                    break;
//                case "Circle":
//                    if (txtBoxval1 != null)
//                        MessageBox.Show(txtBoxval1.ToString());
//                    if (float.TryParse(txtBoxval1, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Circle']/Radius").InnerText = txtBoxval1;

//                    if (combBox.Text != "")
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Circle']/Radiate").InnerText = combBox.Text;
//                    break;
//                case "Line":
//                    if (float.TryParse(txtBoxval1, out val) && float.TryParse(txtBoxval2, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Line']/Axis").InnerText = txtBoxval1 + "," + txtBoxval2;

//                    if (float.TryParse(txtBoxval3, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Line']/Length").InnerText = txtBoxval3;
//                    break;
//                case "Point":
//                    xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Point']/IsPoint").InnerText = IsPoint.ToString();
//                    break;
//                case "Ring":
//                    if (float.TryParse(txtBoxval1, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Ring']/Radius").InnerText = txtBoxval1;

//                    if (combBox.Text != "")
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Ring']/Radiate").InnerText = combBox.Text;
//                    break;
//                case "Spray":
//                    if (float.TryParse(txtBoxval1, out val) && float.TryParse(txtBoxval2, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Spray']/Direction").InnerText = txtBoxval1 + "," + txtBoxval2;

//                    if (float.TryParse(txtBoxval3, out val))
//                        xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Definitions/Profiles/Profile[@Type='Spray']/Spread").InnerText = txtBoxval3;
//                    break;
//            }

//            //Save Parameters datas
//            //RGB Min and Max Color Values
//            if (emitterParameters.ColorEmitterParametersMin.TextBoxRColor.Text != string.Empty
//                && emitterParameters.ColorEmitterParametersMin.TextBoxGColor.Text != string.Empty
//                && emitterParameters.ColorEmitterParametersMin.TextBoxBColor.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Min").InnerText = emitterParameters.ColorEmitterParametersMin.TextBoxRColor.Text + "," + emitterParameters.ColorEmitterParametersMin.TextBoxGColor.Text + "," + emitterParameters.ColorEmitterParametersMin.TextBoxBColor.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Min").InnerText = string.Empty;

//            if (emitterParameters.ColorEmitterParametersMax.TextBoxRColor.Text != string.Empty
//                && emitterParameters.ColorEmitterParametersMax.TextBoxGColor.Text != string.Empty
//                && emitterParameters.ColorEmitterParametersMax.TextBoxBColor.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Max").InnerText = emitterParameters.ColorEmitterParametersMax.TextBoxRColor.Text + "," + emitterParameters.ColorEmitterParametersMax.TextBoxGColor.Text + "," + emitterParameters.ColorEmitterParametersMax.TextBoxBColor.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Color/Max").InnerText = string.Empty;

//            //Mass Min and Max Values
//            if (emitterParameters.MassEmitterParametersMin.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Min").InnerText = emitterParameters.MassEmitterParametersMin.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Min").InnerText = string.Empty;

//            if (emitterParameters.MassEmitterParametersMax.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Max").InnerText = emitterParameters.MassEmitterParametersMax.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Mass/Max").InnerText = string.Empty;


//            //Opacity Min and Max Values
//            if (emitterParameters.OpacityEmitterParametersMin.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Min").InnerText = emitterParameters.OpacityEmitterParametersMin.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Min").InnerText = string.Empty;

//            if (emitterParameters.OpacityEmitterParametersMax.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Max").InnerText = emitterParameters.OpacityEmitterParametersMax.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Opacity/Max").InnerText = string.Empty;

//            //Quantity Min and Max Values
//            if (emitterParameters.QuantityEmitterParametersMin.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Min").InnerText = emitterParameters.QuantityEmitterParametersMin.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Min").InnerText = string.Empty;

//            if (emitterParameters.QuantityEmitterParametersMax.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Max").InnerText = emitterParameters.QuantityEmitterParametersMax.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Quantity/Max").InnerText = string.Empty;

//            //Rotation Min and Max Values
//            if (emitterParameters.RotationEmitterParametersMin.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Min").InnerText = emitterParameters.RotationEmitterParametersMin.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Min").InnerText = string.Empty;

//            if (emitterParameters.RotationEmitterParametersMax.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Max").InnerText = emitterParameters.RotationEmitterParametersMax.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Rotation/Max").InnerText = string.Empty;

//            //Scale Min and Max Values
//            if (emitterParameters.ScaleEmitterParametersMin.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Min").InnerText = emitterParameters.ScaleEmitterParametersMin.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Min").InnerText = string.Empty;

//            if (emitterParameters.ScaleEmitterParametersMax.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Max").InnerText = emitterParameters.ScaleEmitterParametersMax.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Scale/Max").InnerText = string.Empty;

//            //Speed Min and Max Values
//            if (emitterParameters.SpeedEmitterParametersMin.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Min").InnerText = emitterParameters.SpeedEmitterParametersMin.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Min").InnerText = string.Empty;

//            if (emitterParameters.SpeedEmitterParametersMax.TextBoxValue.Text != string.Empty)
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Max").InnerText = emitterParameters.SpeedEmitterParametersMax.TextBoxValue.Text;
//            else
//                xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Parameters/Speed/Max").InnerText = string.Empty;

//            //Save Containers datas
//            /*  if (ComboBoxContainersModifier.Text != string.Empty)
//              {
//                  RAZContainers();
//                  switch (ComboBoxContainersModifier.Text)
//                  {
//                      case "CircleContainerModifier":
//                          if (txtBoxRectangleLoop1.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Name").InnerText = txtBoxRectangleLoop1.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Name").InnerText = string.Empty;

//                          if (combBox.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Inside").InnerText = combBox.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Inside").InnerText = string.Empty;

//                          float val1;
//                          if (float.TryParse(txtBoxRectangleLoop3.Text, out val1))
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Radius").InnerText = txtBoxRectangleLoop3.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/Radius").InnerText = string.Empty;

//                          float val2;
//                          if (float.TryParse(txtBoxRectangleLoop4.Text, out val2))
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/RestitutionCoefficient").InnerText = txtBoxRectangleLoop4.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='CircleContainerModifier']/RestitutionCoefficient").InnerText = string.Empty;

//                          break;
//                      case "RectangleContainerModifier":
//                          xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Name").InnerText = txtBoxRectangleLoop1.Text;
//                          int val3;
//                          if (int.TryParse(txtBoxRectangleLoop2.Text, out val3))
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Width").InnerText = txtBoxRectangleLoop2.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Width").InnerText = string.Empty;

//                          int val4;
//                          if (int.TryParse(txtBoxRectangleLoop3.Text, out val4))
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Height").InnerText = txtBoxRectangleLoop3.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/Height").InnerText = string.Empty;

//                          float val5;
//                          if (float.TryParse(txtBoxRectangleLoop4.Text, out val5))
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/RestitutionCoefficient").InnerText = txtBoxRectangleLoop4.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleContainerModifier']/RestitutionCoefficient").InnerText = string.Empty;

//                          break;
//                      case "RectangleLoopContainerModifier":
//                          xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Name").InnerText = txtBoxRectangleLoop1.Text;
//                          int val6;
//                          if (int.TryParse(txtBoxRectangleLoop2.Text, out val6))
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Width").InnerText = txtBoxRectangleLoop2.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Width").InnerText = string.Empty;

//                          int val7;
//                          if (int.TryParse(txtBoxRectangleLoop3.Text, out val7))
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Height").InnerText = txtBoxRectangleLoop3.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Containers/Modifier[@Type='RectangleLoopContainerModifier']/Height").InnerText = string.Empty;

//                          break;
//                  }
//              }*/

//            //Save Interpolators
//            /*   if (AgeModifierInterpolators.Text != string.Empty)
//               {
//                   RAZAgeModifier();

//                   switch (AgeModifierInterpolators.Text)
//                   {
//                       case "ColorInterpolator":
//                           if (textBoxColorInterpolatorName.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/Name").InnerText = textBoxColorInterpolatorName.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/Name").InnerText = string.Empty;

//                           if (textboxInterpolatorsRedStartValue.Text != string.Empty && textboxInterpolatorsGreenStartValue.Text != string.Empty && textboxInterpolatorsBlueStartValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/StartValue").InnerText = textboxInterpolatorsRedStartValue.Text + "," + textboxInterpolatorsGreenStartValue.Text + "," + textboxInterpolatorsBlueStartValue.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/StartValue").InnerText = string.Empty;

//                           if (textboxInterpolatorsRedEndValue.Text != string.Empty && textboxInterpolatorsGreenEndValue.Text != string.Empty && textboxInterpolatorsBlueEndValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/EndValue").InnerText = textboxInterpolatorsRedEndValue.Text + "," + textboxInterpolatorsGreenEndValue.Text + "," + textboxInterpolatorsBlueEndValue.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ColorInterpolator/EndValue").InnerText = string.Empty;

//                           break;
//                       case "HueInterpolator":
//                           if (textBoxHORInterpolatorName.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/Name").InnerText = textBoxHORInterpolatorName.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/Name").InnerText = string.Empty;

//                           if (textboxHORStartValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/StartValue").InnerText = textboxHORStartValue.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/StartValue").InnerText = string.Empty;

//                           if (textboxHOREndValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/EndValue").InnerText = textboxHOREndValue.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/HueInterpolator/EndValue").InnerText = string.Empty;

//                           break;
//                       case "OpacityInterpolator":
//                           if (textBoxHORInterpolatorName.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/Name").InnerText = textBoxHORInterpolatorName.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/Name").InnerText = string.Empty;

//                           if (textboxHORStartValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText = string.Empty;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText = textboxHORStartValue.Text;

//                           if (textboxHOREndValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText = textboxHOREndValue.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText = string.Empty;

//                           break;
//                       case "RotationInterpolator":
//                           if (textBoxHORInterpolatorName.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/Name").InnerText = textBoxHORInterpolatorName.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/Name").InnerText = string.Empty;
//                           if (textboxHORStartValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/StartValue").InnerText = textboxHORStartValue.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/StartValue").InnerText = string.Empty;

//                           if (textboxHOREndValue.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/EndValue").InnerText = textboxHOREndValue.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/RotationInterpolator/EndValue").InnerText = string.Empty;

//                           break;
//                       case "ScaleInterpolator":
//                           if (textBoxScaleInterpolatorName.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/Name").InnerText = textBoxScaleInterpolatorName.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/Name").InnerText = string.Empty;

//                           if (textBoxScaleInterpolatorStartX.Text != string.Empty && textBoxScaleInterpolatorStartY.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText = textBoxScaleInterpolatorStartX.Text + "," + textBoxScaleInterpolatorStartY.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText = string.Empty;

//                           if (textBoxScaleInterpolatorEndX.Text != string.Empty && textBoxScaleInterpolatorEndY.Text != string.Empty)
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText = textBoxScaleInterpolatorEndX.Text + "," + textBoxScaleInterpolatorEndY.Text;
//                           else
//                               xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='AgeModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText = string.Empty;

//                           break;
//                   }
//               }*/

//            /*  //Save DragModifier            
//              if (TextBoxDragCoefficientName.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Name").InnerText = TextBoxDragCoefficientName.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Name").InnerText = string.Empty;

//              if (TextBoxDragCoefficientDragModifier.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/DragCoefficient").InnerText = TextBoxDragCoefficientDragModifier.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/DragCoefficient").InnerText = string.Empty;

//              if (TextBoxDensityDragModifier.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Density").InnerText = TextBoxDensityDragModifier.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='DragModifier']/Density").InnerText = string.Empty;

//              //Save LinearGravityModifier
//              if (TextBoxLinearGravityModifierName.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Name").InnerText = TextBoxLinearGravityModifierName.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Name").InnerText = string.Empty;

//              if (TextBoxLinearGravityModifierX.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Direction").InnerText = TextBoxLinearGravityModifierX.Text + "," + TextBoxLinearGravityModifierY.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Direction").InnerText = string.Empty;

//              if (TextBoxDensityDragModifier.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Strength").InnerText = TextBoxStrengthDragModifier.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='LinearGravityModifier']/Strength").InnerText = string.Empty;

//              //Save OpacityFastFadeModifier
//              if (CheckBoxAllowOpacityFastFadeModifier.IsChecked == true && OpacityFastFadeModifierName.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='OpacityFastFadeModifier']/Name").InnerText = OpacityFastFadeModifierName.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='OpacityFastFadeModifier']/Name").InnerText = string.Empty;
//              //Save RotationModifier
//              if (CheckBoxAllowRotationModifier.IsChecked == true)
//              {
//                  if (TextBoxRotationModifierName.Text != string.Empty)
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/Name").InnerText = TextBoxRotationModifierName.Text;
//                  else
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/Name").InnerText = string.Empty;

//                  if (TextBoxRotationModifier.Text != string.Empty)
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/RotationRate").InnerText = TextBoxRotationModifier.Text;
//                  else
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='RotationModifier']/RotationRate").InnerText = string.Empty;


//              }

//              //Save VelocityColorModifier
//              if (CheckBoxAllowVelocityColorModifier.IsChecked == true)
//              {
//                  if (TextBoxVelocityColorModifierName.Text != string.Empty)
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/Name").InnerText = TextBoxVelocityColorModifierName.Text;
//                  else
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/Name").InnerText = string.Empty;

//                  if (TextBoxRVelocityColorModifier.Text != string.Empty && TextBoxGVelocityColorModifier.Text != string.Empty && TextBoxBVelocityColorModifier.Text != string.Empty)
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityColor").InnerText = TextBoxRVelocityColorModifier.Text + "," + TextBoxGVelocityColorModifier.Text + "," + TextBoxBVelocityColorModifier.Text;
//                  else
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityColor").InnerText = string.Empty;

//                  if (TextBoxRStationaryColorModifier.Text != string.Empty && TextBoxGStationaryColorModifier.Text != string.Empty && TextBoxBStationaryColorModifier.Text != string.Empty)
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/StationaryColor").InnerText = TextBoxRStationaryColorModifier.Text + "," + TextBoxGStationaryColorModifier.Text + "," + TextBoxBStationaryColorModifier.Text;
//                  else
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/StationaryColor").InnerText = string.Empty;

//                  if (TextBoxVelocityThreshold.Text != string.Empty)
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityThreshold").InnerText = TextBoxVelocityThreshold.Text;
//                  else
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityColorModifier']/VelocityThreshold").InnerText = string.Empty;
//              }

//              //Save VelocityModifier
//              if (VelocityModifierInterpolators.Text != string.Empty)
//              {
//                  RAZVelocityModifier();

//                  if (textBoxVelocityThreshold != null)
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText = textBoxVelocityThreshold.Text;
//                  else
//                      xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/VelocityThreshold").InnerText = string.Empty;

//                  switch (VelocityModifierInterpolators.Text)
//                  {
//                      case "ColorInterpolator":
//                          if (textBoxColorInterpolatorName.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/Name").InnerText = textBoxColorInterpolatorName.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/Name").InnerText = string.Empty;

//                          if (textboxInterpolatorsRedStartValue.Text != string.Empty && textboxInterpolatorsGreenStartValue.Text != string.Empty && textboxInterpolatorsBlueStartValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/StartValue").InnerText = textboxInterpolatorsRedStartValue.Text + "," + textboxInterpolatorsGreenStartValue.Text + "," + textboxInterpolatorsBlueStartValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/StartValue").InnerText = string.Empty;

//                          if (textboxInterpolatorsRedEndValue.Text != string.Empty && textboxInterpolatorsGreenEndValue.Text != string.Empty && textboxInterpolatorsBlueEndValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/EndValue").InnerText = textboxInterpolatorsRedEndValue.Text + "," + textboxInterpolatorsGreenEndValue.Text + "," + textboxInterpolatorsBlueEndValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ColorInterpolator/EndValue").InnerText = string.Empty;

//                          break;
//                      case "HueInterpolator":
//                          if (textBoxHORInterpolatorName.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/Name").InnerText = textBoxHORInterpolatorName.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/Name").InnerText = string.Empty;

//                          if (textboxHORStartValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/StartValue").InnerText = textboxHORStartValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/StartValue").InnerText = string.Empty;

//                          if (textboxHOREndValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/EndValue").InnerText = textboxHOREndValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/HueInterpolator/EndValue").InnerText = string.Empty;

//                          break;
//                      case "OpacityInterpolator":
//                          if (textBoxHORInterpolatorName.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/Name").InnerText = textBoxHORInterpolatorName.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/Name").InnerText = string.Empty;

//                          if (textboxHORStartValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText = textboxHORStartValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/StartValue").InnerText = string.Empty;

//                          if (textboxHOREndValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText = textboxHOREndValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/OpacityInterpolator/EndValue").InnerText = string.Empty;

//                          break;
//                      case "RotationInterpolator":
//                          if (textBoxHORInterpolatorName.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/Name").InnerText = textBoxHORInterpolatorName.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/Name").InnerText = string.Empty;

//                          if (textboxHORStartValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/StartValue").InnerText = textboxHORStartValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/StartValue").InnerText = string.Empty;

//                          if (textboxHOREndValue.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/EndValue").InnerText = textboxHOREndValue.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/RotationInterpolator/EndValue").InnerText = string.Empty;

//                          break;
//                      case "ScaleInterpolator":
//                          if (textBoxScaleInterpolatorName.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/Name").InnerText = textBoxScaleInterpolatorName.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/Name").InnerText = string.Empty;

//                          if (textBoxScaleInterpolatorStartX.Text != string.Empty && textBoxScaleInterpolatorStartY.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText = textBoxScaleInterpolatorStartX.Text + "," + textBoxScaleInterpolatorStartY.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/StartValue").InnerText = string.Empty;

//                          if (textBoxScaleInterpolatorEndX.Text != string.Empty && textBoxScaleInterpolatorEndY.Text != string.Empty)
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText = textBoxScaleInterpolatorEndX.Text + "," + textBoxScaleInterpolatorEndY.Text;
//                          else
//                              xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VelocityModifier']/Interpolators/ScaleInterpolator/EndValue").InnerText = string.Empty;

//                          break;
//                  }
//              }

//              //Save VortexModifier

//              if (TextBoxVortexModifierName.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Name").InnerText = TextBoxVortexModifierName.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Name").InnerText = string.Empty;

//              if (TextBoxMass.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Mass").InnerText = TextBoxMass.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Mass").InnerText = string.Empty;

//              if (TextBoxMaxSpeed.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/MaxSpeed").InnerText = TextBoxMaxSpeed.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/MaxSpeed").InnerText = string.Empty;

//              if (TextBoxVortexModifierX.Text != string.Empty && TextBoxVortexModifierY.Text != string.Empty)
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Position").InnerText = TextBoxVortexModifierX.Text + "," + TextBoxVortexModifierY.Text;
//              else
//                  xmlFile.SelectSingleNode("ParticlesConfiguration/ParticleEffect/Emitters/ParticleEmitter/Modifiers/Modifier[@Type='VortexModifier']/Position").InnerText = string.Empty;
//  */
//            xmlFile.Save(fileName);
//        }
//    }
//}
