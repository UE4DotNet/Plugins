// Copyright 2018 - JCoder58

#pragma once

UENUM()
enum class EDotNetCallType {
	SetGameInstance,
	LoadGameDLL,
	CallStartFunction,
	NewGame,
	NewClass,
	BuildGame,
	PlayGame,
	DebugGame,
};