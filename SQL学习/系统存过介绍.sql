--常用系统存过
--1
exec sp_databases  --查询所有数据库 返回参数 DATABASE_NAME 数据库名称 DATABASE_SIZE 数据库大小

exec sp_tables --查看数据库的所有表 EXEC sp_tables Table_1, dbo, CESHI, NULL

exec sp_columns tt--查看列 tt表名

exec sp_helpindex tt --查看tt表的索引  默认的索引

exec sp_helpConstraint tt--约束 主键约束

exec sp_stored_procedures --用于返回当前数据库中的存储过程的清单。

exec sp_helptext 'sp_stored_procedures';--查看存储过程创建、定义语句 经常用到这句话来查看存储过程，like sp_helptext sp_getLoginInfo.

exec sp_rename tt, tt;--修改表、索引、列的名称

exec sp_renamedb myTempDB, myDB;--更改数据库名称

exec sp_defaultdb 'master', 'myDB';--更改登录名的默认数据库

exec sp_helpdb;--数据库帮助，查询数据库信息

exec sp_helpdb master;