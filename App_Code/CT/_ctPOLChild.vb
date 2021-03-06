Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.CT
  <DataObject()> _
  Partial Public Class ctPOLChild
    Private Shared _RecordCount As Integer
    Private _t_orno As String = ""
    Private _t_vrsn As Int32 = 0
    Private _t_pono As Int32 = 0
    Private _t_item As String = ""
    Private _t_desc As String = ""
    Private _t_qnty As Double = 0
    Private _t_quom As String = ""
    Private _t_wght As Double = 0
    Private _t_slct As Int32 = 0
    Private _t_stat As Int32 = 0
    Private _t_pric As Double = 0
    Private _t_amnt As Double = 0
    Private _t_qoor As Double = 0
    Private _t_acht As Double = 0
    Private _t_docn As String = ""
    Private _t_revi As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_pldt As String = ""
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
    Public Property t_orno() As String
      Get
        Return _t_orno
      End Get
      Set(ByVal value As String)
        _t_orno = value
      End Set
    End Property
    Public Property t_vrsn() As Int32
      Get
        Return _t_vrsn
      End Get
      Set(ByVal value As Int32)
        _t_vrsn = value
      End Set
    End Property
    Public Property t_pono() As Int32
      Get
        Return _t_pono
      End Get
      Set(ByVal value As Int32)
        _t_pono = value
      End Set
    End Property
    Public Property t_item() As String
      Get
        Return _t_item
      End Get
      Set(ByVal value As String)
        _t_item = value
      End Set
    End Property
    Public Property t_desc() As String
      Get
        Return _t_desc
      End Get
      Set(ByVal value As String)
        _t_desc = value
      End Set
    End Property
    Public Property t_qnty() As Double
      Get
        Return _t_qnty
      End Get
      Set(ByVal value As Double)
        _t_qnty = value
      End Set
    End Property
    Public Property t_quom() As String
      Get
        Return _t_quom
      End Get
      Set(ByVal value As String)
        _t_quom = value
      End Set
    End Property
    Public Property t_wght() As Double
      Get
        Return _t_wght
      End Get
      Set(ByVal value As Double)
        _t_wght = value
      End Set
    End Property
    Public Property t_slct() As Int32
      Get
        Return _t_slct
      End Get
      Set(ByVal value As Int32)
        _t_slct = value
      End Set
    End Property
    Public Property t_stat() As Int32
      Get
        Return _t_stat
      End Get
      Set(ByVal value As Int32)
        _t_stat = value
      End Set
    End Property
    Public Property t_pric() As Double
      Get
        Return _t_pric
      End Get
      Set(ByVal value As Double)
        _t_pric = value
      End Set
    End Property
    Public Property t_amnt() As Double
      Get
        Return _t_amnt
      End Get
      Set(ByVal value As Double)
        _t_amnt = value
      End Set
    End Property
    Public Property t_qoor() As Double
      Get
        Return _t_qoor
      End Get
      Set(ByVal value As Double)
        _t_qoor = value
      End Set
    End Property
    Public Property t_acht() As Double
      Get
        Return _t_acht
      End Get
      Set(ByVal value As Double)
        _t_acht = value
      End Set
    End Property
    Public Property t_docn() As String
      Get
        Return _t_docn
      End Get
      Set(ByVal value As String)
        _t_docn = value
      End Set
    End Property
    Public Property t_revi() As String
      Get
        Return _t_revi
      End Get
      Set(ByVal value As String)
        _t_revi = value
      End Set
    End Property
    Public Property t_Refcntd() As Int32
      Get
        Return _t_Refcntd
      End Get
      Set(ByVal value As Int32)
        _t_Refcntd = value
      End Set
    End Property
    Public Property t_Refcntu() As Int32
      Get
        Return _t_Refcntu
      End Get
      Set(ByVal value As Int32)
        _t_Refcntu = value
      End Set
    End Property
    Public Property t_pldt() As String
      Get
        If Not _t_pldt = String.Empty Then
          Return Convert.ToDateTime(_t_pldt).ToString("dd/MM/yyyy")
        End If
        Return _t_pldt
      End Get
      Set(ByVal value As String)
         _t_pldt = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _t_orno & "|" & _t_vrsn & "|" & _t_pono & "|" & _t_item
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
    Public Class PKctPOLChild
      Private _t_orno As String = ""
      Private _t_vrsn As Int32 = 0
      Private _t_pono As Int32 = 0
      Private _t_item As String = ""
      Public Property t_orno() As String
        Get
          Return _t_orno
        End Get
        Set(ByVal value As String)
          _t_orno = value
        End Set
      End Property
      Public Property t_vrsn() As Int32
        Get
          Return _t_vrsn
        End Get
        Set(ByVal value As Int32)
          _t_vrsn = value
        End Set
      End Property
      Public Property t_pono() As Int32
        Get
          Return _t_pono
        End Get
        Set(ByVal value As Int32)
          _t_pono = value
        End Set
      End Property
      Public Property t_item() As String
        Get
          Return _t_item
        End Get
        Set(ByVal value As String)
          _t_item = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function ctPOLChildGetNewRecord() As SIS.CT.ctPOLChild
      Return New SIS.CT.ctPOLChild()
		End Function
    Public Shared Function GetPOLineChildItems(ByVal t_orno As String, ByVal t_pono As Integer) As List(Of SIS.CT.ctPOLChild)
      Dim Results As New List(Of SIS.CT.ctPOLChild)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "select t_docn, sum(t_wght) as t_wght, count(t_item) as t_qoor from ttdisg002200 where t_orno='" & t_orno & "' and t_pono=" & t_pono & " group by t_docn"
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While Reader.Read()
            Results.Add(New SIS.CT.ctPOLChild(Reader))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    '  Public Shared Function GetPOElements(ByVal t_orno As String) As ArrayList
    '    Dim Results As New ArrayList
    '    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
    '      Using Cmd As SqlCommand = Con.CreateCommand()
    '        Cmd.CommandType = CommandType.Text
    '        Cmd.CommandText = "select distinct t_cspa as cspa from ttdpur401200 where t_orno='" & t_orno & "'"
    '        Con.Open()
    '        Dim Reader As SqlDataReader = Cmd.ExecuteReader()
    '        While Reader.Read()
    '          Results.Add(Reader("cspa"))
    '        End While
    '        Reader.Close()
    '      End Using
    '    End Using
    '    Return Results
    '  End Function
    '  Public Shared Function GetPODocuments(ByVal t_orno As String) As ArrayList
    '	Dim Results As New ArrayList
    '	Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
    '		Using Cmd As SqlCommand = Con.CreateCommand()
    '			Cmd.CommandType = CommandType.Text
    '			Cmd.CommandText = "select distinct t_docn as docn from ttdisg002200 where t_orno='" & t_orno & "'"
    '			Con.Open()
    '			Dim Reader As SqlDataReader = Cmd.ExecuteReader()
    '			While Reader.Read()
    '				Results.Add(Reader("docn"))
    '			End While
    '			Reader.Close()
    '		End Using
    '	End Using
    '	Return Results
    'End Function

    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function ctPOLChildGetByID(ByVal t_orno As String, ByVal t_vrsn As Int32, ByVal t_pono As Int32, ByVal t_item As String) As SIS.CT.ctPOLChild
      Dim Results As SIS.CT.ctPOLChild = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spctPOLChildSelectByID"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orno", SqlDbType.VarChar, t_orno.ToString.Length, t_orno)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vrsn", SqlDbType.Int, t_vrsn.ToString.Length, t_vrsn)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pono", SqlDbType.Int, t_pono.ToString.Length, t_pono)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_item", SqlDbType.VarChar, t_item.ToString.Length, t_item)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.CT.ctPOLChild(Reader)
					End If
					Reader.Close()
				End Using
			End Using
			Return Results
		End Function
		<DataObjectMethod(DataObjectMethodType.Select)> _
		Public Shared Function ctPOLChildSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal t_orno As String) As List(Of SIS.CT.ctPOLChild)
			Dim Results As List(Of SIS.CT.ctPOLChild) = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spctPOLChildSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spctPOLChildSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_t_orno", SqlDbType.VarChar, 9, IIf(t_orno Is Nothing, String.Empty, t_orno))
					End If
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
					Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
					Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
					_RecordCount = -1
					Results = New List(Of SIS.CT.ctPOLChild)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					While (Reader.Read())
						Results.Add(New SIS.CT.ctPOLChild(Reader))
					End While
					Reader.Close()
					_RecordCount = Cmd.Parameters("@RecordCount").Value
				End Using
			End Using
			Return Results
		End Function
		Public Shared Function ctPOLChildSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal t_orno As String) As Integer
			Return _RecordCount
		End Function
		'Select By ID One Record Filtered Overloaded GetByID
		<DataObjectMethod(DataObjectMethodType.Select)> _
		Public Shared Function ctPOLChildGetByID(ByVal t_orno As String, ByVal t_vrsn As Int32, ByVal t_pono As Int32, ByVal t_item As String, ByVal Filter_t_orno As String) As SIS.CT.ctPOLChild
			Return ctPOLChildGetByID(t_orno, t_vrsn, t_pono, t_item)
		End Function
		<DataObjectMethod(DataObjectMethodType.Insert, True)> _
		Public Shared Function ctPOLChildInsert(ByVal Record As SIS.CT.ctPOLChild) As SIS.CT.ctPOLChild
			Dim _Rec As SIS.CT.ctPOLChild = SIS.CT.ctPOLChild.ctPOLChildGetNewRecord()
			With _Rec
				.t_orno = Record.t_orno
				.t_vrsn = Record.t_vrsn
				.t_pono = Record.t_pono
				.t_item = Record.t_item
				.t_desc = Record.t_desc
				.t_qnty = Record.t_qnty
				.t_quom = Record.t_quom
				.t_wght = Record.t_wght
				.t_slct = Record.t_slct
				.t_stat = Record.t_stat
				.t_pric = Record.t_pric
				.t_amnt = Record.t_amnt
				.t_qoor = Record.t_qoor
				.t_acht = Record.t_acht
				.t_docn = Record.t_docn
				.t_revi = Record.t_revi
				.t_Refcntd = Record.t_Refcntd
				.t_Refcntu = Record.t_Refcntu
				.t_pldt = Record.t_pldt
			End With
			Return SIS.CT.ctPOLChild.InsertData(_Rec)
		End Function
		Public Shared Function InsertData(ByVal Record As SIS.CT.ctPOLChild) As SIS.CT.ctPOLChild
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spctPOLChildInsert"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orno", SqlDbType.VarChar, 10, Record.t_orno)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vrsn", SqlDbType.Int, 11, Record.t_vrsn)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pono", SqlDbType.Int, 11, Record.t_pono)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_item", SqlDbType.VarChar, 48, Record.t_item)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_desc", SqlDbType.VarChar, 31, Record.t_desc)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_qnty", SqlDbType.Float, 16, Record.t_qnty)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_quom", SqlDbType.VarChar, 4, Record.t_quom)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wght", SqlDbType.Float, 16, Record.t_wght)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_slct", SqlDbType.Int, 11, Record.t_slct)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat", SqlDbType.Int, 11, Record.t_stat)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pric", SqlDbType.Float, 16, Record.t_pric)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_amnt", SqlDbType.Float, 16, Record.t_amnt)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_qoor", SqlDbType.Float, 16, Record.t_qoor)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acht", SqlDbType.Float, 16, Record.t_acht)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revi", SqlDbType.VarChar, 21, Record.t_revi)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pldt", SqlDbType.DateTime, 21, Record.t_pldt)
					Cmd.Parameters.Add("@Return_t_orno", SqlDbType.VarChar, 10)
					Cmd.Parameters("@Return_t_orno").Direction = ParameterDirection.Output
					Cmd.Parameters.Add("@Return_t_vrsn", SqlDbType.Int, 11)
					Cmd.Parameters("@Return_t_vrsn").Direction = ParameterDirection.Output
					Cmd.Parameters.Add("@Return_t_pono", SqlDbType.Int, 11)
					Cmd.Parameters("@Return_t_pono").Direction = ParameterDirection.Output
					Cmd.Parameters.Add("@Return_t_item", SqlDbType.VarChar, 48)
					Cmd.Parameters("@Return_t_item").Direction = ParameterDirection.Output
					Con.Open()
					Cmd.ExecuteNonQuery()
					Record.t_orno = Cmd.Parameters("@Return_t_orno").Value
					Record.t_vrsn = Cmd.Parameters("@Return_t_vrsn").Value
					Record.t_pono = Cmd.Parameters("@Return_t_pono").Value
					Record.t_item = Cmd.Parameters("@Return_t_item").Value
				End Using
			End Using
			Return Record
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
