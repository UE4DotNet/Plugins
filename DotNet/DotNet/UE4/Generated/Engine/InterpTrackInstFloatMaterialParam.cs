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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Interp Track Inst Float Material Param</summary>
    public unsafe partial class InterpTrackInstFloatMaterialParam : InterpTrackInst  {
        ///<summary>MIDs we're using to set the desired parameter.</summary>
        public ObjectArrayField<MaterialInstanceDynamic> MaterialInstances{ get {
            if(MaterialInstances_store == null) MaterialInstances_store = new ObjectArrayField<MaterialInstanceDynamic> (&InterpTrackInstFloatMaterialParam_ptr->MaterialInstances);
            return MaterialInstances_store;
        } }
        private ObjectArrayField<MaterialInstanceDynamic> MaterialInstances_store;

         //TODO: array not UObject TArray ResetFloats
         //TODO: array not UObject TArray PrimitiveMaterialRefs
        ///<summary>track we are an instance of - used in the editor to propagate changes to the track's Materials array immediately</summary>
        public unsafe InterpTrackFloatMaterialParam InstancedTrack {
            get {return InterpTrackInstFloatMaterialParam_ptr->InstancedTrack;}
            set {InterpTrackInstFloatMaterialParam_ptr->InstancedTrack = value;}
        }
        static InterpTrackInstFloatMaterialParam() {
            StaticClass = Main.GetClass("InterpTrackInstFloatMaterialParam");
        }
        internal unsafe InterpTrackInstFloatMaterialParam_fields* InterpTrackInstFloatMaterialParam_ptr => (InterpTrackInstFloatMaterialParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstFloatMaterialParam(IntPtr p) => UObject.Make<InterpTrackInstFloatMaterialParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstFloatMaterialParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstFloatMaterialParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
