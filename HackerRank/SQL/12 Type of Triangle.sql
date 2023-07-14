select 
case
    when A + B <= C OR A + C <= B OR B + C <= A
        then "Not A Triangle"
    when A = B AND A = C AND B = C
        then "Equilateral"
    when A = B OR A = C OR B = C 
        then "Isosceles"
    else   "Scalene" 
end
from TRIANGLES