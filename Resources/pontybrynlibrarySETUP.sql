BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "category" (
	"categoryid"	INTEGER,
	"type"	TEXT,
	PRIMARY KEY("categoryid" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "member" (
	"memberid"	INTEGER,
	"fname"	TEXT NOT NULL,
	"sname"	TEXT NOT NULL,
	"email"	TEXT,
	"streetname"	TEXT NOT NULL,
	"houseidentifier"	TEXT NOT NULL,
	PRIMARY KEY("memberid" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "author" (
	"authorid"	INTEGER,
	"fname"	TEXT NOT NULL,
	"sname"	TEXT NOT NULL,
	PRIMARY KEY("authorid" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "book" (
	"bookid"	INTEGER,
	"title"	TEXT NOT NULL,
	"authorid"	INTEGER NOT NULL,
	"categoryid"	INTEGER NOT NULL,
	PRIMARY KEY("bookid" AUTOINCREMENT),
	FOREIGN KEY("categoryid") REFERENCES "category"("categoryid") ON UPDATE RESTRICT,
	FOREIGN KEY("authorid") REFERENCES "author"("authorid") ON UPDATE RESTRICT
);
CREATE TABLE IF NOT EXISTS "loan" (
	"loanid"	INTEGER,
	"bookid"	INTEGER,
	"memberid"	INTEGER,
	"dateout"	TEXT NOT NULL,
	"datedue"	TEXT NOT NULL,
	"datereturned"	TEXT,
	PRIMARY KEY("loanid" AUTOINCREMENT),
	FOREIGN KEY("memberid") REFERENCES "member"("memberid") ON UPDATE SET NULL,
	FOREIGN KEY("bookid") REFERENCES "book"("bookid") ON UPDATE SET NULL
);
INSERT INTO "category" ("categoryid","type") VALUES (1,'historical fiction'),
 (2,'science fiction'),
 (3,'biography'),
 (4,'thriller fiction'),
 (5,'poetry'),
 (6,'travel'),
 (7,'general fiction'),
 (8,'teenage fiction'),
 (9,'romantic fiction'),
 (10,'science and nature'),
 (11,'humanities and arts'),
 (12,'local history');
INSERT INTO "member" ("memberid","fname","sname","email","streetname","houseidentifier") VALUES (1,'bethan','thomas','bthomas1@bmail.com','school road','15'),
 (2,'gareth','skinner','gskinner123@rotmail.co.uk','highland terrance','7'),
 (3,'clive','hendry','clivealive@yahee.com','park drive','51'),
 (4,'adelajda','boniek','adel.boniek@pontybryn.ac.uk','new road','27'),
 (5,'samesh','khan','skhan100@bmail.com','woodfield road','4'),
 (6,'thomas','davies','daviestunited@rotmail.co.uk','bryn avenue','19'),
 (7,'elizabeth','davies','davieseunited@rotmail.co.uk','bryn avenue','19'),
 (8,'jo','tolley','jt999@yahee.com','new road','12'),
 (9,'jack','tolley','jacktolleyforever@yahee.com','new road','12'),
 (10,'rob','lewis','rjlewis@bmail.com','woodfield road','8'),
 (11,'javed','younis','javyounis3@bmail.com','woodfield road','10'),
 (12,'bronwen','brown','bbrown@yahee.com','park drive','13'),
 (13,'william','evans','williame500@rotmail.co.uk','school road','5');
INSERT INTO "author" ("authorid","fname","sname") VALUES (1,'david','evans'),
 (2,'john','smith'),
 (3,'walter','wall'),
 (4,'sharmila','anand'),
 (5,'minzhe','chen'),
 (6,'rachel','phillips'),
 (7,'jackie','davies'),
 (8,'percy','vere'),
 (9,'derek','miles');
INSERT INTO "book" ("bookid","title","authorid","categoryid") VALUES (1,'the bloody tower',2,1),
 (2,'journey without eend',5,1),
 (3,'the journey',5,1),
 (4,'the king''s court',2,1),
 (5,'martian warrior',4,2),
 (6,'time travel detective',4,2),
 (7,'the sentimental robot',4,2),
 (8,'my carpet fitting life',3,3),
 (9,'never give up',8,3),
 (10,'bourne versus bond',1,4),
 (11,'holiday danger - a dai jones mystery',1,4),
 (12,'the diamond heist - a dai jones mystery',1,4),
 (13,'the hand in the garden',1,4),
 (14,'the caravan man',6,4),
 (15,'las vegas or bust',6,4),
 (16,'photos of pontybryn: 1904-1925',7,12),
 (17,'to the manor born - a history of pontybryn house',7,12),
 (18,'maths for the over 60s',9,10),
 (19,'learning about the small - a casual introduction to subatomic physics',9,10),
 (20,'AI and the home - an idiots guide',4,10);
INSERT INTO "loan" ("loanid","bookid","memberid","dateout","datedue","datereturned") VALUES (1,2,5,'2022-01-01','2022-01-15','2022-01-10'),
 (2,6,5,'2022-01-01','2022-01-15','2022-01-10'),
 (3,9,7,'2022-01-07','2022-01-21','2022-01-21'),
 (4,5,4,'2022-01-09','2022-01-23','2022-01-20'),
 (5,6,4,'2022-01-09','2022-01-23','2022-01-20'),
 (6,6,1,'2022-01-10','2022-01-24','2022-01-18'),
 (7,14,1,'2022-01-10','2022-01-24','2022-01-18'),
 (8,19,1,'2022-01-10','2022-01-24','2022-01-18'),
 (9,7,10,'2022-01-12','2022-01-26','2022-01-29'),
 (10,18,10,'2022-01-12','2022-01-26','2022-01-29'),
 (11,9,13,'2022-01-22','2022-02-05',NULL),
 (12,10,13,'2022-01-22','2022-02-05',NULL),
 (13,1,8,'2022-01-22','2022-02-05','2022-01-29'),
 (14,2,8,'2022-01-22','2022-02-05','2022-01-29'),
 (15,3,4,'2022-01-24','2022-02-07',NULL),
 (16,6,4,'2022-01-24','2022-02-07',NULL),
 (17,13,4,'2022-01-24','2022-02-07',NULL),
 (18,17,11,'2022-01-27','2022-02-10',NULL),
 (19,18,11,'2022-01-27','2022-02-10',NULL),
 (20,4,11,'2022-01-27','2022-02-10',NULL);
COMMIT;
