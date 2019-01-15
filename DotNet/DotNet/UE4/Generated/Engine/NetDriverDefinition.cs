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
        ///<summary>
        ///Container for describing various types of netdrivers available to the engine
        ///The engine will try to construct a netdriver of a given type and, failing that,
        ///the fallback version.
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct NetDriverDefinition {
            [FieldOffset(0)] public Name DefName;

            [FieldOffset(12)] public Name DriverClassName;

            [FieldOffset(24)] public Name DriverClassNameFallback;

        }
}
