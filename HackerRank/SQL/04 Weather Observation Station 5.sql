//Weather Observation Station 5
Select CITY, Length(CITY) From STATION Order by Length(CITY) asc, CITY Limit 1;
Select CITY, Length(CITY) From STATION Order by Length(CITY) desc, CITY Limit 1;