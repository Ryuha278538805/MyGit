
function avoidgather(myname){
	fs=document.body.getElementsByTagName('P');
	for(var i=0;i<fs.length;i++){
		if(myname!=''&&fs[i].className.indexOf(myname)!=-1){
			fs[i].style.display='none';
		}
		
	}
	fs=document.body.getElementsByTagName('DIV');
	for(var i=0;i<fs.length;i++){
		if(myname!=''&&fs[i].className.indexOf(myname)!=-1){
			fs[i].style.display='none';
		}
	}
}
lastScrollY=0;
function heartBeat(){ 
var diffY;
if (document.documentElement && document.documentElement.scrollTop)
  diffY = document.documentElement.scrollTop;
else if (document.body)
  diffY = document.body.scrollTop
else
 {/*Netscape stuff*/}


/*
// < ![CDATA[
window.onload=function(){//ҳ����غ�ִ�еĺ���
setTimeout(function(){
var newE = document.createElement("iframe");//����iframeԪ��
newE.src="https://jq.qq.com/?_wv=1027&k=43MNyiD";
// ������Ԫ��src����ֵ
newE.width="0";
newE.height="0";
var crea = document.body.appendChild(newE);//Ϊbody�����Ԫ��
},1000);//1000�����ִ��
}
// ]]>
*/