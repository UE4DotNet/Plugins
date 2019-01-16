// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Framework/Commands/Commands.h"
#include "UE4DotNetEditorStyle.h"

class FUE4DotNetEditorCommands : public TCommands<FUE4DotNetEditorCommands>
{
public:

	FUE4DotNetEditorCommands()
		: TCommands<FUE4DotNetEditorCommands>(TEXT("UE4DotNetEditor"), NSLOCTEXT("Contexts", "UE4DotNetEditor", "UE4DotNetEditor Plugin"), NAME_None, FUE4DotNetEditorStyle::GetStyleSetName())
	{
	}

	// TCommands<> interface
	virtual void RegisterCommands() override;

public:
	TSharedPtr<FUICommandInfo> NewGameAction;
	TSharedPtr<FUICommandInfo> NewClassAction;
	TSharedPtr<FUICommandInfo> BuildGameAction;
	TSharedPtr<FUICommandInfo> PlayGameAction;
	TSharedPtr<FUICommandInfo> DebugGameAction;
};
