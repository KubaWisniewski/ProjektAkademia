   M S B A M L   `   `   `  ����F  BAkademiaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AkademiaAppAkademiaApp  5   	       AkademiaApp.StudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AkademiaApp     5   	     � Title$  Students��5   	   $��323.964��6   $��642.604��6+   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgStudent��5
      $
��Left=�6&   $	��273��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��344��6y      
IsReadOnly . ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�6)   5      �� 5   
   $��Id��6   $
��Left=�6   $��
374,25,0,0q�68   $	��Top=�6L    J� RenderTransformOrigin$ -0.036,0.47&�6d   $��73��6�   �� 5   
   -   5         ��Name$ bDelete��5      $��Delete Student��6"   $
��Left=�6;   $��
374,64,0,0q�6V   $	��Top=�6j   $	��108��6�   $ 0.816,0.515&�6�   $��23��6�   6�   �� 5   
   -   5         ��Name$
 tbId��5      $
��Left=�6    $��23��6;   $��
463,25,0,0q�6G   	 �� TextWrapping$
	 Wrap=�6[   $	��Top=�6o   $	��144��6�   �� 5   
   -   5        
 ��Name$
 
cbKierunek��5      $
��Left=�6'   $��374,174,0,0q�6B   $	��Top=�6W   $	��101��6o   $ 
0.49,2.861&�6{   �� 5   
   -   5        $��Show Students Branch��5      $
��Left=�60   $��488,174,0,0q�6K   $	��Top=�6`   $	��137��6x   $ 0.333,3.195&�6�   $��22��6�   �� 5   
   -   5        $ bAverage��5      $��Student Average��6#   $
��Left=�6=   $��
499,64,0,0q�6X   $	��Top=�6l   $	��108��6�   $ 0.816,0.515&�6�   $��23��6�   6�   5      5      