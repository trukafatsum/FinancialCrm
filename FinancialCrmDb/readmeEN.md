# **Backups Folder**

This folder contains the backups of the **FinancialCrmDb** database. The backups are provided in two different formats:

1. **CreateDatabase_FinancialCrmDb.sql** - A SQL query used to create the database structure and tables.
2. **FinancialCrmDb202501190233.zip** - A `.bak` backup file of the database, which can be used for database restoration.

## 1. **CreateDatabase_FinancialCrmDb.sql**

This file allows you to create the **FinancialCrmDb** database from scratch. The database structure, tables, relationships, and other basic configurations are included in this query.

**Usage:**

- Connect to SQL Server Management Studio (SSMS) or any similar SQL client.
- Execute the `CreateDatabase_FinancialCrmDb.sql` file to create your database.

```sql
-- Example Query Execution
-- Open SQL Server Management Studio and execute the query to create the database
```



## 2. **FinancialCrmDb202501190233.zip (.bak Backup)**

This file contains the `.bak` backup of the **FinancialCrmDb** database. You can use this to restore the database to an existing SQL Server instance.

**Usage:**

1. Extract the `FinancialCrmDb202501190233.zip` file.
2. Restore the backup using SQL Server Management Studio (SSMS).

```sql
-- Use the following command to restore the backup:
RESTORE DATABASE FinancialCrmDb
FROM DISK = 'C:\Users\MyPC\Desktop\FinancialCrmDb202501190233.bak'
WITH REPLACE;

```



## Restoring the Backups

Both backup types will allow you to set up the **FinancialCrmDb** database. Depending on your need, you can either run the SQL query to create the database from scratch or restore the `.bak` backup file.

## Notes

- Restoring the backup will overwrite the existing database, so proceed with caution.
- Ensure that the database structure and content are consistent across both backup types.

```yaml
--- 

### **Explanation:**

- **CreateDatabase_FinancialCrmDb.sql**: This file contains SQL commands to create the database from scratch. It is typically used when the database structure needs to be manually created.
- **FinancialCrmDb202501190233.zip (bak Backup)**: This file contains a full backup of the database. The `.bak` file is used for restoring the SQL Server database.

---

This **`README.md`** file will help users understand how to use the backups. When adding your backup files to the **`backups`** folder, don't forget to include this **`README.md`** file as well. 😊

```

