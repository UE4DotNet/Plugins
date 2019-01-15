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

using UE4.Engine;

namespace UE4.AnimationModifiers.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AnimationBlueprintLibrary_fields {
    }
    internal unsafe struct AnimationBlueprintLibrary_methods {
        internal struct AddAnimationNotifyEvent_method {
            static internal IntPtr AddAnimationNotifyEvent_ptr;
            static AddAnimationNotifyEvent_method() {
                AddAnimationNotifyEvent_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddAnimationNotifyEvent");
            }

            internal static unsafe AnimNotify Invoke(AnimSequence AnimationSequence, Name NotifyTrackName, float StartTime, float Duration, SubclassOf<UObject> NotifyClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                *((float*)(b+20)) = StartTime;
                *((float*)(b+24)) = Duration;
                *((IntPtr*)(b+32)) = NotifyClass;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddAnimationNotifyEvent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+40));
            }
        }
        internal struct AddAnimationNotifyEventObject_method {
            static internal IntPtr AddAnimationNotifyEventObject_ptr;
            static AddAnimationNotifyEventObject_method() {
                AddAnimationNotifyEventObject_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddAnimationNotifyEventObject");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, float StartTime, AnimNotify Notify, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((float*)(b+8)) = StartTime;
                *((IntPtr*)(b+16)) = Notify;
                *((Name*)(b+24)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddAnimationNotifyEventObject_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddAnimationNotifyTrack_method {
            static internal IntPtr AddAnimationNotifyTrack_ptr;
            static AddAnimationNotifyTrack_method() {
                AddAnimationNotifyTrack_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddAnimationNotifyTrack");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name NotifyTrackName, LinearColor TrackColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                *((LinearColor*)(b+20)) = TrackColor;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddAnimationNotifyTrack_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddAnimationSyncMarker_method {
            static internal IntPtr AddAnimationSyncMarker_ptr;
            static AddAnimationSyncMarker_method() {
                AddAnimationSyncMarker_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddAnimationSyncMarker");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name MarkerName, float Time, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = MarkerName;
                *((float*)(b+20)) = Time;
                *((Name*)(b+24)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddAnimationSyncMarker_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddCurve_method {
            static internal IntPtr AddCurve_ptr;
            static AddCurve_method() {
                AddCurve_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddCurve");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, ERawCurveTrackTypes CurveType, bool bMetaDataCurve) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                *(b+20) = (byte)CurveType;
                *((bool*)(b+21)) = bMetaDataCurve;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddCurve_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddFloatCurveKey_method {
            static internal IntPtr AddFloatCurveKey_ptr;
            static AddFloatCurveKey_method() {
                AddFloatCurveKey_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddFloatCurveKey");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, float Time, float Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                *((float*)(b+20)) = Time;
                *((float*)(b+24)) = Value;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddFloatCurveKey_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddFloatCurveKeys_method {
            static internal IntPtr AddFloatCurveKeys_ptr;
            static AddFloatCurveKeys_method() {
                AddFloatCurveKeys_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddFloatCurveKeys");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, byte Times /*TODO: array TArray */, byte Values /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                throw new NotImplementedException(); //TODO: array TArray Times
                throw new NotImplementedException(); //TODO: array TArray Values
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddFloatCurveKeys_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Times
                 //TODO: array TArray Values
            }
        }
        internal struct AddMetaData_method {
            static internal IntPtr AddMetaData_ptr;
            static AddMetaData_method() {
                AddMetaData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddMetaData");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass, AnimMetaData MetaDataInstance) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = MetaDataClass;
                *((IntPtr*)(b+16)) = MetaDataInstance;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddMetaData_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddMetaDataObject_method {
            static internal IntPtr AddMetaDataObject_ptr;
            static AddMetaDataObject_method() {
                AddMetaDataObject_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddMetaDataObject");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, AnimMetaData MetaDataObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = MetaDataObject;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddMetaDataObject_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTransformationCurveKey_method {
            static internal IntPtr AddTransformationCurveKey_ptr;
            static AddTransformationCurveKey_method() {
                AddTransformationCurveKey_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddTransformationCurveKey");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, float Time, Transform Transform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                *((float*)(b+20)) = Time;
                *((Transform*)(b+32)) = Transform;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddTransformationCurveKey_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddTransformationCurveKeys_method {
            static internal IntPtr AddTransformationCurveKeys_ptr;
            static AddTransformationCurveKeys_method() {
                AddTransformationCurveKeys_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddTransformationCurveKeys");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, byte Times /*TODO: array TArray */, byte Transforms /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                throw new NotImplementedException(); //TODO: array TArray Times
                throw new NotImplementedException(); //TODO: array TArray Transforms
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddTransformationCurveKeys_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Times
                 //TODO: array TArray Transforms
            }
        }
        internal struct AddVectorCurveKey_method {
            static internal IntPtr AddVectorCurveKey_ptr;
            static AddVectorCurveKey_method() {
                AddVectorCurveKey_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddVectorCurveKey");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, float Time, Vector Vector) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                *((float*)(b+20)) = Time;
                *((Vector*)(b+24)) = Vector;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddVectorCurveKey_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddVectorCurveKeys_method {
            static internal IntPtr AddVectorCurveKeys_ptr;
            static AddVectorCurveKeys_method() {
                AddVectorCurveKeys_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddVectorCurveKeys");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, byte Times /*TODO: array TArray */, byte Vectors /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                throw new NotImplementedException(); //TODO: array TArray Times
                throw new NotImplementedException(); //TODO: array TArray Vectors
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddVectorCurveKeys_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Times
                 //TODO: array TArray Vectors
            }
        }
        internal struct AddVirtualBone_method {
            static internal IntPtr AddVirtualBone_ptr;
            static AddVirtualBone_method() {
                AddVirtualBone_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "AddVirtualBone");
            }

            internal static unsafe Name Invoke(AnimSequence AnimationSequence, Name SourceBoneName, Name TargetBoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = SourceBoneName;
                *((Name*)(b+20)) = TargetBoneName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, AddVirtualBone_ptr, new IntPtr(p)); ;
                return *((Name*)(b+32));
            }
        }
        internal struct ContainsMetaDataOfClass_method {
            static internal IntPtr ContainsMetaDataOfClass_ptr;
            static ContainsMetaDataOfClass_method() {
                ContainsMetaDataOfClass_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "ContainsMetaDataOfClass");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = MetaDataClass;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, ContainsMetaDataOfClass_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct DoesBoneNameExist_method {
            static internal IntPtr DoesBoneNameExist_ptr;
            static DoesBoneNameExist_method() {
                DoesBoneNameExist_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "DoesBoneNameExist");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = BoneName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, DoesBoneNameExist_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct DoesCurveExist_method {
            static internal IntPtr DoesCurveExist_ptr;
            static DoesCurveExist_method() {
                DoesCurveExist_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "DoesCurveExist");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence, Name CurveName, ERawCurveTrackTypes CurveType) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                *(b+20) = (byte)CurveType;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, DoesCurveExist_ptr, new IntPtr(p)); ;
                return *((bool*)(b+21));
            }
        }
        internal struct FinalizeBoneAnimation_method {
            static internal IntPtr FinalizeBoneAnimation_ptr;
            static FinalizeBoneAnimation_method() {
                FinalizeBoneAnimation_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "FinalizeBoneAnimation");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, FinalizeBoneAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FindBonePathToRoot_method {
            static internal IntPtr FindBonePathToRoot_ptr;
            static FindBonePathToRoot_method() {
                FindBonePathToRoot_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "FindBonePathToRoot");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(AnimSequence AnimationSequence, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = BoneName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, FindBonePathToRoot_ptr, new IntPtr(p)); ;
                 //TODO: array TArray BonePath
                return UObject.ToUnmangedCollection<Name>(b+24);
            }
        }
        internal struct GetAdditiveAnimationType_method {
            static internal IntPtr GetAdditiveAnimationType_ptr;
            static GetAdditiveAnimationType_method() {
                GetAdditiveAnimationType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAdditiveAnimationType");
            }

            internal static unsafe byte Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAdditiveAnimationType_ptr, new IntPtr(p)); ;
                return *(b+8);
            }
        }
        internal struct GetAdditiveBasePoseType_method {
            static internal IntPtr GetAdditiveBasePoseType_ptr;
            static GetAdditiveBasePoseType_method() {
                GetAdditiveBasePoseType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAdditiveBasePoseType");
            }

            internal static unsafe byte Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAdditiveBasePoseType_ptr, new IntPtr(p)); ;
                return *(b+8);
            }
        }
        internal struct GetAnimationInterpolationType_method {
            static internal IntPtr GetAnimationInterpolationType_ptr;
            static GetAnimationInterpolationType_method() {
                GetAnimationInterpolationType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationInterpolationType");
            }

            internal static unsafe EAnimInterpolationType Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationInterpolationType_ptr, new IntPtr(p)); ;
                return *((EAnimInterpolationType*)(b+8));
            }
        }
        internal struct GetAnimationNotifyEventNames_method {
            static internal IntPtr GetAnimationNotifyEventNames_ptr;
            static GetAnimationNotifyEventNames_method() {
                GetAnimationNotifyEventNames_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationNotifyEventNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationNotifyEventNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray EventNames
                return UObject.ToUnmangedCollection<Name>(b+8);
            }
        }
        internal struct GetAnimationNotifyEvents_method {
            static internal IntPtr GetAnimationNotifyEvents_ptr;
            static GetAnimationNotifyEvents_method() {
                GetAnimationNotifyEvents_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationNotifyEvents");
            }

            internal static unsafe IReadOnlyCollection<AnimNotifyEvent> Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationNotifyEvents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray NotifyEvents
                return UObject.ToUnmangedCollection<AnimNotifyEvent>(b+8);
            }
        }
        internal struct GetAnimationNotifyEventsForTrack_method {
            static internal IntPtr GetAnimationNotifyEventsForTrack_ptr;
            static GetAnimationNotifyEventsForTrack_method() {
                GetAnimationNotifyEventsForTrack_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationNotifyEventsForTrack");
            }

            internal static unsafe IReadOnlyCollection<AnimNotifyEvent> Invoke(AnimSequence AnimationSequence, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationNotifyEventsForTrack_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Events
                return UObject.ToUnmangedCollection<AnimNotifyEvent>(b+24);
            }
        }
        internal struct GetAnimationNotifyTrackNames_method {
            static internal IntPtr GetAnimationNotifyTrackNames_ptr;
            static GetAnimationNotifyTrackNames_method() {
                GetAnimationNotifyTrackNames_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationNotifyTrackNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationNotifyTrackNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TrackNames
                return UObject.ToUnmangedCollection<Name>(b+8);
            }
        }
        internal struct GetAnimationSyncMarkers_method {
            static internal IntPtr GetAnimationSyncMarkers_ptr;
            static GetAnimationSyncMarkers_method() {
                GetAnimationSyncMarkers_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationSyncMarkers");
            }

            internal static unsafe IReadOnlyCollection<AnimSyncMarker> Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationSyncMarkers_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Markers
                return UObject.ToUnmangedCollection<AnimSyncMarker>(b+8);
            }
        }
        internal struct GetAnimationSyncMarkersForTrack_method {
            static internal IntPtr GetAnimationSyncMarkersForTrack_ptr;
            static GetAnimationSyncMarkersForTrack_method() {
                GetAnimationSyncMarkersForTrack_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationSyncMarkersForTrack");
            }

            internal static unsafe IReadOnlyCollection<AnimSyncMarker> Invoke(AnimSequence AnimationSequence, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationSyncMarkersForTrack_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Markers
                return UObject.ToUnmangedCollection<AnimSyncMarker>(b+24);
            }
        }
        internal struct GetAnimationTrackNames_method {
            static internal IntPtr GetAnimationTrackNames_ptr;
            static GetAnimationTrackNames_method() {
                GetAnimationTrackNames_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimationTrackNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimationTrackNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TrackNames
                return UObject.ToUnmangedCollection<Name>(b+8);
            }
        }
        internal struct GetAnimNotifyEventTriggerTime_method {
            static internal IntPtr GetAnimNotifyEventTriggerTime_ptr;
            static GetAnimNotifyEventTriggerTime_method() {
                GetAnimNotifyEventTriggerTime_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetAnimNotifyEventTriggerTime");
            }

            internal static unsafe float Invoke(AnimNotifyEvent NotifyEvent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((AnimNotifyEvent*)(b+0)) = NotifyEvent;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetAnimNotifyEventTriggerTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+184));
            }
        }
        internal struct GetBonePoseForFrame_method {
            static internal IntPtr GetBonePoseForFrame_ptr;
            static GetBonePoseForFrame_method() {
                GetBonePoseForFrame_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetBonePoseForFrame");
            }

            internal static unsafe Transform Invoke(AnimSequence AnimationSequence, Name BoneName, int Frame, bool bExtractRootMotion) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = BoneName;
                *((int*)(b+20)) = Frame;
                *((bool*)(b+24)) = bExtractRootMotion;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetBonePoseForFrame_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+32));
            }
        }
        internal struct GetBonePoseForTime_method {
            static internal IntPtr GetBonePoseForTime_ptr;
            static GetBonePoseForTime_method() {
                GetBonePoseForTime_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetBonePoseForTime");
            }

            internal static unsafe Transform Invoke(AnimSequence AnimationSequence, Name BoneName, float Time, bool bExtractRootMotion) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = BoneName;
                *((float*)(b+20)) = Time;
                *((bool*)(b+24)) = bExtractRootMotion;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetBonePoseForTime_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+32));
            }
        }
        internal struct GetBonePosesForFrame_method {
            static internal IntPtr GetBonePosesForFrame_ptr;
            static GetBonePosesForFrame_method() {
                GetBonePosesForFrame_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetBonePosesForFrame");
            }

            internal static unsafe IReadOnlyCollection<Transform> Invoke(AnimSequence AnimationSequence, byte BoneNames /*TODO: array TArray */, int Frame, bool bExtractRootMotion, SkeletalMesh PreviewMesh) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                throw new NotImplementedException(); //TODO: array TArray BoneNames
                *((int*)(b+24)) = Frame;
                *((bool*)(b+28)) = bExtractRootMotion;
                *((IntPtr*)(b+48)) = PreviewMesh;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetBonePosesForFrame_ptr, new IntPtr(p)); ;
                 //TODO: array TArray BoneNames
                 //TODO: array TArray Poses
                return UObject.ToUnmangedCollection<Transform>(b+32);
            }
        }
        internal struct GetBonePosesForTime_method {
            static internal IntPtr GetBonePosesForTime_ptr;
            static GetBonePosesForTime_method() {
                GetBonePosesForTime_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetBonePosesForTime");
            }

            internal static unsafe IReadOnlyCollection<Transform> Invoke(AnimSequence AnimationSequence, byte BoneNames /*TODO: array TArray */, float Time, bool bExtractRootMotion, SkeletalMesh PreviewMesh) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                throw new NotImplementedException(); //TODO: array TArray BoneNames
                *((float*)(b+24)) = Time;
                *((bool*)(b+28)) = bExtractRootMotion;
                *((IntPtr*)(b+48)) = PreviewMesh;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetBonePosesForTime_ptr, new IntPtr(p)); ;
                 //TODO: array TArray BoneNames
                 //TODO: array TArray Poses
                return UObject.ToUnmangedCollection<Transform>(b+32);
            }
        }
        internal struct GetCompressionScheme_method {
            static internal IntPtr GetCompressionScheme_ptr;
            static GetCompressionScheme_method() {
                GetCompressionScheme_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetCompressionScheme");
            }

            internal static unsafe AnimCompress Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetCompressionScheme_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetFloatKeys_method {
            static internal IntPtr GetFloatKeys_ptr;
            static GetFloatKeys_method() {
                GetFloatKeys_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetFloatKeys");
            }

            internal static unsafe (IReadOnlyCollection<float>, IReadOnlyCollection<float>) Invoke(AnimSequence AnimationSequence, Name CurveName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetFloatKeys_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Times
                 //TODO: array TArray Values
                return (UObject.ToUnmangedCollection<float>(b+24),UObject.ToUnmangedCollection<float>(b+40));
            }
        }
        internal struct GetFrameAtTime_method {
            static internal IntPtr GetFrameAtTime_ptr;
            static GetFrameAtTime_method() {
                GetFrameAtTime_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetFrameAtTime");
            }

            internal static unsafe int Invoke(AnimSequence AnimationSequence, float Time) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((float*)(b+8)) = Time;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetFrameAtTime_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct GetMetaData_method {
            static internal IntPtr GetMetaData_ptr;
            static GetMetaData_method() {
                GetMetaData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetMetaData");
            }

            internal static unsafe IReadOnlyCollection<AnimMetaData> Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetMetaData_ptr, new IntPtr(p)); ;
                 //TODO: array TArray MetaData
                return UObject.ToUObjectCollection<AnimMetaData>(b+8);
            }
        }
        internal struct GetMetaDataOfClass_method {
            static internal IntPtr GetMetaDataOfClass_ptr;
            static GetMetaDataOfClass_method() {
                GetMetaDataOfClass_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetMetaDataOfClass");
            }

            internal static unsafe IReadOnlyCollection<AnimMetaData> Invoke(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = MetaDataClass;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetMetaDataOfClass_ptr, new IntPtr(p)); ;
                 //TODO: array TArray MetaDataOfClass
                return UObject.ToUObjectCollection<AnimMetaData>(b+16);
            }
        }
        internal struct GetNumFrames_method {
            static internal IntPtr GetNumFrames_ptr;
            static GetNumFrames_method() {
                GetNumFrames_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetNumFrames");
            }

            internal static unsafe int Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetNumFrames_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetRateScale_method {
            static internal IntPtr GetRateScale_ptr;
            static GetRateScale_method() {
                GetRateScale_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetRateScale");
            }

            internal static unsafe float Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetRateScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetRawTrackData_method {
            static internal IntPtr GetRawTrackData_ptr;
            static GetRawTrackData_method() {
                GetRawTrackData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetRawTrackData");
            }

            internal static unsafe (IReadOnlyCollection<Vector>, IReadOnlyCollection<Quat>, IReadOnlyCollection<Vector>) Invoke(AnimSequence AnimationSequence, Name TrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = TrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetRawTrackData_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PositionKeys
                 //TODO: array TArray RotationKeys
                 //TODO: array TArray ScalingKeys
                return (UObject.ToUnmangedCollection<Vector>(b+24),UObject.ToUnmangedCollection<Quat>(b+40),UObject.ToUnmangedCollection<Vector>(b+56));
            }
        }
        internal struct GetRawTrackPositionData_method {
            static internal IntPtr GetRawTrackPositionData_ptr;
            static GetRawTrackPositionData_method() {
                GetRawTrackPositionData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetRawTrackPositionData");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(AnimSequence AnimationSequence, Name TrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = TrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetRawTrackPositionData_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PositionData
                return UObject.ToUnmangedCollection<Vector>(b+24);
            }
        }
        internal struct GetRawTrackRotationData_method {
            static internal IntPtr GetRawTrackRotationData_ptr;
            static GetRawTrackRotationData_method() {
                GetRawTrackRotationData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetRawTrackRotationData");
            }

            internal static unsafe IReadOnlyCollection<Quat> Invoke(AnimSequence AnimationSequence, Name TrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = TrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetRawTrackRotationData_ptr, new IntPtr(p)); ;
                 //TODO: array TArray RotationData
                return UObject.ToUnmangedCollection<Quat>(b+24);
            }
        }
        internal struct GetRawTrackScaleData_method {
            static internal IntPtr GetRawTrackScaleData_ptr;
            static GetRawTrackScaleData_method() {
                GetRawTrackScaleData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetRawTrackScaleData");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(AnimSequence AnimationSequence, Name TrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = TrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetRawTrackScaleData_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ScaleData
                return UObject.ToUnmangedCollection<Vector>(b+24);
            }
        }
        internal struct GetRootMotionLockType_method {
            static internal IntPtr GetRootMotionLockType_ptr;
            static GetRootMotionLockType_method() {
                GetRootMotionLockType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetRootMotionLockType");
            }

            internal static unsafe byte Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetRootMotionLockType_ptr, new IntPtr(p)); ;
                return *(b+8);
            }
        }
        internal struct GetSequenceLength_method {
            static internal IntPtr GetSequenceLength_ptr;
            static GetSequenceLength_method() {
                GetSequenceLength_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetSequenceLength");
            }

            internal static unsafe float Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetSequenceLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetTimeAtFrame_method {
            static internal IntPtr GetTimeAtFrame_ptr;
            static GetTimeAtFrame_method() {
                GetTimeAtFrame_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetTimeAtFrame");
            }

            internal static unsafe float Invoke(AnimSequence AnimationSequence, int Frame) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((int*)(b+8)) = Frame;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetTimeAtFrame_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetTransformationKeys_method {
            static internal IntPtr GetTransformationKeys_ptr;
            static GetTransformationKeys_method() {
                GetTransformationKeys_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetTransformationKeys");
            }

            internal static unsafe (IReadOnlyCollection<float>, IReadOnlyCollection<Transform>) Invoke(AnimSequence AnimationSequence, Name CurveName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetTransformationKeys_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Times
                 //TODO: array TArray Values
                return (UObject.ToUnmangedCollection<float>(b+24),UObject.ToUnmangedCollection<Transform>(b+40));
            }
        }
        internal struct GetUniqueMarkerNames_method {
            static internal IntPtr GetUniqueMarkerNames_ptr;
            static GetUniqueMarkerNames_method() {
                GetUniqueMarkerNames_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetUniqueMarkerNames");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetUniqueMarkerNames_ptr, new IntPtr(p)); ;
                 //TODO: array TArray MarkerNames
                return UObject.ToUnmangedCollection<Name>(b+8);
            }
        }
        internal struct GetVectorKeys_method {
            static internal IntPtr GetVectorKeys_ptr;
            static GetVectorKeys_method() {
                GetVectorKeys_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "GetVectorKeys");
            }

            internal static unsafe (IReadOnlyCollection<float>, IReadOnlyCollection<Vector>) Invoke(AnimSequence AnimationSequence, Name CurveName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, GetVectorKeys_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Times
                 //TODO: array TArray Values
                return (UObject.ToUnmangedCollection<float>(b+24),UObject.ToUnmangedCollection<Vector>(b+40));
            }
        }
        internal struct IsRootMotionEnabled_method {
            static internal IntPtr IsRootMotionEnabled_ptr;
            static IsRootMotionEnabled_method() {
                IsRootMotionEnabled_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "IsRootMotionEnabled");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, IsRootMotionEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsRootMotionLockForced_method {
            static internal IntPtr IsRootMotionLockForced_ptr;
            static IsRootMotionLockForced_method() {
                IsRootMotionLockForced_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "IsRootMotionLockForced");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, IsRootMotionLockForced_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsValidAnimationSyncMarkerName_method {
            static internal IntPtr IsValidAnimationSyncMarkerName_ptr;
            static IsValidAnimationSyncMarkerName_method() {
                IsValidAnimationSyncMarkerName_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "IsValidAnimationSyncMarkerName");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence, Name MarkerName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = MarkerName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, IsValidAnimationSyncMarkerName_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct IsValidAnimNotifyTrackName_method {
            static internal IntPtr IsValidAnimNotifyTrackName_ptr;
            static IsValidAnimNotifyTrackName_method() {
                IsValidAnimNotifyTrackName_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "IsValidAnimNotifyTrackName");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, IsValidAnimNotifyTrackName_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct IsValidRawAnimationTrackName_method {
            static internal IntPtr IsValidRawAnimationTrackName_ptr;
            static IsValidRawAnimationTrackName_method() {
                IsValidRawAnimationTrackName_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "IsValidRawAnimationTrackName");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence, Name TrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = TrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, IsValidRawAnimationTrackName_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct IsValidTime_method {
            static internal IntPtr IsValidTime_ptr;
            static IsValidTime_method() {
                IsValidTime_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "IsValidTime");
            }

            internal static unsafe bool Invoke(AnimSequence AnimationSequence, float Time) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((float*)(b+8)) = Time;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, IsValidTime_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct RemoveAllAnimationNotifyTracks_method {
            static internal IntPtr RemoveAllAnimationNotifyTracks_ptr;
            static RemoveAllAnimationNotifyTracks_method() {
                RemoveAllAnimationNotifyTracks_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAllAnimationNotifyTracks");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAllAnimationNotifyTracks_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAllAnimationSyncMarkers_method {
            static internal IntPtr RemoveAllAnimationSyncMarkers_ptr;
            static RemoveAllAnimationSyncMarkers_method() {
                RemoveAllAnimationSyncMarkers_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAllAnimationSyncMarkers");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAllAnimationSyncMarkers_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAllBoneAnimation_method {
            static internal IntPtr RemoveAllBoneAnimation_ptr;
            static RemoveAllBoneAnimation_method() {
                RemoveAllBoneAnimation_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAllBoneAnimation");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAllBoneAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAllCurveData_method {
            static internal IntPtr RemoveAllCurveData_ptr;
            static RemoveAllCurveData_method() {
                RemoveAllCurveData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAllCurveData");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAllCurveData_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAllMetaData_method {
            static internal IntPtr RemoveAllMetaData_ptr;
            static RemoveAllMetaData_method() {
                RemoveAllMetaData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAllMetaData");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAllMetaData_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAllVirtualBones_method {
            static internal IntPtr RemoveAllVirtualBones_ptr;
            static RemoveAllVirtualBones_method() {
                RemoveAllVirtualBones_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAllVirtualBones");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAllVirtualBones_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAnimationNotifyEventsByName_method {
            static internal IntPtr RemoveAnimationNotifyEventsByName_ptr;
            static RemoveAnimationNotifyEventsByName_method() {
                RemoveAnimationNotifyEventsByName_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAnimationNotifyEventsByName");
            }

            internal static unsafe int Invoke(AnimSequence AnimationSequence, Name NotifyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAnimationNotifyEventsByName_ptr, new IntPtr(p)); ;
                return *((int*)(b+20));
            }
        }
        internal struct RemoveAnimationNotifyEventsByTrack_method {
            static internal IntPtr RemoveAnimationNotifyEventsByTrack_ptr;
            static RemoveAnimationNotifyEventsByTrack_method() {
                RemoveAnimationNotifyEventsByTrack_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAnimationNotifyEventsByTrack");
            }

            internal static unsafe int Invoke(AnimSequence AnimationSequence, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAnimationNotifyEventsByTrack_ptr, new IntPtr(p)); ;
                return *((int*)(b+20));
            }
        }
        internal struct RemoveAnimationNotifyTrack_method {
            static internal IntPtr RemoveAnimationNotifyTrack_ptr;
            static RemoveAnimationNotifyTrack_method() {
                RemoveAnimationNotifyTrack_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAnimationNotifyTrack");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAnimationNotifyTrack_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveAnimationSyncMarkersByName_method {
            static internal IntPtr RemoveAnimationSyncMarkersByName_ptr;
            static RemoveAnimationSyncMarkersByName_method() {
                RemoveAnimationSyncMarkersByName_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAnimationSyncMarkersByName");
            }

            internal static unsafe int Invoke(AnimSequence AnimationSequence, Name MarkerName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = MarkerName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAnimationSyncMarkersByName_ptr, new IntPtr(p)); ;
                return *((int*)(b+20));
            }
        }
        internal struct RemoveAnimationSyncMarkersByTrack_method {
            static internal IntPtr RemoveAnimationSyncMarkersByTrack_ptr;
            static RemoveAnimationSyncMarkersByTrack_method() {
                RemoveAnimationSyncMarkersByTrack_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveAnimationSyncMarkersByTrack");
            }

            internal static unsafe int Invoke(AnimSequence AnimationSequence, Name NotifyTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = NotifyTrackName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveAnimationSyncMarkersByTrack_ptr, new IntPtr(p)); ;
                return *((int*)(b+20));
            }
        }
        internal struct RemoveBoneAnimation_method {
            static internal IntPtr RemoveBoneAnimation_ptr;
            static RemoveBoneAnimation_method() {
                RemoveBoneAnimation_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveBoneAnimation");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name BoneName, bool bIncludeChildren, bool bFinalize) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = BoneName;
                *((bool*)(b+20)) = bIncludeChildren;
                *((bool*)(b+21)) = bFinalize;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveBoneAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveCurve_method {
            static internal IntPtr RemoveCurve_ptr;
            static RemoveCurve_method() {
                RemoveCurve_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveCurve");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name CurveName, bool bRemoveNameFromSkeleton) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = CurveName;
                *((bool*)(b+20)) = bRemoveNameFromSkeleton;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveCurve_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveMetaData_method {
            static internal IntPtr RemoveMetaData_ptr;
            static RemoveMetaData_method() {
                RemoveMetaData_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveMetaData");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, AnimMetaData MetaDataObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = MetaDataObject;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveMetaData_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveMetaDataOfClass_method {
            static internal IntPtr RemoveMetaDataOfClass_ptr;
            static RemoveMetaDataOfClass_method() {
                RemoveMetaDataOfClass_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveMetaDataOfClass");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, SubclassOf<AnimMetaData> MetaDataClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = MetaDataClass;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveMetaDataOfClass_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveVirtualBone_method {
            static internal IntPtr RemoveVirtualBone_ptr;
            static RemoveVirtualBone_method() {
                RemoveVirtualBone_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveVirtualBone");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, Name VirtualBoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((Name*)(b+8)) = VirtualBoneName;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveVirtualBone_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveVirtualBones_method {
            static internal IntPtr RemoveVirtualBones_ptr;
            static RemoveVirtualBones_method() {
                RemoveVirtualBones_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "RemoveVirtualBones");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, byte VirtualBoneNames /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                throw new NotImplementedException(); //TODO: array TArray VirtualBoneNames
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, RemoveVirtualBones_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VirtualBoneNames
            }
        }
        internal struct ReplaceAnimNotifies_method {
            static internal IntPtr ReplaceAnimNotifies_ptr;
            static ReplaceAnimNotifies_method() {
                ReplaceAnimNotifies_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "ReplaceAnimNotifies");
            }

            internal static unsafe void Invoke(AnimSequenceBase AnimationSequence, SubclassOf<AnimNotify> OldNotifyClass, SubclassOf<AnimNotify> NewNotifyClass, byte OnNotifyReplaced /*TODO: delegate FOnNotifyReplaced */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = OldNotifyClass;
                *((IntPtr*)(b+16)) = NewNotifyClass;
                throw new NotImplementedException(); //TODO: delegate FOnNotifyReplaced OnNotifyReplaced
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, ReplaceAnimNotifies_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnNotifyReplaced OnNotifyReplaced
            }
        }
        internal struct ReplaceAnimNotifyStates_method {
            static internal IntPtr ReplaceAnimNotifyStates_ptr;
            static ReplaceAnimNotifyStates_method() {
                ReplaceAnimNotifyStates_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "ReplaceAnimNotifyStates");
            }

            internal static unsafe void Invoke(AnimSequenceBase AnimationSequence, SubclassOf<AnimNotifyState> OldNotifyClass, SubclassOf<AnimNotifyState> NewNotifyClass, byte OnNotifyStateReplaced /*TODO: delegate FOnNotifyStateReplaced */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = OldNotifyClass;
                *((IntPtr*)(b+16)) = NewNotifyClass;
                throw new NotImplementedException(); //TODO: delegate FOnNotifyStateReplaced OnNotifyStateReplaced
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, ReplaceAnimNotifyStates_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnNotifyStateReplaced OnNotifyStateReplaced
            }
        }
        internal struct SetAdditiveAnimationType_method {
            static internal IntPtr SetAdditiveAnimationType_ptr;
            static SetAdditiveAnimationType_method() {
                SetAdditiveAnimationType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetAdditiveAnimationType");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, byte AdditiveAnimationType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *(b+8) = AdditiveAnimationType;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetAdditiveAnimationType_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAdditiveBasePoseType_method {
            static internal IntPtr SetAdditiveBasePoseType_ptr;
            static SetAdditiveBasePoseType_method() {
                SetAdditiveBasePoseType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetAdditiveBasePoseType");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, byte AdditiveBasePoseType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *(b+8) = AdditiveBasePoseType;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetAdditiveBasePoseType_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimationInterpolationType_method {
            static internal IntPtr SetAnimationInterpolationType_ptr;
            static SetAnimationInterpolationType_method() {
                SetAnimationInterpolationType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetAnimationInterpolationType");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, EAnimInterpolationType InterpolationType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *(b+8) = (byte)InterpolationType;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetAnimationInterpolationType_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCompressionScheme_method {
            static internal IntPtr SetCompressionScheme_ptr;
            static SetCompressionScheme_method() {
                SetCompressionScheme_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetCompressionScheme");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, AnimCompress CompressionScheme) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((IntPtr*)(b+8)) = CompressionScheme;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetCompressionScheme_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIsRootMotionLockForced_method {
            static internal IntPtr SetIsRootMotionLockForced_ptr;
            static SetIsRootMotionLockForced_method() {
                SetIsRootMotionLockForced_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetIsRootMotionLockForced");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, bool bForced) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((bool*)(b+8)) = bForced;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetIsRootMotionLockForced_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRateScale_method {
            static internal IntPtr SetRateScale_ptr;
            static SetRateScale_method() {
                SetRateScale_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetRateScale");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, float RateScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((float*)(b+8)) = RateScale;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetRateScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRootMotionEnabled_method {
            static internal IntPtr SetRootMotionEnabled_ptr;
            static SetRootMotionEnabled_method() {
                SetRootMotionEnabled_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetRootMotionEnabled");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, bool bEnabled) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *((bool*)(b+8)) = bEnabled;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetRootMotionEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRootMotionLockType_method {
            static internal IntPtr SetRootMotionLockType_ptr;
            static SetRootMotionLockType_method() {
                SetRootMotionLockType_ptr = Main.GetMethodUFunction(AnimationBlueprintLibrary.StaticClass, "SetRootMotionLockType");
            }

            internal static unsafe void Invoke(AnimSequence AnimationSequence, byte RootMotionLockType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimationSequence;
                *(b+8) = RootMotionLockType;
                Main.GetProcessEvent(AnimationBlueprintLibrary.DefaultObject, SetRootMotionLockType_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AnimationBlueprintLibrary_events {
    }
}
