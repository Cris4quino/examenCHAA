USE [BD_TRANSACCIONES_CHAA]
GO
/****** Object:  Table [dbo].[CUENTA]    Script Date: 11/5/2021 13:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUENTA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NRO_CUENTA] [nvarchar](14) NULL,
	[TIPO] [char](3) NULL,
	[MONEDA] [char](3) NULL,
	[NOMBRE] [nvarchar](40) NULL,
	[SALDO] [decimal](12, 2) NULL,
	[FECHA_CREACION] [datetime] NULL,
	[FECHA_MODIFICACION] [datetime] NULL,
 CONSTRAINT [PK_CUENTA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIMIENTO]    Script Date: 11/5/2021 13:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_CUENTA] [int] NULL,
	[NRO_CUENTA] [nvarchar](14) NULL,
	[FECHA_MOVIMIENTO] [datetime] NULL,
	[TIPO] [char](1) NULL,
	[IMPORTE] [decimal](12, 2) NULL,
 CONSTRAINT [PK_MOVIMIENTO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[actualiza_saldo]    Script Date: 11/5/2021 13:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[actualiza_saldo]
	-- Add the parameters for the stored procedure here
	@NRO_CUENTA nvarchar(14),
	@SALDO decimal(12,2), 
	@TIPO char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @saldoanterior decimal(12,2)
	set @saldoanterior = (select SALDO from CUENTA where NRO_CUENTA = @NRO_CUENTA)

	IF @TIPO = 'D'
		set 	@SALDO = @saldoanterior - @SALDO
	else
		set 	@SALDO = @saldoanterior + @SALDO

    -- Insert statements for procedure here
	UPDATE [dbo].[CUENTA]
	SET [SALDO] = @SALDO
	WHERE [NRO_CUENTA]=@NRO_CUENTA

END
GO
/****** Object:  StoredProcedure [dbo].[sp_creacion_cuenta]    Script Date: 11/5/2021 13:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_creacion_cuenta]
	-- Add the parameters for the stored procedure here
		@NRO_CUENTA nvarchar(14)
	,@TIPO char(3)
	,@MONEDA char(3)
	,@NOMBRE nvarchar(40)
	,@SALDO decimal(12,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[CUENTA]
           ([NRO_CUENTA]
           ,[TIPO]
           ,[MONEDA]
           ,[NOMBRE]
           ,[SALDO]
           ,[FECHA_CREACION]
           ,[FECHA_MODIFICACION])
     VALUES
           (@NRO_CUENTA
           ,@TIPO
           ,@MONEDA
           ,@NOMBRE
           ,@SALDO
           ,GETDATE()
           ,GETDATE())
END
GO
/****** Object:  StoredProcedure [dbo].[sp_creacion_movimiento]    Script Date: 11/5/2021 13:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_creacion_movimiento]
	-- Add the parameters for the stored procedure here
			@id_CUENTA int
           ,@NRO_CUENTA nvarchar(14)
           ,@TIPO char(1)
           ,@IMPORTE decimal(12,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
INSERT INTO [dbo].[MOVIMIENTO]
           ([id_CUENTA]
           ,[NRO_CUENTA]
           ,[FECHA_MOVIMIENTO]
           ,[TIPO]
           ,[IMPORTE])
     VALUES
           (@id_CUENTA
           ,@NRO_CUENTA
           ,GETDATE()
           ,@TIPO
           ,@IMPORTE)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_saldo]    Script Date: 11/5/2021 13:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_mostrar_saldo]
	-- Add the parameters for the stored procedure here
	@NRO_CUENTA nvarchar(14)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
 SELECT 
      [SALDO]

  FROM [dbo].[CUENTA]

  WHERE [NRO_CUENTA] = @NRO_CUENTA

END
GO
/****** Object:  StoredProcedure [dbo].[sp_trae_cuenta]    Script Date: 11/5/2021 13:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_trae_cuenta]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id] AS NRO
      ,[NRO_CUENTA] AS NUMERO_CUENTA
      ,[TIPO]
      ,[MONEDA]
      ,[NOMBRE] as TITULAR
      ,[SALDO]
      ,[FECHA_CREACION]
      ,[FECHA_MODIFICACION]
  FROM [dbo].[CUENTA]

END
GO
