   M S B A M L   `   `   `  ����F  BBinaryClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BinaryClockBinaryClock  5   	   =#clr-namespace:BinaryClock.ViewModelBinaryClock.ViewModel  5   	       BinaryClock.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BinaryClock     5   	   2vm#clr-namespace:BinaryClock.ViewModel     5   	     � Title$  Binary Clock��5	   	   $	��525��6   $	��350��6+    � 
ResizeMode$ NoResize=�67    � DataContext 5
      !   BinaryClock.ViewModel.Timer  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value'   !BinaryClock.DigitalTimerConverter   	dgTimeH10   	TimeValue  dgTimeH1  	dgTimeM10  dgTimeM1  	dgTimeS10  dgTimeS1&    BinaryClock.BinaryTimerConverter  BinaryS1One   BinaryTimeValue  BinaryS1Two  BinaryS1Four 	 BinaryS1Eight 
 BinaryS10One  BinaryS10Two  BinaryS10Four  BinaryM1One  BinaryM1Two  BinaryM1Four  BinaryM1Eight  BinaryM10One  BinaryM10Two  BinaryM10Four  BinaryH1One  BinaryH1Two  BinaryH1Four  BinaryH1Eight  BinaryH10One  BinaryH10Two��%  '��       'A� �     &	  *    &	 K    &	 k    &	 �    &	 �    &	 �    &	 �    &	     &	 ?    &		 e    &	
 �    &	 �    &	 �    &	 �    &	 $    &	 I    &	 o    &	 �    &	 �    &	 �    &	 	    &	 .    &	 S    &	 y    &	 �    &	 �    �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 40(�6)   5      �� 5   
   " A�6   .�5      ��  � ��$ 40��6&   �� 5       � ��$ 40��6'   �� 5       � ��
 �����6%   5        5   
   $ Hours10=�68     5   
   $ Hours1=�67     5   
   $ 	Minutes10=�68     5   
   $ Minutes1=�67     5   
   $ 	Seconds10=�68     5   
   $ Seconds1=�67     5   
   $ BinaryS1One=�69     5   
   $ BinaryS1Two=�69     5    
   $ BinaryS1Four=�6:     5!   
   $ BinaryS1Eight=�6;     5"   
   $ BinaryS10One=�6:     5#   
   $ BinaryS10Two=�6:     5$   
   $ BinaryS10Four=�6;     5%   
   $ BinaryM1One=�69     5&   
   $ BinaryM1Two=�69     5'   
   $ BinaryM1Four=�6:     5(   
   $ BinaryM1Eight=�6;     5)   
   $ BinaryM10One=�6:     5*   
   $ BinaryM10Two=�6:     5+   
   $ BinaryM10Four=�6;     5,   
   $ BinaryH1One=�69     5-   
   $ BinaryH1Two=�69     5.   
   $ BinaryH1Four=�6:     5/   
   $ BinaryH1Eight=�6;     50   
   $ BinaryH10One=�6:     51   
   $ BinaryH10Two=�6:   56      .��57      � 	 � ColumnDefinitions	 58   
   �� 59      $��* �6   �� 5:      $��* �6   �� 5;      $
��0.2* �6   �� 5<      $��* �6   �� 5=      $��* �6   �� 5>      $
��0.2* �6   �� 5?      $��* �6   �� 5@      $��* �6   �� 5A      $
��0.6* �6   
 � RowDefinitions
 5C   
   �� 5D      $��* �6   �� 5E      $��* �6   �� 5F      $��* �6   �� 5G      $��* �6   �� 5H      $��* �6   �� 5I      $��* �6   .+�5K   
   �� $��:��6   $��2��6   �� 5L   
   $��:��6   $��5��6   �� 5M   
   $��:��6   $��2��6   $��5��6-   �� 5N   
   $��:��6   $��5��6   $��5��6-   �� 5O   
   $��H��6   �� 5P   
   $��H��6   $��1��6   �� 5Q   
   $��M��6   $��3��6   �� 5R   
   $��M��6   $��4��6   �� 5S   
   $��S��6   $��6��6   �� 5T   
   $��S��6   $��7��6   �� 5U   
   -   5         ��Name$ 
txtHours10��5U      $��5��6(   ��65   �� *CurrentTime+ �� Mode$ OneWay=� �� 	Converter# [  �� 5V   
   -   5        $ 	txtHours1��5V      $��5��6'   $��1��64   ��6D   �� *CurrentTime+$ OneWay=�# [ �� 5W   
   -   5        $ txtMinutes10��5W      $��5��6*   $��3��67   ��6G   �� *CurrentTime+$ OneWay=�# [ �� 5X   
   -   5        $ txtMinutes1��5X      $��5��6)   $��4��66   ��6F   �� *CurrentTime+$ OneWay=�# [ �� 5Y   
   -   5        $ txtSeconds10��5Y      $��5��6*   $��6��67   ��6G   �� *CurrentTime+$ OneWay=�# [ �� 5Z   
   -   5        $ txtSeconds1��5Z      $��5��6)   $��7��66   ��6F   �� *CurrentTime+$ OneWay=�# [ �� 5[   
   $��8��6   $��1��6   $��8��6*   $��25(�6:   �� 5\   
   $��4��6   $��2��6   $��8��6*   $��25(�6:   �� 5]   
   $��2��6   $��3��6   $��8��6*   $��25(�6:   �� 5^   
   $��1��6   $��4��6   $��8��6*   $��25(�6:   A� 5_   
   -   5         A�Name$ h10_2��5_      $��3��6!   ��6.   �� *CurrentTime+# [ A� 5`   
   -   5        $ h10_1��5`      $��4��6!   ��6.   �� *CurrentTime+# [ A� 5a   
   -	   5        $
 h1_8��5a      $��1��6    $��1��6-   ��6=   �� *CurrentTime+# [ A� 5b   
   -
   5        $
 h1_4��5b      $��2��6    $��1��6-   ��6=   �� *CurrentTime+# [ A� 5c   
   -   5        $
 h1_2��5c      $��3��6    $��1��6-   ��6=   �� *CurrentTime+# [ A� 5d   
   -   5        $
 h1_1��5d      $��4��6    $��1��6-   ��6=   �� *CurrentTime+# [ A� 5e   
   -   5        $ min10_4��5e      $��2��6#   $��3��60   ��6@   �� *CurrentTime+# [ A� 5f   
   -   5        $ min10_2��5f      $��3��6#   $��3��60   ��6@   �� *CurrentTime+# [ A� 5g   
   -   5        $ min10_1��5g      $��4��6#   $��3��60   ��6@   �� *CurrentTime+# [ A� 5h   
   -   5        $ min1_8��5h      $��1��6"   $��4��6/   ��6?   �� *CurrentTime+# [ A� 5i   
   -   5        $ min1_4��5i      $��2��6"   $��4��6/   ��6?   �� *CurrentTime+# [ A� 5j   
   -   5        $ min1_2��5j      $��3��6"   $��4��6/   ��6?   �� *CurrentTime+# [ A� 5k   
   -   5        $ min1_1��5k      $��4��6"   $��4��6/   ��6?   �� *CurrentTime+# [ A� 5l   
   -   5        $ sec10_4��5l      $��2��6#   $��6��60   ��6@   �� *CurrentTime+# [ A� 5m   
   -   5        $ sec10_2��5m      $��3��6#   $��6��60   ��6@   �� *CurrentTime+# [ A� 5n   
   -   5        $ sec10_1��5n      $��4��6#   $��6��60   ��6@   �� *CurrentTime+# [
 A� 5o   
   -   5        $ sec1_8��5o      $��1��6"   $��7��6/   ��6?   �� *CurrentTime+# [	 A� 5p   
   -   5        $ sec1_4��5p      $��2��6"   $��7��6/   ��6?   �� *CurrentTime+# [ A� 5q   
   -   5        $ sec1_2��5q      $��3��6"   $��7��6/   ��6?   �� *CurrentTime+# [ A� 5r   
   -   5        $ sec1_1��5r      $��4��6"   $��7��6/   ��6?   �� *CurrentTime+# [ 5s      5t      