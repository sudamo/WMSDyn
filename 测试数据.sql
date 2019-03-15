--BD_Users
INSERT INTO BD_Users(UserId,UserName,Password,GroupId,LogStatus,Creator,CreationDate,Modifier,ModificationDate,LastLoginDate,Description)
VALUES(10000,'Test','wpuCuAD{4&v?y',0,0,'Administrator','2000-01-01','','2000-01-01','2000-01-01','Test密码123')

--PRD_Mo
INSERT INTO PRD_Mo(Barcode,FID,FBillNo,FEntryId,FNumber,FQTY,FSEQ,GroupId,Times,Creator,Modifier,Description)
VALUES('000001',1,'MO000001',1,'3110601010136008',0.0,1,1,1,'Administrator','Administrator','测试')

--BD_Drawing
INSERT INTO BD_Drawing(FMaterialId,FNumber,FPath,FName,Suffix,FSize,Creator,Modifier,Description)
VALUES(100000,'3110601010136008','C:\\Temp','Test001.dwg','dwg',1000,'Administrator','Administrator','测试')

--BD_Material
INSERT INTO BD_Material(FMaterialId,FNumber,FName,FUseOrgId,FGroupId,FDocumentStatus,FForbidStatus,F_PAEZ_BRAND,F_PAEZ_SERIES,F_PAEZ_TRADE,F_PAEZ_CARSERIES,F_PAEZ_CARTYPE,F_PAEZ_COLOR,Creator,Modifier,Description)
VALUES(100000,'3110601010136008','五福金牛招财牛系列招财牛-超感皮3D单片米色座垫',100508,1,'C','A','网销','网销尊福系列','网销尊行','奥迪','15款奥迪TT(4座)','棕色','Administrator','Administrator','测试')

--Log_Operation
INSERT INTO Log_Operation(Barcode,FID,FBillNo,OperatorId,Operator,Client,IP,MAC,Creator,Description)
VALUES('000001',1,'MO000001',16394,'Administrator','testPC','192.168.3.1','testMAC','Administrator','测试')

SELECT TOP 1000 *  FROM BD_Users--可DROP
SELECT TOP 1000 *  FROM PRD_Mo--可DROP
SELECT TOP 1000 *  FROM BD_Drawing
SELECT TOP 1000 *  FROM RL_MTLDrawing
SELECT TOP 1000 *  FROM BD_Material--可DROP
SELECT TOP 1000 *  FROM DM_Template 
SELECT TOP 1000 *  FROM Log_Operation
