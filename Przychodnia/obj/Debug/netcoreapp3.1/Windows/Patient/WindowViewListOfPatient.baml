   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Przychodnia.Windows.PatientPrzychodnia.Windows.Patient  5      9    3Przychodnia.Windows.Patient.WindowViewListOfPatient   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Przychodnia.Windows.Patient     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5           MaterialDesignBody#���   5   	     MaterialDesignPaper  N� 
Background#  �  5   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	    N� Title$ WindowListOfPatient��5   	   $	��600��6%   $
��1000��62    N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��20q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   .��5      �� $��Center=�6   $��Center=�63   $��List Of Patient��6P   $��30(�6g   
�������6u   5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridListOfPatient��5      $	��450��66   $
��1000��6C      AutoGenerateColumns$ False��6P   	   CanUserAddRows$	 False��6l   
   CanUserDeleteRows$
 False��6�      SelectionMode$ Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68      
IsReadOnly$
 True��6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	Doctor_id+6b     5      $
 Name��68   $
 True��6_    6F   �� *Name+6_     5      $ Surname��68   $
 True��6e    6I   �� *	Surname+6e     5       $ Phone number��68   $
 True��6n    6N   �� *PhoneNumber+6n     5!      $ Personal ID Number��68   $
 True��6w    6T   �� *Specialization+6w     5"      $ Date of birth��68   $
 True��6r    6O   �� *StrDateOfBirth+6r     5#      $ Email��68   $
 True��6b    6G   �� *Degree+6b   4  .System.Windows.Controls.DataGridCheckBoxColumn  5$      $ Active��6-   $
 True��6X    6=   �� *Active+6X     5%      $ Inactive��6-   $
 True��6Z    6?   �� *Active+6Z   5(      � 5)       � ColumnDefinitions 5*      �� 5+      $��* �6'   �� 5,      $��* �6'   �� 5-      $��* �6'   �� 5.      $��* �6'   .+�50      �� -   5        $��	ButtonAdd��50      $	��Add��6B   $��15(�6P   
�������$��0��6w   $��20q�6�   �� 51      -   5        $��
ButtonEdit��51      $
��Edit��6D   $��15(�6S   
�������$��1��6z   $��20q�6�   �� 52      -   5        $��ButtonViewDetails��52      $��View details��6R   $��15(�6i   
�������$��2��6�   $��20q�6�   �� 53      -   5        $��ButtonRemove��53      $��Remove��6-   $��15(�6>   
�������$��3��6e   $��20q�6u    � Cursor$
 Hand��6�   6�   55      56      57      58      