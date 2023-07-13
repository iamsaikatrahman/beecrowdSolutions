Select Distinct (CITY) 
from STATION
where Substr(CITY, 1, 1) in ('A', 'E', 'I','O','U');