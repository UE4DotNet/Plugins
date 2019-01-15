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
using UE4.FirstPersonCharacter.Native;
using UE4.DotNetTest;

namespace UE4.FirstPersonCharacter {
    ///<summary>Character Blueprint that configures the arm mesh and projectile </summary>
    public unsafe partial class SKEL_FirstPersonCharacter_C : DotNetTestCharacter  {

        ///<summary>Construction script, the place to spawn components and do other setup.</summary>
        ///<remarks>
        ///@note Name used in CreateBlueprint function
        ///@param       Location        The location.
        ///@param       Rotation        The rotation.
        ///</remarks>
        public event UserConstructionScript_delegate UserConstructionScript;
        public delegate void UserConstructionScript_delegate();
        internal void on_UserConstructionScript() =>
            UserConstructionScript?.Invoke();

         //TODO: struct FPointerToUberGraphFrame UberGraphFrame
        static SKEL_FirstPersonCharacter_C() {
            StaticClass = Main.GetClass("SKEL_FirstPersonCharacter_C");
            SKEL_FirstPersonCharacter_C_events.UserConstructionScript_event.Setup();
        }
        internal unsafe SKEL_FirstPersonCharacter_C_fields* SKEL_FirstPersonCharacter_C_ptr => (SKEL_FirstPersonCharacter_C_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SKEL_FirstPersonCharacter_C(IntPtr p) => UObject.Make<SKEL_FirstPersonCharacter_C>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SKEL_FirstPersonCharacter_C DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
