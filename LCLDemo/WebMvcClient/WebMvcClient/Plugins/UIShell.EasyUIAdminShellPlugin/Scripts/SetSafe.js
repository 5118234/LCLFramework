//�������վ�㼰����IE��ȫ����

try
{
	var internetSet = "HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\";
	var zoneMapDomains = internetSet + "ZoneMap\\Domains\\";
	var zoneMapRanges = internetSet + "ZoneMap\\Ranges\\";
	var zonesActivexPolicy = internetSet + "Zones\\2\\1201";

	var WshShell=new ActiveXObject("WScript.Shell");

	//�������վ��. ���Ϊhttp://www.123.com, ������userSite="123.com"
	var userSiteDomain = "cfca.com.cn";
	WshShell.RegWrite(zoneMapDomains + userSiteDomain + "\\" , "");
	WshShell.RegWrite(zoneMapDomains + userSiteDomain + "\\www\\", "");
	WshShell.RegWrite(zoneMapDomains + userSiteDomain + "\\www\\http", "2", "REG_DWORD");
	//var userSiteIP = "";
	//WshShell.RegWrite(zoneMapRanges + "Range1\\","");
	//WshShell.RegWrite(zoneMapRanges + "Range1\\:Range", userSiteIP, "REG_SZ");
	//WshShell.RegWrite(zoneMapRanges + "Range1\\http", "2", "REG_DWORD");

	//������δ���Ϊ�ɰ�ȫִ�нű���ActiveX�ؼ���ʼ����ִ�нű������ã�0���ã�1��ʾ��3���ã�
	WshShell.RegWrite(zonesActivexPolicy, "0", "REG_DWORD");

	//WScript.Echo("���óɹ���");
}
catch(e)
{
	//if(e.description.length != 0)
	//	WScript.Echo("����ʧ�ܣ�������Ϣ��"+e.description);
	//else
	//	WScript.Echo("����ʧ�ܣ�");
}
