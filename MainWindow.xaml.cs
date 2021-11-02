using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AppleImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(apple, apple.Source, DragDropEffects.Copy);
        }

        private void inventoryApple_Drop(object sender, DragEventArgs e)
        {
            Item item = new Item();
            Inventory inventory = new Inventory();
            inventory.ItemPosition[(1, 1)] = (1, item);
        }
    }
}
