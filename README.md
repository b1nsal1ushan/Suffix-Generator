# Suffix-Generator
A simple function that generates a new suffix base on `lastSuffix` parameter.
## Parameter Information:
1) lastSuffix parameter can be like "A", "B", "C", "D" ... "Z" or "A1", "B1", ..... "Z1", etc.
2) Means lastSuffix will either be a single character or it will have number after an alphabet
## What it returns:
1) if lastSuffix is null then simply return "A"
2) if lastSuffix is a single character e.g. "A", "B", "C", etc. then return the next character for example, if lastSuffix is "A", then return "B".
3) if lastSuffix is "Z" then return the "A1"
4) if lastSuffix is "A1" then return "B1"
5) if lastSuffix is "Z1" then return "A2"
6) if lastSuffix is "A2" then return "B2"
and so on.
