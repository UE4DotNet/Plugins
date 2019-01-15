// Copyright 2019 JCoder58

#include "DotNetAxisBinding.h"


void UDotNetAxisBinding::AxisEvent(float AxisValue) {
	OnAxisEvent(AxisName, AxisValue);
}

