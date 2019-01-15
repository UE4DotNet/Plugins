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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1152 )]
    internal unsafe struct Blueprint_fields {
        [FieldOffset(96)] public bool bRecompileOnLoad;
        [FieldOffset(104)] public IntPtr ParentClass;
        [FieldOffset(112)]  public IntPtr  PRIVATE_InnermostPreviousCDO;
        [FieldOffset(120)] public bool bHasBeenRegenerated;
        [FieldOffset(120)] public bool bIsRegeneratingOnLoad;
        [FieldOffset(120)] public bool bIsNewlyCreated;
        [FieldOffset(120)] public bool bForceFullEditor;
        [FieldOffset(120)] public bool bQueuedForCompilation;
        [FieldOffset(120)] public bool bRunConstructionScriptOnDrag;
        [FieldOffset(120)] public bool bRunConstructionScriptInSequencer;
        [FieldOffset(120)] public bool bGenerateConstClass;
        [FieldOffset(121)] public bool bGenerateAbstractClass;
        [FieldOffset(128)] byte BlueprintDescription; //TODO: string FString BlueprintDescription
        [FieldOffset(144)] byte BlueprintCategory; //TODO: string FString BlueprintCategory
        [FieldOffset(160)] public NativeArray HideCategories;
        [FieldOffset(176)] byte NativizationFlag; //TODO: enum EBlueprintNativizationFlag NativizationFlag
        [FieldOffset(177)] public bool bDisplayCompilePIEWarning;
        [FieldOffset(180)] public FGuid SearchGuid;
        [FieldOffset(196)] public bool bDeprecate;
        [FieldOffset(197)] byte CompileMode; //TODO: enum EBlueprintCompileMode CompileMode
        [FieldOffset(200)]  public IntPtr  SimpleConstructionScript;
        [FieldOffset(208)] public NativeArray UbergraphPages;
        [FieldOffset(224)] public NativeArray FunctionGraphs;
        [FieldOffset(240)] public NativeArray DelegateSignatureGraphs;
        [FieldOffset(256)] public NativeArray MacroGraphs;
        [FieldOffset(272)] public NativeArray IntermediateGeneratedGraphs;
        [FieldOffset(288)] public NativeArray EventGraphs;
        [FieldOffset(304)] byte PRIVATE_CachedMacroInfo; //TODO: map TMap PRIVATE_CachedMacroInfo
        [FieldOffset(384)] public bool bDuplicatingReadOnly;
        [FieldOffset(392)] public NativeArray ComponentTemplates;
        [FieldOffset(408)] public NativeArray Timelines;
        [FieldOffset(424)]  public IntPtr  InheritableComponentHandler;
        [FieldOffset(432)] public byte BlueprintType;
        [FieldOffset(433)] public byte Status;
        [FieldOffset(440)] public NativeArray NewVariables;
        [FieldOffset(456)] public NativeArray CategorySorting;
        [FieldOffset(472)] public NativeArray ImplementedInterfaces;
        [FieldOffset(488)] public int BlueprintSystemVersion;
        [FieldOffset(496)] public NativeArray LastEditedDocuments;
        [FieldOffset(512)] byte Bookmarks; //TODO: map TMap Bookmarks
        [FieldOffset(592)] public NativeArray BookmarkNodes;
        [FieldOffset(608)] public NativeArray Breakpoints;
        [FieldOffset(624)] public NativeArray WatchedPins;
        [FieldOffset(640)] public NativeArray DeprecatedPinWatches;
        [FieldOffset(656)] byte ComponentTemplateNameIndex; //TODO: map TMap ComponentTemplateNameIndex
        [FieldOffset(736)] byte OldToNewComponentTemplateNames; //TODO: map TMap OldToNewComponentTemplateNames
        [FieldOffset(856)]  public IntPtr  ThumbnailInfo;
        [FieldOffset(864)] public bool bBeingCompiled;
        [FieldOffset(868)] byte CrcLastCompiledCDO; //TODO: numeric uint32 CrcLastCompiledCDO
        [FieldOffset(872)] byte CrcLastCompiledSignature; //TODO: numeric uint32 CrcLastCompiledSignature
        [FieldOffset(1048)] public IntPtr OriginalClass;
    }
    internal unsafe struct Blueprint_methods {
    }
    internal unsafe struct Blueprint_events {
    }
}
