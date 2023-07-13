select distinct (CITY)
from STATION
where not substr(CITY, length(CITY), length(CITY)) in ('A', 'E', 'I', 'O', 'U');