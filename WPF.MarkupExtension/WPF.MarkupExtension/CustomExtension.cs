using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.MarkupExtension
{
    public class CustomExtension : DependencyObject
    {
        public static readonly DependencyProperty ItemProperty =
            DependencyProperty.RegisterAttached("ItemProperty", typeof(Item), typeof(CustomExtension), new FrameworkPropertyMetadata(null) );

        public static void SetItemProperty(UIElement element, Item value)
        {
            element.SetValue(ItemProperty, value);
        }

        public static Item GetItemProperty(UIElement element)
        {
            return (Item)element.GetValue(ItemProperty);
        }
    }
}
