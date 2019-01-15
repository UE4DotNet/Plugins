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
        ///<summary>Base struct for items using Fast TArray Replication</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct FastArraySerializerItem {
            [FieldOffset(0)] public int ReplicationID;

            [FieldOffset(4)] public int ReplicationKey;

            [FieldOffset(8)] public int MostRecentArrayReplicationKey;

        }
}
