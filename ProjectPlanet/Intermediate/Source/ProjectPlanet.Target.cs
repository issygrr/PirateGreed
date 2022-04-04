using UnrealBuildTool;

public class ProjectPlanetTarget : TargetRules
{
	public ProjectPlanetTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectPlanet");
	}
}
