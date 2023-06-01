using UnrealBuildTool;

public class PixelStreamingMITarget : TargetRules
{
	public PixelStreamingMITarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PixelStreamingMI");
	}
}
