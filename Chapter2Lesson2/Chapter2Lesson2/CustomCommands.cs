using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Chapter2Lesson2
{
    public static class CustomCommands
    {
        private static RoutedUICommand launch_command;
        public static RoutedUICommand Launch
        {
            get { return launch_command; }
        }

        static CustomCommands()
        {
            var myInputGestures = new InputGestureCollection();
            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            launch_command = new RoutedUICommand("Launch", "Launch", typeof(CustomCommands), myInputGestures);
        }
    }
}
