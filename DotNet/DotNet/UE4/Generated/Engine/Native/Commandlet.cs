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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct Commandlet_fields {
        [FieldOffset(56)] byte HelpDescription; //TODO: string FString HelpDescription
        [FieldOffset(72)] byte HelpUsage; //TODO: string FString HelpUsage
        [FieldOffset(88)] byte HelpWebLink; //TODO: string FString HelpWebLink
        [FieldOffset(104)] public NativeArray HelpParamNames;
        [FieldOffset(120)] public NativeArray HelpParamDescriptions;
        [FieldOffset(136)] public bool IsServer;
        [FieldOffset(136)] public bool IsClient;
        [FieldOffset(136)] public bool IsEditor;
        [FieldOffset(136)] public bool LogToConsole;
        [FieldOffset(136)] public bool ShowErrorCount;
        [FieldOffset(136)] public bool ShowProgress;
    }
    internal unsafe struct Commandlet_methods {
    }
    internal unsafe struct Commandlet_events {
    }
}
