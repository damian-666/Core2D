﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Core2D.Views.Docking.Tools.Options;

public class ZoomOptionsView : UserControl
{
    public ZoomOptionsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}