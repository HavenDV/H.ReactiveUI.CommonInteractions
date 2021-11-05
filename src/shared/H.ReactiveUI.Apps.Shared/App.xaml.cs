﻿using H.ReactiveUI.Apps.Views;
#if !HAS_WPF
using Windows.ApplicationModel.Activation;
#endif

#nullable enable

namespace H.ReactiveUI.Apps;

public sealed partial class App
{
    #region Properties

    private InteractionManager InteractionManager { get; } = new();

    #endregion

    #region Constructors

    public App()
    {
        InteractionManager.Register();
        InteractionManager.CatchUnhandledExceptions(this);

#if !HAS_WPF
        InitializeComponent();
#endif
    }

    #endregion

    #region Event Handlers

#if !HAS_WPF

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
#if HAS_WINUI
        var window = new Window();
#else
        var window = Window.Current;
#endif
        if (window.Content is not Frame frame)
        {
            frame = new Frame();

            window.Content = frame;
        }

#if !HAS_WINUI
        if (args.PrelaunchActivated)
        {
            return;
        }
#endif

        if (frame.Content is null)
        {
            frame.Content = new MainView();
        }

        window.Activate();
    }

#endif

#endregion
}
