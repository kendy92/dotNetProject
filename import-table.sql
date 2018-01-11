--------------------------------------------------------
--  File created - Wednesday-January-10-2018  - by Lilca Dinh
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table FAQ
--------------------------------------------------------

  CREATE TABLE "N01248070"."FAQ" 
   (	"ID" NUMBER, 
	"QUESTION" VARCHAR2(1000 BYTE), 
	"ANSWER" VARCHAR2(4000 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Table CONTACT_US
--------------------------------------------------------

  CREATE TABLE "N01248070"."CONTACT_US" 
   (	"ID" NUMBER, 
	"TYPEOFQUERY" VARCHAR2(500 BYTE), 
	"PATIENT_NAME" VARCHAR2(255 BYTE), 
	"PATIENT_EMAIL" VARCHAR2(100 BYTE), 
	"PATIENT_PHONE" VARCHAR2(11 BYTE), 
	"PATIENT_ADDRESS" VARCHAR2(255 BYTE), 
	"PATIENT_COMMENT" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Table RECRUITMENT
--------------------------------------------------------

  CREATE TABLE "N01248070"."RECRUITMENT" 
   (	"ID" NUMBER, 
	"JOB_TITLE" VARCHAR2(255 BYTE), 
	"JOB_DESCRIPTION" VARCHAR2(4000 BYTE), 
	"JOB_REQUIREMENT" VARCHAR2(4000 BYTE), 
	"JOB_CATEGORY" VARCHAR2(255 BYTE), 
	"JOB_DIVISION" VARCHAR2(255 BYTE), 
	"JOB_POSTDATE" DATE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "HTTP5105ONBF17" ;
REM INSERTING into N01248070.FAQ
SET DEFINE OFF;
Insert into N01248070.FAQ (ID,QUESTION,ANSWER) values (3,'Can I receive palliative care in the hospital?','If palliative care patients are admitted to hospital, our team of physicians and nurses will be available to care for their palliative care needs while they are in the hospital.');
Insert into N01248070.FAQ (ID,QUESTION,ANSWER) values (1,'Can I smoke in my car?','Anyone wishing to smoke must leave hospital property; this includes the parking lots.');
Insert into N01248070.FAQ (ID,QUESTION,ANSWER) values (2,'I want to discuss issues around death and dying. Who can I talk to?','We have several palliative care physicians, nurses and social workers that are very comfortable having conversations with patients and families about death and dying. For many people, it is an unfamiliar experience and part of our role is to provide patients and families with the information they request and that is most helpful to them.');
Insert into N01248070.FAQ (ID,QUESTION,ANSWER) values (4,'How is this Patient- and Family-Centred Care?','Statistics show that 80% of the general population is non-smokers, and of the 20% who are smokers, 75-80% would like to quit. As a health care organization, it is our duty to model the behaviours we encourage our patients to follow. We have chosen to respect the wishes of the majority. Many alternatives to tobacco will be offered to our patients while they are in hospital and information will be clearly posted on hospital grounds.');
Insert into N01248070.FAQ (ID,QUESTION,ANSWER) values (5,'What information do I need to bring with me to the Hospital?','&lt;p&gt;Patients should bring the following information when registering:&lt;/p&gt;
&lt;ul type=&quot;disc&quot;&gt;&lt;li&gt;Insurance Card&lt;/li&gt;&lt;li&gt;Medicare/Medicaid card&lt;/li&gt;&lt;li&gt;Name and Social Security Number of insured&lt;/li&gt;&lt;li&gt;Referral forms from your physician (if required by your insurance carrier)&lt;/li&gt;&lt;li&gt;Referral/Order Guidelines&lt;/li&gt;&lt;li&gt;Worker’s compensation information (if applicable)&lt;/li&gt;&lt;li&gt;Driver’s license&lt;/li&gt;&lt;li&gt;Co-pay or deductible&lt;/li&gt;&lt;li&gt;Pre-admission form (if not previously submitted)&lt;/li&gt;&lt;li&gt;Advance Directive&lt;/li&gt;&lt;/ul&gt;');
Insert into N01248070.FAQ (ID,QUESTION,ANSWER) values (6,'Why do I need to have a Visitor Pass?','We require everyone entering the Hospital to identify themselves and their destination within the hospital to provide a safer environment for our patients, visitors and staff.');
Insert into N01248070.FAQ (ID,QUESTION,ANSWER) values (7,'What is the Observation (formerly Short Stay) Unit?','The Observation Unit cares for patients whose condition needs to be monitored for an extended time—up to 23 hours—to determine if it is necessary to admit the patient as an inpatient.');
REM INSERTING into N01248070.CONTACT_US
SET DEFINE OFF;
REM INSERTING into N01248070.RECRUITMENT
SET DEFINE OFF;
Insert into N01248070.RECRUITMENT (ID,JOB_TITLE,JOB_DESCRIPTION,JOB_REQUIREMENT,JOB_CATEGORY,JOB_DIVISION,JOB_POSTDATE) values (3,'Registered Nurse','&lt;p&gt;Days and nights, including weekends, 12 hour shifts. &lt;br&gt;
*For information purposes only - The Hospital reserves the right to change.&lt;p&gt;','&lt;p&gt;&lt;strong&gt;Basic Requirements&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Certificate of registration from the College of Nurses of Ontario;&lt;br&gt;
Miminum three (3) months of recent Emergency experience in a acute care facility;&lt;br&gt;
ACLS certification or Emergency/Critical care courses in progress;&lt;br&gt;
Demonstrates a commitment to continuing education and willingness to actively participate in departmental educational activities;&lt;br&gt;
Demonstrates a knowledge of the nursing process and the ability to apply this process to the practice of Nursing;&lt;br&gt;
Demonstrates a commitment to patient teaching;&lt;br&gt;
Demonstrates the ability to work effectively as an active member of the health care team;  
Demonstrates a professional and respectful attitude to patients, the public and colleagues.&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;Please Note&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Applicants selected for an interview will be notified of interview results.&lt;/p&gt;


&lt;p&gt;&lt;strong&gt;Preferred Qualifications&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Bachelor of Science Degree in Nursing;&lt;br&gt;
Post-graduate studies&lt;br&gt;
Proficiency in English and French – oral expression (advanced level) and comprehension (advanced level&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;How to Apply&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;If you are passionate about what you do, motivated by improving the health of the community, excited by leading-edge medical technology, and as committed to excellence, quality and patient safety as we are, we would like to hear from you. Please submit an on-line application for the position you are interested in.  We thank all those who apply but only those selected for further consideration will be contacted.&lt;/p&gt; ','Nursing','General Emergency',to_date('10-JAN-18','DD-MON-RR'));
Insert into N01248070.RECRUITMENT (ID,JOB_TITLE,JOB_DESCRIPTION,JOB_REQUIREMENT,JOB_CATEGORY,JOB_DIVISION,JOB_POSTDATE) values (1,'Registered Nurse','&lt;p&gt;Days and evenings, including weekends, 8 hour shifts.&lt;br&gt;

*For information purposes only - The Hospital reserves the right to change.&lt;/p&lt;','&lt;p&gt;&lt;strong&gt;Basic Requirements&lt;/strong&gt;&lt;br&gt;

 &lt;p&gt;Certificate of registration from the College of Nurses of Ontario;&lt;br&gt;
 BCLS/CPR;&lt;br&gt;
 Minimum of three (3) months of recent experience in Hemodialysis;&lt;br&gt;
 Critical thinking skills;&lt;br&gt;
 Demonstrates theoretical knowledge of the nursing process as it relates to the Medicine/Surgery patient and the ability to apply this in a clinical setting;&lt;br&gt;
 Theoretical knowledge of the care of patients with acute/chronic kidney disease;&lt;br&gt;
 Demonstration of teaching, interpersonal and problem solving skills;&lt;br&gt;
 Demonstrates a professional and respectful attitude to patients, to the public and to colleagues;&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;Please Note&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Applicants who do not meet the above-noted requirements are eligible to apply for this position and may be considered if there are no other applicants who meet all of the requirements.

Applicants selected for an interview will be notified of interview results.&lt;/p&gt;


&lt;p&gt;&lt;strong&gt;Preferred Qualifications
&lt;/strong&gt;&lt;/p&gt;
 &lt;p&gt;A degree in Nursing;&lt;br&gt;
 Nephrology certification;&lt;br&gt;
 Proficiency in English and French – oral expression (advanced level) and comprehension (advanced level).&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;How to Apply&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;If you are passionate about what you do, motivated by improving the health of the community, excited by leading-edge medical technology, and as committed to excellence, quality and patient safety as we are, we would like to hear from you. Please submit an on-line application for the position you are interested in.  We thank all those who apply but only those selected for further consideration will be contacted.&lt;/p&gt; 

','Nursing','Hemodialysis',to_date('10-JAN-18','DD-MON-RR'));
Insert into N01248070.RECRUITMENT (ID,JOB_TITLE,JOB_DESCRIPTION,JOB_REQUIREMENT,JOB_CATEGORY,JOB_DIVISION,JOB_POSTDATE) values (2,'Registered Nurse - Operating Room Candidate Pool','	

&lt;p&gt;&lt;strong&gt;Are you a Registered Nurse with OR experience, or have you recently completed an OR course?&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Do you want to work for an organization recently recognized as having one of Canada’s most admired corporate cultures? We are currently accepting resumes to build a pool of qualified candidates for future opportunities in the OR at the Civic, General and Riverside campuses.&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;Who We Are&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;The Hospital is one of Canada’s largest learning and research hospitals, with more than 1,100 beds, approximately 12,000 staff members and an annual budget of about $1.2 billion.&lt;/p&gt;

&lt;p&gt;Our focus on learning and research helps us develop new and innovative ways to treat patients and improve care. As a multi-campus hospital affiliated with the University of Ottawa, we deliver specialized care to the Eastern Ontario region, but our techniques and research discoveries are adopted around the world. We engage the community at all levels to support our vision for better patient care.&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;Who You Are&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;You are an experienced Registered Nurse with a passion for people and a desire to make a difference. The work that you do at The Ottawa Hospital matters because you are key player on a team who is committed to providing each patient with an exceptional experience by demonstrating compassion, respect for all, a collaborative spirit and a commitment to quality. &lt;/p&gt;','&lt;p&gt;&lt;strong&gt;Sounds like you? Do you have the skills and experience listed below?&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Certificate of Registration from the College of Nurses of Ontario;&lt;br&gt;
Post graduate operating room course completed within the last six (6) months with two years working in an acute care setting OR currently working within an acute care operating room environment with two (2) years of experience working in an operating room;&lt;br&gt;
Current BCLS;&lt;br&gt;
Demonstrated ability with and knowledge of AIDET and other clinical tactics;&lt;br&gt;
Demonstrates knowledge of Operating Room Nursing principles and practices, and knowledge of Operating Room surgical procedures and equipment;&lt;br&gt;
Ability to function effectively as a team member in a work environment requiring precision, accuracy, quick response and collaborative approaches;&lt;br&gt;
Demonstrates the ability to function effectively in a physically demanding workplace;&lt;br&gt;
Demonstrates the ability to acquire additional skills to function effectively in an Operating Room nursing role;&lt;br&gt;
Demonstrates strong communication and interpersonal skills;&lt;br&gt;
Identifies a commitment to personal continuing education activities;&lt;br&gt;
Skilled user in a computer technology environment.&lt;br&gt;
You’ll stand out if you have…&lt;/p&gt;

&lt;p&gt;BSc.N.;&lt;br&gt;
CPN (C) designation;&lt;br&gt;
Continuing Education programs/courses in Operating Room Nursing.&lt;br&gt;
Proficiency in English and French – oral expression (advanced level) and comprehension (advanced level).&lt;/p&gt;
&lt;p&gt;What we need from you&lt;/p&gt;

&lt;p&gt;Please submit your online application, including your CV and cover letter, so that you may be considered for future vacancies.&lt;/p&gt;','Nursing','Gen Surgical',to_date('10-JAN-18','DD-MON-RR'));
Insert into N01248070.RECRUITMENT (ID,JOB_TITLE,JOB_DESCRIPTION,JOB_REQUIREMENT,JOB_CATEGORY,JOB_DIVISION,JOB_POSTDATE) values (4,'General Service','&lt;p&gt;Rotation - Various shifts&lt;/p&gt;','	
&lt;p&gt;&lt;strong&gt;Basic Requirements&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Grade 10;&lt;br&gt;
Good written and verbal communication skills in English;&lt;br&gt;
Regular cleaner scope of tasks for a patient care area.&lt;/p&gt;
 


&lt;p&gt;&lt;strong&gt;How to Apply&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;If you are passionate about what you do, motivated by improving the health of the community, excited by leading-edge medical technology, and as committed to excellence, quality and patient safety as we are, we would like to hear from you. Please submit an on-line application for the position you are interested in.  We thank all those who apply but only those selected for further consideration will be contacted.  &lt;/p&gt;','Facilities and Maintenance','Housekeeping',to_date('10-JAN-18','DD-MON-RR'));
Insert into N01248070.RECRUITMENT (ID,JOB_TITLE,JOB_DESCRIPTION,JOB_REQUIREMENT,JOB_CATEGORY,JOB_DIVISION,JOB_POSTDATE) values (5,'Supervisor, Dental Clinic','Rotation/Shifts

Days, 8 hour shifts.','&amp;lt;p&amp;gt;&amp;lt;strong&amp;gt;Basic Requirements&amp;lt;/strong&amp;gt;&amp;lt;/p&amp;gt;

&amp;lt;p&amp;gt;Community College Diploma from a  Dental Hygiene/Dental Assistant Course or equivalent;&amp;lt;br&amp;gt;
3-5 years supervisory experience in health care setting;&amp;lt;br&amp;gt;
3-5 years recent experience in managing a dental practice;&amp;lt;br&amp;gt;
Current registration with College Dental Hygiene of Ontario or Ontario Dental Assistants Association;&amp;lt;br&amp;gt;
Membership with CDHA, ODHA or ODAA;&amp;lt;br&amp;gt;
Experience using dental management software and completing  dental billing submissions;&amp;lt;br&amp;gt;
Working knowledge of personal computers and related software (email, word processing, database and spreadsheet software);&amp;lt;br&amp;gt;
Knowledge of dental billing procedures, financial account management, patient accounts, scheduling a variety medical services, and completing clinical requisitions
Knowledge of insurance plans and claims and processing;&amp;lt;br&amp;gt;
Knowledge of dental terminology, and current dental office procedure with recent application;
Superior oral/written communication and interpersonal skills;&amp;lt;br&amp;gt;
Excellent presentation and training skills;&amp;lt;br&amp;gt;
Excellent analytical and problem solving skills;&amp;lt;br&amp;gt;
Ability to work in a fast paced environment;&amp;lt;br&amp;gt;
Ability to respond to large numbers of simultaneous demands from staff, physicians, logistical services, Human Resources, etc.;&amp;lt;br&amp;gt;
Ability to learn, understand and apply hospital policies and procedures, relative legislation, collective agreements, Canadian Hospital Accreditation Standards, Professional Disciplines Standards for Ontario.&amp;lt;/p&amp;gt;

&amp;lt;p&amp;gt;&amp;lt;strong&amp;gt;Preferred Qualifications&amp;lt;/strong&amp;gt;&amp;lt;/p&amp;gt;

&amp;lt;p&amp;gt;Knowledge of the Occupational Health &amp;amp; Safety Act and Public Hospital’s Act;
Proficiency in English and French oral expression (advanced level) and comprehension (advanced level).&amp;lt;/p&amp;gt;','Allied Health Professional','Dental Clinic',to_date('10-JAN-18','DD-MON-RR'));
--------------------------------------------------------
--  DDL for Index TABLE1_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "N01248070"."TABLE1_PK" ON "N01248070"."FAQ" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Index BOOK_APPOINTMENT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "N01248070"."BOOK_APPOINTMENT_PK" ON "N01248070"."CONTACT_US" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  DDL for Index RECRUITMENT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "N01248070"."RECRUITMENT_PK" ON "N01248070"."RECRUITMENT" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "HTTP5105ONBF17" ;
--------------------------------------------------------
--  Constraints for Table FAQ
--------------------------------------------------------

  ALTER TABLE "N01248070"."FAQ" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."FAQ" ADD CONSTRAINT "TABLE1_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "HTTP5105ONBF17"  ENABLE;
  ALTER TABLE "N01248070"."FAQ" MODIFY ("QUESTION" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."FAQ" MODIFY ("ANSWER" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CONTACT_US
--------------------------------------------------------

  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("TYPEOFQUERY" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("PATIENT_NAME" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."CONTACT_US" ADD CONSTRAINT "BOOK_APPOINTMENT_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "HTTP5105ONBF17"  ENABLE;
  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("PATIENT_EMAIL" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("PATIENT_PHONE" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("PATIENT_ADDRESS" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."CONTACT_US" MODIFY ("PATIENT_COMMENT" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table RECRUITMENT
--------------------------------------------------------

  ALTER TABLE "N01248070"."RECRUITMENT" MODIFY ("JOB_DESCRIPTION" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUITMENT" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUITMENT" MODIFY ("JOB_TITLE" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUITMENT" MODIFY ("JOB_REQUIREMENT" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUITMENT" MODIFY ("JOB_CATEGORY" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUITMENT" MODIFY ("JOB_DIVISION" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUITMENT" MODIFY ("JOB_POSTDATE" NOT NULL ENABLE);
  ALTER TABLE "N01248070"."RECRUITMENT" ADD CONSTRAINT "RECRUITMENT_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "HTTP5105ONBF17"  ENABLE;
