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
    ///<summary>An actor used to generate collision events (begin/end overlap) in the level.</summary>
    public unsafe partial class TriggerBase : Actor  {
        ///<summary>Shape component used for collision</summary>
        public unsafe ShapeComponent CollisionComponent {
            get {return TriggerBase_ptr->CollisionComponent;}
        }
        ///<summary>Billboard used to see the trigger in the editor</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return TriggerBase_ptr->SpriteComponent;}
            set {TriggerBase_ptr->SpriteComponent = value;}
        }
        static TriggerBase() {
            StaticClass = Main.GetClass("TriggerBase");
        }
        internal unsafe TriggerBase_fields* TriggerBase_ptr => (TriggerBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TriggerBase(IntPtr p) => UObject.Make<TriggerBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TriggerBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TriggerBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
