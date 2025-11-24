using CCSharp.Attributes;

namespace CCSharp.ComputerCraft.Events;

[LuaImplicitTypeArgument("speaker_audio_empty")]
public class SpeakerAudioEmptyEvent : CCEvent
{
    /// <summary>
    /// The side or network ID of the speaker which is available to play more audio.
    /// </summary>
    [LuaProperty(2)]
    public string Name { get; set; }
    /// <summary>
    /// The side of the speaker which is available to play more audio.
    /// </summary>
    [LuaProperty(2)]
    public PeripheralSide Side { get; set; }
}