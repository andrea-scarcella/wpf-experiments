using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson_2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            CommandBinding myBinding = new CommandBinding();
            myBinding.Command = CustomCommands.Launch;
            myBinding.Executed += new ExecutedRoutedEventHandler(Launch_Handler);
            myBinding.CanExecute += new CanExecuteRoutedEventHandler(CheckBox1_Handler);
            this.CommandBindings.Add(myBinding);
        }
        private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Launch invoked!");
        }
        private void CheckBox1_Handler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (CheckBox1.IsChecked) ?? false;
        }
    }
}
