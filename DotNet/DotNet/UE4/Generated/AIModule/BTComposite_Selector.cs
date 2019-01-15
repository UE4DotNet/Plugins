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
    ///<summary>Selector composite node.</summary>
    ///<remarks>
    ///Selector Nodes execute their children from left to right, and will stop executing its children when one of their children succeeds.
    ///If a Selector's child succeeds, the Selector succeeds. If all the Selector's children fail, the Selector fails.
    ///</remarks>
    public unsafe partial class BTComposite_Selector : BTCompositeNode  {
        static BTComposite_Selector() {
            StaticClass = Main.GetClass("BTComposite_Selector");
        }
        internal unsafe BTComposite_Selector_fields* BTComposite_Selector_ptr => (BTComposite_Selector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTComposite_Selector(IntPtr p) => UObject.Make<BTComposite_Selector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTComposite_Selector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTComposite_Selector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
