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
    ///<summary>Interp Track Vector Material Param</summary>
    public unsafe partial class InterpTrackVectorMaterialParam : InterpTrackVectorBase  {
        ///<summary>Materials whose parameters we want to change and the references to those materials.</summary>
        public ObjectArrayField<MaterialInterface> TargetMaterials{ get {
            if(TargetMaterials_store == null) TargetMaterials_store = new ObjectArrayField<MaterialInterface> (&InterpTrackVectorMaterialParam_ptr->TargetMaterials);
            return TargetMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> TargetMaterials_store;

        ///<summary>Name of parameter in the MaterialInstance which this track will modify over time.</summary>
        public unsafe Name ParamName {
            get {return InterpTrackVectorMaterialParam_ptr->ParamName;}
            set {InterpTrackVectorMaterialParam_ptr->ParamName = value;}
        }
        static InterpTrackVectorMaterialParam() {
            StaticClass = Main.GetClass("InterpTrackVectorMaterialParam");
        }
        internal unsafe InterpTrackVectorMaterialParam_fields* InterpTrackVectorMaterialParam_ptr => (InterpTrackVectorMaterialParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackVectorMaterialParam(IntPtr p) => UObject.Make<InterpTrackVectorMaterialParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackVectorMaterialParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackVectorMaterialParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
