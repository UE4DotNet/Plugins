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


namespace UE4.UnrealEdMessages{
        ///<summary>Implements a message that is published by file servers when they're ready to accept connections.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct FileServerReady {
            [FieldOffset(0)] byte AddressList; //TODO: array TArray AddressList

            ///<summary>Holds the file server's application identifier.</summary>
            [FieldOffset(16)] FGuid InstanceId;

        }
}
