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


namespace UE4.UnrealEd{
        ///<summary>Options that should be unique per asset editor (like skeletal mesh or anim sequence editors)</summary>
        [StructLayout( LayoutKind.Explicit, Size=108 )]
        public unsafe struct AssetEditorOptions {
            [FieldOffset(0)] public Name Context;

            ///<summary>Per-viewport configuration</summary>
            [FieldOffset(12)] ViewportConfigOptions ViewportConfigs;

        }
}
