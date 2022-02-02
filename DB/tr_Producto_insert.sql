create TRIGGER [dbo].[tr_Producto_insert] on [dbo].[Productos]
	FOR INSERT
	AS
	BEGIN
	INSERT INTO Kardexs (IdProducto,Referencia,Nombre,Descripcion,IVA,IdunidadMedida,unidadMedidaId,Medida,Idestado,estadoId,IdCategoria,categoriaId,
	Idmarca,marcaId,Idproveedor,proveedorId,ModoVenta,StockMinimo,StockMaximo,Cantidad,Costo,PrecioVenta,CodigoBarras,
	SubCantidad,ValorSubcantidad,Sobres,ValorSobre,Idusuario,usuarioId,FechaRegistro,Movimiento,FechaVencimiento,Nota,Accion,UM)
	SELECT p.Id,p.Referencia,p.Nombre,p.Descripcion,p.IVA,p.IdunidadMedida,p.unidadMedidaId,p.Medida,p.Idestado,p.estadoId,p.IdCategoria,p.categoriaId,
	p.Idmarca,p.marcaId,p.Idproveedor,p.proveedorId,p.ModoVenta,p.StockMinimo,p.StockMaximo,p.Cantidad,p.Costo,p.PrecioVenta,p.CodigoBarras,
	p.SubCantidad,p.ValorSubcantidad,p.Sobres,p.ValorSobre,p.Idusuario,p.usuarioId,p.FechaRegistro,p.Movimiento,p.FechaVencimiento,p.Nota,'INSERT-PRODUCTO',
	CASE WHEN ModoVenta = 'Unidad' THEN
		'UND'
		ELSE
		CASE WHEN ModoVenta = 'Pesaje' THEN
		'Bulto'
		ELSE
		'Caja'
		END
	END
	FROM Productos p
	INNER JOIN unidadMedidas um ON um.Id = p.unidadMedidaId
	INNER JOIN categorias ct ON ct.Id = p.categoriaId
	INNER JOIN marcas m ON m.Id = p.marcaId
	INNER JOIN proveedores pr ON pr.id = p.proveedorId
	WHERE p.FechaRegistro = (SELECT MAX(FechaRegistro) FROM Productos)
	END