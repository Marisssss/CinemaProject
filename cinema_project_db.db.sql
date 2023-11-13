BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Post" (
	"ID_post"	INTEGER NOT NULL UNIQUE,
	"Name_post"	TEXT NOT NULL,
	PRIMARY KEY("ID_post" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Hall" (
	"ID_hall"	INTEGER NOT NULL UNIQUE,
	"Number_of_seats"	INTEGER NOT NULL,
	PRIMARY KEY("ID_hall" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Client" (
	"ID_client"	INTEGER NOT NULL UNIQUE,
	"Last_name_client"	TEXT NOT NULL,
	"Name_client"	TEXT NOT NULL,
	"Middle_name_client"	TEXT NOT NULL,
	PRIMARY KEY("ID_client" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Movie" (
	"ID_movie"	INTEGER NOT NULL UNIQUE,
	"Name_movie"	TEXT NOT NULL UNIQUE,
	"Rating"	NUMERIC NOT NULL,
	PRIMARY KEY("ID_movie" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Session" (
	"ID_session"	INTEGER NOT NULL UNIQUE,
	"Cost"	INTEGER NOT NULL,
	"Number_of_client"	INTEGER NOT NULL,
	"Session_start_time"	TEXT NOT NULL,
	"Session_end_time"	NUMERIC NOT NULL,
	"ID_movie"	INTEGER NOT NULL,
	"ID_hall"	INTEGER NOT NULL,
	PRIMARY KEY("ID_session" AUTOINCREMENT),
	FOREIGN KEY("ID_hall") REFERENCES "Hall"("ID_hall") ON UPDATE CASCADE,
	FOREIGN KEY("ID_movie") REFERENCES "Movie"("ID_movie") ON UPDATE CASCADE
);
CREATE TABLE IF NOT EXISTS "Employee" (
	"ID_employee"	INTEGER NOT NULL UNIQUE,
	"Last_name_employee"	TEXT NOT NULL,
	"Name_employee"	TEXT NOT NULL,
	"Middle_name_employee"	TEXT NOT NULL,
	"Date_of_birth"	TEXT NOT NULL,
	"Floor"	TEXT,
	"ID_post"	INTEGER NOT NULL,
	PRIMARY KEY("ID_employee" AUTOINCREMENT),
	FOREIGN KEY("ID_post") REFERENCES "Post"("ID_post") ON UPDATE CASCADE
);
CREATE TABLE IF NOT EXISTS "Cinema" (
	"ID_cinema"	INTEGER NOT NULL UNIQUE,
	"Address"	TEXT NOT NULL UNIQUE,
	"Name_cinema"	TEXT NOT NULL UNIQUE,
	PRIMARY KEY("ID_cinema" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Client_Session" (
	"ID_client"	INTEGER NOT NULL UNIQUE,
	"ID_session"	INTEGER NOT NULL UNIQUE,
	PRIMARY KEY("ID_session","ID_client"),
	FOREIGN KEY("ID_session") REFERENCES "Session"("ID_session") ON UPDATE CASCADE,
	FOREIGN KEY("ID_client") REFERENCES "Client"("ID_client") ON UPDATE CASCADE
);
INSERT INTO "Post" ("ID_post","Name_post") VALUES (1,'Администратор'),
 (2,'Менеджер'),
 (3,'Кассир');
INSERT INTO "Hall" ("ID_hall","Number_of_seats") VALUES (1,30),
 (2,30),
 (3,40),
 (4,40),
 (5,50);
INSERT INTO "Client" ("ID_client","Last_name_client","Name_client","Middle_name_client") VALUES (1,'Рыбин','Валентин','Георгиевич'),
 (2,'Петушков','Максим','Андреевич'),
 (3,'Плядухина','Анжелика','Павловна'),
 (4,'Ершова','Вера','Валерьевна'),
 (5,'Омарова','Дарья','Сергеевна'),
 (6,'Бойко','Дмитрий','Вадимович');
INSERT INTO "Movie" ("ID_movie","Name_movie","Rating") VALUES (1,'Джон Уик 4','7,6'),
 (2,'Стражи Галактики. Часть 3','8,2'),
 (3,'Оппенгеймер','8,5'),
 (4,'Переводчик','8,3'),
 (5,'Мой Хатико','7,9');
INSERT INTO "Session" ("ID_session","Cost","Number_of_client","Session_start_time","Session_end_time","ID_movie","ID_hall") VALUES (1,500,27,'06.11.2023, 17:40:00','06.11.2023, 20:00:00',1,3),
 (2,350,18,'07.11.2023, 14:00:00','07.11.2023, 16:30:00',2,1),
 (3,600,20,'07.11.2023, 18:00:00','07.11.2023, 20:10:00',3,2),
 (4,450,32,'08.11.2023, 12:30:00','08.11.2023, 15:00:00',4,4),
 (5,500,30,'09.11.2023, 16:20:00','09.11.2023, 19:00:00',5,5);
INSERT INTO "Employee" ("ID_employee","Last_name_employee","Name_employee","Middle_name_employee","Date_of_birth","Floor","ID_post") VALUES (1,'Соловьёв','Павел','Алексеевич','13.03.2000','Мужской',1),
 (2,'Гончарова','Лариса','Анатольевна','30.02.2003','Женский',2),
 (3,'Смирнова','Вероника','Александровна','04.05.1999','Женский',2),
 (4,'Сурко','Никита','Ларионович','15.01.1998','Мужской',3),
 (5,'Кручевич','Вадим','Ильич','05.05.2005','Мужской',3),
 (6,'Набатова','Инна','Николаевна','27.08.1987','Женский',3);
INSERT INTO "Cinema" ("ID_cinema","Address","Name_cinema") VALUES (1,'Г. Нея, ул. Любимова, д. 23','Дружба'),
 (2,'Г. Кострома, ул. Димитрова, д. 7','Пятёрка'),
 (3,'Г. Волгореченск, ул. Косматова, д. 5','Радость'),
 (4,'Г. Москва, ул. Ленина, д. 89','Гироскоп'),
 (5,'Г. Нижний Новгород, ул. Космонавтов, д. 10','Балтика');
INSERT INTO "Client_Session" ("ID_client","ID_session") VALUES (1,3),
 (2,2),
 (3,5),
 (4,1),
 (5,4);
COMMIT;
