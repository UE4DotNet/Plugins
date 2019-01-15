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


namespace UE4.EngineMessages{
        ///<summary>Implements a message for responding to a request to discover engine instances on the network.</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct EngineServicePong {
            [FieldOffset(0)] byte CurrentLevel; //TODO: string FString CurrentLevel

            [FieldOffset(16)] public int EngineVersion;

            [FieldOffset(20)] public bool HasBegunPlay;

            ///<summary>Holds the instance identifier.</summary>
            [FieldOffset(24)] FGuid InstanceId;

            [FieldOffset(40)] byte InstanceType; //TODO: string FString InstanceType

            ///<summary>Holds the identifier of the session that the application belongs to.</summary>
            [FieldOffset(56)] FGuid SessionId;

            [FieldOffset(72)] public float WorldTimeSeconds;

        }
}
