using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCinema.Models
{
    public class GlobalSettings
    {
        public static string connectionString = @"Data Source=LAB1-PC12;Initial Catalog=CinemaDB;User=sa;Password=123456";

        #region AccountsSQL

        #region Select Queries
        public static string loginQuery = @"SELECT s.position, a.staffID
                                        FROM [InventoryDB].[dbo].[Account] a
                                        LEFT JOIN [InventoryDB].[dbo].[Staff] s ON a.staffID = s.staffID
                                        WHERE a.userName = @User 
                                        AND a.userPassword = @Password";


        public static string getPersonnel = @"SELECT CONCAT(s.FirstName,' ',
                                    CASE 
                                    WHEN s.MiddleName IS NULL
                                    THEN ' '
                                    ELSE LEFT(s.MiddleName,1)+'. '
                                    END
                                    ,s.LastName,' ',s.Suffix) AS FullName, *
                                    FROM [dbo].[Accounts] s";

        public string sortByPosition = @"SELECT CONCAT(s.firstName, ' ',
                                    CASE WHEN s.middleName IS NULL THEN ' ' 
                                         ELSE LEFT(s.middleName, 1) + '. ' 
                                    END,
                                    s.lastName, ' ', s.nameExtension) AS fullName, *
                                    FROM [dbo].[Staff] s";

        public static string displayAccounts = @"SELECT a.accountID, s.staffID, a.userName, a.userPassword,
                                    CONCAT(s.firstName,' ',
                                    CASE 
                                    WHEN s.middleName IS NULL
                                    THEN ' '
                                    ELSE LEFT(s.middleName,1)+'. '
                                    END
                                     ,s.lastName,' ',s.nameExtension) AS fullName, s.position
                                    FROM [dbo].Account a
                                    LEFT JOIN Staff s
                                    ON s.staffID = a.staffID";
        #endregion

        #region Insert Queries
        public static string insertQuery = @"INSERT INTO [dbo].[Accounts]
                                   ([AccountID]
                                    ,[FirstName]
                                    ,[MiddleName]
                                    ,[LastName]
                                    ,[Suffix]
                                    ,[Role]
                                    ,[UserName]
                                    ,[PasswordHash])
                                   
                            VALUES
                                    (@AccountID
                                    ,@FirstName
                                    ,@MiddleName
                                    ,@LastName
                                    ,@Suffix
                                    ,@Role
                                    ,@UserName
                                    ,@PasswordHash
                                    );";
        #endregion

        #region Update Queries
        public string updateQuery = @"UPDATE [dbo].[Staff]
                              SET [firstName] = @firstName,
                                  [middleName] = @middleName,
                                  [lastName] = @lastName,
                                  [nameExtension] = @nameExtension,
                                  [gender] = @gender,
                                  [civilStatus] = @civilStatus,
                                  [contactNumber] = @contactNumber,
                                  [address] = @address,
                                  [email] = @email,
                                  [birthDate] = @birthDate,
                                  [position] = @position
                              WHERE [staffID] = @staffID";
        #endregion

        #endregion of AccountsSQL


        #region ProductsSQL

        public static string productList = @"SELECT * FROM Product p
                                             LEFT JOIN Supplier s
                                             ON s.supplierID = p.supplierID
                                             ORDER BY p.productName ASC";

        public static string stockList = @"SELECT 
                                            ns.[productCode],
                                            p.[productName],
                                            ns.[quantity],
                                            ns.[dateReceived],
                                            ns.[expiryDate]
                                            FROM [InventoryDB].[dbo].[NewStock] ns
                                            LEFT JOIN Product p ON p.productCode = ns.productCode
                                            ORDER BY ns.[quantity] ASC, ns.[expiryDate] ASC;";

        public static string insertProduct = @"INSERT INTO [dbo].[Product]
                                           ([productCode]
                                           ,[productName]
                                           ,[productType]
                                           ,[supplierID]
                                           ,[productPrice])
                                     VALUES
                                           (@productCode
                                           ,@productName
                                           ,@productType
                                           ,@supplierID
                                           ,@productPrice);";

        public string populateProduct = @"SELECT productCode
                                          ,p.productName
                                          ,p.productType
                                          ,p.quantity
                                          ,s.supplierID
                                          ,s.supplierName
                                          ,s.contactNumber
                                          ,s.supplierAddress    
                                          ,p.productPrice
                                          ,p.expiryDate
                                          ,p.dateReceived
                                          FROM [InventoryDB].[dbo].[Product] p
                                          LEFT JOIN Supplier s
                                          ON s.supplierID = p.supplierID
                                          WHERE productCode = @productCode";

        public static string updateStock = @"INSERT INTO [dbo].[Product]
                                           ([productCode]
                                           ,[quantity]
                                           ,[expiryDate]
                                           ,[dateReceived])
                                     VALUES
                                           (@productCode
                                           ,@quantity
                                           ,@expiryDate
                                           ,@dateReceived);";

        public static string newStock = @"INSERT INTO [dbo].[NewStock]
                                           ([productCode]
                                           ,[productName]
                                           ,[quantity]
                                           ,[dateReceived]
                                           ,[expiryDate]
                                           ,[capacity])
                                     VALUES
                                           (@productCode
                                           ,@productName
                                           ,@quantity
                                           ,@dateReceived
                                           ,@expiryDate
                                           ,@capacity);";

        public static string minusStock = @"UPDATE [dbo].[NewStock]
                                            SET [quantity] = [quantity] - @amountToRemove
                                            WHERE productCode = @productCode;";

        public string updateProduct = @"DECLARE @oldCapacity INT;
                                        SELECT @oldCapacity = maximumCapacity FROM Product WHERE productCode = @productCode;
                                     
                                        UPDATE [dbo].[Product]
                                        SET 
                                             [productName] = @productName,
                                             [productType] = @productType,
                                             [quantity] = @quantity,
                                             [supplierID] = @supplierID,
                                             [productPrice] = @productPrice,
                                             [expiryDate] = @expiryDate,
                                             [dateReceived] = @dateReceived,
                                             [maximumCapacity] = @maximumCapacity
                                        WHERE productCode = @productCode;
                                     
                                        IF @oldCapacity IS NULL OR @oldCapacity <> @maximumCapacity
                                        BEGIN
                                            DECLARE 
                                                @quantity INT,
                                                @capacity INT,
                                                @remaining INT,
                                                @locationCode VARCHAR(20);

                                            SELECT 
                                                @quantity = quantity,
                                                @capacity = maximumCapacity
                                            FROM Product
                                            WHERE productCode = @productCode;

                                            SET @remaining = @quantity;

                                           
                                            DELETE FROM Location WHERE productCode = @productCode;

                                        
                                            DECLARE shelf_cursor CURSOR FOR
                                                SELECT Code
                                                FROM LocationCodes lc
                                                LEFT JOIN Location l ON lc.Code = l.locationCode
                                                WHERE l.productCode IS NULL
                                                ORDER BY Code;

                                            OPEN shelf_cursor;
                                            FETCH NEXT FROM shelf_cursor INTO @locationCode;

                                            WHILE @@FETCH_STATUS = 0 AND @remaining > 0
                                            BEGIN
                                                INSERT INTO Location (locationCode, productCode)
                                                VALUES (@locationCode, @productCode);

                                                SET @remaining -= @capacity;

                                                FETCH NEXT FROM shelf_cursor INTO @locationCode;
                                            END

                                            CLOSE shelf_cursor;
                                            DEALLOCATE shelf_cursor;
                                            END;";

        public static string newSupplier = @"INSERT INTO [dbo].[Supplier]
                                                   ([supplierID]
                                                   ,[supplierName]
                                                   ,[supplierAddress]
                                                   ,[contactNumber])
                                             VALUES
                                                   (@supplierID
                                                   ,@supplierName
                                                   ,@supplierAddress
                                                   ,@contactNumber);";

        public static string populateSupplier = @"SELECT * FROM [InventoryDB].[dbo].[Supplier] 
                                             WHERE supplierID = @supplierID;";

        public static string updateSupplier = @"UPDATE [dbo].[Supplier]
                                                SET [supplierName] = @supplierName
                                                          ,[contactNumber] = @contactNumber
                                                          ,[supplierAddress] = @supplierAddress
                                                WHERE supplierID = @supplierCode;";



        #region Location Queries

        public static string locationCodes = @"SELECT lc.Code,
                                                CASE 
                                                    WHEN pl.LocationCode IS NULL THEN 'AVAILABLE'
                                                    ELSE 'OCCUPIED'
                                                END AS locationStatus,
    
                                                CASE
                                                    WHEN p.productName IS NULL THEN 'No Product'
                                                    ELSE p.productName
                                                END AS productName,

                                                ISNULL(ns.capacity, 0) AS capacity

                                            FROM [InventoryDB].[dbo].[LocationCodes] lc
                                            LEFT JOIN ProductLocations pl ON pl.LocationCode = lc.Code
                                            LEFT JOIN NewStock ns ON ns.productRollNum = pl.productRollNumber
                                            LEFT JOIN Product p ON p.productCode = ns.productCode";

        public static string productWithLocations = @"SELECT DISTINCT p.[productCode]
                                              ,p.[productName]
                                              ,p.[quantity]
	                                       
                                         FROM [InventoryDB].[dbo].[Product] p
                                          LEFT JOIN ProductLocations l
                                        ON l.productCode = p.productCode
                                        ORDER BY p.productName ASC";

        public static string locationList = @"SELECT p.[productCode]
                                      ,p.[productName]
                                      ,p.[productType]
                                      ,l.locationCode
                                  FROM [InventoryDB].[dbo].[Product] p
                                  LEFT JOIN Location l
                                  ON l.productCode = p.productCode;";

        public static string checkProductQuery = @"SELECT COUNT(*) FROM [dbo].[Location]
                                                WHERE productCode = @productCode";

        public static string checkLocationQuery = @"SELECT COUNT(*) FROM [dbo].[Location] 
                                                WHERE locationCode = @locationCode";

        public static string insertLocation = @"INSERT INTO [dbo].[ProductLocations]
                                               ([LocationCode]
                                               ,[productRollNumber])
                                                VALUES(
                                                @locationCode
                                               ,@productRollNumber)";

        public static string countLocations = @"SELECT COUNT(*) FROM [InventoryDB].[dbo].[ProductLocations]
                                              WHERE LocationCode = @locationCode";

        public static string unlinkProduct = @"UPDATE ProductLocations
                                                SET ProductCode = NULL, LocationCode = NULL
                                                WHERE LocationCode = @locationCode;
                                                DELETE FROM ProductLocations
                                                WHERE ProductCode IS NULL;
                                                DELETE FROM ProductLocations
                                                WHERE LocationCode IS NULL";

        public static string stockWithLocation = @"SELECT 
                                                p.productCode,
                                                p.productName,
                                                ns.quantity,
                                                ns.capacity,
                                                ns.productRollNum AS productRollNumber,
                                                COUNT(pl.LocationCode) AS assignedLocationsCount,
                                                COUNT(pl.LocationCode) * ns.capacity AS totalAssignedCapacity,
                                                ns.quantity - (COUNT(pl.LocationCode) * ns.capacity) AS newQuantity
                                            FROM product p
                                            JOIN newStock ns ON p.productCode = ns.productCode
                                            LEFT JOIN ProductLocations pl ON ns.productRollNum = pl.productRollNumber
                                            GROUP BY p.productCode, p.productName, ns.quantity, ns.capacity, ns.productRollNum
                                            HAVING ns.quantity - (COUNT(pl.LocationCode) * ns.capacity) > 0;";

        #endregion
        #endregion



    }


}
    