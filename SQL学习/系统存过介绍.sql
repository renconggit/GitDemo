--����ϵͳ���
--1
exec sp_databases  --��ѯ�������ݿ� ���ز��� DATABASE_NAME ���ݿ����� DATABASE_SIZE ���ݿ��С

exec sp_tables --�鿴���ݿ�����б� EXEC sp_tables Table_1, dbo, CESHI, NULL

exec sp_columns tt--�鿴�� tt����

exec sp_helpindex tt --�鿴tt�������  Ĭ�ϵ�����

exec sp_helpConstraint tt--Լ�� ����Լ��

exec sp_stored_procedures --���ڷ��ص�ǰ���ݿ��еĴ洢���̵��嵥��

exec sp_helptext 'sp_stored_procedures';--�鿴�洢���̴������������ �����õ���仰���鿴�洢���̣�like sp_helptext sp_getLoginInfo.

exec sp_rename tt, tt;--�޸ı��������е�����

exec sp_renamedb myTempDB, myDB;--�������ݿ�����

exec sp_defaultdb 'master', 'myDB';--���ĵ�¼����Ĭ�����ݿ�

exec sp_helpdb;--���ݿ��������ѯ���ݿ���Ϣ

exec sp_helpdb master;