// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE4_Mobile_Test_Cpp : ModuleRules
{
	public UE4_Mobile_Test_Cpp(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D" });
	}
}
