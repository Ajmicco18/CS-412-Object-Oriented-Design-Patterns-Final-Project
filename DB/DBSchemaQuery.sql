/*Use MyInstance database as db name*/
alter table SUPPLIER
add NAME nvarchar(64);

alter table COUNTRY
add NAME nvarchar(64);

alter table BANK
add BANK_NAME nvarchar(64),
SWIFT_CODE int not null,
ACCOUNT_NUM int not null,
SUPPLIER nvarchar(64),
ROUTING_NUM int not null;

alter table BANK_ACCOUNT
add BENEFICIARY nvarchar(64),
AMOUNT_DUE int not null, 
ACCOUNT_TYPE nvarchar(32);

insert into BANK ( COUNTRY_CID, BANK_NAME, SWIFT_CODE, ACCOUNT_NUM, SUPPLIER, ROUTING_NUM) 
						values ( 1, 'Alpha Bank', 123, 12345678, 'Greek Government', 263421202 );
insert into BANK ( COUNTRY_CID, BANK_NAME, SWIFT_CODE, ACCOUNT_NUM, SUPPLIER, ROUTING_NUM) 
						values ( 2, 'Farmers National Bank', 345, 87654321, 'American Government', 041209080 );
insert into BANK ( COUNTRY_CID, BANK_NAME, SWIFT_CODE, ACCOUNT_NUM, SUPPLIER, ROUTING_NUM) 
						values ( 3, 'UniCredit Bank', 456, 36912151, 'Italian Government', 003481701 );

insert into SUPPLIER_CATEGORY (CID, LEVEL, PARENT_CATEGORY_CID )
						values(1, 5, 1);
insert into SUPPLIER_CATEGORY (CID, LEVEL, PARENT_CATEGORY_CID )
						values(2, 1, 2);
insert into SUPPLIER_CATEGORY (CID, LEVEL, PARENT_CATEGORY_CID )
						values(3, 0, 3);

insert into SUPPLIER( SUPPLIER_CATEGORY_CID, NAME) 
						values ( 1, 'Greek Government');
insert into SUPPLIER( SUPPLIER_CATEGORY_CID, NAME) 
						values ( 2, 'American Government');
insert into SUPPLIER( SUPPLIER_CATEGORY_CID, NAME) 
						values ( 3, 'Italian Government');

insert into BANK_ACCOUNT( SUPPLIER_ID, IBAN, BANK_ID, BENEFICIARY, AMOUNT_DUE, ACCOUNT_TYPE) 
						values ( 1, 'GR 12 123 102030 12345678', 7, 'John Doe', 345, 'Checking' );
insert into BANK_ACCOUNT( SUPPLIER_ID, IBAN, BANK_ID, BENEFICIARY, AMOUNT_DUE, ACCOUNT_TYPE) 
						values ( 2, 'US 23 456 213141 87654321', 8, 'Jane Doe', 100, 'Savings' );
insert into BANK_ACCOUNT( SUPPLIER_ID, IBAN, BANK_ID, BENEFICIARY, AMOUNT_DUE, ACCOUNT_TYPE) 
						values ( 3, 'IT 45 789 324252 36912151', 9, 'John Doe', 18, 'Checking' );

insert into COUNTRY(CID, NAME) 
						values (1,'Greece');
insert into COUNTRY(CID, NAME) 
						values (2,'United States');
insert into COUNTRY(CID, NAME) 
						values (3,'Italy');
insert into COUNTRY(CID, NAME) 
						values (4,'Germany');
insert into COUNTRY(CID, NAME) 
						values (5,'Mexico');
insert into COUNTRY(CID, NAME) 
						values (6,'France');

INSERT INTO COUNTRY (CID, NAME) VALUES (43, 'Austria');
INSERT INTO COUNTRY (CID, NAME) VALUES (32, 'Belgium');
INSERT INTO COUNTRY (CID, NAME) VALUES (359,'Bulgaria'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (385, 'Croatia'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (357, 'Cyprus');
INSERT INTO COUNTRY (CID, NAME) VALUES (420, 'Czech Republic');
INSERT INTO COUNTRY (CID, NAME) VALUES (45, 'Denmark'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (372, 'Estonia'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (34,'Finland');
INSERT INTO COUNTRY (CID, NAME) VALUES (33, 'France');
INSERT INTO COUNTRY (CID, NAME) VALUES (49, 'Germany');
INSERT INTO COUNTRY (CID, NAME) VALUES (30, 'Greece'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (36, 'Hungary');
INSERT INTO COUNTRY (CID, NAME) VALUES (353, 'Ireland');
INSERT INTO COUNTRY (CID, NAME) VALUES (39, 'Italy');
INSERT INTO COUNTRY (CID, NAME) VALUES (371, 'Latvia');
INSERT INTO COUNTRY (CID, NAME) VALUES (370, 'Lithuania');
INSERT INTO COUNTRY (CID, NAME) VALUES (352, 'Luxembourg'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (31, 'Netherlands');
INSERT INTO COUNTRY (CID, NAME) VALUES (48, 'Poland'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (351, 'Portugal');
INSERT INTO COUNTRY (CID, NAME) VALUES (40, 'Romania');
INSERT INTO COUNTRY (CID, NAME) VALUES (386, 'Slovenia');
INSERT INTO COUNTRY (CID, NAME) VALUES (421, 'Slovakia'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (61, 'Australia'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (355, 'Albania');
INSERT INTO COUNTRY (CID, NAME) VALUES (381, 'Serbia'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (382, 'Montenegro');
INSERT INTO COUNTRY (CID, NAME) VALUES (389, 'North Macedonia');
INSERT INTO COUNTRY (CID, NAME) VALUES (387, 'Bosnia and Herzegovina');
INSERT INTO COUNTRY (CID, NAME) VALUES (373, 'Moldova');
INSERT INTO COUNTRY (CID, NAME) VALUES (44, 'United Kingdom');
INSERT INTO COUNTRY (CID, NAME) VALUES (1, 'United States');
INSERT INTO COUNTRY (CID, NAME) VALUES (11, 'Canada');
INSERT INTO COUNTRY (CID, NAME) VALUES (81, 'Japan'); 
INSERT INTO COUNTRY (CID, NAME) VALUES (20, 'Egypt');

update COUNTRY
set NAME = 'United States'
where CID = 1;
SELECT * FROM COUNTRY;

update COUNTRY
set CID = '52'
where CID = 5;

update BANK
set COUNTRY_CID = 39
where ID = 9;

DELETE FROM COUNTRY WHERE CID = 3;
DELETE FROM COUNTRY WHERE CID = 4;
DELETE FROM COUNTRY WHERE CID = 6;

update BANK_ACCOUNT
set IBAN = 'GR1212310203012345678'
where BANK_ID = 7;

update BANK_ACCOUNT
set IBAN = 'US2345621314187654321'
where BANK_ID = 8;

update BANK_ACCOUNT
set IBAN = 'IT4578932425236912151'
where BANK_ID = 9;

SELECT * FROM BANK;
SELECT * FROM BANK_ACCOUNT;
SELECT * FROM COUNTRY;
SELECT * FROM SUPPLIER;

alter TABLE BANK
alter COLUMN SWIFT_CODE nvarchar(32);

alter TABLE BANK
alter COLUMN ACCOUNT_NUM nvarchar(32);

alter TABLE BANK
alter COLUMN ROUTING_NUM nvarchar(32);

update SUPPLIER
set NAME = 'Government'
WHERE ID = 1;

update SUPPLIER
set NAME = 'Loan Officers'
WHERE ID = 2;

update SUPPLIER
set NAME = 'Depositors'
WHERE ID = 3;

insert into SUPPLIER_CATEGORY (CID, LEVEL, PARENT_CATEGORY_CID )
						values(4, 3, 4);

insert into SUPPLIER( SUPPLIER_CATEGORY_CID, NAME) 
						values ( 4, 'Central Banks');











