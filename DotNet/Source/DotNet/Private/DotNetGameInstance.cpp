// Copyright 2018 - JCoder58

#include "DotNetGameInstance.h"
#include "DotNet.h"

void UDotNetGameInstance::Init() {
	auto* dotNet = FDotNetModule::GetModule(); 
	ObjectsSharedWithDotNet.Reserve(100);
	
	Super::Init();

	dotNet->LoadGameDll(this);

}

AGameModeBase* UDotNetGameInstance::CreateGameModeForURL(FURL InURL) {
	auto* gameModeBase = Super::CreateGameModeForURL(InURL);

	SetGameModeBase(gameModeBase,InURL.ToString());
	
	return gameModeBase;
}

void UDotNetGameInstance::AddBinding(UDotNetAxisBinding* AxisBinding) {
	for (auto b : AxisBindings)
		if (b == AxisBinding) {
			GLog->Log(ELogVerbosity::Error, TEXT("Duplicate AxisBinding"));
			return;
		}
	AxisBindings.Add(AxisBinding);
}

void UDotNetGameInstance::AddBinding(UDotNetActionBinding* ActionBinding) {
	for (auto b : ActionBindings)
		if (b == ActionBinding) {
			GLog->Log(ELogVerbosity::Error, TEXT("Duplicate ActionBinding"));
			return;
		}
	ActionBindings.Add(ActionBinding);
}

void UDotNetGameInstance::AddReferencedObjects(UObject* InThis, FReferenceCollector& Collector) {
}

void UDotNetGameInstance::RemoveSharedObject(UObject* InThis) {
	int i = ObjectsSharedWithDotNet.Num();
	while (--i >= 0)
		if (ObjectsSharedWithDotNet[i] == InThis) {
			ObjectsSharedWithDotNet[i] = nullptr;
			if (i < FirstFreeShared)
				FirstFreeShared = i;
			break;
		}
}

void UDotNetGameInstance::AddSharedObject(UObject* InThis) {
	if (ObjectsSharedWithDotNet.Num() == 0 || FirstFreeShared >= ObjectsSharedWithDotNet.Num()) {
		ObjectsSharedWithDotNet.Add(InThis);
		FirstFreeShared = ObjectsSharedWithDotNet.Num();
	}
	else {
		ObjectsSharedWithDotNet[FirstFreeShared] = InThis;
		FirstFreeShared = ObjectsSharedWithDotNet.Num();
		for (int i = FirstFreeShared + 1; i < ObjectsSharedWithDotNet.Num(); i++) {
			if (ObjectsSharedWithDotNet[i] == nullptr) {
				FirstFreeShared = i;
				break;
			}
		}
	}

}
