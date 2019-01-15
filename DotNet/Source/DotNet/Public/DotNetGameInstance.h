// Copyright 2018 - JCoder58

#pragma once

#include "CoreMinimal.h"
#include "Engine/GameInstance.h"
#include "DotNetAxisBinding.h"
#include "DotNetActionBinding.h"
#include "DotNetGameInstance.generated.h"

//TODO: UPlatformGameInstance also needed.

/**
 * 
 */
UCLASS()
class DOTNET_API UDotNetGameInstance : public UGameInstance
{
	GENERATED_BODY()
	
public:
	UPROPERTY(BlueprintReadOnly)
		TArray<UDotNetAxisBinding*> AxisBindings;

	UPROPERTY(BlueprintReadOnly)
		TArray<UDotNetActionBinding*> ActionBindings;

	UPROPERTY(BlueprintReadWrite)
		TArray<UObject*> ObjectsSharedWithDotNet; 
	
	UPROPERTY(BlueprintReadWrite)
		int FirstFreeShared;

	virtual void Init() override;
	
	UFUNCTION(BlueprintImplementableEvent, meta = (DisplayName = "SetGameMode"))
	void SetGameModeBase(class AGameModeBase* gameModeBase, const FString& mapURL);

	virtual class AGameModeBase* CreateGameModeForURL(FURL InURL)  override;

	static void AddReferencedObjects(UObject* InThis, FReferenceCollector& Collector);

	void AddBinding(UDotNetAxisBinding* Binding);
	void AddBinding(UDotNetActionBinding* Binding);
	//TODO: Add GetBinding and RemoveBindage

	void AddSharedObject(UObject* obj);
	void RemoveSharedObject(UObject* obj);

};
