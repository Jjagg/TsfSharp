using System;
using SharpGen.Runtime;
using SharpGen.Runtime.Win32;
using TsfSharp;

namespace Sandbox
{
    public class TextStore : CallbackBase,
        ITextStoreACP2,
        ITfLanguageProfileNotifySink,
        ITfKeyTraceEventSink,
        ITfContextOwnerCompositionSink,
        ITfTextEditSink
    {
        public void AdviseSink(Guid riid, IUnknown unkRef, int dwMask)
        {
            throw new NotImplementedException();
        }

        public void FindNextAttrTransition(int acpStart, int acpHalt, uint cFilterAttrs, Guid[] aFilterAttrsRef, int dwFlags, out int acpNextRef, out RawBool fFoundRef, out int lFoundOffsetRef)
        {
            throw new NotImplementedException();
        }

        public void GetACPFromPoint(int vcView, TsfSharp.Point tScreenRef, int dwFlags, out int acpRef)
        {
            throw new NotImplementedException();
        }

        public void GetActiveView(out int vcViewRef)
        {
            throw new NotImplementedException();
        }

        public void GetEmbedded(int acpPos, Guid rguidService, Guid riid, out IUnknown unkOut)
        {
            throw new NotImplementedException();
        }

        public void GetEndACP(out int acpRef)
        {
            throw new NotImplementedException();
        }

        public void GetFormattedText(int acpStart, int acpEnd, out IDataObject dataObjectOut)
        {
            throw new NotImplementedException();
        }

        public void GetScreenExt(int vcView, out Rect rcRef)
        {
            throw new NotImplementedException();
        }

        public void GetSelection(uint ulIndex, uint ulCount, TsSelectionAcp[] selectionRef, out uint cFetchedRef)
        {
            throw new NotImplementedException();
        }

        public void GetStatus(out TsStatus dcsRef)
        {
            throw new NotImplementedException();
        }

        public void GetText(int acpStart, int acpEnd, IntPtr chPlainRef, uint cchPlainReq, out uint cchPlainRetRef, TsRuninfo[] rgRunInfoRef, uint cRunInfoReq, out uint cRunInfoRetRef, out int acpNextRef)
        {
            throw new NotImplementedException();
        }

        public void GetTextExt(int vcView, int acpStart, int acpEnd, out Rect rcRef, out RawBool fClippedRef)
        {
            throw new NotImplementedException();
        }

        public void InsertEmbedded(int dwFlags, int acpStart, int acpEnd, IDataObject dataObjectRef, out TsTextchange changeRef)
        {
            throw new NotImplementedException();
        }

        public void InsertEmbeddedAtSelection(int dwFlags, IDataObject dataObjectRef, out int acpStartRef, out int acpEndRef, out TsTextchange changeRef)
        {
            throw new NotImplementedException();
        }

        public void InsertTextAtSelection(int dwFlags, string chTextRef, uint cch, out int acpStartRef, out int acpEndRef, out TsTextchange changeRef)
        {
            throw new NotImplementedException();
        }

        public void OnEndComposition(ITfCompositionView compositionRef)
        {
            throw new NotImplementedException();
        }

        public void OnEndEdit(ITfContext icRef, int ecReadOnly, ITfEditRecord editRecordRef)
        {
            throw new NotImplementedException();
        }

        public void OnKeyTraceDown(UIntPtr wParam, IntPtr lParam)
        {
            throw new NotImplementedException();
        }

        public void OnKeyTraceUp(UIntPtr wParam, IntPtr lParam)
        {
            throw new NotImplementedException();
        }

        public void OnLanguageChange(ushort langid, out RawBool fAcceptRef)
        {
            throw new NotImplementedException();
        }

        public void OnLanguageChanged()
        {
            throw new NotImplementedException();
        }

        public void OnStartComposition(ITfCompositionView compositionRef, out RawBool fOkRef)
        {
            throw new NotImplementedException();
        }

        public void OnUpdateComposition(ITfCompositionView compositionRef, ITfRange rangeNewRef)
        {
            throw new NotImplementedException();
        }

        public void QueryInsert(int acpTestStart, int acpTestEnd, uint cch, out int acpResultStartRef, out int acpResultEndRef)
        {
            throw new NotImplementedException();
        }

        public void QueryInsertEmbedded(Guid guidServiceRef, ref Formatetc formatEtcRef, out RawBool fInsertableRef)
        {
            throw new NotImplementedException();
        }

        public void RequestAttrsAtPosition(int acpPos, uint cFilterAttrs, Guid[] aFilterAttrsRef, int dwFlags)
        {
            throw new NotImplementedException();
        }

        public void RequestAttrsTransitioningAtPosition(int acpPos, uint cFilterAttrs, Guid[] aFilterAttrsRef, int dwFlags)
        {
            throw new NotImplementedException();
        }

        public void RequestLock(int dwLockFlags, out Result hrSessionRef)
        {
            throw new NotImplementedException();
        }

        public void RequestSupportedAttrs(int dwFlags, uint cFilterAttrs, Guid[] aFilterAttrsRef)
        {
            throw new NotImplementedException();
        }

        public void RetrieveRequestedAttrs(uint ulCount, TsAttrval[] aAttrValsRef, out uint cFetchedRef)
        {
            throw new NotImplementedException();
        }

        public void SetSelection(uint ulCount, TsSelectionAcp[] selectionRef)
        {
            throw new NotImplementedException();
        }

        public void SetText(int dwFlags, int acpStart, int acpEnd, string chTextRef, uint cch, out TsTextchange changeRef)
        {
            throw new NotImplementedException();
        }

        public void UnadviseSink(IUnknown unkRef)
        {
            throw new NotImplementedException();
        }
    }
}
