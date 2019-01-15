// Copyright 2019 JCoder58

#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "DotNetActionBinding.generated.h"

using ActionEventFunction = void(*)(FName name, FKey KeyValue, EInputEvent InputEvent);

/**
 * 
 */
UCLASS()
class DOTNET_API UDotNetActionBinding : public UObject
{
	GENERATED_BODY()
	
public:
	UPROPERTY(BlueprintReadOnly)
		FName ActionName;

	UPROPERTY(BlueprintReadOnly)
		UInputComponent* Input;

	UPROPERTY(BlueprintReadOnly)
		TEnumAsByte<EInputEvent> InputEvent;

	ActionEventFunction OnActionEvent;


	void ActionEvent(FKey Key);
	
};
