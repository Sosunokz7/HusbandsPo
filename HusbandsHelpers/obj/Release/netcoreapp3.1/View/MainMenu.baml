   M S B A M L   `   `   `  ���� J  FHusbandsHelpers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:HusbandsHelpers.ViewHusbandsHelpers.View  E'clr-namespace:HusbandsHelpers.ViewModelHusbandsHelpers.ViewModel  #    HusbandsHelpers.View.MainMenu   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:HusbandsHelpers.View     6vm'clr-namespace:HusbandsHelpers.ViewModel       N� Title$  MainMenu�� N� 
Background
 �   � � DataContext ,  &HusbandsHelpers.ViewModel.NavigateMenu   � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType �Name	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  '��       �� " ��.���  � ��
 �������  � ��$ 22(���  � ��$ 40����  � ��$	 150����  � �� �� " ��.R�� $ 
buttonGrid��$	��150��.+��� $	��150��$
��Left=�$��Center=�#��z��	 P� 
 �@J�IsMouseOver$
 True��. ��� $ 
buttonGrid�� � �� �#1F1F1FP� 
 � {�$ False��. ��� $ 
buttonGrid�� � �� �#1F1F1F.��� 
�������.+�� $
��Left=�$	��152��.+��� -    ��Name$ listBox��$��Hidden=����#2B2B2B���� *	menuPages+���� .R��� $��0,5,0,0q����� *Name+���� ���� *DataContext.NewPageClick+ �� ElementName$ listBox�� � 
�������$��
152,0,-2,0q����� *
thisPage+ � ���� *Exit+