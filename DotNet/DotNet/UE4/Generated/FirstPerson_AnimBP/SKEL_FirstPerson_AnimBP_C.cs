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
using UE4.FirstPerson_AnimBP.Native;
using UE4.Engine;

namespace UE4.FirstPerson_AnimBP {
    ///<summary>First Person Anim BP</summary>
    public unsafe partial class SKEL_FirstPerson_AnimBP_C : AnimInstance  {

        ///<summary>Executed when the Animation is updated</summary>
        public event BlueprintUpdateAnimation_delegate BlueprintUpdateAnimation;
        public delegate void BlueprintUpdateAnimation_delegate(float DeltaTimeX);
        internal void on_BlueprintUpdateAnimation(float DeltaTimeX) =>
            BlueprintUpdateAnimation?.Invoke(DeltaTimeX);

         //TODO: struct FPointerToUberGraphFrame UberGraphFrame
        ///<summary>Is Moving</summary>
        public unsafe bool IsMoving {
            get {return SKEL_FirstPerson_AnimBP_C_ptr->IsMoving;}
            set {SKEL_FirstPerson_AnimBP_C_ptr->IsMoving = value;}
        }
        ///<summary>Is in Air</summary>
        public unsafe bool bIsInAir {
            get {return SKEL_FirstPerson_AnimBP_C_ptr->bIsInAir;}
            set {SKEL_FirstPerson_AnimBP_C_ptr->bIsInAir = value;}
        }
        static SKEL_FirstPerson_AnimBP_C() {
            StaticClass = Main.GetClass("SKEL_FirstPerson_AnimBP_C");
            SKEL_FirstPerson_AnimBP_C_events.BlueprintUpdateAnimation_event.Setup();
        }
        internal unsafe SKEL_FirstPerson_AnimBP_C_fields* SKEL_FirstPerson_AnimBP_C_ptr => (SKEL_FirstPerson_AnimBP_C_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SKEL_FirstPerson_AnimBP_C(IntPtr p) => UObject.Make<SKEL_FirstPerson_AnimBP_C>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SKEL_FirstPerson_AnimBP_C DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
