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
    ///<summary>Interp Filter Classes</summary>
    public unsafe partial class InterpFilter_Classes : InterpFilter  {
        ///<summary>Which class to filter groups by.</summary>
        public unsafe SubclassOf<UObject> ClassToFilterBy {
            get {return InterpFilter_Classes_ptr->ClassToFilterBy;}
            set {InterpFilter_Classes_ptr->ClassToFilterBy = value;}
        }
        ///<summary>List of allowed track classes.</summary>
        ///<remarks>
        ///If empty, then all track classes will be included.  Only groups that
        ///              contain at least one of these types of tracks will be displayed.
        ///</remarks>
        public ObjectArrayField<Class> TrackClasses{ get {
            if(TrackClasses_store == null) TrackClasses_store = new ObjectArrayField<Class> (&InterpFilter_Classes_ptr->TrackClasses);
            return TrackClasses_store;
        } }
        private ObjectArrayField<Class> TrackClasses_store;

        static InterpFilter_Classes() {
            StaticClass = Main.GetClass("InterpFilter_Classes");
        }
        internal unsafe InterpFilter_Classes_fields* InterpFilter_Classes_ptr => (InterpFilter_Classes_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpFilter_Classes(IntPtr p) => UObject.Make<InterpFilter_Classes>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpFilter_Classes DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpFilter_Classes New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
