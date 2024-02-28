// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Utilities : ModuleRules
{
	public Utilities(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PublicIncludePaths.AddRange(new string[] { "Utilities" });

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "Engine" });
	}
}
