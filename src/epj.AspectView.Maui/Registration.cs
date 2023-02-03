using Microsoft.Maui.Handlers;

namespace epj.AspectView.Maui;

public static class Registration
{
    public static MauiAppBuilder UseAspectView(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(h =>
        {
            h.AddHandler<AspectView, ContentViewHandler>();
        });

        return builder;
    }
}