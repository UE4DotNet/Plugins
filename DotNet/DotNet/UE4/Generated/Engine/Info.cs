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
    ///Info is the base class of an Actor that isn't meant to have a physical representation in the world, used primarily
    ///for "manager" type classes that hold settings data about the world, but might need to be an Actor for replication purposes.
    ///</summary>
    public unsafe partial class Info : Actor  {
        ///<summary>Billboard Component displayed in editor</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return Info_ptr->SpriteComponent;}
            set {Info_ptr->SpriteComponent = value;}
        }
        static Info() {
            StaticClass = Main.GetClass("Info");
        }
        internal unsafe Info_fields* Info_ptr => (Info_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Info(IntPtr p) => UObject.Make<Info>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Info DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Info New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
