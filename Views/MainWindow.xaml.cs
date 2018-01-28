﻿using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using MahApps.Metro.Controls;

using TeachingPlatformApp.ViewModels;

namespace TeachingPlatformApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();         
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.ScrollToEnd();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == System.Windows.Input.Key.C)
            {
                if(DataContext is MainWindowViewModel viewModel)
                {
                    viewModel.ClearCommand.Execute();                 
                }
            }
            else if(e.Key == System.Windows.Input.Key.S)
            {
                consoleTextBox.FontSize -= 2;
            }
            else if(e.Key == System.Windows.Input.Key.W)
            {
                consoleTextBox.FontSize += 2;
            }
            else if(e.Key == System.Windows.Input.Key.T)
            {
                if (testButton.Visibility == Visibility.Collapsed)
                    testButton.Visibility = Visibility.Visible;
                else
                    testButton.Visibility = Visibility.Collapsed;
            }
            else if(e.Key == System.Windows.Input.Key.Enter)
            {
                try
                {
                    var count = consoleTextBox.LineCount;
                    for(var i = 0;i < count ;++i)
                    {
                        var text = consoleTextBox.GetLineText(i);
                        if (Regex.IsMatch(text, "speech", RegexOptions.IgnoreCase))
                        {
                            new SpeechWindow().Show();
                        }
                        else if (Regex.IsMatch(text, "config", RegexOptions.IgnoreCase))
                        {
                            new ConfigWindow().Show();
                        }
                    }
                    
                }
                catch 
                {

                }
                
            }
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
