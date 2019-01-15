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
    ///<summary>SplineMeshActor is an actor with a SplineMeshComponent.</summary>
    ///<remarks>
    ///@see USplineMeshComponent
    ///</remarks>
    public unsafe partial class SplineMeshActor : Actor  {
        ///<summary>Spline Mesh Component</summary>
        public unsafe SplineMeshComponent SplineMeshComponent {
            get {return SplineMeshActor_ptr->SplineMeshComponent;}
        }
        static SplineMeshActor() {
            StaticClass = Main.GetClass("SplineMeshActor");
        }
        internal unsafe SplineMeshActor_fields* SplineMeshActor_ptr => (SplineMeshActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplineMeshActor(IntPtr p) => UObject.Make<SplineMeshActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplineMeshActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplineMeshActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
