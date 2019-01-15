// Copyright 2019 JCoder58

#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"

#include "DotNetAxisBinding.generated.h"

using AxisEventFunction = void(*)(FName name, float axisValue);

/**
 * 
 */
UCLASS()
class UDotNetAxisBinding : public UObject
{
	GENERATED_BODY()
	
public:
	UPROPERTY(BlueprintReadOnly)
	FName AxisName;

	UPROPERTY(BlueprintReadOnly)
	UInputComponent* Input;

	AxisEventFunction OnAxisEvent;


	void AxisEvent(float AxisValue);
};
