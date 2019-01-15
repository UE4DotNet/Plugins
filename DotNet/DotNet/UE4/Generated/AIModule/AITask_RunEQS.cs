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
    ///<summary>AITask Run EQS</summary>
    public unsafe partial class AITask_RunEQS : AITask  {

        ///<summary>Run EQS</summary>
        public static AITask_RunEQS RunEQS(AIController Controller, EnvQuery QueryTemplate)  => 
            AITask_RunEQS_methods.RunEQS_method.Invoke(Controller, QueryTemplate);
        static AITask_RunEQS() {
            StaticClass = Main.GetClass("AITask_RunEQS");
        }
        internal unsafe AITask_RunEQS_fields* AITask_RunEQS_ptr => (AITask_RunEQS_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AITask_RunEQS(IntPtr p) => UObject.Make<AITask_RunEQS>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AITask_RunEQS DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AITask_RunEQS New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
