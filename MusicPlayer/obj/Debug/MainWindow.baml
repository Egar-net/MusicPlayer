   M S B A M L   `   `   `  ����F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5   	       MusicPlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MusicPlayer     5   	     � Title$  
MainWindow��5   	   $	��570��6   $	��450��6)   .��5	      � ���	#FF7D4343 � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   r� -   5        $��mediaElement��5       r� LoadedBehavior$ Manual=�6+    r� UnloadedBehavior$
 Stop=�6C   $��0��6[   �� 5   
   ���	#FFA91010 �� Orientation$ Vertical=�6,   $��0��6C   .+�5      �� $	��500��6   .��5      �� -   5        $��listBoxSongs��5      $	��500��6_   ���	#FF7D43436l   5      5      �� 5   
   $��0��6   $��2��6   
�������$��Bottom=�6;   $��5q�6V   �� 5   
   $ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6I   $��0,10,0,0q�6f   ���	#FFE00101$��1��6�   .+�5      �� -   5        $��btnPlay��5      $
��Play��6$   $��8 0 8 0q�6I   $��5q�6[   ���	#FFFF4646
�������6}   �� 5      -   5        $��btnPause��5      $��Pause��6%   $��8 0 8 0q�6L   $��5q�6^   ���	#FFFF4646
�������6�   �� 5      -   5        $��btnStop��5      $
��Stop��6$   $��8 0 8 0q�6I   $��5q�6[   ���	#FFFF4646
�������6}   �� 5      -   5        $��btnOpen��5      $
��Open��6$   $��8 0 8 0q�6I   $��5q�6[   ���	#FFFF4646
�������6}   �� 5      -   5        $��	btnRandom��5      $��R��6&   $��8 0 8 0q�6J   $��5q�6\   ���	#FFFF4646
�������6~   5       5!      5"      