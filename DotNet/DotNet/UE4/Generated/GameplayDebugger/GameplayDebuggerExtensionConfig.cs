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
        ///<summary>Gameplay Debugger Extension Config</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct GameplayDebuggerExtensionConfig {
            [FieldOffset(0)] byte ExtensionName; //TODO: string FString ExtensionName

            [FieldOffset(16)] byte UseExtension; //TODO: enum EGameplayDebuggerOverrideMode UseExtension

            [FieldOffset(24)] byte InputHandlers; //TODO: array TArray InputHandlers

        }
}
