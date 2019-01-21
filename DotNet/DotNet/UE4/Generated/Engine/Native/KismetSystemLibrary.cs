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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetSystemLibrary_fields {
    }
    internal unsafe struct KismetSystemLibrary_methods {
        internal struct AddFloatHistorySample_method {
            static internal IntPtr AddFloatHistorySample_ptr;
            static AddFloatHistorySample_method() {
                AddFloatHistorySample_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "AddFloatHistorySample");
            }

            internal static unsafe DebugFloatHistory Invoke(float Value, DebugFloatHistory FloatHistory) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *((DebugFloatHistory*)(b+8)) = FloatHistory;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, AddFloatHistorySample_ptr, new IntPtr(p)); ;
                return *((DebugFloatHistory*)(b+40));
            }
        }
        internal struct BeginTransaction_method {
            static internal IntPtr BeginTransaction_ptr;
            static BeginTransaction_method() {
                BeginTransaction_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BeginTransaction");
            }

            internal static unsafe int Invoke(string Context, byte Description /*TODO: text FText */, UObject PrimaryObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Context_handle = GCHandle.Alloc(Context, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Context_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Context.Length;
                *(int*)(b+IntPtr.Size+4+0) = Context.Length;
                throw new NotImplementedException(); //TODO: text FText Description
                *((IntPtr*)(b+40)) = PrimaryObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BeginTransaction_ptr, new IntPtr(p)); ;
                Context_handle.Free();
                 //TODO: text FText Description
                return *((int*)(b+48));
            }
        }
        internal struct BoxOverlapActors_method {
            static internal IntPtr BoxOverlapActors_ptr;
            static BoxOverlapActors_method() {
                BoxOverlapActors_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxOverlapActors");
            }

            internal static unsafe (IReadOnlyCollection<Actor>, bool) Invoke(UObject WorldContextObject, Vector BoxPos, Vector BoxExtent, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = BoxPos;
                *((Vector*)(b+20)) = BoxExtent;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+48)) = ActorClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxOverlapActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutActors
                return (UObject.ToUObjectCollection<Actor>(b+72),*((bool*)(b+88)));
            }
        }
        internal struct BoxOverlapComponents_method {
            static internal IntPtr BoxOverlapComponents_ptr;
            static BoxOverlapComponents_method() {
                BoxOverlapComponents_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxOverlapComponents");
            }

            internal static unsafe (IReadOnlyCollection<PrimitiveComponent>, bool) Invoke(UObject WorldContextObject, Vector BoxPos, Vector Extent, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = BoxPos;
                *((Vector*)(b+20)) = Extent;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+48)) = ComponentClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxOverlapComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutComponents
                return (UObject.ToUObjectCollection<PrimitiveComponent>(b+72),*((bool*)(b+88)));
            }
        }
        internal struct BoxTraceMulti_method {
            static internal IntPtr BoxTraceMulti_ptr;
            static BoxTraceMulti_method() {
                BoxTraceMulti_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxTraceMulti");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Vector*)(b+32)) = HalfSize;
                *((Rotator*)(b+44)) = Orientation;
                *(b+56) = TraceChannel;
                *((bool*)(b+57)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+80) = DrawDebugType;
                *((bool*)(b+104)) = bIgnoreSelf;
                *((LinearColor*)(b+108)) = TraceColor;
                *((LinearColor*)(b+124)) = TraceHitColor;
                *((float*)(b+140)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxTraceMulti_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+88),*((bool*)(b+144)));
            }
        }
        internal struct BoxTraceMultiByProfile_method {
            static internal IntPtr BoxTraceMultiByProfile_ptr;
            static BoxTraceMultiByProfile_method() {
                BoxTraceMultiByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxTraceMultiByProfile");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Vector*)(b+32)) = HalfSize;
                *((Rotator*)(b+44)) = Orientation;
                *((Name*)(b+56)) = ProfileName;
                *((bool*)(b+68)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+88) = DrawDebugType;
                *((bool*)(b+112)) = bIgnoreSelf;
                *((LinearColor*)(b+116)) = TraceColor;
                *((LinearColor*)(b+132)) = TraceHitColor;
                *((float*)(b+148)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxTraceMultiByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+96),*((bool*)(b+152)));
            }
        }
        internal struct BoxTraceMultiForObjects_method {
            static internal IntPtr BoxTraceMultiForObjects_ptr;
            static BoxTraceMultiForObjects_method() {
                BoxTraceMultiForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxTraceMultiForObjects");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Vector*)(b+32)) = HalfSize;
                *((Rotator*)(b+44)) = Orientation;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+72)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+96) = DrawDebugType;
                *((bool*)(b+120)) = bIgnoreSelf;
                *((LinearColor*)(b+124)) = TraceColor;
                *((LinearColor*)(b+140)) = TraceHitColor;
                *((float*)(b+156)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxTraceMultiForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+104),*((bool*)(b+160)));
            }
        }
        internal struct BoxTraceSingle_method {
            static internal IntPtr BoxTraceSingle_ptr;
            static BoxTraceSingle_method() {
                BoxTraceSingle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxTraceSingle");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Vector*)(b+32)) = HalfSize;
                *((Rotator*)(b+44)) = Orientation;
                *(b+56) = TraceChannel;
                *((bool*)(b+57)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+80) = DrawDebugType;
                *((bool*)(b+228)) = bIgnoreSelf;
                *((LinearColor*)(b+232)) = TraceColor;
                *((LinearColor*)(b+248)) = TraceHitColor;
                *((float*)(b+264)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxTraceSingle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+84)),*((bool*)(b+268)));
            }
        }
        internal struct BoxTraceSingleByProfile_method {
            static internal IntPtr BoxTraceSingleByProfile_ptr;
            static BoxTraceSingleByProfile_method() {
                BoxTraceSingleByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxTraceSingleByProfile");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Vector*)(b+32)) = HalfSize;
                *((Rotator*)(b+44)) = Orientation;
                *((Name*)(b+56)) = ProfileName;
                *((bool*)(b+68)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+88) = DrawDebugType;
                *((bool*)(b+236)) = bIgnoreSelf;
                *((LinearColor*)(b+240)) = TraceColor;
                *((LinearColor*)(b+256)) = TraceHitColor;
                *((float*)(b+272)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxTraceSingleByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+92)),*((bool*)(b+276)));
            }
        }
        internal struct BoxTraceSingleForObjects_method {
            static internal IntPtr BoxTraceSingleForObjects_ptr;
            static BoxTraceSingleForObjects_method() {
                BoxTraceSingleForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BoxTraceSingleForObjects");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Vector*)(b+32)) = HalfSize;
                *((Rotator*)(b+44)) = Orientation;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+72)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+96) = DrawDebugType;
                *((bool*)(b+244)) = bIgnoreSelf;
                *((LinearColor*)(b+248)) = TraceColor;
                *((LinearColor*)(b+264)) = TraceHitColor;
                *((float*)(b+280)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BoxTraceSingleForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+100)),*((bool*)(b+284)));
            }
        }
        internal struct BreakSoftClassPath_method {
            static internal IntPtr BreakSoftClassPath_ptr;
            static BreakSoftClassPath_method() {
                BreakSoftClassPath_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BreakSoftClassPath");
            }

            internal static unsafe string Invoke(SoftClassPath InSoftClassPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SoftClassPath*)(b+0)) = InSoftClassPath;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BreakSoftClassPath_ptr, new IntPtr(p)); ;
                return FString.Get(b+32);
            }
        }
        internal struct BreakSoftObjectPath_method {
            static internal IntPtr BreakSoftObjectPath_ptr;
            static BreakSoftObjectPath_method() {
                BreakSoftObjectPath_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "BreakSoftObjectPath");
            }

            internal static unsafe string Invoke(SoftObjectPath InSoftObjectPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SoftObjectPath*)(b+0)) = InSoftObjectPath;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, BreakSoftObjectPath_ptr, new IntPtr(p)); ;
                return FString.Get(b+32);
            }
        }
        internal struct CancelTransaction_method {
            static internal IntPtr CancelTransaction_ptr;
            static CancelTransaction_method() {
                CancelTransaction_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CancelTransaction");
            }

            internal static unsafe void Invoke(int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CancelTransaction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CanLaunchURL_method {
            static internal IntPtr CanLaunchURL_ptr;
            static CanLaunchURL_method() {
                CanLaunchURL_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CanLaunchURL");
            }

            internal static unsafe bool Invoke(string URL) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var URL_handle = GCHandle.Alloc(URL, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = URL_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = URL.Length;
                *(int*)(b+IntPtr.Size+4+0) = URL.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CanLaunchURL_ptr, new IntPtr(p)); ;
                URL_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct CapsuleOverlapActors_method {
            static internal IntPtr CapsuleOverlapActors_ptr;
            static CapsuleOverlapActors_method() {
                CapsuleOverlapActors_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleOverlapActors");
            }

            internal static unsafe (IReadOnlyCollection<Actor>, bool) Invoke(UObject WorldContextObject, Vector CapsulePos, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = CapsulePos;
                *((float*)(b+20)) = Radius;
                *((float*)(b+24)) = HalfHeight;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+48)) = ActorClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleOverlapActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutActors
                return (UObject.ToUObjectCollection<Actor>(b+72),*((bool*)(b+88)));
            }
        }
        internal struct CapsuleOverlapComponents_method {
            static internal IntPtr CapsuleOverlapComponents_ptr;
            static CapsuleOverlapComponents_method() {
                CapsuleOverlapComponents_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleOverlapComponents");
            }

            internal static unsafe (IReadOnlyCollection<PrimitiveComponent>, bool) Invoke(UObject WorldContextObject, Vector CapsulePos, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = CapsulePos;
                *((float*)(b+20)) = Radius;
                *((float*)(b+24)) = HalfHeight;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+48)) = ComponentClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleOverlapComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutComponents
                return (UObject.ToUObjectCollection<PrimitiveComponent>(b+72),*((bool*)(b+88)));
            }
        }
        internal struct CapsuleTraceMulti_method {
            static internal IntPtr CapsuleTraceMulti_ptr;
            static CapsuleTraceMulti_method() {
                CapsuleTraceMulti_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleTraceMulti");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((float*)(b+36)) = HalfHeight;
                *(b+40) = TraceChannel;
                *((bool*)(b+41)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+64) = DrawDebugType;
                *((bool*)(b+88)) = bIgnoreSelf;
                *((LinearColor*)(b+92)) = TraceColor;
                *((LinearColor*)(b+108)) = TraceHitColor;
                *((float*)(b+124)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleTraceMulti_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+72),*((bool*)(b+128)));
            }
        }
        internal struct CapsuleTraceMultiByProfile_method {
            static internal IntPtr CapsuleTraceMultiByProfile_ptr;
            static CapsuleTraceMultiByProfile_method() {
                CapsuleTraceMultiByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleTraceMultiByProfile");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((float*)(b+36)) = HalfHeight;
                *((Name*)(b+40)) = ProfileName;
                *((bool*)(b+52)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+72) = DrawDebugType;
                *((bool*)(b+96)) = bIgnoreSelf;
                *((LinearColor*)(b+100)) = TraceColor;
                *((LinearColor*)(b+116)) = TraceHitColor;
                *((float*)(b+132)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleTraceMultiByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+80),*((bool*)(b+136)));
            }
        }
        internal struct CapsuleTraceMultiForObjects_method {
            static internal IntPtr CapsuleTraceMultiForObjects_ptr;
            static CapsuleTraceMultiForObjects_method() {
                CapsuleTraceMultiForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleTraceMultiForObjects");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((float*)(b+36)) = HalfHeight;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+56)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+80) = DrawDebugType;
                *((bool*)(b+104)) = bIgnoreSelf;
                *((LinearColor*)(b+108)) = TraceColor;
                *((LinearColor*)(b+124)) = TraceHitColor;
                *((float*)(b+140)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleTraceMultiForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+88),*((bool*)(b+144)));
            }
        }
        internal struct CapsuleTraceSingle_method {
            static internal IntPtr CapsuleTraceSingle_ptr;
            static CapsuleTraceSingle_method() {
                CapsuleTraceSingle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleTraceSingle");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((float*)(b+36)) = HalfHeight;
                *(b+40) = TraceChannel;
                *((bool*)(b+41)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+64) = DrawDebugType;
                *((bool*)(b+212)) = bIgnoreSelf;
                *((LinearColor*)(b+216)) = TraceColor;
                *((LinearColor*)(b+232)) = TraceHitColor;
                *((float*)(b+248)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleTraceSingle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+68)),*((bool*)(b+252)));
            }
        }
        internal struct CapsuleTraceSingleByProfile_method {
            static internal IntPtr CapsuleTraceSingleByProfile_ptr;
            static CapsuleTraceSingleByProfile_method() {
                CapsuleTraceSingleByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleTraceSingleByProfile");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((float*)(b+36)) = HalfHeight;
                *((Name*)(b+40)) = ProfileName;
                *((bool*)(b+52)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+72) = DrawDebugType;
                *((bool*)(b+220)) = bIgnoreSelf;
                *((LinearColor*)(b+224)) = TraceColor;
                *((LinearColor*)(b+240)) = TraceHitColor;
                *((float*)(b+256)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleTraceSingleByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+76)),*((bool*)(b+260)));
            }
        }
        internal struct CapsuleTraceSingleForObjects_method {
            static internal IntPtr CapsuleTraceSingleForObjects_ptr;
            static CapsuleTraceSingleForObjects_method() {
                CapsuleTraceSingleForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CapsuleTraceSingleForObjects");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((float*)(b+36)) = HalfHeight;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+56)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+80) = DrawDebugType;
                *((bool*)(b+228)) = bIgnoreSelf;
                *((LinearColor*)(b+232)) = TraceColor;
                *((LinearColor*)(b+248)) = TraceHitColor;
                *((float*)(b+264)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CapsuleTraceSingleForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+84)),*((bool*)(b+268)));
            }
        }
        internal struct CollectGarbage_method {
            static internal IntPtr CollectGarbage_ptr;
            static CollectGarbage_method() {
                CollectGarbage_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CollectGarbage");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CollectGarbage_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ComponentOverlapActors_method {
            static internal IntPtr ComponentOverlapActors_ptr;
            static ComponentOverlapActors_method() {
                ComponentOverlapActors_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ComponentOverlapActors");
            }

            internal static unsafe (IReadOnlyCollection<Actor>, bool) Invoke(PrimitiveComponent Component, Transform ComponentTransform, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Transform*)(b+16)) = ComponentTransform;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+80)) = ActorClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ComponentOverlapActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutActors
                return (UObject.ToUObjectCollection<Actor>(b+104),*((bool*)(b+120)));
            }
        }
        internal struct ComponentOverlapComponents_method {
            static internal IntPtr ComponentOverlapComponents_ptr;
            static ComponentOverlapComponents_method() {
                ComponentOverlapComponents_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ComponentOverlapComponents");
            }

            internal static unsafe (IReadOnlyCollection<PrimitiveComponent>, bool) Invoke(PrimitiveComponent Component, Transform ComponentTransform, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Transform*)(b+16)) = ComponentTransform;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+80)) = ComponentClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ComponentOverlapComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutComponents
                return (UObject.ToUObjectCollection<PrimitiveComponent>(b+104),*((bool*)(b+120)));
            }
        }
        internal struct ControlScreensaver_method {
            static internal IntPtr ControlScreensaver_ptr;
            static ControlScreensaver_method() {
                ControlScreensaver_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ControlScreensaver");
            }

            internal static unsafe void Invoke(bool bAllowScreenSaver) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bAllowScreenSaver;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ControlScreensaver_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Conv_ClassToSoftClassReference_method {
            static internal IntPtr Conv_ClassToSoftClassReference_ptr;
            static Conv_ClassToSoftClassReference_method() {
                Conv_ClassToSoftClassReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_ClassToSoftClassReference");
            }

            internal static unsafe byte /*TODO: soft class TSoftClassPtr<UObject> */ Invoke(SubclassOf<UObject> Class) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Class;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_ClassToSoftClassReference_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: soft class TSoftClassPtr<UObject> */;
            }
        }
        internal struct Conv_InterfaceToObject_method {
            static internal IntPtr Conv_InterfaceToObject_ptr;
            static Conv_InterfaceToObject_method() {
                Conv_InterfaceToObject_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_InterfaceToObject");
            }

            internal static unsafe UObject Invoke(byte Interface /*TODO: interface TScriptInterface */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface Interface
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_InterfaceToObject_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface Interface
                return *((IntPtr*)(b+16));
            }
        }
        internal struct Conv_ObjectToSoftObjectReference_method {
            static internal IntPtr Conv_ObjectToSoftObjectReference_ptr;
            static Conv_ObjectToSoftObjectReference_method() {
                Conv_ObjectToSoftObjectReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_ObjectToSoftObjectReference");
            }

            internal static unsafe byte /*TODO: soft object TSoftObjectPtr<UObject>*/ Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_ObjectToSoftObjectReference_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: soft object TSoftObjectPtr<UObject>*/;
            }
        }
        internal struct Conv_PrimaryAssetIdToString_method {
            static internal IntPtr Conv_PrimaryAssetIdToString_ptr;
            static Conv_PrimaryAssetIdToString_method() {
                Conv_PrimaryAssetIdToString_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_PrimaryAssetIdToString");
            }

            internal static unsafe string Invoke(PrimaryAssetId PrimaryAssetId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_PrimaryAssetIdToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+24);
            }
        }
        internal struct Conv_PrimaryAssetTypeToString_method {
            static internal IntPtr Conv_PrimaryAssetTypeToString_ptr;
            static Conv_PrimaryAssetTypeToString_method() {
                Conv_PrimaryAssetTypeToString_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_PrimaryAssetTypeToString");
            }

            internal static unsafe string Invoke(PrimaryAssetType PrimaryAssetType) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetType*)(b+0)) = PrimaryAssetType;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_PrimaryAssetTypeToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct Conv_SoftClassReferenceToClass_method {
            static internal IntPtr Conv_SoftClassReferenceToClass_ptr;
            static Conv_SoftClassReferenceToClass_method() {
                Conv_SoftClassReferenceToClass_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_SoftClassReferenceToClass");
            }

            internal static unsafe SubclassOf<UObject> Invoke(byte SoftClass /*TODO: soft class TSoftClassPtr<UObject>  */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  SoftClass
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_SoftClassReferenceToClass_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  SoftClass
                return *((IntPtr*)(b+48));
            }
        }
        internal struct Conv_SoftClassReferenceToString_method {
            static internal IntPtr Conv_SoftClassReferenceToString_ptr;
            static Conv_SoftClassReferenceToString_method() {
                Conv_SoftClassReferenceToString_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_SoftClassReferenceToString");
            }

            internal static unsafe string Invoke(byte SoftClassReference /*TODO: soft class TSoftClassPtr<UObject>  */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  SoftClassReference
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_SoftClassReferenceToString_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  SoftClassReference
                return FString.Get(b+48);
            }
        }
        internal struct Conv_SoftObjectReferenceToObject_method {
            static internal IntPtr Conv_SoftObjectReferenceToObject_ptr;
            static Conv_SoftObjectReferenceToObject_method() {
                Conv_SoftObjectReferenceToObject_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_SoftObjectReferenceToObject");
            }

            internal static unsafe UObject Invoke(byte SoftObject /*TODO: soft object TSoftObjectPtr<UObject> */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> SoftObject
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_SoftObjectReferenceToObject_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> SoftObject
                return *((IntPtr*)(b+48));
            }
        }
        internal struct Conv_SoftObjectReferenceToString_method {
            static internal IntPtr Conv_SoftObjectReferenceToString_ptr;
            static Conv_SoftObjectReferenceToString_method() {
                Conv_SoftObjectReferenceToString_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Conv_SoftObjectReferenceToString");
            }

            internal static unsafe string Invoke(byte SoftObjectReference /*TODO: soft object TSoftObjectPtr<UObject> */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> SoftObjectReference
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Conv_SoftObjectReferenceToString_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> SoftObjectReference
                return FString.Get(b+48);
            }
        }
        internal struct ConvertToAbsolutePath_method {
            static internal IntPtr ConvertToAbsolutePath_ptr;
            static ConvertToAbsolutePath_method() {
                ConvertToAbsolutePath_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ConvertToAbsolutePath");
            }

            internal static unsafe string Invoke(string Filename) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Filename_handle = GCHandle.Alloc(Filename, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Filename_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Filename.Length;
                *(int*)(b+IntPtr.Size+4+0) = Filename.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ConvertToAbsolutePath_ptr, new IntPtr(p)); ;
                Filename_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct ConvertToRelativePath_method {
            static internal IntPtr ConvertToRelativePath_ptr;
            static ConvertToRelativePath_method() {
                ConvertToRelativePath_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ConvertToRelativePath");
            }

            internal static unsafe string Invoke(string Filename) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Filename_handle = GCHandle.Alloc(Filename, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Filename_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Filename.Length;
                *(int*)(b+IntPtr.Size+4+0) = Filename.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ConvertToRelativePath_ptr, new IntPtr(p)); ;
                Filename_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct CreateCopyForUndoBuffer_method {
            static internal IntPtr CreateCopyForUndoBuffer_ptr;
            static CreateCopyForUndoBuffer_method() {
                CreateCopyForUndoBuffer_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "CreateCopyForUndoBuffer");
            }

            internal static unsafe void Invoke(UObject ObjectToModify) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ObjectToModify;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, CreateCopyForUndoBuffer_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Delay_method {
            static internal IntPtr Delay_ptr;
            static Delay_method() {
                Delay_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "Delay");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, float Duration, LatentActionInfo LatentInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = Duration;
                *((LatentActionInfo*)(b+16)) = LatentInfo;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, Delay_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DoesImplementInterface_method {
            static internal IntPtr DoesImplementInterface_ptr;
            static DoesImplementInterface_method() {
                DoesImplementInterface_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DoesImplementInterface");
            }

            internal static unsafe bool Invoke(UObject TestObject, SubclassOf<Interface> Interface) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = TestObject;
                *((IntPtr*)(b+8)) = Interface;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DoesImplementInterface_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct DrawDebugArrow_method {
            static internal IntPtr DrawDebugArrow_ptr;
            static DrawDebugArrow_method() {
                DrawDebugArrow_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugArrow");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector LineStart, Vector LineEnd, float ArrowSize, LinearColor LineColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = LineStart;
                *((Vector*)(b+20)) = LineEnd;
                *((float*)(b+32)) = ArrowSize;
                *((LinearColor*)(b+36)) = LineColor;
                *((float*)(b+52)) = Duration;
                *((float*)(b+56)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugArrow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugBox_method {
            static internal IntPtr DrawDebugBox_ptr;
            static DrawDebugBox_method() {
                DrawDebugBox_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugBox");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Center, Vector Extent, LinearColor LineColor, Rotator Rotation, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Center;
                *((Vector*)(b+20)) = Extent;
                *((LinearColor*)(b+32)) = LineColor;
                *((Rotator*)(b+48)) = Rotation;
                *((float*)(b+60)) = Duration;
                *((float*)(b+64)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugBox_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugCamera_method {
            static internal IntPtr DrawDebugCamera_ptr;
            static DrawDebugCamera_method() {
                DrawDebugCamera_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugCamera");
            }

            internal static unsafe void Invoke(CameraActor CameraActor, LinearColor CameraColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = CameraActor;
                *((LinearColor*)(b+8)) = CameraColor;
                *((float*)(b+24)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugCamera_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugCapsule_method {
            static internal IntPtr DrawDebugCapsule_ptr;
            static DrawDebugCapsule_method() {
                DrawDebugCapsule_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugCapsule");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Center, float HalfHeight, float Radius, Rotator Rotation, LinearColor LineColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Center;
                *((float*)(b+20)) = HalfHeight;
                *((float*)(b+24)) = Radius;
                *((Rotator*)(b+28)) = Rotation;
                *((LinearColor*)(b+40)) = LineColor;
                *((float*)(b+56)) = Duration;
                *((float*)(b+60)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugCapsule_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugCircle_method {
            static internal IntPtr DrawDebugCircle_ptr;
            static DrawDebugCircle_method() {
                DrawDebugCircle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugCircle");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Center, float Radius, int NumSegments, LinearColor LineColor, float Duration, float Thickness, Vector YAxis, Vector ZAxis, bool bDrawAxis) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Center;
                *((float*)(b+20)) = Radius;
                *((int*)(b+24)) = NumSegments;
                *((LinearColor*)(b+28)) = LineColor;
                *((float*)(b+44)) = Duration;
                *((float*)(b+48)) = Thickness;
                *((Vector*)(b+52)) = YAxis;
                *((Vector*)(b+64)) = ZAxis;
                *((bool*)(b+76)) = bDrawAxis;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugCircle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugCone_method {
            static internal IntPtr DrawDebugCone_ptr;
            static DrawDebugCone_method() {
                DrawDebugCone_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugCone");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Origin, Vector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, LinearColor LineColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Origin;
                *((Vector*)(b+20)) = Direction;
                *((float*)(b+32)) = Length;
                *((float*)(b+36)) = AngleWidth;
                *((float*)(b+40)) = AngleHeight;
                *((int*)(b+44)) = NumSides;
                *((LinearColor*)(b+48)) = LineColor;
                *((float*)(b+64)) = Duration;
                *((float*)(b+68)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugCone_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugConeInDegrees_method {
            static internal IntPtr DrawDebugConeInDegrees_ptr;
            static DrawDebugConeInDegrees_method() {
                DrawDebugConeInDegrees_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugConeInDegrees");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Origin, Vector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, LinearColor LineColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Origin;
                *((Vector*)(b+20)) = Direction;
                *((float*)(b+32)) = Length;
                *((float*)(b+36)) = AngleWidth;
                *((float*)(b+40)) = AngleHeight;
                *((int*)(b+44)) = NumSides;
                *((LinearColor*)(b+48)) = LineColor;
                *((float*)(b+64)) = Duration;
                *((float*)(b+68)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugConeInDegrees_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugCoordinateSystem_method {
            static internal IntPtr DrawDebugCoordinateSystem_ptr;
            static DrawDebugCoordinateSystem_method() {
                DrawDebugCoordinateSystem_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugCoordinateSystem");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector AxisLoc, Rotator AxisRot, float Scale, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = AxisLoc;
                *((Rotator*)(b+20)) = AxisRot;
                *((float*)(b+32)) = Scale;
                *((float*)(b+36)) = Duration;
                *((float*)(b+40)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugCoordinateSystem_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugCylinder_method {
            static internal IntPtr DrawDebugCylinder_ptr;
            static DrawDebugCylinder_method() {
                DrawDebugCylinder_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugCylinder");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, int Segments, LinearColor LineColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((int*)(b+36)) = Segments;
                *((LinearColor*)(b+40)) = LineColor;
                *((float*)(b+56)) = Duration;
                *((float*)(b+60)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugCylinder_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugFloatHistoryLocation_method {
            static internal IntPtr DrawDebugFloatHistoryLocation_ptr;
            static DrawDebugFloatHistoryLocation_method() {
                DrawDebugFloatHistoryLocation_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugFloatHistoryLocation");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, DebugFloatHistory FloatHistory, Vector DrawLocation, Vector2D DrawSize, LinearColor DrawColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((DebugFloatHistory*)(b+8)) = FloatHistory;
                *((Vector*)(b+40)) = DrawLocation;
                *((Vector2D*)(b+52)) = DrawSize;
                *((LinearColor*)(b+60)) = DrawColor;
                *((float*)(b+76)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugFloatHistoryLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugFloatHistoryTransform_method {
            static internal IntPtr DrawDebugFloatHistoryTransform_ptr;
            static DrawDebugFloatHistoryTransform_method() {
                DrawDebugFloatHistoryTransform_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugFloatHistoryTransform");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, DebugFloatHistory FloatHistory, Transform DrawTransform, Vector2D DrawSize, LinearColor DrawColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((DebugFloatHistory*)(b+8)) = FloatHistory;
                *((Transform*)(b+48)) = DrawTransform;
                *((Vector2D*)(b+96)) = DrawSize;
                *((LinearColor*)(b+104)) = DrawColor;
                *((float*)(b+120)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugFloatHistoryTransform_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugFrustum_method {
            static internal IntPtr DrawDebugFrustum_ptr;
            static DrawDebugFrustum_method() {
                DrawDebugFrustum_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugFrustum");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Transform FrustumTransform, LinearColor FrustumColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Transform*)(b+16)) = FrustumTransform;
                *((LinearColor*)(b+64)) = FrustumColor;
                *((float*)(b+80)) = Duration;
                *((float*)(b+84)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugFrustum_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugLine_method {
            static internal IntPtr DrawDebugLine_ptr;
            static DrawDebugLine_method() {
                DrawDebugLine_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugLine");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector LineStart, Vector LineEnd, LinearColor LineColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = LineStart;
                *((Vector*)(b+20)) = LineEnd;
                *((LinearColor*)(b+32)) = LineColor;
                *((float*)(b+48)) = Duration;
                *((float*)(b+52)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugLine_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugPlane_method {
            static internal IntPtr DrawDebugPlane_ptr;
            static DrawDebugPlane_method() {
                DrawDebugPlane_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugPlane");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Plane PlaneCoordinates, Vector Location, float Size, LinearColor PlaneColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Plane*)(b+16)) = PlaneCoordinates;
                *((Vector*)(b+32)) = Location;
                *((float*)(b+44)) = Size;
                *((LinearColor*)(b+48)) = PlaneColor;
                *((float*)(b+64)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugPlane_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugPoint_method {
            static internal IntPtr DrawDebugPoint_ptr;
            static DrawDebugPoint_method() {
                DrawDebugPoint_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugPoint");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Position, float Size, LinearColor PointColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Position;
                *((float*)(b+20)) = Size;
                *((LinearColor*)(b+24)) = PointColor;
                *((float*)(b+40)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugPoint_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugSphere_method {
            static internal IntPtr DrawDebugSphere_ptr;
            static DrawDebugSphere_method() {
                DrawDebugSphere_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugSphere");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector Center, float Radius, int Segments, LinearColor LineColor, float Duration, float Thickness) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Center;
                *((float*)(b+20)) = Radius;
                *((int*)(b+24)) = Segments;
                *((LinearColor*)(b+28)) = LineColor;
                *((float*)(b+44)) = Duration;
                *((float*)(b+48)) = Thickness;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugSphere_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DrawDebugString_method {
            static internal IntPtr DrawDebugString_ptr;
            static DrawDebugString_method() {
                DrawDebugString_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "DrawDebugString");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, Vector TextLocation, string Text, Actor TestBaseActor, LinearColor TextColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = TextLocation;
                var Text_handle = GCHandle.Alloc(Text, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = Text_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = Text.Length;
                *(int*)(b+IntPtr.Size+4+24) = Text.Length;
                *((IntPtr*)(b+40)) = TestBaseActor;
                *((LinearColor*)(b+48)) = TextColor;
                *((float*)(b+64)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, DrawDebugString_ptr, new IntPtr(p)); ;
                Text_handle.Free();
            }
        }
        internal struct EndTransaction_method {
            static internal IntPtr EndTransaction_ptr;
            static EndTransaction_method() {
                EndTransaction_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "EndTransaction");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, EndTransaction_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct EqualEqual_PrimaryAssetId_method {
            static internal IntPtr EqualEqual_PrimaryAssetId_ptr;
            static EqualEqual_PrimaryAssetId_method() {
                EqualEqual_PrimaryAssetId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "EqualEqual_PrimaryAssetId");
            }

            internal static unsafe bool Invoke(PrimaryAssetId A, PrimaryAssetId B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = A;
                *((PrimaryAssetId*)(b+24)) = B;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, EqualEqual_PrimaryAssetId_ptr, new IntPtr(p)); ;
                return *((bool*)(b+48));
            }
        }
        internal struct EqualEqual_PrimaryAssetType_method {
            static internal IntPtr EqualEqual_PrimaryAssetType_ptr;
            static EqualEqual_PrimaryAssetType_method() {
                EqualEqual_PrimaryAssetType_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "EqualEqual_PrimaryAssetType");
            }

            internal static unsafe bool Invoke(PrimaryAssetType A, PrimaryAssetType B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetType*)(b+0)) = A;
                *((PrimaryAssetType*)(b+12)) = B;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, EqualEqual_PrimaryAssetType_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct EqualEqual_SoftClassReference_method {
            static internal IntPtr EqualEqual_SoftClassReference_ptr;
            static EqualEqual_SoftClassReference_method() {
                EqualEqual_SoftClassReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "EqualEqual_SoftClassReference");
            }

            internal static unsafe bool Invoke(byte A /*TODO: soft class TSoftClassPtr<UObject>  */, byte B /*TODO: soft class TSoftClassPtr<UObject>  */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  A
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  B
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, EqualEqual_SoftClassReference_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  A
                 //TODO: soft class TSoftClassPtr<UObject>  B
                return *((bool*)(b+96));
            }
        }
        internal struct EqualEqual_SoftObjectReference_method {
            static internal IntPtr EqualEqual_SoftObjectReference_ptr;
            static EqualEqual_SoftObjectReference_method() {
                EqualEqual_SoftObjectReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "EqualEqual_SoftObjectReference");
            }

            internal static unsafe bool Invoke(byte A /*TODO: soft object TSoftObjectPtr<UObject> */, byte B /*TODO: soft object TSoftObjectPtr<UObject> */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> A
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> B
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, EqualEqual_SoftObjectReference_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> A
                 //TODO: soft object TSoftObjectPtr<UObject> B
                return *((bool*)(b+96));
            }
        }
        internal struct ExecuteConsoleCommand_method {
            static internal IntPtr ExecuteConsoleCommand_ptr;
            static ExecuteConsoleCommand_method() {
                ExecuteConsoleCommand_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ExecuteConsoleCommand");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, string Command, PlayerController SpecificPlayer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                var Command_handle = GCHandle.Alloc(Command, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = Command_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = Command.Length;
                *(int*)(b+IntPtr.Size+4+8) = Command.Length;
                *((IntPtr*)(b+24)) = SpecificPlayer;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ExecuteConsoleCommand_ptr, new IntPtr(p)); ;
                Command_handle.Free();
            }
        }
        internal struct FlushDebugStrings_method {
            static internal IntPtr FlushDebugStrings_ptr;
            static FlushDebugStrings_method() {
                FlushDebugStrings_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "FlushDebugStrings");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, FlushDebugStrings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FlushPersistentDebugLines_method {
            static internal IntPtr FlushPersistentDebugLines_ptr;
            static FlushPersistentDebugLines_method() {
                FlushPersistentDebugLines_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "FlushPersistentDebugLines");
            }

            internal static unsafe void Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, FlushPersistentDebugLines_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ForceCloseAdBanner_method {
            static internal IntPtr ForceCloseAdBanner_ptr;
            static ForceCloseAdBanner_method() {
                ForceCloseAdBanner_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ForceCloseAdBanner");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ForceCloseAdBanner_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetActorBounds_method {
            static internal IntPtr GetActorBounds_ptr;
            static GetActorBounds_method() {
                GetActorBounds_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetActorBounds");
            }

            internal static unsafe (Vector, Vector) Invoke(Actor Actor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actor;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetActorBounds_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((Vector*)(b+20)));
            }
        }
        internal struct GetActorListFromComponentList_method {
            static internal IntPtr GetActorListFromComponentList_ptr;
            static GetActorListFromComponentList_method() {
                GetActorListFromComponentList_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetActorListFromComponentList");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(byte ComponentList /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ComponentList
                *((IntPtr*)(b+16)) = ActorClassFilter;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetActorListFromComponentList_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ComponentList
                 //TODO: array TArray OutActorList
                return UObject.ToUObjectCollection<Actor>(b+24);
            }
        }
        internal struct GetAdIDCount_method {
            static internal IntPtr GetAdIDCount_ptr;
            static GetAdIDCount_method() {
                GetAdIDCount_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetAdIDCount");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetAdIDCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetClassDisplayName_method {
            static internal IntPtr GetClassDisplayName_ptr;
            static GetClassDisplayName_method() {
                GetClassDisplayName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetClassDisplayName");
            }

            internal static unsafe string Invoke(SubclassOf<UObject> Class) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Class;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetClassDisplayName_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetClassFromPrimaryAssetId_method {
            static internal IntPtr GetClassFromPrimaryAssetId_ptr;
            static GetClassFromPrimaryAssetId_method() {
                GetClassFromPrimaryAssetId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetClassFromPrimaryAssetId");
            }

            internal static unsafe SubclassOf<UObject> Invoke(PrimaryAssetId PrimaryAssetId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetClassFromPrimaryAssetId_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct GetCommandLine_method {
            static internal IntPtr GetCommandLine_ptr;
            static GetCommandLine_method() {
                GetCommandLine_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetCommandLine");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetCommandLine_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetComponentBounds_method {
            static internal IntPtr GetComponentBounds_ptr;
            static GetComponentBounds_method() {
                GetComponentBounds_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetComponentBounds");
            }

            internal static unsafe (Vector, Vector, float) Invoke(SceneComponent Component) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetComponentBounds_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((Vector*)(b+20)),*((float*)(b+32)));
            }
        }
        internal struct GetConsoleVariableFloatValue_method {
            static internal IntPtr GetConsoleVariableFloatValue_ptr;
            static GetConsoleVariableFloatValue_method() {
                GetConsoleVariableFloatValue_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetConsoleVariableFloatValue");
            }

            internal static unsafe float Invoke(UObject WorldContextObject, string VariableName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                var VariableName_handle = GCHandle.Alloc(VariableName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = VariableName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = VariableName.Length;
                *(int*)(b+IntPtr.Size+4+8) = VariableName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetConsoleVariableFloatValue_ptr, new IntPtr(p)); ;
                VariableName_handle.Free();
                return *((float*)(b+24));
            }
        }
        internal struct GetConsoleVariableIntValue_method {
            static internal IntPtr GetConsoleVariableIntValue_ptr;
            static GetConsoleVariableIntValue_method() {
                GetConsoleVariableIntValue_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetConsoleVariableIntValue");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, string VariableName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                var VariableName_handle = GCHandle.Alloc(VariableName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = VariableName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = VariableName.Length;
                *(int*)(b+IntPtr.Size+4+8) = VariableName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetConsoleVariableIntValue_ptr, new IntPtr(p)); ;
                VariableName_handle.Free();
                return *((int*)(b+24));
            }
        }
        internal struct GetConvenientWindowedResolutions_method {
            static internal IntPtr GetConvenientWindowedResolutions_ptr;
            static GetConvenientWindowedResolutions_method() {
                GetConvenientWindowedResolutions_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetConvenientWindowedResolutions");
            }

            internal static unsafe (IReadOnlyCollection<IntPoint>, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetConvenientWindowedResolutions_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Resolutions
                return (UObject.ToUnmangedCollection<IntPoint>(b+0),*((bool*)(b+16)));
            }
        }
        internal struct GetCurrentBundleState_method {
            static internal IntPtr GetCurrentBundleState_ptr;
            static GetCurrentBundleState_method() {
                GetCurrentBundleState_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetCurrentBundleState");
            }

            internal static unsafe (IReadOnlyCollection<Name>, bool) Invoke(PrimaryAssetId PrimaryAssetId, bool bForceCurrentState) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                *((bool*)(b+24)) = bForceCurrentState;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetCurrentBundleState_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutBundles
                return (UObject.ToUnmangedCollection<Name>(b+32),*((bool*)(b+48)));
            }
        }
        internal struct GetDefaultLanguage_method {
            static internal IntPtr GetDefaultLanguage_ptr;
            static GetDefaultLanguage_method() {
                GetDefaultLanguage_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetDefaultLanguage");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetDefaultLanguage_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetDefaultLocale_method {
            static internal IntPtr GetDefaultLocale_ptr;
            static GetDefaultLocale_method() {
                GetDefaultLocale_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetDefaultLocale");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetDefaultLocale_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetDeviceId_method {
            static internal IntPtr GetDeviceId_ptr;
            static GetDeviceId_method() {
                GetDeviceId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetDeviceId");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetDeviceId_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetDisplayName_method {
            static internal IntPtr GetDisplayName_ptr;
            static GetDisplayName_method() {
                GetDisplayName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetDisplayName");
            }

            internal static unsafe string Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetDisplayName_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetEngineVersion_method {
            static internal IntPtr GetEngineVersion_ptr;
            static GetEngineVersion_method() {
                GetEngineVersion_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetEngineVersion");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetEngineVersion_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetGameBundleId_method {
            static internal IntPtr GetGameBundleId_ptr;
            static GetGameBundleId_method() {
                GetGameBundleId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetGameBundleId");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetGameBundleId_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetGameName_method {
            static internal IntPtr GetGameName_ptr;
            static GetGameName_method() {
                GetGameName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetGameName");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetGameName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetGameTimeInSeconds_method {
            static internal IntPtr GetGameTimeInSeconds_ptr;
            static GetGameTimeInSeconds_method() {
                GetGameTimeInSeconds_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetGameTimeInSeconds");
            }

            internal static unsafe float Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetGameTimeInSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetLocalCurrencyCode_method {
            static internal IntPtr GetLocalCurrencyCode_ptr;
            static GetLocalCurrencyCode_method() {
                GetLocalCurrencyCode_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetLocalCurrencyCode");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetLocalCurrencyCode_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetLocalCurrencySymbol_method {
            static internal IntPtr GetLocalCurrencySymbol_ptr;
            static GetLocalCurrencySymbol_method() {
                GetLocalCurrencySymbol_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetLocalCurrencySymbol");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetLocalCurrencySymbol_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetMinYResolutionFor3DView_method {
            static internal IntPtr GetMinYResolutionFor3DView_ptr;
            static GetMinYResolutionFor3DView_method() {
                GetMinYResolutionFor3DView_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetMinYResolutionFor3DView");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetMinYResolutionFor3DView_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetMinYResolutionForUI_method {
            static internal IntPtr GetMinYResolutionForUI_ptr;
            static GetMinYResolutionForUI_method() {
                GetMinYResolutionForUI_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetMinYResolutionForUI");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetMinYResolutionForUI_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetObjectFromPrimaryAssetId_method {
            static internal IntPtr GetObjectFromPrimaryAssetId_ptr;
            static GetObjectFromPrimaryAssetId_method() {
                GetObjectFromPrimaryAssetId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetObjectFromPrimaryAssetId");
            }

            internal static unsafe UObject Invoke(PrimaryAssetId PrimaryAssetId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetObjectFromPrimaryAssetId_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct GetObjectName_method {
            static internal IntPtr GetObjectName_ptr;
            static GetObjectName_method() {
                GetObjectName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetObjectName");
            }

            internal static unsafe string Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetObjectName_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetPathName_method {
            static internal IntPtr GetPathName_ptr;
            static GetPathName_method() {
                GetPathName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPathName");
            }

            internal static unsafe string Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPathName_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct GetPlatformUserName_method {
            static internal IntPtr GetPlatformUserName_ptr;
            static GetPlatformUserName_method() {
                GetPlatformUserName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPlatformUserName");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPlatformUserName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetPreferredLanguages_method {
            static internal IntPtr GetPreferredLanguages_ptr;
            static GetPreferredLanguages_method() {
                GetPreferredLanguages_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPreferredLanguages");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPreferredLanguages_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToStringCollection(b+0);
            }
        }
        internal struct GetPrimaryAssetIdFromClass_method {
            static internal IntPtr GetPrimaryAssetIdFromClass_ptr;
            static GetPrimaryAssetIdFromClass_method() {
                GetPrimaryAssetIdFromClass_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPrimaryAssetIdFromClass");
            }

            internal static unsafe PrimaryAssetId Invoke(SubclassOf<UObject> Class) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Class;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPrimaryAssetIdFromClass_ptr, new IntPtr(p)); ;
                return *((PrimaryAssetId*)(b+8));
            }
        }
        internal struct GetPrimaryAssetIdFromObject_method {
            static internal IntPtr GetPrimaryAssetIdFromObject_ptr;
            static GetPrimaryAssetIdFromObject_method() {
                GetPrimaryAssetIdFromObject_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPrimaryAssetIdFromObject");
            }

            internal static unsafe PrimaryAssetId Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPrimaryAssetIdFromObject_ptr, new IntPtr(p)); ;
                return *((PrimaryAssetId*)(b+8));
            }
        }
        internal struct GetPrimaryAssetIdFromSoftClassReference_method {
            static internal IntPtr GetPrimaryAssetIdFromSoftClassReference_ptr;
            static GetPrimaryAssetIdFromSoftClassReference_method() {
                GetPrimaryAssetIdFromSoftClassReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPrimaryAssetIdFromSoftClassReference");
            }

            internal static unsafe PrimaryAssetId Invoke(byte SoftClassReference /*TODO: soft class TSoftClassPtr<UObject>  */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  SoftClassReference
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPrimaryAssetIdFromSoftClassReference_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  SoftClassReference
                return *((PrimaryAssetId*)(b+48));
            }
        }
        internal struct GetPrimaryAssetIdFromSoftObjectReference_method {
            static internal IntPtr GetPrimaryAssetIdFromSoftObjectReference_ptr;
            static GetPrimaryAssetIdFromSoftObjectReference_method() {
                GetPrimaryAssetIdFromSoftObjectReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPrimaryAssetIdFromSoftObjectReference");
            }

            internal static unsafe PrimaryAssetId Invoke(byte SoftObjectReference /*TODO: soft object TSoftObjectPtr<UObject> */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> SoftObjectReference
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPrimaryAssetIdFromSoftObjectReference_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> SoftObjectReference
                return *((PrimaryAssetId*)(b+48));
            }
        }
        internal struct GetPrimaryAssetIdList_method {
            static internal IntPtr GetPrimaryAssetIdList_ptr;
            static GetPrimaryAssetIdList_method() {
                GetPrimaryAssetIdList_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPrimaryAssetIdList");
            }

            internal static unsafe IReadOnlyCollection<PrimaryAssetId> Invoke(PrimaryAssetType PrimaryAssetType) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetType*)(b+0)) = PrimaryAssetType;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPrimaryAssetIdList_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutPrimaryAssetIdList
                return UObject.ToUnmangedCollection<PrimaryAssetId>(b+16);
            }
        }
        internal struct GetPrimaryAssetsWithBundleState_method {
            static internal IntPtr GetPrimaryAssetsWithBundleState_ptr;
            static GetPrimaryAssetsWithBundleState_method() {
                GetPrimaryAssetsWithBundleState_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetPrimaryAssetsWithBundleState");
            }

            internal static unsafe IReadOnlyCollection<PrimaryAssetId> Invoke(byte RequiredBundles /*TODO: array TArray */, byte ExcludedBundles /*TODO: array TArray */, byte ValidTypes /*TODO: array TArray */, bool bForceCurrentState) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray RequiredBundles
                throw new NotImplementedException(); //TODO: array TArray ExcludedBundles
                throw new NotImplementedException(); //TODO: array TArray ValidTypes
                *((bool*)(b+48)) = bForceCurrentState;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetPrimaryAssetsWithBundleState_ptr, new IntPtr(p)); ;
                 //TODO: array TArray RequiredBundles
                 //TODO: array TArray ExcludedBundles
                 //TODO: array TArray ValidTypes
                 //TODO: array TArray OutPrimaryAssetIdList
                return UObject.ToUnmangedCollection<PrimaryAssetId>(b+56);
            }
        }
        internal struct GetProjectContentDirectory_method {
            static internal IntPtr GetProjectContentDirectory_ptr;
            static GetProjectContentDirectory_method() {
                GetProjectContentDirectory_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetProjectContentDirectory");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetProjectContentDirectory_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetProjectDirectory_method {
            static internal IntPtr GetProjectDirectory_ptr;
            static GetProjectDirectory_method() {
                GetProjectDirectory_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetProjectDirectory");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetProjectDirectory_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetProjectSavedDirectory_method {
            static internal IntPtr GetProjectSavedDirectory_ptr;
            static GetProjectSavedDirectory_method() {
                GetProjectSavedDirectory_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetProjectSavedDirectory");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetProjectSavedDirectory_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetRenderingDetailMode_method {
            static internal IntPtr GetRenderingDetailMode_ptr;
            static GetRenderingDetailMode_method() {
                GetRenderingDetailMode_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetRenderingDetailMode");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetRenderingDetailMode_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetRenderingMaterialQualityLevel_method {
            static internal IntPtr GetRenderingMaterialQualityLevel_ptr;
            static GetRenderingMaterialQualityLevel_method() {
                GetRenderingMaterialQualityLevel_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetRenderingMaterialQualityLevel");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetRenderingMaterialQualityLevel_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetSoftClassReferenceFromPrimaryAssetId_method {
            static internal IntPtr GetSoftClassReferenceFromPrimaryAssetId_ptr;
            static GetSoftClassReferenceFromPrimaryAssetId_method() {
                GetSoftClassReferenceFromPrimaryAssetId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetSoftClassReferenceFromPrimaryAssetId");
            }

            internal static unsafe byte /*TODO: soft class TSoftClassPtr<UObject> */ Invoke(PrimaryAssetId PrimaryAssetId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetSoftClassReferenceFromPrimaryAssetId_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: soft class TSoftClassPtr<UObject> */;
            }
        }
        internal struct GetSoftObjectReferenceFromPrimaryAssetId_method {
            static internal IntPtr GetSoftObjectReferenceFromPrimaryAssetId_ptr;
            static GetSoftObjectReferenceFromPrimaryAssetId_method() {
                GetSoftObjectReferenceFromPrimaryAssetId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetSoftObjectReferenceFromPrimaryAssetId");
            }

            internal static unsafe byte /*TODO: soft object TSoftObjectPtr<UObject>*/ Invoke(PrimaryAssetId PrimaryAssetId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetSoftObjectReferenceFromPrimaryAssetId_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: soft object TSoftObjectPtr<UObject>*/;
            }
        }
        internal struct GetSupportedFullscreenResolutions_method {
            static internal IntPtr GetSupportedFullscreenResolutions_ptr;
            static GetSupportedFullscreenResolutions_method() {
                GetSupportedFullscreenResolutions_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetSupportedFullscreenResolutions");
            }

            internal static unsafe (IReadOnlyCollection<IntPoint>, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetSupportedFullscreenResolutions_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Resolutions
                return (UObject.ToUnmangedCollection<IntPoint>(b+0),*((bool*)(b+16)));
            }
        }
        internal struct GetUniqueDeviceId_method {
            static internal IntPtr GetUniqueDeviceId_ptr;
            static GetUniqueDeviceId_method() {
                GetUniqueDeviceId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetUniqueDeviceId");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetUniqueDeviceId_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetVolumeButtonsHandledBySystem_method {
            static internal IntPtr GetVolumeButtonsHandledBySystem_ptr;
            static GetVolumeButtonsHandledBySystem_method() {
                GetVolumeButtonsHandledBySystem_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "GetVolumeButtonsHandledBySystem");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, GetVolumeButtonsHandledBySystem_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HideAdBanner_method {
            static internal IntPtr HideAdBanner_ptr;
            static HideAdBanner_method() {
                HideAdBanner_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "HideAdBanner");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, HideAdBanner_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsControllerAssignedToGamepad_method {
            static internal IntPtr IsControllerAssignedToGamepad_ptr;
            static IsControllerAssignedToGamepad_method() {
                IsControllerAssignedToGamepad_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsControllerAssignedToGamepad");
            }

            internal static unsafe bool Invoke(int ControllerId) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ControllerId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsControllerAssignedToGamepad_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct IsDedicatedServer_method {
            static internal IntPtr IsDedicatedServer_ptr;
            static IsDedicatedServer_method() {
                IsDedicatedServer_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsDedicatedServer");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsDedicatedServer_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsInterstitialAdAvailable_method {
            static internal IntPtr IsInterstitialAdAvailable_ptr;
            static IsInterstitialAdAvailable_method() {
                IsInterstitialAdAvailable_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsInterstitialAdAvailable");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsInterstitialAdAvailable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsInterstitialAdRequested_method {
            static internal IntPtr IsInterstitialAdRequested_ptr;
            static IsInterstitialAdRequested_method() {
                IsInterstitialAdRequested_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsInterstitialAdRequested");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsInterstitialAdRequested_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsLoggedIn_method {
            static internal IntPtr IsLoggedIn_ptr;
            static IsLoggedIn_method() {
                IsLoggedIn_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsLoggedIn");
            }

            internal static unsafe bool Invoke(PlayerController SpecificPlayer) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SpecificPlayer;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsLoggedIn_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsPackagedForDistribution_method {
            static internal IntPtr IsPackagedForDistribution_ptr;
            static IsPackagedForDistribution_method() {
                IsPackagedForDistribution_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsPackagedForDistribution");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsPackagedForDistribution_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsScreensaverEnabled_method {
            static internal IntPtr IsScreensaverEnabled_ptr;
            static IsScreensaverEnabled_method() {
                IsScreensaverEnabled_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsScreensaverEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsScreensaverEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsServer_method {
            static internal IntPtr IsServer_ptr;
            static IsServer_method() {
                IsServer_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsServer");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsServer_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsStandalone_method {
            static internal IntPtr IsStandalone_ptr;
            static IsStandalone_method() {
                IsStandalone_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsStandalone");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsStandalone_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsUnattended_method {
            static internal IntPtr IsUnattended_ptr;
            static IsUnattended_method() {
                IsUnattended_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsUnattended");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsUnattended_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsValid_method {
            static internal IntPtr IsValid_ptr;
            static IsValid_method() {
                IsValid_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsValid");
            }

            internal static unsafe bool Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsValid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsValidClass_method {
            static internal IntPtr IsValidClass_ptr;
            static IsValidClass_method() {
                IsValidClass_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsValidClass");
            }

            internal static unsafe bool Invoke(SubclassOf<UObject> Class) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Class;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsValidClass_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsValidPrimaryAssetId_method {
            static internal IntPtr IsValidPrimaryAssetId_ptr;
            static IsValidPrimaryAssetId_method() {
                IsValidPrimaryAssetId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsValidPrimaryAssetId");
            }

            internal static unsafe bool Invoke(PrimaryAssetId PrimaryAssetId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsValidPrimaryAssetId_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct IsValidPrimaryAssetType_method {
            static internal IntPtr IsValidPrimaryAssetType_ptr;
            static IsValidPrimaryAssetType_method() {
                IsValidPrimaryAssetType_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsValidPrimaryAssetType");
            }

            internal static unsafe bool Invoke(PrimaryAssetType PrimaryAssetType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetType*)(b+0)) = PrimaryAssetType;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsValidPrimaryAssetType_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsValidSoftClassReference_method {
            static internal IntPtr IsValidSoftClassReference_ptr;
            static IsValidSoftClassReference_method() {
                IsValidSoftClassReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsValidSoftClassReference");
            }

            internal static unsafe bool Invoke(byte SoftClassReference /*TODO: soft class TSoftClassPtr<UObject>  */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  SoftClassReference
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsValidSoftClassReference_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  SoftClassReference
                return *((bool*)(b+48));
            }
        }
        internal struct IsValidSoftObjectReference_method {
            static internal IntPtr IsValidSoftObjectReference_ptr;
            static IsValidSoftObjectReference_method() {
                IsValidSoftObjectReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "IsValidSoftObjectReference");
            }

            internal static unsafe bool Invoke(byte SoftObjectReference /*TODO: soft object TSoftObjectPtr<UObject> */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> SoftObjectReference
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, IsValidSoftObjectReference_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> SoftObjectReference
                return *((bool*)(b+48));
            }
        }
        internal struct K2_ClearAndInvalidateTimerHandle_method {
            static internal IntPtr K2_ClearAndInvalidateTimerHandle_ptr;
            static K2_ClearAndInvalidateTimerHandle_method() {
                K2_ClearAndInvalidateTimerHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_ClearAndInvalidateTimerHandle");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_ClearAndInvalidateTimerHandle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_ClearTimer_method {
            static internal IntPtr K2_ClearTimer_ptr;
            static K2_ClearTimer_method() {
                K2_ClearTimer_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_ClearTimer");
            }

            internal static unsafe void Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_ClearTimer_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
            }
        }
        internal struct K2_ClearTimerDelegate_method {
            static internal IntPtr K2_ClearTimerDelegate_ptr;
            static K2_ClearTimerDelegate_method() {
                K2_ClearTimerDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_ClearTimerDelegate");
            }

            internal static unsafe void Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_ClearTimerDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
            }
        }
        internal struct K2_ClearTimerHandle_method {
            static internal IntPtr K2_ClearTimerHandle_ptr;
            static K2_ClearTimerHandle_method() {
                K2_ClearTimerHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_ClearTimerHandle");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_ClearTimerHandle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_GetTimerElapsedTime_method {
            static internal IntPtr K2_GetTimerElapsedTime_ptr;
            static K2_GetTimerElapsedTime_method() {
                K2_GetTimerElapsedTime_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_GetTimerElapsedTime");
            }

            internal static unsafe float Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_GetTimerElapsedTime_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
                return *((float*)(b+24));
            }
        }
        internal struct K2_GetTimerElapsedTimeDelegate_method {
            static internal IntPtr K2_GetTimerElapsedTimeDelegate_ptr;
            static K2_GetTimerElapsedTimeDelegate_method() {
                K2_GetTimerElapsedTimeDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_GetTimerElapsedTimeDelegate");
            }

            internal static unsafe float Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_GetTimerElapsedTimeDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
                return *((float*)(b+20));
            }
        }
        internal struct K2_GetTimerElapsedTimeHandle_method {
            static internal IntPtr K2_GetTimerElapsedTimeHandle_ptr;
            static K2_GetTimerElapsedTimeHandle_method() {
                K2_GetTimerElapsedTimeHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_GetTimerElapsedTimeHandle");
            }

            internal static unsafe float Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_GetTimerElapsedTimeHandle_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct K2_GetTimerRemainingTime_method {
            static internal IntPtr K2_GetTimerRemainingTime_ptr;
            static K2_GetTimerRemainingTime_method() {
                K2_GetTimerRemainingTime_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_GetTimerRemainingTime");
            }

            internal static unsafe float Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_GetTimerRemainingTime_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
                return *((float*)(b+24));
            }
        }
        internal struct K2_GetTimerRemainingTimeDelegate_method {
            static internal IntPtr K2_GetTimerRemainingTimeDelegate_ptr;
            static K2_GetTimerRemainingTimeDelegate_method() {
                K2_GetTimerRemainingTimeDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_GetTimerRemainingTimeDelegate");
            }

            internal static unsafe float Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_GetTimerRemainingTimeDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
                return *((float*)(b+20));
            }
        }
        internal struct K2_GetTimerRemainingTimeHandle_method {
            static internal IntPtr K2_GetTimerRemainingTimeHandle_ptr;
            static K2_GetTimerRemainingTimeHandle_method() {
                K2_GetTimerRemainingTimeHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_GetTimerRemainingTimeHandle");
            }

            internal static unsafe float Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_GetTimerRemainingTimeHandle_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct K2_InvalidateTimerHandle_method {
            static internal IntPtr K2_InvalidateTimerHandle_ptr;
            static K2_InvalidateTimerHandle_method() {
                K2_InvalidateTimerHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_InvalidateTimerHandle");
            }

            internal static unsafe TimerHandle Invoke(TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((TimerHandle*)(b+0)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_InvalidateTimerHandle_ptr, new IntPtr(p)); ;
                return *((TimerHandle*)(b+8));
            }
        }
        internal struct K2_IsTimerActive_method {
            static internal IntPtr K2_IsTimerActive_ptr;
            static K2_IsTimerActive_method() {
                K2_IsTimerActive_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_IsTimerActive");
            }

            internal static unsafe bool Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_IsTimerActive_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct K2_IsTimerActiveDelegate_method {
            static internal IntPtr K2_IsTimerActiveDelegate_ptr;
            static K2_IsTimerActiveDelegate_method() {
                K2_IsTimerActiveDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_IsTimerActiveDelegate");
            }

            internal static unsafe bool Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_IsTimerActiveDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
                return *((bool*)(b+20));
            }
        }
        internal struct K2_IsTimerActiveHandle_method {
            static internal IntPtr K2_IsTimerActiveHandle_ptr;
            static K2_IsTimerActiveHandle_method() {
                K2_IsTimerActiveHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_IsTimerActiveHandle");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_IsTimerActiveHandle_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct K2_IsTimerPaused_method {
            static internal IntPtr K2_IsTimerPaused_ptr;
            static K2_IsTimerPaused_method() {
                K2_IsTimerPaused_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_IsTimerPaused");
            }

            internal static unsafe bool Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_IsTimerPaused_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct K2_IsTimerPausedDelegate_method {
            static internal IntPtr K2_IsTimerPausedDelegate_ptr;
            static K2_IsTimerPausedDelegate_method() {
                K2_IsTimerPausedDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_IsTimerPausedDelegate");
            }

            internal static unsafe bool Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_IsTimerPausedDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
                return *((bool*)(b+20));
            }
        }
        internal struct K2_IsTimerPausedHandle_method {
            static internal IntPtr K2_IsTimerPausedHandle_ptr;
            static K2_IsTimerPausedHandle_method() {
                K2_IsTimerPausedHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_IsTimerPausedHandle");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_IsTimerPausedHandle_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct K2_IsValidTimerHandle_method {
            static internal IntPtr K2_IsValidTimerHandle_ptr;
            static K2_IsValidTimerHandle_method() {
                K2_IsValidTimerHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_IsValidTimerHandle");
            }

            internal static unsafe bool Invoke(TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((TimerHandle*)(b+0)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_IsValidTimerHandle_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct K2_PauseTimer_method {
            static internal IntPtr K2_PauseTimer_ptr;
            static K2_PauseTimer_method() {
                K2_PauseTimer_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_PauseTimer");
            }

            internal static unsafe void Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_PauseTimer_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
            }
        }
        internal struct K2_PauseTimerDelegate_method {
            static internal IntPtr K2_PauseTimerDelegate_ptr;
            static K2_PauseTimerDelegate_method() {
                K2_PauseTimerDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_PauseTimerDelegate");
            }

            internal static unsafe void Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_PauseTimerDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
            }
        }
        internal struct K2_PauseTimerHandle_method {
            static internal IntPtr K2_PauseTimerHandle_ptr;
            static K2_PauseTimerHandle_method() {
                K2_PauseTimerHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_PauseTimerHandle");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_PauseTimerHandle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct K2_SetTimer_method {
            static internal IntPtr K2_SetTimer_ptr;
            static K2_SetTimer_method() {
                K2_SetTimer_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_SetTimer");
            }

            internal static unsafe TimerHandle Invoke(UObject UObject, string FunctionName, float Time, bool bLooping) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                *((float*)(b+24)) = Time;
                *((bool*)(b+28)) = bLooping;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_SetTimer_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
                return *((TimerHandle*)(b+32));
            }
        }
        internal struct K2_SetTimerDelegate_method {
            static internal IntPtr K2_SetTimerDelegate_ptr;
            static K2_SetTimerDelegate_method() {
                K2_SetTimerDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_SetTimerDelegate");
            }

            internal static unsafe TimerHandle Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */, float Time, bool bLooping) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                *((float*)(b+20)) = Time;
                *((bool*)(b+24)) = bLooping;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_SetTimerDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
                return *((TimerHandle*)(b+32));
            }
        }
        internal struct K2_TimerExists_method {
            static internal IntPtr K2_TimerExists_ptr;
            static K2_TimerExists_method() {
                K2_TimerExists_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_TimerExists");
            }

            internal static unsafe bool Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_TimerExists_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
                return *((bool*)(b+24));
            }
        }
        internal struct K2_TimerExistsDelegate_method {
            static internal IntPtr K2_TimerExistsDelegate_ptr;
            static K2_TimerExistsDelegate_method() {
                K2_TimerExistsDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_TimerExistsDelegate");
            }

            internal static unsafe bool Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_TimerExistsDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
                return *((bool*)(b+20));
            }
        }
        internal struct K2_TimerExistsHandle_method {
            static internal IntPtr K2_TimerExistsHandle_ptr;
            static K2_TimerExistsHandle_method() {
                K2_TimerExistsHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_TimerExistsHandle");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_TimerExistsHandle_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct K2_UnPauseTimer_method {
            static internal IntPtr K2_UnPauseTimer_ptr;
            static K2_UnPauseTimer_method() {
                K2_UnPauseTimer_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_UnPauseTimer");
            }

            internal static unsafe void Invoke(UObject UObject, string FunctionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                var FunctionName_handle = GCHandle.Alloc(FunctionName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FunctionName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FunctionName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FunctionName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_UnPauseTimer_ptr, new IntPtr(p)); ;
                FunctionName_handle.Free();
            }
        }
        internal struct K2_UnPauseTimerDelegate_method {
            static internal IntPtr K2_UnPauseTimerDelegate_ptr;
            static K2_UnPauseTimerDelegate_method() {
                K2_UnPauseTimerDelegate_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_UnPauseTimerDelegate");
            }

            internal static unsafe void Invoke(byte Delegate /*TODO: delegate FTimerDynamicDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FTimerDynamicDelegate Delegate
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_UnPauseTimerDelegate_ptr, new IntPtr(p)); ;
                 //TODO: delegate FTimerDynamicDelegate Delegate
            }
        }
        internal struct K2_UnPauseTimerHandle_method {
            static internal IntPtr K2_UnPauseTimerHandle_ptr;
            static K2_UnPauseTimerHandle_method() {
                K2_UnPauseTimerHandle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "K2_UnPauseTimerHandle");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, TimerHandle Handle) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TimerHandle*)(b+8)) = Handle;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, K2_UnPauseTimerHandle_ptr, new IntPtr(p)); ;
            }
        }
        internal struct LaunchURL_method {
            static internal IntPtr LaunchURL_ptr;
            static LaunchURL_method() {
                LaunchURL_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LaunchURL");
            }

            internal static unsafe void Invoke(string URL) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var URL_handle = GCHandle.Alloc(URL, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = URL_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = URL.Length;
                *(int*)(b+IntPtr.Size+4+0) = URL.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LaunchURL_ptr, new IntPtr(p)); ;
                URL_handle.Free();
            }
        }
        internal struct LineTraceMulti_method {
            static internal IntPtr LineTraceMulti_ptr;
            static LineTraceMulti_method() {
                LineTraceMulti_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LineTraceMulti");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *(b+32) = TraceChannel;
                *((bool*)(b+33)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+56) = DrawDebugType;
                *((bool*)(b+80)) = bIgnoreSelf;
                *((LinearColor*)(b+84)) = TraceColor;
                *((LinearColor*)(b+100)) = TraceHitColor;
                *((float*)(b+116)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LineTraceMulti_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+64),*((bool*)(b+120)));
            }
        }
        internal struct LineTraceMultiByProfile_method {
            static internal IntPtr LineTraceMultiByProfile_ptr;
            static LineTraceMultiByProfile_method() {
                LineTraceMultiByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LineTraceMultiByProfile");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Name*)(b+32)) = ProfileName;
                *((bool*)(b+44)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+64) = DrawDebugType;
                *((bool*)(b+88)) = bIgnoreSelf;
                *((LinearColor*)(b+92)) = TraceColor;
                *((LinearColor*)(b+108)) = TraceHitColor;
                *((float*)(b+124)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LineTraceMultiByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+72),*((bool*)(b+128)));
            }
        }
        internal struct LineTraceMultiForObjects_method {
            static internal IntPtr LineTraceMultiForObjects_ptr;
            static LineTraceMultiForObjects_method() {
                LineTraceMultiForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LineTraceMultiForObjects");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+48)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+72) = DrawDebugType;
                *((bool*)(b+96)) = bIgnoreSelf;
                *((LinearColor*)(b+100)) = TraceColor;
                *((LinearColor*)(b+116)) = TraceHitColor;
                *((float*)(b+132)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LineTraceMultiForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+80),*((bool*)(b+136)));
            }
        }
        internal struct LineTraceSingle_method {
            static internal IntPtr LineTraceSingle_ptr;
            static LineTraceSingle_method() {
                LineTraceSingle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LineTraceSingle");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *(b+32) = TraceChannel;
                *((bool*)(b+33)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+56) = DrawDebugType;
                *((bool*)(b+204)) = bIgnoreSelf;
                *((LinearColor*)(b+208)) = TraceColor;
                *((LinearColor*)(b+224)) = TraceHitColor;
                *((float*)(b+240)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LineTraceSingle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+60)),*((bool*)(b+244)));
            }
        }
        internal struct LineTraceSingleByProfile_method {
            static internal IntPtr LineTraceSingleByProfile_ptr;
            static LineTraceSingleByProfile_method() {
                LineTraceSingleByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LineTraceSingleByProfile");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((Name*)(b+32)) = ProfileName;
                *((bool*)(b+44)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+64) = DrawDebugType;
                *((bool*)(b+212)) = bIgnoreSelf;
                *((LinearColor*)(b+216)) = TraceColor;
                *((LinearColor*)(b+232)) = TraceHitColor;
                *((float*)(b+248)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LineTraceSingleByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+68)),*((bool*)(b+252)));
            }
        }
        internal struct LineTraceSingleForObjects_method {
            static internal IntPtr LineTraceSingleForObjects_ptr;
            static LineTraceSingleForObjects_method() {
                LineTraceSingleForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LineTraceSingleForObjects");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+48)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+72) = DrawDebugType;
                *((bool*)(b+220)) = bIgnoreSelf;
                *((LinearColor*)(b+224)) = TraceColor;
                *((LinearColor*)(b+240)) = TraceHitColor;
                *((float*)(b+256)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LineTraceSingleForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+76)),*((bool*)(b+260)));
            }
        }
        internal struct LoadAsset_method {
            static internal IntPtr LoadAsset_ptr;
            static LoadAsset_method() {
                LoadAsset_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LoadAsset");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, byte Asset /*TODO: soft object TSoftObjectPtr<UObject> */, byte OnLoaded /*TODO: delegate FOnAssetLoaded */, LatentActionInfo LatentInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> Asset
                throw new NotImplementedException(); //TODO: delegate FOnAssetLoaded OnLoaded
                *((LatentActionInfo*)(b+80)) = LatentInfo;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LoadAsset_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> Asset
                 //TODO: delegate FOnAssetLoaded OnLoaded
            }
        }
        internal struct LoadAssetClass_method {
            static internal IntPtr LoadAssetClass_ptr;
            static LoadAssetClass_method() {
                LoadAssetClass_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LoadAssetClass");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, byte AssetClass /*TODO: soft class TSoftClassPtr<UObject>  */, byte OnLoaded /*TODO: delegate FOnAssetClassLoaded */, LatentActionInfo LatentInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  AssetClass
                throw new NotImplementedException(); //TODO: delegate FOnAssetClassLoaded OnLoaded
                *((LatentActionInfo*)(b+80)) = LatentInfo;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LoadAssetClass_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  AssetClass
                 //TODO: delegate FOnAssetClassLoaded OnLoaded
            }
        }
        internal struct LoadInterstitialAd_method {
            static internal IntPtr LoadInterstitialAd_ptr;
            static LoadInterstitialAd_method() {
                LoadInterstitialAd_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "LoadInterstitialAd");
            }

            internal static unsafe void Invoke(int AdIdIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = AdIdIndex;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, LoadInterstitialAd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MakeLiteralBool_method {
            static internal IntPtr MakeLiteralBool_ptr;
            static MakeLiteralBool_method() {
                MakeLiteralBool_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeLiteralBool");
            }

            internal static unsafe bool Invoke(bool Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeLiteralBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct MakeLiteralByte_method {
            static internal IntPtr MakeLiteralByte_ptr;
            static MakeLiteralByte_method() {
                MakeLiteralByte_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeLiteralByte");
            }

            internal static unsafe byte Invoke(byte Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeLiteralByte_ptr, new IntPtr(p)); ;
                return *(b+1);
            }
        }
        internal struct MakeLiteralFloat_method {
            static internal IntPtr MakeLiteralFloat_ptr;
            static MakeLiteralFloat_method() {
                MakeLiteralFloat_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeLiteralFloat");
            }

            internal static unsafe float Invoke(float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeLiteralFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct MakeLiteralInt_method {
            static internal IntPtr MakeLiteralInt_ptr;
            static MakeLiteralInt_method() {
                MakeLiteralInt_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeLiteralInt");
            }

            internal static unsafe int Invoke(int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeLiteralInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct MakeLiteralName_method {
            static internal IntPtr MakeLiteralName_ptr;
            static MakeLiteralName_method() {
                MakeLiteralName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeLiteralName");
            }

            internal static unsafe Name Invoke(Name Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeLiteralName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+12));
            }
        }
        internal struct MakeLiteralString_method {
            static internal IntPtr MakeLiteralString_ptr;
            static MakeLiteralString_method() {
                MakeLiteralString_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeLiteralString");
            }

            internal static unsafe string Invoke(string Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Value_handle = GCHandle.Alloc(Value, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Value_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Value.Length;
                *(int*)(b+IntPtr.Size+4+0) = Value.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeLiteralString_ptr, new IntPtr(p)); ;
                Value_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct MakeLiteralText_method {
            static internal IntPtr MakeLiteralText_ptr;
            static MakeLiteralText_method() {
                MakeLiteralText_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeLiteralText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte Value /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText Value
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeLiteralText_ptr, new IntPtr(p)); ;
                 //TODO: text FText Value
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct MakeSoftClassPath_method {
            static internal IntPtr MakeSoftClassPath_ptr;
            static MakeSoftClassPath_method() {
                MakeSoftClassPath_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeSoftClassPath");
            }

            internal static unsafe SoftClassPath Invoke(string PathString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var PathString_handle = GCHandle.Alloc(PathString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = PathString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = PathString.Length;
                *(int*)(b+IntPtr.Size+4+0) = PathString.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeSoftClassPath_ptr, new IntPtr(p)); ;
                PathString_handle.Free();
                return *((SoftClassPath*)(b+16));
            }
        }
        internal struct MakeSoftObjectPath_method {
            static internal IntPtr MakeSoftObjectPath_ptr;
            static MakeSoftObjectPath_method() {
                MakeSoftObjectPath_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MakeSoftObjectPath");
            }

            internal static unsafe SoftObjectPath Invoke(string PathString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var PathString_handle = GCHandle.Alloc(PathString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = PathString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = PathString.Length;
                *(int*)(b+IntPtr.Size+4+0) = PathString.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MakeSoftObjectPath_ptr, new IntPtr(p)); ;
                PathString_handle.Free();
                return *((SoftObjectPath*)(b+16));
            }
        }
        internal struct MoveComponentTo_method {
            static internal IntPtr MoveComponentTo_ptr;
            static MoveComponentTo_method() {
                MoveComponentTo_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "MoveComponentTo");
            }

            internal static unsafe void Invoke(SceneComponent Component, Vector TargetRelativeLocation, Rotator TargetRelativeRotation, bool bEaseOut, bool bEaseIn, float OverTime, bool bForceShortestRotationPath, byte MoveAction, LatentActionInfo LatentInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                *((Vector*)(b+8)) = TargetRelativeLocation;
                *((Rotator*)(b+20)) = TargetRelativeRotation;
                *((bool*)(b+32)) = bEaseOut;
                *((bool*)(b+33)) = bEaseIn;
                *((float*)(b+36)) = OverTime;
                *((bool*)(b+40)) = bForceShortestRotationPath;
                *(b+41) = MoveAction;
                *((LatentActionInfo*)(b+48)) = LatentInfo;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, MoveComponentTo_ptr, new IntPtr(p)); ;
            }
        }
        internal struct NormalizeFilename_method {
            static internal IntPtr NormalizeFilename_ptr;
            static NormalizeFilename_method() {
                NormalizeFilename_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "NormalizeFilename");
            }

            internal static unsafe string Invoke(string InFilename) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InFilename_handle = GCHandle.Alloc(InFilename, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InFilename_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InFilename.Length;
                *(int*)(b+IntPtr.Size+4+0) = InFilename.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, NormalizeFilename_ptr, new IntPtr(p)); ;
                InFilename_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct NotEqual_PrimaryAssetId_method {
            static internal IntPtr NotEqual_PrimaryAssetId_ptr;
            static NotEqual_PrimaryAssetId_method() {
                NotEqual_PrimaryAssetId_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "NotEqual_PrimaryAssetId");
            }

            internal static unsafe bool Invoke(PrimaryAssetId A, PrimaryAssetId B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = A;
                *((PrimaryAssetId*)(b+24)) = B;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, NotEqual_PrimaryAssetId_ptr, new IntPtr(p)); ;
                return *((bool*)(b+48));
            }
        }
        internal struct NotEqual_PrimaryAssetType_method {
            static internal IntPtr NotEqual_PrimaryAssetType_ptr;
            static NotEqual_PrimaryAssetType_method() {
                NotEqual_PrimaryAssetType_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "NotEqual_PrimaryAssetType");
            }

            internal static unsafe bool Invoke(PrimaryAssetType A, PrimaryAssetType B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetType*)(b+0)) = A;
                *((PrimaryAssetType*)(b+12)) = B;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, NotEqual_PrimaryAssetType_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct NotEqual_SoftClassReference_method {
            static internal IntPtr NotEqual_SoftClassReference_ptr;
            static NotEqual_SoftClassReference_method() {
                NotEqual_SoftClassReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "NotEqual_SoftClassReference");
            }

            internal static unsafe bool Invoke(byte A /*TODO: soft class TSoftClassPtr<UObject>  */, byte B /*TODO: soft class TSoftClassPtr<UObject>  */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  A
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  B
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, NotEqual_SoftClassReference_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  A
                 //TODO: soft class TSoftClassPtr<UObject>  B
                return *((bool*)(b+96));
            }
        }
        internal struct NotEqual_SoftObjectReference_method {
            static internal IntPtr NotEqual_SoftObjectReference_ptr;
            static NotEqual_SoftObjectReference_method() {
                NotEqual_SoftObjectReference_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "NotEqual_SoftObjectReference");
            }

            internal static unsafe bool Invoke(byte A /*TODO: soft object TSoftObjectPtr<UObject> */, byte B /*TODO: soft object TSoftObjectPtr<UObject> */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> A
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> B
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, NotEqual_SoftObjectReference_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> A
                 //TODO: soft object TSoftObjectPtr<UObject> B
                return *((bool*)(b+96));
            }
        }
        internal struct PrintString_method {
            static internal IntPtr PrintString_ptr;
            static PrintString_method() {
                PrintString_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "PrintString");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, string InString, bool bPrintToScreen, bool bPrintToLog, LinearColor TextColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = InString.Length;
                *(int*)(b+IntPtr.Size+4+8) = InString.Length;
                *((bool*)(b+24)) = bPrintToScreen;
                *((bool*)(b+25)) = bPrintToLog;
                *((LinearColor*)(b+28)) = TextColor;
                *((float*)(b+44)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, PrintString_ptr, new IntPtr(p)); ;
                InString_handle.Free();
            }
        }
        internal struct PrintText_method {
            static internal IntPtr PrintText_ptr;
            static PrintText_method() {
                PrintText_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "PrintText");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, byte InText /*TODO: text FText */, bool bPrintToScreen, bool bPrintToLog, LinearColor TextColor, float Duration) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: text FText InText
                *((bool*)(b+32)) = bPrintToScreen;
                *((bool*)(b+33)) = bPrintToLog;
                *((LinearColor*)(b+36)) = TextColor;
                *((float*)(b+52)) = Duration;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, PrintText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
            }
        }
        internal struct PrintWarning_method {
            static internal IntPtr PrintWarning_ptr;
            static PrintWarning_method() {
                PrintWarning_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "PrintWarning");
            }

            internal static unsafe void Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, PrintWarning_ptr, new IntPtr(p)); ;
                InString_handle.Free();
            }
        }
        internal struct QuitGame_method {
            static internal IntPtr QuitGame_ptr;
            static QuitGame_method() {
                QuitGame_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "QuitGame");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, PlayerController SpecificPlayer, byte QuitPreference, bool bIgnorePlatformRestrictions) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = SpecificPlayer;
                *(b+16) = QuitPreference;
                *((bool*)(b+17)) = bIgnorePlatformRestrictions;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, QuitGame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RegisterForRemoteNotifications_method {
            static internal IntPtr RegisterForRemoteNotifications_ptr;
            static RegisterForRemoteNotifications_method() {
                RegisterForRemoteNotifications_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "RegisterForRemoteNotifications");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, RegisterForRemoteNotifications_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetGamepadAssignments_method {
            static internal IntPtr ResetGamepadAssignments_ptr;
            static ResetGamepadAssignments_method() {
                ResetGamepadAssignments_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ResetGamepadAssignments");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ResetGamepadAssignments_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetGamepadAssignmentToController_method {
            static internal IntPtr ResetGamepadAssignmentToController_ptr;
            static ResetGamepadAssignmentToController_method() {
                ResetGamepadAssignmentToController_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ResetGamepadAssignmentToController");
            }

            internal static unsafe void Invoke(int ControllerId) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ControllerId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ResetGamepadAssignmentToController_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RetriggerableDelay_method {
            static internal IntPtr RetriggerableDelay_ptr;
            static RetriggerableDelay_method() {
                RetriggerableDelay_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "RetriggerableDelay");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, float Duration, LatentActionInfo LatentInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = Duration;
                *((LatentActionInfo*)(b+16)) = LatentInfo;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, RetriggerableDelay_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoolPropertyByName_method {
            static internal IntPtr SetBoolPropertyByName_ptr;
            static SetBoolPropertyByName_method() {
                SetBoolPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetBoolPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, bool Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((bool*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetBoolPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBytePropertyByName_method {
            static internal IntPtr SetBytePropertyByName_ptr;
            static SetBytePropertyByName_method() {
                SetBytePropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetBytePropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *(b+20) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetBytePropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetClassPropertyByName_method {
            static internal IntPtr SetClassPropertyByName_ptr;
            static SetClassPropertyByName_method() {
                SetClassPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetClassPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, SubclassOf<UObject> Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((IntPtr*)(b+24)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetClassPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCollisionProfileNameProperty_method {
            static internal IntPtr SetCollisionProfileNameProperty_ptr;
            static SetCollisionProfileNameProperty_method() {
                SetCollisionProfileNameProperty_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetCollisionProfileNameProperty");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, CollisionProfileName Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((CollisionProfileName*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetCollisionProfileNameProperty_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFloatPropertyByName_method {
            static internal IntPtr SetFloatPropertyByName_ptr;
            static SetFloatPropertyByName_method() {
                SetFloatPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetFloatPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, float Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((float*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetFloatPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInterfacePropertyByName_method {
            static internal IntPtr SetInterfacePropertyByName_ptr;
            static SetInterfacePropertyByName_method() {
                SetInterfacePropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetInterfacePropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value /*TODO: interface TScriptInterface */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                throw new NotImplementedException(); //TODO: interface TScriptInterface Value
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetInterfacePropertyByName_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface Value
            }
        }
        internal struct SetIntPropertyByName_method {
            static internal IntPtr SetIntPropertyByName_ptr;
            static SetIntPropertyByName_method() {
                SetIntPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetIntPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, int Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((int*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetIntPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearColorPropertyByName_method {
            static internal IntPtr SetLinearColorPropertyByName_ptr;
            static SetLinearColorPropertyByName_method() {
                SetLinearColorPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetLinearColorPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, LinearColor Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((LinearColor*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetLinearColorPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNamePropertyByName_method {
            static internal IntPtr SetNamePropertyByName_ptr;
            static SetNamePropertyByName_method() {
                SetNamePropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetNamePropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, Name Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((Name*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetNamePropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetObjectPropertyByName_method {
            static internal IntPtr SetObjectPropertyByName_ptr;
            static SetObjectPropertyByName_method() {
                SetObjectPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetObjectPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, UObject Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((IntPtr*)(b+24)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetObjectPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRotatorPropertyByName_method {
            static internal IntPtr SetRotatorPropertyByName_ptr;
            static SetRotatorPropertyByName_method() {
                SetRotatorPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetRotatorPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, Rotator Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((Rotator*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetRotatorPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSoftClassPropertyByName_method {
            static internal IntPtr SetSoftClassPropertyByName_ptr;
            static SetSoftClassPropertyByName_method() {
                SetSoftClassPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetSoftClassPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value /*TODO: soft class TSoftClassPtr<UObject>  */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                throw new NotImplementedException(); //TODO: soft class TSoftClassPtr<UObject>  Value
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetSoftClassPropertyByName_ptr, new IntPtr(p)); ;
                 //TODO: soft class TSoftClassPtr<UObject>  Value
            }
        }
        internal struct SetSoftObjectPropertyByName_method {
            static internal IntPtr SetSoftObjectPropertyByName_ptr;
            static SetSoftObjectPropertyByName_method() {
                SetSoftObjectPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetSoftObjectPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value /*TODO: soft object TSoftObjectPtr<UObject> */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                throw new NotImplementedException(); //TODO: soft object TSoftObjectPtr<UObject> Value
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetSoftObjectPropertyByName_ptr, new IntPtr(p)); ;
                 //TODO: soft object TSoftObjectPtr<UObject> Value
            }
        }
        internal struct SetStringPropertyByName_method {
            static internal IntPtr SetStringPropertyByName_ptr;
            static SetStringPropertyByName_method() {
                SetStringPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetStringPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, string Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                var Value_handle = GCHandle.Alloc(Value, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = Value_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = Value.Length;
                *(int*)(b+IntPtr.Size+4+24) = Value.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetStringPropertyByName_ptr, new IntPtr(p)); ;
                Value_handle.Free();
            }
        }
        internal struct SetStructurePropertyByName_method {
            static internal IntPtr SetStructurePropertyByName_ptr;
            static SetStructurePropertyByName_method() {
                SetStructurePropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetStructurePropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, GenericStruct Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((GenericStruct*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetStructurePropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSuppressViewportTransitionMessage_method {
            static internal IntPtr SetSuppressViewportTransitionMessage_ptr;
            static SetSuppressViewportTransitionMessage_method() {
                SetSuppressViewportTransitionMessage_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetSuppressViewportTransitionMessage");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, bool bState) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((bool*)(b+8)) = bState;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetSuppressViewportTransitionMessage_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTextPropertyByName_method {
            static internal IntPtr SetTextPropertyByName_ptr;
            static SetTextPropertyByName_method() {
                SetTextPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetTextPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                throw new NotImplementedException(); //TODO: text FText Value
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetTextPropertyByName_ptr, new IntPtr(p)); ;
                 //TODO: text FText Value
            }
        }
        internal struct SetTransformPropertyByName_method {
            static internal IntPtr SetTransformPropertyByName_ptr;
            static SetTransformPropertyByName_method() {
                SetTransformPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetTransformPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, Transform Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((Transform*)(b+32)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetTransformPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUserActivity_method {
            static internal IntPtr SetUserActivity_ptr;
            static SetUserActivity_method() {
                SetUserActivity_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetUserActivity");
            }

            internal static unsafe void Invoke(UserActivity UserActivity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((UserActivity*)(b+0)) = UserActivity;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetUserActivity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVectorPropertyByName_method {
            static internal IntPtr SetVectorPropertyByName_ptr;
            static SetVectorPropertyByName_method() {
                SetVectorPropertyByName_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetVectorPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, Vector Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                *((Vector*)(b+20)) = Value;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetVectorPropertyByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumeButtonsHandledBySystem_method {
            static internal IntPtr SetVolumeButtonsHandledBySystem_ptr;
            static SetVolumeButtonsHandledBySystem_method() {
                SetVolumeButtonsHandledBySystem_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetVolumeButtonsHandledBySystem");
            }

            internal static unsafe void Invoke(bool bEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnabled;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetVolumeButtonsHandledBySystem_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWindowTitle_method {
            static internal IntPtr SetWindowTitle_ptr;
            static SetWindowTitle_method() {
                SetWindowTitle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SetWindowTitle");
            }

            internal static unsafe void Invoke(byte Title /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText Title
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SetWindowTitle_ptr, new IntPtr(p)); ;
                 //TODO: text FText Title
            }
        }
        internal struct ShowAdBanner_method {
            static internal IntPtr ShowAdBanner_ptr;
            static ShowAdBanner_method() {
                ShowAdBanner_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ShowAdBanner");
            }

            internal static unsafe void Invoke(int AdIdIndex, bool bShowOnBottomOfScreen) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = AdIdIndex;
                *((bool*)(b+4)) = bShowOnBottomOfScreen;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ShowAdBanner_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowInterstitialAd_method {
            static internal IntPtr ShowInterstitialAd_ptr;
            static ShowInterstitialAd_method() {
                ShowInterstitialAd_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ShowInterstitialAd");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ShowInterstitialAd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowPlatformSpecificAchievementsScreen_method {
            static internal IntPtr ShowPlatformSpecificAchievementsScreen_ptr;
            static ShowPlatformSpecificAchievementsScreen_method() {
                ShowPlatformSpecificAchievementsScreen_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ShowPlatformSpecificAchievementsScreen");
            }

            internal static unsafe void Invoke(PlayerController SpecificPlayer) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SpecificPlayer;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ShowPlatformSpecificAchievementsScreen_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowPlatformSpecificLeaderboardScreen_method {
            static internal IntPtr ShowPlatformSpecificLeaderboardScreen_ptr;
            static ShowPlatformSpecificLeaderboardScreen_method() {
                ShowPlatformSpecificLeaderboardScreen_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "ShowPlatformSpecificLeaderboardScreen");
            }

            internal static unsafe void Invoke(string CategoryName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var CategoryName_handle = GCHandle.Alloc(CategoryName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = CategoryName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = CategoryName.Length;
                *(int*)(b+IntPtr.Size+4+0) = CategoryName.Length;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, ShowPlatformSpecificLeaderboardScreen_ptr, new IntPtr(p)); ;
                CategoryName_handle.Free();
            }
        }
        internal struct SphereOverlapActors_method {
            static internal IntPtr SphereOverlapActors_ptr;
            static SphereOverlapActors_method() {
                SphereOverlapActors_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereOverlapActors");
            }

            internal static unsafe (IReadOnlyCollection<Actor>, bool) Invoke(UObject WorldContextObject, Vector SpherePos, float SphereRadius, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = SpherePos;
                *((float*)(b+20)) = SphereRadius;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+40)) = ActorClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereOverlapActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutActors
                return (UObject.ToUObjectCollection<Actor>(b+64),*((bool*)(b+80)));
            }
        }
        internal struct SphereOverlapComponents_method {
            static internal IntPtr SphereOverlapComponents_ptr;
            static SphereOverlapComponents_method() {
                SphereOverlapComponents_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereOverlapComponents");
            }

            internal static unsafe (IReadOnlyCollection<PrimitiveComponent>, bool) Invoke(UObject WorldContextObject, Vector SpherePos, float SphereRadius, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = SpherePos;
                *((float*)(b+20)) = SphereRadius;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((IntPtr*)(b+40)) = ComponentClassFilter;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereOverlapComponents_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutComponents
                return (UObject.ToUObjectCollection<PrimitiveComponent>(b+64),*((bool*)(b+80)));
            }
        }
        internal struct SphereTraceMulti_method {
            static internal IntPtr SphereTraceMulti_ptr;
            static SphereTraceMulti_method() {
                SphereTraceMulti_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereTraceMulti");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *(b+36) = TraceChannel;
                *((bool*)(b+37)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+56) = DrawDebugType;
                *((bool*)(b+80)) = bIgnoreSelf;
                *((LinearColor*)(b+84)) = TraceColor;
                *((LinearColor*)(b+100)) = TraceHitColor;
                *((float*)(b+116)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereTraceMulti_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+64),*((bool*)(b+120)));
            }
        }
        internal struct SphereTraceMultiByProfile_method {
            static internal IntPtr SphereTraceMultiByProfile_ptr;
            static SphereTraceMultiByProfile_method() {
                SphereTraceMultiByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereTraceMultiByProfile");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((Name*)(b+36)) = ProfileName;
                *((bool*)(b+48)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+72) = DrawDebugType;
                *((bool*)(b+96)) = bIgnoreSelf;
                *((LinearColor*)(b+100)) = TraceColor;
                *((LinearColor*)(b+116)) = TraceHitColor;
                *((float*)(b+132)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereTraceMultiByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+80),*((bool*)(b+136)));
            }
        }
        internal struct SphereTraceMultiForObjects_method {
            static internal IntPtr SphereTraceMultiForObjects_ptr;
            static SphereTraceMultiForObjects_method() {
                SphereTraceMultiForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereTraceMultiForObjects");
            }

            internal static unsafe (IReadOnlyCollection<HitResult>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+56)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+80) = DrawDebugType;
                *((bool*)(b+104)) = bIgnoreSelf;
                *((LinearColor*)(b+108)) = TraceColor;
                *((LinearColor*)(b+124)) = TraceHitColor;
                *((float*)(b+140)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereTraceMultiForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                 //TODO: array TArray OutHits
                return (UObject.ToUnmangedCollection<HitResult>(b+88),*((bool*)(b+144)));
            }
        }
        internal struct SphereTraceSingle_method {
            static internal IntPtr SphereTraceSingle_ptr;
            static SphereTraceSingle_method() {
                SphereTraceSingle_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereTraceSingle");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *(b+36) = TraceChannel;
                *((bool*)(b+37)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+56) = DrawDebugType;
                *((bool*)(b+204)) = bIgnoreSelf;
                *((LinearColor*)(b+208)) = TraceColor;
                *((LinearColor*)(b+224)) = TraceHitColor;
                *((float*)(b+240)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereTraceSingle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+60)),*((bool*)(b+244)));
            }
        }
        internal struct SphereTraceSingleByProfile_method {
            static internal IntPtr SphereTraceSingleByProfile_ptr;
            static SphereTraceSingleByProfile_method() {
                SphereTraceSingleByProfile_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereTraceSingleByProfile");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                *((Name*)(b+36)) = ProfileName;
                *((bool*)(b+48)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+72) = DrawDebugType;
                *((bool*)(b+220)) = bIgnoreSelf;
                *((LinearColor*)(b+224)) = TraceColor;
                *((LinearColor*)(b+240)) = TraceHitColor;
                *((float*)(b+256)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereTraceSingleByProfile_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+76)),*((bool*)(b+260)));
            }
        }
        internal struct SphereTraceSingleForObjects_method {
            static internal IntPtr SphereTraceSingleForObjects_ptr;
            static SphereTraceSingleForObjects_method() {
                SphereTraceSingleForObjects_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "SphereTraceSingleForObjects");
            }

            internal static unsafe (HitResult, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                *((float*)(b+32)) = Radius;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+56)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *(b+80) = DrawDebugType;
                *((bool*)(b+228)) = bIgnoreSelf;
                *((LinearColor*)(b+232)) = TraceColor;
                *((LinearColor*)(b+248)) = TraceHitColor;
                *((float*)(b+264)) = DrawTime;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, SphereTraceSingleForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                return (*((HitResult*)(b+84)),*((bool*)(b+268)));
            }
        }
        internal struct StackTrace_method {
            static internal IntPtr StackTrace_ptr;
            static StackTrace_method() {
                StackTrace_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "StackTrace");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, StackTrace_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TransactObject_method {
            static internal IntPtr TransactObject_ptr;
            static TransactObject_method() {
                TransactObject_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "TransactObject");
            }

            internal static unsafe void Invoke(UObject UObject) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, TransactObject_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnloadPrimaryAsset_method {
            static internal IntPtr UnloadPrimaryAsset_ptr;
            static UnloadPrimaryAsset_method() {
                UnloadPrimaryAsset_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "UnloadPrimaryAsset");
            }

            internal static unsafe void Invoke(PrimaryAssetId PrimaryAssetId) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PrimaryAssetId*)(b+0)) = PrimaryAssetId;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, UnloadPrimaryAsset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnloadPrimaryAssetList_method {
            static internal IntPtr UnloadPrimaryAssetList_ptr;
            static UnloadPrimaryAssetList_method() {
                UnloadPrimaryAssetList_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "UnloadPrimaryAssetList");
            }

            internal static unsafe void Invoke(byte PrimaryAssetIdList /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray PrimaryAssetIdList
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, UnloadPrimaryAssetList_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PrimaryAssetIdList
            }
        }
        internal struct UnregisterForRemoteNotifications_method {
            static internal IntPtr UnregisterForRemoteNotifications_ptr;
            static UnregisterForRemoteNotifications_method() {
                UnregisterForRemoteNotifications_ptr = Main.GetMethodUFunction(KismetSystemLibrary.StaticClass, "UnregisterForRemoteNotifications");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetSystemLibrary.DefaultObject, UnregisterForRemoteNotifications_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct KismetSystemLibrary_events {
    }
}
