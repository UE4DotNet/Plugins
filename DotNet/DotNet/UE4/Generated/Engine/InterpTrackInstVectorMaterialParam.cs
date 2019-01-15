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
    ///<summary>Interp Track Inst Vector Material Param</summary>
    public unsafe partial class InterpTrackInstVectorMaterialParam : InterpTrackInst  {
        ///<summary>MIDs we're using to set the desired parameter.</summary>
        public ObjectArrayField<MaterialInstanceDynamic> MaterialInstances{ get {
            if(MaterialInstances_store == null) MaterialInstances_store = new ObjectArrayField<MaterialInstanceDynamic> (&InterpTrackInstVectorMaterialParam_ptr->MaterialInstances);
            return MaterialInstances_store;
        } }
        private ObjectArrayField<MaterialInstanceDynamic> MaterialInstances_store;

         //TODO: array not UObject TArray ResetVectors
         //TODO: array not UObject TArray PrimitiveMaterialRefs
        ///<summary>Track we are an instance of - used in the editor to propagate changes to the track's Materials array immediately.</summary>
        public unsafe InterpTrackVectorMaterialParam InstancedTrack {
            get {return InterpTrackInstVectorMaterialParam_ptr->InstancedTrack;}
            set {InterpTrackInstVectorMaterialParam_ptr->InstancedTrack = value;}
        }
        static InterpTrackInstVectorMaterialParam() {
            StaticClass = Main.GetClass("InterpTrackInstVectorMaterialParam");
        }
        internal unsafe InterpTrackInstVectorMaterialParam_fields* InterpTrackInstVectorMaterialParam_ptr => (InterpTrackInstVectorMaterialParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstVectorMaterialParam(IntPtr p) => UObject.Make<InterpTrackInstVectorMaterialParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstVectorMaterialParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstVectorMaterialParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
