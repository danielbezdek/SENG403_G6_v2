   M S B A M L   `   `   `  ����P  LSENG403_AlarmClock_V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SENG403_AlarmClock_V2SENG403_AlarmClock_V2  5      ,    &SENG403_AlarmClock_V2.AlarmUserControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SENG403_AlarmClock_V2     5      $��80��5	        � 	Resources  5
         AnimatedSwitch �� 
TargetType �� Property �� Value �� 
TargetType (� Stretch �� Left
 �� Top A�Name	 T� X
 T� Y J� BitmapEffect F� Softness F� ShadowDepth F� 	Direction F� Color �� Triggers P� Property P� Value N� EnterActions �� TargetProperty	 �� To g� Duration �� 
TargetName O� KeyTime O� Value �� 	KeySpline N� ExitActions�� 5   
   %�  &	        �� 5      " d�6+   .�5      ��  � ��
 �   �6/   �� 5       � �� �#FAFAFB6/   �� 5       � �� �#EAEAEB60   �� 5       � �� 5      �� 5      " d�6*   .R�5      (� $ Uniform=�6&   .��5   "   �� $��Layer_1��6)   $��20��68   $��20��6C   $ 10��6O   $ 0��6`   .+�5   &   A� $ 0��6/   $��20��6?   $��20��6J   #��z��6V   #��z��6z   $	��0.5��6�   A� 5   &   $ 15��6/   $��20��6@   $��20��6K   #��z��6W   #��z��6{   $	��0.5��6�   �� 5   &   $��
rect416927��6U   $ 10��6-   $��15��6>   $��20��6I   #��z��6g   #��z��6�   $��0,0.5,0,0.5q�6�   A� 5   &   $ ellipse��6.   $ 0��6@   $��20��6P   $��20��6[   
�������#��z��6t   $	��0.3��6�   z�5   *   T� 5   .   $	 0Q�6A   $
 0Q�6G    5   *   F� 5   .   $	 0.1Q�6E   $	 0.7Q�6T   $	 270Q�6f   $ #BBBBBB��6v   5   '   5    #   5!       5"      P� 5#   "    �@d�	IsChecked$
 TrueY�6?    5$   &   �� 5%   *   .��5&   .   �� .��5'   2   �� $ Background.Color�6A   $ #52D468X�6n   $ 0:0:0.2D�6{   �� 5(   2   $ BorderBrush.Color�6A   $ #41C955X�6o   $ 0:0:0.2D�6|   U� 5)   2   $6 0(Ellipse.RenderTransform).(TranslateTransform.X)�6P   $ ellipse��6�   .\�5*   6   �� $ 0��6K    06W   �� 5+   6   $ 0:0:0.4��6K   $ 0, 1, 0.6, 1��6h    156]   6h   5,   3   5-   /   5.   +    50   &   �� 51   *   .��52   .   �� .��53   2   �� $ Background.Color�6A   $ #8f8f91X�6n   $ 0:0:0.2D�6{   �� 54   2   $ BorderBrush.Color�6A   $ #c9c9ccX�6o   $ 0:0:0.2D�6|   U� 55   2   $6 0(Ellipse.RenderTransform).(TranslateTransform.X)�6P   $ ellipse��6�   .\�56   6   �� $ 0��6K    156W   �� 57   6   $ 0:0:0.3��6K   $ 0, 0.5, 0.5, 1��6g    06]   6g   58   3   59   /   5:   +   5<   #   5>      5@      5A      5B      .��5D      �� 
������ $��2,2,2,10q�6'   ._�5F   
   � ���#efefef.+�5I      �� -   5         ��Name$ AlarmType_label��5I      
���   �$��Daily��6@   $
��Left=�6P   $	��Top=�6k   $��	10,40,0,0q�6�   $��28��6�    J� RenderTransformOrigin$ 	0.5,0.821&�6�   �� 5K      -   5        $ AlarmTime_label��5K      
���   �$��
4:20:00 am��6@   $
��Left=�6U   $��	10,18,0,0q�6p   $	��Top=�6�   $��30��6�   $	��201��6�   $��14(�6�   �� 5L      -   5         ��Name$ EditAlarm_Button��5L      ���#16a3ff
�������$
��Edit��6W   $
��Left=�6f   $��
180,41,0,0q�6�   $	��Top=�6�   $��33��6�   $ 0.2,0.5&�6�   $��22��6�   $��0q�6�   6�   �� 5M      -   5        $ DeleteAlarm_Button��5M      
���   �$
��Left=�6D   $��	216,0,0,0q�6_   $	��Top=�6r   $��15��6�   $��15��6�   $ 	0.333,0.2&�6�   .��5N      �� $0��*pack://application:,,,/Images/x_button.png��6    �� BitmapScalingMode$
 Fant=�6L   6u   5O      �� 5P      -   5        $ ReminderLabel��5P      $��Alarm��6+   $
��Left=�6;   $	��Top=�6V   $	��206��6n   $
��Bold"�6z   $��15(�6�   $��27��6�   $��	10,-4,0,0q�6�   d� 5Q      -   5          d�Name$  EnableAlarmToggleButton��5Q      #��[  6<   ���#c9c9cc$
��Left=�6y   $��
164,15,0,0q�6�   $	��Top=�6�   $��54��6�   $��17��6�   5S      5T      5U      5W      