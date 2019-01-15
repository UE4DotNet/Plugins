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
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>A spacer widget; it does not have a visual representation, and just provides padding between other widgets.</summary>
    ///<remarks>* No Children</remarks>
    public unsafe partial class Spacer : Widget  {

        ///<summary>Sets the size of the spacer</summary>
        public void SetSize(Vector2D InSize)  => 
            Spacer_methods.SetSize_method.Invoke(ObjPointer, InSize);
        ///<summary>The size of the spacer</summary>
        public unsafe Vector2D Size {
            get {return Spacer_ptr->Size;}
        }
        static Spacer() {
            StaticClass = Main.GetClass("Spacer");
        }
        internal unsafe Spacer_fields* Spacer_ptr => (Spacer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Spacer(IntPtr p) => UObject.Make<Spacer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Spacer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Spacer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
