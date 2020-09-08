namespace TsfSharp
{
    [SharpGen.Runtime.ShadowAttribute(typeof(TsfSharp.ITfTextEditSinkShadowImproved))]
    public partial interface ITfTextEditSink : SharpGen.Runtime.IUnknown
    {
        void OnEndEdit(TsfSharp.ITfContext icRef, System.Int32 ecReadOnly, TsfSharp.ITfEditRecord editRecordRef);
    }
}
