Partial Class GF_vrUnits
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/VR_Main/App_Display/DF_vrUnits.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?UnitID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVvrUnits_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVvrUnits.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim UnitID As Int32 = GVvrUnits.DataKeys(e.CommandArgument).Values("UnitID")  
				Dim RedirectUrl As String = TBLvrUnits.EditUrl & "?UnitID=" & UnitID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVvrUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVvrUnits.Init
    DataClassName = "GvrUnits"
    SetGridView = GVvrUnits
  End Sub
  Protected Sub TBLvrUnits_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLvrUnits.Init
    SetToolBar = TBLvrUnits
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
