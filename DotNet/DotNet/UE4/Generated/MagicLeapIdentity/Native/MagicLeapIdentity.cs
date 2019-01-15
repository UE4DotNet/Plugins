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


namespace UE4.MagicLeapIdentity.Native {
    [StructLayout( LayoutKind.Explicit, Size=72 )]
    internal unsafe struct MagicLeapIdentity_fields {
    }
    internal unsafe struct MagicLeapIdentity_methods {
        internal struct GetAllAvailableAttributes_method {
            static internal IntPtr GetAllAvailableAttributes_ptr;
            static GetAllAvailableAttributes_method() {
                GetAllAvailableAttributes_ptr = Main.GetMethodUFunction(MagicLeapIdentity.StaticClass, "GetAllAvailableAttributes");
            }

            internal static unsafe (IReadOnlyCollection<EMagicLeapIdentityAttribute>, EMagicLeapIdentityError) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAllAvailableAttributes_ptr, new IntPtr(p)); ;
                 //TODO: array TArray AvailableAttributes
                return (UObject.ToUnmangedCollection<EMagicLeapIdentityAttribute>(b+0),*((EMagicLeapIdentityError*)(b+16)));
            }
        }
        internal struct GetAllAvailableAttributesAsync_method {
            static internal IntPtr GetAllAvailableAttributesAsync_ptr;
            static GetAllAvailableAttributesAsync_method() {
                GetAllAvailableAttributesAsync_ptr = Main.GetMethodUFunction(MagicLeapIdentity.StaticClass, "GetAllAvailableAttributesAsync");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ResultDelegate /*TODO: delegate FAvailableIdentityAttributesDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FAvailableIdentityAttributesDelegate ResultDelegate
                Main.GetProcessEvent(obj, GetAllAvailableAttributesAsync_ptr, new IntPtr(p)); ;
                 //TODO: delegate FAvailableIdentityAttributesDelegate ResultDelegate
            }
        }
        internal struct ModifyAttributeValue_method {
            static internal IntPtr ModifyAttributeValue_ptr;
            static ModifyAttributeValue_method() {
                ModifyAttributeValue_ptr = Main.GetMethodUFunction(MagicLeapIdentity.StaticClass, "ModifyAttributeValue");
            }

            internal static unsafe (IReadOnlyCollection<EMagicLeapIdentityAttribute>, EMagicLeapIdentityError) Invoke(IntPtr obj, byte UpdatedAttributeValueList /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray UpdatedAttributeValueList
                Main.GetProcessEvent(obj, ModifyAttributeValue_ptr, new IntPtr(p)); ;
                 //TODO: array TArray UpdatedAttributeValueList
                 //TODO: array TArray AttributesUpdatedSuccessfully
                return (UObject.ToUnmangedCollection<EMagicLeapIdentityAttribute>(b+16),*((EMagicLeapIdentityError*)(b+32)));
            }
        }
        internal struct ModifyAttributeValueAsync_method {
            static internal IntPtr ModifyAttributeValueAsync_ptr;
            static ModifyAttributeValueAsync_method() {
                ModifyAttributeValueAsync_ptr = Main.GetMethodUFunction(MagicLeapIdentity.StaticClass, "ModifyAttributeValueAsync");
            }

            internal static unsafe EMagicLeapIdentityError Invoke(IntPtr obj, byte UpdatedAttributeValueList /*TODO: array TArray */, byte ResultDelegate /*TODO: delegate FModifyIdentityAttributeValueDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray UpdatedAttributeValueList
                throw new NotImplementedException(); //TODO: delegate FModifyIdentityAttributeValueDelegate ResultDelegate
                Main.GetProcessEvent(obj, ModifyAttributeValueAsync_ptr, new IntPtr(p)); ;
                 //TODO: array TArray UpdatedAttributeValueList
                 //TODO: delegate FModifyIdentityAttributeValueDelegate ResultDelegate
                return *((EMagicLeapIdentityError*)(b+36));
            }
        }
        internal struct RequestAttributeValue_method {
            static internal IntPtr RequestAttributeValue_ptr;
            static RequestAttributeValue_method() {
                RequestAttributeValue_ptr = Main.GetMethodUFunction(MagicLeapIdentity.StaticClass, "RequestAttributeValue");
            }

            internal static unsafe (IReadOnlyCollection<MagicLeapIdentityAttribute>, EMagicLeapIdentityError) Invoke(IntPtr obj, byte RequestedAttributeList /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray RequestedAttributeList
                Main.GetProcessEvent(obj, RequestAttributeValue_ptr, new IntPtr(p)); ;
                 //TODO: array TArray RequestedAttributeList
                 //TODO: array TArray RequestedAttributeValues
                return (UObject.ToUnmangedCollection<MagicLeapIdentityAttribute>(b+16),*((EMagicLeapIdentityError*)(b+32)));
            }
        }
        internal struct RequestAttributeValueAsync_method {
            static internal IntPtr RequestAttributeValueAsync_ptr;
            static RequestAttributeValueAsync_method() {
                RequestAttributeValueAsync_ptr = Main.GetMethodUFunction(MagicLeapIdentity.StaticClass, "RequestAttributeValueAsync");
            }

            internal static unsafe EMagicLeapIdentityError Invoke(IntPtr obj, byte RequestedAttributeList /*TODO: array TArray */, byte ResultDelegate /*TODO: delegate FRequestIdentityAttributeValueDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray RequestedAttributeList
                throw new NotImplementedException(); //TODO: delegate FRequestIdentityAttributeValueDelegate ResultDelegate
                Main.GetProcessEvent(obj, RequestAttributeValueAsync_ptr, new IntPtr(p)); ;
                 //TODO: array TArray RequestedAttributeList
                 //TODO: delegate FRequestIdentityAttributeValueDelegate ResultDelegate
                return *((EMagicLeapIdentityError*)(b+36));
            }
        }
    }
    internal unsafe struct MagicLeapIdentity_events {
    }
}
