   M S B A M L   `   `   `  ����H  DTelefonszamok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TelefonszamokTelefonszamok  5   	       Telefonszamok.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Telefonszamok     5   	     � Title$  Bejelentkezés��5   	   $	��400��6   $	��500��6,   .��5	      � $��0,10,0,0q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��LoginHeading��5      $��23��5      $��0��6    $��0��6-   $��4��6=   $��Center=�5      $��	10,10,0,0q�5      $��Bejentkezés��5      $	��Top=�5       $��17(�5!      $��ExtraCondensed&�5"      �� 5#   
   $��Felhasznáónév/email:��6   $��2��60   $��1��6=   �� 5$   
   -   5         ��Name$ tbEmail��5$      $��0,0,0,10q�6$   $��2��66   $��2��6C   �� 5%   
   $��Jelszó:��6   $��3��6"   $��1��6/   G� 5&   
   -   5         G�Name$ 
pbPassword��5&      $��0,0,0,10q�6*   $��3��6<   $��2��6I   �� 5'   
   -   5        $��Bejelentkezés��5'      $	��120��5(   
   $��40��5)   
   $��Center=�5*   
   $��5��5,      $��0��6   $��4��6.   5.      50      