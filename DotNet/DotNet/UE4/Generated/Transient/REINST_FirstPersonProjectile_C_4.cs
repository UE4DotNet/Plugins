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
using UE4.Transient.Native;
using UE4.DotNetTest;
using UE4.Engine;

namespace UE4.Transient {
    ///<summary>REINST First Person Projectile C 4</summary>
    public unsafe partial class REINST_FirstPersonProjectile_C_4 : DotNetTestProjectile  {

        ///<summary>User Construction Script</summary>
        public event UserConstructionScript_delegate UserConstructionScript;
        public delegate void UserConstructionScript_delegate();
        internal void on_UserConstructionScript() =>
            UserConstructionScript?.Invoke();

        ///<summary>Static Mesh 1</summary>
        public unsafe StaticMeshComponent StaticMesh1 {
            get {return REINST_FirstPersonProjectile_C_4_ptr->StaticMesh1;}
            set {REINST_FirstPersonProjectile_C_4_ptr->StaticMesh1 = value;}
        }
        static REINST_FirstPersonProjectile_C_4() {
            StaticClass = Main.GetClass("REINST_FirstPersonProjectile_C_4");
            REINST_FirstPersonProjectile_C_4_events.UserConstructionScript_event.Setup();
        }
        internal unsafe REINST_FirstPersonProjectile_C_4_fields* REINST_FirstPersonProjectile_C_4_ptr => (REINST_FirstPersonProjectile_C_4_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator REINST_FirstPersonProjectile_C_4(IntPtr p) => UObject.Make<REINST_FirstPersonProjectile_C_4>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static REINST_FirstPersonProjectile_C_4 DefaultObject => Main.GetDefaultObject(StaticClass);
    }
}
