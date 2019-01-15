#include "Interfaces.h"
#include "DotNetInterface.h"

static const FName FunctionName("Function");

using GetFlagsFunction = int32(*)(UFunction*);
using SetFlagsFunction = void(*)(UFunction*, int32);
using GetNativeFuncFunction = void*(*)(UFunction*);
using SetNativeFuncFunction = void(*)(UFunction*,void*);

struct FunctionsInterface {
	GetFlagsFunction GetFlags;
	SetFlagsFunction SetFlags;
	GetNativeFuncFunction GetNativeFunc;
	SetNativeFuncFunction SetNativeFunc;
};

static int32 GetFlags(UFunction* func) {
	return func->FunctionFlags;
}

static void SetFlags(UFunction* func, int32 flags) {
	func->FunctionFlags = (EFunctionFlags)flags;
}

static void* GetNativeFunc(UFunction* func) {
	return (void*)func->GetNativeFunc();
}

static void SetNativeFunc(UFunction* func, void* nativeFunc) {
	func->SetNativeFunc((FNativeFuncPtr)nativeFunc);
}

static DotNetInterface<FunctionsInterface> FunctionRouter(FunctionName);

void PushFunctionInterface(class CLRHost& clrHost) {
	FunctionRouter.Interface.GetFlags = GetFlags;
	FunctionRouter.Interface.SetFlags = SetFlags;
	FunctionRouter.Interface.GetNativeFunc = GetNativeFunc;
	FunctionRouter.Interface.SetNativeFunc = SetNativeFunc;

	clrHost.PushName(FunctionName);
	clrHost.PushInteface(FunctionName, &FunctionRouter);
}