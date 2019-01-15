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
    ///<summary>Wait task node.</summary>
    ///<remarks>Wait for the specified time when executed.</remarks>
    public unsafe partial class BTTask_Wait : BTTaskNode  {
        ///<summary>wait time in seconds</summary>
        public unsafe float WaitTime {
            get {return BTTask_Wait_ptr->WaitTime;}
            set {BTTask_Wait_ptr->WaitTime = value;}
        }
        ///<summary>allows adding random time to wait time</summary>
        public unsafe float RandomDeviation {
            get {return BTTask_Wait_ptr->RandomDeviation;}
            set {BTTask_Wait_ptr->RandomDeviation = value;}
        }
        static BTTask_Wait() {
            StaticClass = Main.GetClass("BTTask_Wait");
        }
        internal unsafe BTTask_Wait_fields* BTTask_Wait_ptr => (BTTask_Wait_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_Wait(IntPtr p) => UObject.Make<BTTask_Wait>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_Wait DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_Wait New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
