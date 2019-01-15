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
        ///<summary>Settings pertaining to which PhysX broadphase to use, and settings for MBP if that is the chosen broadphase type</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct BroadphaseSettings {
            [FieldOffset(0)] public bool bUseMBPOnClient;

            [FieldOffset(1)] public bool bUseMBPOnServer;

            ///<summary>Total bounds for MBP, must cover the game world or collisions are disabled for out of bounds actors</summary>
            [FieldOffset(4)] Box MBPBounds;

            [FieldOffset(32)] byte MBPNumSubdivs; //TODO: numeric uint32 MBPNumSubdivs

        }
}
