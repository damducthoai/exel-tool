USE [exeltool]
GO
/****** Object:  Table [dbo].[bom]    Script Date: 5/23/2018 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bom](
	[component_id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[check] [int] NULL,
	[component_name] [nvarchar](50) NULL,
	[object_description] [nvarchar](50) NULL,
 CONSTRAINT [PK_bom_1] PRIMARY KEY CLUSTERED 
(
	[component_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bom_model]    Script Date: 5/23/2018 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bom_model](
	[component_id] [decimal](18, 0) NOT NULL,
	[model_name] [nvarchar](50) NOT NULL,
	[model_value] [decimal](18, 0) NULL,
	[id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_bom_model] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[planx]    Script Date: 5/23/2018 10:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[planx](
	[plan_id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[component_id] [decimal](18, 0) NULL,
	[model_id] [decimal](18, 0) NULL,
	[plan_data] [decimal](18, 0) NULL,
	[plan_line] [decimal](18, 0) NULL,
	[plan_time] [nvarchar](50) NULL,
 CONSTRAINT [PK_plan] PRIMARY KEY CLUSTERED 
(
	[plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bom_model] ADD  CONSTRAINT [DF_bom_model_model_value]  DEFAULT ((0)) FOR [model_value]
GO
ALTER TABLE [dbo].[bom_model]  WITH CHECK ADD  CONSTRAINT [FK_bom_model_bom] FOREIGN KEY([component_id])
REFERENCES [dbo].[bom] ([component_id])
GO
ALTER TABLE [dbo].[bom_model] CHECK CONSTRAINT [FK_bom_model_bom]
GO
ALTER TABLE [dbo].[planx]  WITH CHECK ADD  CONSTRAINT [FK_plan_bom] FOREIGN KEY([component_id])
REFERENCES [dbo].[bom] ([component_id])
GO
ALTER TABLE [dbo].[planx] CHECK CONSTRAINT [FK_plan_bom]
GO
ALTER TABLE [dbo].[planx]  WITH CHECK ADD  CONSTRAINT [FK_plan_bom_model] FOREIGN KEY([model_id])
REFERENCES [dbo].[bom_model] ([id])
GO
ALTER TABLE [dbo].[planx] CHECK CONSTRAINT [FK_plan_bom_model]
GO
