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
        ///<summary>Stored information about replicated static/placed actors that have been destroyed in a level.</summary>
        ///<remarks>
        ///This information is cached in ULevel so that any net drivers that are created after these actors
        ///are destroyed can access this info and correctly replicate the destruction to their clients.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct ReplicatedStaticActorDestructionInfo {
            ///<summary>Obj Class</summary>
            public SubclassOf<UObject> ObjClass {
                get {return ObjClass_class; }
                set {ObjClass_class = value; }
            }
            [FieldOffset(32)] private IntPtr ObjClass_class;

        }
}
