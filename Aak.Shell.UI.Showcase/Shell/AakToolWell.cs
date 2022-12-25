﻿using Aak.Shell.UI.Showcase.Interfaces;

namespace Aak.Shell.UI.Showcase.Shell;

internal abstract class AakToolWell : AakViewElement, IAakToolWell
{
    public bool CanHide
    {
        get => canHide;
        set => SetProperty(ref canHide, value);
    }

    public bool IsVisible
    {
        get => isVisible;
        set => SetProperty(ref isVisible, value);
    }

    private bool canHide = true;
    private bool isVisible = true;
}
