   M S B A M L   `   `   `  ����G  CGuessTheFreq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GuessTheSinFreqGuessTheSinFreq  5   	        GuessTheSinFreq.MainWindow   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5   	   -localclr-namespace:GuessTheSinFreq    5   	   -   5          � Title$  GuessTheFreq��5   	   $	��361��6   $	��264��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ CanMinimize=�6\   .��5	      � .+�5
   
   �� -   5         ��Name$ groupBox��5
      $��Train your ear here (=��6%   $
��Left=�6E   $��10,164.16,0,0q�6`   $	��Top=�6w   $��144.84��6�   $��222.334��6�   �� 5   
   -   5         ��Name$ label��5      $��Freq:��6   $
��Left=�6/   $��25.37,198.12,0,0q�6J   $	��Top=�6d   �� 5   
   -   5        $ label1��5      $
��Dur:��6    $
��Left=�6/   $��25.37,229.08,0,0q�6J   $	��Top=�6d   �� 5   
   -   5         ��Name$ Duration_TextBox��5      $
��Left=�6,   $��23��6G   $��66.347,233.08,0,0q�6S    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $��135.37��6�   $
��1000��6�   �� 5   
   -   5        $ Frequency_TextBox��5      $
��Left=�6-   $��23��6H   $��66.347,201.08,0,0q�6T   $
 Wrap=�6o   $	��Top=�6�   $��135.37��6�   $
��1000��6�   �� 5   
   -   5         ��Name$ Beep_Button��5      $
��Beep��6&   $
��Left=�65   $��25.37,261.08,0,0q�6P   $	��Top=�6j   $��176.347��6�   6�   �� 5   
   -   5        $ UserAnswer_TextBox��5      $
��Left=�6.   $��23��6I   $��66.347,26,0,0q�6U   $
 Wrap=�6l   $	��Top=�6�   $��165.987��6�   �� 5   
   -	   5        $ label1_Copy��5      $��Answer:��6%   $
��Left=�67   $��10,23.04,0,0q�6R   $	��Top=�6h   �� 5   
   -
   5        $ MakeAGuess_Button��5      $��Make a guess��6,   $
��Left=�6C   $��	10,54,0,0q�6^   $	��Top=�6q   $��222.334��6�   6�   �� 5   
   -   5        $ Result_Label��5      $�� ��6&   $��Center=�61   $��10,78.96,23.666,0q�6N   $	��Top=�6i   $��222.334��6�   $��Center=�6�   �� 5   
   -   5        $ RepeatQuestion_Button��5      $��Repeat qustion��60   $
��Left=�6I   $��10,109.92,0,0q�6d   $	��Top=�6{   $��222.334��6�   6�   �� 5   
   -   5        $ Skip_Button��5      $��Next question��6&   $
��Left=�6>   $��10,134.88,0,0q�6Y   $	��Top=�6p   $��222.334��6�   6�   5      5      