   M S B A M L   `   `   `  ����F  BAkademiaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AkademiaAppAkademiaApp  5   	       AkademiaApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AkademiaApp     5   	     � Title$  AkademiaApp��5   	   $��484.512��6   $��637.87��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ lName��5
      $
��Name��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   $��90��6t   �� 5   
   -   5        $ lSurname��5      $��Surname��6"   $
��Left=�64   $��	10,41,0,0q�6O   $	��Top=�6b   $��90��6z   �� 5   
   -   5        $ lPhoneNumber��5      $��Phone number��6&   $
��Left=�6=   $��	10,72,0,0q�6X   $	��Top=�6k   $��90��6�   �� 5   
   -   5         ��Name$ tbName��5      $
��Left=�6"   $��23��6=   $��
105,15,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ 	tbSurname��5      $
��Left=�6%   $��23��6@   $��
105,45,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ tbPhoneNumber��5      $
��Left=�6)   $��23��6D   $��
105,76,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   	� 5   
   -   5         	�Name$ 	rbStudent��5      $��Student��6)   $
��Left=�6;   $��
15,123,0,0q�6V   $	��Top=�6j    J� RenderTransformOrigin$ 	-0.276,-1&�6�   6�   	� 5   
   -   5        $ 	rbTeacher��5      $��Teacher��6)   $
��Left=�6;   $��140,123,0,0q�6V   $	��Top=�6k   $ 	-0.276,-1&�6�   6�   �� 5   
   -	   5        $ lNrIdx��5      $��Nr Idx��6    $
��Left=�61   $��
15,162,0,0q�6L   $	��Top=�6`   $ -0.395,-0.404&�6x   $��28��6�   $��85��6�   $y�Hidden=�6�   �� 5   
   -
   5        $ lBranchOfStudy��5      $��Branch Of Study��6(   $
��Left=�6B   $��
15,195,0,0q�6]   $	��Top=�6q   $��23��6�   $��85��6�   $y�Hidden=�6�   �� 5   
   -   5        $ tbNrIdx��5      $
��Left=�6#   $��23��6>   $��140,162,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $y�Hidden=�6�   �� 5   
   -   5        $ lMaths��5      $��Maths��6    $
��Left=�60   $��
15,245,0,0q�6K   $	��Top=�6_   $��97��6w   $y�Hidden=�6�   �� 5   
   -   5        $ lPhysics��5      $��Physics��6"   $
��Left=�64   $��
15,276,0,0q�6O   $	��Top=�6c   $��97��6{   $y�Hidden=�6�   �� 5   
   -   5        $ lEnglish��5      $��English��6"   $
��Left=�64   $��
15,307,0,0q�6O   $	��Top=�6c   $��97��6{   $y�Hidden=�6�   �� 5   
   -   5        $ lProgramming��5      $��Programming��6&   $
��Left=�6<   $��
15,338,0,0q�6W   $	��Top=�6k   $��97��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ cbMaths��5      $
��Left=�6$   $��140,245,0,0q�6?   $	��Top=�6T   $	��120��6l   $y�Hidden=�6x   �� 5   
   -   5        $ 	cbPhysics��5      $
��Left=�6&   $��140,276,0,0q�6A   $	��Top=�6V   $	��120��6n   $y�Hidden=�6z   �� 5   
   -   5        $ 	cbEnglish��5      $
��Left=�6&   $��140,307,0,0q�6A   $	��Top=�6V   $	��120��6n   $y�Hidden=�6z   �� 5   
   -   5        $ cbProgramming��5      $
��Left=�6*   $��140,338,0,0q�6E   $	��Top=�6Z   $	��120��6r   $y�Hidden=�6~   �� 5   
   -   5        $ lAcademicDegree��5      $��AcademicDegree��6)   $
��Left=�6B   $��
15,159,0,0q�6]   $	��Top=�6q   $	��110��6�   $y�Hidden=�6�   �� 5   
   -   5        $ lSalary��5      $��Salary��6!   $
��Left=�62   $��
15,190,0,0q�6M   $	��Top=�6a   $ -0.184,-0.192&�6y   $��97��6�   $y�Hidden=�6�   �� 5    
   -   5        $ cbAcademicDegree��5       $
��Left=�6-   $��149,159,0,0q�6H   $	��Top=�6]   $	��120��6u   $y�Hidden=�6�   �� 5!   
   -   5        $ tbSalary��5!      $
��Left=�6$   $��23��6?   $��149,193,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   $y�Hidden=�6�   �� 5"   
   -   5         ��Name$ bClear��5"      $��Clear��6!   $
��Left=�61   $��31��6L   $��
402,36,0,0q�6X   $	��Top=�6l   $	��180��6�   6�   �� 5#   
   -   5        $ 
bAddPerson��5#      $��
Add person��6%   $
��Left=�6:   $��
402,94,0,0q�6U   $	��Top=�6i   $	��180��6�   $��31��6�   6�   �� 5$   
   -   5        $ 	bStudents��5$      $��Students��6$   $
��Left=�67   $��402,178,0,0q�6R   $	��Top=�6g   $	��180��6   $��31��6�   6�   �� 5%   
   -   5        $ 
bTeachears��5%      $��	Teachears��6%   $
��Left=�69   $��402,224,0,0q�6T   $	��Top=�6i   $	��180��6�   $��31��6�   6�   �� 5&   
   -   5        $ bExit��5&      $
��Exit��6    $
��Left=�6/   $��402,302,0,0q�6J   $	��Top=�6_   $	��180��6w   $��31��6�   6�   �� 5'   
   -   5        $��Button��5'      $
��Left=�6"   $	��Top=�6=   $��75��6U   $��464,368,0,0q�6`   $y�Hidden=�6�   �� 5(   
   -   5        $ cbBranchOfStudy��5(      $
��Left=�6,   $��140,195,0,0q�6G   $	��Top=�6\   $	��120��6t   $y�Hidden=�6�   5*      5+      