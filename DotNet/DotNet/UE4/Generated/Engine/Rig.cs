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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>
    ///URig : that has rigging data for skeleton
    ///        - used for retargeting
    ///</summary>
    ///<remarks>- support to share different animations</remarks>
    public unsafe partial class Rig : UObject  {
         //TODO: array not UObject TArray TransformBases
         //TODO: array not UObject TArray Nodes
        static Rig() {
            StaticClass = Main.GetClass("Rig");
        }
        internal unsafe Rig_fields* Rig_ptr => (Rig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Rig(IntPtr p) => UObject.Make<Rig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Rig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Rig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
