using ChatTwo.Resources;
using ChatTwo.Util;
using ImGuiNET;

namespace ChatTwo.Ui.SettingsTabs;

internal sealed class Display : ISettingsTab {
    private Configuration Mutable { get; }

    public string Name => Language.Options_Display_Tab + "###tabs-display";

    internal Display(Configuration mutable) {
        Mutable = mutable;
    }

    public void Draw(bool changed) {
        ImGui.PushTextWrapPos();

        ImGuiUtil.OptionCheckbox(ref Mutable.HideChat, Language.Options_HideChat_Name, Language.Options_HideChat_Description);
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(
            ref Mutable.HideDuringCutscenes,
            Language.Options_HideDuringCutscenes_Name,
            string.Format(Language.Options_HideDuringCutscenes_Description, Plugin.PluginName)
        );
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(
            ref Mutable.HideWhenNotLoggedIn,
            Language.Options_HideWhenNotLoggedIn_Name,
            string.Format(Language.Options_HideWhenNotLoggedIn_Description, Plugin.PluginName)
        );
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(
            ref Mutable.HideWhenUiHidden,
            Language.Options_HideWhenUiHidden_Name,
            string.Format(Language.Options_HideWhenUiHidden_Description, Plugin.PluginName)
        );
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(
            ref Mutable.NativeItemTooltips,
            Language.Options_NativeItemTooltips_Name,
            string.Format(Language.Options_NativeItemTooltips_Description, Plugin.PluginName)
        );
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(
            ref Mutable.SidebarTabView,
            Language.Options_SidebarTabView_Name,
            string.Format(Language.Options_SidebarTabView_Description, Plugin.PluginName)
        );
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(ref Mutable.PrettierTimestamps, Language.Options_PrettierTimestamps_Name, Language.Options_PrettierTimestamps_Description);

        if (Mutable.PrettierTimestamps) {
            ImGui.TreePush();
            ImGuiUtil.OptionCheckbox(ref Mutable.MoreCompactPretty, Language.Options_MoreCompactPretty_Name, Language.Options_MoreCompactPretty_Description);
            ImGuiUtil.OptionCheckbox(ref Mutable.HideSameTimestamps, Language.Options_HideSameTimestamps_Name, Language.Options_HideSameTimestamps_Description);
            ImGui.TreePop();
        }

        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(ref Mutable.CollapseDuplicateMessages, Language.Options_CollapseDuplicateMessages_Name, Language.Options_CollapseDuplicateMessages_Description);
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(ref Mutable.ShowNoviceNetwork, Language.Options_ShowNoviceNetwork_Name, Language.Options_ShowNoviceNetwork_Description);
        ImGui.Spacing();

        ImGuiUtil.DragFloatVertical(Language.Options_TooltipOffset_Name, Language.Options_TooltipOffset_Desc, ref Mutable.TooltipOffset, 1, 0f, 400f, $"{Mutable.TooltipOffset:N0}px", ImGuiSliderFlags.AlwaysClamp);
        ImGui.Spacing();

        ImGuiUtil.DragFloatVertical(Language.Options_WindowOpacity_Name, ref Mutable.WindowAlpha, .25f, 0f, 100f, $"{Mutable.WindowAlpha:N2}%%", ImGuiSliderFlags.AlwaysClamp);
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(ref Mutable.CanMove, Language.Options_CanMove_Name);
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(ref Mutable.CanResize, Language.Options_CanResize_Name);
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(ref Mutable.ShowTitleBar, Language.Options_ShowTitleBar_Name);
        ImGui.Spacing();

        ImGuiUtil.OptionCheckbox(ref Mutable.ShowPopOutTitleBar, Language.Options_ShowPopOutTitleBar_Name);
        ImGui.Spacing();

        ImGui.PopTextWrapPos();
    }
}
