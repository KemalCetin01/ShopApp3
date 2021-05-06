--select * from Products s where s.id=14;

SELECT OBJECT_NAME(OBJECT_ID) AS TableName, last_user_update
FROM sys.dm_db_index_usage_stats
WHERE  OBJECT_ID = OBJECT_ID('Products')