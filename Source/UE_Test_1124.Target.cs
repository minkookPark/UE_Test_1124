// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UE_Test_1124Target : TargetRules
{
	public UE_Test_1124Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;

		ExtraModuleNames.AddRange( new string[] { "UE_Test_1124" } );
	}
}
