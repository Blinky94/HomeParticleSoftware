   M S B A M L   `   `   `  ����P  LHomeParticlesSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HomeParticlesSoftwareHomeParticlesSoftware  5   	   N JColourSliderLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:ColourSliderLibrary;assembly=ColourSliderLibraryColourSliderLibrary 5   	   &     HomeParticlesSoftware.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HomeParticlesSoftware     5   	   Ls>clr-namespace:ColourSliderLibrary;assembly=ColourSliderLibrary     5   	     � Title$  
MainWindow��5	   	   $
��1000��6   $
��1200��6*    � 	Resources 5
      7   1HomeParticlesSoftware.EnumMatchToBooleanConverter   enumConverter��%   &	          5   
   6,   5      .��5      � ���#3c3750 � ColumnDefinitions 5   
   �� 5      $	��600 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $	��200 �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   $��0��6'   $��3��64   
������ $
��auto��5      $��Visible=�5      $��Hidden=�5      $��	10,0,10,0q�6E   .��5       ��  �� Orientation$ Vertical=�6   $��Stretch=�60   $��Stretch=�6L   .+�5"      �   MainTitleStyle#��[ 6   
������ $
��auto��6X    5#      �� 5$      $	��150 �6+   �� 5%      $��* �6+   .+�5'      �� $��INFORMATION��6   $
��Bold"�62   $��1q�6D   $��0��6X   �� 5(      -   5        $��CheckBoxInformation��5(      $��Center=�6:   $��1��5+      5,      � 5.      -   5        $��InformationDetails��5.      $y�	Collapsed=�61    5/      �� 50      $��* �6+    52      �� 53      $��* �6(   �� 54      $��* �6(   �� 55      $��* �6(   �� 56      $��* �6(   58      � 5;      #��[ 6    5<      �� 5=      $	��150 �6+   �� 5>      $��* �6+   .+�5@      �� $��
DEFINITION��6   $
��Bold"�61   $��1q�6C   $��0��5A      �� 5B      -   5        $��CheckBoxDefinition��5B      $��Center=�69   $��1��5E      5F      � 5H      -   5        $��DefinitionsDetails��5H      $��Stretch=�61   $��Center=�6O   $y�	Collapsed=�5I       5J      �� 5K      $��* �6+    5M      �� 5N      $��* �6(   �� 5O      $��* �6(   �� 5P      $��* �6(   �� 5Q      $��* �6(   �� 5R      $��* �6(   .+�5V      �� -   5        $*��$SliderCapacityAndLifeSpanDefinitions��5V   !   $ 
Horizontal=�6M   $��Center=�5W   !   $��Center=�6>   ���#25265c$��0��5Y   !   $��2��61   5Z      � 5]      $��0��6   $��3��6+    5^      �� 5_      $��50 �6/   �� 5`      $��* �6/    5b      �� 5c      $��* �6,   �� 5d      $��* �6,   .+�5g      �� $��Profile��6    $��0��62   $��0��6C   $��Right=�5h      $��Center=�68   �� 5j      -   5        $ ��ComboBoxProfileDefinitions��5j   #   $
��auto��6E   $��Center=�6S   $��0��5k   $   $��Stretch=�62   $��Center=�5l      $��Center=�6:   $��1��5m       �� SelectedIndex$ 6��6/   .@�5n      �� -   5        $��ProfileBoxFill��5n   +   $��BoxFill��6A   6S   �� 5o      -   5        $��
ProfileBox��5o   +   $	��Box��6=   6K   �� 5p      -	   5        $��ProfileBoxUniform��5p   +   $��
BoxUniform��6D   6Y   �� 5q      -
   5        $��ProfileCircle��5q   +   $��Circle��6@   6Q   �� 5r      -   5        $��ProfileLine��5r   +   $
��Line��6>   6M   �� 5s      -   5        $��ProfileRing��5s   +   $
��Ring��6>   6M   �� 5t      -   5        $��ProfilePoint��5t   +   $��Point��6?   6O   �� 5u      -   5        $��ProfileSpray��5u   +   $��Spray��6?   6O   5v      5w      �� 5z      -   5        $��ProfilDetails��5z   !   $y�	Collapsed=�66   $ 
Horizontal=�6M   ���#25265c$
��auto��6|   $��0��5{   %   $��2��65   $��4��6I   $��Center=�5|   %   $��Center=�6B   5}      � 5�      #��[ 6    5�      �� 5�      $	��150 �6+   �� 5�      $��* �6+   .+�5�      �� $��EMITTER PARAMETERS��6   $
��Bold"�69   $��1q�6K   $��0��6_   �� 5�      -   5        $��CheckBoxEmitterParameters��5�      $��Center=�6@   $��1��5�      5�      �� 5�      -   5        $��EmitterParameterBlock��5�      
������ $y�	Collapsed=�6U   $	��542��5�      $
��auto��6#   $��Stretch=�61   $��Hidden=�5�      $��Visible=�5�      .��5�      � -   5        $"��EmitterParameterControlsGrid��5�      $��0��6?   $
��Left=�6O    5�      �� 5�      $
��auto �6/   5�      5�      � 5�      #��[ 6    5�      �� 5�      $	��150 �6+   �� 5�      $��* �6+   .+�5�      �� $��EMITTER MODIFIERS��6   $
��Bold"�68   $��1q�6J   $��0��5�      $��0��6,   �� 5�      -   5        $��CheckBoxEmitterModifiers��5�      $��Center=�6?   $��1��5�      $��1��6/   $	��0,6q�6C   5�      �� 5�      -   5        $��EmitterModifiersBlock��5�      $ Vertical=�6:   $y�	Collapsed=�5�      .+�5�      �� $ 
Horizontal=�6!   .+�5�      �� $��CONTAINERS MODIFIER��6    $��Center=�6>   $��Center=�6[   $	��200��6v   �� 5�      -   5        $ ��CheckBoxCOntainersModifier��5�   #   $
��Left=�6n   $��Center=�6�   5�      �� 5�      -   5        $��StackContainersModifiers��5�   !   $y�	Collapsed=�6A   $ Vertical=�6X   ���#25265c$
��auto��6�   .+�5�      � $��0��6   $��3��6/    5�      �� 5�   "   $��70 �63   �� 5�   "   $��* �63    5�      �� 5�   "   $��* �60   �� 5�   "   $��* �60   .+�5�      �� $��
Containers��6$   $��0��69   $��0��6I   $
��Left=�6V   $��Center=�6q   �� 5�      -   5        $'��!ComboBoxContainersModifierControl��5�   '   $
��auto��6P   $��Center=�6^   $��0��5�   #   $��Stretch=�61   $��Center=�6O   $��Center=�6j   $��1��5�      $ 1��6/   .@�5�   "   �� -   5        $��CircleContainerModifier��5�   /   $��CircleContainerModifier��6N   6p   �� 5�   "   -   5        $ ��RectangleContainerModifier��5�   /   $ ��RectangleContainerModifier��6Q   6v   �� 5�   "   -   5        $$��RectangleLoopContainerModifier��5�   /   $$��RectangleLoopContainerModifier��6U   6~   5�      �� 5�      -   5        $��ContainerDetails��5�   )   $y�Visible=�6A   $ 
Horizontal=�6V   $
��auto��6o   $��0��6}   $��2��6�   $��1��6�   $��Center=�5�   !   $��Center=�6>   5�      5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��AGE MODIFIER��6    $��Center=�67   $��Center=�6T   $	��200��6o   �� 5�      -   5        $��CheckBoxAgeModifier��5�   #   $
��Left=�6`   $��Center=�6{   5�      � 5�      -   5        $ ��GridModifiersInterpolators��5�      $��Center=�6=   ���#25265c$��Stretch=�6m   $y�	Collapsed=�6�    5�      �� 5�      $	��100 �6/   �� 5�      $��* �6/    5�      �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   .+�5�      �� $��Interpolators��6    $��0��68   $��2��6H   $��0��6\   $
��Left=�5�       $��20q�6;   $��Center=�6G   �� 5�      -   5        $$��ComboBoxModifiersInterpolators��5�   #   $
��auto��6I   $��Center=�6W   $��Stretch=�5�   #   $��Center=�6A   $��Center=�6\   $��1��5�   #   $��3��63   $��0��6H   .@�5�      �� -   5        $��ModifierColorInterpolator��5�   +   $��ColorInterpolator��6L   6h   �� 5�      -    5        $��ModifierHueInterpolator��5�   +   $��HueInterpolator��6J   6d   �� 5�      -!   5        $!��ModifierOpacityInterpolator��5�   +   $��OpacityInterpolator��6N   6l   �� 5�      -"   5        $"��ModifierRotationInterpolator��5�   +   $��RotationInterpolator��6O   6n   �� 5�      -#   5        $��ModifierScaleInterpolator��5�   +   $��ScaleInterpolator��6L   6h   5�      �� 5�      -$   5        $"��ModifierInterpolatorsDetails��5�   %   $y�	Collapsed=�6I   $ 
Horizontal=�6`   $
��auto��5�   %   $��3��63   $��0��6@   $��2��6P   $��Center=�5�   !   $��Center=�6>   5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��DRAG MODIFIER��6    $��Center=�68   $��Center=�6U   $	��200��6p   �� 5�      -%   5        $��CheckBoxDragModifier��5�   #   $
��Left=�6b   $��Center=�6}   5�      2   ,HomeParticlesSoftware.HueInterpolatorControl  5�      -&   5          Name$! DragModifierModifierControl��5�   3   $��Center=�5�   3   $��Center=�6P   $y�	Collapsed=�5�   X   �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��LINEAR GRAVITY MODIFIER��6    $��Center=�6B   $��Center=�6_   $	��200��6z   �� 5�      -'   5        $#��CheckBoxLinearGravityModifier��5�   #   $
��Left=�6t   $��Center=�6�   $y�Visible=�5�   #   5�      �� 5�      -(   5        $,��&LinearGravityModifierControlStackPanel��5�   !   $ 
Horizontal=�6O   $y�	Collapsed=�6h   $��Center=�6   .+�5�      /   )HomeParticlesSoftware.LineAndSprayControl  -)   5          Name$" LinearGravityModifierControl��5�   0   $��Stretch=�5�   4   $��Center=�6R   $y�Visible=�5�   V   .   (HomeParticlesSoftware.SliderFloatControl  5�      -*   5          Name$* $LinearGravityModifierControlDuration��5�   0   $��Stretch=�5�   3   $��Center=�6Q   $y�Visible=�5�   ^   ���#25265c$	��220��6�   ,   &HomeParticlesSoftware.SliderIntControl  5�      -+   5        	  Name$,	 &LinearGravityModifierControlSizeBuffer��5�   0   $��Stretch=�5�   1   $��Center=�6O   $y�Visible=�5�   `   ���#25265c$	��220��6�   5�      �� 5�      $ 
Horizontal=�6!   .+�5      �� $ ��OPACITY FAST FADE MODIFIER��6    $��Center=�6E   $��Center=�6b   $	��200��6}   �� 5     -,   5        $%��CheckBoxOpacityFastFadeModifier��5  #   $
��Left=�6x   $��Center=�6�   5     �� 5     --   5        $.��(OpacityFastFadeModifierControlStackPanel��5  !   $ 
Horizontal=�6Q   $y�	Collapsed=�6j   $��Center=�6�   ���#25265c.+�5       -.   5        $, &OpacityFastFadeModifierControlDuration��5  3   $��Center=�5  3   $��Center=�6P   $y�Visible=�5  c   $	��220��6x     5     -/   5        $.	 (OpacityFastFadeModifierControlSizeBuffer��5  1   $��Center=�5  1   $��Center=�6N   $y�Visible=�5  c   $	��220��6x   5     �� 5
     $ 
Horizontal=�6!   .+�5     �� $��ROTATION MODIFIER��6    $��Center=�6<   $��Center=�6Y   $	��200��6t   �� 5     -0   5        $��CheckBoxRotationModifier��5  #   $
��Left=�6j   $��Center=�6�   5       5     -1   5        $( "SliderRotationRateRotationModifier��5  /   $��Center=�5  /   $��Center=�6L   $y�	Collapsed=�5  [   ���#25265c6r   �� 5     $ 
Horizontal=�6!   .+�5     �� $��VELOCITY COLOR MODIFIER��6    $��Center=�6B   $��Center=�6_   $	��200��6z   �� 5     -2   5        $#��CheckBoxVelocityColorModifier��5  #   $
��Left=�6t   $��Center=�6�   5     8   2HomeParticlesSoftware.VelocityColorModifierControl  5     -3   5        
  Name$
 VelocityColorModifier��5  9   $��Center=�5  9   $��Center=�6V   $y�	Collapsed=�5  X   �� 5     $ 
Horizontal=�6!   .+�5     �� $��VELOCITY MODIFIER��6    $��Center=�6<   $��Center=�6Y   $	��200��6t   �� 5     -4   5        $��CheckBoxVelocityModifier��5  #   $
��Left=�6j   $��Center=�6�   5     � 5     -5   5        $(��"GridVelocityModifiersInterpolators��5     $��Center=�6E   ���#25265c$��Stretch=�6u   $y�	Collapsed=�6�    5      �� 5!     $	��100 �6/   �� 5"     $��* �6/    5$     �� 5%     $
��auto �6,   �� 5&     $
��auto �6,   .+�5)     �� $��Interpolators��6    $��0��68   $��2��6H   $��0��6\   $
��Left=�5*      $��20q�6;   $��Center=�6G   �� 5,     -6   5        $,��&ComboBoxVelocityModifiersInterpolators��5,  #   $
��auto��6Q   $��Center=�6_   $��Stretch=�5-  #   $��Center=�6A   $��Center=�6\   $��1��5.  #   $��3��63   $��0��6H   .@�5/     �� -7   5        $'��!VelocityModifierColorInterpolator��5/  +   $��ColorInterpolator��6T   6p   �� 50     -8   5        $%��VelocityModifierHueInterpolator��50  +   $��HueInterpolator��6R   6l   �� 51     -9   5        $)��#VelocityModifierOpacityInterpolator��51  +   $��OpacityInterpolator��6V   6t   �� 52     -:   5        $*��$VelocityModifierRotationInterpolator��52  +   $��RotationInterpolator��6W   6v   �� 53     -;   5        $'��!VelocityModifierScaleInterpolator��53  +   $��ScaleInterpolator��6T   6p   54     �� 55     -<   5        $*��$VelocityModifierInterpolatorsDetails��55  %   $y�	Collapsed=�6Q   $ 
Horizontal=�6h   $
��auto��56  %   $��1��63   $��0��6@   $��2��6P   
������ $��Center=�57  !   $��Center=�6>   58     �� 5:     $ 
Horizontal=�6!   .+�5;     �� $��VORTEX MODIFIER��6    $��Center=�6:   $��Center=�6W   $	��200��6r   �� 5<     -=   5        $��CheckBoxVortexModifier��5<  #   $
��Left=�6f   $��Center=�6�   5=     �� 5?     ->   5        $��VortexModifierStackPanel��5?  !   $ 
Horizontal=�6A   $��Center=�6Z   ���#25265c$y�	Collapsed=�6�   .+�5@     .   (HomeParticlesSoftware.MinMaxFloatControl  -?   5          Name$ VortexModifierPosition��5@  3   $��0��6S   $��1��5A  &   $��Center=�63     5B     -@   5        $ VortexModifierMaxSpeed��5B  3   $��1��6S   $��1��5C  &   $��Center=�63     5D     -A   5        $ VortexModifierMass��5D  3   $��2��6O   $��1��5E  &   $��Center=�63   5F     5G     5I     5J     �� 5M  
   $��0��6   $��4��6%   $��3��62   $��Center=�6C   .+�5N     �� $ 
Horizontal=�6   $��Center=�64   .+�5O     �� -B   5        $��NewXml��5O     $��1��6'   $��4q�64   $��New XML��5P     $	��100��6#   $��30��6/   5Q     �� 5R     -C   5        $��LoadXml��5R     $��1��6(   $��4q�65   $��Load XML��5S     $	��100��6$   $��30��60   5T     �� 5U     -D   5        $��SaveXml��5U     $��1��6(   $��4q�65   $��Save XML��5V     $	��100��6$   $��30��60   5W     5X     5Y     ]� 5\  
   -E   5        $��ParticleVisualisation��5\     $��1��61   $��0��6A   
����  �$��10q�6`   .+�5]     "   HomeParticlesSoftware.MyGame  $
��auto��6   $
��auto��6(   $��Stretch=�66   $��Stretch=�5^     5_     �� 5b  
   $��1��6   $��1��6%   $ 
Horizontal=�62   $
��Left=�6K   $��Center=�6f   $��50��6�   .+�5c     	� -F   5        $��ClickModeParticleEffect��5d      	� 	GroupName$ ParticleMode��5c     $��Mouse Pointer Mode��5e     $��Right=�5f     $��Center=�5g      d� 	IsChecked 5i     ��  �� Path$ CurrentOption� �� Mode$ TwoWay=� �� 	Converter# [   �� ConverterParameter$ ParticleMode��	� 5l     -G   5        $��AutoParticleModeEffect��5m     $ ParticleMode��5l     $��1��5n     $��Auto Particle Mode��5o     $
��Left=�5p      5r     �� $ CurrentOption�$ TwoWay=�# [  $ ParticleMode��8	   2HomeParticlesSoftware.SliderHorizontalFloatControl	  5u     -H   5         	 Name$ SliderFloatParticleMode��5u  1   $	��400��5v  1   $��Stretch=�5w  1   $��Center=�5x  1   5y     �� 5|  
   -I   5        $��borderImagesToParticles��5|     $��1��5}     $��2��6   $��Stretch=�5~     $��Center=�6+   .+�5     �� -J   5        $��ListViewImagesToPaticles��5     $��Visible=�5�     
���   � �� SelectionMode$ Single=�5�     ��5�     �� ��5�     �� 5�     .R�5�     �� $ 
Horizontal=�6%   $��Stretch=�6>   $��Center=�6\   5�     5�     5�     5�     � 5�  
   $��1��6   $��3��6    5�     �� 5�     $��* �6#   �� 5�     $��50 �6#   .+�5�     �� -K   5        $��TextBoxTexturesBrowser��5�     $��Stretch=�64    �� TextAlignment$
 Left=�6R   $��0��6g   $��Center=�6w   �� 5�     -L   5        $��ButtonTexturesBrowser��5�     $	��...��62   $��0 0 10 0q�6@   $��30��6R   $��1��6^   6n   5�     5�     5�     