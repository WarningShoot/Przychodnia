   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Przychodnia.Windows.VisitPrzychodnia.Windows.Visit  5      5    /Przychodnia.Windows.Visit.WindowViewListOfVisit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Przychodnia.Windows.Visit     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5           MaterialDesignBody#���   5
   	     MaterialDesignPaper  N� 
Background#  �  5   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	    N� Title$ List of Visit��5   	   $	��600��5      $
��1450��6    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��20q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   .��5      �� $��Center=�6   $��Center=�63   $��List Of Visit��6P   $��30(�6e   
�������6s   5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridListOfVisit��5      $	��450��64   $
��1450��6A      AutoGenerateColumns$ False��6N   	   CanUserAddRows$	 False��6j   
   CanUserDeleteRows$
 False��6�      SelectionMode$ Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68      
IsReadOnly$
 True��6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	Doctor_id+6b     5      $ NamePatient��68   $
 True��6f    6M   �� *Name+6f     5      $ SurnamePatient��68   $
 True��6l    6P   �� *	Surname+6l     5       $ Phone number��68   $
 True��6n    6N   �� *PhoneNumber+6n     5!      $ Personal ID Number��68   $
 True��6t    6T   �� *PhoneNumber+6t     5"      $ DateOfVisit��68   $
 True��6m    6M   �� *PhoneNumber+6m     5#      $ Doctor��68   $
 True��6h    6H   �� *PhoneNumber+6h     5$      $ Degree of doctor��68   $
 True��6m    6R   �� *Degree+6m     5%      $ Specialization��68   $
 True��6s    6P   �� *Specialization+6s     5&      $ Type of specialization��68   $
 True��6�    6X   �� *TypeOfSpecialization+6�     5'      $ Office��68   $
 True��6q    6H   �� *TypeOfSpecialization+6q   4  .System.Windows.Controls.DataGridCheckBoxColumn  5(      $ Confirmation Of The Visit��6-   $
 True��6k    6P   �� *Active+6k     5)      $ To Pay��68   $
 True��6q    6H   �� *TypeOfSpecialization+6q   5+      � 5,       � ColumnDefinitions 5-      �� 5.      $��* �6'   �� 5/      $��* �6'   �� 50      $��* �6'   �� 51      $��* �6'   .+�54      �� -   5        $��	ButtonAdd��54      $	��Add��6B   $��15(�6P   
�������$��0��6w   $��20q�6�   �� 55      -   5        $��
ButtonEdit��55      $
��Edit��6D   $��15(�6S   
�������$��1��6z   $��20q�6�   �� 56      -   5        $��ButtonViewDetails��56      $��View details��6R   $��15(�6i   
�������$��2��6�   $��20q�6�    J� RenderTransformOrigin$ 1.598,0.487&�6�   �� 57      -   5        $��ButtonCancel��57      $��Cancel��6H   $��15(�6Y   
�������$��3��6�   $��20,20,20,20q�6�   5:      5;      5<      5=      