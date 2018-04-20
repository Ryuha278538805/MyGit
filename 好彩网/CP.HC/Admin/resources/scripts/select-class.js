BindSel(1,0);   //绑定根分类
SetDefault();   //设置默认选中 

$("#select1").change(function(){
	$("#select3").hide();
	$("#select4").hide();
	var cid=$(this).find('option:selected').val();
	SetCookies(1,cid);
	$("#cid").attr("value",cid);
	var leaf;							  
	if(cid>0){
	  leaf = GetLeaf(cid);
	  if(leaf==0) {
		  BindSel(2,cid);}
	  else{
		  HideSel(2);}
	}NowSelect();})

$("#select2").change(function(){
	$("#select4").hide();
	var cid=$(this).find('option:selected').val();
	SetCookies(2,cid);
	$("#cid").attr("value",cid);
	var leaf;							  
	if(cid>0){
	  leaf = GetLeaf(cid);
	  if(leaf==0) {
		  BindSel(3,cid);}
	  else{
		  HideSel(3);}
	}NowSelect();})

$("#select3").change(function(){
	var cid=$(this).find('option:selected').val();
	SetCookies(3,cid);
	$("#cid").attr("value",cid);
	var leaf;							  
	if(cid>0){
	  leaf = GetLeaf(cid);
	  if(leaf==0) {
		  BindSel(4,cid);}
	  else{
		  HideSel(4);}
	}NowSelect();})

$("#select4").change(function(){
	var cid=$(this).find('option:selected').val();
	SetCookies(4,cid);
	$("#cid").attr("value",cid);
	var leaf;							  
	NowSelect();})

//获取是否叶子分类
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
	
//初始页面设置默认选中
function SetDefault(){
	var cids = [$.cookie('cid1'),$.cookie('cid2'),$.cookie('cid3'),$.cookie('cid4')];
	SetSelect(cids);
}


function SetSelect(cids){
	for(var i=0;i<cids.length;i++){
		if(cids[i]!=null && cids[i]!=0){
			$("#select"+(i+1)).setSelectedValue(cids[i]);
			$("#cid").attr("value",cids[i]);
			if (i < cids.length-1)
				BindSel((i+2),cids[i]);
		}
	}
	NowSelect();
}

//设置当前选中字符串
function NowSelect(){
	var nowcname ='';
	var cids = [$.cookie('cid1'),$.cookie('cid2'),$.cookie('cid3'),$.cookie('cid4')];
	for(var i=0;i<cids.length;i++){
		if(cids[i]!=null && cids[i]!=0){
			if (i >0)
            	nowcname+= ' >> ';
			nowcname+= GetCname(cids[i]);			
		}
	}
	$("#nowcname").html(nowcname);
}

//获取Cname
function GetCname(cid){	
	if(leafArray.length==cnameArray.length && leafArray.length==cidArray.length){
		for(var i =0;i<leafArray.length; i++){
			if(cid==cidArray[i])
				return cnameArray [i];
		}
	}
}

var root = [0,0,0,0];  //反向路径

//获取根到叶子路径
function GetWay(cid,num){	   
	if(cid>0){		
		for(var i=0;i<cidArray.length;i++){   //找到cid
			if(cidArray[i]== cid){   //找到叶子				
				root[num]=cidArray[i];			//设置叶子
				if(pidArray[i]>0)
					GetWay(pidArray[i],num+1);		//继续递归
				else
					break;
			}
		}
	}
}

function EditSelectClass(cid){
	if(cid>0){
		root = [0,0,0,0];   //清0过期数据
		GetWay(cid,0);  	//得到反向数组
		var way = [0,0,0,0];
		var waynum = 0;
		for(var i=root.length;i>=0;i--){    //反向填入正确字段
			if(root[i]>0){
				way[waynum]=root[i];				
				SetCookies(waynum+1,root[i]);  //设置上次选中值
				waynum++;
			}
		}
		SetSelect(way);
	}
}




























