   M S B A M L   `   `   `  ����C  ?MiniRace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MiniRaceMiniRace  5   	       MiniRace.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MiniRace     5   	   -   5          � 
ResizeMode$  NoResize=�5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��350��6)   .��5
      � ��5   
   �� 5       �� ImageSource$ raceArea.png��6    j� TileMode$
 Tile=�64    j� Stretch$ UniformToFill=�6D   .+�5   
   �� -   5         ��Name$ line1��5      ���	#FFF4F4F5$��Center=�64   $��90��6Q   
���   �$	��Top=�6l   $��10��6�   $��120,0,214,0q�6�   �� 5   
   -   5        $ line2��5      ���	#FFF4F4F5$��Center=�64   $��90��6Q   
���   �$	��Top=�6l   $��10��6�   $��120,145,214,0q�6�   �� 5   
   -   5        $ line3��5      ���	#FFF4F4F5$��Center=�64   $��90��6Q   
���   �$	��Top=�6l   $��10��6�   $��120,295,214,0q�6�   �� 5   
   -   5        $ line4��5      ���	#FFF4F4F5$��Center=�64   $��90��6Q   
���   �$	��Top=�6l   $��10��6�   $��215,0,119,0q�6�   �� 5   
   -   5        $ line5��5      ���	#FFF4F4F5$��Center=�64   $��90��6Q   
���   �$	��Top=�6l   $��10��6�   $��215,145,119,0q�6�   �� 5   
   -   5        $ line6��5      ���	#FFF4F4F5$��Center=�64   $��90��6Q   
���   �$	��Top=�6l   $��10��6�   $��215,295,119,0q�6�   � 5   
   -   5         �Name$ gameArea��5      $��Center=�6!   $	��420��6>   $��0,0,0,0q�6K   $	��Top=�6\   $	��283��6t    � ColumnDefinitions 5      �� 5      $	��95* �6#   �� 5      $	��94* �6#   �� 5      $	��94* �6#   .+�5      �� -	   5         ��Name$ carImage��5      $��car1.png��6&   $��Center=�68   $	��140��6U   $��0,0,0,5q�6b   $��Bottom=�6s   $��75��6�   	 J� RenderTransformOrigin$	 0.077,0.498&�6�   $��1��6�   �� 5      -
   5        $ enemy1��5      $��car1.png��6$   $��Center=�66   $	��140��6S   $��10,10,10.2,0q�6`   $	��Top=�6v   $��75��6�   $	 0.077,0.498&�6�   $��0��6�   �� 5      -   5        $ enemy2��5      $��car1.png��6$   $��Center=�66   $	��140��6S   $��8.4,10,10.2,0q�6`   $	��Top=�6w   $��75��6�   $	 0.077,0.498&�6�   $��2��6�   �� 5      -   5        
 ��Name$
 
scoreLabel��5      $��Label��6(   $
��Left=�68   $��35��6S   $��
10,375,0,0q�6_   $	��Top=�6s   $��85��6�   
�������$��20(�6�   $��Impact)�6�   �� 5       -   5         ��Name$ gameSpeedComboBox��5       $��3��62   $
��Left=�6F   $��
85,128,0,0q�6a   $	��Top=�6u   $	��120��6�   .@�5!      �� $��Poziom 1��6   �� 5"      $��Poziom 2��6    �� 
IsSelected . 62   �� 5#      $��Poziom 3��6   �� 5$      $��Poziom 4��6   �� 5%      $��Poziom 5��6   5&      5)      �� 5*   
   -   5         ��Name$ startButton��5*      $��Rozpocznij grę��6&   $��Center=�6?   $��Center=�6\   $	��150��6w   $��60��6�   6�   �� 5+   
   -   5        $
 gameOverLabel��5+      $��Przegrałeś��6'   $y�Hidden=�6<   $��Center=�6P   $��Center=�6t   $	��Top=�6�   $	��100��6�   $��45��6�   
�������$��20(�6�   $��125,119,119,0q�6�   $��Impact)�6�   �� 5,   
   -   5        $ restartButton��5,      $y�Hidden=�6(   $��Zagraj ponownie��6<   $��Center=�6V   $��Center=�6s   $	��150��6�   $��60��6�   $��97,180q�6�   6�   5-      5.      