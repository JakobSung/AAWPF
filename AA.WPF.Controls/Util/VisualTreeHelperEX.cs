﻿using System.Windows;
using System.Windows.Media;

namespace AA.WPF.Controls.Util
{
    internal class VisualTreeHelperEX
    {
        public static T FindVisualParent<T>(DependencyObject child)
            where T : DependencyObject
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null) return null;

            T parent = parentObject as T;
            if (parent != null)
            {
                return parent;
            }
            else
            {
                return FindVisualParent<T>(parentObject);
            }
        }
    }
}
