namespace Dalamud.Game.Addon.Lifecycle.AddonArgTypes;

/// <summary>
/// Addon argument data for Show events.
/// </summary>
/// <remarks>This event does not allow mutating the arg data.</remarks>
public class AddonHideArgs : AddonArgs, ICloneable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddonHideArgs"/> class.
    /// </summary>
    [Obsolete("Not intended for public construction.", false)]
    public AddonHideArgs()
    {
    }

    /// <inheritdoc/>
    public override AddonArgsType Type => AddonArgsType.Hide;

    /// <summary>
    /// Gets a value indicating whether this event has the close transition disabled.
    /// </summary>
    public bool DisableCloseTransition { get; internal set; }

    /// <summary>
    /// Gets a value indicating whether this event triggered the hide callback.
    /// </summary>
    public bool TriggerCloseHideCallback { get; internal set; }

    /// <summary>
    /// Gets a value indicating whether this event triggered the ShowHide Flags to be changed.
    /// </summary>
    public int SetShowHideFlags { get; internal set; }

    /// <inheritdoc cref="ICloneable.Clone"/>
    public AddonHideArgs Clone() => (AddonHideArgs)this.MemberwiseClone();

    /// <inheritdoc cref="Clone"/>
    object ICloneable.Clone() => this.Clone();

    /// <inheritdoc cref="AddonArgs.Clear"/>
    internal override void Clear()
    {
        base.Clear();

        this.DisableCloseTransition = false;
        this.TriggerCloseHideCallback = false;
        this.SetShowHideFlags = 0;
    }
}
