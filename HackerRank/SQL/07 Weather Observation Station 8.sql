Select distinct (CITY)
from STATION
where substr(CITY, 1, 1) IN ('A', 'E', 'I', 'O', 'U') and substr(CITY, Length(CITY), Length(CITY)) IN ('A', 'E', 'I', 'O', 'U');