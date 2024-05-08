namespace Telegram.Bot.Types.Enums;

[JsonConverter(typeof(BackgroundTypeTypeConverter))]
public enum BackgroundTypeType
{
    /// <summary>
    /// <see cref="BackgroundTypeFill"/>
    /// </summary>
    Fill = 1,

    /// <summary>
    /// <see cref="BackgroundTypeWallpaper"/>
    /// </summary>
    Wallpaper,

    /// <summary>
    /// <see cref="BackgroundTypePattern"/>
    /// </summary>
    Pattern,

    /// <summary>
    /// <see cref="BackgroundTypeChatTheme"/>
    /// </summary>
    ChatTheme,
}
