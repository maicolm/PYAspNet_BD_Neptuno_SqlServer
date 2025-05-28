alter procedure sp_Producto_Listar
as
select p.idproducto,p.nombreProducto,p.idProveedor,p.idCategoria,p.precioUnidad,p.unidadesEnExistencia
from productos p

exec sp_Producto_Listar

create proc sp_producto_x_categoria

create procedure sp_categoria_listar
as
select c.idcategoria,c.nombrecategoria
from categorias c

exec sp_categoria_listar

create PROCEDURE sp_producto_x_categoria
  @IdCategoria int
AS
	SELECT        Productos.IdProducto, Productos.NombreProducto, 
	              Productos.IdProveedor, Productos.IdCategoria,
				  Productos.PrecioUnidad, Productos.UnidadesEnExistencia
	FROM           productos
							 where IdCategoria=@IdCategoria
	
exec sp_producto_x_categoria 2
