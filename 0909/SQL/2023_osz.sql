-- 10. feladat

create database hamburger
default charset utf8
collate utf8_hungarian_ci;

-- 12. feladat
select nev from menutetel where ar = 2500;

-- 13. feladat
update menutetel 
set ar = 2300
where nev = 'Grill pizza 32cm';

-- 14. feladat
select f.nev as vendeg_nev, sum(r.felhasznaloId) as rendeles_db
from felhasznalo as f
inner join rendeles as r on r.felhasznaloId = f.id
group by r.felhasznaloId
order by rendeles_db desc
limit 9;

-- 15. feladat
insert into menutetel(nev, ar, etelkatId)
values ('Boston Tészta', 2200, 3);

-- 16. feladat
select r.id as rendeles_azon,
        re.id as rendeleselem_azon,
        m.nev as menutetel_neve
from rendeles as r
inner join felhasznalo as f on r.felhasznaloId = f.id
inner join rendeleselem re on r.id = re.rendelesId
inner join menutetel m on re.menutetelId = m.id
where f.nev = 'Balázs Flóra';