#include "Interfaces.h"
#include "DotNetInterface.h"
#include "CLRHost.h"
#include "Containers/Array.h"

static const FName PointerArrayName("PointerArray");

using AddFunction = void(*)(void* PointerArray, void* object);
using RemoveAtFunction = void(*)(void* PointerArray, int index);
using InsertFunction = void(*)(void* PointerArray, void* object, int index);
using ReserveFunction = void(*)(void* PointerArray, int number);

struct PointerArrayInterfaceBinding {
	AddFunction Add;
	RemoveAtFunction RemoveAt;
	InsertFunction Insert;
	ReserveFunction Reserve;
};

static void Add(void* PointerArray, void* object) {
	TArray<UObject*>& objArray = *(TArray<UObject*>*)PointerArray;
	objArray.Add((UObject*)object);
}

static void Reserve(void* PointerArray,  int number) {
	TArray<UObject*>& objArray = *(TArray<UObject*>*)PointerArray;
	objArray.Reserve(number);
}

static void Insert(void* PointerArray, void* object, int index) {
	TArray<UObject*>& objArray = *(TArray<UObject*>*)PointerArray;
	objArray.Insert((UObject*)object, index);
}

static void RemoveAt(void* PointerArray, int index) {
	TArray<UObject*>& objArray = *(TArray<UObject*>*)PointerArray;
	objArray.RemoveAt(index);
}

static DotNetInterface<PointerArrayInterfaceBinding> PointerArrayRouter(PointerArrayName);

void PointerArrayInterface(class CLRHost& clrHost) {
	PointerArrayRouter.Interface.Add = Add;

	clrHost.PushInteface(PointerArrayName, &PointerArrayRouter);
}



