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
using UE4.Sequencer.Native;
using UE4.Engine;

namespace UE4.Sequencer {
    ///<summary>Contains data for a group of assets to import</summary>
    public unsafe partial class SequencerExportTask : AssetExportTask  {
        ///<summary>A UWorld for LevelSequences, UUserWidget for WidgetAnimations, or AActor for Actor Sequences, etc...</summary>
        public unsafe UObject SequencerContext {
            get {return SequencerExportTask_ptr->SequencerContext;}
            set {SequencerExportTask_ptr->SequencerContext = value;}
        }
        static SequencerExportTask() {
            StaticClass = Main.GetClass("SequencerExportTask");
        }
        internal unsafe SequencerExportTask_fields* SequencerExportTask_ptr => (SequencerExportTask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SequencerExportTask(IntPtr p) => UObject.Make<SequencerExportTask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SequencerExportTask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SequencerExportTask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
