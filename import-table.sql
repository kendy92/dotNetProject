--------------------------------------------------------
--  File created - Tuesday-January-09-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table FAQ
--------------------------------------------------------

  CREATE TABLE "N01248070"."FAQ" 
   (	"ID" NUMBER, 
	"QUESTION" VARCHAR2(255 BYTE), 
	"ANSWER" VARCHAR2(255 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Table CONTACT_US
--------------------------------------------------------

  CREATE TABLE "N01248070"."CONTACT_US" 
   (	"ID" NUMBER, 
	"TYPEOFQUERY" VARCHAR2(20 BYTE), 
	"PATIENT_NAME" VARCHAR2(20 BYTE), 
	"PATIENT_EMAIL" VARCHAR2(20 BYTE), 
	"PATIENT_PHONE" VARCHAR2(20 BYTE), 
	"PATIENT_ADDRESS" VARCHAR2(20 BYTE), 
	"PATIENT_COMMENT" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Table RECRUIMENT
--------------------------------------------------------

  CREATE TABLE "N01248070"."RECRUIMENT" 
   (	"ID" NUMBER, 
	"JOB_TITLE" VARCHAR2(100 BYTE), 
	"JOB_DESCRIPTION" VARCHAR2(2000 BYTE), 
	"JOB_REQUIREMENT" VARCHAR2(2000 BYTE), 
	"JOB_BENEFIT" VARCHAR2(2000 BYTE), 
	"JOB_SALARY" VARCHAR2(20 BYTE), 
	"JOB_NUMBER" NUMBER(10,0)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "HTTP5105ONBF17" ;
REM INSERTING into N01248070.FAQ
SET DEFINE OFF;
REM INSERTING into N01248070.CONTACT_US
SET DEFINE OFF;
REM INSERTING into N01248070.RECRUIMENT
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index TABLE1_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "N01248070"."TABLE1_PK" ON "N01248070"."FAQ" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Index BOOK_APPOINTMENT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "N01248070"."BOOK_APPOINTMENT_PK" ON "N01248070"."CONTACT_US" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Index RECRUIMENT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "N01248070"."RECRUIMENT_PK" ON "N01248070"."RECRUIMENT" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  Constraints for Table FAQ
--------------------------------------------------------

  ALTER TABLE "N01248070"."FAQ" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."FAQ" ADD CONSTRAINT "TABLE1_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "HTTP5105ONBF17"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CONTACT_US
--------------------------------------------------------

  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."CONTACT_US" ADD CONSTRAINT "BOOK_APPOINTMENT_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "HTTP5105ONBF17"  ENABLE;
--------------------------------------------------------
--  Constraints for Table RECRUIMENT
--------------------------------------------------------

  ALTER TABLE "N01248070"."RECRUIMENT" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUIMENT" MODIFY ("JOB_TITLE" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUIMENT" MODIFY ("JOB_DESCRIPTION" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUIMENT" MODIFY ("JOB_REQUIREMENT" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUIMENT" MODIFY ("JOB_NUMBER" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUIMENT" ADD CONSTRAINT "RECRUIMENT_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "HTTP5105ONBF17"  ENABLE;
