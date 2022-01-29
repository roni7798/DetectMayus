using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shell;

namespace DetectMayus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool mayuscula = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void sincronizar()
        { 
        
        }

        private void verificarMayus(object sender, KeyEventArgs e)
        {
            //sincronizar();
            
            //int ascii = KeyInterop.VirtualKeyFromKey(e.Key);
            if (e.Key == Key.CapsLock && mayuscula==false)
            {
                mayuscula = true;
                lblMayus.Background = Brushes.Green;
                lblMayus.Content = "Teclado en mayúscula";
            }
            else if(e.Key == Key.CapsLock && mayuscula == true)
            {
                lblMayus.Background = Brushes.Gray;
                lblMayus.Content = "Teclado en minúscula";
                mayuscula = false;
            }      
        }
    }
}
