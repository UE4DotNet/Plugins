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
    ///<summary>Actor that provides a directional wind source. Only affects SpeedTree assets.</summary>
    public unsafe partial class WindDirectionalSource : Info  {
        ///<summary>Component</summary>
        public unsafe WindDirectionalSourceComponent Component {
            get {return WindDirectionalSource_ptr->Component;}
        }
        ///<summary>Arrow Component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return WindDirectionalSource_ptr->ArrowComponent;}
            set {WindDirectionalSource_ptr->ArrowComponent = value;}
        }
        static WindDirectionalSource() {
            StaticClass = Main.GetClass("WindDirectionalSource");
        }
        internal unsafe WindDirectionalSource_fields* WindDirectionalSource_ptr => (WindDirectionalSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WindDirectionalSource(IntPtr p) => UObject.Make<WindDirectionalSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WindDirectionalSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WindDirectionalSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
