using CCSharp.Attributes;
using CCSharp.ComputerCraft.Events;
using CCSharp.RedIL.Resolving.CommonResolvers;

namespace CCSharp.ComputerCraft;

[LuaEnum(typeof(TimeLocale))]
public enum TimeLocale
{
    [LuaEnumValue("ingame")] InGame,
    [LuaEnumValue("utc")] UTC,
    [LuaEnumValue("local")] Local
}

public static class OS
{
    /// <summary>
    /// Pause execution of the current thread and waits for any events matching filter.
    /// This function yields the current process and waits for it to be resumed with a vararg list where the first element matches filter. If no filter is supplied, this will match all events.
    /// Unlike OS.PullEventRaw, it will stop the application upon a "terminate" event, printing the error "Terminated".
    /// </summary>
    /// <returns>CCEvent</returns>
    [LuaMethod("os.pullEvent", CallMethodFlags.WrapAsTable)]
    public static CCEvent PullAnyEvent() => default;

    /// <summary>
    /// Pause execution of the current thread and waits for any events matching filter.
    /// This function yields the current process and waits for it to be resumed with a vararg list where the first element matches filter. If no filter is supplied, this will match all events.
    /// Unlike OS.PullEventRaw, it will stop the application upon a "terminate" event, printing the error "Terminated".
    /// </summary>
    /// <typeparam name="TEvent">Event implementation class</typeparam>
    /// <returns>TEvent</returns>
    [LuaMethod("os.pullEvent", CallMethodFlags.WrapAsTable | CallMethodFlags.ImplicitReturnTypeArgument)]
    public static TEvent PullEvent<TEvent>() where TEvent : CCEvent => default;

    /// <summary>
    /// Pause execution of the current thread and waits for any events matching filter.
    /// This function yields the current process and waits for it to be resumed with a vararg list where the first element matches filter. If no filter is supplied, this will match all events.
    /// Unlike OS.PullEventRaw, it will stop the application upon a "terminate" event, printing the error "Terminated".
    /// </summary>
    /// <param name="filter">Event to filter for.</param>
    /// <typeparam name="TEventResults">Either a subclass of CCEvent or a tuple of everything the event returns</typeparam>
    /// <returns>TEventResults</returns>
    [LuaMethod("os.pullEvent", CallMethodFlags.WrapAsTable)]
    public static TEventResults PullEvent<TEventResults>(string filter) => default;

    /// <summary>
    /// Pause execution of the current thread and waits for events, including the terminate event.
    /// This behaves almost the same as OS.PullAnyEvent, except it allows you to handle the terminate event yourself - the program will not stop execution when Ctrl+T is pressed.
    /// </summary>
    /// <returns>CCEvent</returns>
    [LuaMethod("os.pullEventRaw", CallMethodFlags.WrapAsTable)]
    public static CCEvent PullAnyEventRaw() => default;

    /// <summary>
    /// Pause execution of the current thread and waits for events, including the terminate event.
    /// This behaves almost the same as OS.PullEvent, except it allows you to handle the terminate event yourself - the program will not stop execution when Ctrl+T is pressed.
    /// </summary>
    /// <typeparam name="TEvent">Event implementation class</typeparam>
    /// <returns>TEvent</returns>
    [LuaMethod("os.pullEventRaw", CallMethodFlags.WrapAsTable | CallMethodFlags.ImplicitReturnTypeArgument)]
    public static TEvent PullEventRaw<TEvent>() where TEvent : CCEvent => default;

    /// <summary>
    /// Pause execution of the current thread and waits for events, including the terminate event.
    /// This behaves almost the same as OS.PullEvent, except it allows you to handle the terminate event yourself - the program will not stop execution when Ctrl+T is pressed.
    /// </summary>
    /// <param name="filter">Event to filter for.</param>
    /// <typeparam name="TEventResults">Either a subclass of CCEvent or a tuple of everything the event returns</typeparam>
    /// <returns>TEventResults</returns>
    [LuaMethod("os.pullEventRaw", CallMethodFlags.WrapAsTable)]
    public static TEventResults PullEventRaw<TEventResults>(string filter) => default;
    
    /// <summary>
    /// Pauses execution for the specified number of seconds
    /// </summary>
    /// <param name="time">The number of seconds to sleep for, rounded up to the nearest multiple of 0.05.</param>
    [LuaMethod("os.sleep")]
    public static void Sleep(float time) { }

    /// <summary>
    /// Get the current CraftOS version (for example, CraftOS 1.9).
    /// This is defined by bios.lua.
    /// </summary>
    [LuaMethod("os.version")]
    public static string Version() => default;

    /// <summary>
    /// Adds an event to the event queue. This event can later be pulled with os.pullEvent.
    /// </summary>
    [LuaMethod("os.queueEvent", CallMethodFlags.UnwrapTableIntoArguments)]
    public static void QueueEvent(CCEvent ccEvent) { }

    /// <summary>
    /// Starts a timer that will run for the specified number of seconds. Once the timer fires, a timer event will be added to the queue with the ID returned from this function as the first parameter.
    /// As with sleep, the time will automatically be rounded up to the nearest multiple of 0.05 seconds, as it waits for a fixed amount of world ticks.
    /// </summary>
    /// <param name="time">The number of seconds until the timer fires.</param>
    /// <returns>The ID of the new timer. This can be used to filter the timer event, or cancel the timer.</returns>
    [LuaMethod("os.startTimer")]
    public static int StartTimer(float time) => default;

    /// <summary>
    /// Cancels a timer previously started with StartTimer. This will stop the timer from firing.
    /// </summary>
    /// <param name="token">The ID of the timer to cancel.</param>
    [LuaMethod("os.cancelTimer")]
    public static void CancelTimer(int token) { }

    /// <summary>
    /// Sets an alarm that will fire at the specified in-game time. When it fires, an alarm event will be added to the event queue with the ID returned from this function as the first parameter.
    /// </summary>
    /// <param name="time">The time at which to fire the alarm, in the range [0.0, 24.0).</param>
    /// <returns>The ID of the new alarm. This can be used to filter the alarm event, or cancel the alarm.</returns>
    [LuaMethod("os.setAlarm")]
    public static int SetAlarm(float time) => default;

    /// <summary>
    /// Cancels an alarm previously started with setAlarm. This will stop the alarm from firing.
    /// </summary>
    /// <param name="token">The ID of the alarm to cancel.</param>
    [LuaMethod("os.cancelAlarm")]
    public static void CancelAlarm(int token) { }

    /// <summary>
    /// Shuts down the computer immediately.
    /// </summary>
    [LuaMethod("os.shutdown")]
    public static void Shutdown() { }

    /// <summary>
    /// Reboots the computer immediately.
    /// </summary>
    [LuaMethod("os.reboot")]
    public static void Reboot() { }

    /// <summary>
    /// Returns the ID of the computer.
    /// </summary>
    /// <returns>The ID of the computer.</returns>
    [LuaMethod("os.getComputerID")]
    public static int GetComputerID() => default;

    /// <summary>
    /// Returns the label of the computer, or null if none is set.
    /// </summary>
    /// <returns>The label of the computer.</returns>
    [LuaMethod("os.getComputerLabel")]
    public static string GetComputerLabel() => default;

    /// <summary>
    /// Set the label of this computer.
    /// </summary>
    /// <param name="label">The new label. May be null in order to clear it.</param>
    [LuaMethod("os.setComputerLabel")]
    public static void SetComputerLabel(string label) { }

    /// <summary>
    /// Returns the number of seconds that the computer has been running.
    /// </summary>
    /// <returns>The computer's uptime.</returns>
    [LuaMethod("os.clock")]
    public static float Clock() => default;

    /// <summary>
    /// Returns the current time depending on the string passed in. This will always be in the range [0.0, 24.0).
    /// </summary>
    /// <param name="locale">The locale of the time.</param>
    /// <returns>The hour of the selected locale.</returns>
    [LuaMethod("os.time")]
    public static float Time(TimeLocale locale) => default;

    /// <summary>
    /// Returns the current time depending on the string passed in. This will always be in the range [0.0, 24.0).
    /// </summary>
    /// <param name="time">DateTime from GetDateTime</param>
    /// <returns>The hour of the selected locale</returns>
    [LuaMethod("os.time")]
    public static float Time(DateTime time) => default;

    /// <summary>
    /// Returns the day depending on the locale specified.
    /// </summary>
    /// <param name="locale">The locale to get the day for.</param>
    /// <returns>The day depending on the selected locale.</returns>
    [LuaMethod("os.day")]
    public static int Day(TimeLocale locale) => default;

    /// <summary>
    /// Returns the number of milliseconds since an epoch depending on the locale.
    /// </summary>
    /// <param name="locale">The locale to get the milliseconds for.</param>
    /// <returns>The milliseconds since the epoch depending on the selected locale.</returns>
    [LuaMethod("os.epoch")]
    public static int Epoch(TimeLocale locale) => default;

    /// <summary>
    /// Returns a date string of the current time.
    /// The format string takes the same formats as C's strftime function. The format string can also be prefixed with an exclamation mark (!) to use UTC time instead of the server's local timezone.
    /// </summary>
    /// <returns>The resulting formatted string.</returns>
    [LuaMethod("os.date")]
    public static string Date() => default;

    /// <summary>
    /// Returns a date string of the current time using a specified format string.
    /// The format string takes the same formats as C's strftime function. The format string can also be prefixed with an exclamation mark (!) to use UTC time instead of the server's local timezone.
    /// </summary>
    /// <param name="format">The locale to get the milliseconds for.</param>
    /// <returns>The resulting formatted string.</returns>
    [LuaMethod("os.date")]
    public static string Date(string format) => default;

    /// <summary>
    /// Returns a date string using a specified format string.
    /// The format string takes the same formats as C's strftime function. The format string can also be prefixed with an exclamation mark (!) to use UTC time instead of the server's local timezone.
    /// </summary>
    /// <param name="format">The locale to get the milliseconds for.</param>
    /// <param name="time">The timestamp to convert to a string.</param>
    /// <returns>The resulting formatted string.</returns>
    [LuaMethod("os.date")]
    public static string Date(string format, int time) => default;

    /// <summary>
    /// Returns a DateTime of the current time
    /// </summary>
    /// <returns>A DateTime object of the current time.</returns>
    [LuaMethod("os.date", CallMethodFlags.ImplicitReturnTypeArgument)]
    public static DateTime GetDateTime() => default;

    /// <summary>
    /// Returns a DateTime of a specified time
    /// </summary>
    /// <param name="time">The timestamp of the time to create a DateTime out of.</param>
    /// <returns>A DateTime object of the current time.</returns>
    [LuaMethod("os.date", CallMethodFlags.ImplicitReturnTypeArgument)]
    public static DateTime GetDateTime(int time) => default;
}