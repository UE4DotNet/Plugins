#include "Interfaces.h"
#include "DotNetInterface.h"
#include "DotNetGameInstance.h"
#include "DotNetAxisBinding.h"
#include "DotNetActionBinding.h"
#include "GameFramework/PlayerInput.h"

static const FName InputName("Input");

using BindAxisFunction = void(*)(UDotNetGameInstance* gameInstance, UInputComponent* Input, const FName AxisName);
using BindActionFunction = void(*)(UDotNetGameInstance* gameInstance, UInputComponent* Input, const FName ActionName, EInputEvent KeyEvent);

struct InputInteface {
	BindAxisFunction BindAxis;
	BindActionFunction BindAction;
	AxisEventFunction AxisEvent;
	ActionEventFunction ActionEvent;
};
static DotNetInterface<InputInteface> InputRouter(InputName);

static void OnAxisEvent(FName Name, float AxisValue) {
	InputRouter.Interface.AxisEvent(Name, AxisValue);
}

static void OnActionEvent(FName Name, FKey Key, EInputEvent InputEvent) {
	InputRouter.Interface.ActionEvent(Name, Key, InputEvent);
}

static void BindAxis(UDotNetGameInstance* gameInstance, UInputComponent* Input, const FName AxisName) {
	UDotNetAxisBinding* binding = NewObject<UDotNetAxisBinding>(gameInstance);
	binding->AxisName = AxisName;
	binding->Input = Input;
	binding->OnAxisEvent = OnAxisEvent;
	Input->BindAxis(AxisName, binding, &UDotNetAxisBinding::AxisEvent);
	gameInstance->AddBinding(binding);
}

static void BindAction(UDotNetGameInstance* gameInstance, UInputComponent* Input, const FName ActionName, EInputEvent InputEvent) {
	UDotNetActionBinding* binding = NewObject<UDotNetActionBinding>(gameInstance);
	binding->ActionName = ActionName;
	binding->Input = Input;
	binding->InputEvent = InputEvent;
	binding->OnActionEvent = OnActionEvent;
	Input->BindAction(ActionName, InputEvent, binding, &UDotNetActionBinding::ActionEvent);
	gameInstance->AddBinding(binding);
}


void InputInterface(class CLRHost& clrHost) {
	InputRouter.Interface.BindAxis = BindAxis;
	InputRouter.Interface.BindAction = BindAction;
	InputRouter.Interface.AxisEvent = nullptr;
	InputRouter.Interface.ActionEvent = nullptr;

	clrHost.PushInteface(InputName, &InputRouter);
}

