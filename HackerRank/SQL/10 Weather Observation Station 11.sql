select distinct (CITY)
from STATION
where not substr(CITY, 1 ,1) in ('A','E','I','O','U') OR not substr(CITY, length(CITY), length(CITY)) in ('A','E','I','O','U');