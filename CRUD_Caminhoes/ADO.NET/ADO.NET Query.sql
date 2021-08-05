create database db_Caminhao
use db_Caminhao

CREATE TABLE [dbo].[Caminhao] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (50)  NOT NULL,
    [DtCriacao] DATETIME      NOT NULL,
    [Descricao] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
CREATE PROCEDURE [dbo].[AtualizarCaminhao](@Id int,@Nome varchar(50),@DtCriacao datetime,@Descricao varchar(50))
AS BEGIN
	Update Caminhao
	SET Nome = @Nome, DtCriacao = @DtCriacao, Descricao = @Descricao
	WHERE Id = @Id
END

GO
CREATE PROCEDURE [dbo].[CriarCaminhao]
(
	@Nome nvarchar(50),
	@DtCriacao datetime,
	@Descricao nvarchar(50)
)
AS BEGIN	
	INSERT INTO Caminhao values
	(
		@Nome,
		@DtCriacao,
		@Descricao
	)
END

GO
CREATE PROCEDURE [dbo].[SelecionarCaminhao]

AS BEGIN

	SELECT * FROM Caminhao

END

GO
CREATE PROCEDURE [dbo].[ExcluirCaminhao]
(
	@Id int
)
AS BEGIN
	DELETE FROM Caminhao WHERE Id = @Id
END
