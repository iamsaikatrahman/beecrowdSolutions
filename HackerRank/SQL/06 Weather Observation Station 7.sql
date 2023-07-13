Select distinct (CITY)
from STATION
where substr(CITY, Length(CITY), Length(CITY)) IN ('A', 'E', 'I', 'O', 'U');