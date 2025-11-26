Create DataBase FinanceiroBD
go
use financeiro
go

create login Financei with password='senha123';
create user Financei from login Financei;

exec sp_addrolemember 'DB_DATAREADER', 'Financei';
exec sp_addrolemember 'DB_DATAWRITER', 'Financei';

CREATE TABLE Lancamentos
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Descricao NVARCHAR(255) NOT NULL,
    Valor DECIMAL(18,2) NOT NULL,
    DataLancamento DATE NOT NULL,
    Tipo CHAR(1) NOT NULL
);