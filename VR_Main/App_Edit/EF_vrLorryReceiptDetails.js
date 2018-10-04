<script type="text/javascript"> 
var script_vrLorryReceiptDetails = {
    ACEProjectID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ProjectID','');
      var F_ProjectID = $get(sender._element.id);
      var F_ProjectID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ProjectID.value = p[0];
      F_ProjectID_Display.innerHTML = e.get_text();
    },
    ACEProjectID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ProjectID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEProjectID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEMRNNo_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('MRNNo','');
      var F_MRNNo = $get(sender._element.id);
      var F_MRNNo_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_MRNNo.value = p[1];
      F_MRNNo_Display.innerHTML = e.get_text();
    },
    ACEMRNNo_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('MRNNo','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEMRNNo_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACESupplierID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('SupplierID','');
      var F_SupplierID = $get(sender._element.id);
      var F_SupplierID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_SupplierID.value = p[0];
      F_SupplierID_Display.innerHTML = e.get_text();
    },
    ACESupplierID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('SupplierID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACESupplierID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_SupplierID: function(sender) {
      var Prefix = sender.id.replace('SupplierID','');
      this.validated_FK_VR_LorryReceiptDetails_SupplierID_main = true;
      this.validate_FK_VR_LorryReceiptDetails_SupplierID(sender,Prefix);
      },
    validate_FK_VR_LorryReceiptDetails_SupplierID: function(o,Prefix) {
      var value = o.id;
      var SupplierID = $get(Prefix + 'SupplierID');
      if(SupplierID.value==''){
        if(this.validated_FK_VR_LorryReceiptDetails_SupplierID_main){
          var o_d = $get(Prefix + 'SupplierID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + SupplierID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_VR_LorryReceiptDetails_SupplierID(value, this.validated_FK_VR_LorryReceiptDetails_SupplierID);
      },
    validated_FK_VR_LorryReceiptDetails_SupplierID_main: false,
    validated_FK_VR_LorryReceiptDetails_SupplierID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_vrLorryReceiptDetails.validated_FK_VR_LorryReceiptDetails_SupplierID_main){
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
