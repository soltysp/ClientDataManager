   M S B A M L   `   `   `  ����L  HClientDataManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ClientDataManagerClientDataManager  5   	   "    ClientDataManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ClientDataManager     5   	     � Title$  Client Data��5   	   $	��495��6   $��796.429��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ clData��5
   .      AutoGenerateColumns .    SelectionMode$ Single=�6>   $��15(�6U   $��5q�6c   
������� J� RenderTransformOrigin$ 0.505,0.434&�6�   $��104,335,69,23q�6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��	91,82,0,0q�6B   $
��Wrap=�6U   $��Name:��6i   $	��Top=�6v   $ 
0.43,1.951&�6�   �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��
91,118,0,0q�6C   $
��Wrap=�6W   $��Surname:��6k   $	��Top=�6{   �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��
91,151,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   �� 6�   $�T��6�   �� 6�   $�elephone Number��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5        $ 
textBlock3��5      $
��Left=�6(   $��
91,184,0,0q�6C   $
��Wrap=�6W   $��Address:��6k   $	��Top=�6{   �� 5   
   -   5         ��Name$ 	textBoxNm��5      $
��Left=�6%   $��23��6@   $��
199,81,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ 	textBoxSm��5      $
��Left=�6%   $��23��6@   $��199,117,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ 	textBoxPn��5      $
��Left=�6%   $��23��6@   $��199,150,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -	   5        $ 	textBoxAd��5      $
��Left=�6%   $��23��6@   $��199,184,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -
   5         ��Name$ btnAdd��5      $��Add New��6!   $
��Left=�63   $��376,114,0,0q�6N   $	��Top=�6c   $��71��6{   $��53��6�   6�   �� 5   
   -   5        $ btnEdit��5      $
��Edit��6"   $
��Left=�61   $��104,292,0,0q�6L   $	��Top=�6a   $��75��6y   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��219,292,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $ 	textBoxID��5      $
��Left=�6%   $��23��6@   $��
199,45,0,0q�6L   $
 Wrap=�6`   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ 
textBlock4��5      $
��Left=�6(   $��	91,46,0,0q�6C   $
��Wrap=�6V   $	��ID:��6j   $	��Top=�6u   5      5      