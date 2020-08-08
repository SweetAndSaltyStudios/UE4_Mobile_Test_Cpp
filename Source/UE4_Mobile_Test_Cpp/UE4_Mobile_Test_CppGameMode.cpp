// Copyright Epic Games, Inc. All Rights Reserved.

#include "UE4_Mobile_Test_CppGameMode.h"
#include "UE4_Mobile_Test_CppCharacter.h"

AUE4_Mobile_Test_CppGameMode::AUE4_Mobile_Test_CppGameMode()
{
	// Set default pawn class to our character
	DefaultPawnClass = AUE4_Mobile_Test_CppCharacter::StaticClass();	
}
