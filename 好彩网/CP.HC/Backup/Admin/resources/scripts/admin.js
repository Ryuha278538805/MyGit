//后台删除活动
var delmethod = function(mo,id)
{
	var text = $.ajax({
		url: '/ajax/ConfigMode.aspx',
		data:'mo='+escape(mo)+'&me='+escape(2)+'&id='+escape(id),
		dataType:'text', 
		type:'POST',
		cache:false,
		async:false
	   }).responseText;	
	return text;
}


//后台删除活动
var delallmethod = function(mo)
{
	var method = $("#dropdown").val();
	var id = "";
	$("input[@type=checkbox][@checked]").each(function(){ id= id+$(this).val()+',';});	
	id+='0';
	if(method>0)
	{		
		var text = $.ajax({
			url: '/ajax/ConfigMode.aspx',
			data:'mo='+escape(mo)+'&me='+escape(method)+'&id='+escape(id),
			dataType:'text', 
			type:'POST',
			cache:false,
			async:false
		   }).responseText;	
		return text;
	}
	else
	{
		return 'error';
	}
}


//后台活动
var domethod = function(mo,me,id)
{
	var text = $.ajax({
		url: '/ajax/ConfigMode.aspx',
		data:'mo='+escape(mo)+'&me='+escape(me)+'&id='+escape(id),
		dataType:'text', 
		type:'POST',
		cache:false,
		async:false
	   }).responseText;	
	return text;
}


//后台删除开奖号
var delmethodkjh = function(mo,id)
{
	var text = $.ajax({
		url: '/ajax/KjhMode.aspx',
		data:'mo='+escape(mo)+'&me='+escape(2)+'&id='+escape(id),
		dataType:'text', 
		type:'POST',
		cache:false,
		async:false
	   }).responseText;	
	return text;
}


//后台删除开奖号
var delallmethodkjh = function(mo)
{
	var method = $("#dropdown").val();
	var id = "";
	$("input[@type=checkbox][@checked]").each(function(){ id= id+$(this).val()+',';});	
	id+='0';	
	if(method>0)
	{
		var text = $.ajax({
			url: '/ajax/KjhMode.aspx',
			data:'mo='+escape(mo)+'&me='+escape(method)+'&id='+escape(id),
			dataType:'text', 
			type:'POST',
			cache:false,
			async:false
		   }).responseText;	
		return text;
	}
	else
	{
		return 'error';
	}
}


var RequestXML = function(page,pagesize,nid)
{
	var cid = $("#cid2").val();	
	var strhtml="";	
	$.ajax({
        url: '/ajax/NewsGet.aspx',
		data:'page='+escape(page)+'&pagesize='+escape(pagesize)+'&cid='+escape(cid)+'&nid='+escape(nid),
		type:'POST',
        dataType: "xml",
        success: function(data) {													
												  $.each($(data).find("news"), function(n, obj) {
																strhtml += "<li><input id='nid"+n+"' type='checkbox' name='nid"+n+"' onclick=\"SelectNews("+ $(obj).find("nid").text() +",$(this).attr('checked'))\"; value='"+ $(obj).find("nid").text() +"'/> <label for='nid"+n+"'>"+ $(obj).find("title").text() +"</label></li>";
																});
												  				$("#mergelist").html(strhtml); 
											}
    	});

}


var SelectNews =function(nid,chk){
		var strhtml="";	
		if(chk)   //选中获取新闻消息
		{
				$.ajax({
					url: '/ajax/NewsGet.aspx',
					data:'nid='+escape(nid),
					type:'POST',
					dataType: "xml",
					success: function(data) {													
															$.each($(data).find("news"), function(n, obj) {
																	strhtml += "<p class='title2'>" + $(obj).find("title").text() +"</p><p>" + $(obj).find("context").text() +"</p><p class='hr2'>*********************** www.haocw.com *****************</p>";
																	});																       
															$("#context").html($("#context").html()+strhtml);
															$("#content").val($("#content").val()+strhtml);
														}
					});
			} 
	}

     





















