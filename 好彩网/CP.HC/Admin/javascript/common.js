//////////////////////////////////////此为批量上传图片JS代码/////////////////////////////////////////////////////////////////////////////
	//////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//增加上传图片框
	var TfileUploadNum=1;//记录图片选择框个数
	var Tnum=1;//ajax上传图片时索引
	function TAddFileUpload()
	{
		var idnum = TfileUploadNum+1;
		var str="<tr><td>图片 "+idnum+"：";
		str += "<input name='' size='60' id='uploadImg"+idnum+"' type='file' />&nbsp;<span id='uploadImgState"+idnum+"'>";
		str += "</span></td></tr>";
		$("#imgTable").append(str);
		TfileUploadNum += 1;
	}
	//提交按钮事件，批量提交
	function TSubmitUploadImageFile()
	{
		$("SubUpload").disabled=true;
		$("AddUpload").disabled=true;
		setTimeout("TajaxFileUpload()",1000); 
	}
	
	function TajaxFileUpload()
	{
		if(Tnum<TfileUploadNum+1)
		{
			//准备提交处理
			$("#uploadImgState"+Tnum).html("<img src=../images/loading.gif />");
			
			//开始提交
			$.ajax
			({ 
				type: "POST",
				url:"../Ajax/UpFiles.ashx",
				data:{upfile:$("#uploadImg"+Tnum).val(),gid:$("#goid").val()},
				success:function (data, status)
				{
					var stringArray = data.split("|");
					
					if(stringArray[0]=="1")
					{
						//stringArray[0]    成功状态(1为成功，0为失败)
						//stringArray[1]    上传成功的文件名
						//stringArray[2]    消息提示
						$("#uploadImgState"+Tnum).html("<img src=../images/ok.gif />");//+stringArray[1]+"|"+stringArray[2]);
					}            
					else
					{
						//上传出错
						$("#uploadImgState"+Tnum).html("<img src=../images/error.gif />"+stringArray[2]);//+stringArray[2]+"");
					}
					Tnum++;
			 		setTimeout("TSubmitUploadImageFile()",0);
				 }
			 });
			 
		}
		else
		{
			location.reload();
		}
	}