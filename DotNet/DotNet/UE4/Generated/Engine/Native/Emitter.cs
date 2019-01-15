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
    [StructLayout( LayoutKind.Explicit, Size=1104 )]
    internal unsafe struct Emitter_fields {
        [FieldOffset(1008)]  public IntPtr  ParticleSystemComponent;
        [FieldOffset(1016)] public bool bDestroyOnSystemFinish;
        [FieldOffset(1016)] public bool bPostUpdateTickGroup;
        [FieldOffset(1016)] public bool bCurrentlyActive;
        [FieldOffset(1024)] byte OnParticleSpawn; //TODO: multicast delegate FParticleSpawnSignature OnParticleSpawn
        [FieldOffset(1040)] byte OnParticleBurst; //TODO: multicast delegate FParticleBurstSignature OnParticleBurst
        [FieldOffset(1056)] byte OnParticleDeath; //TODO: multicast delegate FParticleDeathSignature OnParticleDeath
        [FieldOffset(1072)] byte OnParticleCollide; //TODO: multicast delegate FParticleCollisionSignature OnParticleCollide
        [FieldOffset(1088)]  public IntPtr  SpriteComponent;
        [FieldOffset(1096)]  public IntPtr  ArrowComponent;
    }
    internal unsafe struct Emitter_methods {
        internal struct Activate_method {
            static internal IntPtr Activate_ptr;
            static Activate_method() {
                Activate_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "Activate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Activate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Deactivate_method {
            static internal IntPtr Deactivate_ptr;
            static Deactivate_method() {
                Deactivate_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "Deactivate");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Deactivate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsActive_method {
            static internal IntPtr IsActive_ptr;
            static IsActive_method() {
                IsActive_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "IsActive");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetActorParameter_method {
            static internal IntPtr SetActorParameter_ptr;
            static SetActorParameter_method() {
                SetActorParameter_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "SetActorParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, Actor Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((IntPtr*)(b+16)) = Param;
                Main.GetProcessEvent(obj, SetActorParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetColorParameter_method {
            static internal IntPtr SetColorParameter_ptr;
            static SetColorParameter_method() {
                SetColorParameter_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "SetColorParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, LinearColor Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((LinearColor*)(b+12)) = Param;
                Main.GetProcessEvent(obj, SetColorParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFloatParameter_method {
            static internal IntPtr SetFloatParameter_ptr;
            static SetFloatParameter_method() {
                SetFloatParameter_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "SetFloatParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, float Param) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((float*)(b+12)) = Param;
                Main.GetProcessEvent(obj, SetFloatParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaterialParameter_method {
            static internal IntPtr SetMaterialParameter_ptr;
            static SetMaterialParameter_method() {
                SetMaterialParameter_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "SetMaterialParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, MaterialInterface Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((IntPtr*)(b+16)) = Param;
                Main.GetProcessEvent(obj, SetMaterialParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTemplate_method {
            static internal IntPtr SetTemplate_ptr;
            static SetTemplate_method() {
                SetTemplate_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "SetTemplate");
            }

            internal static unsafe void Invoke(IntPtr obj, ParticleSystem NewTemplate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewTemplate;
                Main.GetProcessEvent(obj, SetTemplate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVectorParameter_method {
            static internal IntPtr SetVectorParameter_ptr;
            static SetVectorParameter_method() {
                SetVectorParameter_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "SetVectorParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ParameterName, Vector Param) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ParameterName;
                *((Vector*)(b+12)) = Param;
                Main.GetProcessEvent(obj, SetVectorParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ToggleActive_method {
            static internal IntPtr ToggleActive_ptr;
            static ToggleActive_method() {
                ToggleActive_ptr = Main.GetMethodUFunction(Emitter.StaticClass, "ToggleActive");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ToggleActive_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Emitter_events {
    }
}
