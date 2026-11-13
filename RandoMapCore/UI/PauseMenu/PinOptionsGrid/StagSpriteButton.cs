using MapChanger;
using MapChanger.UI;

namespace RandoMapCore.UI;

internal class StagSpriteButton: ExtraButton {
    protected override void OnClick()
    {
        RandoMapCoreMod.GS.ToggleStagSpriteSetting();
    }

    protected override TextFormat GetTextFormat()
    {
        var text = $"{"Stag Sprite".L()}:\n";

        return (
            text + RandoMapCoreMod.GS.StagSprite.ToString().ToWhitespaced().L(),
            RmcColorSetting.UI_Neutral
        ).ToTextFormat();
    }

    protected override TextFormat? GetHoverTextFormat()
    {
        return "Always show stag pin for MoreStags locations".L().ToNeutralTextFormat();
    }
}
