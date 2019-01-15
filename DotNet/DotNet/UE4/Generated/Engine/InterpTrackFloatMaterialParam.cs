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
    ///<summary>Interp Track Float Material Param</summary>
    public unsafe partial class InterpTrackFloatMaterialParam : InterpTrackFloatBase  {
        ///<summary>Materials whose parameters we want to change and the references to those materials.</summary>
        public ObjectArrayField<MaterialInterface> TargetMaterials{ get {
            if(TargetMaterials_store == null) TargetMaterials_store = new ObjectArrayField<MaterialInterface> (&InterpTrackFloatMaterialParam_ptr->TargetMaterials);
            return TargetMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> TargetMaterials_store;

        ///<summary>Name of parameter in the MaterialInstance which this track will modify over time.</summary>
        public unsafe Name ParamName {
            get {return InterpTrackFloatMaterialParam_ptr->ParamName;}
            set {InterpTrackFloatMaterialParam_ptr->ParamName = value;}
        }
        static InterpTrackFloatMaterialParam() {
            StaticClass = Main.GetClass("InterpTrackFloatMaterialParam");
        }
        internal unsafe InterpTrackFloatMaterialParam_fields* InterpTrackFloatMaterialParam_ptr => (InterpTrackFloatMaterialParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackFloatMaterialParam(IntPtr p) => UObject.Make<InterpTrackFloatMaterialParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackFloatMaterialParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackFloatMaterialParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
