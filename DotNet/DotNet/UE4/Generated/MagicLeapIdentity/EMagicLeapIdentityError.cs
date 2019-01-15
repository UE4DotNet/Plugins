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

namespace UE4.MagicLeapIdentity {
    ///<summary>List of possible errors when calling the Identity functions.</summary>
    public enum EMagicLeapIdentityError {
        Ok = 0x00000000, 
        FailedToConnectToLocalService = 0x00000001, 
        FailedToConnectToCloudService = 0x00000002, 
        CloudAuthentication = 0x00000003, 
        InvalidInformationFromCloud = 0x00000004, 
        InvalidArgument = 0x00000005, 
        AsyncOperationNotComplete = 0x00000006, 
        OtherError = 0x00000007, 
        EMagicLeapIdentityError_MAX = 0x00000008
    }
}
