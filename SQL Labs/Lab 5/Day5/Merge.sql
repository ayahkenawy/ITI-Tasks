--Merge statment
--•	Merge statement can be used replicat data from on table to anther
--•	Merge can be a part on sub query or used in SP with output keyword

----------------synax-------------------
--Merge Into 
--Using 
--on

--When matched Then
--[insert or update]

--When matched and Condition[optional]
--Then [insert or update]

--When not matched by target                            
--Then [insert]

--When not matched by Source
--Then [delete or update]

--Output $action,inserted.*,deleted.*;

---------------------------
create table product_Alex
(
ProductID int,
Pname varchar(50),
Price int
)

create table product_Cairo
(
ProductID int,
Pname varchar(50),
Price int
)


Merge into [dbo].[product_Cairo] as T 
using [dbo].[product_Alex] as S
On T.[ProductID]=S.[ProductID]

When matched then
update set T.price=S.price

When not matched by target Then 
insert(ProductID,Pname,Price)
values(S.ProductID,S.Pname,S.Price)

When not matched by Source
Then delete

Output $action,inserted.*,deleted.*;


----Here is the base syntax for MERGE:
    
    [ WITH <common_table_expression> [,...n] ]

    MERGE
    [ TOP ( expression ) [ PERCENT ] ]
    [ INTO ] target_table [ [ AS ] table_alias ]
            [ WITH ( <merge_hint> ) ]

    USING <table_source>

    ON <search_condition>

    [ WHEN MATCHED [ AND <search_condition> ]

            THEN <merge_matched> ]

    [ WHEN [TARGET] NOT MATCHED [ AND <search_condition> ]

            THEN <merge_not_matched> ]

    [ WHEN SOURCE NOT MATCHED [ AND <search_condition> ]

            THEN <merge_matched> ]

    <output_clause>

    [ OPTION ( <query_hint> [ ,...n ] ) ]   
    
--Below is the initial setup for the source and target tables.
-- Static table as target for merging data

    CREATE TABLE CentralOfficeAccounts (
     account_nbr INT PRIMARY KEY,
     company_name VARCHAR(35),
     primary_contact VARCHAR(35),
     contact_phone VARCHAR(12));

-- Dynamic table with daily updates to be merged
    CREATE TABLE BranchOfficeAccounts (
     account_nbr INT PRIMARY KEY,
     company_name VARCHAR(35),
     primary_contact VARCHAR(35),
     contact_phone VARCHAR(12));

-- Sample centrall office static data

   INSERT INTO CentralOfficeAccounts
    VALUES (1, 'Bayside Motors', 'Jim Smith', '902-203-1234'),
           (2, 'Dallas Industries', 'Joe Doe', '301-663-9134'),
           (3, 'Sky Computer Systems', 'Jane Brown', '201-943-6053');

-- Daily updated branch office data
    INSERT INTO BranchOfficeAccounts
    VALUES (2, 'Dallas Industries, Inc.', 'Rick Gross', '301-663-9134'), -- changed
           (3, 'Sky Computer Systems', 'Jane Brown', '201-943-6053'),    -- same
           (4, 'Auto Insurance Co.', 'Chris Jefferson', '313-601-6201'); -- new

--Here is how MERGE can be used to perform an update on existing accounts and insert of new accounts.
-- Update existing and add missing

 MERGE INTO CentralOfficeAccounts AS C    -- Target
 USING BranchOfficeAccounts AS B          -- Source
 ON C.account_nbr = B.account_nbr

 WHEN MATCHED THEN                        -- On match update
 UPDATE SET C.company_name = B.company_name,
      C.primary_contact = B.primary_contact,
      C.contact_phone = B.contact_phone

 WHEN NOT MATCHED THEN                    -- Add missing
 INSERT (account_nbr, company_name, primary_contact, contact_phone)
 VALUES (B.account_nbr, B.company_name, B.primary_contact, B.contact_phone);
 
 
 
 
 SELECT account_nbr, company_name, primary_contact, contact_phone
 FROM CentralOfficeAccounts;

/*
    -- Results:
    account_nbr company_name             primary_contact contact_phone
    ----------- ------------------------ ---------------- -------------
    1           Bayside Motors           Jim Smith        902-203-1234

    2           Dallas Industries, Inc. Rick Gross       301-663-9134

    3           Sky Computer Systems     Jane Brown       201-943-6053

    4           Auto Insurance Co.       Chris Jefferson 313-601-6201
*/
    
