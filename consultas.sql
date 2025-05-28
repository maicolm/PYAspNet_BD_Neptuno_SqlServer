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
use Neptuno

CREATE PROCEDURE usp_Productos_Nombre
	@Nombre varchar(40)
AS
SELECT   p.IdProducto, p.NombreProducto, p.IdProveedor, p.IdCategoria, p.CantidadPorUnidad, 
         p.PrecioUnidad, p.UnidadesEnExistencia, p.UnidadesEnPedido, p.NivelNuevoPedido, 
                         p.Suspendido
FROM     Productos p	
WHERE  NombreProducto like @Nombre +'%'

exec usp_Productos_Nombre cer


CREATE PROCEDURE sp_Cliente_Listar
AS
	Select c.IdCliente,c.NombreCompañia
	from Clientes c

exec sp_Cliente_Listar


CREATE PROCEDURE sp_Pedido_Listar
       @IdCliente char(5)
AS
	select p.IdPedido,p.FechaPedido,p.Cargo
	from Pedidos p
	where p.IdCliente=@IdCliente
	
	Exec sp_Pedido_Listar 'WILMK'

	select p.IdPedido,p.FechaPedido,p.Cargo,p.IdCliente
	from Pedidos p