using MapChanger.UI;

namespace RandoMapCore.UI;

internal class PinOptionsGrid : RmcOptionsGrid
{
    protected override IEnumerable<ExtraButton> GetButtons()
    {
        if(Interop.HasMoreStags)
            return [new ClearedButton(), new ReachablePinsButton(), new QMarkSettingButton(), new StagSpriteButton()];
        return [new ClearedButton(), new ReachablePinsButton(), new QMarkSettingButton()];
    }
}
