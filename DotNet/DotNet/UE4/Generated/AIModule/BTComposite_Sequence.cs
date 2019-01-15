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
    ///<summary>Sequence composite node.</summary>
    ///<remarks>
    ///Sequence Nodes execute their children from left to right, and will stop executing its children when one of their children fails.
    ///If a child fails, then the Sequence fails. If all the Sequence's children succeed, then the Sequence succeeds.
    ///</remarks>
    public unsafe partial class BTComposite_Sequence : BTCompositeNode  {
        static BTComposite_Sequence() {
            StaticClass = Main.GetClass("BTComposite_Sequence");
        }
        internal unsafe BTComposite_Sequence_fields* BTComposite_Sequence_ptr => (BTComposite_Sequence_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTComposite_Sequence(IntPtr p) => UObject.Make<BTComposite_Sequence>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTComposite_Sequence DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTComposite_Sequence New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
