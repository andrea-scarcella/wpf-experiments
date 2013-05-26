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

namespace phonegap_create
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "Choose project folder";
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //projec.Text= dialog.SelectedPath;
                projectFolderPath.Text = dialog.SelectedPath;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox4.Text = "create.bat ";
            textBox4.Text +="\""+projectFolderPath.Text + "\"";
            textBox4.Text += " " + packageName.Text;
            textBox4.Text += " " + projectName.Text;
            textBox4.Focus();
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox4_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.SelectAll();
                Clipboard.SetText(textBox4.Text); 
            }
        }
    }
}
