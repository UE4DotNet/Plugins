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
        InvalidParam = 0x00000001, 
        AllocFailed = 0x00000002, 
        PrivilegeDenied = 0x00000003, 
        FailedToConnectToLocalService = 0x00000004, 
        FailedToConnectToCloudService = 0x00000005, 
        CloudAuthentication = 0x00000006, 
        InvalidInformationFromCloud = 0x00000007, 
        NotLoggedIn = 0x00000008, 
        ExpiredCredentials = 0x00000009, 
        FailedToGetUserProfile = 0x0000000a, 
        Unauthorized = 0x0000000b, 
        CertificateError = 0x0000000c, 
        RejectedByCloud = 0x0000000d, 
        AlreadyLoggedIn = 0x0000000e, 
        ModifyIsNotSupported = 0x0000000f, 
        NetworkError = 0x00000010, 
        UnspecifiedFailure = 0x00000011, 
        EMagicLeapIdentityError_MAX = 0x00000012
    }
}
