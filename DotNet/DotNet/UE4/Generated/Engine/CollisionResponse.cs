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
        ///<summary>Collision Response</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct CollisionResponse {
            ///<summary>Types of objects that this physics objects will collide with. // we have to still load them until resave</summary>
            [FieldOffset(0)] CollisionResponseContainer ResponseToChannels;

            [FieldOffset(32)] byte ResponseArray; //TODO: array TArray ResponseArray

        }
}
