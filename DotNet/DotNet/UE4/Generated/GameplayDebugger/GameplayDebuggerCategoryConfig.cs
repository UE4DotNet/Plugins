// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.GameplayDebugger{
        ///<summary>Gameplay Debugger Category Config</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct GameplayDebuggerCategoryConfig {
            [FieldOffset(0)] byte CategoryName; //TODO: string FString CategoryName

            [FieldOffset(16)] public int SlotIdx;

            [FieldOffset(20)] byte ActiveInGame; //TODO: enum EGameplayDebuggerOverrideMode ActiveInGame

            [FieldOffset(21)] byte ActiveInSimulate; //TODO: enum EGameplayDebuggerOverrideMode ActiveInSimulate

            [FieldOffset(22)] byte Hidden; //TODO: enum EGameplayDebuggerOverrideMode Hidden

            [FieldOffset(24)] public bool bOverrideSlotIdx;

            [FieldOffset(32)] byte InputHandlers; //TODO: array TArray InputHandlers

        }
}
