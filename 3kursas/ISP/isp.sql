
INSERT INTO `vartotojas` (`asmens_kodas`, `vardas`, `pavarde`, `slaptazodis`, `vartotojo_tipas`) VALUES
('admin', 'admin', 'admin', 'admin', 1),
('testas', 'testas', 'testas', 'testas', 1),
('stud', 'stud', 'stud', 'stud', 3),
('dest', 'dest', 'dest', 'dest', 2),
('testas2', 'testas2', 'testas2', 'testas2', 1);

INSERT INTO `burelis` (`pavadinimas`, `aprasas`, `vieta`, `id`, `laikas`, `fk_Vartotojas`) VALUES
('asdasdasdasd', 'asdasdasasdsd', 'vt', 1, '2020-12-31 14:52:00', 'testas');

INSERT INTO `konsultacija` (`tema`, `dalykas`, `laikas`, `vieta`, `id`, `fk_Vartotojas`) VALUES
('asdasdasd', 'asdasd', '2020-12-20 08:38:00', 'vieta', 5, 'testas');

INSERT INTO `eina_i_konsultacija` (`fk_Konsultacija`, `fk_Vartotojas`) VALUES
(5, 'testas2');
INSERT INTO `irasas` (`data`, `id`, `pavadinimas`, `fk_Vartotojas`) VALUES
('2020-12-01 21:01:56', 1, 'sasda', 'testas2');
INSERT INTO `apklausa` (`nuoroda`, `fk_Irasas`) VALUES
('linkassadasdads', 1);











