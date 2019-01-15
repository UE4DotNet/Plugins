#include "Interfaces.h"
#include "DotNetInterface.h"
#include "CoreMinimal.h"

static const FName StringName("String");

using InitStringFunction = void(*)(void*);
using GetLengthFunction = int32(*)(const FString*);
using GetCharFunction = int32(*)(const FString*, int32 index);
using SetCharFunction = int32(*)(FString*, int32 ch, int32 index);
using GetStringFunction = const TCHAR * (*)(const FString*);
using SetStringFunction = void(*)(FString*, const TCHAR*);

struct StringInterface {
	InitStringFunction InitString;
	GetLengthFunction GetLength;
	GetStringFunction GetString;
	SetStringFunction SetString;
	GetCharFunction GetChar;
	SetCharFunction SetChar;
};

static void InitString(void* stringMemory) {
	auto str = new (stringMemory) FString();
}

static int32 GetLength(const FString* str) {
	return str->Len();
}

static const TCHAR* GetString(const FString* str) {
	return **str;
}

static void SetString(FString* str, const TCHAR* ch) {
	str->Reset();
	str->Append(ch);
}

static int32 GetChar(const FString* str, int32 index) {
	return (*str)[index];
}

static int32 SetChar(FString* str, int32 ch, int32 index) {
	if (index < str->Len())
		(*str)[index] = ch;
	else
		str->AppendChar(ch);
	return str->Len();
}

static DotNetInterface<StringInterface> StringRouter(StringName);

void PushStringInterface(class CLRHost& clrHost) {
	StringRouter.Interface.GetChar = GetChar;
	StringRouter.Interface.SetChar = SetChar;
	StringRouter.Interface.GetLength = GetLength;
	StringRouter.Interface.InitString = InitString;
	StringRouter.Interface.GetString = GetString;
	StringRouter.Interface.SetString = SetString;

	clrHost.PushName(StringName);
	clrHost.PushInteface(StringName, &StringRouter);
}