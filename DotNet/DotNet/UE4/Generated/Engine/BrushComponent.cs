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
    ///<summary>A brush component defines a shape that can be modified within the editor.</summary>
    ///<remarks>
    ///They are used both as part of BSP building, and for volumes.
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Actors/Volumes
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Actors/Brushes
    ///</remarks>
    public unsafe partial class BrushComponent : PrimitiveComponent  {
        ///<summary>Brush</summary>
        public unsafe Model Brush {
            get {return BrushComponent_ptr->Brush;}
            set {BrushComponent_ptr->Brush = value;}
        }
        ///<summary>Description of collision</summary>
        public unsafe BodySetup BrushBodySetup {
            get {return BrushComponent_ptr->BrushBodySetup;}
            set {BrushComponent_ptr->BrushBodySetup = value;}
        }
        static BrushComponent() {
            StaticClass = Main.GetClass("BrushComponent");
        }
        internal unsafe BrushComponent_fields* BrushComponent_ptr => (BrushComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BrushComponent(IntPtr p) => UObject.Make<BrushComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BrushComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BrushComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
