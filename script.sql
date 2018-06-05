/* ���� ������ */
USE [master]
GO
CREATE DATABASE Delivery_service
ON PRIMARY
(
NAME = 'Delivery_service',
FILENAME = 'D:\546\Delivery_service.mdf',
SIZE =5,
MAXSIZE=50,
FILEGROWTH=1
)
LOG ON
(
NAME = 'Delivery_service_log',
FILENAME = 'D:\546\Delivery_service_log.ldf',
SIZE =5,
MAXSIZE=50,
FILEGROWTH=1
)
GO
use Delivery_service
GO

/*���������������� ���� ������ � ������� ��� ��� */
create type status
from varchar(10) not null
go
create rule statusRule
as
@x in ('����������', '����������', '��������')
go
exec sp_bindrule 'statusRule', 'status'
go
create type email
from varchar(30)
go
create rule emailRule
as
@x like '%_@_%_.__%'
go
exec sp_bindrule 'emailRule', 'email'
go
create type mphone 
from varchar(12)not null
go
create rule mphonelRule
as
@x like '%+7_%___%'
go
exec sp_bindrule 'mphonelRule', 'mphone'
go

/* �������� ������ */
CREATE TABLE ������� (
[����� ��������][mphone] PRIMARY KEY,
[����� ��������][bigint] NULL,
[�������][varchar](64) NOT NULL,
[���][varchar](64) NOT NULL,
[��������][varchar](64) NULL, 
[����������� �����][email] NULL, 
[�����][varchar](512) NULL
)
GO
CREATE TABLE [��� ��������] (
[��� ��������][tinyint] PRIMARY KEY,
[��� ��������][varchar](32)NOT NULL,
[����][money] NOT NULL,
)
GO
CREATE TABLE [������� ���������] (
[��� ���������][tinyint] PRIMARY KEY,
[��������][varchar](32)NOT NULL,
[�������][real] NOT NULL,
)
GO
CREATE TABLE [�����] (
[��� ������][int] PRIMARY KEY,
[��������][varchar](32)NOT NULL,
[�������][varchar](64) NOT NULL,
[���������� ���][smallint] NOT NULL,
)
GO
CREATE TABLE [����� ������] (
[��� ������][int] PRIMARY KEY,
[��� ������][int] NOT NULL,
[�����][varchar](512)NOT NULL,
[��������� �������][int] NOT NULL,
[��������� �������][mphone] NULL,
[����������� �����][bit] NOT NULL,
)
GO
CREATE TABLE [���������� �����������] (
[��� �������][int] PRIMARY KEY,
[���� ������][datetime] NOT NULL,
[�������][varchar](512)NOT NULL,
[�������][varchar](512) NULL
)
GO
CREATE TABLE [����������] (
[��� �������][int] NOT NULL,
[������������ ������][varchar](256) NOT NULL,
[����������� ���������][money] NOT NULL,
[����������][smallint] NOT NULL,
[���][real] NOT NULL,
)
GO
CREATE TABLE [�����������] (
[��� �������][int] PRIMARY KEY,
[�����������][mphone] NOT NULL,
[����������][mphone] NOT NULL,
[��� ��������][tinyint] NOT NULL,
[������� ���������][tinyint] NOT NULL,
[����� �����������][int] NOT NULL,
[����� ���������][int] NOT NULL,
[���� �����������][datetime] NOT NULL,
[���������][money] NOT NULL,
[������][status] NOT NULL,
[���� ���������][datetime] NULL,
[�����������][varchar](512) NULL,
)
GO
/* �������� ����������� � �������� �� ��������� � �������� */
ALTER TABLE [��� ��������]
ADD CONSTRAINT AK_���_�������� unique([��� ��������]);
GO
ALTER TABLE [������� ���������]
ADD CONSTRAINT AK_�������_��������� unique([��������]);
GO
ALTER TABLE [�����]
ADD CONSTRAINT AK_����� unique([���������� ���]);
GO
ALTER TABLE [����������]  
ADD CONSTRAINT CK_����������  CHECK (���������� > 0);  
GO
ALTER TABLE [����� ������]  
ADD CONSTRAINT �����������_�����_DEF DEFAULT 0 FOR [����������� �����] ;  
GO
ALTER TABLE [���������� �����������]  
ADD CONSTRAINT ����_������_DEF DEFAULT GETDATE() FOR [���� ������] ;  
GO
ALTER TABLE [�����������]  
ADD CONSTRAINT ����_�����������_DEF DEFAULT GETDATE() FOR [���� �����������] ;  
GO
ALTER TABLE [����������]   
ADD CONSTRAINT PK_����������� PRIMARY KEY ([��� �������], [������������ ������]);  
GO
ALTER TABLE [�����������]     
ADD CONSTRAINT FK_�����������_�����_������ FOREIGN KEY ([����� �����������])     
    REFERENCES [����� ������] ([��� ������])          
;    
GO

ALTER TABLE [����� ������]     
ADD CONSTRAINT FK_�����_������_����� FOREIGN KEY ([��� ������])     
    REFERENCES [�����] ([��� ������])          
;   
GO
ALTER TABLE [�����������]     
ADD CONSTRAINT FK_�����������_�����_������_��������� FOREIGN KEY ([����� ���������])     
    REFERENCES [����� ������] ([��� ������]) 
;    
GO

ALTER TABLE [�����������]     
ADD CONSTRAINT FK_�����������_������ FOREIGN KEY ([�����������])     
    REFERENCES [�������] ([����� ��������]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [�����������]     
ADD CONSTRAINT FK_�����������_���������� FOREIGN KEY ([����������])     
    REFERENCES [�������] ([����� ��������]) 
;    
GO
ALTER TABLE [�����������]     
ADD CONSTRAINT FK_�����������_���_�������� FOREIGN KEY ([��� ��������])     
    REFERENCES [��� ��������] ([��� ��������]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [�����������]     
ADD CONSTRAINT FK_�����������_�������_��������� FOREIGN KEY ([������� ���������])     
    REFERENCES [������� ���������] ([��� ���������]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [����������]     
ADD CONSTRAINT FK_����������_����������� FOREIGN KEY ([��� �������])     
    REFERENCES [�����������] ([��� �������]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [���������� �����������]     
ADD CONSTRAINT FK_����������_����������� FOREIGN KEY ([��� �������])     
    REFERENCES [�����������] ([��� �������]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
--�������� �������������
create view dispatch_without_codes
as
select �����������, ����������, [��� ��������].[��� ��������], [������� ���������].�������� as '������� ���������',
 [���� �����������],pv_cities.�����, ���������, ������, [���� ���������], �����������
from (����������� inner join [��� ��������] on �����������.[��� ��������]=[��� ��������].[��� ��������]) 
inner join [������� ���������] on �����������.[������� ���������]=[������� ���������].[��� ���������] 
inner join pv_cities on �����������.[����� �����������]=pv_cities.[��� ������]
go
create view pv_cities
as 
select [����� ������].[��� ������] as '��� ������', �������� as '�����', �����, (CAST([���������� ���] AS varchar)+'-'+CAST([��������� �������] AS varchar)) AS [��������� �������], [��������� �������]
from [����� ������] inner join ����� on [����� ������].[��� ������]=�����.[��� ������]
go
create view number_of_failures
as 
select COUNT([��� �������]) As '���������� �������'
from �����������
where ������='��������'
go
select *
from  dispatch_without_codes
--�������� ��
CREATE PROCEDURE Search_pv 
@x varchar(32) 
AS 
SELECT [��� ������],[��������] AS �����, �����, (CAST([���������� ���] AS varchar)+'-'+CAST([��������� �������] AS varchar)) AS [��������� �������] , [��������� �������]
FROM [����� ������] INNER JOIN ����� ON [����� ������].[��� ������]=�����.[��� ������]
WHERE ��������=@x
GO
CREATE PROCEDURE Update_pv 
@a int,
@x varchar(512), 
@y int,
@z mphone
AS 
UPDATE [����� ������]
SET �����=@x, [��������� �������]=@y, [��������� �������]=@z
WHERE [��� ������]=@a
GO
CREATE PROCEDURE Get_city
@city varchar(512),
@Code int OUTPUT
AS
SELECT @Code=[��� ������]
FROM �����
WHERE ��������=@city
GO
CREATE PROCEDURE Get_pv_last
@Code int OUTPUT
AS
SELECT TOP 1 @Code=[��� ������]
FROM [����� ������]
ORDER BY [��� ������] DESC
GO
CREATE PROCEDURE Insert_pv 
@city varchar(512),
@x varchar(512), 
@y int,
@z mphone
AS 
declare @code int
declare @code_pv int
exec Get_city @city, @code OUTPUT
exec Get_pv_last @code_pv OUTPUT
set @code_pv = @code_pv+1
INSERT INTO [����� ������]
VALUES (@code_pv,@code, @x, @y, @z, 0)
GO

CREATE PROCEDURE Delete_pv 
@pynkt int
AS
DELETE FROM [����� ������]
WHERE [��� ������]=@pynkt
GO

CREATE TRIGGER Delete_pv_trig ON [����� ������]
INSTEAD OF DELETE 
AS
declare @existence int 
declare @code int
SELECT TOP 1 @existence=[��� �������]
FROM �����������
WHERE ������='����������' and ([����� �����������] IN (SELECT [��� ������] FROM deleted)
 or [����� ���������] IN (SELECT [��� ������] FROM deleted))
IF (@existence IS NOT NULL)
ROLLBACK TRAN
ELSE 
BEGIN
SELECT @code=[��� ������] FROM deleted
DELETE FROM [�����������]
WHERE [����� �����������]=@code OR [����� ���������]=@code
DELETE FROM [����� ������]
WHERE [��� ������]=@code
END
GO
CREATE PROCEDURE Change_main_pv 
@city varchar(512)
AS
SELECT �����
FROM [����� ������]inner join ����� ON [����� ������].[��� ������]=�����.[��� ������]
WHERE ��������=@city and [����������� �����]=0
GO
CREATE PROCEDURE Show_main_pv 
@city varchar(512)
AS
SELECT �����
FROM [����� ������]inner join ����� ON [����� ������].[��� ������]=�����.[��� ������]
WHERE ��������=@city and [����������� �����]=1
GO
CREATE PROCEDURE Insert_Change_main_pv 
@city varchar(512),
@p2 varchar(512)
AS
declare @code int
exec Get_city @city, @code OUTPUT
UPDATE [����� ������]
SET [����������� �����]=0
WHERE [����������� �����]=1 and [��� ������]=@code
UPDATE [����� ������]
SET [����������� �����]=1
WHERE �����=@p2 AND [��� ������]=@code
GO
create proc show_value
@td varchar(512) 
as
Select [����]
from [��� ��������]
where [��� ��������]=@td
GO
create proc change_value
@td varchar(512),
@value real
as
UPDATE [��� ��������]
SET [����]=CONVERT(money, @value)
WHERE [��� ��������] = @td;
go
create proc show_VK_charge
@vk varchar(512) 
as
Select [�������]
from [������� ���������]
where [��������]=@vk
go
create proc change_charge
@vk varchar(512),
@value real
as
UPDATE [������� ���������]
SET [�������]=@value
WHERE [��������]=@vk
go
create proc del_vk
@vk varchar(512) 
as
delete from [������� ���������]
WHERE [��������]=@vk
go
CREATE TRIGGER Delete_vk_trig ON [������� ���������]
INSTEAD OF DELETE 
AS
declare @existence int 
declare @code int
SELECT TOP 1 @existence=[��� �������]
FROM �����������
WHERE ������='����������' and ([������� ���������] IN (SELECT [��� ���������] FROM deleted))
IF (@existence IS NOT NULL)
ROLLBACK TRAN
ELSE 
BEGIN
SELECT @code=[��� ���������] FROM deleted
DELETE FROM [�����������]
WHERE [������� ���������]=@code
DELETE FROM [������� ���������]
WHERE [��� ���������]=@code
END
go
create proc get_last_vk_code
@code tinyint OUTPUT 
as
select top 1 @code=[��� ���������]
from [������� ���������]
order by [��� ���������] desc
go
create proc ins_vk
@vk varchar (512),
@charge tinyint
as
declare @code tinyint
exec get_last_vk_code @code OUTPUT
insert into [������� ���������]
values (@code+1, @vk, @charge)
go
create proc show_city
as
select [��������],[�������],[���������� ���]
from [�����]
go
create proc del_city
@city  varchar (512)
as
delete from [�����]
WHERE [��������]=@city
go
create proc get_last_city_code
@code int OUTPUT 
as
select top 1 @code=[��� ������]
from [�����]
order by [��� ������] desc
go
create proc ins_city
@city varchar (512),
@area varchar (512),
@phone_code int
as
declare @code int
exec get_last_city_code @code OUTPUT
insert into [�����]
values (@code+1, @city, @area, @phone_code)
go
create PROCEDURE Search_client_fam 
@fam varchar(32) 
AS
SELECT [����� ��������], [����� ��������],[�������],[���],[��������], [����������� �����], [�����]
FROM ������� 
WHERE [�������] LIKE '%'+@fam+'%'
go
CREATE PROCEDURE Search_client_phone 
@phone mphone
AS 
SELECT [����� ��������], [����� ��������], [�������], [���], [��������], [����������� �����], [�����]
FROM �������
WHERE [����� ��������]=@phone
go
create proc del_client
@phone mphone
as
delete from �������
WHERE [����� ��������]=@phone
go
CREATE TRIGGER Delete_client_trig ON �������
INSTEAD OF DELETE 
AS
declare @existence int 
declare @phone mphone
SELECT TOP 1 @existence=[��� �������]
FROM �����������
WHERE ������='����������' and ([�����������] IN (SELECT [����� ��������] FROM deleted) or [����������] IN (SELECT [����� ��������] FROM deleted))
IF (@existence IS NOT NULL)
ROLLBACK TRAN
ELSE 
BEGIN
SELECT @phone=[����� ��������] FROM deleted
DELETE FROM [�����������]
WHERE [����������]=@phone OR [�����������]=@phone
DELETE FROM �������
WHERE [����� ��������]=@phone
END
go
create proc change_client
@newphone mphone,
@oldphone mphone,
@fam varchar(512),
@name varchar(512),
@pas bigint=NULL,
@surname varchar(512)=NULL,
@adr varchar(512)=NULL,
@mail email=NULL
as
UPDATE �������
SET [����� ��������]=@newphone,
 [����� ��������]=@pas,
 [�������]=@fam,
 [���]=@name,
 [��������]=@surname,
 [����������� �����]=@mail,
 [�����]=@adr
WHERE [����� ��������] = @oldphone;
go
create TRIGGER update_client_trig ON �������
INSTEAD OF UPDATE 
AS
declare @pas bigint
declare @fam varchar(512)
declare @name varchar(512)
declare @surname varchar(512)
declare @mail email
declare @adr varchar(512)
declare @old_phone mphone
declare @new_phone mphone
select @old_phone=[����� ��������] from deleted
select @new_phone=[����� ��������] from inserted
select @pas=[����� ��������] from inserted
select @fam=[�������] from inserted
select @name=[���] from inserted
select @surname=[��������] from inserted
select @mail=[����������� �����] from inserted
select @adr=[�����] from inserted
if (@old_phone = @new_phone)
  begin
        UPDATE ������� set
        [����� ��������]= @old_phone,
        [����� ��������]=@pas,
        [�������]=@fam,
        [���]=@name,
        [��������]=@surname,
        [����������� �����]=@mail,
        [�����]=@adr
       WHERE [����� ��������] = @old_phone;
  end
else 
  begin
    if (@new_phone in (select [����� ��������] from ������� ))
     rollback tran
     else
      begin
		insert into �������
		values (@new_phone, @pas, @fam, @name, @surname, @mail, @adr)	    
        UPDATE [�����������] 
        SET     
        [�����������]= @new_phone
        where [�����������]= @old_phone
        
        UPDATE [�����������] 
        SET     
        [����������]= @new_phone
        where [����������]= @old_phone
                
       delete from ������� 
       WHERE [����� ��������] = @old_phone;        
      end
  end
go
create proc insert_client
@phone mphone,
@fam varchar(512),
@name varchar(512),
@pas bigint=NULL,
@surname varchar(512)=NULL,
@adr varchar(512)=NULL,
@mail email=NULL
as
insert into �������
values (@phone, @pas,@fam, @name, @surname, @mail, @adr)

