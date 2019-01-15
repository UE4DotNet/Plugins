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
    ///<summary>Simple Parallel composite node.</summary>
    ///<remarks>Allows for running two children: one which must be a single task node (with optional decorators), and the other of which can be a complete subtree.</remarks>
    public unsafe partial class BTComposite_SimpleParallel : BTCompositeNode  {
        ///<summary>how background tree should be handled when main task finishes execution</summary>
        public unsafe byte FinishMode {
            get {return BTComposite_SimpleParallel_ptr->FinishMode;}
            set {BTComposite_SimpleParallel_ptr->FinishMode = value;}
        }
        static BTComposite_SimpleParallel() {
            StaticClass = Main.GetClass("BTComposite_SimpleParallel");
        }
        internal unsafe BTComposite_SimpleParallel_fields* BTComposite_SimpleParallel_ptr => (BTComposite_SimpleParallel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTComposite_SimpleParallel(IntPtr p) => UObject.Make<BTComposite_SimpleParallel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTComposite_SimpleParallel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTComposite_SimpleParallel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
