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

namespace UE4.Engine {
    ///<summary>All the types of delegate callbacks that a CloudStorage subclass may receive from C++</summary>
    public enum ECloudStorageDelegate {
        CSD_KeyValueReadComplete = 0x00000000, 
        CSD_KeyValueWriteComplete = 0x00000001, 
        CSD_ValueChanged = 0x00000002, 
        CSD_DocumentQueryComplete = 0x00000003, 
        CSD_DocumentReadComplete = 0x00000004, 
        CSD_DocumentWriteComplete = 0x00000005, 
        CSD_DocumentConflictDetected = 0x00000006, 
        CSD_MAX = 0x00000007
    }
}
