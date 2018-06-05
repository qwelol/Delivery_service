/* База данных */
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

/*Пользовательские типы данных и правила для них */
create type status
from varchar(10) not null
go
create rule statusRule
as
@x in ('отправлено', 'доставлено', 'отказано')
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

/* Создание таблиц */
CREATE TABLE Клиенты (
[Номер телефона][mphone] PRIMARY KEY,
[Номер паспорта][bigint] NULL,
[Фамилия][varchar](64) NOT NULL,
[Имя][varchar](64) NOT NULL,
[Отчество][varchar](64) NULL, 
[Электронная почта][email] NULL, 
[Адрес][varchar](512) NULL
)
GO
CREATE TABLE [Тип доставки] (
[Код доставки][tinyint] PRIMARY KEY,
[Тип доставки][varchar](32)NOT NULL,
[Цена][money] NOT NULL,
)
GO
CREATE TABLE [Весовая категория] (
[Код категории][tinyint] PRIMARY KEY,
[Название][varchar](32)NOT NULL,
[Наценка][real] NOT NULL,
)
GO
CREATE TABLE [Город] (
[Код города][int] PRIMARY KEY,
[Название][varchar](32)NOT NULL,
[Область][varchar](64) NOT NULL,
[Телефонный код][smallint] NOT NULL,
)
GO
CREATE TABLE [Пункт выдачи] (
[Код пункта][int] PRIMARY KEY,
[Код города][int] NOT NULL,
[Адрес][varchar](512)NOT NULL,
[Городской телефон][int] NOT NULL,
[Мобильный телефон][mphone] NULL,
[Центральный пункт][bit] NOT NULL,
)
GO
CREATE TABLE [Отказанное отправление] (
[Код посылки][int] PRIMARY KEY,
[Дата отказа][datetime] NOT NULL,
[Причина][varchar](512)NOT NULL,
[Решение][varchar](512) NULL
)
GO
CREATE TABLE [Содержимое] (
[Код посылки][int] NOT NULL,
[Наименование товара][varchar](256) NOT NULL,
[Объявленная стоимость][money] NOT NULL,
[Количество][smallint] NOT NULL,
[Вес][real] NOT NULL,
)
GO
CREATE TABLE [Отправление] (
[Код посылки][int] PRIMARY KEY,
[Отправитель][mphone] NOT NULL,
[Получатель][mphone] NOT NULL,
[Тип доставки][tinyint] NOT NULL,
[Весовая категория][tinyint] NOT NULL,
[Пункт отправления][int] NOT NULL,
[Пункт получения][int] NOT NULL,
[Дата отправления][datetime] NOT NULL,
[Стоимость][money] NOT NULL,
[Статус][status] NOT NULL,
[Дата получения][datetime] NULL,
[Комментарий][varchar](512) NULL,
)
GO
/* Привязка ограничений и значений по умолчанию к таблицам */
ALTER TABLE [Тип доставки]
ADD CONSTRAINT AK_Тип_доставки unique([Тип доставки]);
GO
ALTER TABLE [Весовая категория]
ADD CONSTRAINT AK_Весовая_категория unique([Название]);
GO
ALTER TABLE [Город]
ADD CONSTRAINT AK_Город unique([Телефонный код]);
GO
ALTER TABLE [Содержимое]  
ADD CONSTRAINT CK_Количество  CHECK (Количество > 0);  
GO
ALTER TABLE [Пункт выдачи]  
ADD CONSTRAINT Центральный_пункт_DEF DEFAULT 0 FOR [Центральный пункт] ;  
GO
ALTER TABLE [Отказанное отправление]  
ADD CONSTRAINT Дата_отказа_DEF DEFAULT GETDATE() FOR [Дата отказа] ;  
GO
ALTER TABLE [Отправление]  
ADD CONSTRAINT Дата_отправления_DEF DEFAULT GETDATE() FOR [Дата отправления] ;  
GO
ALTER TABLE [Содержимое]   
ADD CONSTRAINT PK_Содержимсое PRIMARY KEY ([Код посылки], [Наименование товара]);  
GO
ALTER TABLE [Отправление]     
ADD CONSTRAINT FK_Отправление_Пункт_выдачи FOREIGN KEY ([Пункт отправления])     
    REFERENCES [Пункт выдачи] ([Код пункта])          
;    
GO

ALTER TABLE [Пункт выдачи]     
ADD CONSTRAINT FK_Пункт_выдачи_Город FOREIGN KEY ([Код города])     
    REFERENCES [Город] ([Код города])          
;   
GO
ALTER TABLE [Отправление]     
ADD CONSTRAINT FK_Отправление_Пункт_выдачи_получения FOREIGN KEY ([Пункт получения])     
    REFERENCES [Пункт выдачи] ([Код пункта]) 
;    
GO

ALTER TABLE [Отправление]     
ADD CONSTRAINT FK_Отправление_Клиент FOREIGN KEY ([Отправитель])     
    REFERENCES [Клиенты] ([Номер телефона]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [Отправление]     
ADD CONSTRAINT FK_Отправление_Получатель FOREIGN KEY ([Получатель])     
    REFERENCES [Клиенты] ([Номер телефона]) 
;    
GO
ALTER TABLE [Отправление]     
ADD CONSTRAINT FK_Отправление_Тип_доставки FOREIGN KEY ([Тип доставки])     
    REFERENCES [Тип доставки] ([Код доставки]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [Отправление]     
ADD CONSTRAINT FK_Отправление_Весовая_категория FOREIGN KEY ([Весовая категория])     
    REFERENCES [Весовая категория] ([Код категории]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [Содержимое]     
ADD CONSTRAINT FK_Содержимое_Отправление FOREIGN KEY ([Код посылки])     
    REFERENCES [Отправление] ([Код посылки]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
ALTER TABLE [Отказанное отправление]     
ADD CONSTRAINT FK_Отказанное_Отправление FOREIGN KEY ([Код посылки])     
    REFERENCES [Отправление] ([Код посылки]) 
    ON DELETE CASCADE 
    ON UPDATE CASCADE
;    
GO
--Создание представлений
create view dispatch_without_codes
as
select Отправитель, Получатель, [Тип доставки].[Тип доставки], [Весовая категория].Название as 'Весовая категория',
 [Дата отправления],pv_cities.Адрес, Стоимость, Статус, [Дата получения], Комментарий
from (Отправление inner join [Тип доставки] on Отправление.[Тип доставки]=[Тип доставки].[Код доставки]) 
inner join [Весовая категория] on Отправление.[Весовая категория]=[Весовая категория].[Код категории] 
inner join pv_cities on Отправление.[Пункт отправления]=pv_cities.[Код пункта]
go
create view pv_cities
as 
select [Пункт выдачи].[Код пункта] as 'Код пункта', Название as 'Город', Адрес, (CAST([Телефонный код] AS varchar)+'-'+CAST([Городской телефон] AS varchar)) AS [Городской телефон], [Мобильный телефон]
from [Пункт выдачи] inner join Город on [Пункт выдачи].[Код города]=Город.[Код города]
go
create view number_of_failures
as 
select COUNT([Код посылки]) As 'Количество отказов'
from Отправление
where Статус='отказано'
go
select *
from  dispatch_without_codes
--Создание ХП
CREATE PROCEDURE Search_pv 
@x varchar(32) 
AS 
SELECT [Код пункта],[Название] AS Город, Адрес, (CAST([Телефонный код] AS varchar)+'-'+CAST([Городской телефон] AS varchar)) AS [Городской телефон] , [Мобильный телефон]
FROM [Пункт выдачи] INNER JOIN Город ON [Пункт выдачи].[Код города]=Город.[Код города]
WHERE Название=@x
GO
CREATE PROCEDURE Update_pv 
@a int,
@x varchar(512), 
@y int,
@z mphone
AS 
UPDATE [Пункт выдачи]
SET Адрес=@x, [Городской телефон]=@y, [Мобильный телефон]=@z
WHERE [Код пункта]=@a
GO
CREATE PROCEDURE Get_city
@city varchar(512),
@Code int OUTPUT
AS
SELECT @Code=[Код города]
FROM Город
WHERE Название=@city
GO
CREATE PROCEDURE Get_pv_last
@Code int OUTPUT
AS
SELECT TOP 1 @Code=[Код пункта]
FROM [Пункт выдачи]
ORDER BY [Код пункта] DESC
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
INSERT INTO [Пункт выдачи]
VALUES (@code_pv,@code, @x, @y, @z, 0)
GO

CREATE PROCEDURE Delete_pv 
@pynkt int
AS
DELETE FROM [Пункт выдачи]
WHERE [Код пункта]=@pynkt
GO

CREATE TRIGGER Delete_pv_trig ON [Пункт выдачи]
INSTEAD OF DELETE 
AS
declare @existence int 
declare @code int
SELECT TOP 1 @existence=[Код посылки]
FROM Отправление
WHERE Статус='отправлено' and ([Пункт отправления] IN (SELECT [Код пункта] FROM deleted)
 or [Пункт получения] IN (SELECT [Код пункта] FROM deleted))
IF (@existence IS NOT NULL)
ROLLBACK TRAN
ELSE 
BEGIN
SELECT @code=[Код пункта] FROM deleted
DELETE FROM [Отправление]
WHERE [Пункт отправления]=@code OR [Пункт получения]=@code
DELETE FROM [Пункт выдачи]
WHERE [Код пункта]=@code
END
GO
CREATE PROCEDURE Change_main_pv 
@city varchar(512)
AS
SELECT Адрес
FROM [Пункт выдачи]inner join Город ON [Пункт выдачи].[Код города]=Город.[Код города]
WHERE Название=@city and [Центральный пункт]=0
GO
CREATE PROCEDURE Show_main_pv 
@city varchar(512)
AS
SELECT Адрес
FROM [Пункт выдачи]inner join Город ON [Пункт выдачи].[Код города]=Город.[Код города]
WHERE Название=@city and [Центральный пункт]=1
GO
CREATE PROCEDURE Insert_Change_main_pv 
@city varchar(512),
@p2 varchar(512)
AS
declare @code int
exec Get_city @city, @code OUTPUT
UPDATE [Пункт выдачи]
SET [Центральный пункт]=0
WHERE [Центральный пункт]=1 and [Код города]=@code
UPDATE [Пункт выдачи]
SET [Центральный пункт]=1
WHERE Адрес=@p2 AND [Код города]=@code
GO
create proc show_value
@td varchar(512) 
as
Select [Цена]
from [Тип доставки]
where [Тип доставки]=@td
GO
create proc change_value
@td varchar(512),
@value real
as
UPDATE [Тип доставки]
SET [Цена]=CONVERT(money, @value)
WHERE [Тип доставки] = @td;
go
create proc show_VK_charge
@vk varchar(512) 
as
Select [Наценка]
from [Весовая категория]
where [Название]=@vk
go
create proc change_charge
@vk varchar(512),
@value real
as
UPDATE [Весовая категория]
SET [Наценка]=@value
WHERE [Название]=@vk
go
create proc del_vk
@vk varchar(512) 
as
delete from [Весовая категория]
WHERE [Название]=@vk
go
CREATE TRIGGER Delete_vk_trig ON [Весовая категория]
INSTEAD OF DELETE 
AS
declare @existence int 
declare @code int
SELECT TOP 1 @existence=[Код посылки]
FROM Отправление
WHERE Статус='отправлено' and ([Весовая категория] IN (SELECT [Код категории] FROM deleted))
IF (@existence IS NOT NULL)
ROLLBACK TRAN
ELSE 
BEGIN
SELECT @code=[Код категории] FROM deleted
DELETE FROM [Отправление]
WHERE [Весовая категория]=@code
DELETE FROM [Весовая категория]
WHERE [Код категории]=@code
END
go
create proc get_last_vk_code
@code tinyint OUTPUT 
as
select top 1 @code=[Код категории]
from [Весовая категория]
order by [Код категории] desc
go
create proc ins_vk
@vk varchar (512),
@charge tinyint
as
declare @code tinyint
exec get_last_vk_code @code OUTPUT
insert into [Весовая категория]
values (@code+1, @vk, @charge)
go
create proc show_city
as
select [Название],[Область],[Телефонный код]
from [Город]
go
create proc del_city
@city  varchar (512)
as
delete from [Город]
WHERE [Название]=@city
go
create proc get_last_city_code
@code int OUTPUT 
as
select top 1 @code=[Код города]
from [Город]
order by [Код города] desc
go
create proc ins_city
@city varchar (512),
@area varchar (512),
@phone_code int
as
declare @code int
exec get_last_city_code @code OUTPUT
insert into [Город]
values (@code+1, @city, @area, @phone_code)
go
create PROCEDURE Search_client_fam 
@fam varchar(32) 
AS
SELECT [Номер телефона], [Номер паспорта],[Фамилия],[Имя],[Отчество], [Электронная почта], [Адрес]
FROM Клиенты 
WHERE [Фамилия] LIKE '%'+@fam+'%'
go
CREATE PROCEDURE Search_client_phone 
@phone mphone
AS 
SELECT [Номер телефона], [Номер паспорта], [Фамилия], [Имя], [Отчество], [Электронная почта], [Адрес]
FROM Клиенты
WHERE [Номер телефона]=@phone
go
create proc del_client
@phone mphone
as
delete from Клиенты
WHERE [Номер телефона]=@phone
go
CREATE TRIGGER Delete_client_trig ON Клиенты
INSTEAD OF DELETE 
AS
declare @existence int 
declare @phone mphone
SELECT TOP 1 @existence=[Код посылки]
FROM Отправление
WHERE Статус='отправлено' and ([Отправитель] IN (SELECT [Номер телефона] FROM deleted) or [Получатель] IN (SELECT [Номер телефона] FROM deleted))
IF (@existence IS NOT NULL)
ROLLBACK TRAN
ELSE 
BEGIN
SELECT @phone=[Номер телефона] FROM deleted
DELETE FROM [Отправление]
WHERE [Получатель]=@phone OR [Отправитель]=@phone
DELETE FROM Клиенты
WHERE [Номер телефона]=@phone
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
UPDATE Клиенты
SET [Номер телефона]=@newphone,
 [Номер паспорта]=@pas,
 [Фамилия]=@fam,
 [Имя]=@name,
 [Отчество]=@surname,
 [Электронная почта]=@mail,
 [Адрес]=@adr
WHERE [Номер телефона] = @oldphone;
go
create TRIGGER update_client_trig ON Клиенты
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
select @old_phone=[Номер телефона] from deleted
select @new_phone=[Номер телефона] from inserted
select @pas=[Номер паспорта] from inserted
select @fam=[Фамилия] from inserted
select @name=[Имя] from inserted
select @surname=[Отчество] from inserted
select @mail=[Электронная почта] from inserted
select @adr=[Адрес] from inserted
if (@old_phone = @new_phone)
  begin
        UPDATE Клиенты set
        [Номер телефона]= @old_phone,
        [Номер паспорта]=@pas,
        [Фамилия]=@fam,
        [Имя]=@name,
        [Отчество]=@surname,
        [Электронная почта]=@mail,
        [Адрес]=@adr
       WHERE [Номер телефона] = @old_phone;
  end
else 
  begin
    if (@new_phone in (select [Номер телефона] from Клиенты ))
     rollback tran
     else
      begin
		insert into Клиенты
		values (@new_phone, @pas, @fam, @name, @surname, @mail, @adr)	    
        UPDATE [Отправление] 
        SET     
        [Отправитель]= @new_phone
        where [Отправитель]= @old_phone
        
        UPDATE [Отправление] 
        SET     
        [Получатель]= @new_phone
        where [Получатель]= @old_phone
                
       delete from Клиенты 
       WHERE [Номер телефона] = @old_phone;        
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
insert into Клиенты
values (@phone, @pas,@fam, @name, @surname, @mail, @adr)

