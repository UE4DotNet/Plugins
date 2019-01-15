#include "Interfaces.h"
#include "DotNetInterface.h"
#include "UObjectGlobals.h"
#include "Components/ActorComponent.h"

static const FName UObjectName("UObject");

using LoadObjectDelegate = UObject * (*)(UClass*, UObject*, const TCHAR*, const TCHAR*, uint32, UPackageMap*, bool);
using LoadClassDelegate = UClass * (*)(UClass*, UObject*, const TCHAR*, const TCHAR*, uint32, UPackageMap*);
using RegisterComponentDelegate = void(*)(class UActorComponent* component);
using UnregisterComponentDelegate = void(*)(UActorComponent* component);
using GetPropertyFromNameDelegate = UProperty * (*)(UObject*, FName);
using GetBoolPropertyValueDelegate = bool(*)(UObject*, UBoolProperty*);
using SetBoolPropertyValueDelegate = void(*)(UObject*, UBoolProperty*, bool value);
using GetFloatPropertyValueDelegate = float(*)(UObject*, UFloatProperty*);
using SetFloatPropertyValueDelegate = void(*)(UObject*, UFloatProperty*, float value);

struct UObjectInterface {
	LoadObjectDelegate LoadObject;
	LoadClassDelegate LoadClass;
	RegisterComponentDelegate RegisterCoomponent;
	UnregisterComponentDelegate UnregisterComponent;
	GetPropertyFromNameDelegate GetPropertyFromName;
	GetBoolPropertyValueDelegate GetBoolPropertyValue;
	SetBoolPropertyValueDelegate SetBoolPropertyValue;
	GetFloatPropertyValueDelegate GetFloatPropertyValue;
	SetFloatPropertyValueDelegate SetFloatPropertyValue;
};

static void RegisterComponent(UActorComponent* component) {
	component->RegisterComponent();
}

static void UnregisterComponent(UActorComponent* component) {
	component->UnregisterComponent();
}

static UProperty* GetPropertyFromName(UObject* obj, FName name) {
	auto field = FindField<UProperty>(obj->GetClass(), name);
	return field;
}

//TODO: SetBoolPropertyValue, SetFloatPropertyValue, SetIntPropertyValue, etc.
static bool GetBoolPropertyValueFunc(UObject* container, UBoolProperty* prop) {
	auto offset = prop->GetOffset_ForInternal();
	return prop->GetPropertyValue((byte*)container + offset);
}

static void SetBoolPropertyValueFunc(UObject* container, UBoolProperty* prop, bool value) {
	auto offset = prop->GetOffset_ForInternal();
	prop->SetPropertyValue((byte*)container + offset, value);
}

static float GetFloatPropertyValueFunc(UObject* container, UFloatProperty* prop) {
	auto offset = prop->GetOffset_ForInternal();
	return prop->GetPropertyValue((byte*)container + offset);
}

static void SetFloatPropertyValueFunc(UObject* container, UFloatProperty* prop, float value) {
	auto offset = prop->GetOffset_ForInternal();
	prop->SetPropertyValue((byte*)container + offset, value);
}

static DotNetInterface<UObjectInterface> UObjectRouter(UObjectName);

void UObjectFunctionInteface(class CLRHost& clrHost) {
	UObjectRouter.Interface.LoadObject = StaticLoadObject;
	UObjectRouter.Interface.LoadClass = StaticLoadClass;
	UObjectRouter.Interface.RegisterCoomponent = RegisterComponent;
	UObjectRouter.Interface.UnregisterComponent = UnregisterComponent;
	UObjectRouter.Interface.GetPropertyFromName = GetPropertyFromName;
	UObjectRouter.Interface.GetBoolPropertyValue = GetBoolPropertyValueFunc;
	UObjectRouter.Interface.SetBoolPropertyValue = SetBoolPropertyValueFunc;
	UObjectRouter.Interface.GetFloatPropertyValue = GetFloatPropertyValueFunc;
	UObjectRouter.Interface.SetFloatPropertyValue = SetFloatPropertyValueFunc;

	clrHost.PushInteface(UObjectName, &UObjectRouter);
}