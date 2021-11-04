﻿// UWP does not support project level global usings.
global using System;
global using System.Linq;

global using ReactiveUI;
global using H.ReactiveUI;
global using H.ReactiveUI.Converters;
global using System.Reactive.Disposables;

global using H.ReactiveUI.Apps.ViewModels;

#if HAS_WPF
global using System.Globalization;
global using System.Windows;
global using System.Windows.Data;
global using System.Windows.Media;
global using System.Windows.Controls;
#elif HAS_WINUI
global using Microsoft.UI;
global using Microsoft.UI.Xaml;
global using Microsoft.UI.Xaml.Data;
global using Microsoft.UI.Xaml.Media;
global using Microsoft.UI.Xaml.Controls;
global using LaunchActivatedEventArgs = Microsoft.UI.Xaml.LaunchActivatedEventArgs;
#else
global using Windows.UI;
global using Windows.UI.Xaml;
global using Windows.UI.Xaml.Data;
global using Windows.UI.Xaml.Media;
global using Windows.UI.Xaml.Controls;
#endif