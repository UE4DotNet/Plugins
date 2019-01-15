// Copyright 2018 - JCoder58

#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "ObjectLifetimeManager.generated.h"

/**
 * 
 */
UCLASS()
class DOTNET_API UObjectLifetimeManager : public UObject
{
	GENERATED_BODY()

public:
	void AddToLifetime(UObject* object) {
		CLRObjects.Add(object);
	}

	void ReleaseFromLifttime(UObject* object) {
		int32 index = 0;
		if (CLRObjects.Find(object, index)) {
			CLRObjects[index] = nullptr;
		}
	}

	UPROPERTY()
	TArray<UObject*> CLRObjects;
};
