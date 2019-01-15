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
        ///<summary>Transform composed of Quat/Translation/Scale.</summary>
        ///<remarks>The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Transform.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct Transform {
            ///<summary>Rotation</summary>
            [FieldOffset(0)] Quat Rotation;

            ///<summary>Translation</summary>
            [FieldOffset(16)] Vector Translation;

            ///<summary>Scale 3D</summary>
            [FieldOffset(32)] Vector Scale3D;

        }
}
