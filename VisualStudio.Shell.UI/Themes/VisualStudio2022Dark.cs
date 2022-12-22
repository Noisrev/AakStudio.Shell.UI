﻿using System;
using System.Windows;

namespace VisualStudio.Shell.UI.Themes
{
    public class VisualStudio2022Dark : Theme
    {
        public VisualStudio2022Dark()
            : base("Visual Studio 2022 Dark", true, false, new ResourceDictionary()
            { Source = new Uri("/VisualStudio.Shell.UI;component/Themes/VisualStudio2022/DarkTheme.xaml", UriKind.Relative) })
        { }
    }
}