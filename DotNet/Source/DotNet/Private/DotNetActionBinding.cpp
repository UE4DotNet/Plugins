// Copyright 2019 JCoder58

#include "DotNetActionBinding.h"



void UDotNetActionBinding::ActionEvent(FKey Key) {
	OnActionEvent(ActionName, Key, InputEvent);
}


