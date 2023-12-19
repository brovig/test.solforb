# �������� �������

���������� ��������� �� ASP.NET Core Web API � ������ � Angular.  
Web API ���������� �� ��������� Onion Architecture: ��� ���� ��������������� ���� � ������ ������ ����� ����������, ������������ � ����������� �����.  
  
## �����������

������� Domain ������ �������� ��������, ���������������� ���������� (Domain.Entities), � ����� ���������� ����������� (Domain.Contracts).  

������ Repository ��������� ��� ���������� � ����� �������� �� �������� ���� ������.  

������� Service ������ �������� ����������, ��������������� ������ ������ (Service.Contracts), � �� ���������� (Service).  

������ Presentation �������� ���������� �� ��������� ���������� (OrdersApp) �����������, � ����� ����� ��� ��������� �������. ��������� ������������ � ��������� ������ ��������� ������������� ��������� � ��� ����-���� ����� ����������� Service ������.   

������ WebUI �������� Angular ����������. ����������� ������� �������� � ����������� � ������� �������.  

## ��������� �������
����������� ����� ���������������� �������� ��� Create � Put ��������.  

## Global error handling
��������� ���������� ����������� � ������� ����������� middleware c ������������ ����� ��������� �������.  

## �����������
���������� � ������� NLog.  

## ����������
����������� ����� ��������� � ������ �������. ������ ������������ � ������� ��������, ����� query string ����� ����������� pagination �� ��������� � ���������� �����.  