using Content.Shared.Backmen.Surgery.Pain;
using Content.Shared.FixedPoint;
using Robust.Shared.GameStates;

namespace Content.Shared.Backmen.Surgery.Steps;

[RegisterComponent, NetworkedComponent]
public sealed partial class SurgeryStepPainInflicterComponent : Component
{
    [DataField]
    public PainDamageTypes PainType = PainDamageTypes.WoundPain;

    [DataField]
    public FixedPoint2 SleepModifier = 1f;

    [DataField]
    public TimeSpan PainDuration = TimeSpan.FromSeconds(10f);

    [DataField]
    public FixedPoint2 Amount = 5;
}
