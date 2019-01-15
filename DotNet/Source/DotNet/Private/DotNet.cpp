// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "DotNet.h"
#include "UObjectGlobals.h"
#include "Paths.h"
#include "LogVerbosity.h"
#include "Class.h"
#include "DotNetInterface.h"
#include "PathsInterface.h"
#include "ObjectLifetimeManager.h"
#include "DotNetConfig.h"
#include "Interfaces.h"
#include "DotNetGameInstance.h"
#if WITH_EDITOR
#include "ISettingsModule.h"
#endif
#include "EngineUtils.h"
#include "Engine/TextRenderActor.h"
#include "SourceWriter.h"
#include "CLRHost.h"

#define LOCTEXT_NAMESPACE "FDotNetModule"

FDotNetModule* FDotNetModule::Module;

static void DotNetLog(int level, const void* data) {
	const wchar_t* text = (const wchar_t*)data;
	ELogVerbosity::Type verbosity((ELogVerbosity::Type) level);
	GLog->Log(verbosity, text);
}

static FName GetNameFunction(const TCHAR* string) {
	return FName(string);
}

static void ProcessEventFunction(UObject* obj, UFunction* func, void* data) {
	if (obj == nullptr) {
		//TODO: Is this right?  We need a contxt for ProcessEvent, but 
		//      this is a global blueprint function with no object.
		func->ProcessEvent(func, data);
	} else
		obj->ProcessEvent(func, data);
}

static void* GetMethodUFunctionFunction(UClass* klass, const TCHAR* fName) {
	return klass->FindFunctionByName(fName, EIncludeSuperFlag::IncludeSuper);
}

static void* NewObjectFunction(UClass* klass, UObject* outer, FName name) {
	return StaticConstructObject_Internal(klass, outer, name);
}

static void* GetUFunctionFunction(const TCHAR* fName) {
	FName name(fName);
	UFunction* func = FindObject<UFunction>(ANY_PACKAGE, fName);
	if (func != nullptr)
		return func;
	GLog->Log(ELogVerbosity::Fatal, FString("Function ") + fName + FString("not found"));
	return nullptr;
}

static void* GetUClassFunction(const TCHAR* fName) {
	FName name(fName);
	UClass* cl = FindObject<UClass>(ANY_PACKAGE, fName);
	if (cl != nullptr)
		return cl;
	GLog->Log(ELogVerbosity::Fatal, FString("Class ") + fName + FString("not found"));
	return nullptr;
}

static void* GetDefaultObjectFunction(void* class_) {
	UClass* c = (UClass*)class_;
	check(c);
	UObject* defaultObject = c->GetDefaultObject();
	return defaultObject;
}

static UDotNetGameInstance* GameInstance;

static void ShareObject(UObject* obj) {
	if (GameInstance != nullptr)
		GameInstance->AddSharedObject(obj);
}

static void ReleaseObject(UObject* obj) {
	if (GameInstance != nullptr)
		GameInstance->RemoveSharedObject(obj);
}

static bool GetBoolPropertyValueByName(void* obj_, const TCHAR* pName) {
	FString name(pName);
	UObject* obj = (UObject*)obj_;
	AActor* a = Cast<AActor>(obj);
	auto b = a->bBlockInput;

	auto class_ = obj->GetClass();

	//TODO: CHange this to use FindField<UBoolProperty>
	auto it = TFieldIterator<UProperty>(class_);
	for (; it; ++it) {
		if ((*it)->IsA<UBoolProperty>() && (*it)->GetName() == name) {
			auto boolProp = Cast<UBoolProperty>(*it);
			return boolProp->GetPropertyValue((byte*) obj + boolProp->GetOffset_ForInternal());
		}
	}
	FString message = FString::Printf(TEXT("boolean field %s not found"), pName);
	GLog->Log(ELogVerbosity::Fatal, message);
	return false;
}

static void SetBoolPropertyValueByName(void* obj_, const TCHAR* pName, bool value) {
	FString name(pName);
	UObject* obj = (UObject*)obj_;

	auto class_ = obj->GetClass();

	//TODO: CHange this to use FindField<UBoolProperty>
	auto it = TFieldIterator<UProperty>(class_);
	for (; it; ++it) {
		if ((*it)->IsA<UBoolProperty>() && (*it)->GetName() == name) {
			auto boolProp = Cast<UBoolProperty>(*it);
			boolProp->SetPropertyValue((byte*)obj + boolProp->GetOffset_ForInternal(), value);
			return;
		}
	}
	FString message = FString::Printf(TEXT("boolean field %s not found"), pName);
	GLog->Log(ELogVerbosity::Fatal, message);
}

#if WITH_EDITOR
static void WriteEnums(UObject* obj) {
	using namespace SourceWriter;

	auto source = make(enum_file(), Cast<UField>(obj));
}

static void WriteStructs(UObject* obj) {
	using namespace SourceWriter;

	auto source = make(struct_file(), Cast<UField>(obj));
}

static void WriteClasses(UObject* obj) {
	using namespace SourceWriter;

	auto source = make(class_file(), Cast<UField>(obj));
}

static void WriteFrame() {
	using namespace SourceWriter;

	auto source = make(frame_file(), nullptr);
}

static void WriteSource() {
	using namespace SourceWriter;

	if (false) {
		WriteFrame();
		ForEachObjectOfClass(UScriptStruct::StaticClass(), WriteStructs);
		ForEachObjectOfClass(UClass::StaticClass(), WriteClasses);
		ForEachObjectOfClass(UEnum::StaticClass(), WriteEnums);
		auto x = 3;
	}
}
#endif

void FDotNetModule::StartupModule()
{
	Module = this;
	LifetimeManager = NewObject<UObjectLifetimeManager>(UObjectLifetimeManager::StaticClass());
	auto path = FPaths::ProjectPluginsDir();
#if WITH_EDITOR

	// register settings
	ISettingsModule* SettingsModule = FModuleManager::GetModulePtr<ISettingsModule>("Settings");

	if (SettingsModule != nullptr)
	{
		auto SettingsSection = SettingsModule->RegisterSettings("Project", "Plugins", "UE4DotNet",
			LOCTEXT("UE4DotNetName", "UE4 Dot Net"),
			LOCTEXT("UE4DotNetDescription", "Configure the Dot Net Plug-in."),
			GetMutableDefault<UDotNetConfig>()
		);

		if (SettingsSection.IsValid())
		{
			//SettingsSection->OnModified().BindRaw(this, &FTcpMessagingModule::HandleSettingsSaved);
		}
	}


	WriteSource();
#endif // WITH_EDITOR

	//TODO: Change this to correct directory
	path = path / TEXT("DotNet/DotNet/UE4/bin/Debug/netstandard2.0");
	Host = new CLRHost(DotNetLog, GetNameFunction, 
		ProcessEventFunction, GetUFunctionFunction, 
		GetUClassFunction, GetDefaultObjectFunction,
		GetBoolPropertyValueByName, SetBoolPropertyValueByName,
		GetMethodUFunctionFunction, NewObjectFunction, GetTransientPackage,
		ShareObject, ReleaseObject
	);

	Host->Start();
	if (Host->IsOK()) {
		unsigned long result;
		auto dllFileName = path / "UE4DotNet.dll";
		FString text(Host->TextToPass());
		Host->LoadIntoDefaultAppDomain(
			*dllFileName, TEXT("UE4.Main"), TEXT("Start"), 
			*text, result);
		if (!Host->IsOK()) {
			auto errorCode = Host->GetErrorResult();
			GLog->Logf(ELogVerbosity::Type::Fatal, TEXT("Failed to start CLR and load Ue4DotNet.dll (%d)"), errorCode);
		}
		else {
			PushPathsInterface(*Host);
			PushFunctionInterface(*Host);
			PushStringInterface(*Host);
			PointerArrayInterface(*Host);
			UObjectFunctionInteface(*Host);
			InputInterface(*Host);
			
			Host->Test("Hello, World!");
		}
	}
}

void FDotNetModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
		
}

void FDotNetModule::LoadGameDll(UGameInstance* gameInstance) {
	GameInstance = Cast<UDotNetGameInstance>( gameInstance );
	Host->SetGameInstance(gameInstance);

	auto config = GetDefault<UDotNetConfig>();
	if (config->DLLGameFileName.IsEmpty()) {
		GLog->Log(ELogVerbosity::Warning, "No file name for the DotNet DLL found.  Set in the Project settings under UE4 Dot Net");
		return;
	}
	Host->LoadDLL(config->DLLGameFileName);
	Host->CallStartFunction(config->GameInstanceClass, config->Argument, gameInstance);
}

void FDotNetModule::NewGame() {
	Host->DotNetCall(EDotNetCallType::NewGame, nullptr);
}

void FDotNetModule::NewClass() {
	Host->DotNetCall(EDotNetCallType::NewClass, nullptr);
}

void FDotNetModule::BuildGame() {
	Host->DotNetCall(EDotNetCallType::BuildGame, nullptr);
}

void FDotNetModule::PlayGame() {
	Host->DotNetCall(EDotNetCallType::PlayGame, nullptr);
}

void FDotNetModule::DebugGame() {
	Host->DotNetCall(EDotNetCallType::DebugGame, nullptr);
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FDotNetModule, DotNet)