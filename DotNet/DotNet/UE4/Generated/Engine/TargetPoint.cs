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
    ///<summary>Target Point</summary>
    public unsafe partial class TargetPoint : Actor  {
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return TargetPoint_ptr->SpriteComponent;}
        }
        ///<summary>Arrow Component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return TargetPoint_ptr->ArrowComponent;}
            set {TargetPoint_ptr->ArrowComponent = value;}
        }
        static TargetPoint() {
            StaticClass = Main.GetClass("TargetPoint");
        }
        internal unsafe TargetPoint_fields* TargetPoint_ptr => (TargetPoint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TargetPoint(IntPtr p) => UObject.Make<TargetPoint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TargetPoint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TargetPoint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
