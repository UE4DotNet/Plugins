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
using UE4.Landscape.Native;

namespace UE4.Landscape {
    ///<summary>Landscape Info</summary>
    public unsafe partial class LandscapeInfo : UObject  {
         //TODO: lazy object TLazyObjectPtr<ALandscape> LandscapeActor
        ///<summary>Landscape Guid</summary>
        public unsafe FGuid LandscapeGuid {
            get {return LandscapeInfo_ptr->LandscapeGuid;}
            set {LandscapeInfo_ptr->LandscapeGuid = value;}
        }
        ///<summary>Component Size Quads</summary>
        public unsafe int ComponentSizeQuads {
            get {return LandscapeInfo_ptr->ComponentSizeQuads;}
            set {LandscapeInfo_ptr->ComponentSizeQuads = value;}
        }
        ///<summary>Subsection Size Quads</summary>
        public unsafe int SubsectionSizeQuads {
            get {return LandscapeInfo_ptr->SubsectionSizeQuads;}
            set {LandscapeInfo_ptr->SubsectionSizeQuads = value;}
        }
        ///<summary>Component Num Subsections</summary>
        public unsafe int ComponentNumSubsections {
            get {return LandscapeInfo_ptr->ComponentNumSubsections;}
            set {LandscapeInfo_ptr->ComponentNumSubsections = value;}
        }
        ///<summary>Draw Scale</summary>
        public unsafe Vector DrawScale {
            get {return LandscapeInfo_ptr->DrawScale;}
            set {LandscapeInfo_ptr->DrawScale = value;}
        }
         //TODO: array not UObject TArray Layers
         //TODO: set TSet Proxies
        static LandscapeInfo() {
            StaticClass = Main.GetClass("LandscapeInfo");
        }
        internal unsafe LandscapeInfo_fields* LandscapeInfo_ptr => (LandscapeInfo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeInfo(IntPtr p) => UObject.Make<LandscapeInfo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeInfo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeInfo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
