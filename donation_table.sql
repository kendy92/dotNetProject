  CREATE TABLE "DONATION_SECTION" 
   (	"DONATION_AMOUNT" VARCHAR2(10 BYTE), 
	"TITLE" VARCHAR2(5 BYTE), 
	"FIRST_NAME" VARCHAR2(20 BYTE), 
	"LAST_NAME" VARCHAR2(20 BYTE), 
	"EMAIL" VARCHAR2(30 BYTE), 
	"COUNTRY" VARCHAR2(20 BYTE), 
	"ADDRESS_1" VARCHAR2(50 BYTE), 
	"ADDRESS_2" VARCHAR2(50 BYTE), 
	"CITY" VARCHAR2(20 BYTE), 
	"PROVINCE_STATE" VARCHAR2(2 BYTE), 
	"POSTAL_ZIP_CODE" VARCHAR2(7 BYTE), 
	"PHONE" VARCHAR2(15 BYTE), 
	"DESCRIPTION" VARCHAR2(240 BYTE), 
	"CREDIT_CARD_NUMBER" VARCHAR2(16 BYTE), 
	"CARDHOLDERS_NAME" VARCHAR2(30 BYTE), 
	"EXPIRATION_DATE" VARCHAR2(5 BYTE), 
	"CARD_SECURITY_CODE" VARCHAR2(3 BYTE), 
	"ID" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE 
   ) 
   
Insert into DONATION_SECTION (DONATION_AMOUNT,TITLE,FIRST_NAME,LAST_NAME,EMAIL,COUNTRY,ADDRESS_1,ADDRESS_2,CITY,PROVINCE_STATE,POSTAL_ZIP_CODE,PHONE,DESCRIPTION,CREDIT_CARD_NUMBER,CARDHOLDERS_NAME,EXPIRATION_DATE,CARD_SECURITY_CODE,ID) values ('5000','Mr.','Bradley','Cooper','b.cooper@gmail.com','USA','8 Flamingo str.','Unit 55','Flagstaff','AZ','42342','2345162242','General Donation','4569399353954935','Bradley Cooper','12-21','423',82);
Insert into DONATION_SECTION (DONATION_AMOUNT,TITLE,FIRST_NAME,LAST_NAME,EMAIL,COUNTRY,ADDRESS_1,ADDRESS_2,CITY,PROVINCE_STATE,POSTAL_ZIP_CODE,PHONE,DESCRIPTION,CREDIT_CARD_NUMBER,CARDHOLDERS_NAME,EXPIRATION_DATE,CARD_SECURITY_CODE,ID) values ('100','Miss','Maria','Honsales','hons_maria@yahoo.com','USA','33 Coronation Blvd',null,'Huston','TX','23525','3673938484','General Donation','4745378958974379','Maria','07-18','325',83);
Insert into DONATION_SECTION (DONATION_AMOUNT,TITLE,FIRST_NAME,LAST_NAME,EMAIL,COUNTRY,ADDRESS_1,ADDRESS_2,CITY,PROVINCE_STATE,POSTAL_ZIP_CODE,PHONE,DESCRIPTION,CREDIT_CARD_NUMBER,CARDHOLDERS_NAME,EXPIRATION_DATE,CARD_SECURITY_CODE,ID) values ('1500','Ms.','Galya','Vasina','vasinag@he.com','Russia','23 Putin str.','unit 2','Rostov','RS','23423','2356575453','In Memory Donation','4566534567873423','Galya Vasina','10-21','546',84);
Insert into DONATION_SECTION (DONATION_AMOUNT,TITLE,FIRST_NAME,LAST_NAME,EMAIL,COUNTRY,ADDRESS_1,ADDRESS_2,CITY,PROVINCE_STATE,POSTAL_ZIP_CODE,PHONE,DESCRIPTION,CREDIT_CARD_NUMBER,CARDHOLDERS_NAME,EXPIRATION_DATE,CARD_SECURITY_CODE,ID) values ('300','Mr.','Justin','Bieber','jb@bieber.com','Canada','50 Melchior dr.',null,'London','ON','M1E 3W5','4168214681','Grateful Patient or In Honour Donation','4544656434623634','Justin JB Bieber','04-22','654',85);
Insert into DONATION_SECTION (DONATION_AMOUNT,TITLE,FIRST_NAME,LAST_NAME,EMAIL,COUNTRY,ADDRESS_1,ADDRESS_2,CITY,PROVINCE_STATE,POSTAL_ZIP_CODE,PHONE,DESCRIPTION,CREDIT_CARD_NUMBER,CARDHOLDERS_NAME,EXPIRATION_DATE,CARD_SECURITY_CODE,ID) values ('10000','Mr.','Yuriy','Yakymenko','yakymenko.y@gmail.com','Ukraine','13B Goloseevska str','unit 272','Kiev','KI','03039','4168358707','General Donation','4343534634634634','Yuriy Yakymenko','06-20','234',86);


  ALTER TABLE "DONATION_SECTION" MODIFY ("CARDHOLDERS_NAME" NOT NULL ENABLE);
  ALTER TABLE "DONATION_SECTION" MODIFY ("EXPIRATION_DATE" NOT NULL ENABLE);
  ALTER TABLE "DONATION_SECTION" MODIFY ("CARD_SECURITY_CODE" NOT NULL ENABLE);
  ALTER TABLE "DONATION_SECTION" MODIFY ("DONATION_AMOUNT" NOT NULL ENABLE);
  ALTER TABLE "DONATION_SECTION" MODIFY ("CREDIT_CARD_NUMBER" NOT NULL ENABLE);
  ALTER TABLE "DONATION_SECTION" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "DONATION_SECTION" ADD PRIMARY KEY ("ID")

