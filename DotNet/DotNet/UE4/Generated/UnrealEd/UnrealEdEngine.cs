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
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Unreal Ed Engine</summary>
    public unsafe partial class UnrealEdEngine : EditorEngine  {
        ///<summary>Global instance of the editor options class.</summary>
        public unsafe UnrealEdOptions EditorOptionsInst {
            get {return UnrealEdEngine_ptr->EditorOptionsInst;}
            set {UnrealEdEngine_ptr->EditorOptionsInst = value;}
        }
        ///<summary>Manager responsible for configuring auto reimport</summary>
        public unsafe AutoReimportManager AutoReimportManager {
            get {return UnrealEdEngine_ptr->AutoReimportManager;}
            set {UnrealEdEngine_ptr->AutoReimportManager = value;}
        }
        ///<summary>A buffer for implementing material expression copy/paste.</summary>
        public unsafe Material MaterialCopyPasteBuffer {
            get {return UnrealEdEngine_ptr->MaterialCopyPasteBuffer;}
            set {UnrealEdEngine_ptr->MaterialCopyPasteBuffer = value;}
        }
        ///<summary>A buffer for implementing matinee track/group copy/paste.</summary>
        public ObjectArrayField<UObject> MatineeCopyPasteBuffer{ get {
            if(MatineeCopyPasteBuffer_store == null) MatineeCopyPasteBuffer_store = new ObjectArrayField<UObject> (&UnrealEdEngine_ptr->MatineeCopyPasteBuffer);
            return MatineeCopyPasteBuffer_store;
        } }
        private ObjectArrayField<UObject> MatineeCopyPasteBuffer_store;

        ///<summary>A buffer for implementing sound cue nodes copy/paste.</summary>
        public unsafe SoundCue SoundCueCopyPasteBuffer {
            get {return UnrealEdEngine_ptr->SoundCueCopyPasteBuffer;}
            set {UnrealEdEngine_ptr->SoundCueCopyPasteBuffer = value;}
        }
        ///<summary>Global list of instanced animation compression algorithms.</summary>
        public ObjectArrayField<AnimCompress> AnimationCompressionAlgorithms{ get {
            if(AnimationCompressionAlgorithms_store == null) AnimationCompressionAlgorithms_store = new ObjectArrayField<AnimCompress> (&UnrealEdEngine_ptr->AnimationCompressionAlgorithms);
            return AnimationCompressionAlgorithms_store;
        } }
        private ObjectArrayField<AnimCompress> AnimationCompressionAlgorithms_store;

         //TODO: array not UObject TArray PackagesToBeFullyLoadedAtStartup
        ///<summary>Current target for LOD parenting operations (actors will use this as the replacement)</summary>
        public unsafe Actor CurrentLODParentActor {
            get {return UnrealEdEngine_ptr->CurrentLODParentActor;}
            set {UnrealEdEngine_ptr->CurrentLODParentActor = value;}
        }
        public bool bNeedWarningForPkgEngineVer {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedWarningForPkgEngineVer"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedWarningForPkgEngineVer", value); }
        }
        public bool bNeedWarningForWritePermission {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedWarningForWritePermission"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedWarningForWritePermission", value); }
        }
         //TODO: array not UObject TArray TemplateMapInfos
        ///<summary>Cooker server incase we want to cook ont he side while editing...</summary>
        public unsafe CookOnTheFlyServer CookServer {
            get {return UnrealEdEngine_ptr->CookServer;}
            set {UnrealEdEngine_ptr->CookServer = value;}
        }
        static UnrealEdEngine() {
            StaticClass = Main.GetClass("UnrealEdEngine");
        }
        internal unsafe UnrealEdEngine_fields* UnrealEdEngine_ptr => (UnrealEdEngine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnrealEdEngine(IntPtr p) => UObject.Make<UnrealEdEngine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnrealEdEngine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnrealEdEngine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
