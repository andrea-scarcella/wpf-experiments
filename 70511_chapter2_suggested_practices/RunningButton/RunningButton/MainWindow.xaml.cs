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

namespace RunningButton
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


        private void btn0_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            double deltaX = 100;
            double deltaY = 100;
            //e.Source
            IInputElement inp = (IInputElement)e.Source;
            var position = e.GetPosition(inp);
            Button b = (Button)e.Source;
            deltaX = b.Width + 5;
            deltaY = b.Height + 5;

            if (position.X > (b.Width / 2.0))
            {
                deltaX = deltaX * (-1);
            }
            if (position.Y > (b.Height / 2.0))
            {
                deltaY = deltaY * (-1);
            }
            var mr = b.Margin;
            mr.Left += deltaX;
            mr.Top += deltaY;
            if (mr.Left < 0)
            {
                mr.Left = 0 + 2 * Math.Abs(deltaX);
            }

            if (mr.Top < 0)
            {
                mr.Top = 0 + 2 * Math.Abs(deltaY);
            }
            if (mr.Left + b.Width > this.Width - b.Width)
            {
                mr.Left = this.Width - b.Width - 2 * Math.Abs(deltaX);
            }
            if (mr.Top + b.Height > this.Height - b.Height)
            {
                mr.Top = this.Height - b.Height - 2 * Math.Abs(deltaY);
            }
            b.Margin = mr;

        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        //private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    Button b = e.Source as Button;
        //    double deltaX = b.Width + 5;
        //    double deltaY = b.Height + 5;
        //    var mr = b.Margin;
        //    if (mr.Left > this.Width - b.Width)
        //    {
        //        mr.Left -= 2 * deltaX;
        //    }

        //    if (mr.Top > this.Height - b.Height)
        //    {
        //        mr.Top -= 2 * deltaY;
        //    }
        //    b.Margin = mr;
        //}
    }
}
