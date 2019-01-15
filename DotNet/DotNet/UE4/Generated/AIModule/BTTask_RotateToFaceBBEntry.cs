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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>BTTask Rotate to Face BBEntry</summary>
    public unsafe partial class BTTask_RotateToFaceBBEntry : BTTask_BlackboardBase  {
        ///<summary>Success condition precision in degrees</summary>
        public unsafe float Precision {
            get {return BTTask_RotateToFaceBBEntry_ptr->Precision;}
            set {BTTask_RotateToFaceBBEntry_ptr->Precision = value;}
        }
        static BTTask_RotateToFaceBBEntry() {
            StaticClass = Main.GetClass("BTTask_RotateToFaceBBEntry");
        }
        internal unsafe BTTask_RotateToFaceBBEntry_fields* BTTask_RotateToFaceBBEntry_ptr => (BTTask_RotateToFaceBBEntry_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_RotateToFaceBBEntry(IntPtr p) => UObject.Make<BTTask_RotateToFaceBBEntry>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_RotateToFaceBBEntry DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_RotateToFaceBBEntry New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
