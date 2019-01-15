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


namespace UE4.Engine{
        ///<summary>Replicated movement data of our RootComponent.</summary>
        ///<remarks>
        ///Struct used for efficient replication as velocity and location are generally replicated together (this saves a repindex)
        ///and velocity.Z is commonly zero (most position replications are for walking pawns).
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct RepMovement {
            ///<summary>Linear Velocity</summary>
            [FieldOffset(0)] Vector LinearVelocity;

            ///<summary>Angular Velocity</summary>
            [FieldOffset(12)] Vector AngularVelocity;

            ///<summary>Location</summary>
            [FieldOffset(24)] Vector Location;

            ///<summary>Rotation</summary>
            [FieldOffset(36)] Rotator Rotation;

            [FieldOffset(48)] public bool bSimulatedPhysicSleep;

            [FieldOffset(48)] public bool bRepPhysics;

            [FieldOffset(49)] byte LocationQuantizationLevel; //TODO: enum EVectorQuantization LocationQuantizationLevel

            [FieldOffset(50)] byte VelocityQuantizationLevel; //TODO: enum EVectorQuantization VelocityQuantizationLevel

            [FieldOffset(51)] byte RotationQuantizationLevel; //TODO: enum ERotatorQuantization RotationQuantizationLevel

        }
}
