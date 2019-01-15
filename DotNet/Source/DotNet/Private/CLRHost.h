// Copyright 2018 - JCoder58

#pragma once

#include <stdio.h>
#include "DotNetCallTypes.h"


using LogDelegate = void(*)(int, const void*);
using PushNameDelegate = void(*)(FName, const void*);
using PushInterface = void(*)(FName, const void*);
using GetName = FName(*)(const TCHAR*);
using Test = void(*)(const TCHAR*);
using PushUObject = void(*)(class UObject*);
using ProcessEvent = void(*)(class UObject*, class UFunction*, void*);
using GetMethodUFunction = void*(*)(class UClass*, const TCHAR*);
using GetUFunction = void*(*)(const TCHAR*);
using GetUClass = void*(*)(const TCHAR*);
using GetDefaultObject = void*(*)(void*);
using DotNetCall = void*(*)(int callType, void* value);
using GetBoolPropertyValue = bool(*)(void* o, const TCHAR* name);
using SetBoolPropertyValue = void(*)(void* o, const TCHAR* name, bool value);
using SpawnUObject = void*(*)(class UClass*, class UObject*, FName);
using GetTransientPackageDelegate = UPackage *(*)();
using ShareMemoryDelegate = void(*)(class UObject*);
using ReleaseMemoryDelegate = void(*)(class UObject*);

// This struct must match the struct int SharedDotNet.cs
struct SharedDotNet {
	const uint32 StartGuardian;
	const uint32 SizeOfShared;

	const LogDelegate LogFunction;
	const GetName GetNameFunction;
	const ProcessEvent ProcessEventFunction;
	const GetUFunction GetUFunctionFunction;
	const GetUClass GetUClassFunction;
	const GetDefaultObject GetDefaultObjectFunction;
	const GetBoolPropertyValue GetBoolPropertyValueFunction;
	const SetBoolPropertyValue SetBoolPropertyValueFunction;
	const GetMethodUFunction GetMethodUFunctionFunction;
	const SpawnUObject NewObjectFunction;
	const GetTransientPackageDelegate GetTransientPackageFunction;
	const ShareMemoryDelegate ShareMemoryFunction;
	const ReleaseMemoryDelegate ReleaseMemoryFunction;

	const PushNameDelegate PushNameFunction;			// Will be set by SharedDotNet
	const PushInterface PushInterfaceFunction;			// Will be set by SharedDotNet
	const PushUObject PushUObjectFunction;				// Will be set by SharedDotNet
	const Test TestFunction;							// Will be Set by SharedDotNet
	const DotNetCall DotNetCallFunction;				// Will be Set by SharedDotNet

	const uint32 EndGuardian;

	SharedDotNet(LogDelegate logFunction, GetName getNameFunction,
		ProcessEvent processEventFunction, GetUFunction getUFunctionFunction,
		GetUClass getUClassFunction, GetDefaultObject getDefaultObjectFunction,
		GetBoolPropertyValue getBoolPropertyValueFunction,
		SetBoolPropertyValue setBoolPropertyValueFunction,
		GetMethodUFunction getMethodUFunctionFunction,
		SpawnUObject newObjectFunction,GetTransientPackageDelegate getTransientPackage,
		ShareMemoryDelegate shareMemoryFunction, ReleaseMemoryDelegate releaseMEmoryFunction
		) :
		StartGuardian(0x12345678),
		SizeOfShared(sizeof(SharedDotNet)),
		LogFunction(logFunction),
		GetNameFunction(getNameFunction),
		ProcessEventFunction(processEventFunction),
		GetUFunctionFunction(getUFunctionFunction),
		GetUClassFunction(getUClassFunction),
		GetDefaultObjectFunction(getDefaultObjectFunction),
		GetBoolPropertyValueFunction(getBoolPropertyValueFunction),
		SetBoolPropertyValueFunction(setBoolPropertyValueFunction),
		GetMethodUFunctionFunction(getMethodUFunctionFunction),
		NewObjectFunction(newObjectFunction),
		GetTransientPackageFunction(getTransientPackage),
		ShareMemoryFunction(shareMemoryFunction),
		ReleaseMemoryFunction(releaseMEmoryFunction),

		PushNameFunction(nullptr),
		PushInterfaceFunction(nullptr),
		PushUObjectFunction(nullptr),
		TestFunction(nullptr),
		DotNetCallFunction(nullptr),
		EndGuardian(0x87654321)
	{}
};


/**
 * 
 */
class CLRHost
{
public:
	CLRHost(LogDelegate logFunction, GetName getNameFunction,
		ProcessEvent processEventFunction, GetUFunction getUFunctionFunction,
		GetUClass getUClassFunction, GetDefaultObject getDefaultObjectFunction, 
		GetBoolPropertyValue getBoolPropertyValueFunction,
		SetBoolPropertyValue setBoolPropertyValueFunction,
		GetMethodUFunction getMethodUFunctionFunction,
		SpawnUObject newObjectFunction, GetTransientPackageDelegate getTransientPackage,
		ShareMemoryDelegate shareMemoryFunction, ReleaseMemoryDelegate releaseMemoryFunction
	) :
		SharedData(logFunction, getNameFunction, processEventFunction,
			getUFunctionFunction, getUClassFunction, getDefaultObjectFunction,
			getBoolPropertyValueFunction, setBoolPropertyValueFunction,
			getMethodUFunctionFunction, newObjectFunction, getTransientPackage,
			shareMemoryFunction,releaseMemoryFunction
			) {
		MetaHost = nullptr;
		RuntimeInfo = nullptr;
		ClrRuntimeHost = nullptr;
		errorResult = 0;
	}

	~CLRHost();

	bool Start();

	long GetErrorResult()const  {
		return errorResult;
	}

	bool IsOK() const {
		return errorResult >= 0;
	}

	const char* TextToPass() {
		sprintf(PassPointer, "%lld", (int64) &SharedData);
		return PassPointer;
	}

	template <typename T>
	void DotNetCallFunction(EDotNetCallType callType, T* value) {
		SharedData.DotNetCallFunction((int) callType, (void*)value);
	}

	template <typename T, typename R>
	R* DotNetCallFunction(EDotNetCallType callType, T* value) {
		return (R*) SharedData.DotNetCallFunction((int) callType, (void*)value);
	}

	static int GetIndexFromName(FName name) {
		return name.GetComparisonIndex();
	}

	void PushName(const FName& name) {
		auto text = name.ToString();
		SharedData.PushNameFunction(name, *text);
	}

	void PushInteface(FName name, struct DotNetInterfaceBase* interf) {
		SharedData.PushInterfaceFunction(name, interf);
	}

	void SetGameInstance(class UGameInstance* instance) {
		DotNetCallFunction(EDotNetCallType::SetGameInstance, instance);
	}

	void LoadDLL(const FString& dllFileName) {
		DotNetCallFunction(EDotNetCallType::LoadGameDLL, *dllFileName);
	}

	void CallStartFunction(const FString& callStartFunction, const FString& argument, UGameInstance* gameInstance) {
		const void* params[3] = { *callStartFunction, *argument, gameInstance };
		DotNetCallFunction(EDotNetCallType::CallStartFunction, params);
	}

	void Test(FString options) {
		SharedData.TestFunction(*options);
	}

	void* DotNetCall(EDotNetCallType callType, void* value) {
		return SharedData.DotNetCallFunction((int) callType, value);
	}

	bool LoadIntoDefaultAppDomain(
		const wchar_t*	assemblyPath, 
		const wchar_t* className,
		const wchar_t* staticMethodName, 
		const wchar_t* stringArgument,
		unsigned long& result);

private:
	SharedDotNet SharedData;
    struct ICLRMetaHost *MetaHost;
    struct ICLRRuntimeInfo *RuntimeInfo;
	struct ICLRRuntimeHost *ClrRuntimeHost;
	long errorResult;
	char PassPointer[64];
};
