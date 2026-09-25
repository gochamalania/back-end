SELECT
    fk.name AS ForeignKeyName,
    OBJECT_NAME(fk.parent_object_id) AS ForeignKeyTable,
    COL_NAME(fkc.parent_object_id, fkc.parent_column_id) AS ForeignKeyColumn,
    OBJECT_NAME(fk.referenced_object_id) AS PrimaryKeyTable,
    COL_NAME(fkc.referenced_object_id, fkc.referenced_column_id) AS PrimaryKeyColumn
FROM sys.foreign_keys AS fk
INNER JOIN sys.foreign_key_columns AS fkc
    ON fk.object_id = fkc.constraint_object_id
ORDER BY ForeignKeyTable;