﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.RepocitoryDbVentas;

using CapaEntidad.DbVentas;

namespace CapaDatos.RepocitoryDbVentas
{
    public class DventasData
    {

        #region articulo Datos
        public DataTable ListArticulos()
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "SP_GET_ARTICULO_LOAD";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }

        public DataTable ListarticulosX_Codigo(string codigo, int copia)
        {
            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "[dbo].[LIST_ARTICULOS_X_CODIGO]";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CODIGO", codigo);
                    cmd.Parameters.AddWithValue("@COPIAS", copia);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        public DataTable BuscarArticulo(string codigo, string nombre)
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "[dbo].[SP_GET_ARTICULOS_BUSCAR]";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        public int Registrar_Articulos(articulosEntitis articulo)
        {
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "SP_SET_INSERT_UPDATE_ARTICULO";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idarticulo", articulo.@idarticulo));
                        cmd.Parameters.Add(new SqlParameter("@codigo", articulo.codigo));
                        cmd.Parameters.Add(new SqlParameter("@nombre", articulo.nombre));
                        cmd.Parameters.Add(new SqlParameter("@idcategoria", articulo.idcategoria));
                        cmd.Parameters.Add(new SqlParameter("@Imag_Url", articulo.Imag_Url));
                        cmd.Parameters.Add(new SqlParameter("@descripcion", articulo.descripcion));
                        cmd.Parameters.Add(new SqlParameter("@precioVenta", articulo.precioVenta));
                        cmd.Parameters.Add(new SqlParameter("@precioCompra", articulo.precioCompra));
                        cmd.Parameters.Add(new SqlParameter("@cantidad", articulo.cantidad));
                        cmd.Parameters.Add(new SqlParameter("@estado", articulo.estado));
                        cmd.Parameters.Add(new SqlParameter("@idProveedor", articulo.idProveedor));

                        //cmd.Parameters.Add(new SqlParameter("@UsuarioModifica", null));
                        cmd.ExecuteNonQuery();
                        return 1;

                    }
                }

            }
            catch (Exception ex)
            {
                return 0;

                throw ex;
            }

        }
        public int EliminarArticulo(articulosEntitis articulo)
        {
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "[DBO].[SP_SET_DELETE_ARTICULO]";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@codigo", articulo.idarticulo));
                        cmd.Parameters.Add(new SqlParameter("@estado", articulo.estado));
                        cmd.ExecuteNonQuery();
                        return 1;
                    }

                }
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }
        public articulosEntitis BuscarArticuloXCodigo(string codigo)
        {
            articulosEntitis entity = null;
            try
            {
                using (dbventasEntity db = new dbventasEntity())
                {
                    var connection = db.Database.Connection as SqlConnection;
                    using (connection)
                    {
                        connection.Open();
                        string command = "[DBO].[SP_GET_ARTICULOS_BUSCAR_X_CODIGO]";
                        SqlCommand sqlCommand = new SqlCommand(command);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@codigo", codigo.ToUpper());
                        SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            entity = new articulosEntitis();
                            foreach (DataRow row in dt.Rows)
                            {
                                entity.idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                                entity.codigo = row["codigo"].ToString();
                                entity.nombre = row["nombre"].ToString();
                                entity.idcategoria = Convert.ToInt32(row["idcategoria"].ToString());
                                entity.Imag_Url = row["Imag_Url"].ToString();
                                entity.descripcion = row["descripcion"].ToString();
                                entity.precioVenta = Convert.ToDecimal(row["precioVenta"].ToString());
                                entity.precioCompra = Convert.ToDecimal(row["precioCompra"].ToString());
                            }
                            return entity;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return entity;
            }
            return entity;
        }


        #endregion

        #region categoria Datos
        public DataTable ListCategoria()
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "SP_GET_Categoria_LOAD";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        public DataTable BuscarCategoria(categoriaEntitis categoria)
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "[dbo].[SP_GET_CATEGORIA_BUSCAR]";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", categoria.nombre);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        public int Registrar_Categoria(categoriaEntitis categoria)
        {
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "[dbo].[SP_SET_CATEGORIA]";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@idCat", categoria.idcategoria));
                        cmd.Parameters.Add(new SqlParameter("@nom", categoria.nombre));
                        cmd.Parameters.Add(new SqlParameter("@Desc", categoria.descripcion));
                        cmd.ExecuteNonQuery();

                        return 1;

                    }
                }

            }
            catch (Exception)
            {
                return 0;

            }

        }
        //public void EliminarCategoria(categoriaEntitis categoria)
        //    {
        //    try
        //        {
        //        using (dbventasEntity context = new dbventasEntity())
        //            {

        //            var connection = context.Database.Connection as SqlConnection;

        //            using (connection)
        //                {
        //                connection.Open();
        //                string Qry = "SP_SET_DELETE_ARTICULO";
        //                SqlCommand cmd = new SqlCommand(Qry, connection);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add(new SqlParameter("@codigo",categoria.idcategoria));
        //                cmd.Parameters.Add(new SqlParameter("@estado",categoria.nombre));
        //                cmd.ExecuteNonQuery();

        //                }
        //            }
        //        }
        //    catch (Exception ex)
        //        {

        //        throw ex;
        //        }            
        #endregion

        #region clientes Datos
        public DataTable ListaCliente()
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "[dbo].[SP_GET_CLIENTES_LOAD]";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }

        public DataTable BuscarCliente(string NombreCompleto, string cedula, string codigo, string telefono)
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "SP_GET_CLIENTES_BUSCAR";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoCliente", codigo);
                    cmd.Parameters.AddWithValue("@Identificacion", cedula);
                    cmd.Parameters.AddWithValue("@Nombre_Completo", NombreCompleto);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        public int Registrar_Clientes(ClienteEntitis cliente)
        {

            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "[dbo].[SP_SET_CLIENTE_INSERT_UPDATE]";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@idcliente", cliente.idcliente));
                        cmd.Parameters.Add(new SqlParameter("@nombre", cliente.nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellidos", cliente.apellidos));
                        cmd.Parameters.Add(new SqlParameter("@sexo", cliente.sexo));
                        cmd.Parameters.Add(new SqlParameter("@fecha_nacimiento", cliente.fecha_nacimiento));
                        cmd.Parameters.Add(new SqlParameter("@tipo_documento", cliente.tipo_documento));
                        cmd.Parameters.Add(new SqlParameter("@num_documento", cliente.num_documento));
                        cmd.Parameters.Add(new SqlParameter("@direccion", cliente.direccion));
                        cmd.Parameters.Add(new SqlParameter("@telefono", cliente.telefono));
                        cmd.Parameters.Add(new SqlParameter("@email", cliente.email));
                        cmd.Parameters.Add(new SqlParameter("@status", 1));
                        cmd.Parameters.Add(new SqlParameter("@UsuarioAdiciona", cliente.UsuarioAdiciona));
                        cmd.Parameters.Add(new SqlParameter("@UsuarioModifica", cliente.UsuarioModifica));
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }

        }

        public void EliminarClientes(ClienteEntitis cliente)
        {
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "[dbo].[SP_SET_CLIENTE_DELETE]";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idcliente", cliente.idcliente));
                        //cmd.Parameters.Add(new SqlParameter("@status", 0));
                        //cmd.Parameters.Add(new SqlParameter("@FechaModifica", DateTime.Now));
                        cmd.Parameters.Add(new SqlParameter("@UsuarioModifica", cliente.UsuarioModifica));
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region cuenta_x_cobrar Datos

        /// <summary>
        /// Metodo que devuelve un listado de los clientes con deuda
        /// </summary>
        /// <returns></returns>
        public DataTable ListCuentasXcobrar()
        {
            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "SP_GET_CLIENTE_DEUDA";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        /// <summary>
        /// Metodo que Busca a los clientes con Deudas
        /// </summary>
        /// <param name="cxc">Resive un Objeto la cual estan las propiedades</param>
        /// <returns></returns>
        public DataTable BuscarClientesDeuda(cuentas_x_cobrarEntitis cxc)
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "[dbo].[sp_get_searche_client_pagos]";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@num_documento", cxc.num_documento);
                    cmd.Parameters.AddWithValue("@codigoCliente", cxc.codigoCliente);
                    cmd.Parameters.AddWithValue("@NombComp", cxc.NombComp);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }

        public int PagarCuentaCxc(cuentas_x_cobrarEntitis cxc)
        {

            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "SP_SET_PAGAR_CXC_NEW";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.Add(new SqlParameter("@id_cliente", cxc.id_cliente));
                        cmd.Parameters.Add(new SqlParameter("@fecha", cxc.fecha));
                        cmd.Parameters.Add(new SqlParameter("@valor", cxc.valor));
                        cmd.Parameters.Add(new SqlParameter("@pagado", cxc.pagado));
                        cmd.Parameters.Add(new SqlParameter("@usuario", cxc.usuario));
                        cmd.Parameters.Add(new SqlParameter("@fechaPago", cxc.fecha));
                        cmd.Parameters.Add(new SqlParameter("@idFactura", cxc.idFactura));
                        cmd.Parameters.Add(new SqlParameter("@CantidadPagada", cxc.CantidadPagada));
                        cmd.Parameters.Add(new SqlParameter("@statud", cxc.statud));
                        cmd.Parameters.Add(new SqlParameter("@id_cxc", cxc.id));
                        cmd.ExecuteNonQuery();
                        return 1;

                    }
                }
            }


            catch (Exception ex)
            {
                Console.Write("Se presento un error al realizar esta Acción" + ex.ToString());
                return 0;
                throw;
            }

        }


        #endregion

        #region cuenta_x_pagar Datos
        #endregion

        #region detalle_ingreso Datos
        #endregion

        #region detalles_ventas Datos
        #endregion

        #region ingreso Datos
        public int IngresdoDeDatos(ArticulosCompuestoEntity ingreso)
        {

            int Estado;
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "SP_SET_INSERTAR_ARTICULOS_INGRESO";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@nombre", ingreso.nombre));
                        cmd.Parameters.Add(new SqlParameter("@idcategoria", ingreso.idcategoria));
                        cmd.Parameters.Add(new SqlParameter("@Codigo", ingreso.Codigo));
                        cmd.Parameters.Add(new SqlParameter("@Imag_Url", ingreso.Imag_Url));
                        cmd.Parameters.Add(new SqlParameter("@descripcion", ingreso.descripcion));
                        cmd.Parameters.Add(new SqlParameter("@precioVenta", ingreso.precioVenta));
                        cmd.Parameters.Add(new SqlParameter("@precioCompra", ingreso.precioCompra));
                        cmd.Parameters.Add(new SqlParameter("@cantidad", ingreso.cantidad));
                        cmd.Parameters.Add(new SqlParameter("@estado", ingreso.estado));
                        cmd.Parameters.Add(new SqlParameter("@idProveedor", ingreso.idProveedor));
                        cmd.Parameters.Add(new SqlParameter("@idingreso", ingreso.idingreso));
                        cmd.Parameters.Add(new SqlParameter("@fecha", ingreso.fecha));
                        cmd.Parameters.Add(new SqlParameter("@tipo_comprobante", ingreso.tipo_comprobante));
                        cmd.Parameters.Add(new SqlParameter("@igv", ingreso.igv));
                        cmd.Parameters.Add(new SqlParameter("@UsuarioAdiciona", ingreso.UsuarioAdiciona));
                        cmd.Parameters.Add(new SqlParameter("@stock_inicial", ingreso.stock_inicial));
                        cmd.Parameters.Add(new SqlParameter("@fecha_produccion", ingreso.fecha_produccion));
                        cmd.Parameters.Add(new SqlParameter("@fecha_vencimiento", ingreso.fecha_vencimiento));

                        cmd.ExecuteNonQuery();
                    }
                }
                Estado = 1;

            }
            catch (Exception ex)
            {

                return Estado = 0;
                throw ex;
            }

            return Estado;

        }

        #endregion

        #region proveedor Datos
        public DataTable Listproveedor()
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "[dbo].[SP_GET_PROVEEDOR_LOAD]";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        public DataTable Buscarproveedor(string doc, string tel, string nom)
        {

            using (dbventasEntity context = new dbventasEntity())
            {

                var connection = context.Database.Connection as SqlConnection;

                using (connection)
                {
                    connection.Open();
                    string Qry = "SP_GET_BUSCAR_PROVEEDOR";
                    SqlCommand cmd = new SqlCommand(Qry, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@documento", doc);
                    cmd.Parameters.AddWithValue("@telefono", tel);
                    cmd.Parameters.AddWithValue("@nombre", nom);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }

        }
        public int Registrar_Proveedor(ProveedorEntity proveedor)
        {
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "SP_SET_UDATE_INSERT_PROVEEDOR";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@idproveedor", proveedor.idproveedor));
                        cmd.Parameters.Add(new SqlParameter("@razon_social", proveedor.razon_social));
                        cmd.Parameters.Add(new SqlParameter("@NombreProveedor", proveedor.NombreProveedor));
                        cmd.Parameters.Add(new SqlParameter("@tipo_documento", proveedor.tipo_documento));
                        cmd.Parameters.Add(new SqlParameter("@num_documento", proveedor.num_documento));
                        cmd.Parameters.Add(new SqlParameter("@direccion", proveedor.direccion));
                        cmd.Parameters.Add(new SqlParameter("@telefono", proveedor.telefono));
                        cmd.Parameters.Add(new SqlParameter("@email", proveedor.email));
                        cmd.Parameters.Add(new SqlParameter("@url", proveedor.url));
                        cmd.Parameters.Add(new SqlParameter("@statu", proveedor.statu));
                        cmd.Parameters.Add(new SqlParameter("@UsuarioAdiciona", proveedor.UsuarioAdiciona));
                        cmd.Parameters.Add(new SqlParameter("@UsuarioModifica", proveedor.UsuarioModifica));
                        cmd.ExecuteNonQuery();
                        return 1;

                    }
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }

        }
        public void EliminarProveedor(ProveedorEntity proveedor)
        {
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "SP_SET_DELETE_PROVEEDOR";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@codigo", proveedor.idproveedor));
                        cmd.Parameters.Add(new SqlParameter("@estado", proveedor.statu));
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ProveedorEntity ListaProveedores(int idproveedor)
        {
            ProveedorEntity p;

            //if (string.IsNullOrWhiteSpace(usuario))
            //    return null;
            try
            {
                using (dbventasEntity db = new dbventasEntity())
                {
                    using (var connection = db.Database.Connection as SqlConnection)
                    {
                        connection.Open();
                        string procedure = "[dbo].[ListaProveedores]";
                        SqlCommand cmd = new SqlCommand(procedure, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", idproveedor);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count <= 0)
                        {
                            connection.Close();
                            return null;
                        }
                        p = new ProveedorEntity();
                        foreach (DataRow row in dt.Rows)
                        {
                            p.idproveedor = Convert.ToInt32(row["idproveedor"].ToString());
                            p.razon_social = row["razon_social"].ToString();
                            p.NombreProveedor = row["NombreProveedor"].ToString();
                            p.tipo_documento = row["tipo_documento"].ToString();
                            p.num_documento = row["num_documento"].ToString();
                            p.direccion = row["direccion"].ToString();
                            p.telefono = row["telefono"].ToString();
                            p.email = row["email"].ToString();
                            p.url = row["url"].ToString();
                            p.statu = Convert.ToBoolean(row["statu"].ToString());
                            p.FechaAdiciona = Convert.ToDateTime(row["FechaAdiciona"].ToString());
                            p.UsuarioAdiciona = row["UsuarioAdiciona"].ToString();
                        }
                    }
                }

                return p;

            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

        #region Roles Datos
        #endregion

        #region trabajador Datos


        public int Registrar_Empleado(trabajadorEntitis trabajador)
        {
            try
            {
                using (dbventasEntity context = new dbventasEntity())
                {

                    var connection = context.Database.Connection as SqlConnection;

                    using (connection)
                    {
                        connection.Open();
                        string Qry = "[SP_SET_EMPLEADO]";
                        SqlCommand cmd = new SqlCommand(Qry, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idtrabajador", trabajador.idtrabajador);
                        cmd.Parameters.AddWithValue("@nombre", trabajador.nombre);
                        cmd.Parameters.AddWithValue("@apellidos", trabajador.apellidos);
                        cmd.Parameters.AddWithValue("@sexo", trabajador.sexo);
                        cmd.Parameters.AddWithValue("@Fecha_nac", trabajador.Fecha_nac);
                        cmd.Parameters.AddWithValue("@num_documento", trabajador.num_documento);
                        cmd.Parameters.AddWithValue("@direccion", trabajador.direccion);
                        cmd.Parameters.AddWithValue("@telefono", trabajador.telefono);
                        cmd.Parameters.AddWithValue("@email", trabajador.email);
                        cmd.Parameters.AddWithValue("@StatusE", trabajador.StatusE);
                        cmd.Parameters.AddWithValue("UsuarioAdiciona", trabajador.UsuarioAdiciona);
                        cmd.Parameters.AddWithValue("UsuarioModifica", trabajador.UsuarioModifica);
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }

        }

        public trabajadorEntitis ListaTrabajador(string NombCompleto, string cedula, string telefono)
        {
            trabajadorEntitis trab;

            using (dbventasEntity db = new dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string procedure = "[dbo].[SP_GET_EMPLOYEES]";
                    SqlCommand cmd = new SqlCommand(procedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreC", NombCompleto);
                    cmd.Parameters.AddWithValue("@num_cedula", cedula);
                    cmd.Parameters.AddWithValue("@telefono", telefono);


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {
                        connection.Close();
                        return null;
                    }
                    trab = new trabajadorEntitis();
                    foreach (DataRow row in dt.Rows)
                    {
                        trab.idtrabajador = Convert.ToInt32(row["idtrabajador"].ToString());
                        trab.NombreCompleto = row["NombreCompleto"].ToString();
                        trab.sexo = row["sexo"].ToString();
                        trab.num_documento = row["num_documento"].ToString();
                        trab.direccion = row["direccion"].ToString();
                        trab.telefono = row["telefono"].ToString();
                        trab.email = row["email"].ToString();
                        trab.estatus = row["Estado"].ToString();

                    }

                }
            }

            return trab;
        }

        public trabajadorEntitis GetEmployeeById(int id)
        {
            trabajadorEntitis trabajador = null;

            using (var db = new dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("[DBO].[SELECT_EMPLOYEE_BY_ID]", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        trabajador = new trabajadorEntitis();

                        while (reader.Read())
                        {
                            trabajador.idtrabajador = Convert.ToInt32(reader["idtrabajador"]);
                            trabajador.nombre = reader["nombre"].ToString();
                            trabajador.NombreCompleto = reader["nombre"].ToString() + " " + reader["apellidos"].ToString();
                            trabajador.num_documento = reader["num_documento"].ToString();
                            trabajador.sexo = reader["sexo"].ToString();
                            trabajador.StatusE = Convert.ToBoolean(reader["StatusE"]);
                            trabajador.telefono = reader["telefono"].ToString();
                            trabajador.Fecha_nac = Convert.ToDateTime(reader["Fecha_nac"]);
                            trabajador.apellidos = reader["apellidos"].ToString();
                            trabajador.direccion = reader["direccion"].ToString();
                            trabajador.email = reader["email"].ToString();
                        }

                        reader.Close();
                    }
                }
            }

            return trabajador;
        }


        #endregion

        #region users Datos
        public string[] LoginUser(string user, string pass)
        {
            int rolId = 0;
            string NombreC = "";
            int id_trabajador = 0;

            string[] arreglo = new string[3];

            try
            {
                using (dbventasEntity db = new dbventasEntity())
                {
                    using (var connection = db.Database.Connection as SqlConnection)
                    {
                        connection.Open();
                        string query = "SP_LOGIN";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        //parameters. @usuario
                        SqlParameter usuario = new SqlParameter("@usuario", user);
                        usuario.SqlDbType = SqlDbType.VarChar;
                        usuario.Size = 50;

                        //parameter. @contrasena
                        SqlParameter contrasena = new SqlParameter("@contrasena", pass);
                        contrasena.SqlDbType = SqlDbType.VarChar;
                        contrasena.Size = 50;

                        //parameter. @rolid
                        SqlParameter rolid = new SqlParameter("@rolid", rolId);
                        rolid.SqlDbType = SqlDbType.Int;
                        rolid.Direction = ParameterDirection.Output;

                        //parameter.@NombreC
                        SqlParameter nombreC = new SqlParameter("@NombreC", NombreC);
                        nombreC.SqlDbType = SqlDbType.VarChar;
                        nombreC.Size = 80;
                        nombreC.Direction = ParameterDirection.Output;

                        //parameter.@id_trabajador
                        SqlParameter idTrabajador = new SqlParameter("@id_trabajador", id_trabajador);
                        idTrabajador.SqlDbType = SqlDbType.Int;
                        idTrabajador.Direction = ParameterDirection.Output;

                        //add parameters to cmd
                        cmd.Parameters.Add(usuario);
                        cmd.Parameters.Add(contrasena);
                        cmd.Parameters.Add(rolid);
                        cmd.Parameters.Add(nombreC);
                        cmd.Parameters.Add(idTrabajador);
                        //exec procedure
                        cmd.ExecuteNonQuery();
                        if (cmd.Parameters["@rolid"].Value == DBNull.Value)
                        {
                            rolId = 0;
                        }
                        else
                        {
                            rolId = System.Convert.ToInt32(cmd.Parameters["@rolid"].Value);
                            NombreC = System.Convert.ToString(cmd.Parameters["@NombreC"].Value);
                            id_trabajador = System.Convert.ToInt32(cmd.Parameters["@id_trabajador"].Value);
                        }

                        arreglo[0] = rolId.ToString();
                        arreglo[1] = NombreC;
                        arreglo[2] = id_trabajador.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return arreglo;
        }

        public UsersEntitis GetUserByName(string usuario)
        {
            UsersEntitis user;

            if (string.IsNullOrWhiteSpace(usuario))
                return null;

            using (dbventasEntity db = new dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string procedure = "[dbo].[SP_GET_USER_BY_NAME]";
                    SqlCommand cmd = new SqlCommand(procedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@USERNAME", usuario);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {
                        connection.Close();
                        return null;
                    }
                    user = new UsersEntitis();
                    foreach (DataRow row in dt.Rows)
                    {
                        user.id = Convert.ToInt32(row["id"].ToString());
                        user.Usuario = row["Usuario"].ToString();
                        user.Clave = row["Clave"].ToString();
                        user.RolID = Convert.ToInt32(row["RolID"].ToString());
                        user.Statud = Convert.ToBoolean(row["Statud"].ToString());
                    }

                }
            }

            return user;
        }

        public int RegistrarUsuario(UsersEntitis entity)
        {
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    try
                    {
                        connection.Open();
                        string procedure = "[dbo].[REGISTRAR_USUARIO]";
                        SqlCommand cmd = new SqlCommand(procedure, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", entity.id);
                        cmd.Parameters.AddWithValue("@Usuario", entity.Usuario);
                        cmd.Parameters.AddWithValue("@Clave", entity.Clave);
                        cmd.Parameters.AddWithValue("@RolID", entity.RolID);
                        cmd.Parameters.AddWithValue("@Statud", entity.Statud);
                        cmd.Parameters.AddWithValue("@id_trabajador", entity.id_trabajador);

                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        return 0;
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region ventas Datos    
        public articulosEntitis BuscarArticuloFaturar(string codigo, string nom)
        {
            articulosEntitis vent;

            using (dbventasEntity db = new dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string procedure = "[dbo].[SP_GET_ARTICULO]";
                    SqlCommand cmd = new SqlCommand(procedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nom", nom);



                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {
                        connection.Close();
                        return null;
                    }
                    vent = new articulosEntitis();
                    foreach (DataRow row in dt.Rows)
                    {
                        vent.idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                        vent.nombre = row["nombre"].ToString();
                        vent.idcategoria = Convert.ToInt32(row["idcategoria"].ToString());
                        vent.codigo = row["Codigo"].ToString(); ;
                        vent.Imag_Url = row["Imag_Url"].ToString(); ;
                        vent.descripcion = row["descripcion"].ToString(); ;
                        vent.precioVenta = Convert.ToDecimal(row["precioVenta"].ToString());
                        vent.precioCompra = Convert.ToDecimal(row["precioCompra"].ToString());
                        vent.cantidad = Convert.ToDecimal(row["cantidad"].ToString());
                        vent.estado = Convert.ToBoolean(row["estado"]);
                        vent.idProveedor = Convert.ToInt32(row["idProveedor"].ToString());
                        vent.CodigoBarra = row["CodigoBarra"].ToString();

                    }
                }

                return vent;
            }

        }
        //ingresa la venta y devuelve el id de la venta creada;

        public int IngresarVenta(ventasEntitis venta, ICollection<detalle_ventaEntitis> detalles)
        {
            int idRetornado = 0;
            using (dbventasEntity db = new dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string sqlVenta = "[DBO].[SP_INGRESAR_VENTA]";
                    string sqlDetalles = "[DBO].[SP_INGRESAR_DETALLE_VENTA]";

                    SqlCommand cmd = new SqlCommand(sqlVenta, connection);
                    SqlCommand cmd2 = new SqlCommand(sqlDetalles, connection);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandType = CommandType.StoredProcedure;

                    int ventaid = 0;
                    //parameters venta
                    cmd.Parameters.AddWithValue("@idtrabajador", venta.idtrabajador);
                    cmd.Parameters.AddWithValue("@id_cliente", venta.idcliente);
                    cmd.Parameters.AddWithValue("@tipo_comprobante", venta.tipo_comprobante);
                    cmd.Parameters.AddWithValue("@tipo_venta", venta.tipo_venta);
                    cmd.Parameters.AddWithValue("@tipo_cliente", venta.tipo_cliente);
                    cmd.Parameters.AddWithValue("@itbis", venta.itbis);
                    cmd.Parameters.AddWithValue("@subtotal", venta.subtotal);
                    cmd.Parameters.AddWithValue("@total", venta.total);
                    cmd.Parameters.AddWithValue("@ventaid", ventaid).Direction = ParameterDirection.Output;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        if (cmd.Parameters["@ventaid"].Value == DBNull.Value)
                        {
                            ventaid = 0;
                        }
                        else
                        {
                            ventaid = Convert.ToInt32(cmd.Parameters["@ventaid"].Value);
                        }

                        if (ventaid > 0)
                        {
                            cmd2.Parameters.Clear();
                            foreach (detalle_ventaEntitis detalle in detalles)
                            {
                                cmd2.Parameters.AddWithValue("@idventa", ventaid);
                                cmd2.Parameters.AddWithValue("@producto", detalle.producto);
                                cmd2.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                                cmd2.Parameters.AddWithValue("@precio_venta", detalle.precio_venta);
                                cmd2.Parameters.AddWithValue("@descuento", detalle.descuento);
                                cmd2.Parameters.AddWithValue("@itbis", detalle.itbis);

                                cmd2.ExecuteNonQuery();
                                cmd2.Parameters.Clear();
                            }
                            idRetornado = ventaid;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return idRetornado;
                }
            }

        }
        //metodo para ingresar la factura a la base de datos
        public void IngresarFactura(FacturaEntity factura)
        {
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string query = "[DBO].[INGRESAR_FACTURA]";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //parameters
                    cmd.Parameters.AddWithValue("@nombre_trabajador", factura.nombre_trabajador).SqlDbType = SqlDbType.VarChar;
                    cmd.Parameters.AddWithValue("@tipo_pago", factura.tipo_pago).SqlDbType = SqlDbType.VarChar;
                    cmd.Parameters.AddWithValue("@medio_pago", factura.medio_pago).SqlDbType = SqlDbType.VarChar;
                    cmd.Parameters.AddWithValue("@id_venta", factura.id_venta).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@id_trabajador", factura.id_trabajador).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@cantidad_articulos", factura.cantidad_articulos).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@subtotal", factura.subtotal).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@itbis", factura.itbis).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@total", factura.total).SqlDbType = SqlDbType.Decimal;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        public FacturaEntity BuscarFactura(int idVenta, int idFactura = 0) //No Usarlo por ahora
        {
            FacturaEntity facturaEncontrada = null;
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string query = "[DBO].[SP_BUSCAR_FACTURA_X_ID]";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //parameters
                    cmd.Parameters.AddWithValue("@id_factura", idFactura).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@id_venta", idVenta).SqlDbType = SqlDbType.Int;
                    try
                    {
                        facturaEncontrada = new FacturaEntity();
                        SqlDataReader lector = cmd.ExecuteReader();
                        if (lector.HasRows)
                        {
                            facturaEncontrada.id_factura = (int)lector["id_factura"];
                            facturaEncontrada.id_cliente = (int)lector["id_cliente"];
                            facturaEncontrada.nombre_trabajador = lector["nombre_trabajador"].ToString();
                            facturaEncontrada.tipo_pago = lector["tipo_pago"].ToString();
                            facturaEncontrada.fecha = (DateTime)lector["fecha"];
                            facturaEncontrada.medio_pago = lector["medio_pago"].ToString();
                            facturaEncontrada.id_venta = (int)lector["id_venta"];
                            facturaEncontrada.id_trabajador = (int)lector["id_trabajador"];
                            facturaEncontrada.cantidad_articulos = (int)lector["cantidad_articulos"];
                            facturaEncontrada.subtotal = (decimal)lector["subtotal"];
                            facturaEncontrada.itbis = (decimal)lector["itbis"];
                            facturaEncontrada.total = (decimal)lector["total"];
                            facturaEncontrada.numero_factura = lector["numero_factura"].ToString();
                        }
                        lector.Close();

                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            return facturaEncontrada;
        }
        /// <summary>
        /// Busca En la base de datos el Id de la Factura.
        /// </summary>
        /// <param name="id_venta">ID de la Venta Registrad en Relacion a la factura</param>
        /// <returns>Valor Entero del Id de la Factura</returns>
        public int BuscarIdFactura(int id_venta)
        {
            int id_factura = 0;
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Close();
                    connection.Open();
                    string query = "[DBO].[SP_GET_FACTURA]";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id_venta", id_venta).SqlDbType = SqlDbType.Int;

                    DataTable dt = new DataTable();
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        id_factura = Convert.ToInt32(dt.Rows[0]["id_factura"].ToString());
                    }

                }
            }
            return id_factura;
        }
        /// <summary>
        /// Agrega una Cuenta por Cobrar en la base de datos.
        /// </summary>
        /// <param name="entity">Entidad cuentas_x_cobrarEntitis</param>
        public void AgregarCuentaACobrar(cuentas_x_cobrarEntitis entity)
        {
            using (dbventasEntity db = new dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string query = "[DBO].[SP_CREAR_CUENTA_X_COBRAR]";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //parameters
                    cmd.Parameters.AddWithValue("@id_cliente", entity.id_cliente).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@valor", entity.valor).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@usuario", entity.usuario).SqlDbType = SqlDbType.VarChar;
                    cmd.Parameters.AddWithValue("@id_venta", entity.id_venta).SqlDbType = SqlDbType.Int;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// Reduce la Cantidad de los Articulos registrados
        /// </summary>
        /// <param name="entity">Entidad Articulos</param>
        public void ReducirCantidadArticulo(articulosEntitis entity)
        {
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string query = "[DBO].[REDUCIR_CANTIDAD_ARTICULO]";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //parameters
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idarticulo", entity.idarticulo).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad).SqlDbType = SqlDbType.Int;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// Busca la Venta de Dia Registradas
        /// </summary>
        /// <returns>Ventas Del Dia en DataTable</returns>
        public DataTable BuscarVentasDelDia()
        {
            DateTime ahora = DateTime.Now;
            DataTable ventas = null;
            using (dbventasEntity db = new dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string proc = "[DBO].[SP_GET_VENTAS_DEL_DIA]";

                    SqlCommand cmd = new SqlCommand(proc, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fecha", ahora).SqlDbType = SqlDbType.Date;

                    try
                    {
                        ventas = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(ventas);

                        if (ventas.Rows.Count <= 0)
                            return null;

                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

            return ventas;
        }
        /// <summary>
        /// Busca en la base de datos las Ventas del Mes
        /// </summary>
        /// <param name="inicio">Fecha de Inicio 1ro del Mes</param>
        /// <param name="final">Fecha final 30 o 31 del Mes</param>
        /// <returns>Filas de las ventas en DataTable</returns>
        public DataTable BuscarVentasDelMes(DateTime inicio, DateTime final)
        {
            DataTable ventas = null;
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    connection.Open();
                    string proc = "[DBO].[SP_GET_VENTAS_DEL_MES]";
                    SqlCommand cmd = new SqlCommand(proc, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FROM", inicio).SqlDbType = SqlDbType.Date;
                    cmd.Parameters.AddWithValue("@Tipo_de_Documento", final).SqlDbType = SqlDbType.Date;

                    try
                    {
                        ventas = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ventas);
                        if (ventas.Rows.Count <= 0)
                            return null;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

            return ventas;
        }
        #endregion

        #region Cotizacion
        /// <summary>
        /// Ingresa el detalle de productos cotizados a la base de datos
        /// </summary>
        /// <param name="entity">Entidad de detalles para la cotizacion</param>
        public void IngresarDetallesCotizacion(detalle_cotizacion_productos entity)
        {
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    string proc = "[DBO].[INSERTAR_DETALLES_COTIZADOR_PRODUCTOS]";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(proc, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parameterers
                    cmd.Parameters.AddWithValue("@idcotizacion", entity.idcotizacion).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@producto", entity.producto).SqlDbType = SqlDbType.VarChar;
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@precioVenta", entity.precioVenta).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@itbis", entity.itbis).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@subtotal", entity.subtotal).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@total", entity.total).SqlDbType = SqlDbType.Decimal;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// Ingresa La Cotizacion a la base de datos.
        /// </summary>
        /// <param name="entity">Entidad Cotizacion con los datos</param>
        /// <returns>El Id de la cotizacion Ingresada</returns>
        public int IngresarCotizacion(CotizacionEntity entity)
        {
            int cotizacionId = 0;
            using (dbventasEntity db = new CapaDatos.dbventasEntity())
            {
                using (var connection = db.Database.Connection as SqlConnection)
                {
                    string proc = "[DBO].[INSERTAR_COTIZACION]";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(proc, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parameters
                    cmd.Parameters.AddWithValue("@idcliente", entity.idcliente).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@idtrabajador", entity.idtrabajador).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad).SqlDbType = SqlDbType.Int;
                    cmd.Parameters.AddWithValue("@subtotal", entity.subtotal).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@itbis", entity.itbis).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@total", entity.total).SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@id_cotizacion", cotizacionId).Direction = ParameterDirection.Output;
                    cmd.Parameters["@id_cotizacion"].SqlDbType = SqlDbType.Int;

                    try
                    {
                        cmd.ExecuteNonQuery();

                        if (cmd.Parameters["@id_cotizacion"].Value == DBNull.Value)
                        {
                            return 0;
                        }
                        else
                        {
                            cotizacionId = Convert.ToInt32(cmd.Parameters["@id_cotizacion"].Value);
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            return cotizacionId;
        }
        #endregion
    }


}