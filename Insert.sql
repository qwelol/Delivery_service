USE [Delivery_service]
GO 
INSERT INTO [��� ��������] VALUES
(1,'�����-�����', 570 ),
(2,'�����-�����', 470 ),
(3,'�����-�����', 350 ),
(4,'�����-�����', 290 )
GO
INSERT INTO [������� ���������]  VALUES
(1,'�� 1 ��', 1 ),
(2,'1-5 ��', 2 ),
(3,'5-10 ��', 4 ),
(4,'����� 10 ��', 8 )
GO
INSERT INTO [�������]  VALUES
('+79537368357',6111714863,'���������', '���������', '���������','VasilevaElizaveta101@yandex.ru', '��. �������, ��� 82, ��. 60' ),
('+78315967114',2567125489, '������', '������', '���������',NULL, '��. ������, ��� 32, ��.216' ),
('+79478727911',NULL, '����������', '��������', '����������', 'KudryavtsevaVioletta@mail.ru', NULL ),
('+79213451638',3925964823, '��������', '����', '����������','IgnatevYuriy22@gmail.com', '��. ������������, ��� 5, ��. 164' ),
('+79361433763',6010756214, '������', '������', NULL, 'ChaurinRatmir82@yahoo.com','��. �������������, ��� 13, ��. 270' ),
('+79437056116',7890672143, '������', '�����', '���������','VlasovVadim@bk.ru', '��. ������������, ��� 65, ��. 93'),
('+79581453399',4629857319, '��������', '������', '���������', NULL, '��. �������, ��� 35, ��. 174'),
('+79129503554',NULL, '���������', '�����', '���������', 'NikiforovTihon1@ya.ru', '��. ��������, ��� 88, ��. 51' ),
('+79586956429',3915714814, '��������', '���������', '��������', 'FedotovaValentina56@inbox.ru', NULL),
('+79378706550',5125681347, '�������', '�����', '�����������', NULL, '��. ������, ��� 55, ��. 113'),
('+79537368358',6111714865, '�������', '�������', '��������', 'nofakeboot@yandex.ru', NULL)
GO
INSERT INTO [�����]  VALUES
(1, '������', '����������', 495),
(2, '������', '���������', 4912),
(3, '�����-���������', '�������������', 812),
(4, '������ ��������', '�������������', 8312),
(5, '����', '��������', 4872),
(6, '�������', '�����������', 4732),
(7, '�������', '�����������', 8452),
(8, '������', '���������', 8462),
(9, '���������', '�����������', 8202),
(10, '������',	'���������',	4842)
GO
INSERT INTO [����� ������]  VALUES
(1, 2, '��. �����������, ��� 14', 48378, '+79331278498', 0), 
(2, 7, '��. �������, ��� 92', 10930, '+79331128498', 1),
(3, 4, '��. �����������, ��� 14', 39801, NULL, 1),
(4, 2, '��. ���������, ��� 98', 95456, '+79331278798', 1),
(5, 8, '��. �������, ��� 6,', 17721, '+79665937797', 1),
(6, 4, '��. �����������, ��� 4', 22642, '+79764486127', 0),
(7, 3, '��. ����������, ��� 20', 27001, '+79651501917', 1),
(8, 10, '��. ���������, ��� 85', 96483, '+79612467497', 1),
(9, 4, '��. ����������, ��� 10', 38155, NULL, 0),
(10, 9, '��. ������, ��� 91', 99513, '+79417249919', 1),
(11, 8, '��. ������, ��� 22', 43689, '+79179867532', 0),
(12, 1, '��. ����������, ��� 3', 40558,'+79113138979', 0),
(13, 1, '��. 15 ��� �������, ��� 53', 19207, '+79582322897', 0), 
(14, 7, '��. �����������, ��� 4', 46528, '+79808757680', 0),
(15, 8, '��. �������, ��� 35', 77518, '+79729927376', 0),
(16, 5, '��. ��������, ��� 93', 14511, '+79729927376', 1),
(17, 1, '��. �������, ��� 5', 18466, '+79102647740', 1), 
(18, 6, '��. �������, ��� 75', 78762, '+79789024130', 1),
(19, 7, '��. ���������, ��� 52', 90870, '+79725912363', 0),
(20, 7, '��. �����, ��� 35', 86719, '+79001473215', 0)
GO
INSERT INTO [�����������]  VALUES
(1,'+78315967114', '+79478727911', 3, 3, 1, 4, convert(datetime,'25-04-18 12:32:11',5), 0,'����������', convert(datetime,'01-05-18 12:32:11',5) , NULL),
(2,'+79213451638', '+79378706550', 3, 2, 12, 14, convert(datetime,'03-05-18 12:32:11',5) , 0, '����������', NULL, NULL),
(3,'+79537368357', '+79129503554', 1, 1, 1, 11, convert(datetime,'23-01-18 12:32:11',5) , 0, '����������', convert(datetime,'02-02-18 12:32:11',5) , '������� Rumicom'),
(4,'+79378706550', '+79129503554', 4, 1, 1, 16, convert(datetime,'25-06-18 12:32:11',5) , 0, '����������', NULL, NULL),
(5,'+79537368357', '+79437056116', 2, 2, 4, 19, convert(datetime,'04-05-18 12:32:11',5) , 0, '����������', NULL, '�� ���������'),
(6,'+79361433763', '+79537368357', 3, 4, 18, 5,convert(datetime,'23-06-18 12:32:11',5) , 0, '����������', NULL, NULL),
(7,'+78315967114', '+79129503554', 4, 1, 7, 2, convert(datetime,'19-06-18 12:32:11',5) , 0, '����������', NULL, '�� ������'),
(8,'+79361433763', '+79537368357', 3, 1, 14, 6, convert(datetime,'11-05-18 12:32:11',5), 0, '����������', NULL, NULL),
(9,'+79378706550', '+79437056116', 3, 4, 11, 19, convert(datetime,'28-01-18 12:32:11',5) , 0, '��������', NULL, NULL),
(10,'+78315967114', '+79129503554', 2, 2, 12, 18, convert(datetime,'08-05-18 12:32:11',5), 0, '����������', NULL, NULL),
(11,'+79213451638', '+79361433763', 4, 2, 12, 9, convert(datetime,'21-03-18 12:32:11',5) , 0, '����������', convert(datetime,'28-03-18 12:32:11',5) , NULL),
(12,'+79378706550', '+79437056116', 2, 2, 20, 4, convert(datetime,'28-03-18 12:32:11',5) , 0, '����������', convert(datetime,'05-04-18 12:32:11',5) , NULL),
(13,'+79537368357', '+79478727911', 2, 2, 17, 12, convert(datetime,'21-02-18 12:32:11',5), 0, '��������', NULL, NULL),
(14,'+79537368358', '+79581453399', 1, 3, 7, 15, convert(datetime,'20-04-18 12:32:11',5) , 0, '����������', convert(datetime,'30-04-18 12:32:11',5) , NULL),
(15,'+79586956429', '+79129503554', 2, 3, 9, 3, convert(datetime,'24-04-18 12:32:11',5) , 0, '����������', convert(datetime,'02-05-18 12:32:11',5) , NULL),
(16,'+78315967114', '+79213451638', 1, 2, 17, 5, convert(datetime,'05-05-18 12:32:11',5), 0, '����������', NULL, NULL),
(17,'+79361433763', '+79378706550', 2, 1, 19, 5, convert(datetime,'10-04-18 12:32:11',5), 0, '����������', convert(datetime,'15-04-18 12:32:11',5) , NULL),
(18,'+79437056116', '+79478727911', 4, 1, 20, 10, convert(datetime,'25-05-18 12:32:11',5), 0, '����������', NULL, NULL),
(19,'+79537368357', '+79537368358', 1, 2, 2, 10, convert(datetime,'09-03-18 12:32:11',5), 0, '����������', convert(datetime,'17-03-18 12:32:11',5) , NULL),
(20,'+79581453399', '+79586956429', 3, 4, 1, 19, convert(datetime,'27-01-18 12:32:11',5) , 0, '��������', NULL, NULL)
go
INSERT INTO [���������� �����������]  VALUES
(9, convert(datetime,'15-02-18 12:32:11',5), ' ����� ��������� � �������� ��������������� ', ' ���������� ����������� ��������� '),
(13, convert(datetime,'08-03-18 12:32:11',5), ' ���������� ��������� �� ���������' , '������� ����������� '),
(20, convert(datetime,'25-02-18 12:32:11',5), ' ���������� �� ������ ����������� ', '������� �����������')
go
INSERT INTO [����������]  VALUES
(1, ' ������ �������������� � ������ ', 400 , 3, 1),
(1, ' ������������� ��� ������ ', 1500 , 1, 2),
(2, ' ���� ��� ����� Royal Canin ', 500, 2, 1),
(2, ' �������� Excel Glucosamine ', 690, 1, 0.5),
(2, ' ������� �� ���� Beaphar ', 365, 2, 0.1),
(3, 'Xiaomi Redmi 4x 32GB (������)', 8994, 1, 0.5),
(4, ' �������� ������� XL ', 1200, 1, 0.2),
(5, ' �������� ���� Redmond 32-S ', 780, 1, 0.5),
(5, ' ������� ��������� Bosh MSM 66110 ', 3150, 1, 1),
(6, ' ���������� ������ Indesit  ', 11000, 1, 12),
(7, ' ������������� ������ ����� Oral-B ', 1080, 1, 0.4),
(8, ' ������� �����-������� ', 5000, 1, 0.1),
(8, ' �������� �� ����� ������������� ', 5000, 1, 0.1),
(9, ' ���������� ', 7600, 1, 5),
(9, ' �������������� ', 26000, 1, 10),
(9, ' �������� ������ ', 1000, 1, 1),
(10, ' ����������� ������ NOVA TOUR ', 4230, 1, 1.5),
(11, ' ������� ', 2400, 1, 1.2),
(12, ' Nintendo 3ds ', 5400, 2 , 0.5),
(12, ' �������� � ����� ��� Nintendo 3ds ', 2000, 2, 0.1),
(13, ' ���������� ����� ', 5000, 15, 0.1),
(14, ' �������� ������ ', 100, 1, 0.1),
(15, ' ������� ���������� ', 5422, 6, 1),
(16, ' ���������� GeForce GTX 1060 ', 18625, 1, 1.5),
(17, ' ����� ��� iPhone ', 250, 3, 0.1),
(17, ' ������� ��� iPhone ', 750, 2, 0.1),
(18, ' ��������� Nike ', 5000, 1, 0.8),
(19, ' ����������� Nikon D60 ', 12000, 1, 1.5),
(20, ' ������� Philips a32 ', 3670, 1, 5),
(20, ' ���� � ��������������� Philips ', 9100, 1, 6)
go