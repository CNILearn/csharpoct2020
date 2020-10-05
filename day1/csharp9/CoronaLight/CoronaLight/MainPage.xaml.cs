﻿using CoronaLight.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

#nullable enable
namespace CoronaLight
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private IServiceScope? _scope;
        public MainPage()
        {
            if (Application.Current is App app)
            {
                _scope = app.Services.CreateScope();
            }
            else
            {
                throw new InvalidOperationException("App is not App!!");
            }
            ViewModel = _scope.ServiceProvider.GetRequiredService<MainPageViewModel>();
            this.InitializeComponent();
        }

        public MainPageViewModel ViewModel { get; }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            _scope?.Dispose();
        }
    }
}

#nullable restore
