   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Przychodnia.Windows.VisitPrzychodnia.Windows.Visit  5      ;    5Przychodnia.Windows.Visit.WindowViewListOfResultVisit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Przychodnia.Windows.Visit     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5           MaterialDesignBody#���   5
   	     MaterialDesignPaper  N� 
Background#  �  5   	   $��Medium"�5   	   $��14(�5   	    �� BitmapScalingMode$ HighQuality=�5   	    � UseLayoutRounding$
 True��5   	   $	��600��5      $
��1000��6    N� Title$! WindowViewListOfResultVisit��5       N� 
FontFamily 5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��20q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   .��5      �� $��Center=�6   $��Center=�63   $��ListOfResultVisit��6P   $��30(�6i   
�������6w   5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridListOfResultVisit��5      $	��450��6:   $
��1000��6G      AutoGenerateColumns$ False��6T   	   CanUserAddRows$	 False��6p   
   CanUserDeleteRows$
 False��6�      SelectionMode$ Single=�6�      Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68      
IsReadOnly$
 True��6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	Doctor_id+6b     5      $
 Name��68   $
 True��6_    6F   �� *Name+6_     5      $ Surname��68   $
 True��6e    6I   �� *	Surname+6e     5      $ Phone number��68   $
 True��6n    6N   �� *PhoneNumber+6n     5       $ Personal ID Number��68   $
 True��6w    6T   �� *Specialization+6w     5!      $ DateOfVisit��68   $
 True��6m    6M   �� *PhoneNumber+6m     5"      $ Patient's condition��68   $
 True��6p    6U   �� *Degree+6p     5#      $ Prescription��68   $
 True��6i    6N   �� *Degree+6i     5$      $ Recommendations��68   $
 True��6l    6Q   �� *Degree+6l     5%      $ Result��68   $
 True��6c    6H   �� *Degree+6c   5+      � 5,       � ColumnDefinitions 5-      �� 5.      $��* �6'   �� 5/      $��* �6'   �� 50      $��* �6'   �� 51      $��* �6'   .+�53      �� -   5        $��	ButtonAdd��53      $	��Add��6B   $��15(�6P   
�������$��0��6w   $��20q�6�   �� 54      -   5        $��
ButtonEdit��54      $
��Edit��6D   $��15(�6S   
�������$��1��6z   $��20q�6�   �� 55      -   5        $��ButtonViewDetails��55      $��View details��6R   $��15(�6i   
�������$��2��6�   $��20q�6�   �� 56      -   5        $��ButtonRemove��56      $��Remove��6-   $��15(�6>   
�������$��3��6e   $��20q�6u    � Cursor$
 Hand��6�   6�   58      59      5:      5;      