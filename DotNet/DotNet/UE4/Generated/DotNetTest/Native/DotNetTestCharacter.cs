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


namespace UE4.DotNetTest.Native {
    [StructLayout( LayoutKind.Explicit, Size=2208 )]
    internal unsafe struct DotNetTestCharacter_fields {
        [FieldOffset(2064)]  public IntPtr  Mesh1P;
        [FieldOffset(2072)]  public IntPtr  FP_Gun;
        [FieldOffset(2080)]  public IntPtr  FP_MuzzleLocation;
        [FieldOffset(2088)]  public IntPtr  VR_Gun;
        [FieldOffset(2096)]  public IntPtr  VR_MuzzleLocation;
        [FieldOffset(2104)]  public IntPtr  FirstPersonCameraComponent;
        [FieldOffset(2112)]  public IntPtr  R_MotionController;
        [FieldOffset(2120)]  public IntPtr  L_MotionController;
        ///<summary>Base turn rate, in deg/sec. Other scaling may affect final turn rate.</summary>
        [FieldOffset(2128)] public float BaseTurnRate;
        ///<summary>Base look up/down rate, in deg/sec. Other scaling may affect final rate.</summary>
        [FieldOffset(2132)] public float BaseLookUpRate;
        [FieldOffset(2136)] byte GunOffset; //TODO: struct FVector GunOffset
        ///<summary>Projectile class to spawn</summary>
        [FieldOffset(2152)] public IntPtr ProjectileClass;
        [FieldOffset(2160)]  public IntPtr  FireSound;
        [FieldOffset(2168)]  public IntPtr  FireAnimation;
        ///<summary>Whether to use motion controller location for aiming.</summary>
        [FieldOffset(2176)] public bool bUsingMotionControllers;
    }
    internal unsafe struct DotNetTestCharacter_methods {
    }
    internal unsafe struct DotNetTestCharacter_events {
    }
}
