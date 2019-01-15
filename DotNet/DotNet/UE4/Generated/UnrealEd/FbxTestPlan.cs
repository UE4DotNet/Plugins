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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Container for detailing collision automated test data.</summary>
    public unsafe partial class FbxTestPlan : UObject  {
         //TODO: string FString TestPlanName
        ///<summary>Tell the system what we want to do</summary>
        public unsafe byte Action {
            get {return FbxTestPlan_ptr->Action;}
            set {FbxTestPlan_ptr->Action = value;}
        }
        ///<summary>The LOD index in case the user choose to add or reimport a LOD</summary>
        public unsafe int LodIndex {
            get {return FbxTestPlan_ptr->LodIndex;}
            set {FbxTestPlan_ptr->LodIndex = value;}
        }
        public bool bDeleteFolderAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bDeleteFolderAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeleteFolderAssets", value); }
        }
         //TODO: array not UObject TArray ExpectedResult
        ///<summary>Options use for this test plan, Transient because we manually serialize the options.</summary>
        public unsafe FbxImportUI ImportUI {
            get {return FbxTestPlan_ptr->ImportUI;}
            set {FbxTestPlan_ptr->ImportUI = value;}
        }
        static FbxTestPlan() {
            StaticClass = Main.GetClass("FbxTestPlan");
        }
        internal unsafe FbxTestPlan_fields* FbxTestPlan_ptr => (FbxTestPlan_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxTestPlan(IntPtr p) => UObject.Make<FbxTestPlan>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxTestPlan DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxTestPlan New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
