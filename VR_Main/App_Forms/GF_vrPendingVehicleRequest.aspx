<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_vrPendingVehicleRequest.aspx.vb" Inherits="GF_vrPendingVehicleRequest" title="Maintain List: Pending Vehicle Request" %>
<asp:Content ID="CPHvrPendingVehicleRequest" ContentPlaceHolderID="cph1" Runat="Server">
  <div class="ui-widget-content page">
    <div class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;List: Pending Vehicle Request"></asp:Label>
    </div>
    <div class="pagedata">
<asp:UpdatePanel ID="UPNLvrPendingVehicleRequest" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLvrPendingVehicleRequest"
      ToolType = "lgNMGrid"
      EditUrl = "~/VR_Main/App_Edit/EF_vrPendingVehicleRequest.aspx"
      EnableAdd = "False"
      ValidationGroup = "vrPendingVehicleRequest"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSvrPendingVehicleRequest" runat="server" AssociatedUpdatePanelID="UPNLvrPendingVehicleRequest" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
		<asp:Panel ID="pnlH" runat="server" CssClass="cph_filter">
			<div style="padding: 5px; cursor: pointer; vertical-align: middle;">
				<div style="float: left;">Filter Records </div>
				<div style="float: left; margin-left: 20px;">
					<asp:Label ID="lblH" runat="server">(Show Filters...)</asp:Label>
				</div>
				<div style="float: right; vertical-align: middle;">
					<asp:ImageButton ID="imgH" runat="server" ImageUrl="~/images/ua.png" AlternateText="(Show Filters...)" />
				</div>
			</div>
		</asp:Panel>
		<asp:Panel ID="pnlD" runat="server" CssClass="cp_filter" Height="0">
    <table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_SupplierID" runat="server" Text="Supplier ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_SupplierID"
						CssClass = "myfktxt"
            Width="92px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_SupplierID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_SupplierID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACESupplierID"
            BehaviorID="B_ACESupplierID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="SupplierIDCompletionList"
            TargetControlID="F_SupplierID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACESupplierID_Selected"
            OnClientPopulating="ACESupplierID_Populating"
            OnClientPopulated="ACESupplierID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_ProjectID"
						CssClass = "myfktxt"
            Width="62px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_ProjectID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_ProjectID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEProjectID"
            BehaviorID="B_ACEProjectID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ProjectIDCompletionList"
            TargetControlID="F_ProjectID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEProjectID_Selected"
            OnClientPopulating="ACEProjectID_Populating"
            OnClientPopulated="ACEProjectID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestedBy" runat="server" Text="Requested By :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_RequestedBy"
						CssClass = "myfktxt"
            Width="56px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_RequestedBy(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_RequestedBy_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACERequestedBy"
            BehaviorID="B_ACERequestedBy"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="RequestedByCompletionList"
            TargetControlID="F_RequestedBy"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACERequestedBy_Selected"
            OnClientPopulating="ACERequestedBy_Populating"
            OnClientPopulated="ACERequestedBy_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
    </table>
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    <script type="text/javascript">
      var pcnt = 0;
      function print_report(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_','App_Print/RP_');
        url = url + '?pk=' + o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
		<script type="text/javascript"> 
   var script_ReturnRemarks = {
		temp: function() {
		}
		}
		</script>

		<script type="text/javascript"> 
   var script_SRNNo = {
		ACESRNNo_Selected: function(sender, e) {
		  var Prefix = sender._element.id.replace('SRNNo','');
		  var F_SRNNo = $get(sender._element.id);
		  var F_SRNNo_Display = $get(sender._element.id + '_Display');
		  var retval = e.get_value();
		  var p = retval.split('|');
		  F_SRNNo.value = p[0];
		  F_SRNNo_Display.innerHTML = e.get_text();
		},
		ACESRNNo_Populating: function(sender,e) {
		  var p = sender.get_element();
		  var Prefix = sender._element.id.replace('SRNNo','');
		  p.style.backgroundImage  = 'url(../../images/loader.gif)';
		  p.style.backgroundRepeat= 'no-repeat';
		  p.style.backgroundPosition = 'right';
		  sender._contextKey = '';
		},
		ACESRNNo_Populated: function(sender,e) {
		  var p = sender.get_element();
		  p.style.backgroundImage  = 'none';
		},
		validate_SRNNo: function(sender) {
		  var Prefix = sender.id.replace('SRNNo','');
		  this.validated_FK_VR_VehicleRequest_SRNNo_main = true;
		  this.validate_FK_VR_VehicleRequest_SRNNo(sender,Prefix);
		  },
		validate_FK_VR_VehicleRequest_SRNNo: function(o,Prefix) {
		  var value = o.id;
		  var SRNNo = $get(o.id);
		  if(SRNNo.value==''){
		    if(this.validated_FK_VR_VehicleRequest_SRNNo_main){
		      var o_d = $get(Prefix + 'SRNNo' + '_Display');
		      try{o_d.innerHTML = '';}catch(ex){}
		    }
		    return true;
		  }
		  value = value + ',' + SRNNo.value ;
		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
		    o.style.backgroundRepeat= 'no-repeat';
		    o.style.backgroundPosition = 'right';
		    PageMethods.validate_FK_VR_VehicleRequest_SRNNo(value, this.validated_FK_VR_VehicleRequest_SRNNo);
		  },
		validated_FK_VR_VehicleRequest_SRNNo_main: false,
		validated_FK_VR_VehicleRequest_SRNNo: function(result) {
		  var p = result.split('|');
		  var o = $get(p[1]);
		  if(script_SRNNo.validated_FK_VR_VehicleRequest_SRNNo_main){
		    var o_d = $get(p[1]+'_Display');
		    try{o_d.innerHTML = p[2];}catch(ex){}
		  }
		  o.style.backgroundImage  = 'none';
		  if(p[0]=='1'){
		    o.value='';
		    o.focus();
		  }
		},
		temp: function() {
		}
		}
		</script>

    <asp:GridView ID="GVvrPendingVehicleRequest" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSvrPendingVehicleRequest" DataKeyNames="RequestNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<table><tr>
              <td style="vertical-align:top"><asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
              <td style="vertical-align:top"><asp:ImageButton ID="cmdPrintPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_report(this);" /></td>
						</tr></table>
          </ItemTemplate>
          <ItemStyle VerticalAlign="Top" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="REQ.No" SortExpression="RequestNo">
          <ItemTemplate>
            <asp:Label ID="LabelRequestNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RequestNo") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" />
          <HeaderStyle HorizontalAlign="Center" Width="60px"  />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SUPPLIER" SortExpression="IDM_Vendors5_Description">
          <ItemTemplate>
             <asp:Label ID="L_SupplierID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("SupplierID") %>' Text='<%# Eval("IDM_Vendors5_Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle VerticalAlign="Top" />
          <HeaderStyle Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PROJECT" SortExpression="IDM_Projects4_Description">
          <ItemTemplate>
             <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects4_Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle VerticalAlign="Top" />
          <HeaderStyle Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="VEHICLE" SortExpression="VR_VehicleTypes9_cmba">
          <ItemTemplate>
             <asp:Label ID="L_VehicleTypeID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("VehicleTypeID") %>' Text='<%# Eval("VR_VehicleTypes9_cmba") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle VerticalAlign="Top" />
          <HeaderStyle Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="REQUIRED ON" SortExpression="VehicleRequiredOn">
          <ItemTemplate>
            <asp:Label ID="LabelVehicleRequiredOn" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("VehicleRequiredOn") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle VerticalAlign="Top" />
          <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="REQUESTED ON" SortExpression="RequestedOn">
          <ItemTemplate>
            <asp:Label ID="LabelRequestedOn" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RequestedOn") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle VerticalAlign="Top" />
          <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="REMARKS" SortExpression="ReturnRemarks">
          <ItemTemplate>
					<asp:TextBox ID="F_ReturnRemarks"
						Text='<%# Bind("ReturnRemarks") %>'
            Width="200px" Height="30px" TextMode="MultiLine"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup='<%# "Reject" & Container.DataItemIndex %>'
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Return Remarks."
						MaxLength="100"
					  Enabled='<%# Eval("EnableInput") %>'
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVReturnRemarks"
						runat = "server"
						ControlToValidate = "F_ReturnRemarks"
						Text = "Return Remarks is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = '<%# "Reject" & Container.DataItemIndex %>'
						SetFocusOnError="true" />

          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="RETURN">
          <ItemTemplate>
						<table><tr>
              <td><asp:ImageButton ID="cmdRejectWF" ValidationGroup='<%# "Reject" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("RejectWFVisible") %>' Enabled='<%# EVal("RejectWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Return" SkinID="reject" OnClientClick='<%# "return Page_ClientValidate(""Reject" & Container.DataItemIndex & """) && confirm(""Return record ?"");" %>' CommandName="RejectWF" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></table>
          </ItemTemplate>
          <ItemStyle VerticalAlign="Top" HorizontalAlign="Center" />
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField >
          <ItemTemplate>
						</td></tr>
						<tr style="background-color:AntiqueWhite; color:DeepPink">
              <td colspan="5"></td>
              <td colspan="5">
                <asp:Label ID="LabelNotification" runat="server" Text='<%# Eval("Notification") %>'></asp:Label>
              </td>
						</tr>
          </ItemTemplate>
          <HeaderStyle Width="10px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSvrPendingVehicleRequest"
      runat = "server"
      DataObjectTypeName = "SIS.VR.vrPendingVehicleRequest"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_vrPendingVehicleRequestSelectList"
      TypeName = "SIS.VR.vrPendingVehicleRequest"
      SelectCountMethod = "vrPendingVehicleRequestSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_SupplierID" PropertyName="Text" Name="SupplierID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_ProjectID" PropertyName="Text" Name="ProjectID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_RequestedBy" PropertyName="Text" Name="RequestedBy" Type="String" Size="8" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVvrPendingVehicleRequest" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_SupplierID" />
    <asp:AsyncPostBackTrigger ControlID="F_ProjectID" />
    <asp:AsyncPostBackTrigger ControlID="F_RequestedBy" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
