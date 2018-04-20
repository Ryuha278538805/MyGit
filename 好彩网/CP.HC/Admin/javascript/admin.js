

var addnews = function()
{
	var i = 1;
	var cid = $("#cid");
	var title = $("#title");
	var text = editor1.html()

	if(cid.val()=='0')
	{
		alert("没有选择分类...");
		cid.focus();
		i = 2;
		return false;
	}
	if(title.val().length==0||title.val()=="")
	{
		alert("没有填写标题...");
		title.focus();
		i  = 2;
		return false;
	}
	if(text.length==0||text=="")
	{
		alert("没有填写内容...");	
		editor1.focus();
		i = 2;
		return false;
	}
	
	if(i==1)
		$("#enter").disabled = true;
}



/*******************************
 * @author Mr.Think
 * @author blog http://mrthink.net/
 * @2012.02.28
 * @可自由转载及使用,但请注明版权归属
 *******************************/
;(function($){
    /*
     * 统一select样式并实现样式高度自定义的jQuery插件@Mr.Think(http://mrthink.net/)
     */
    $.fn.iSimulateSelect=function(iSet){
        iSet=$.extend({
            selectBoxCls:'i_selectbox', //string类型,外围class名
            curSCls:'i_currentselected',//string类型,默认显示class名
            optionCls:'i_selectoption',//string类型,下拉列表class名
            selectedCls:'selected',//string类型,当前选中class名
            width:260,//number类型，模拟select的宽度
            height:300,//number类型，模拟select的最大高度
            zindex:20//层级顺序
        },iSet||{});
        this.hide();
        return this.each(function(){
           var self=this; 
           var thisCurVal,thisSelect,cIndex=0;
           //计算模拟select宽度
           if(iSet.width==0){
              iSet.width=$(self).width();
           }
           var html='<div class="'+iSet.selectBoxCls+'" style="z-index:'+iSet.zindex+'"><div class="'+iSet.curSCls+'" style="width:'+iSet.width+'px">'+$(self).find('option:selected').text()+'</div><dl class="'+iSet.optionCls+'" style="display:none;width:'+iSet.width+'px">';
           //判断select中是否有optgroup
           //用dt替代optgroup，用dd替代option
           if($(self).find('optgroup').size()>0){
               $(this).find('optgroup').each(function(){
                   html+='<dt>'+$(this).attr('label')+'</dt>';
                   $(this).find('option').each(function(){
                        if($(this).is(':selected')){
                          html+='<dd class="'+iSet.selectedCls+'">'+$(this).text()+'</dd>'; 
                       }else{
                          html+='<dd>'+$(this).text()+'</dd>';
                       }                    
                   });
               });
           }else{
               $(this).find('option').each(function(){
                   if($(this).is(':selected')){
                      html+='<dd class="'+iSet.selectedCls+'">'+$(this).text()+'</dd>'; 
                   }else{
                      html+='<dd>'+$(this).text()+'</dd>';
                   }
               });
           }
           //将模拟dl插入到select后面
           $(self).after(html);
           //当前模拟select外围box元素    
           thisBox=$(self).next('.'+iSet.selectBoxCls);
           //当前模拟select初始值元素    
           thisCurVal=thisBox.find('.'+iSet.curSCls);
           //当前模拟select列表
           thisSelect=thisBox.find('.'+iSet.optionCls);
           /*
           若同页面还有其他原生select,请前往https://github.com/brandonaaron/bgiframe下载bgiframe，同时在此处调用thisSelect.bgiframe()
            */ 
           //thisSelect.bgiframe();
           
           //弹出模拟下拉列表
           thisCurVal.click(function(){
              $('.'+iSet.optionCls).hide();
              $('.'+iSet.selectBoxCls).css('zIndex',iSet.zindex); 
              $(self).next('.'+iSet.selectBoxCls).css('zIndex',iSet.zindex+1);
              thisSelect.show();
           });
           //若模拟select高度超出限定高度，则自动overflow-y:auto
           if(thisSelect.height()>iSet.height){
               thisSelect.height(iSet.height);
           }
           //模拟列表点击事件-赋值-改变y坐标位置-...
           thisSelect.find('dd').click(function(){
               $(this).addClass(iSet.selectedCls).siblings().removeClass(iSet.selectedCls);
               cIndex=thisSelect.find('dd').index(this);
               thisCurVal.text($(this).text());
               $(self).find('option').eq(cIndex).attr('selected','selected');
               $('.'+iSet.selectBoxCls).css('zIndex',iSet.zindex);
               thisSelect.hide(); 
           });
           //非模拟列表处点击隐藏模拟列表
		   //$(document)点击事件不兼容部分移动设备
           $('html,body').click(function(e){
              if(e.target.className.indexOf(iSet.curSCls)==-1){
                  thisSelect.hide();
                  $('.'+iSet.selectBoxCls).css('zIndex',iSet.zindex); 
              } 
           });
           //取消模块列表处取消默认事件
           thisSelect.click(function(e){
              e.stopPropagation();
           });
        });
    }
})(jQuery);

