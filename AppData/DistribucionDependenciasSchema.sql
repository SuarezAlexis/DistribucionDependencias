if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Comentarios') and o.name = 'FK_COMENT_REF_NOTA')
alter table Comentarios
   drop constraint FK_COMENT_REF_NOTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Comentarios') and o.name = 'FK_COMENT_REF_USR')
alter table Comentarios
   drop constraint FK_COMENT_REF_USR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Dependencia') and o.name = 'FK_DEP_REF_USR')
alter table Dependencia
   drop constraint FK_DEP_REF_USR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Envio') and o.name = 'FK_ENTREGA_REF_NOTA')
alter table Envio
   drop constraint FK_ENTREGA_REF_NOTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Envio') and o.name = 'FK_ENTREGA_REF_VEHICULO')
alter table Envio
   drop constraint FK_ENTREGA_REF_VEHICULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Envio') and o.name = 'FK_ENTREGA_REF_CHOFER')
alter table Envio
   drop constraint FK_ENTREGA_REF_CHOFER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HistoricoNota') and o.name = 'FK_HIST_NOTA_REF_NOTA')
alter table HistoricoNota
   drop constraint FK_HIST_NOTA_REF_NOTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HistoricoNota') and o.name = 'FK_HIST_NOTA_REF_USUARIO')
alter table HistoricoNota
   drop constraint FK_HIST_NOTA_REF_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HistoricoProducto_Lista') and o.name = 'FK_HIST_PROD_REF_USUARIO')
alter table HistoricoProducto_Lista
   drop constraint FK_HIST_PROD_REF_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HistoricoProducto_Lista') and o.name = 'FK_HIST_PROD_REF_LISTA')
alter table HistoricoProducto_Lista
   drop constraint FK_HIST_PROD_REF_LISTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HistoricoProducto_Lista') and o.name = 'FK_HIST_PROD_REF_PROD')
alter table HistoricoProducto_Lista
   drop constraint FK_HIST_PROD_REF_PROD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_DEP')
alter table Nota
   drop constraint FK_NOTA_REF_DEP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_ESTATUS')
alter table Nota
   drop constraint FK_NOTA_REF_ESTATUS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_LISTA')
alter table Nota
   drop constraint FK_NOTA_REF_LISTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_NOTA')
alter table Nota
   drop constraint FK_NOTA_REF_NOTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_SUBDEP')
alter table Nota
   drop constraint FK_NOTA_REF_SUBDEP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_TIPO_NOTA')
alter table Nota
   drop constraint FK_NOTA_REF_TIPO_NOTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_USR_CREA')
alter table Nota
   drop constraint FK_NOTA_REF_USR_CREA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nota') and o.name = 'FK_NOTA_REF_USR_MOD')
alter table Nota
   drop constraint FK_NOTA_REF_USR_MOD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Producto') and o.name = 'FK_PRODUCTO_REF_CATEGORIA')
alter table Producto
   drop constraint FK_PRODUCTO_REF_CATEGORIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Producto_Lista') and o.name = 'FK_PROD_LISTA_REF_LISTA')
alter table Producto_Lista
   drop constraint FK_PROD_LISTA_REF_LISTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Producto_Lista') and o.name = 'FK_PROD_LISTA_REF_PRODUCTO')
alter table Producto_Lista
   drop constraint FK_PROD_LISTA_REF_PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Subdependencia') and o.name = 'FK_SUBDEP_REF_DEP')
alter table Subdependencia
   drop constraint FK_SUBDEP_REF_DEP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Usuario_Lista') and o.name = 'FK_USR_LISTA_REF_LISTA')
alter table Usuario_Lista
   drop constraint FK_USR_LISTA_REF_LISTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Usuario_Lista') and o.name = 'FK_USR_LISTA_REF_USR')
alter table Usuario_Lista
   drop constraint FK_USR_LISTA_REF_USR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Usuario_Rol') and o.name = 'FK_USR_ROL_REF_ROL')
alter table Usuario_Rol
   drop constraint FK_USR_ROL_REF_ROL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Usuario_Rol') and o.name = 'FK_USR_ROL_REF_USR')
alter table Usuario_Rol
   drop constraint FK_USR_ROL_REF_USR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Categoria')
            and   type = 'U')
   drop table Categoria
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Chofer')
            and   type = 'U')
   drop table Chofer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Comentarios')
            and   type = 'U')
   drop table Comentarios
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Dependencia')
            and   type = 'U')
   drop table Dependencia
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Envio')
            and   type = 'U')
   drop table Envio
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EstatusNota')
            and   type = 'U')
   drop table EstatusNota
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HistoricoNota')
            and   type = 'U')
   drop table HistoricoNota
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HistoricoProducto_Lista')
            and   type = 'U')
   drop table HistoricoProducto_Lista
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Lista')
            and   type = 'U')
   drop table Lista
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Nota')
            and   type = 'U')
   drop table Nota
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Producto')
            and   type = 'U')
   drop table Producto
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Producto_Lista')
            and   type = 'U')
   drop table Producto_Lista
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Rol')
            and   type = 'U')
   drop table Rol
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Subdependencia')
            and   type = 'U')
   drop table Subdependencia
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TipoNota')
            and   type = 'U')
   drop table TipoNota
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Usuario')
            and   type = 'U')
   drop table Usuario
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Usuario_Lista')
            and   type = 'U')
   drop table Usuario_Lista
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Usuario_Rol')
            and   type = 'U')
   drop table Usuario_Rol
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Vehiculo')
            and   type = 'U')
   drop table Vehiculo
go

/*==============================================================*/
/* Table: Categoria                                             */
/*==============================================================*/
create table Categoria (
   ID                   int                  not null,
   Nombre               varchar(50)          not null,
   Descripcion          varchar(256)         null,
   constraint PK_CATEGORIA primary key (ID)
)
go

/*==============================================================*/
/* Table: Chofer                                                */
/*==============================================================*/
create table Chofer (
   ID                   bigint               identity,
   Nombre               varchar(50)          not null,
   ApPaterno            varchar(50)          not null,
   ApMaterno            varchar(50)          null,
   NumEmpleado          char(20)             not null,
   constraint PK_CHOFER primary key (ID)
)
go

/*==============================================================*/
/* Table: Comentarios                                           */
/*==============================================================*/
create table Comentarios (
   ID                   bigint               identity,
   Fecha                datetime             not null,
   Comentario           text                 not null,
   Nota                 bigint               not null,
   Usuario              bigint               not null,
   constraint PK_COMENTARIOS primary key (ID)
)
go

/*==============================================================*/
/* Table: Dependencia                                           */
/*==============================================================*/
create table Dependencia (
   Clave                char(5)              not null,
   Nombre               varchar(50)          not null,
   Titular              bigint               null,
   constraint PK_DEPENDENCIA primary key (Clave)
)
go

/*==============================================================*/
/* Table: Envio                                                 */
/*==============================================================*/
create table Envio (
   ID                   bigint               identity,
   NotaID               bigint               not null,
   VehiculoID           bigint               not null,
   ChoferID             bigint               not null,
   TiempoEstimado       int                  null,
   constraint PK_ENVIO primary key (ID)
)
go

/*==============================================================*/
/* Table: EstatusNota                                           */
/*==============================================================*/
create table EstatusNota (
   ID                   int                  not null,
   EstatusNota          varchar(20)          not null,
   Descripcion          varchar(100)         null,
   constraint PK_ESTATUSNOTA primary key (ID)
)
go

/*==============================================================*/
/* Table: HistoricoNota                                         */
/*==============================================================*/
create table HistoricoNota (
   ID                   bigint               identity,
   Nota_ID              bigint               not null,
   Fecha                datetime             not null,
   EstatusAnterior      int                  null,
   EstatusNuevo         int                  null,
   UsuarioModifica      bigint               not null,
   constraint PK_HISTORICONOTA primary key (ID)
)
go

/*==============================================================*/
/* Table: HistoricoProducto_Lista                               */
/*==============================================================*/
create table HistoricoProducto_Lista (
   ID                   bigint               not null,
   ListaID              bigint               not null,
   Codigo               varchar(16)          not null,
   Cambio               char(1)              not null,
   Fecha                datetime             not null,
   Anterior             int                  null,
   UsuarioID            bigint               null,
   constraint PK_HISTORICOPRODUCTO_LISTA primary key (ID)
)
go

/*==============================================================*/
/* Table: Lista                                                 */
/*==============================================================*/
create table Lista (
   ID                   bigint               identity,
   Nombre               varchar(30)          null,
   FechaCreacion        datetime             not null,
   UltimaMod            datetime             not null,
   constraint PK_LISTA primary key (ID)
)
go

/*==============================================================*/
/* Table: Nota                                                  */
/*==============================================================*/
create table Nota (
   ID                   bigint               identity,
   TipoNota             char(1)              not null,
   EstatusNota          int                  null,
   Dependencia          char(5)              not null,
   Subdependencia       char(5)              null,
   FechaCreacion        datetime             not null,
   UsuarioGenera        bigint               not null,
   UltimaModificacion   datetime             not null,
   UsuarioModifica      bigint               not null,
   Lista                bigint               not null,
   Importe              decimal(8,2)         null,
   EntregaSugerida      datetime             null,
   EntregaPropuesta     datetime             null,
   NotaAsociada         bigint               null,
   constraint PK_NOTA primary key (ID)
)
go

/*==============================================================*/
/* Table: Producto                                              */
/*==============================================================*/
create table Producto (
   Codigo               varchar(16)          not null,
   Nombre               varchar(50)          not null,
   NombreCorto          varchar(10)          null,
   Categoria            int                  not null,
   Precio               decimal(8,2)         null,
   constraint PK_PRODUCTO primary key (Codigo)
)
go

/*==============================================================*/
/* Table: Producto_Lista                                        */
/*==============================================================*/
create table Producto_Lista (
   ID                   bigint               identity,
   ListaID              bigint               not null,
   Codigo               varchar(16)          not null,
   Cantidad             int                  null,
   constraint PK_PRODUCTO_LISTA primary key (ID)
)
go

/*==============================================================*/
/* Table: Rol                                                   */
/*==============================================================*/
create table Rol (
   ID                   bigint               not null,
   Nombre               varchar(20)          not null,
   constraint PK_ROL primary key (ID)
)
go

/*==============================================================*/
/* Table: Subdependencia                                        */
/*==============================================================*/
create table Subdependencia (
   Clave                char(5)              not null,
   Dependencia          char(5)              not null,
   Nombre               varchar(50)          not null,
   constraint PK_SUBDEPENDENCIA primary key (Clave)
)
go

/*==============================================================*/
/* Table: TipoNota                                              */
/*==============================================================*/
create table TipoNota (
   ID                   char(1)              not null,
   TipoNota             varchar(20)          null,
   constraint PK_TIPONOTA primary key (ID)
)
go

/*==============================================================*/
/* Table: Usuario                                               */
/*==============================================================*/
create table Usuario (
   ID                   bigint               identity,
   Nombre               varchar(30)          not null,
   ApPaterno            varchar(30)          not null,
   ApMaterno            varchar(30)          null,
   Email                varchar(50)          not null,
   Bloqueado            bit                  null,
   IntentosFallidos     int                  null,
   Password             varchar(32)          not null,
   constraint PK_USUARIO primary key (ID)
)
go

/*==============================================================*/
/* Table: Usuario_Lista                                         */
/*==============================================================*/
create table Usuario_Lista (
   ID                   bigint               identity,
   Usuario              bigint               not null,
   Lista                bigint               not null,
   constraint PK_USUARIO_LISTA primary key (ID)
)
go

/*==============================================================*/
/* Table: Usuario_Rol                                           */
/*==============================================================*/
create table Usuario_Rol (
   ID                   bigint               identity,
   Usuario              bigint               not null,
   Rol                  bigint               not null,
   constraint PK_USUARIO_ROL primary key (ID)
)
go

/*==============================================================*/
/* Table: Vehiculo                                              */
/*==============================================================*/
create table Vehiculo (
   ID                   bigint               identity,
   Placas               char(7)              not null,
   Marca                varchar(50)          null,
   Modelo               varchar(50)          null,
   Tipo                 tinyint              null,
   Disponible           bit                  null,
   constraint PK_VEHICULO primary key (ID)
)
go

alter table Comentarios
   add constraint FK_COMENT_REF_NOTA foreign key (Nota)
      references Nota (ID)
go

alter table Comentarios
   add constraint FK_COMENT_REF_USR foreign key (Usuario)
      references Usuario (ID)
go

alter table Dependencia
   add constraint FK_DEP_REF_USR foreign key (Titular)
      references Usuario (ID)
go

alter table Envio
   add constraint FK_ENTREGA_REF_NOTA foreign key (NotaID)
      references Nota (ID)
go

alter table Envio
   add constraint FK_ENTREGA_REF_VEHICULO foreign key (VehiculoID)
      references Vehiculo (ID)
go

alter table Envio
   add constraint FK_ENTREGA_REF_CHOFER foreign key (ChoferID)
      references Chofer (ID)
go

alter table HistoricoNota
   add constraint FK_HIST_NOTA_REF_NOTA foreign key (Nota_ID)
      references Nota (ID)
go

alter table HistoricoNota
   add constraint FK_HIST_NOTA_REF_USUARIO foreign key (UsuarioModifica)
      references Usuario (ID)
go

alter table HistoricoProducto_Lista
   add constraint FK_HIST_PROD_REF_USUARIO foreign key (UsuarioID)
      references Usuario (ID)
go

alter table HistoricoProducto_Lista
   add constraint FK_HIST_PROD_REF_LISTA foreign key (ListaID)
      references Lista (ID)
go

alter table HistoricoProducto_Lista
   add constraint FK_HIST_PROD_REF_PROD foreign key (Codigo)
      references Producto (Codigo)
go

alter table Nota
   add constraint FK_NOTA_REF_DEP foreign key (Dependencia)
      references Dependencia (Clave)
go

alter table Nota
   add constraint FK_NOTA_REF_ESTATUS foreign key (EstatusNota)
      references EstatusNota (ID)
go

alter table Nota
   add constraint FK_NOTA_REF_LISTA foreign key (Lista)
      references Lista (ID)
go

alter table Nota
   add constraint FK_NOTA_REF_NOTA foreign key (NotaAsociada)
      references Nota (ID)
go

alter table Nota
   add constraint FK_NOTA_REF_SUBDEP foreign key (Subdependencia)
      references Subdependencia (Clave)
go

alter table Nota
   add constraint FK_NOTA_REF_TIPO_NOTA foreign key (TipoNota)
      references TipoNota (ID)
go

alter table Nota
   add constraint FK_NOTA_REF_USR_CREA foreign key (UsuarioGenera)
      references Usuario (ID)
go

alter table Nota
   add constraint FK_NOTA_REF_USR_MOD foreign key (UsuarioModifica)
      references Usuario (ID)
go

alter table Producto
   add constraint FK_PRODUCTO_REF_CATEGORIA foreign key (Categoria)
      references Categoria (ID)
go

alter table Producto_Lista
   add constraint FK_PROD_LISTA_REF_LISTA foreign key (ListaID)
      references Lista (ID)
go

alter table Producto_Lista
   add constraint FK_PROD_LISTA_REF_PRODUCTO foreign key (Codigo)
      references Producto (Codigo)
go

alter table Subdependencia
   add constraint FK_SUBDEP_REF_DEP foreign key (Dependencia)
      references Dependencia (Clave)
go

alter table Usuario_Lista
   add constraint FK_USR_LISTA_REF_LISTA foreign key (Lista)
      references Lista (ID)
go

alter table Usuario_Lista
   add constraint FK_USR_LISTA_REF_USR foreign key (Usuario)
      references Usuario (ID)
go

alter table Usuario_Rol
   add constraint FK_USR_ROL_REF_ROL foreign key (Rol)
      references Rol (ID)
go

alter table Usuario_Rol
   add constraint FK_USR_ROL_REF_USR foreign key (Usuario)
      references Usuario (ID)
go
