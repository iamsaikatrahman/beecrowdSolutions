select distinct (CITY)
from STATION
where not substr(CITY, 1, 1) in ('A', 'E', 'I', 'O', 'U');