<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_vrBillStatus.aspx.vb" Inherits="EF_vrBillStatus" title="Edit: Bill Status" %>
<asp:Content ID="CPHvrBillStatus" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="page">
<asp:UpdatePanel ID="UPNLvrBillStatus" runat="server" >
<ContentTemplate>
  <asp:Label ID="LabelvrBillStatus" runat="server" Text="&nbsp;Edit: Bill Status" Width="100%" CssClass="sis_formheading"></asp:Label>
  <LGM:ToolBar0 
    ID = "TBLvrBillStatus"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnablePrint = "True"
    PrintUrl = "../App_Print/RP_vrBillStatus.aspx?pk="
    ValidationGroup = "vrBillStatus"
    Skin = "tbl_blue"
    runat = "server" />
    <script type="text/javascript">
      var pcnt = 0;
      function print_report(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_','App_Print/RP_');
        url = url + '?pk=' + o.alt;
        url = o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
<asp:FormView ID="FVvrBillStatus"
	runat = "server"
	DataKeyNames = "BillStatusID"
	DataSourceID = "ODSvrBillStatus"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <br />
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_BillStatusID" runat="server" ForeColor="#CC6633" Text="Bill Status ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_BillStatusID"
						Text='<%# Bind("BillStatusID") %>'
            ToolTip="Value of Bill Status ID."
            Enabled = "False"
						CssClass = "mypktxt"
            Width="70px"
						style="text-align: right"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Description" runat="server" Text="Description :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Description"
						Text='<%# Bind("Description") %>'
            Width="350px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="vrBillStatus"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
						MaxLength="50"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVDescription"
						runat = "server"
						ControlToValidate = "F_Description"
						Text = "Description is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "vrBillStatus"
						SetFocusOnError="true" />
				</td>
			</tr>
		</table>
	<br />
	</EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSvrBillStatus"
  DataObjectTypeName = "SIS.VR.vrBillStatus"
  SelectMethod = "vrBillStatusGetByID"
  UpdateMethod="vrBillStatusUpdate"
  DeleteMethod="vrBillStatusDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.VR.vrBillStatus"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="BillStatusID" Name="BillStatusID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</asp:Content>
