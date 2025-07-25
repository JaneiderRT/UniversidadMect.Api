if (select COUNT(1) from sysdatabases where name = 'UniversidadMect') < 1
begin
	create database UniversidadMect
end
go

USE [UniversidadMect]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[EstudianteId] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NOT NULL,
	[UniversidadId] [int] NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[CreditosEstudiante] [int] NOT NULL,
	[EsActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion](
	[InscripcionId] [int] IDENTITY(1,1) NOT NULL,
	[MateriaId] [int] NOT NULL,
	[EstudianteId] [int] NOT NULL,
	[EsActivo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[CreadoPor] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[ModificadoPor] [int] NULL,
 CONSTRAINT [PK_Inscripcion] PRIMARY KEY CLUSTERED 
(
	[InscripcionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[MateriaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[CreditosMateria] [int] NOT NULL,
	[ProfesorId] [int] NOT NULL,
	[EsActivo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[CreadoPor] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[ModifcadoPor] [int] NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[MateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[PersonaId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[PrimerNombre] [varchar](100) NOT NULL,
	[SegundoNombre] [varchar](100) NULL,
	[PrimerApellido] [varchar](100) NOT NULL,
	[SegundoApellido] [varchar](100) NULL,
	[Sexo] [varchar](2) NOT NULL,
	[TipoIdentificacionId] [int] NOT NULL,
	[Identificacion] [varchar](50) NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Adicional] [varchar](30) NULL,
	[EsActivo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[CreadoPor] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[ModificadoPor] [int] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[PersonaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[ProfesorId] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NOT NULL,
	[UniversidadId] [int] NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[EsActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[ProfesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Programa]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Programa](
	[ProgramaId] [int] IDENTITY(1,1) NOT NULL,
	[UniversidadId] [int] NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[CreditosTotales] [int] NOT NULL,
	[EsActivo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[CreadoPor] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[ModificadoPor] [int] NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[ProgramaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramaMateria]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramaMateria](
	[ProgramaMateriaId] [int] IDENTITY(1,1) NOT NULL,
	[ProgramaId] [int] NOT NULL,
	[MateriaId] [int] NOT NULL,
 CONSTRAINT [PK_ProgramaMateria] PRIMARY KEY CLUSTERED 
(
	[ProgramaMateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoIdentificacion]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoIdentificacion](
	[TipoIdentificacionId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TipoIdentificacion] PRIMARY KEY CLUSTERED 
(
	[TipoIdentificacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Universidad]    Script Date: 15/07/2025 7:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universidad](
	[UniversidadId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Nit] [int] NOT NULL,
	[CodigoVerificacion] [int] NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[EsActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Universidad] PRIMARY KEY CLUSTERED 
(
	[UniversidadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Estudiante] ON 

INSERT [dbo].[Estudiante] ([EstudianteId], [PersonaId], [UniversidadId], [Codigo], [CreditosEstudiante], [EsActivo]) VALUES (1, 4, 1, N'964323', 9, 1)
INSERT [dbo].[Estudiante] ([EstudianteId], [PersonaId], [UniversidadId], [Codigo], [CreditosEstudiante], [EsActivo]) VALUES (2, 9, 1, N'12345678', 9, 1)
SET IDENTITY_INSERT [dbo].[Estudiante] OFF
GO
SET IDENTITY_INSERT [dbo].[Inscripcion] ON 

INSERT [dbo].[Inscripcion] ([InscripcionId], [MateriaId], [EstudianteId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (1, 5, 1, 1, CAST(N'2025-07-13T20:49:51.933' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Inscripcion] ([InscripcionId], [MateriaId], [EstudianteId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (2, 6, 1, 1, CAST(N'2025-07-13T20:50:07.423' AS DateTime), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Inscripcion] OFF
GO
SET IDENTITY_INSERT [dbo].[Materia] ON 

INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (2, N'Matematicas Especiales', 3, 1, 1, CAST(N'2025-07-12T23:04:48.920' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (3, N'Programacion Orientada Objetos 1', 3, 1, 1, CAST(N'2025-07-12T23:05:35.413' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (4, N'Fisica Cuantica', 3, 3, 1, CAST(N'2025-07-12T23:14:37.547' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (5, N'Fisica 1', 3, 3, 1, CAST(N'2025-07-12T23:14:58.643' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (6, N'BDD Avanzadas', 3, 4, 1, CAST(N'2025-07-12T23:15:22.697' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (7, N'Calculo Multivariado', 3, 4, 1, CAST(N'2025-07-12T23:16:26.460' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (8, N'Calculo Diferencial', 3, 5, 1, CAST(N'2025-07-12T23:16:51.900' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (9, N'Esquematica Basica', 3, 5, 1, CAST(N'2025-07-12T23:18:01.787' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (10, N'Teoria De Grafos', 3, 6, 1, CAST(N'2025-07-12T23:19:55.117' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Materia] ([MateriaId], [Nombre], [CreditosMateria], [ProfesorId], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModifcadoPor]) VALUES (11, N'Teoria De Conjuntos', 3, 6, 1, CAST(N'2025-07-12T23:20:12.933' AS DateTime), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Materia] OFF
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([PersonaId], [UserId], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Sexo], [TipoIdentificacionId], [Identificacion], [Direccion], [Adicional], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (2, 1, N'Pablo', NULL, N'Gaibor', NULL, N'M', 1, N'1060654382', N'Cra. 58 #12 - 10', NULL, 1, CAST(N'2025-07-12T22:47:37.650' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Persona] ([PersonaId], [UserId], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Sexo], [TipoIdentificacionId], [Identificacion], [Direccion], [Adicional], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (4, 2, N'Pedro', NULL, N'Pascal', NULL, N'M', 2, N'1058672543', N'Cll. 9 #6 -20', NULL, 1, CAST(N'2025-07-12T22:50:34.180' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Persona] ([PersonaId], [UserId], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Sexo], [TipoIdentificacionId], [Identificacion], [Direccion], [Adicional], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (5, 3, N'Sandra', NULL, N'Rojas', NULL, N'F', 1, N'1065432387', N'Cll. 74b #100 - 1', NULL, 1, CAST(N'2025-07-12T23:07:08.527' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Persona] ([PersonaId], [UserId], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Sexo], [TipoIdentificacionId], [Identificacion], [Direccion], [Adicional], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (6, 4, N'Pilar', NULL, N'Rodriguez', NULL, N'F', 1, N'1876965432', N'Cra. 100a #12b -2', NULL, 1, CAST(N'2025-07-12T23:08:04.917' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Persona] ([PersonaId], [UserId], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Sexo], [TipoIdentificacionId], [Identificacion], [Direccion], [Adicional], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (7, 5, N'Esteban', NULL, N'Martinez', NULL, N'M', 1, N'1080643254', N'Cll. 4 #5 - 1', NULL, 1, CAST(N'2025-07-12T23:09:07.700' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Persona] ([PersonaId], [UserId], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Sexo], [TipoIdentificacionId], [Identificacion], [Direccion], [Adicional], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (8, 6, N'Julio', NULL, N'Tobar', NULL, N'M', 1, N'1090754389', N'Cra. 90f bis #30 -30', NULL, 1, CAST(N'2025-07-12T23:10:27.713' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Persona] ([PersonaId], [UserId], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Sexo], [TipoIdentificacionId], [Identificacion], [Direccion], [Adicional], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (9, 7, N'Juan', NULL, N'Velez', NULL, N'M', 2, N'1980754632', N'Cll. 30f #30-30', NULL, 1, CAST(N'2025-07-12T23:24:36.850' AS DateTime), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesor] ON 

INSERT [dbo].[Profesor] ([ProfesorId], [PersonaId], [UniversidadId], [Codigo], [EsActivo]) VALUES (1, 2, 1, N'12345', 1)
INSERT [dbo].[Profesor] ([ProfesorId], [PersonaId], [UniversidadId], [Codigo], [EsActivo]) VALUES (3, 5, 1, N'1234567', 1)
INSERT [dbo].[Profesor] ([ProfesorId], [PersonaId], [UniversidadId], [Codigo], [EsActivo]) VALUES (4, 6, 1, N'123', 1)
INSERT [dbo].[Profesor] ([ProfesorId], [PersonaId], [UniversidadId], [Codigo], [EsActivo]) VALUES (5, 7, 1, N'1234', 1)
INSERT [dbo].[Profesor] ([ProfesorId], [PersonaId], [UniversidadId], [Codigo], [EsActivo]) VALUES (6, 8, 1, N'12345678', 1)
SET IDENTITY_INSERT [dbo].[Profesor] OFF
GO
SET IDENTITY_INSERT [dbo].[Programa] ON 

INSERT [dbo].[Programa] ([ProgramaId], [UniversidadId], [Nombre], [CreditosTotales], [EsActivo], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor]) VALUES (7, 1, N'Ing. sistemas', 50, 1, CAST(N'2025-07-12T23:03:09.137' AS DateTime), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Programa] OFF
GO
SET IDENTITY_INSERT [dbo].[ProgramaMateria] ON 

INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (1, 7, 2)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (3, 7, 3)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (4, 7, 4)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (5, 7, 5)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (6, 7, 6)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (7, 7, 8)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (8, 7, 9)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (9, 7, 10)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (10, 7, 11)
INSERT [dbo].[ProgramaMateria] ([ProgramaMateriaId], [ProgramaId], [MateriaId]) VALUES (11, 7, 7)
SET IDENTITY_INSERT [dbo].[ProgramaMateria] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoIdentificacion] ON 

INSERT [dbo].[TipoIdentificacion] ([TipoIdentificacionId], [Descripcion]) VALUES (1, N'Cedula Ciudadania')
INSERT [dbo].[TipoIdentificacion] ([TipoIdentificacionId], [Descripcion]) VALUES (2, N'Tarjeta Identidad')
SET IDENTITY_INSERT [dbo].[TipoIdentificacion] OFF
GO
SET IDENTITY_INSERT [dbo].[Universidad] ON 

INSERT [dbo].[Universidad] ([UniversidadId], [Nombre], [Nit], [CodigoVerificacion], [Direccion], [Telefono], [EsActivo]) VALUES (1, N'Piloto De Colombia', 123456789, 9, N'Cra 18 #12f - 23', N'3216785438', 1)
SET IDENTITY_INSERT [dbo].[Universidad] OFF
GO
ALTER TABLE [dbo].[Inscripcion] ADD  CONSTRAINT [DF_Inscripcion_FechaCreacion]  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Inscripcion] ADD  CONSTRAINT [DF_Inscripcion_CreadoPor]  DEFAULT ((1)) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[Materia] ADD  CONSTRAINT [DF_Materia_FechaCreacion]  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Materia] ADD  CONSTRAINT [DF_Materia_CreadoPor]  DEFAULT ((1)) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[Persona] ADD  CONSTRAINT [DF_Persona_FechaCreacion]  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Persona] ADD  CONSTRAINT [DF_Persona_CreadoPor]  DEFAULT ((1)) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[Programa] ADD  CONSTRAINT [DF_Programa_FechaCreacion]  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Programa] ADD  CONSTRAINT [DF_Programa_CreadoPor]  DEFAULT ((1)) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante_Persona] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Persona] ([PersonaId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_Estudiante_Persona]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante_Universidad] FOREIGN KEY([UniversidadId])
REFERENCES [dbo].[Universidad] ([UniversidadId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_Estudiante_Universidad]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_Estudiante] FOREIGN KEY([EstudianteId])
REFERENCES [dbo].[Estudiante] ([EstudianteId])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_Estudiante]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_Materia] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materia] ([MateriaId])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_Materia]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Profesor] FOREIGN KEY([ProfesorId])
REFERENCES [dbo].[Profesor] ([ProfesorId])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_Materia_Profesor]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_TipoIdentificacion] FOREIGN KEY([TipoIdentificacionId])
REFERENCES [dbo].[TipoIdentificacion] ([TipoIdentificacionId])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_TipoIdentificacion]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_Persona] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Persona] ([PersonaId])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_Profesor_Persona]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_Universidad] FOREIGN KEY([UniversidadId])
REFERENCES [dbo].[Universidad] ([UniversidadId])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_Profesor_Universidad]
GO
ALTER TABLE [dbo].[Programa]  WITH CHECK ADD  CONSTRAINT [FK_Programa_Universidad] FOREIGN KEY([UniversidadId])
REFERENCES [dbo].[Universidad] ([UniversidadId])
GO
ALTER TABLE [dbo].[Programa] CHECK CONSTRAINT [FK_Programa_Universidad]
GO
ALTER TABLE [dbo].[ProgramaMateria]  WITH CHECK ADD  CONSTRAINT [FK_ProgramaMateria_Materia] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materia] ([MateriaId])
GO
ALTER TABLE [dbo].[ProgramaMateria] CHECK CONSTRAINT [FK_ProgramaMateria_Materia]
GO
ALTER TABLE [dbo].[ProgramaMateria]  WITH CHECK ADD  CONSTRAINT [FK_ProgramaMateria_Programa] FOREIGN KEY([ProgramaId])
REFERENCES [dbo].[Programa] ([ProgramaId])
GO
ALTER TABLE [dbo].[ProgramaMateria] CHECK CONSTRAINT [FK_ProgramaMateria_Programa]
GO
