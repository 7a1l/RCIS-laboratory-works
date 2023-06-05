using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Linq;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1;

public partial class SecretWindow : Window
{
    private TextBlock Click;
    public SecretWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        Click = this.FindControl<TextBlock>("ClickTBlock");
    }
    private void BackBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
        Close();
    }
    
    private void ClkBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        int counter = 0;
        if (int.TryParse(Click.Text, out counter))
        {
            counter++;
        }
        else
        {
            counter = 0;
        }
        Click.Text = counter.ToString();
    }

    private void ClearBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        Click.Text = "0";
    }
}