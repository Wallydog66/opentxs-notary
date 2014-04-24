/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OpenTransactions.OTAPI {

public class OTLookupCaller : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OTLookupCaller(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OTLookupCaller obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OTLookupCaller() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_OTLookupCaller(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public OTLookupCaller() : this(otapiPINVOKE.new_OTLookupCaller(), true) {
  }

  public void delCallback() {
    otapiPINVOKE.OTLookupCaller_delCallback(swigCPtr);
  }

  public void setCallback(OTNameLookup cb) {
    otapiPINVOKE.OTLookupCaller_setCallback(swigCPtr, OTNameLookup.getCPtr(cb));
  }

  public bool isCallbackSet() {
    bool ret = otapiPINVOKE.OTLookupCaller_isCallbackSet(swigCPtr);
    return ret;
  }

  public string GetNymName(string str_id, SWIGTYPE_p_std__string p_server_id) {
    string ret = otapiPINVOKE.OTLookupCaller_GetNymName__SWIG_0(swigCPtr, str_id, SWIGTYPE_p_std__string.getCPtr(p_server_id));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetNymName(string str_id) {
    string ret = otapiPINVOKE.OTLookupCaller_GetNymName__SWIG_1(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetAcctName(string str_id, SWIGTYPE_p_std__string p_nym_id, SWIGTYPE_p_std__string p_server_id, SWIGTYPE_p_std__string p_asset_id) {
    string ret = otapiPINVOKE.OTLookupCaller_GetAcctName__SWIG_0(swigCPtr, str_id, SWIGTYPE_p_std__string.getCPtr(p_nym_id), SWIGTYPE_p_std__string.getCPtr(p_server_id), SWIGTYPE_p_std__string.getCPtr(p_asset_id));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetAcctName(string str_id, SWIGTYPE_p_std__string p_nym_id, SWIGTYPE_p_std__string p_server_id) {
    string ret = otapiPINVOKE.OTLookupCaller_GetAcctName__SWIG_1(swigCPtr, str_id, SWIGTYPE_p_std__string.getCPtr(p_nym_id), SWIGTYPE_p_std__string.getCPtr(p_server_id));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetAcctName(string str_id, SWIGTYPE_p_std__string p_nym_id) {
    string ret = otapiPINVOKE.OTLookupCaller_GetAcctName__SWIG_2(swigCPtr, str_id, SWIGTYPE_p_std__string.getCPtr(p_nym_id));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetAcctName(string str_id) {
    string ret = otapiPINVOKE.OTLookupCaller_GetAcctName__SWIG_3(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
