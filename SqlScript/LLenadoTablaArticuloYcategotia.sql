--INSERT LAS CATEGORIAS
WITH tbl (a,b)as
(SELECT'Cereales' 	 ,'Cereales'                                                                                                                                                                                                                                                        
UNION SELECT'Verduras'	 ,'Verduras'                                                                                                                                                                                                                                                        
UNION SELECT'Frutas'	 ,'Frutas'                                                                                                                                                                                                                                                          
UNION SELECT'Red'	     ,'Red'                                                                                                                                                                                                                                                             
UNION SELECT'Aves'	     ,'Aves'                                                                                                                                                                                                                                                            
UNION SELECT'Porcino'	 ,'Porcino'                                                                                                                                                                                                                                                         
UNION SELECT'Enlatado'	 ,'Enlatado'                                                                                                                                                                                                                                                        
UNION SELECT'Grasas'	 ,'Grasas'                                                                                                                                                                                                                                                          
UNION SELECT'Dulces'	 ,'Dulces'                                                                                                                                                                                                                                                          
UNION SELECT'Lateos'	 ,'Lateos'                                                                                                                                                                                                                                                          
UNION SELECT'Bebidas'    ,'gaseosas')

select a[nombre],b[descripcion] into #temp from tbl

Begin tran --commit rollback

INSERT INTO [dbventas].[dbo].[categoria]
SELECT
	   nombre
      ,descripcion
FROM #temp

SELECT * FROM dbo.categoria
DROP TABLE #temp
go
  with ct (a,b,c,d,e,f,g,h)as
     ( SELECT 0	,'Arroz el Campo',            1,2500.00	,2300.00 ,100.00,1,1
UNION SELECT 0	,'Arroz la Garza',			  1,2450.00	,2200.00 ,50.00	,1,1
UNION SELECT 0	,'Guandules la famosa',		  1,810.00	,685.00	 ,4.00	,1,1
UNION SELECT 0	,'Maiz',					  1,900.00	,650.00	 ,2.00	,1,1
UNION SELECT 0	,'Cola Real',				  1,300.00	,400.00	 ,10.00	,1,1
UNION SELECT 0	,'Coca cola',				  1,500.00	,340.00	 ,1.00	,1,1
UNION SELECT 0	,'Leche Rica',				  1,600.00	,450.00	 ,1.00	,1,1
UNION SELECT 0	,'LECHE EVAPORADA CARNETION', 1,850.00	,620.00	 ,25.00	,1,1
UNION SELECT 0	,'AZUCAR PAPA GAYO BLANCA',	  1,2500.00	,2320.00 ,25.00	,1,1
UNION SELECT 0	,'ARROZ DON ARMANDO',		  1,1900.00	,1650.00 ,30.00 ,1,1)

select a  [codigo]
      ,b  [nombre]
	  ,c  [idcategoria]
	  ,d  [precioVenta]
	  ,e  [precioCompra]
	  ,f  [cantidad]
	  ,g  [estado]
	  ,h  [idProveedor]
	  INTO #tempo
 from ct

 begin tran --commit rollback

 INSERT INTO [dbventas].[dbo].[articulo] 

 
SELECT 
      [codigo]
     ,[nombre]
     ,[idcategoria]
     ,null[Imag_Url]
     ,null[descripcion]
     ,[precioVenta]
     ,[precioCompra]
     ,[cantidad]
     ,[estado]
     ,[idProveedor]
 FROM #tempo

 drop table #tempo