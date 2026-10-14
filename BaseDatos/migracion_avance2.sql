USE bdpryDistribuidos;
GO

-- 1) Estados de maquinaria iguales a la versión web (necesario para "Dar de baja")
DECLARE @ck SYSNAME;
SELECT @ck = cc.name
FROM sys.check_constraints cc
JOIN sys.columns c ON c.object_id = cc.parent_object_id AND c.column_id = cc.parent_column_id
WHERE cc.parent_object_id = OBJECT_ID('dbo.maquinaria') AND c.name = 'estado';
IF @ck IS NOT NULL EXEC('ALTER TABLE dbo.maquinaria DROP CONSTRAINT ' + QUOTENAME(@ck));
GO
UPDATE dbo.maquinaria SET estado = 'Sin Tarea' WHERE estado = 'Inactivo';
ALTER TABLE dbo.maquinaria ADD CONSTRAINT CK_maquinaria_estado
    CHECK (estado IN ('Operativo','En Mantenimiento','Sin Tarea','Dado de Baja'));
GO

-- 2) Solicitudes: tipo y máquina relacionada (igual que la versión web)
IF COL_LENGTH('dbo.solicitudes', 'tipo_solicitud') IS NULL
    ALTER TABLE dbo.solicitudes ADD tipo_solicitud VARCHAR(15) NOT NULL
        CONSTRAINT DF_solicitudes_tipo DEFAULT 'Mantenimiento'
        CONSTRAINT CK_solicitudes_tipo CHECK (tipo_solicitud IN ('Mantenimiento','Trabajo'));
GO
IF COL_LENGTH('dbo.solicitudes', 'id_maquinaria') IS NULL
    ALTER TABLE dbo.solicitudes ADD id_maquinaria INT NULL
        CONSTRAINT FK_Solicitudes_Maquinaria REFERENCES dbo.maquinaria(id_maquinaria);
GO
