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
using UE4.FirstPersonProjectile.Native;
using UE4.DotNetTest;
using UE4.Engine;

namespace UE4.FirstPersonProjectile {
    ///<summary>Projectile BP that adds a graphics mesh</summary>
    public unsafe partial class SKEL_FirstPersonProjectile_C : DotNetTestProjectile  {

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
        ///<summary>Static Mesh 1</summary>
        public unsafe StaticMeshComponent StaticMesh1 {
            get {return SKEL_FirstPersonProjectile_C_ptr->StaticMesh1;}
            set {SKEL_FirstPersonProjectile_C_ptr->StaticMesh1 = value;}
        }
        static SKEL_FirstPersonProjectile_C() {
            StaticClass = Main.GetClass("SKEL_FirstPersonProjectile_C");
            SKEL_FirstPersonProjectile_C_events.UserConstructionScript_event.Setup();
        }
        internal unsafe SKEL_FirstPersonProjectile_C_fields* SKEL_FirstPersonProjectile_C_ptr => (SKEL_FirstPersonProjectile_C_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SKEL_FirstPersonProjectile_C(IntPtr p) => UObject.Make<SKEL_FirstPersonProjectile_C>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SKEL_FirstPersonProjectile_C DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
