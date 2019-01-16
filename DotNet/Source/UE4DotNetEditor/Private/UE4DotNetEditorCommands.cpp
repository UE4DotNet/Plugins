// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "UE4DotNetEditorCommands.h"

#define LOCTEXT_NAMESPACE "FUE4DotNetEditorModule"

void FUE4DotNetEditorCommands::RegisterCommands()
{
	UI_COMMAND(NewGameAction, "New Game", "Create a new DotNet Game", EUserInterfaceActionType::Button, FInputGesture());
	UI_COMMAND(NewClassAction, "New Class", "Create a new Game Class", EUserInterfaceActionType::Button, FInputGesture());
	UI_COMMAND(BuildGameAction, "Build Game", "Build the Game", EUserInterfaceActionType::Button, FInputGesture());
	UI_COMMAND(PlayGameAction, "Play Game", "Play the Game", EUserInterfaceActionType::Button, FInputGesture());
	UI_COMMAND(DebugGameAction, "Debug Game", "Debug the Game", EUserInterfaceActionType::Button, FInputGesture());
}

#undef LOCTEXT_NAMESPACE
