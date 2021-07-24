// Copyright (c) Richasy. All rights reserved.

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Richasy.FluentIcon.Uwp
{
    /// <summary>
    /// Fluent icon control using Filled font.
    /// </summary>
    public class FilledFluentIcon : FontIcon
    {
        // Download from https://github.com/microsoft/fluentui-system-icons/tree/master/fonts
        public static readonly string Version = "1.1.135";

        /// <summary>
        /// Dependency property of <see cref="Symbol"/>.
        /// </summary>
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register(nameof(Symbol), typeof(FilledFluentSymbol), typeof(FilledFluentIcon), new PropertyMetadata(default, new PropertyChangedCallback(OnSymbolChanged)));

        public FilledFluentIcon()
        {
            FontFamily = new Windows.UI.Xaml.Media.FontFamily("/Richasy.FluentIcon.Filled.Uwp/Assets/FluentSystemIcons-Filled.ttf#FluentSystemIcons-Filled");
        }

        /// <summary>
        /// Symbol enumeration value corresponding to the icon.
        /// </summary>
        public FilledFluentSymbol Symbol
        {
            get { return (FilledFluentSymbol)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is FilledFluentSymbol symbol)
            {
                var instance = d as FilledFluentIcon;
                instance.Glyph = ((char)symbol).ToString();
            }
        }
    }
}
