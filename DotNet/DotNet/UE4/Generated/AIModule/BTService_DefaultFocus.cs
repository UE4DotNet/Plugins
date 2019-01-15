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
    ///<summary>Default Focus service node.</summary>
    ///<remarks>A service node that automatically sets the AI controller's focus when it becomes active.</remarks>
    public unsafe partial class BTService_DefaultFocus : BTService_BlackboardBase  {
        ///<summary>not exposed to users on purpose. Here to make reusing focus-setting mechanics by derived classes possible</summary>
        public unsafe byte FocusPriority {
            get {return BTService_DefaultFocus_ptr->FocusPriority;}
            set {BTService_DefaultFocus_ptr->FocusPriority = value;}
        }
        static BTService_DefaultFocus() {
            StaticClass = Main.GetClass("BTService_DefaultFocus");
        }
        internal unsafe BTService_DefaultFocus_fields* BTService_DefaultFocus_ptr => (BTService_DefaultFocus_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTService_DefaultFocus(IntPtr p) => UObject.Make<BTService_DefaultFocus>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTService_DefaultFocus DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTService_DefaultFocus New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
