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
    [StructLayout( LayoutKind.Explicit, Size=1904 )]
    internal unsafe struct SplineMeshComponent_fields {
        [FieldOffset(1752)] public SplineMeshParams SplineParams;
        [FieldOffset(1840)] public Vector SplineUpDir;
        [FieldOffset(1852)] public bool bAllowSplineEditingPerInstance;
        [FieldOffset(1852)] public bool bSmoothInterpRollScale;
        [FieldOffset(1856)] public byte ForwardAxis;
        [FieldOffset(1860)] public float SplineBoundaryMin;
        [FieldOffset(1864)] public float SplineBoundaryMax;
        [FieldOffset(1872)]  public IntPtr  BodySetup;
        [FieldOffset(1880)] public FGuid CachedMeshBodySetupGuid;
        [FieldOffset(1896)] public bool bSelected;
        [FieldOffset(1896)] public bool bMeshDirty;
    }
    internal unsafe struct SplineMeshComponent_methods {
        internal struct GetBoundaryMax_method {
            static internal IntPtr GetBoundaryMax_ptr;
            static GetBoundaryMax_method() {
                GetBoundaryMax_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetBoundaryMax");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBoundaryMax_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetBoundaryMin_method {
            static internal IntPtr GetBoundaryMin_ptr;
            static GetBoundaryMin_method() {
                GetBoundaryMin_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetBoundaryMin");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBoundaryMin_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetEndOffset_method {
            static internal IntPtr GetEndOffset_ptr;
            static GetEndOffset_method() {
                GetEndOffset_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetEndOffset");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEndOffset_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetEndPosition_method {
            static internal IntPtr GetEndPosition_ptr;
            static GetEndPosition_method() {
                GetEndPosition_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetEndPosition");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEndPosition_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetEndRoll_method {
            static internal IntPtr GetEndRoll_ptr;
            static GetEndRoll_method() {
                GetEndRoll_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetEndRoll");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEndRoll_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetEndScale_method {
            static internal IntPtr GetEndScale_ptr;
            static GetEndScale_method() {
                GetEndScale_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetEndScale");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEndScale_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetEndTangent_method {
            static internal IntPtr GetEndTangent_ptr;
            static GetEndTangent_method() {
                GetEndTangent_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetEndTangent");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEndTangent_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetForwardAxis_method {
            static internal IntPtr GetForwardAxis_ptr;
            static GetForwardAxis_method() {
                GetForwardAxis_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetForwardAxis");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetForwardAxis_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetSplineUpDir_method {
            static internal IntPtr GetSplineUpDir_ptr;
            static GetSplineUpDir_method() {
                GetSplineUpDir_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetSplineUpDir");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSplineUpDir_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetStartOffset_method {
            static internal IntPtr GetStartOffset_ptr;
            static GetStartOffset_method() {
                GetStartOffset_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetStartOffset");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartOffset_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetStartPosition_method {
            static internal IntPtr GetStartPosition_ptr;
            static GetStartPosition_method() {
                GetStartPosition_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetStartPosition");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartPosition_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetStartRoll_method {
            static internal IntPtr GetStartRoll_ptr;
            static GetStartRoll_method() {
                GetStartRoll_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetStartRoll");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartRoll_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetStartScale_method {
            static internal IntPtr GetStartScale_ptr;
            static GetStartScale_method() {
                GetStartScale_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetStartScale");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartScale_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetStartTangent_method {
            static internal IntPtr GetStartTangent_ptr;
            static GetStartTangent_method() {
                GetStartTangent_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "GetStartTangent");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartTangent_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct SetBoundaryMax_method {
            static internal IntPtr SetBoundaryMax_ptr;
            static SetBoundaryMax_method() {
                SetBoundaryMax_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetBoundaryMax");
            }

            internal static unsafe void Invoke(IntPtr obj, float InBoundaryMax, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InBoundaryMax;
                *((bool*)(b+4)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetBoundaryMax_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoundaryMin_method {
            static internal IntPtr SetBoundaryMin_ptr;
            static SetBoundaryMin_method() {
                SetBoundaryMin_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetBoundaryMin");
            }

            internal static unsafe void Invoke(IntPtr obj, float InBoundaryMin, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InBoundaryMin;
                *((bool*)(b+4)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetBoundaryMin_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEndOffset_method {
            static internal IntPtr SetEndOffset_ptr;
            static SetEndOffset_method() {
                SetEndOffset_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetEndOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D EndOffset, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = EndOffset;
                *((bool*)(b+8)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetEndOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEndPosition_method {
            static internal IntPtr SetEndPosition_ptr;
            static SetEndPosition_method() {
                SetEndPosition_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetEndPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector EndPos, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = EndPos;
                *((bool*)(b+12)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetEndPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEndRoll_method {
            static internal IntPtr SetEndRoll_ptr;
            static SetEndRoll_method() {
                SetEndRoll_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetEndRoll");
            }

            internal static unsafe void Invoke(IntPtr obj, float EndRoll, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = EndRoll;
                *((bool*)(b+4)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetEndRoll_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEndScale_method {
            static internal IntPtr SetEndScale_ptr;
            static SetEndScale_method() {
                SetEndScale_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetEndScale");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D EndScale, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = EndScale;
                *((bool*)(b+8)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetEndScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEndTangent_method {
            static internal IntPtr SetEndTangent_ptr;
            static SetEndTangent_method() {
                SetEndTangent_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetEndTangent");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector EndTangent, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = EndTangent;
                *((bool*)(b+12)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetEndTangent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetForwardAxis_method {
            static internal IntPtr SetForwardAxis_ptr;
            static SetForwardAxis_method() {
                SetForwardAxis_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetForwardAxis");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InForwardAxis, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InForwardAxis;
                *((bool*)(b+1)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetForwardAxis_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSplineUpDir_method {
            static internal IntPtr SetSplineUpDir_ptr;
            static SetSplineUpDir_method() {
                SetSplineUpDir_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetSplineUpDir");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector InSplineUpDir, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InSplineUpDir;
                *((bool*)(b+12)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetSplineUpDir_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartAndEnd_method {
            static internal IntPtr SetStartAndEnd_ptr;
            static SetStartAndEnd_method() {
                SetStartAndEnd_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetStartAndEnd");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector StartPos, Vector StartTangent, Vector EndPos, Vector EndTangent, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = StartPos;
                *((Vector*)(b+12)) = StartTangent;
                *((Vector*)(b+24)) = EndPos;
                *((Vector*)(b+36)) = EndTangent;
                *((bool*)(b+48)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetStartAndEnd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartOffset_method {
            static internal IntPtr SetStartOffset_ptr;
            static SetStartOffset_method() {
                SetStartOffset_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetStartOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D StartOffset, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = StartOffset;
                *((bool*)(b+8)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetStartOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartPosition_method {
            static internal IntPtr SetStartPosition_ptr;
            static SetStartPosition_method() {
                SetStartPosition_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetStartPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector StartPos, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = StartPos;
                *((bool*)(b+12)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetStartPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartRoll_method {
            static internal IntPtr SetStartRoll_ptr;
            static SetStartRoll_method() {
                SetStartRoll_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetStartRoll");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartRoll, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartRoll;
                *((bool*)(b+4)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetStartRoll_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartScale_method {
            static internal IntPtr SetStartScale_ptr;
            static SetStartScale_method() {
                SetStartScale_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetStartScale");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D StartScale, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = StartScale;
                *((bool*)(b+8)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetStartScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartTangent_method {
            static internal IntPtr SetStartTangent_ptr;
            static SetStartTangent_method() {
                SetStartTangent_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "SetStartTangent");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector StartTangent, bool bUpdateMesh) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = StartTangent;
                *((bool*)(b+12)) = bUpdateMesh;
                Main.GetProcessEvent(obj, SetStartTangent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UpdateMesh_method {
            static internal IntPtr UpdateMesh_ptr;
            static UpdateMesh_method() {
                UpdateMesh_ptr = Main.GetMethodUFunction(SplineMeshComponent.StaticClass, "UpdateMesh");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UpdateMesh_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SplineMeshComponent_events {
    }
}
