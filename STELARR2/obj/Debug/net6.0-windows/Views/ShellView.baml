   M S B A M L   `   `   `  ����C  ?STELARR2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:STELARR2.ViewsSTELARR2.Views  5   	       STELARR2.Views.ShellView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:STELARR2.Views     5   	   
���   �  � Title$  	ShellView��5   	   $	��450��6   $	��800��6(    � 
ResizeMode$ NoResize=�64   .��5	      � $��10q�6   
���   � � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��9* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ MenuBarIsVisible��5       �� Orientation$ 
Horizontal=�6/   .+�5      �� -   5         ��Name$ LoadHome��5      $��0,0,10,0q�6'   $��80��69   $
��Bold"�6D   .��6V   Home5      �� 5      -   5        $ LoadLibrary��5      $��0,0,10,0q�6*   $��80��6<   $
��Bold"�6G   .��6Y   	Library5      �� 5      $��0,0,10,0q�6   $��80��6'   $
��Bold"�62   .��6D   	Quizzes5      �� 5      $��0,0,10,0q�6   $��80��6'   $
��Bold"�62   .��6D   	Gradebook5       �� 5!      $��0,0,10,0q�6   $��80��6'   $
��Bold"�62   .��6D   
Settings5#      5$      �� 5%   
   $��1��6   $��Right=�6?   $��Center=�6[   $
��Bold"�6v   $��Italic$�6�   
�������$	��200��6�   $��30��6�   $��20(�6�   $��Right=�6�   ��6    ��  �� Path$ Clock�6�   �� 5(   
   -   5         ��Name$ 
ActiveItem��5(   :   $��1��6   $��2��6&   .��6N   New Content Control here5*      5+      5,      