/*
���� ����Ҽ���Ctrl+n��shift+F10��F5ˢ�¡��˸��
���� Alt+ ����� ��
���� Alt+ ����� ��
���� �˸�ɾ����
���� F5
���� F6
���� F11
���� Ctrl + R
���� Ctrl + I
���� Ctrl + O
���� Ctrl + H
���� Ctrl + L
���� Ctrl + B
���� Ctrl + W
���� Ctrl + N
���� Ctrl + D
���� Ctrl + E
���� shift+F10
*/

var ie= /msie [6789]/i.test(window.navigator.userAgent);
var WinSize;/*������������*/
var hr='\n������������������������������������������������         \n';

document.onselectstart= function(){if(window.event.srcElement.tagName != 'INPUT' && event.srcElement.tagName != 'TEXTAREA')return false;}
document.oncontextmenu=function(){return false;}
document.ondragstart=function(){return false;}
function KeyDown(){	//��������Ҽ���Ctrl+n��shift+F10��F5ˢ�¡��˸��
  if ((window.event.altKey && window.event.keyCode==37)||   //���� Alt+ ����� ��
	  (window.event.altKey && window.event.keyCode==39)		//���� Alt+ ����� ��
         //(window.event.keyCode==8)              //�����˸�ɾ����
	 ){
	   window.event.keyCode=0;
       window.event.returnValue=false;
     }
  if ((window.event.keyCode==116)||                       //���� F5
	  (window.event.keyCode==117)||                       //���� F6
	  (window.event.keyCode == 122) ||                    //���� F11
    //  (window.event.keyCode == 123) ||                    //���� F12
      (window.event.ctrlKey) ||                           //Ctrl
      (window.event.ctrlKey && window.event.keyCode==82)|| //Ctrl + R
	  (window.event.ctrlKey && window.event.keyCode==73)|| //Ctrl + I
      (window.event.ctrlKey && window.event.keyCode==79)|| //Ctrl + O
	  (window.event.ctrlKey && window.event.keyCode==72)|| //Ctrl + H
	  (window.event.ctrlKey && window.event.keyCode==76)|| //Ctrl + L
	  (window.event.ctrlKey && window.event.keyCode==66)|| //Ctrl + B
	  (window.event.ctrlKey && window.event.keyCode==87)|| //Ctrl + W
	  (window.event.ctrlKey && window.event.keyCode==78)|| //Ctrl + N
	  (window.event.ctrlKey && window.event.keyCode==68)|| //Ctrl + D
	  (window.event.ctrlKey && window.event.keyCode==69)|| //Ctrl + E
      (window.event.shiftKey && window.event.keyCode==121) //shift+F10
	  ) {
      try {
          window.event.keyCode = 0;
          window.event.returnValue = false;
      } catch (e) { 
       }
     }
  if ((window.event.altKey)&&(window.event.keyCode==115)){   //����Alt+F4
      window.showModelessDialog("about:blank","","dialogWidth:1px;dialogheight:1px");
      return false;
	}
}
document.onclick=function(){
  if (window.event.srcElement.tagName == "A" && window.event.shiftKey) //���� shift ���������¿�һ��ҳ
    window.event.returnValue = false; 
}
document.onkeydown = function () { KeyDown(); }
//����js����
function killerrors() { return true; } 
window.onerror = killerrors; 