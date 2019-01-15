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


namespace UE4.Engine{
        ///<summary>Structure for defining an external tool</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct ExternalToolDefinition {
            [FieldOffset(0)] byte ToolName; //TODO: string FString ToolName

            ///<summary>The executable to run.</summary>
            [FieldOffset(16)] FilePath ExecutablePath;

            [FieldOffset(32)] byte CommandLineOptions; //TODO: string FString CommandLineOptions

            ///<summary>The working directory for the new process.</summary>
            [FieldOffset(48)] DirectoryPath WorkingDirectory;

            [FieldOffset(64)] byte ScriptExtension; //TODO: string FString ScriptExtension

            ///<summary>If the ScriptExtension is set, look here for the script files.</summary>
            [FieldOffset(80)] DirectoryPath ScriptDirectory;

        }
}
