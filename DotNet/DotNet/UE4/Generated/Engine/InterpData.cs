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
    ///<summary>Interpolation data, containing keyframe tracks, event tracks etc.</summary>
    ///<remarks>
    ///This does not contain any  AActor  references or state, so can safely be stored in
    ///packages, shared between multiple MatineeActors etc.
    ///</remarks>
    public unsafe partial class InterpData : UObject  {
        ///<summary>Duration of interpolation sequence - in seconds.</summary>
        public unsafe float InterpLength {
            get {return InterpData_ptr->InterpLength;}
        }
        ///<summary>Position in Interp to move things to for path-building in editor.</summary>
        public unsafe float PathBuildTime {
            get {return InterpData_ptr->PathBuildTime;}
            set {InterpData_ptr->PathBuildTime = value;}
        }
        ///<summary>Actual interpolation data. Groups of InterpTracks.</summary>
        public ObjectArrayField<InterpGroup> InterpGroups{ get {
            if(InterpGroups_store == null) InterpGroups_store = new ObjectArrayField<InterpGroup> (&InterpData_ptr->InterpGroups);
            return InterpGroups_store;
        } }
        private ObjectArrayField<InterpGroup> InterpGroups_store;

        ///<summary>Used for curve editor to remember curve-editing setup. Only loaded in editor.</summary>
        public unsafe InterpCurveEdSetup CurveEdSetup {
            get {return InterpData_ptr->CurveEdSetup;}
            set {InterpData_ptr->CurveEdSetup = value;}
        }
        ///<summary>Used for filtering which tracks are currently visible.</summary>
        public ObjectArrayField<InterpFilter> InterpFilters{ get {
            if(InterpFilters_store == null) InterpFilters_store = new ObjectArrayField<InterpFilter> (&InterpData_ptr->InterpFilters);
            return InterpFilters_store;
        } }
        private ObjectArrayField<InterpFilter> InterpFilters_store;

        ///<summary>The currently selected filter.</summary>
        public unsafe InterpFilter SelectedFilter {
            get {return InterpData_ptr->SelectedFilter;}
            set {InterpData_ptr->SelectedFilter = value;}
        }
        ///<summary>Array of default filters.</summary>
        public ObjectArrayField<InterpFilter> DefaultFilters{ get {
            if(DefaultFilters_store == null) DefaultFilters_store = new ObjectArrayField<InterpFilter> (&InterpData_ptr->DefaultFilters);
            return DefaultFilters_store;
        } }
        private ObjectArrayField<InterpFilter> DefaultFilters_store;

        ///<summary>Used in editor for defining sections to loop, stretch etc.</summary>
        public unsafe float EdSectionStart {
            get {return InterpData_ptr->EdSectionStart;}
            set {InterpData_ptr->EdSectionStart = value;}
        }
        ///<summary>Used in editor for defining sections to loop, stretch etc.</summary>
        public unsafe float EdSectionEnd {
            get {return InterpData_ptr->EdSectionEnd;}
            set {InterpData_ptr->EdSectionEnd = value;}
        }
        public bool bShouldBakeAndPrune {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBakeAndPrune"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBakeAndPrune", value); }
        }
        ///<summary>Cached version of the director group, if any, for easy access while in game</summary>
        public unsafe InterpGroupDirector CachedDirectorGroup {
            get {return InterpData_ptr->CachedDirectorGroup;}
            set {InterpData_ptr->CachedDirectorGroup = value;}
        }
         //TODO: array not UObject TArray AllEventNames
        static InterpData() {
            StaticClass = Main.GetClass("InterpData");
        }
        internal unsafe InterpData_fields* InterpData_ptr => (InterpData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpData(IntPtr p) => UObject.Make<InterpData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
