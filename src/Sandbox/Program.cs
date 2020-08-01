using System;
using OpenWindow;
using SharpGen.Runtime;
using SharpGen.Runtime.Win32;
using TsfSharp;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowingService.Logger.OutputLevel = Logger.Level.Warning;
            using var service = WindowingService.Create();
            using var window = service.CreateWindow(WindowCreateInfo.Default);

            window.KeyDown += (s, e) =>
            {
                switch (e.Key)
                {
                    case Key.Escape:
                        window.Close();
                        break;
                }
            };

            var hwnd = ((Win32WindowData) window.GetPlatformData()).Hwnd;

            Tsf.CreateThreadMgr(out var threadManager);
            threadManager.CreateDocumentMgr(out var documentManager);
            threadManager.SetFocus(documentManager);

            //var threadManagerEx = threadManager.QueryInterface<ITfThreadMgrEx>();
            //threadManagerEx.ActivateEx(out var clientId, TfTmaeFlags.Uielementenabledonly);
            threadManager.Activate(out var clientId);

            var uiElementManager = threadManager.QueryInterface<ITfUIElementMgr>();
            Tsf.CreateCategoryMgr(out var categoryManager);
            Tsf.CreateDisplayAttributeMgr(out var displayAttributeManager);

            var textStore = new TextStore();

            documentManager.CreateContext(clientId, 0, textStore, out var ctx, out var cookie);

            documentManager.Push(ctx);

            var languageProfileNotifySinkIid = typeof(ITfLanguageProfileNotifySink).GUID;
            var keyTraceEventSinkIid = typeof(ITfKeyTraceEventSink).GUID;
            var textEditSinkIid = typeof(ITfTextEditSink).GUID;

            var threadMgrSource = threadManager.QueryInterface<ITfSource>();
            threadMgrSource.AdviseSink(keyTraceEventSinkIid, textStore, out var keyTraceEventCookie);
            var ctxSource = ctx.QueryInterface<ITfSource>();
            ctxSource.AdviseSink(textEditSinkIid, textStore, out var textEditCookie);
            //source.AdviseSink(languageProfileNotifySinkIid, sink, out var languageProfileNotifyCookie);

            window.FocusChanged += (s, e) =>
            {
                if (e.HasFocus)
                {
                    threadManager.SetFocus(documentManager);
                }
            };

            while (!window.IsCloseRequested)
            {
                service.WaitEvent();
            }

            ctxSource.UnadviseSink(textEditCookie);
            threadMgrSource.UnadviseSink(keyTraceEventCookie);
            //threadMgrSource.UnadviseSink(languageProfileNotifyCookie);
        }
    }
}
