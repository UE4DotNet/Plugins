// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

DOTNET_API class FDotNetModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

	class CLRHost* GetHost() { return Host; }

	DOTNET_API static FDotNetModule* GetModule() {
		return Module;
	}

	virtual void LoadGameDll(UGameInstance* gameInstance);

	DOTNET_API void NewGame();
	DOTNET_API void NewClass();
	DOTNET_API void BuildGame();
	DOTNET_API void PlayGame();
	DOTNET_API void DebugGame();

private:
	static FDotNetModule* Module;
	class CLRHost* Host;
	class UObjectLifetimeManager* LifetimeManager;
};
