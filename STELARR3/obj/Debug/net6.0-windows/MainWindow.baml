   M S B A M L   `   `   `  ����C  ?STELARR3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:STELARR3STELARR3  5   	       STELARR3.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:STELARR3     5   	   -   5        
���   �  � Title$  STELARR��5   	   $	��450��6   $	��800��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   .��5      � .+�5   
   � -   5         �Name$ 	dashboard��5   5   $��10q�6   
������� � RowDefinitions 5      �� 5      $��* �6    �� 5      $��9* �6     � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $��* �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ LoadHomeBtn��5      $��0,0,10,0q�6.   $��80��6@   $
��Bold"�6K   .��6w   Home5      �� 5      -   5        $ LoadLibraryBtn��5      $��0,0,10,0q�61   $��80��6C   $
��Bold"�6N   .��6}   	Library5      �� 5      $��0,0,10,0q�6   $��80��6+   $
��Bold"�66   .��6H   	Quizzes5!      �� 5"      $��0,0,10,0q�6   $��80��6+   $
��Bold"�66   .��6H   	Gradebook5$      �� 5%      $��0,0,10,0q�6   $��80��6+   $
��Bold"�66   .��6H   
Settings5'      5(      �� 5)      $��1��6   $��Right=�6C   $��Center=�6_   $
��Bold"�6z   $��Italic$�6�   
�������$	��200��6�   $��30��6�   $��20(�6�   $��Right=�6�   ��6$   ��  �� Path$ Clock�6�   �� 5,      -   5        	 ��Name$	 
activeView��5,   >   $��1��6   $��2��6*   .��5-      �� $��Center=�6   $��Center=�69   $��60(�6T   Welcome to STELARR!5/      50      51      �� 52   
   -   5        $	 screen��52      53      54      55      