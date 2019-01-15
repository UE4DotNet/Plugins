// Copyright 2018 - JCoder58

#include "CLRHost.h"
#include <functional>

#define _WIN32_WINNT_WIN10_RS1 0	// Generated undefined symbol error
#define _WIN32_WINNT_WIN10_RS2 0
#define _WIN32_WINNT_WIN10_RS3 0
#define _WIN32_WINNT_WIN10_TH2 0

#include <windows.h>

#include <metahost.h>
#pragma comment(lib, "mscoree.lib")

// Import mscorlib.tlb (Microsoft Common Language Runtime Class Library).
#import "mscorlib.tlb" raw_interfaces_only				\
    high_property_prefixes("_get","_put","_putref")		\
    rename("ReportEvent", "InteropServices_ReportEvent")
using namespace mscorlib;
#pragma endregion

static const auto* CLRVersion = TEXT("v4.0.30319");

CLRHost::~CLRHost()
{
	if (MetaHost) {
		MetaHost->Release();
		MetaHost = NULL;
	}
	if (RuntimeInfo) {
		RuntimeInfo->Release();
		RuntimeInfo = NULL;
	}
	if (ClrRuntimeHost) {
		ClrRuntimeHost->Stop();

		ClrRuntimeHost->Release();
		ClrRuntimeHost = NULL;
	}

}

bool CLRHost::Start() {
	HRESULT hr = CLRCreateInstance(CLSID_CLRMetaHost, IID_PPV_ARGS(&MetaHost));
	if (FAILED(hr)) {
		errorResult = hr;
		return false;
	}

	hr = MetaHost->GetRuntime(CLRVersion, IID_PPV_ARGS(&RuntimeInfo));
	if (FAILED(hr)) {
		errorResult = hr;
		return false;
	}

	BOOL fLoadable;
	hr = RuntimeInfo->IsLoadable(&fLoadable);
	if (FAILED(hr)) {
		errorResult = hr;
		return false;
	}

	if (!fLoadable) {
		errorResult = -1;
		return false;
	}

	hr = RuntimeInfo->GetInterface(CLSID_CLRRuntimeHost, IID_PPV_ARGS(&ClrRuntimeHost));
	if (FAILED(hr)) {
		errorResult = hr;
		return false;
	}

	hr = ClrRuntimeHost->Start();
	if (FAILED(hr)) {
		errorResult = hr;
		return false;
	}

	return true;
}

bool CLRHost::LoadIntoDefaultAppDomain(
	const wchar_t*	assemblyPath,
	const wchar_t* className,
	const wchar_t* staticMethodName,
	const wchar_t* stringArgument,
	unsigned long& result) {
	if (ClrRuntimeHost == nullptr)
		return false;

	auto hr = ClrRuntimeHost->ExecuteInDefaultAppDomain(
		assemblyPath,
		className, 
		staticMethodName, 
		stringArgument,
		&result);
	if (FAILED(hr)) {
		errorResult = hr;
		return false;
	}

	return true;
}
