using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
namespace Lesson_2
{
    public class CustomCommands
    {
        private static RoutedUICommand launch_command;
        static CustomCommands()
        {
            InputGestureCollection collection = new InputGestureCollection();
            collection.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            launch_command = new RoutedUICommand("Launch", "Launch", typeof(CustomCommands), collection);
        }
        public static RoutedUICommand Launch
        {
            get
            {
                return launch_command;
            }
        }
    }
}
