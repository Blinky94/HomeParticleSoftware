using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.Particles;
using MonoGame.Extended.Particles.Modifiers;
using MonoGame.Extended.Particles.Modifiers.Containers;
using MonoGame.Extended.Particles.Modifiers.Interpolators;
using MonoGame.Extended.Particles.Profiles;
using MonoGame.Extended.TextureAtlases;
using System;
using System.Collections.Generic;
using System.IO;

namespace HomeParticlesSoftware
{
    public class ParticlesEffect
    {
        public ParticleEffect Particle { get { return particle; } set { particle = value; } }
        private ParticleEffect particle;
        private float lifeSpan;
        private bool isParticleAlive = true;
        public bool IsParticleAlive { get { return isParticleAlive; } }
        private Texture2D texture;
        private TextureRegion2D textureRegion;
        private Vector2 positionParticle;

        private Profile.CircleRadiation GetCircleRadationValue(string radiate)
        {
            Profile.CircleRadiation profile = Profile.CircleRadiation.None;

            switch (radiate)
            {
                case "In":
                    profile = Profile.CircleRadiation.In;
                    break;
                case "None":
                    profile = Profile.CircleRadiation.None;
                    break;
                case "Out":
                    profile = Profile.CircleRadiation.Out;
                    break;
            }

            return profile;
        }

        private float BoxWidth = 0, BoxHeight = 0, BoxFillWidth = 0,  BoxFillHeight = 0, BoxUniformWidth = 0,
            BoxUniformHeight = 0, CircleRadius = 0, LineAxisX = 0,  LineAxisY = 0,  LineLength = 0,  RingRadius = 0,
            SpraySpread = 0,  SprayDirectionX = 0,  SprayDirectionY = 0;

        private string CircleRadiate, RingRadiate;  

        private Profile GetProfile(string profileName)
        {
            switch (profileName)
            {
                case "Box" :
                    return Profile.Box(BoxWidth, BoxHeight);
                case "BoxFill":
                    return Profile.BoxFill(BoxFillWidth, BoxFillHeight);
                case "BoxUniform":
                    return Profile.BoxUniform(BoxUniformWidth, BoxUniformHeight);
                case "Circle":
                    return Profile.Circle(CircleRadius, GetCircleRadationValue(CircleRadiate));
                case "Line":
                    return Profile.Line(new Vector2(LineAxisX, LineAxisY), LineLength);
                case "Ring":
                    return Profile.Ring(RingRadius, GetCircleRadationValue(RingRadiate));
                case "Spray":
                    return Profile.Spray(new Vector2(SprayDirectionX, SprayDirectionY), SpraySpread);
                case "Point":
                    return Profile.Point();
                default:
                    return Profile.Point();
            }
        }

        private Texture2D CreateTexture(GraphicsDevice device, int width, int height, Func<int, Microsoft.Xna.Framework.Color> paint)
        {
            //initialize a texture
            Texture2D texture = new Texture2D(device, width, height);

            //the array holds the color for each pixel in the texture
            Microsoft.Xna.Framework.Color[] data = new Microsoft.Xna.Framework.Color[width * height];
            for (int pixel = 0; pixel < data.Length; pixel++)
            {
                //the function applies the color according to the specified pixel
                data[pixel] = paint(pixel);
            }

            //set the color
            texture.SetData(data);

            return texture;
        }

        public ParticlesEffect(bool IsEmitterParameters,
            string ProfileName, IGraphicsDeviceService graphics, Vector2 Position,         
            string DefinitionsTextureRegion, int DefinitionsCapacity, float LifeSpanFromMilliseconds,              
            float BoxFillWidth, float BoxFillHeight,
            float BoxWidth, float BoxHeight,      
            float BoxUniformWidth, float BoxUniformHeight,
            float CircleRadius, string CircleRadiate,
            float LineAxisX, float LineAxisY, float LineLength,
            bool PointIsPoint,
            float RingRadius, string RingRadiate,
            float SprayDirectionX, float SprayDirectionY, float SpraySpread,
            Microsoft.Xna.Framework.Color ParametersColorMin, float ParametersMassMin, float ParametersOpacityMin, int ParametersQuantityMin, float ParametersRotationMin, float ParametersScaleMin, float ParametersSpeedMin,
            float ParametersMassMax, float ParametersOpacityMax, int ParametersQuantityMax, float ParametersRotationMax, float ParametersScaleMax, float ParametersSpeedMax,
            string ContainerModifierSelectedName,
            bool IsContainerModifierSelected, bool CircleContainerModifierInside, float CircleContainerModifierRadius, float CircleContainerModifierRestitutionCoefficient,
            int RectangleContainerModifierWidth, int RectangleContainerModifierHeight, float RectangleContainerModifierRestitutionCoefficient,
            int RectangleLoopContainerModifierWidth, int RectangleLoopContainerModifierHeight,
            string ModifiersInterpolatorsSelectedName,
            Microsoft.Xna.Framework.Color AgeModifierColorInterpolatorStartValue, Microsoft.Xna.Framework.Color AgeModifierColorInterpolatorEndValue,
            float AgeModifierHueInterpolatorStartValue, float AgeModifierHueInterpolatorEndValue,
            float AgeModifierOpacityInterpolatorStartValue, float AgeModifierOpacityInterpolatorEndValue,
            float AgeModifierRotationInterpolatorStartValue, float AgeModifierRotationInterpolatorEndValue,
            float AgeModifierScaleInterpolatorStartValueX, float AgeModifierScaleInterpolatorStartValueY, float AgeModifierScaleInterpolatorEndValueX, float AgeModifierScaleInterpolatorEndValueY,
            Microsoft.Xna.Framework.Color VelocityModifierColorInterpolatorStartValue, Microsoft.Xna.Framework.Color VelocityModifierColorInterpolatorEndValue,
            float VelocityModifierHueInterpolatorStartValue, float VelocityModifierHueInterpolatorEndValue,
            float VelocityModifierOpacityInterpolatorStartValue, float VelocityModifierOpacityInterpolatorEndValue,
            float VelocityModifierRotationInterpolatorStartValue, float VelocityModifierRotationInterpolatorEndValue,
            float VelocityModifierScaleInterpolatorStartValueX, float VelocityModifierScaleInterpolatorStartValueY, float VelocityModifierScaleInterpolatorEndValueX, float VelocityModifierScaleInterpolatorEndValueY,
            bool IsDragModifierSelected, float DragModifierDragCoefficient, float DragModifierDensity,
            bool IsLinearGravityModifierSelected, float LinearGravityModifierDirectionX, float LinearGravityModifierDirectionY, float LinearGravityModifierStrength, int LinearGravityModifierControlSizeBuffer, float LinearGravityModifierControlDuration,
            bool IsOpacityFastFadeModifierSelected, float OpacityFastFadeModifierControlDuration, int OpacityFastFadeModifierControlSizeBuffer,
            bool IsRotationModifierRotationRate, float RotationModifierRotationRate,
            bool IsVelocityColorModifierSelected, Microsoft.Xna.Framework.Color VelocityColorModifierVelocityColor, Microsoft.Xna.Framework.Color VelocityColorModifierStationaryColor, 
            bool IsVelocityModifierInterpolatorSelected, float VelocityColorModifierVelocityThreshold, float VelocityModifierVelocityThreshold, string VelocityModifiersInterpolatorsSelectedName, 
            bool IsVortexModifierSelected, float VortexModifierMass, float VortexModifierMaxSpeed, float VortexModifierPositionX, float VortexModifierPositionY,
            Texture2D TextBoxTextureRegionDefinitions, int TextBoxCapacityDefinitions, float TextBoxLifeSpanDefinitions)
        {
            positionParticle = Position;
            this.BoxWidth = BoxWidth;
            this.BoxHeight = BoxHeight;
            this.BoxFillWidth = BoxFillWidth;
            this.BoxFillHeight = BoxFillHeight;
            this.BoxUniformWidth = BoxUniformWidth;
            this.BoxUniformHeight = BoxUniformHeight;
            this.CircleRadius = CircleRadius;
            this.LineAxisX = LineAxisX;
            this.LineAxisY = LineAxisY;
            this.LineLength = LineLength;
            this.RingRadius = RingRadius;
            this.SpraySpread = SpraySpread;
            this.SprayDirectionX = SprayDirectionX;
            this.SprayDirectionY = SprayDirectionY;
            this.CircleRadiate = CircleRadiate;
            this.RingRadiate = RingRadiate;

            if (texture != null)
                texture.Dispose();

            if (string.IsNullOrEmpty(DefinitionsTextureRegion))
                texture = CreateTexture(graphics.GraphicsDevice, 5, 5, pixel => Color.White);       
            else            
                texture = Texture2D.FromStream(graphics.GraphicsDevice, new FileStream(DefinitionsTextureRegion, FileMode.Open, FileAccess.Read, FileShare.Read));             

            textureRegion = new TextureRegion2D(texture);

            if(LifeSpanFromMilliseconds == 1)
                this.lifeSpan = 5;
            else
                this.lifeSpan = LifeSpanFromMilliseconds;

            particle = new ParticleEffect();
            particle.Position = Position;

            particle.Emitters = new List<ParticleEmitter>();

            File.WriteAllText(@"D:\GameDevelop\HomeParticlesSoftware\HomeParticlesSoftware\traceText\test.txt", String.Empty);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\GameDevelop\HomeParticlesSoftware\HomeParticlesSoftware\traceText\test.txt", true))
            {
                file.WriteLine("ProfileUsed : " + GetProfile(ProfileName).ToString());

                file.WriteLine("ProfileName : " + ProfileName);
                file.WriteLine("Position : " + Position);
                file.WriteLine("DefinitionsTextureRegion : " + DefinitionsTextureRegion);

                file.WriteLine("DefinitionsCapacity : " + DefinitionsCapacity);
                file.WriteLine("LifeSpanFromMilliseconds : " + LifeSpanFromMilliseconds);
                file.WriteLine("BoxFillWidth : " + BoxFillWidth);
                file.WriteLine("BoxFillHeight : " + BoxFillHeight);

                file.WriteLine("BoxWidth : " + BoxWidth);
                file.WriteLine("BoxHeight : " + BoxHeight);
                file.WriteLine("BoxUniformWidth : " + BoxUniformWidth);
                file.WriteLine("BoxUniformHeight : " + BoxUniformHeight);

                file.WriteLine("CircleRadius : " + CircleRadius);
                file.WriteLine("CircleRadiate : " + CircleRadiate);
                file.WriteLine("LineAxisX : " + LineAxisX);
                file.WriteLine("LineAxisY : " + LineAxisY);

                file.WriteLine("LineLength : " + LineLength);
                file.WriteLine("PointIsPoint : " + PointIsPoint);
                file.WriteLine("RingRadius : " + RingRadius);
                file.WriteLine("RingRadiate : " + RingRadiate);

                file.WriteLine("SprayDirectionX : " + SprayDirectionX);
                file.WriteLine("SprayDirectionY : " + SprayDirectionY);
                file.WriteLine("SpraySpread : " + SpraySpread);
                file.WriteLine("ParametersColorMin : " + ParametersColorMin);

                file.WriteLine("ParametersMassMin : " + ParametersMassMin);
                file.WriteLine("ParametersOpacityMin : " + ParametersOpacityMin);
                file.WriteLine("ParametersQuantityMin : " + ParametersQuantityMin);
                file.WriteLine("ParametersRotationMin : " + ParametersRotationMin);

                file.WriteLine("ParametersScaleMin : " + ParametersScaleMin);
                file.WriteLine("ParametersSpeedMin : " + ParametersSpeedMin);
              
                file.WriteLine("ParametersMassMax : " + ParametersMassMax);

                file.WriteLine("ParametersOpacityMax : " + ParametersOpacityMax);
                file.WriteLine("ParametersQuantityMax : " + ParametersQuantityMax);
                file.WriteLine("ParametersRotationMax : " + ParametersRotationMax);
                file.WriteLine("ParametersScaleMax : " + ParametersScaleMax);

                file.WriteLine("ParametersSpeedMax : " + ParametersSpeedMax);
                file.WriteLine("CircleContainerModifierInside : " + CircleContainerModifierInside);
                file.WriteLine("CircleContainerModifierRadius : " + CircleContainerModifierRadius);
                file.WriteLine("CircleContainerModifierRestitutionCoefficient : " + CircleContainerModifierRestitutionCoefficient);

                file.WriteLine("RectangleContainerModifierWidth : " + RectangleContainerModifierWidth);
                file.WriteLine("RectangleContainerModifierHeight : " + RectangleContainerModifierHeight);
                file.WriteLine("RectangleContainerModifierRestitutionCoefficient : " + RectangleContainerModifierRestitutionCoefficient);
                file.WriteLine("RectangleLoopContainerModifierWidth : " + RectangleLoopContainerModifierWidth);
                file.WriteLine("RectangleLoopContainerModifierHeight : " + RectangleLoopContainerModifierHeight);

                file.WriteLine("ModifiersInterpolatorsSelectedName : " + ModifiersInterpolatorsSelectedName);
                file.WriteLine("AgeModifierColorInterpolatorStartValue : " + AgeModifierColorInterpolatorStartValue);
                file.WriteLine("AgeModifierColorInterpolatorEndValue : " + AgeModifierColorInterpolatorEndValue);
                file.WriteLine("AgeModifierHueInterpolatorStartValue : " + AgeModifierHueInterpolatorStartValue);
                file.WriteLine("AgeModifierHueInterpolatorEndValue : " + AgeModifierHueInterpolatorEndValue);
                file.WriteLine("AgeModifierOpacityInterpolatorStartValue : " + AgeModifierOpacityInterpolatorStartValue);
                file.WriteLine("AgeModifierOpacityInterpolatorEndValue : " + AgeModifierOpacityInterpolatorEndValue);
                file.WriteLine("AgeModifierRotationInterpolatorStartValue : " + AgeModifierRotationInterpolatorStartValue);
                file.WriteLine("AgeModifierRotationInterpolatorEndValue : " + AgeModifierRotationInterpolatorEndValue);
                file.WriteLine("AgeModifierScaleInterpolatorStartValueX : " + AgeModifierScaleInterpolatorStartValueX);
                file.WriteLine("AgeModifierScaleInterpolatorStartValueY : " + AgeModifierScaleInterpolatorStartValueY);
                file.WriteLine("AgeModifierScaleInterpolatorEndValueX : " + AgeModifierScaleInterpolatorEndValueX);
                file.WriteLine("AgeModifierScaleInterpolatorEndValueY : " + AgeModifierScaleInterpolatorEndValueY);

                file.WriteLine("VelocityModifiersInterpolatorsSelectedName : " + VelocityModifiersInterpolatorsSelectedName);
                file.WriteLine("VelocityModifierColorInterpolatorStartValue : " + VelocityModifierColorInterpolatorStartValue);
                file.WriteLine("VelocityModifierColorInterpolatorEndValue : " + VelocityModifierColorInterpolatorEndValue);
                file.WriteLine("VelocityModifierHueInterpolatorStartValue : " + VelocityModifierHueInterpolatorStartValue);
                file.WriteLine("VelocityModifierHueInterpolatorEndValue : " + VelocityModifierHueInterpolatorEndValue);
                file.WriteLine("VelocityModifierOpacityInterpolatorStartValue : " + VelocityModifierOpacityInterpolatorStartValue);
                file.WriteLine("VelocityModifierOpacityInterpolatorEndValue : " + VelocityModifierOpacityInterpolatorEndValue);
                file.WriteLine("VelocityModifierRotationInterpolatorStartValue : " + VelocityModifierRotationInterpolatorStartValue);
                file.WriteLine("VelocityModifierRotationInterpolatorEndValue : " + VelocityModifierRotationInterpolatorEndValue);
                file.WriteLine("VelocityModifierScaleInterpolatorStartValueX : " + VelocityModifierScaleInterpolatorStartValueX);
                file.WriteLine("VelocityModifierScaleInterpolatorStartValueY : " + VelocityModifierScaleInterpolatorStartValueY);
                file.WriteLine("VelocityModifierScaleInterpolatorEndValueX : " + VelocityModifierScaleInterpolatorEndValueX);
                file.WriteLine("VelocityModifierScaleInterpolatorEndValueY : " + VelocityModifierScaleInterpolatorEndValueY);

                file.WriteLine("DragModifierDragCoefficient : " + DragModifierDragCoefficient);
                file.WriteLine("DragModifierDensity : " + DragModifierDensity);

                file.WriteLine("IsLinearGravityModifierSelected : " + IsLinearGravityModifierSelected.ToString());
                file.WriteLine("LinearGravityModifierDirectionX : " + LinearGravityModifierDirectionX);
                file.WriteLine("LinearGravityModifierDirectionY : " + LinearGravityModifierDirectionY);
                file.WriteLine("LinearGravityModifierStrength : " + LinearGravityModifierStrength);
                file.WriteLine("LinearGravityModifierControlSizeBuffer : " + LinearGravityModifierControlSizeBuffer);
                file.WriteLine("LinearGravityModifierControlDuration : " + LinearGravityModifierControlDuration);

                file.WriteLine("IsOpacityFastFadeModifierSelected : " + IsOpacityFastFadeModifierSelected.ToString());
                file.WriteLine("OpacityFastFadeModifierControlSizeBuffer : " + OpacityFastFadeModifierControlSizeBuffer);
                file.WriteLine("OpacityFastFadeModifierControlDuration : " + OpacityFastFadeModifierControlDuration);

                file.WriteLine("IsRotationModifierRotationRate : " + IsRotationModifierRotationRate.ToString());
                file.WriteLine("RotationModifierRotationRate : " + RotationModifierRotationRate);

                file.WriteLine("VelocityColorModifierVelocityColor : " + VelocityColorModifierVelocityColor);
                file.WriteLine("VelocityColorModifierStationaryColor : " + VelocityColorModifierStationaryColor);
                file.WriteLine("VelocityColorModifierVelocityThreshold : " + VelocityColorModifierVelocityThreshold);

                file.WriteLine("IsVelocityModifierInterpolatorSelected : " + IsVelocityModifierInterpolatorSelected);
                file.WriteLine("VelocityModifiersInterpolatorsSelectedName : " + VelocityModifiersInterpolatorsSelectedName);
                file.WriteLine("VelocityModifierColorInterpolatorStartValue : " + VelocityModifierColorInterpolatorStartValue);
                file.WriteLine("VelocityModifierColorInterpolatorEndValue : " + VelocityModifierColorInterpolatorEndValue);
                file.WriteLine("VelocityModifierHueInterpolatorStartValue : " + VelocityModifierHueInterpolatorStartValue);
                file.WriteLine("VelocityModifierHueInterpolatorEndValue : " + VelocityModifierHueInterpolatorEndValue);
                file.WriteLine("VelocityModifierOpacityInterpolatorStartValue : " + VelocityModifierOpacityInterpolatorStartValue);
                file.WriteLine("VelocityModifierOpacityInterpolatorEndValue : " + VelocityModifierOpacityInterpolatorEndValue);
                file.WriteLine("VelocityModifierRotationInterpolatorStartValue : " + VelocityModifierRotationInterpolatorStartValue);
                file.WriteLine("VelocityModifierRotationInterpolatorEndValue : " + VelocityModifierRotationInterpolatorEndValue);
                file.WriteLine("VelocityModifierScaleInterpolatorStartValueX : " + VelocityModifierScaleInterpolatorStartValueX);
                file.WriteLine("VelocityModifierScaleInterpolatorStartValueY : " + VelocityModifierScaleInterpolatorStartValueY);
                file.WriteLine("VelocityModifierScaleInterpolatorEndValueX : " + VelocityModifierScaleInterpolatorEndValueX);
                file.WriteLine("VelocityModifierScaleInterpolatorEndValueY : " + VelocityModifierScaleInterpolatorEndValueY);
                file.WriteLine("VelocityModifierVelocityThreshold : " + VelocityModifierVelocityThreshold);

                file.WriteLine("VortexModifierMass : " + VortexModifierMass);
                file.WriteLine("VortexModifierMaxSpeed : " + VortexModifierMaxSpeed);
                file.WriteLine("VortexModifierPositionX : " + VortexModifierPositionX);
                file.WriteLine("VortexModifierPositionY : " + VortexModifierPositionY);
                file.WriteLine("TextBoxTextureRegionDefinitions : " + TextBoxTextureRegionDefinitions);

                file.WriteLine("TextBoxCapacityDefinitions : " + TextBoxCapacityDefinitions);
                file.WriteLine("TextBoxLifeSpanDefinitions : " + TextBoxLifeSpanDefinitions);               
            }

            #region ParticleEmitter
            ParticleEmitter particleEmitter = new ParticleEmitter("", textureRegion, DefinitionsCapacity, TimeSpan.FromSeconds(lifeSpan), GetProfile(ProfileName));

            isEmit = IsEmitterParameters;

            if (IsEmitterParameters)
            {
                particleEmitter.Parameters = new ParticleReleaseParameters();
                if (ParametersSpeedMin <= ParametersSpeedMax && ParametersSpeedMax > 0)
                    particleEmitter.Parameters.Speed = new Range<float>(ParametersSpeedMin, ParametersSpeedMax);
                if (ParametersQuantityMin <= ParametersQuantityMax && ParametersQuantityMax > 0)
                    particleEmitter.Parameters.Quantity = new Range<int>(ParametersQuantityMin, ParametersQuantityMax);
                if (ParametersRotationMin <= ParametersRotationMax && ParametersRotationMax > 0)
                    particleEmitter.Parameters.Rotation = new Range<float>(ParametersRotationMin, ParametersRotationMax);
                if (ParametersScaleMin <= ParametersScaleMax && ParametersScaleMax > 0)
                    particleEmitter.Parameters.Scale = new Range<float>(ParametersScaleMin, ParametersScaleMax);
                if (ParametersOpacityMin <= ParametersOpacityMax && ParametersOpacityMax > 0)
                    particleEmitter.Parameters.Opacity = new Range<float>(ParametersOpacityMin, ParametersOpacityMax);
                if (ParametersMassMin <= ParametersMassMax && ParametersMassMax > 0)
                    particleEmitter.Parameters.Mass = new Range<float>(ParametersMassMin, ParametersMassMax);
                if(ParametersColorMin.R > 0 || ParametersColorMin.G > 0 || ParametersColorMin.B > 0)
                    particleEmitter.Parameters.Color = HslColor.FromRgb(ParametersColorMin);     
            }   
            #endregion

            #region Modifiers Containers
            if(IsContainerModifierSelected)
            {
                if (ContainerModifierSelectedName == "CircleContainerModifier")
                {
                    CircleContainerModifier circleContainerModifier = new CircleContainerModifier();
                    circleContainerModifier.Inside = CircleContainerModifierInside;
                    circleContainerModifier.Radius = CircleContainerModifierRadius;
                    circleContainerModifier.RestitutionCoefficient = CircleContainerModifierRestitutionCoefficient;
                    particleEmitter.Modifiers.Add(circleContainerModifier);
                }
                if (ContainerModifierSelectedName == "RectangleContainerModifier")
                {
                    RectangleContainerModifier rectangleContainerModifier = new RectangleContainerModifier();
                    rectangleContainerModifier.Width = RectangleContainerModifierWidth;
                    rectangleContainerModifier.Height = RectangleContainerModifierHeight;
                    rectangleContainerModifier.RestitutionCoefficient = RectangleContainerModifierRestitutionCoefficient;
                    particleEmitter.Modifiers.Add(rectangleContainerModifier);
                }
                if (ContainerModifierSelectedName == "RectangleLoopContainerModifier")
                {
                    RectangleLoopContainerModifier rectangleLoopContainerModifier = new RectangleLoopContainerModifier();
                    rectangleLoopContainerModifier.Width = RectangleLoopContainerModifierWidth;
                    rectangleLoopContainerModifier.Height = RectangleLoopContainerModifierHeight;
                    particleEmitter.Modifiers.Add(rectangleLoopContainerModifier);
                }
            }

            #endregion

            #region AgeModifier Interpolator
            AgeModifier ageModifierColor = new AgeModifier();
            AgeModifier ageModifierHue = new AgeModifier();
            AgeModifier ageModifierOpacity = new AgeModifier();
            AgeModifier ageModifierRotation = new AgeModifier();
            AgeModifier ageModifierScale = new AgeModifier();

            if (ModifiersInterpolatorsSelectedName == "ColorInterpolator")
            {
                ColorInterpolator ageModifiercolorInterpolator = new ColorInterpolator();                  
                ageModifiercolorInterpolator.StartValue = HslColor.FromRgb(AgeModifierColorInterpolatorStartValue);
                ageModifierColor.Interpolators.Add(ageModifiercolorInterpolator);
            }

            else if (ModifiersInterpolatorsSelectedName == "HueInterpolator")
            {
                HueInterpolator ageModifierhueInterpolator = new HueInterpolator();
                ageModifierhueInterpolator.StartValue = AgeModifierHueInterpolatorStartValue;
                ageModifierhueInterpolator.EndValue = AgeModifierHueInterpolatorEndValue;
                ageModifierHue.Interpolators.Add(ageModifierhueInterpolator);
            }
            else if (ModifiersInterpolatorsSelectedName == "OpacityInterpolator")
            {
                OpacityInterpolator ageModifierOpacityInterpolator = new OpacityInterpolator();
                ageModifierOpacityInterpolator.StartValue = AgeModifierOpacityInterpolatorStartValue;
                ageModifierOpacityInterpolator.EndValue = AgeModifierOpacityInterpolatorEndValue;
                ageModifierOpacity.Interpolators.Add(ageModifierOpacityInterpolator);
            }

            else if (ModifiersInterpolatorsSelectedName == "RotationInterpolator")
            {
                RotationInterpolator ageModifierRotationInterpolator = new RotationInterpolator();
                ageModifierRotationInterpolator.StartValue = AgeModifierRotationInterpolatorStartValue;
                ageModifierRotationInterpolator.EndValue = AgeModifierRotationInterpolatorEndValue;
                ageModifierRotation.Interpolators.Add(ageModifierRotationInterpolator);
            }

            else if (ModifiersInterpolatorsSelectedName == "ScaleInterpolator")
            {
                ScaleInterpolator ageModifierScaleInterpolator = new ScaleInterpolator();
                ageModifierScaleInterpolator.StartValue = new Vector2(AgeModifierScaleInterpolatorStartValueX, AgeModifierScaleInterpolatorStartValueY);
                ageModifierScaleInterpolator.EndValue = new Vector2(AgeModifierScaleInterpolatorEndValueX, AgeModifierScaleInterpolatorEndValueY);
                ageModifierScale.Interpolators.Add(ageModifierScaleInterpolator);
            }

            particleEmitter.Modifiers.Add(ageModifierColor);
            particleEmitter.Modifiers.Add(ageModifierHue);
            particleEmitter.Modifiers.Add(ageModifierOpacity);
            particleEmitter.Modifiers.Add(ageModifierRotation);
            particleEmitter.Modifiers.Add(ageModifierScale);
            #endregion

            #region DragModifier Interpolator
            if(IsDragModifierSelected && DragModifierDensity > 0f && DragModifierDragCoefficient > 0f)
            {
                DragModifier dragModifier = new DragModifier();
                dragModifier.Density = DragModifierDensity;
                dragModifier.DragCoefficient = DragModifierDragCoefficient;
                particleEmitter.Modifiers.Add(dragModifier);
            }              
            #endregion

           #region LinearGravityModifier Interpolator
            if (IsLinearGravityModifierSelected)
            {
                LinearGravityModifier linearGravityModifier = new LinearGravityModifier();     
                linearGravityModifier.Direction = new Vector2(LinearGravityModifierDirectionX, LinearGravityModifierDirectionY);
                linearGravityModifier.Strength = LinearGravityModifierStrength;

                if (LinearGravityModifierControlSizeBuffer > 0 && LinearGravityModifierControlDuration > 0)
                {
                    ParticleBuffer particle1 = new ParticleBuffer(LinearGravityModifierControlSizeBuffer);
                    linearGravityModifier.Update(LinearGravityModifierControlDuration, particle1.Iterator);
                }
                particleEmitter.Modifiers.Add(linearGravityModifier);
            }
            #endregion

            #region OpacityFastFadeModifier Interpolator

            if (IsOpacityFastFadeModifierSelected)
            {
                OpacityFastFadeModifier opacityFastFadeModifier = new OpacityFastFadeModifier();
                if (OpacityFastFadeModifierControlSizeBuffer > 0 && OpacityFastFadeModifierControlDuration > 0)
                {
                    ParticleBuffer particle1 = new ParticleBuffer(OpacityFastFadeModifierControlSizeBuffer);
                    opacityFastFadeModifier.Update(OpacityFastFadeModifierControlDuration, particle1.Iterator);
                }
                particleEmitter.Modifiers.Add(opacityFastFadeModifier);
            }        
            #endregion

            #region RotationModifier Interpolator           
            if(IsRotationModifierRotationRate)
            {
                    RotationModifier rotationModifier = new RotationModifier();
                    rotationModifier.RotationRate = RotationModifierRotationRate;
                    particleEmitter.Modifiers.Add(rotationModifier);
            }
            #endregion

            #region VelocityColorModifier Interpolator
            if (IsVelocityColorModifierSelected)
            {
                VelocityColorModifier velocityColorModifier = new VelocityColorModifier();
                velocityColorModifier.StationaryColor = HslColor.FromRgb(VelocityColorModifierVelocityColor);
                velocityColorModifier.VelocityColor = HslColor.FromRgb(VelocityColorModifierStationaryColor);
                velocityColorModifier.VelocityThreshold = VelocityColorModifierVelocityThreshold;
                particleEmitter.Modifiers.Add(velocityColorModifier);
            }
            #endregion

            #region VelocityModifier Interpolator
            if(IsVelocityModifierInterpolatorSelected)
            {
                VelocityModifier velocityModifierColor = new VelocityModifier();
                VelocityModifier velocityModifierHue = new VelocityModifier();
                VelocityModifier velocityModifierOpacity = new VelocityModifier();
                VelocityModifier velocityModifierRotation = new VelocityModifier();
                VelocityModifier velocityModifierScale = new VelocityModifier();

                if (VelocityModifiersInterpolatorsSelectedName == "ColorInterpolator")
                {
                    ColorInterpolator velocityModifiercolorInterpolator = new ColorInterpolator();
                    velocityModifiercolorInterpolator.StartValue = HslColor.FromRgb(VelocityModifierColorInterpolatorStartValue);
                    velocityModifiercolorInterpolator.EndValue = HslColor.FromRgb(VelocityModifierColorInterpolatorEndValue);
                    velocityModifierColor.Interpolators.Add(velocityModifiercolorInterpolator);
                }

                else if (VelocityModifiersInterpolatorsSelectedName == "HueInterpolator")
                {
                    HueInterpolator velocityModifierhueInterpolator = new HueInterpolator();
                    velocityModifierhueInterpolator.StartValue = VelocityModifierHueInterpolatorStartValue;
                    velocityModifierhueInterpolator.EndValue = VelocityModifierHueInterpolatorEndValue;
                    velocityModifierHue.Interpolators.Add(velocityModifierhueInterpolator);
                }
                else if (VelocityModifiersInterpolatorsSelectedName == "OpacityInterpolator")
                {
                    OpacityInterpolator velocityModifierOpacityInterpolator = new OpacityInterpolator();
                    velocityModifierOpacityInterpolator.StartValue = VelocityModifierOpacityInterpolatorStartValue;
                    velocityModifierOpacityInterpolator.EndValue = VelocityModifierOpacityInterpolatorEndValue;
                    velocityModifierOpacity.Interpolators.Add(velocityModifierOpacityInterpolator);
                }

                else if (VelocityModifiersInterpolatorsSelectedName == "RotationInterpolator")
                {
                    RotationInterpolator velocityModifierRotationInterpolator = new RotationInterpolator();
                    velocityModifierRotationInterpolator.StartValue = VelocityModifierRotationInterpolatorStartValue;
                    velocityModifierRotationInterpolator.EndValue = VelocityModifierRotationInterpolatorEndValue;
                    velocityModifierRotation.Interpolators.Add(velocityModifierRotationInterpolator);
                }

                else if (VelocityModifiersInterpolatorsSelectedName == "ScaleInterpolator")
                {
                    ScaleInterpolator velocityModifierScaleInterpolator = new ScaleInterpolator();
                    velocityModifierScaleInterpolator.StartValue = new Vector2(VelocityModifierScaleInterpolatorStartValueX, VelocityModifierScaleInterpolatorStartValueY);
                    velocityModifierScaleInterpolator.EndValue = new Vector2(VelocityModifierScaleInterpolatorEndValueX, VelocityModifierScaleInterpolatorEndValueY);
                    velocityModifierScale.Interpolators.Add(velocityModifierScaleInterpolator);
                }

                particleEmitter.Modifiers.Add(velocityModifierColor);
                particleEmitter.Modifiers.Add(velocityModifierHue);
                particleEmitter.Modifiers.Add(velocityModifierOpacity);
                particleEmitter.Modifiers.Add(velocityModifierRotation);
                particleEmitter.Modifiers.Add(velocityModifierScale);
            }          
            #endregion

            #region VortexModifier Interpolator
            if(IsVortexModifierSelected)
            {
                VortexModifier vortexModifier = new VortexModifier();
                vortexModifier.Mass = VortexModifierMass;
                vortexModifier.MaxSpeed = VortexModifierMaxSpeed;
                vortexModifier.Position = new Vector2(VortexModifierPositionX, VortexModifierPositionY);           
                particleEmitter.Modifiers.Add(vortexModifier);
            }
            #endregion

            particle.Emitters.Add(particleEmitter);
        }

        float elapseTime = 0;
        bool isEmit = false;
        public void ParticlesUpdate(GameTime gameTime)
        {
            if (isParticleAlive)
            {
                if (lifeSpan > 0f)
                {
                    particle.Update((float)gameTime.ElapsedGameTime.TotalSeconds);

                    elapseTime = (float)gameTime.GetElapsedSeconds();
                    lifeSpan -= elapseTime;
                }
                else
                    isParticleAlive = false;
            }
        }

        public void ParticlesDrawDebug(SpriteBatch spriteBatch, SpriteFont DebugFont, Vector2 position, string text)
        {
           /* spriteBatch.DrawString(DebugFont, text, position, Color.Red);
            spriteBatch.DrawString(DebugFont, LineAxisX.ToString(), new Vector2(10, 50), Color.Red);
            spriteBatch.DrawString(DebugFont, LineAxisY.ToString(), new Vector2(10, 100), Color.Red);
            spriteBatch.DrawString(DebugFont, LineLength.ToString(), new Vector2(10, 150), Color.Red);*/
        }
    }
}
