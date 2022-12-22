﻿using System.Windows;
using System.Windows.Controls;
using VisualStudio.Shell.UI.Showcase.ViewModels;
using VisualStudio.Shell.UI.Showcase.ViewModels.Collection;

namespace VisualStudio.Shell.UI.Showcase.Styles;

internal sealed class PanesStyleSelector : StyleSelector
{
    public Style? PageStyle
    {
        get;
        set;
    }

    public Style? StyleSelectorStyle
    {
        get;
        set;
    }

    public Style? CollectionStyle
    {
        get;
        set;
    }

    public override Style? SelectStyle(object item, DependencyObject container)
    {
        if (item is PageViewModel)
            return PageStyle;

        if (item is StyleSelectorViewModel)
            return StyleSelectorStyle;

        if (item is CollectionViewModel)
            return CollectionStyle;

        return base.SelectStyle(item, container);
    }
}
