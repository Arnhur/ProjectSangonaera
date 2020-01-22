using UnrealBuildTool;

public class SangoneraTarget : TargetRules
{
	public SangoneraTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Sangonera");
	}
}
