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


namespace UE4.CoreUObject{
        ///<summary>Thread-safe RNG.</summary>
        ///<remarks>The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\RandomStream.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct RandomStream {
            [FieldOffset(0)] public int InitialSeed;

            [FieldOffset(4)] public int Seed;

        }
}
