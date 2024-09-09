-- 12. feladat
create database mozaik
default charset utf8
collate utf8_hungarian_ci;

-- 14. feladat
select count(id) as 'nagyrendezvények száma'
from rendezveny
where letszam >= 100;

-- 15. feladat
select idopont, napokszama, letszam
from rendezveny
inner join helyszin on rendezveny.helyszinId = helyszin.id
where helyszin.nev = 'Szeged';

-- 16. feladat
update kapcsolat
set cegnev = 'BugFix IT'
where nev = 'Nagy Béla';

-- 17. feladat
select tipus.nev as 'típus', avg(rendezveny.letszam) as átlaglétszám
from rendezveny
inner join tipus on rendezveny.tipusId = tipus.id
group by tipus.nev
order by avg(rendezveny.letszam) desc
limit 2;

-- 18. feladat
select helyszin.nev from helyszin
where helyszin.id not in (select helyszinId from rendezveny);

-- 19. feladat
select kapcsolat.nev,
        kapcsolat.email,
        rendezveny.napokszama * 20000 + rendezveny.letszam * 1000 as 'szervezési díj'
from rendezveny
inner join tipus on rendezveny.tipusId = tipus.id
inner join kapcsolat on rendezveny.kapcsolatId = kapcsolat.id
where tipus.nev = 'tréning';