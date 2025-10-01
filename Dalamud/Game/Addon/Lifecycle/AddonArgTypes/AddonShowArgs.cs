namespace Dalamud.Game.Addon.Lifecycle.AddonArgTypes;

/// <summary>
/// Addon argument data for Show events.
/// </summary>
/// <remarks>This event does not allow mutating the arg data.</remarks>
public class AddonShowArgs : AddonArgs, ICloneable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddonShowArgs"/> class.
    /// </summary>
    [Obsolete("Not intended for public construction.", false)]
    public AddonShowArgs()
    {
    }

    /// <inheritdoc/>
    public override AddonArgsType Type => AddonArgsType.Show;

    /// <summary>
    /// Gets a value indicating whether this event has the open sound effect suppressed.
    /// </summary>
    public bool SilenceOpenSoundEffect { get; internal set; }

    /// <summary>
    /// Gets a value indicating whether this event triggered the ShowHide Flags to be changed.
    /// </summary>
    public int UnsetShowHideFlags { get; internal set; }

    /// <inheritdoc cref="ICloneable.Clone"/>
    public AddonShowArgs Clone() => (AddonShowArgs)this.MemberwiseClone();

    /// <inheritdoc cref="Clone"/>
    object ICloneable.Clone() => this.Clone();

    /// <inheritdoc cref="AddonArgs.Clear"/>
    internal override void Clear()
    {
        base.Clear();

        this.SilenceOpenSoundEffect = false;
        this.UnsetShowHideFlags = 0;
    }
}
