using ItemChanger;
using RandoMapCore.Settings;

namespace RandoMapCore.Pins;

internal sealed class RandomizedStagPinDef: RandomizedPinDef {
    public RandomizedStagPinDef(AbstractPlacement placement): base(placement) {
        Stag = new(placement.Name);
    }

    internal StagInfo Stag { get; }

    internal override void Update() {
        base.Update();
        Stag.Update();
    }

    internal override bool ActiveByCurrentMode() => DoOverride ? true : base.ActiveByCurrentMode();

    internal override bool ActiveBySettings() => DoOverride ? true : base.ActiveBySettings();

    internal override bool ActiveByProgress() => DoOverride ? true : base.ActiveByProgress();

    internal override IEnumerable<ScaledPinSprite> GetPinSprites() => DoOverride ? [RmcPinManager.Psm.GetSprite("Stags")] : base.GetPinSprites();

    internal override PinShape GetMixedPinShape() => DoOverride ? PinShape.Circle : base.GetMixedPinShape();

    internal override float GetZPriority() => DoOverride ? -1f : base.GetZPriority();

    private bool DoOverride => Stag.IsActiveStag && RandoMapCoreMod.GS.StagSprite == StagSpriteSetting.AlwaysStag;
}
