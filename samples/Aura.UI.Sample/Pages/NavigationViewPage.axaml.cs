﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Aura.UI.ControlsGallery.Pages
{
    public class NavigationViewPage : UserControl
    {
        public NavigationViewPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
