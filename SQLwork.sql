 CREATE TABLE Weather(
    id INT PRIMARY KEY,
	recordDate DATE,
    temperature int
 )

 INSERT INTO Weather VALUES(1,'2015-01-01',10)
 INSERT INTO Weather VALUES(2,'2015-01-02',25)
 INSERT INTO Weather VALUES(3,'2015-01-03',20)
 INSERT INTO Weather VALUES(4,'2015-01-04',30)
 SELECT * FROM Weather w


SELECT x.id FROM Weather x JOIN Weather y 
ON DATEDIFF(DAY, y.recordDate, x.recordDate) = 1 AND x.temperature > y.temperature;
