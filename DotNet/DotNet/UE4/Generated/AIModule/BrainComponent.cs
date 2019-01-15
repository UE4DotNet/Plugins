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
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>Brain Component</summary>
    public unsafe partial class BrainComponent : ActorComponent  {

        ///<summary>Is Paused</summary>
        public bool IsPaused()  => 
            BrainComponent_methods.IsPaused_method.Invoke(ObjPointer);

        ///<summary>Is Running</summary>
        public bool IsRunning()  => 
            BrainComponent_methods.IsRunning_method.Invoke(ObjPointer);

        ///<summary>Restart Logic</summary>
        public void RestartLogic()  => 
            BrainComponent_methods.RestartLogic_method.Invoke(ObjPointer);

        ///<summary>Stop Logic</summary>
        public void StopLogic(string Reason)  => 
            BrainComponent_methods.StopLogic_method.Invoke(ObjPointer, Reason);
        ///<summary>blackboard component</summary>
        public unsafe BlackboardComponent BlackboardComp {
            get {return BrainComponent_ptr->BlackboardComp;}
            set {BrainComponent_ptr->BlackboardComp = value;}
        }
        ///<summary>AIOwner</summary>
        public unsafe AIController AIOwner {
            get {return BrainComponent_ptr->AIOwner;}
            set {BrainComponent_ptr->AIOwner = value;}
        }
        static BrainComponent() {
            StaticClass = Main.GetClass("BrainComponent");
        }
        internal unsafe BrainComponent_fields* BrainComponent_ptr => (BrainComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BrainComponent(IntPtr p) => UObject.Make<BrainComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BrainComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BrainComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
