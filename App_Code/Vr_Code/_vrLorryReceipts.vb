Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.VR
  <DataObject()> _
  Partial Public Class vrLorryReceipts
    Private Shared _RecordCount As Integer
    Private _ProjectID As String = ""
    Private _RequestExecutionNo As String = ""
    Private _MRNNo As Int32 = 0
    Private _MRNDate As String = ""
    Private _TransporterID As String = ""
    Private _TransporterName As String = ""
    Private _CustomerID As String = ""
    Private _VehicleRegistrationNo As String = ""
    Private _WayBillFormNo As String = ""
    Private _PaymentMadeAtSite As Boolean = False
    Private _AmountPaid As Decimal = 0
    Private _VehicleInDate As String = ""
    Private _VehicleOutDate As String = ""
    Private _DetentionAtSite As String = ""
    Private _ReasonForDetention As String = ""
    Private _OverDimensionConsignment As String = ""
    Private _VehicleTypeID As String = ""
    Private _VehicleType As String = ""
    Private _VehicleLengthInFt As String = ""
    Private _VechicleWidthInFt As String = ""
    Private _VehicleHeightInFt As String = ""
    Private _MaterialStateID As String = ""
    Private _RemarksForDamageOrShortage As String = ""
    Private _OtherRemarks As String = ""
    Private _DriverNameAndContactNo As String = ""
    Private _CreatedBy As String = ""
    Private _LRStatusID As Int32 = 0
    Private _CreatedOn As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _IDM_Projects2_Description As String = ""
    Private _VR_BusinessPartner3_BPName As String = ""
    Private _VR_LorryReceiptStatus4_Description As String = ""
    Private _VR_MaterialStates5_Description As String = ""
    Private _VR_RequestExecution6_ExecutionDescription As String = ""
    Private _VR_Transporters7_TransporterName As String = ""
    Private _VR_VehicleTypes8_cmba As String = ""
    Private _FK_VR_LorryReceipts_CreatedBy As SIS.QCM.qcmUsers = Nothing
    Private _FK_VR_LorryReceipts_ProjectID As SIS.QCM.qcmProjects = Nothing
    Private _FK_VR_LorryReceipts_CustomerID As SIS.VR.vrBusinessPartner = Nothing
    Private _FK_VR_LorryReceipts_LRStatusID As SIS.VR.vrLorryReceiptStatus = Nothing
    Private _FK_VR_LorryReceipts_MaterialStatusID As SIS.VR.vrMaterialStates = Nothing
    Private _FK_VR_LorryReceipts_ExecutionNo As SIS.VR.vrRequestExecution = Nothing
    Private _FK_VR_LorryReceipts_TransporterID As SIS.VR.vrTransporters = Nothing
    Private _FK_VR_LorryReceipts_VehicleTypeID As SIS.VR.vrVehicleTypes = Nothing
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
          mRet = GetColor()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Visible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Enable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
        _ProjectID = value
      End Set
    End Property
    Public Property RequestExecutionNo() As String
      Get
        Return _RequestExecutionNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RequestExecutionNo = ""
         Else
           _RequestExecutionNo = value
         End If
      End Set
    End Property
    Public Property MRNNo() As Int32
      Get
        Return _MRNNo
      End Get
      Set(ByVal value As Int32)
        _MRNNo = value
      End Set
    End Property
    Public Property MRNDate() As String
      Get
        If Not _MRNDate = String.Empty Then
          Return Convert.ToDateTime(_MRNDate).ToString("dd/MM/yyyy")
        End If
        Return _MRNDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _MRNDate = ""
         Else
           _MRNDate = value
         End If
      End Set
    End Property
    Public Property TransporterID() As String
      Get
        Return _TransporterID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TransporterID = ""
         Else
           _TransporterID = value
         End If
      End Set
    End Property
    Public Property TransporterName() As String
      Get
        Return _TransporterName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TransporterName = ""
         Else
           _TransporterName = value
         End If
      End Set
    End Property
    Public Property CustomerID() As String
      Get
        Return _CustomerID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CustomerID = ""
         Else
           _CustomerID = value
         End If
      End Set
    End Property
    Public Property VehicleRegistrationNo() As String
      Get
        Return _VehicleRegistrationNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleRegistrationNo = ""
         Else
           _VehicleRegistrationNo = value
         End If
      End Set
    End Property
    Public Property WayBillFormNo() As String
      Get
        Return _WayBillFormNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _WayBillFormNo = ""
         Else
           _WayBillFormNo = value
         End If
      End Set
    End Property
    Public Property PaymentMadeAtSite() As Boolean
      Get
        Return _PaymentMadeAtSite
      End Get
      Set(ByVal value As Boolean)
        _PaymentMadeAtSite = value
      End Set
    End Property
    Public Property AmountPaid() As Decimal
      Get
        Return _AmountPaid
      End Get
      Set(ByVal value As Decimal)
        _AmountPaid = value
      End Set
    End Property
    Public Property VehicleInDate() As String
      Get
        If Not _VehicleInDate = String.Empty Then
          Return Convert.ToDateTime(_VehicleInDate).ToString("dd/MM/yyyy HH:mm")
        End If
        Return _VehicleInDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleInDate = ""
         Else
           _VehicleInDate = value
         End If
      End Set
    End Property
    Public Property VehicleOutDate() As String
      Get
        If Not _VehicleOutDate = String.Empty Then
          Return Convert.ToDateTime(_VehicleOutDate).ToString("dd/MM/yyyy HH:mm")
        End If
        Return _VehicleOutDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleOutDate = ""
         Else
           _VehicleOutDate = value
         End If
      End Set
    End Property
    Public Property DetentionAtSite() As String
      Get
        Return _DetentionAtSite
      End Get
      Set(ByVal value As String)
        _DetentionAtSite = value
      End Set
    End Property
    Public Property ReasonForDetention() As String
      Get
        Return _ReasonForDetention
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ReasonForDetention = ""
         Else
           _ReasonForDetention = value
         End If
      End Set
    End Property
    Public Property OverDimensionConsignment() As String
      Get
        Return _OverDimensionConsignment
      End Get
      Set(ByVal value As String)
        _OverDimensionConsignment = value
      End Set
    End Property
    Public Property VehicleTypeID() As String
      Get
        Return _VehicleTypeID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleTypeID = ""
         Else
           _VehicleTypeID = value
         End If
      End Set
    End Property
    Public Property VehicleType() As String
      Get
        Return _VehicleType
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleType = ""
         Else
           _VehicleType = value
         End If
      End Set
    End Property
    Public Property VehicleLengthInFt() As String
      Get
        Return _VehicleLengthInFt
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleLengthInFt = ""
         Else
           _VehicleLengthInFt = value
         End If
      End Set
    End Property
    Public Property VechicleWidthInFt() As String
      Get
        Return _VechicleWidthInFt
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VechicleWidthInFt = ""
         Else
           _VechicleWidthInFt = value
         End If
      End Set
    End Property
    Public Property VehicleHeightInFt() As String
      Get
        Return _VehicleHeightInFt
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleHeightInFt = ""
         Else
           _VehicleHeightInFt = value
         End If
      End Set
    End Property
    Public Property MaterialStateID() As String
      Get
        Return _MaterialStateID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _MaterialStateID = ""
         Else
           _MaterialStateID = value
         End If
      End Set
    End Property
    Public Property RemarksForDamageOrShortage() As String
      Get
        Return _RemarksForDamageOrShortage
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _RemarksForDamageOrShortage = ""
         Else
           _RemarksForDamageOrShortage = value
         End If
      End Set
    End Property
    Public Property OtherRemarks() As String
      Get
        Return _OtherRemarks
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _OtherRemarks = ""
         Else
           _OtherRemarks = value
         End If
      End Set
    End Property
    Public Property DriverNameAndContactNo() As String
      Get
        Return _DriverNameAndContactNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _DriverNameAndContactNo = ""
         Else
           _DriverNameAndContactNo = value
         End If
      End Set
    End Property
    Public Property CreatedBy() As String
      Get
        Return _CreatedBy
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CreatedBy = ""
         Else
           _CreatedBy = value
         End If
      End Set
    End Property
    Public Property LRStatusID() As Int32
      Get
        Return _LRStatusID
      End Get
      Set(ByVal value As Int32)
        _LRStatusID = value
      End Set
    End Property
    Public Property CreatedOn() As String
      Get
        If Not _CreatedOn = String.Empty Then
          Return Convert.ToDateTime(_CreatedOn).ToString("dd/MM/yyyy")
        End If
        Return _CreatedOn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CreatedOn = ""
         Else
           _CreatedOn = value
         End If
      End Set
    End Property
    Public Property aspnet_Users1_UserFullName() As String
      Get
        Return _aspnet_Users1_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users1_UserFullName = value
      End Set
    End Property
    Public Property IDM_Projects2_Description() As String
      Get
        Return _IDM_Projects2_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects2_Description = value
      End Set
    End Property
    Public Property VR_BusinessPartner3_BPName() As String
      Get
        Return _VR_BusinessPartner3_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner3_BPName = value
      End Set
    End Property
    Public Property VR_LorryReceiptStatus4_Description() As String
      Get
        Return _VR_LorryReceiptStatus4_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_LorryReceiptStatus4_Description = ""
         Else
           _VR_LorryReceiptStatus4_Description = value
         End If
      End Set
    End Property
    Public Property VR_MaterialStates5_Description() As String
      Get
        Return _VR_MaterialStates5_Description
      End Get
      Set(ByVal value As String)
        _VR_MaterialStates5_Description = value
      End Set
    End Property
    Public Property VR_RequestExecution6_ExecutionDescription() As String
      Get
        Return _VR_RequestExecution6_ExecutionDescription
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_RequestExecution6_ExecutionDescription = ""
         Else
           _VR_RequestExecution6_ExecutionDescription = value
         End If
      End Set
    End Property
    Public Property VR_Transporters7_TransporterName() As String
      Get
        Return _VR_Transporters7_TransporterName
      End Get
      Set(ByVal value As String)
        _VR_Transporters7_TransporterName = value
      End Set
    End Property
    Public Property VR_VehicleTypes8_cmba() As String
      Get
        Return _VR_VehicleTypes8_cmba
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_VehicleTypes8_cmba = ""
         Else
           _VR_VehicleTypes8_cmba = value
         End If
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _WayBillFormNo.ToString.PadRight(50, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _ProjectID & "|" & _MRNNo
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKvrLorryReceipts
      Private _ProjectID As String = ""
      Private _MRNNo As Int32 = 0
      Public Property ProjectID() As String
        Get
          Return _ProjectID
        End Get
        Set(ByVal value As String)
          _ProjectID = value
        End Set
      End Property
      Public Property MRNNo() As Int32
        Get
          Return _MRNNo
        End Get
        Set(ByVal value As Int32)
          _MRNNo = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_VR_LorryReceipts_CreatedBy() As SIS.QCM.qcmUsers
      Get
        If _FK_VR_LorryReceipts_CreatedBy Is Nothing Then
          _FK_VR_LorryReceipts_CreatedBy = SIS.QCM.qcmUsers.qcmUsersGetByID(_CreatedBy)
        End If
        Return _FK_VR_LorryReceipts_CreatedBy
      End Get
    End Property
    Public ReadOnly Property FK_VR_LorryReceipts_ProjectID() As SIS.QCM.qcmProjects
      Get
        If _FK_VR_LorryReceipts_ProjectID Is Nothing Then
          _FK_VR_LorryReceipts_ProjectID = SIS.QCM.qcmProjects.qcmProjectsGetByID(_ProjectID)
        End If
        Return _FK_VR_LorryReceipts_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_VR_LorryReceipts_CustomerID() As SIS.VR.vrBusinessPartner
      Get
        If _FK_VR_LorryReceipts_CustomerID Is Nothing Then
          _FK_VR_LorryReceipts_CustomerID = SIS.VR.vrBusinessPartner.vrBusinessPartnerGetByID(_CustomerID)
        End If
        Return _FK_VR_LorryReceipts_CustomerID
      End Get
    End Property
    Public ReadOnly Property FK_VR_LorryReceipts_LRStatusID() As SIS.VR.vrLorryReceiptStatus
      Get
        If _FK_VR_LorryReceipts_LRStatusID Is Nothing Then
          _FK_VR_LorryReceipts_LRStatusID = SIS.VR.vrLorryReceiptStatus.vrLorryReceiptStatusGetByID(_LRStatusID)
        End If
        Return _FK_VR_LorryReceipts_LRStatusID
      End Get
    End Property
    Public ReadOnly Property FK_VR_LorryReceipts_MaterialStatusID() As SIS.VR.vrMaterialStates
      Get
        If _FK_VR_LorryReceipts_MaterialStatusID Is Nothing Then
          _FK_VR_LorryReceipts_MaterialStatusID = SIS.VR.vrMaterialStates.vrMaterialStatesGetByID(_MaterialStateID)
        End If
        Return _FK_VR_LorryReceipts_MaterialStatusID
      End Get
    End Property
    Public ReadOnly Property FK_VR_LorryReceipts_ExecutionNo() As SIS.VR.vrRequestExecution
      Get
        If _FK_VR_LorryReceipts_ExecutionNo Is Nothing Then
          _FK_VR_LorryReceipts_ExecutionNo = SIS.VR.vrRequestExecution.UZ_vrRequestExecutionGetByID(_RequestExecutionNo)
        End If
        Return _FK_VR_LorryReceipts_ExecutionNo
      End Get
    End Property
    Public ReadOnly Property FK_VR_LorryReceipts_TransporterID() As SIS.VR.vrTransporters
      Get
        If _FK_VR_LorryReceipts_TransporterID Is Nothing Then
          _FK_VR_LorryReceipts_TransporterID = SIS.VR.vrTransporters.vrTransportersGetByID(_TransporterID)
        End If
        Return _FK_VR_LorryReceipts_TransporterID
      End Get
    End Property
    Public ReadOnly Property FK_VR_LorryReceipts_VehicleTypeID() As SIS.VR.vrVehicleTypes
      Get
        If _FK_VR_LorryReceipts_VehicleTypeID Is Nothing Then
          _FK_VR_LorryReceipts_VehicleTypeID = SIS.VR.vrVehicleTypes.vrVehicleTypesGetByID(_VehicleTypeID)
        End If
        Return _FK_VR_LorryReceipts_VehicleTypeID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function vrLorryReceiptsSelectList(ByVal OrderBy As String) As List(Of SIS.VR.vrLorryReceipts)
      Dim Results As List(Of SIS.VR.vrLorryReceipts) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.VR.vrLorryReceipts)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.VR.vrLorryReceipts(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function vrLorryReceiptsGetNewRecord() As SIS.VR.vrLorryReceipts
      Return New SIS.VR.vrLorryReceipts()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function vrLorryReceiptsGetByID(ByVal ProjectID As String, ByVal MRNNo As Int32) As SIS.VR.vrLorryReceipts
      Dim Results As SIS.VR.vrLorryReceipts = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,ProjectID.ToString.Length, ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MRNNo",SqlDbType.Int,MRNNo.ToString.Length, MRNNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.VR.vrLorryReceipts(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByProjectID(ByVal ProjectID As String, ByVal OrderBy as String) As List(Of SIS.VR.vrLorryReceipts)
      Dim Results As List(Of SIS.VR.vrLorryReceipts) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsSelectByProjectID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,ProjectID.ToString.Length, ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.VR.vrLorryReceipts)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.VR.vrLorryReceipts(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByCustomerID(ByVal CustomerID As String, ByVal OrderBy as String) As List(Of SIS.VR.vrLorryReceipts)
      Dim Results As List(Of SIS.VR.vrLorryReceipts) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsSelectByCustomerID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CustomerID",SqlDbType.NVarChar,CustomerID.ToString.Length, CustomerID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.VR.vrLorryReceipts)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.VR.vrLorryReceipts(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function vrLorryReceiptsSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal TransporterID As String, ByVal CustomerID As String, ByVal VehicleTypeID As Int32, ByVal LRStatusID As Int32) As List(Of SIS.VR.vrLorryReceipts)
      Dim Results As List(Of SIS.VR.vrLorryReceipts) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spvrLorryReceiptsSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spvrLorryReceiptsSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID",SqlDbType.NVarChar,6, IIf(ProjectID Is Nothing, String.Empty,ProjectID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TransporterID",SqlDbType.NVarChar,9, IIf(TransporterID Is Nothing, String.Empty,TransporterID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CustomerID",SqlDbType.NVarChar,9, IIf(CustomerID Is Nothing, String.Empty,CustomerID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_VehicleTypeID",SqlDbType.Int,10, IIf(VehicleTypeID = Nothing, 0,VehicleTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_LRStatusID",SqlDbType.Int,10, IIf(LRStatusID = Nothing, 0,LRStatusID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.VR.vrLorryReceipts)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.VR.vrLorryReceipts(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function vrLorryReceiptsSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal TransporterID As String, ByVal CustomerID As String, ByVal VehicleTypeID As Int32, ByVal LRStatusID As Int32) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function vrLorryReceiptsGetByID(ByVal ProjectID As String, ByVal MRNNo As Int32, ByVal Filter_ProjectID As String, ByVal Filter_TransporterID As String, ByVal Filter_CustomerID As String, ByVal Filter_VehicleTypeID As Int32, ByVal Filter_LRStatusID As Int32) As SIS.VR.vrLorryReceipts
      Return vrLorryReceiptsGetByID(ProjectID, MRNNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function vrLorryReceiptsInsert(ByVal Record As SIS.VR.vrLorryReceipts) As SIS.VR.vrLorryReceipts
      Dim _Rec As SIS.VR.vrLorryReceipts = SIS.VR.vrLorryReceipts.vrLorryReceiptsGetNewRecord()
      With _Rec
        .ProjectID = Record.ProjectID
        .RequestExecutionNo = Record.RequestExecutionNo
        .MRNNo = Record.MRNNo
        .MRNDate = Record.MRNDate
        .TransporterID = Record.TransporterID
        .TransporterName = Record.TransporterName
        .CustomerID = Record.CustomerID
        .VehicleRegistrationNo = Record.VehicleRegistrationNo
        .WayBillFormNo = Record.WayBillFormNo
        .PaymentMadeAtSite = Record.PaymentMadeAtSite
        .AmountPaid = Record.AmountPaid
        .VehicleInDate = Record.VehicleInDate
        .VehicleOutDate = Record.VehicleOutDate
        .DetentionAtSite = Record.DetentionAtSite
        .ReasonForDetention = Record.ReasonForDetention
        .OverDimensionConsignment = Record.OverDimensionConsignment
        .VehicleTypeID = Record.VehicleTypeID
        .VehicleType = Record.VehicleType
        .VehicleLengthInFt = Record.VehicleLengthInFt
        .VechicleWidthInFt = Record.VechicleWidthInFt
        .VehicleHeightInFt = Record.VehicleHeightInFt
        .MaterialStateID = Record.MaterialStateID
        .RemarksForDamageOrShortage = Record.RemarksForDamageOrShortage
        .OtherRemarks = Record.OtherRemarks
        .DriverNameAndContactNo = Record.DriverNameAndContactNo
        .CreatedBy =  Global.System.Web.HttpContext.Current.Session("LoginID")
        .LRStatusID = 1
        .CreatedOn = Now
      End With
      Return SIS.VR.vrLorryReceipts.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.VR.vrLorryReceipts) As SIS.VR.vrLorryReceipts
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestExecutionNo",SqlDbType.Int,11, Iif(Record.RequestExecutionNo= "" ,Convert.DBNull, Record.RequestExecutionNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MRNNo",SqlDbType.Int,11, Record.MRNNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MRNDate",SqlDbType.DateTime,21, Iif(Record.MRNDate= "" ,Convert.DBNull, Record.MRNDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterID",SqlDbType.NVarChar,10, Iif(Record.TransporterID= "" ,Convert.DBNull, Record.TransporterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterName",SqlDbType.NVarChar,51, Iif(Record.TransporterName= "" ,Convert.DBNull, Record.TransporterName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CustomerID",SqlDbType.NVarChar,10, Iif(Record.CustomerID= "" ,Convert.DBNull, Record.CustomerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleRegistrationNo",SqlDbType.NVarChar,51, Iif(Record.VehicleRegistrationNo= "" ,Convert.DBNull, Record.VehicleRegistrationNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@WayBillFormNo",SqlDbType.NVarChar,51, Iif(Record.WayBillFormNo= "" ,Convert.DBNull, Record.WayBillFormNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PaymentMadeAtSite",SqlDbType.Bit,3, Record.PaymentMadeAtSite)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AmountPaid",SqlDbType.Decimal,13, Record.AmountPaid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleInDate",SqlDbType.DateTime,21, Iif(Record.VehicleInDate= "" ,Convert.DBNull, Record.VehicleInDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleOutDate",SqlDbType.DateTime,21, Iif(Record.VehicleOutDate= "" ,Convert.DBNull, Record.VehicleOutDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DetentionAtSite",SqlDbType.NVarChar,11, Record.DetentionAtSite)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReasonForDetention",SqlDbType.NVarChar,501, Iif(Record.ReasonForDetention= "" ,Convert.DBNull, Record.ReasonForDetention))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OverDimensionConsignment",SqlDbType.NVarChar,11, Record.OverDimensionConsignment)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleTypeID",SqlDbType.Int,11, Iif(Record.VehicleTypeID= "" ,Convert.DBNull, Record.VehicleTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleType",SqlDbType.NVarChar,51, Iif(Record.VehicleType= "" ,Convert.DBNull, Record.VehicleType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleLengthInFt", SqlDbType.Decimal, 11, IIf(Record.VehicleLengthInFt = "", Convert.DBNull, Record.VehicleLengthInFt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VechicleWidthInFt", SqlDbType.Decimal, 11, IIf(Record.VechicleWidthInFt = "", Convert.DBNull, Record.VechicleWidthInFt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleHeightInFt", SqlDbType.Decimal, 11, IIf(Record.VehicleHeightInFt = "", Convert.DBNull, Record.VehicleHeightInFt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaterialStateID",SqlDbType.Int,11, Iif(Record.MaterialStateID= "" ,Convert.DBNull, Record.MaterialStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksForDamageOrShortage",SqlDbType.NVarChar,501, Iif(Record.RemarksForDamageOrShortage= "" ,Convert.DBNull, Record.RemarksForDamageOrShortage))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OtherRemarks",SqlDbType.NVarChar,501, Iif(Record.OtherRemarks= "" ,Convert.DBNull, Record.OtherRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DriverNameAndContactNo",SqlDbType.NVarChar,51, Iif(Record.DriverNameAndContactNo= "" ,Convert.DBNull, Record.DriverNameAndContactNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LRStatusID",SqlDbType.Int,11, Record.LRStatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          Cmd.Parameters.Add("@Return_ProjectID", SqlDbType.NVarChar, 7)
          Cmd.Parameters("@Return_ProjectID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_MRNNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_MRNNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.ProjectID = Cmd.Parameters("@Return_ProjectID").Value
          Record.MRNNo = Cmd.Parameters("@Return_MRNNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function vrLorryReceiptsUpdate(ByVal Record As SIS.VR.vrLorryReceipts) As SIS.VR.vrLorryReceipts
      Dim _Rec As SIS.VR.vrLorryReceipts = SIS.VR.vrLorryReceipts.vrLorryReceiptsGetByID(Record.ProjectID, Record.MRNNo)
      With _Rec
        .RequestExecutionNo = Record.RequestExecutionNo
        .MRNDate = Record.MRNDate
        .TransporterID = Record.TransporterID
        .TransporterName = Record.TransporterName
        .CustomerID = Record.CustomerID
        .VehicleRegistrationNo = Record.VehicleRegistrationNo
        .WayBillFormNo = Record.WayBillFormNo
        .PaymentMadeAtSite = Record.PaymentMadeAtSite
        .AmountPaid = Record.AmountPaid
        .VehicleInDate = Record.VehicleInDate
        .VehicleOutDate = Record.VehicleOutDate
        .DetentionAtSite = Record.DetentionAtSite
        .ReasonForDetention = Record.ReasonForDetention
        .OverDimensionConsignment = Record.OverDimensionConsignment
        .VehicleTypeID = Record.VehicleTypeID
        .VehicleType = Record.VehicleType
        .VehicleLengthInFt = Record.VehicleLengthInFt
        .VechicleWidthInFt = Record.VechicleWidthInFt
        .VehicleHeightInFt = Record.VehicleHeightInFt
        .MaterialStateID = Record.MaterialStateID
        .RemarksForDamageOrShortage = Record.RemarksForDamageOrShortage
        .OtherRemarks = Record.OtherRemarks
        .DriverNameAndContactNo = Record.DriverNameAndContactNo
        .CreatedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .LRStatusID = Record.LRStatusID
        .CreatedOn = Now
      End With
      Return SIS.VR.vrLorryReceipts.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.VR.vrLorryReceipts) As SIS.VR.vrLorryReceipts
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ProjectID",SqlDbType.NVarChar,7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_MRNNo",SqlDbType.Int,11, Record.MRNNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestExecutionNo",SqlDbType.Int,11, Iif(Record.RequestExecutionNo= "" ,Convert.DBNull, Record.RequestExecutionNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MRNNo",SqlDbType.Int,11, Record.MRNNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MRNDate",SqlDbType.DateTime,21, Iif(Record.MRNDate= "" ,Convert.DBNull, Record.MRNDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterID",SqlDbType.NVarChar,10, Iif(Record.TransporterID= "" ,Convert.DBNull, Record.TransporterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterName",SqlDbType.NVarChar,51, Iif(Record.TransporterName= "" ,Convert.DBNull, Record.TransporterName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CustomerID",SqlDbType.NVarChar,10, Iif(Record.CustomerID= "" ,Convert.DBNull, Record.CustomerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleRegistrationNo",SqlDbType.NVarChar,51, Iif(Record.VehicleRegistrationNo= "" ,Convert.DBNull, Record.VehicleRegistrationNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@WayBillFormNo",SqlDbType.NVarChar,51, Iif(Record.WayBillFormNo= "" ,Convert.DBNull, Record.WayBillFormNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PaymentMadeAtSite",SqlDbType.Bit,3, Record.PaymentMadeAtSite)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AmountPaid",SqlDbType.Decimal,13, Record.AmountPaid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleInDate",SqlDbType.DateTime,21, Iif(Record.VehicleInDate= "" ,Convert.DBNull, Record.VehicleInDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleOutDate",SqlDbType.DateTime,21, Iif(Record.VehicleOutDate= "" ,Convert.DBNull, Record.VehicleOutDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DetentionAtSite",SqlDbType.NVarChar,11, Record.DetentionAtSite)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReasonForDetention",SqlDbType.NVarChar,501, Iif(Record.ReasonForDetention= "" ,Convert.DBNull, Record.ReasonForDetention))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OverDimensionConsignment",SqlDbType.NVarChar,11, Record.OverDimensionConsignment)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleTypeID",SqlDbType.Int,11, Iif(Record.VehicleTypeID= "" ,Convert.DBNull, Record.VehicleTypeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleType",SqlDbType.NVarChar,51, Iif(Record.VehicleType= "" ,Convert.DBNull, Record.VehicleType))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleLengthInFt", SqlDbType.Decimal, 11, IIf(Record.VehicleLengthInFt = "", Convert.DBNull, Record.VehicleLengthInFt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VechicleWidthInFt", SqlDbType.Decimal, 11, IIf(Record.VechicleWidthInFt = "", Convert.DBNull, Record.VechicleWidthInFt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleHeightInFt", SqlDbType.Decimal, 11, IIf(Record.VehicleHeightInFt = "", Convert.DBNull, Record.VehicleHeightInFt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaterialStateID",SqlDbType.Int,11, Iif(Record.MaterialStateID= "" ,Convert.DBNull, Record.MaterialStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RemarksForDamageOrShortage",SqlDbType.NVarChar,501, Iif(Record.RemarksForDamageOrShortage= "" ,Convert.DBNull, Record.RemarksForDamageOrShortage))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OtherRemarks",SqlDbType.NVarChar,501, Iif(Record.OtherRemarks= "" ,Convert.DBNull, Record.OtherRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DriverNameAndContactNo",SqlDbType.NVarChar,51, Iif(Record.DriverNameAndContactNo= "" ,Convert.DBNull, Record.DriverNameAndContactNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LRStatusID",SqlDbType.Int,11, Record.LRStatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)> _
    Public Shared Function vrLorryReceiptsDelete(ByVal Record As SIS.VR.vrLorryReceipts) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ProjectID",SqlDbType.NVarChar,Record.ProjectID.ToString.Length, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_MRNNo",SqlDbType.Int,Record.MRNNo.ToString.Length, Record.MRNNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
    End Function
'    Autocomplete Method
    Public Shared Function SelectvrLorryReceiptsAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrLorryReceiptsAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "),"" & "|" & ""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.VR.vrLorryReceipts = New SIS.VR.vrLorryReceipts(Reader)
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results.ToArray
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(Me, pi.Name, CallType.Let, "0.00")
                    Case "bit"
                      CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                    Case Else
                      CallByName(Me, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
