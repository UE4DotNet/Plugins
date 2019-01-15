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
using UE4.DatasmithContent.Native;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Area Light Actor Template</summary>
    public unsafe partial class DatasmithAreaLightActorTemplate : DatasmithObjectTemplate  {
         //TODO: enum EDatasmithAreaLightActorShape LightShape
        ///<summary>Dimensions</summary>
        public unsafe Vector2D Dimensions {
            get {return DatasmithAreaLightActorTemplate_ptr->Dimensions;}
            set {DatasmithAreaLightActorTemplate_ptr->Dimensions = value;}
        }
        ///<summary>Color</summary>
        public unsafe LinearColor Color {
            get {return DatasmithAreaLightActorTemplate_ptr->Color;}
            set {DatasmithAreaLightActorTemplate_ptr->Color = value;}
        }
        ///<summary>Intensity</summary>
        public unsafe float Intensity {
            get {return DatasmithAreaLightActorTemplate_ptr->Intensity;}
            set {DatasmithAreaLightActorTemplate_ptr->Intensity = value;}
        }
        public bool bHidden {
            get {return Main.GetGetBoolPropertyByName(this, "bHidden"); }
            set {Main.SetGetBoolPropertyByName(this, "bHidden", value); }
        }
        static DatasmithAreaLightActorTemplate() {
            StaticClass = Main.GetClass("DatasmithAreaLightActorTemplate");
        }
        internal unsafe DatasmithAreaLightActorTemplate_fields* DatasmithAreaLightActorTemplate_ptr => (DatasmithAreaLightActorTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithAreaLightActorTemplate(IntPtr p) => UObject.Make<DatasmithAreaLightActorTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithAreaLightActorTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithAreaLightActorTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
