using System;
using System.Collections.Generic;

namespace TsfSharp
{
    internal class ITfTextEditSinkShadowImproved : SharpGen.Runtime.ComObjectShadow
    {
        protected unsafe class ITfTextEditSinkVtbl : SharpGen.Runtime.ComObjectShadow.ComObjectVtbl
        {
            private static Dictionary<IntPtr, ITfContext> _contextCaches = new Dictionary<IntPtr, ITfContext>();
            private static Dictionary<IntPtr, ITfEditRecord> _editRecordCaches = new Dictionary<IntPtr, ITfEditRecord>();

            public ITfTextEditSinkVtbl(int numberOfCallbackMethods): base (numberOfCallbackMethods + 1)
            {
                AddMethod(new OnEndEditDelegate(OnEndEdit));
            }

            [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
            private delegate int OnEndEditDelegate(System.IntPtr thisObject, void *arg0, int arg1, void *arg2);
            private static unsafe int OnEndEdit(System.IntPtr thisObject, void *param0, int param1, void *param2)
            {
                try
                {
                    TsfSharp.ITfContext icRef = default (TsfSharp.ITfContext);
                    System.IntPtr icRef_ = (System.IntPtr)param0;

                    if (icRef_ != System.IntPtr.Zero)
                    {
                        if (!_contextCaches.TryGetValue(icRef_, out icRef))
                        {
                            icRef = new TsfSharp.ITfContext(icRef_);
                            _contextCaches[icRef_] = icRef;
                        }
                    }

                    System.Int32 ecReadOnly = default (System.Int32);
                    ecReadOnly = (System.Int32)param1;

                    TsfSharp.ITfEditRecord editRecordRef = default (TsfSharp.ITfEditRecord);
                    System.IntPtr editRecordRef_ = (System.IntPtr)param2;

                    if (editRecordRef_ != System.IntPtr.Zero)
                    {
                        if (!_editRecordCaches.TryGetValue(editRecordRef_, out editRecordRef))
                        {
                            editRecordRef = new TsfSharp.ITfEditRecord(editRecordRef_);
                            _editRecordCaches[editRecordRef_] = editRecordRef;
                        }
                    }

                    ITfTextEditSink @this = (ITfTextEditSink)ToShadow<TsfSharp.ITfTextEditSinkShadowImproved>(thisObject).Callback;

                    @this.OnEndEdit(icRef, ecReadOnly, editRecordRef);
                    return SharpGen.Runtime.Result.Ok.Code;
                }
                catch (System.Exception __exception__)
                {
                    ITfTextEditSink @this = (ITfTextEditSink)ToShadow<TsfSharp.ITfTextEditSinkShadowImproved>(thisObject).Callback;
                    (@this as SharpGen.Runtime.IExceptionCallback)?.RaiseException(__exception__);
                    return SharpGen.Runtime.Result.GetResultFromException(__exception__).Code;
                }
            }
        }

        protected override SharpGen.Runtime.CppObjectVtbl Vtbl
        {
            get;
        }

        = new TsfSharp.ITfTextEditSinkShadowImproved.ITfTextEditSinkVtbl(0);
    }
}
