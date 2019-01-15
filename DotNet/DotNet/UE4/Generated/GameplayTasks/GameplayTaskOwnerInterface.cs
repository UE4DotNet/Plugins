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
using UE4.GameplayTasks.Native;

namespace UE4.GameplayTasks {
    ///<summary>Gameplay Task Owner Interface</summary>
    public unsafe partial class GameplayTaskOwnerInterface : Interface  {
        static GameplayTaskOwnerInterface() {
            StaticClass = Main.GetClass("GameplayTaskOwnerInterface");
        }
        internal unsafe GameplayTaskOwnerInterface_fields* GameplayTaskOwnerInterface_ptr => (GameplayTaskOwnerInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTaskOwnerInterface(IntPtr p) => UObject.Make<GameplayTaskOwnerInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTaskOwnerInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTaskOwnerInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
