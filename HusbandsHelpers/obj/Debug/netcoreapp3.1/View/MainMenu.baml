   M S B A M L   `   `   `  ����J  FHusbandsHelpers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:HusbandsHelpers.ViewHusbandsHelpers.View  5      E'clr-namespace:HusbandsHelpers.ViewModelHusbandsHelpers.ViewModel  5      #    HusbandsHelpers.View.MainMenu   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:HusbandsHelpers.View     5      6vm'clr-namespace:HusbandsHelpers.ViewModel     5        N� Title$  MainMenu��5
       N� 
Background
 �   � � DataContext 5      ,  &HusbandsHelpers.ViewModel.NavigateMenu  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �Name	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 22(�6)   �� 5       � ��$ 40��6'   �� 5       � ��$	 150��6&   �� 5       � �� 5      �� 5      " ��6&   .R�5      � $ 
buttonGrid��6   $	��150��63   .+�5      �� $	��150��5   !   $
��Left=�5   !   $��Center=�5   !   #��z��5    !   5"      	 5#      P� 5$      
 �@J�IsMouseOver$
 True��6=   . �5%   "   �� $ 
buttonGrid��6)    � �� �#1F1F1F6W   5&      P� 5'      
 � {�$ False��6;   . �5(   "   �� $ 
buttonGrid��6)    � �� �#1F1F1F6W   5)      5.      50      51      52      .��53      � 
�������.+�55   
   � $
��Left=�6   $	��152��6,   .+�57      �� -   5         ��Name$ listBox��57   Q   $��Hidden=�6   ���#2B2B2B��58      �� *	menuPages+��59      �� 5:      .R�5;      �� $��0,5,0,0q�6"   ��63   �� *Name+��6L   �� ��6i   �� *DataContext.NewPageClick+ �� ElementName$ listBox��5<      5@      5C       � 5D   
   
�������$��
152,0,-2,0q�6#   ��67   �� *
thisPage+ � 5E   
   ��6   �� *Exit+5F      5G      