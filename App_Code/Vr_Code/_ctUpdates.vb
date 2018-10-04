Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.CT
  Public Class ctUpdates
    Public Shared Sub CT_ManualVRRequest(ByVal pp As SIS.VR.vrVehicleRequest)
      Dim errMsg As String = ""
      Dim hndl As String = "CT_VEHICLEREQUESTRAISED"
      '1. Insert In tpisg229
      Dim ct229 As New SIS.TPISG.tpisg229
      With ct229
        .t_trdt = Now.ToString("dd/MM/yyyy HH:mm:ss")
        .t_bohd = hndl
        .t_indv = pp.RequestNo & "_" & pp.ERPPONumber
        .t_srno = 1
        .t_proj = pp.ProjectID
        .t_elem = ""
        .t_user = HttpContext.Current.Session("LoginID")
        .t_stat = ""
        .t_Refcntd = 0
        .t_Refcntu = 0
      End With
      ct229 = SIS.TPISG.tpisg229.InsertData(ct229)
      '2. Insert In tpisg230
      Dim DSrn As Integer = 0
      Dim PODocs As List(Of SIS.DOCS.Document) = SIS.DOCS.Document.DocumentsSelectList(pp.ERPPONumber)
      If PODocs.Count > 0 Then
        For Each PODoc As SIS.DOCS.Document In PODocs
          DSrn += 1
          Dim ct230 As New SIS.TPISG.tpisg230
          With ct230
            .t_trdt = ct229.t_trdt
            .t_bohd = hndl
            .t_indv = pp.RequestNo & "_" & pp.ERPPONumber
            .t_srno = 1
            .t_dsno = DSrn
            .t_dwno = PODoc.t_docn
            .t_elem = ""
            .t_proj = pp.ProjectID
            .t_wght = 0
            .t_pitc = 0
            .t_stat = ""
            .t_atcd = ""
            .t_scup = 0
            .t_acdt = "01/01/1753"
            .t_acfh = "01/01/1753"
            .t_pper = 0
            .t_lupd = "01/01/1753"
            .t_Refcntd = 0
            .t_Refcntu = 0
            .t_numo = 0
            .t_numq = 0
            .t_numt = 0
            .t_numv = 0
            .t_nutc = 0
            .t_cuni = ""
            .t_iref = ""
            .t_quan = 0
            .t_iuom = ""
          End With
          ct230 = SIS.TPISG.tpisg230.InsertData(ct230)
        Next
      End If
      '4. Calculate Progress %
      '4.1 Get PO IREFs
      Dim POIrefs As List(Of SIS.VR.vrctVehicleRequest) = SIS.VR.vrctVehicleRequest.vrctVehicleRequestSelectList(0, 999, "", False, "", pp.RequestNo)
      For Each iref As SIS.VR.vrctVehicleRequest In POIrefs
        Dim tmp As New SIS.TPISG.tpisg207
        With tmp
          .t_bohd = hndl
          .t_date = ct229.t_trdt
          .t_inid = pp.RequestNo
          .t_iref = iref.ItemReference
          .t_mode = 1  '=>Manual, 2=>Packing List
          .t_pono = pp.ERPPONumber
          .t_prpo = iref.ProgressPercent
          .t_powt = iref.ProgressWeight
          .t_Refcntd = 0
          .t_Refcntu = 0
          .t_cprj = pp.ProjectID
          .t_sitm = iref.ActivityID
        End With
        SIS.TPISG.tpisg207.InsertData(tmp)
      Next
      If errMsg <> "" Then
        Throw New Exception(errMsg)
      End If
    End Sub

    Public Shared Sub CT_VehiclePlaced(ByVal pp As SIS.VR.vrVehicleRequest)
      Dim errMsg As String = ""
      Dim hndl As String = "CT_VEHICLEPLACED"
      '1. Insert In tpisg229
      Dim ct229 As New SIS.TPISG.tpisg229
      With ct229
        .t_trdt = Now.ToString("dd/MM/yyyy HH:mm:ss")
        .t_bohd = hndl
        .t_indv = pp.RequestNo & "_" & pp.ERPPONumber
        .t_srno = 1
        .t_proj = pp.ProjectID
        .t_elem = ""
        .t_user = HttpContext.Current.Session("LoginID")
        .t_stat = ""
        .t_Refcntd = 0
        .t_Refcntu = 0
      End With
      ct229 = SIS.TPISG.tpisg229.InsertData(ct229)
      '2. Insert In tpisg230
      Dim DSrn As Integer = 0
      Dim PODocs As List(Of SIS.DOCS.Document) = SIS.DOCS.Document.DocumentsSelectList(pp.ERPPONumber)
      If PODocs.Count > 0 Then
        For Each PODoc As SIS.DOCS.Document In PODocs
          DSrn += 1
          Dim ct230 As New SIS.TPISG.tpisg230
          With ct230
            .t_trdt = ct229.t_trdt
            .t_bohd = hndl
            .t_indv = pp.RequestNo & "_" & pp.ERPPONumber
            .t_srno = 1
            .t_dsno = DSrn
            .t_dwno = PODoc.t_docn
            .t_elem = ""
            .t_proj = pp.ProjectID
            .t_wght = 0
            .t_pitc = 0
            .t_stat = ""
            .t_atcd = ""
            .t_scup = 0
            .t_acdt = "01/01/1753"
            .t_acfh = "01/01/1753"
            .t_pper = 0
            .t_lupd = "01/01/1753"
            .t_Refcntd = 0
            .t_Refcntu = 0
            .t_numo = 0
            .t_numq = 0
            .t_numt = 0
            .t_numv = 0
            .t_nutc = 0
            .t_cuni = ""
            .t_iref = ""
            .t_quan = 0
            .t_iuom = ""
          End With
          ct230 = SIS.TPISG.tpisg230.InsertData(ct230)
        Next
      End If
      '4. Calculate Progress %
      '4.1 Get PO IREFs
      Dim POIrefs As List(Of SIS.VR.vrctVehicleRequest) = SIS.VR.vrctVehicleRequest.vrctVehicleRequestSelectList(0, 999, "", False, "", pp.RequestNo)
      For Each iref As SIS.VR.vrctVehicleRequest In POIrefs
        Dim tmp As New SIS.TPISG.tpisg207
        With tmp
          .t_bohd = hndl
          .t_date = ct229.t_trdt
          .t_inid = pp.RequestNo
          .t_iref = iref.ItemReference
          .t_mode = 1  '=>Manual, 2=>Packing List
          .t_pono = pp.ERPPONumber
          .t_prpo = iref.ProgressPercent
          .t_powt = iref.ProgressWeight
          .t_Refcntd = 0
          .t_Refcntu = 0
          .t_cprj = pp.ProjectID
          .t_sitm = iref.ActivityID
        End With
        SIS.TPISG.tpisg207.InsertData(tmp)
      Next
      If errMsg <> "" Then
        Throw New Exception(errMsg)
      End If
    End Sub
  End Class
End Namespace
