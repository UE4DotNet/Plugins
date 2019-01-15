#pragma once

#include "NameTypes.h"

struct DotNetInterfaceBase {};

template <typename Struct>
struct DotNetInterface : public DotNetInterfaceBase {
	const uint32 StartGuardian;
	const uint32 SizeOfShared;
	const int FNameID;

	Struct Interface;

	const uint32 EndGuardian;

	DotNetInterface(FName name)
		: StartGuardian(0x12345678),
		EndGuardian(0x87654321),
		FNameID(name.GetComparisonIndex()),
		SizeOfShared(sizeof(DotNetInterface<Struct>))
	{}
};