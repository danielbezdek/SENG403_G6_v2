   M S B A M L   `   `   `  ����P  LSENG403_AlarmClock_V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SENG403_AlarmClock_V2SENG403_AlarmClock_V2  5   	   *    $SENG403_AlarmClock_V2.GlobalSettings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SENG403_AlarmClock_V2     5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � WindowStyle$
  None=�5	   	   ���#efefef � Title$ GlobalSettings��5   	   $	��203��6    $	��235��6-   .��5      � -   5        .+�5   
   �� -   5         ��Name$ 
textBlock2��5      $
��Left=�6(   $
��Wrap=�6C   $	��Top=�6W   $	��203��6o   $	��235��6|   �� 5   
   -   5         ��Name$ Title_Label��5      $��Center=�6%   
���   �$��Settings��6\   $��Center=�6o   $��0,10,0,0q�6�   $	��Top=�6�   $��20(�6�   $	��227��6�    J� RenderTransformOrigin$ 0.242,0.435&�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$
 Done��5      $
��Done��6   $
��Left=�6.   $��131,148,0,0q�6I   $	��Top=�6^   $��75��6v   $ 0.038,0.393&�6�   6�   �� 5   
   -   5        $ Cancel��5      $��Cancel��6!   $
��Left=�62   $��
22,148,0,0q�6M   $	��Top=�6a   $��75��6y   6�   �� 5   
   -   5        $ Title_Label_Copy��5      
���   �$��Snooze Time��6=   $��Center=�6S   $��
22,52,33,0q�6p   $	��Top=�6�   $��16(�6�   $	��172��6�   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -   5          Name$ Snooze_Selector��5      $
��Left=�66   $��	25,98,0,0q�6Q   $	��Top=�6d   $��60��6|   �� 5   
   -   5        $ 	textBlock��5      
���   �$
��Left=�6:   $��	98,99,0,0q�6U   $
��Wrap=�6h   $��	Minute(s)��6|   $	��Top=�6�   $��14(�6�   $ 0.507,0.235&�6�   �� 5   
   -	   5        $ 
textBlock1��5      $
��Left=�6(   $��317,184,-32,-36q�6C   $
��Wrap=�6\   $��	TextBlock��6p   $	��Top=�6�   5      5      