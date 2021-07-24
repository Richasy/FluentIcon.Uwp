// Copyright (c) Richasy. All rights reserved.

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Richasy.FluentIcon.Uwp
{
    /// <summary>
    /// Fluent icon control using Regular font.
    /// </summary>
    public class RegularFluentIcon : FontIcon
    {
        // Download from https://github.com/microsoft/fluentui-system-icons/tree/master/fonts
        public static readonly string Version = "1.1.135";

        /// <summary>
        /// Dependency property of <see cref="Symbol"/>.
        /// </summary>
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register(nameof(Symbol), typeof(RegularFluentSymbol), typeof(RegularFluentIcon), new PropertyMetadata(default, new PropertyChangedCallback(OnSymbolChanged)));

        public RegularFluentIcon()
        {
            FontFamily = new Windows.UI.Xaml.Media.FontFamily("/Richasy.FluentIcon.Regular.Uwp/Assets/FluentSystemIcons-Regular.ttf#FluentSystemIcons-Regular");
        }

        /// <summary>
        /// Symbol enumeration value corresponding to the icon.
        /// </summary>
        public RegularFluentSymbol Symbol
        {
            get { return (RegularFluentSymbol)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is RegularFluentSymbol symbol)
            {
                var instance = d as RegularFluentIcon;
                instance.Glyph = ((char)symbol).ToString();
            }
        }
    }
}
