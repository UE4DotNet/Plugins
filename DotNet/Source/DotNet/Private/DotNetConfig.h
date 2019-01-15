// Copyright 2018 - JCoder58

#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "DotNetConfig.generated.h"

/**
 * 
 */
UCLASS(config=Game)
class DOTNET_API UDotNetConfig : public UObject
{
	GENERATED_BODY()

public:
	// Name of DotNet DLL to load
	UPROPERTY(config, EditAnywhere, Category = StartUp)
	FString DLLGameFileName;

	// fully qualified function name (namespace.className.function()) */
	UPROPERTY(config, EditAnywhere, Category = StartUp)
		FString GameInstanceClass;

	// Argument passed to Start Function
	UPROPERTY(config, EditAnywhere, Category = StartUp)
		FString Argument;

};
