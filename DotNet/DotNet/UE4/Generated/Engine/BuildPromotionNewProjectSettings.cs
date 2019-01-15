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
        ///<summary>Holds settings for the new project stage of the build promotion test</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct BuildPromotionNewProjectSettings {
            ///<summary>The path for the new project</summary>
            [FieldOffset(0)] DirectoryPath NewProjectFolderOverride;

            [FieldOffset(16)] byte NewProjectNameOverride; //TODO: string FString NewProjectNameOverride

        }
}
