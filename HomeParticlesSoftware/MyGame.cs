using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Particles;
using MonoGame.Extended.TextureAtlases;
using MonoGame.Framework.WpfInterop;
using System.Collections.Generic;

namespace HomeParticlesSoftware
{
    public class MyGame : WpfGame
    {
        private IGraphicsDeviceService graphics;
        private SpriteBatch spriteBatch;
        private List<ParticlesEffect> listParticlesEffect = new List<ParticlesEffect>();
        public List<ParticlesEffect> ListParticlesEffect
        {
            get { return listParticlesEffect; }
            internal set { listParticlesEffect = value; }
        }
        private SpriteFont DebugFont;
        private static string displayDim;
        public bool IsEmitterParameters { get; set; }
        public string ModifiersInterpolatorsSelectedName { get; set; }
        public string ModifierInterpolatorVelocityName { get; set; }   

        public bool ParticleMode { get; set; }
        public string DefinitionsName { get; internal set; }
        public string DefinitionsTextureRegion { get; internal set; }
        public int DefinitionsCapacity { get; internal set; }
        public float LifeSpanFromMilliseconds { get; internal set; }
        public string ProfileName { get; internal set; }        
        public float BoxFillWidth { get; internal set; }
        public float BoxFillHeight { get; internal set; }
        public float BoxWidth { get; internal set; }
        public float BoxHeight { get; internal set; }
        public float BoxUniformWidth { get; internal set; }
        public float BoxUniformHeight { get; internal set; }
        public float CircleRadius { get; internal set; }
        public string CircleRadiate { get; internal set; }
        public float LineAxisX { get; internal set; }
        public float LineAxisY { get; internal set; }
        public float LineLength { get; internal set; }
        public bool PointIsPoint { get; internal set; }
        public float RingRadius { get; internal set; }
        public string RingRadiate { get; internal set; }
        public float SprayDirectionX { get; internal set; }
        public float SprayDirectionY { get; internal set; }
        public float SpraySpread { get; internal set; }
        public Microsoft.Xna.Framework.Color ParametersColorMin { get; internal set; }
        public Microsoft.Xna.Framework.Color ParametersColorMax { get; internal set; }
        public float ParametersMassMin { get; internal set; }
        public float ParametersMassMax { get; internal set; }
        public float ParametersOpacityMin { get; internal set; }
        public int ParametersQuantityMin { get; internal set; }
        public float ParametersRotationMin { get; internal set; }
        public float ParametersScaleMin { get; internal set; }
        public float ParametersSpeedMin { get; internal set; }
        public float ParametersOpacityMax { get; internal set; }
        public int ParametersQuantityMax { get; internal set; }
        public float ParametersRotationMax { get; internal set; }
        public float ParametersScaleMax { get; internal set; }
        public float ParametersSpeedMax { get; internal set; }
        public string ContainerModifierSelectedName { get; internal set; }
        public bool IsContainerModifierSelected { get; internal set; }
        public bool CircleContainerModifierInside { get; internal set; }
        public float CircleContainerModifierRadius { get; internal set; }
        public float CircleContainerModifierRestitutionCoefficient { get; internal set; }
        public int RectangleContainerModifierWidth { get; internal set; }
        public int RectangleContainerModifierHeight { get; internal set; }
        public float RectangleContainerModifierRestitutionCoefficient { get; internal set; }
        public int RectangleLoopContainerModifierWidth { get; internal set; }
        public int RectangleLoopContainerModifierHeight { get; internal set; }

        public string AgeModifierColorInterpolatorName { get; internal set; }
        public Microsoft.Xna.Framework.Color AgeModifierColorInterpolatorStartValue { get; internal set; }
        public Microsoft.Xna.Framework.Color AgeModifierColorInterpolatorEndValue { get; internal set; }
        public string AgeModifierHueInterpolatorName { get; internal set; }
        public float AgeModifierHueInterpolatorStartValue { get; internal set; }
        public float AgeModifierHueInterpolatorEndValue { get; internal set; }
        public string AgeModifierOpacityInterpolatorName { get; internal set; }
        public float AgeModifierOpacityInterpolatorStartValue { get; internal set; }
        public float AgeModifierOpacityInterpolatorEndValue { get; internal set; }
        public string AgeModifierRotationInterpolatorName { get; internal set; }
        public float AgeModifierRotationInterpolatorStartValue { get; internal set; }
        public float AgeModifierRotationInterpolatorEndValue { get; internal set; }
        public string AgeModifierScaleInterpolatorName { get; internal set; }
        public float AgeModifierScaleInterpolatorStartValueX { get; internal set; }
        public float AgeModifierScaleInterpolatorStartValueY { get; internal set; }
        public float AgeModifierScaleInterpolatorEndValueX { get; internal set; }
        public float AgeModifierScaleInterpolatorEndValueY { get; internal set; }

        public string VelocityModifierColorInterpolatorName { get; internal set; }
        public Microsoft.Xna.Framework.Color VelocityModifierColorInterpolatorStartValue { get; internal set; }
        public Microsoft.Xna.Framework.Color VelocityModifierColorInterpolatorEndValue { get; internal set; }
        public string VelocityModifierHueInterpolatorName { get; internal set; }
        public float VelocityModifierHueInterpolatorStartValue { get; internal set; }
        public float VelocityModifierHueInterpolatorEndValue { get; internal set; }
        public string VelocityModifierOpacityInterpolatorName { get; internal set; }
        public float VelocityModifierOpacityInterpolatorStartValue { get; internal set; }
        public float VelocityModifierOpacityInterpolatorEndValue { get; internal set; }
        public string VelocityModifierRotationInterpolatorName { get; internal set; }
        public float VelocityModifierRotationInterpolatorStartValue { get; internal set; }
        public float VelocityModifierRotationInterpolatorEndValue { get; internal set; }
        public string VelocityModifierScaleInterpolatorName { get; internal set; }
        public float VelocityModifierScaleInterpolatorStartValueX { get; internal set; }
        public float VelocityModifierScaleInterpolatorStartValueY { get; internal set; }
        public float VelocityModifierScaleInterpolatorEndValueX { get; internal set; }
        public float VelocityModifierScaleInterpolatorEndValueY { get; internal set; }

        public bool IsDragModifierSelected { get; internal set; }
        public float DragModifierDragCoefficient { get; internal set; }
        public float DragModifierDensity { get; internal set; }
        public bool IsLinearGravityModifierSelected { get; internal set; }
        public float LinearGravityModifierDirectionX { get; internal set; }
        public float LinearGravityModifierDirectionY { get; internal set; }
        public float LinearGravityModifierStrength { get; internal set; }
        public int LinearGravityModifierControlSizeBuffer { get; internal set; }
        public float LinearGravityModifierControlDuration { get; internal set; }

        public bool IsOpacityFastFadeModifierSelected { get; internal set; }
        public int OpacityFastFadeModifierControlSizeBuffer { get; internal set; }
        public float OpacityFastFadeModifierControlDuration { get; internal set; }

        public bool IsRotationModifierRotationRate { get; internal set; }
        public float RotationModifierRotationRate { get; internal set; }
        public bool IsVelocityColorModifierSelected { get; internal set; }
        public Microsoft.Xna.Framework.Color VelocityColorModifierVelocityColor { get; internal set; }
        public Microsoft.Xna.Framework.Color VelocityColorModifierStationaryColor { get; internal set; }

        public bool IsVelocityModifierInterpolatorSelected { get; internal set; }
        public string VelocityModifiersInterpolatorsSelectedName { get; internal set; }
        public float VelocityColorModifierVelocityThreshold { get; internal set; }
        public float VelocityModifierVelocityThreshold { get; internal set; }

        public bool IsVortexModifierSelected { get; internal set; }
        public float VortexModifierMass { get; internal set; }
        public float VortexModifierMaxSpeed { get; internal set; }
        public float VortexModifierPositionX { get; internal set; }
        public float VortexModifierPositionY { get; internal set; }
        private System.Windows.Point mousePointerPos;
        private string oldState;
        public string TextBoxNameDefinitions { get; set; }
        public Texture2D TextBoxTextureRegionDefinitions { get; set; }
        public int TextBoxCapacityDefinitions { get; set; }
        public float TextBoxLifeSpanDefinitions { get; set; }
        public string ComboBoxProfileDefinitionsSelected { get; set; }
        public int ViewPortWidth { get; set; }
        public int ViewPortHeight { get; set; }

        private void GenerateParticleEffect(Vector2 position)
        {
            if (DefinitionsCapacity == 0)
                DefinitionsCapacity = 10;
            if (LifeSpanFromMilliseconds == 0f)
                LifeSpanFromMilliseconds = 1.0f;
          
            listParticlesEffect.Add(new ParticlesEffect
                (IsEmitterParameters, 
                ProfileName, graphics, position,
                DefinitionsTextureRegion, DefinitionsCapacity, LifeSpanFromMilliseconds,
                BoxFillWidth, BoxFillHeight,
                BoxWidth, BoxHeight,
                BoxUniformWidth, BoxUniformHeight,
                CircleRadius, CircleRadiate,
                LineAxisX, LineAxisY, LineLength,
                PointIsPoint,
                RingRadius, RingRadiate,
                SprayDirectionX, SprayDirectionY, SpraySpread,
                ParametersColorMin, ParametersMassMin, ParametersOpacityMin, ParametersQuantityMin, ParametersRotationMin, ParametersScaleMin, ParametersSpeedMin,
                ParametersMassMax, ParametersOpacityMax, ParametersQuantityMax, ParametersRotationMax, ParametersScaleMax, ParametersSpeedMax,
                ContainerModifierSelectedName,
                IsContainerModifierSelected, CircleContainerModifierInside, CircleContainerModifierRadius, CircleContainerModifierRestitutionCoefficient,               
                RectangleContainerModifierWidth, RectangleContainerModifierHeight, RectangleContainerModifierRestitutionCoefficient,
                RectangleLoopContainerModifierWidth, RectangleLoopContainerModifierHeight,
                ModifiersInterpolatorsSelectedName,
                AgeModifierColorInterpolatorStartValue, AgeModifierColorInterpolatorEndValue,
                AgeModifierHueInterpolatorStartValue, AgeModifierHueInterpolatorEndValue,
                AgeModifierOpacityInterpolatorStartValue, AgeModifierOpacityInterpolatorEndValue,
                AgeModifierRotationInterpolatorStartValue, AgeModifierRotationInterpolatorEndValue,
                AgeModifierScaleInterpolatorStartValueX, AgeModifierScaleInterpolatorStartValueY, AgeModifierScaleInterpolatorEndValueX, AgeModifierScaleInterpolatorEndValueY,
                VelocityModifierColorInterpolatorStartValue, VelocityModifierColorInterpolatorEndValue,
                VelocityModifierHueInterpolatorStartValue, VelocityModifierHueInterpolatorEndValue,
                VelocityModifierOpacityInterpolatorStartValue, VelocityModifierOpacityInterpolatorEndValue,
                VelocityModifierRotationInterpolatorStartValue, VelocityModifierRotationInterpolatorEndValue,
                VelocityModifierScaleInterpolatorStartValueX, VelocityModifierScaleInterpolatorStartValueY, VelocityModifierScaleInterpolatorEndValueX, VelocityModifierScaleInterpolatorEndValueY,
                IsDragModifierSelected, DragModifierDragCoefficient, DragModifierDensity,
                IsLinearGravityModifierSelected, LinearGravityModifierDirectionX, LinearGravityModifierDirectionY, LinearGravityModifierStrength, LinearGravityModifierControlSizeBuffer, LinearGravityModifierControlDuration,         
                IsOpacityFastFadeModifierSelected, OpacityFastFadeModifierControlDuration, OpacityFastFadeModifierControlSizeBuffer,
                IsRotationModifierRotationRate, RotationModifierRotationRate,
                IsVelocityColorModifierSelected, VelocityColorModifierVelocityColor, VelocityColorModifierStationaryColor,
                IsVelocityModifierInterpolatorSelected, VelocityColorModifierVelocityThreshold, VelocityModifierVelocityThreshold, VelocityModifiersInterpolatorsSelectedName,
                IsVortexModifierSelected, VortexModifierMass, VortexModifierMaxSpeed, VortexModifierPositionX, VortexModifierPositionY,
                TextBoxTextureRegionDefinitions, TextBoxCapacityDefinitions, TextBoxLifeSpanDefinitions));
        }

        protected override void Initialize()
        {
            graphics = new WpfGraphicsDeviceService(this);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            DebugFont = Content.Load<SpriteFont>("DebugFont");
        }

        protected override void Update(GameTime gameTime)
        {
            mousePointerPos = System.Windows.Input.Mouse.GetPosition(this);
            ViewPortWidth = graphics.GraphicsDevice.Viewport.Width;
            ViewPortHeight = graphics.GraphicsDevice.Viewport.Height;
            
            if(ParticleMode == false)
            {
                if (System.Windows.Input.Mouse.LeftButton == System.Windows.Input.MouseButtonState.Pressed && oldState == "Released"
               && mousePointerPos.X >= graphics.GraphicsDevice.Viewport.X
               && mousePointerPos.X <= graphics.GraphicsDevice.Viewport.Width
               && mousePointerPos.Y >= graphics.GraphicsDevice.Viewport.Y
               && mousePointerPos.Y <= graphics.GraphicsDevice.Viewport.Height)
                {
                    GenerateParticleEffect(new Vector2((float)mousePointerPos.X, (float)mousePointerPos.Y));
                }
            }
            else
            {             
                if (listParticlesEffect.Count < 1)
                    GenerateParticleEffect(new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2));
            }
         
            if (listParticlesEffect.Count != 0)
            {
                foreach (ParticlesEffect particlesEffect in listParticlesEffect)
                {
                    if (particlesEffect.IsParticleAlive)
                        particlesEffect.ParticlesUpdate(gameTime);
                    else
                    {
                        listParticlesEffect.Remove(particlesEffect);
                        break;
                    }
                }
            }

            oldState = System.Windows.Input.Mouse.LeftButton.ToString() ;

            base.Update(gameTime);
        }
     
        public string DisplayDim { get { return displayDim; }set { displayDim = value; } }

        public bool IsLinearGravityModifier { get; internal set; }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Transparent);

            spriteBatch.Begin();

            if (listParticlesEffect.Count > 0)
                listParticlesEffect[0].ParticlesDrawDebug(spriteBatch, DebugFont, new Vector2(0, 50), listParticlesEffect.Count.ToString());
           //spriteBatch.DrawString(DebugFont, iN.ToString(), new Vector2(0, 0), Color.Red);

            if (listParticlesEffect.Count != 0)
                foreach (ParticlesEffect particlesEffect in listParticlesEffect)
                    spriteBatch.Draw(particlesEffect.Particle);                 

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
