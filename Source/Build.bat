echo off
title  ���ڷ�����վ��
ECHO "��������������������������������"
ECHO "��������������������������������"
ECHO "���                                                      ���"
ECHO "���      �������޿���-�����ǵ����������                 ���"
ECHO "���                                       --����С��     ���"
ECHO "��������������������������������"
echo.
echo.
path %SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319\

msbuild.exe LCL.sln /t:Rebuild /p:Configuration=Release /p:VisualStudioVersion=12.0


pause