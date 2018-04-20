$("#select1").addSons(0);
SetDefault();

$("#select1").change(function(){
							  $("#select3").hide();
							  $("#select4").hide();
							  var cid=$(this).find('option:selected').val();
							  var cname=$(this).find('option:selected').text();
							  SetCookies(1,cid);
							  var leaf;							  
							  if(cid>0){
								  leaf = GetLeaf(cid);
								  if(leaf==0) {
									  BindSel(2,cid);}
								  else{
									  HideSel(2);}
							  }})

$("#select2").change(function(){
							  $("#select4").hide();
							  var cid=$(this).find('option:selected').val();
							  var cname=$(this).find('option:selected').text();
							  SetCookies(2,cid);
							  var leaf;							  
							  if(cid>0){
								  leaf = GetLeaf(cid);
								  if(leaf==0) {
									  BindSel(3,cid);}
								  else{
									  HideSel(3);}
							  }})

$("#select3").change(function(){
							  var cid=$(this).find('option:selected').val();
							  var cname=$(this).find('option:selected').text();
							  SetCookies(3,cid);
							  var leaf;							  
							  if(cid>0){
								  leaf = GetLeaf(cid);
								  if(leaf==0) {
									  BindSel(4,cid);}
								  else{
									  HideSel(4);}
							  }})

$("#select4").change(function(){var cid=$(this).find('option:selected').val();
							  var cname=$(this).find('option:selected').text();
							  SetCookies(4,cid);
							  var leaf;							  
							  if(cid>0){
								 
							  }})


function GetLeaf(cid){
		if(leafArray.length==cnameArray.length && leafArray.length==cidArray.length){
			for(var i =0;i<leafArray.length; i++)
			{
				if(cid==cidArray[i])
					return leafArray[i];
			}
		}
		return true;
	}

//添加选项到下拉列表
function BindSel(selectnum,cid){
	$("#select"+selectnum).clearAll();
	$("#select"+selectnum).addSons(cid);
	if($("#select"+selectnum).size()>0)
		$("#select"+selectnum).show();
}
//隐藏下拉列表
function HideSel(selectnum){
	$("#select"+selectnum).clearAll();
	$("#select"+selectnum).hide();
}

//隐藏下拉列表
function SetCookies(num,value){
	for(var i=1;i<5;i++){
		if(i==num)
		{
			$.cookie('cid'+num,value,{expires:1});
		}
		if(i>num)
		{	$.cookie('cid'+i,0,{expires:1});}		
	}
}
	
	
function SetDefault(){
		var lastcname ='';
		var cid1 = $.cookie('cid1');
		var cid2 = $.cookie('cid2');
		var cid3 = $.cookie('cid3');
		var cid4 = $.cookie('cid4');
		if(cid1!=null && cid1!=0){$("#select1").setSelectedValue(cid1); BindSel(2,cid1); lastcname= GetCname(cid1); }
		if(cid2!=null && cid2!=0){$("#select2").setSelectedValue(cid2); BindSel(3,cid2); lastcname+= (' >> ' + GetCname(cid2));}
		if(cid3!=null && cid3!=0){$("#select3").setSelectedValue(cid3); BindSel(4,cid3); lastcname+= (' >> ' + GetCname(cid3));}
		if(cid4!=null && cid4!=0){$("#select4").setSelectedValue(cid4); lastcname+= (' >> ' + GetCname(cid4)); }
		$("#lastclass").html(lastcname);
	}
	
function GetCname(cid){	
	if(leafArray.length==cnameArray.length && leafArray.length==cidArray.length){
		for(var i =0;i<leafArray.length; i++){
			if(cid==cidArray[i])
				return cnameArray [i];
		}
	}
}