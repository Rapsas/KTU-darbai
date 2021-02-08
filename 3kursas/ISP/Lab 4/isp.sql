-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 2020 m. Grd 20 d. 18:51
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `isp`
--

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `apklausa`
--

CREATE TABLE `apklausa` (
  `nuoroda` varchar(255) DEFAULT NULL,
  `fk_Irasas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `apklausa`
--

INSERT INTO `apklausa` (`nuoroda`, `fk_Irasas`) VALUES
('linkassadasdads', 1);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `atsiskaitymas`
--

CREATE TABLE `atsiskaitymas` (
  `data` date DEFAULT NULL,
  `tema` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `fk_Modulis` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `atsiskaitymas`
--

INSERT INTO `atsiskaitymas` (`data`, `tema`, `id`, `fk_Modulis`) VALUES
('2020-12-12', 'lastwork', 40, '1'),
('2020-12-05', 'bandymas', 41, '1'),
('2020-12-12', 'projektas', 42, '1'),
('2020-12-31', 'pdf', 43, '2'),
('2021-02-01', 'bandymas', 44, '2'),
('2021-03-02', 'programa', 45, '2');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `biblioteka`
--

CREATE TABLE `biblioteka` (
  `vieta` varchar(255) DEFAULT NULL,
  `pavadinimas` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `burelis`
--

CREATE TABLE `burelis` (
  `pavadinimas` varchar(255) DEFAULT NULL,
  `aprasas` varchar(255) DEFAULT NULL,
  `vieta` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `laikas` datetime DEFAULT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `burelis`
--

INSERT INTO `burelis` (`pavadinimas`, `aprasas`, `vieta`, `id`, `laikas`, `fk_Vartotojas`) VALUES
('asdasdasdasd', 'asdasdasasdsd', 'vt', 1, '2020-12-31 14:52:00', 'testas');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `dalyvauja`
--

CREATE TABLE `dalyvauja` (
  `fk_Modulis` varchar(255) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `dalyvauja`
--

INSERT INTO `dalyvauja` (`fk_Modulis`, `fk_Vartotojas`) VALUES
('1', '212'),
('1', '657'),
('1', '689'),
('1', '873'),
('1', 'stud'),
('2', 'stud');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `eina_i_konsultacija`
--

CREATE TABLE `eina_i_konsultacija` (
  `fk_Konsultacija` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `eina_i_konsultacija`
--

INSERT INTO `eina_i_konsultacija` (`fk_Konsultacija`, `fk_Vartotojas`) VALUES
(5, 'testas2');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `eina_i_mentorius`
--

CREATE TABLE `eina_i_mentorius` (
  `fk_Burelis` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `gauna_grupe`
--

CREATE TABLE `gauna_grupe` (
  `fk_Grupe` int(11) NOT NULL,
  `fk_Zinute` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `gauna_vartotojas`
--

CREATE TABLE `gauna_vartotojas` (
  `fk_Vartotojas` varchar(255) NOT NULL,
  `fk_Zinute` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `grupe`
--

CREATE TABLE `grupe` (
  `pavadinimas` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `imoka`
--

CREATE TABLE `imoka` (
  `suma` decimal(10,0) DEFAULT NULL,
  `saskaitos_numeris` varchar(255) DEFAULT NULL,
  `paskirtis` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `statusas` int(11) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `sumoketi_iki` date DEFAULT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `irasas`
--

CREATE TABLE `irasas` (
  `data` datetime DEFAULT NULL,
  `id` int(11) NOT NULL,
  `pavadinimas` varchar(255) DEFAULT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `irasas`
--

INSERT INTO `irasas` (`data`, `id`, `pavadinimas`, `fk_Vartotojas`) VALUES
('2020-12-01 21:01:56', 1, 'sasda', 'testas2'),
('2020-12-17 02:28:36', 2, 'skelbimas', 'testas');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `isakymas`
--

CREATE TABLE `isakymas` (
  `turinys` varchar(255) DEFAULT NULL,
  `parasas` varchar(255) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `fk_Irasas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `ivertis`
--

CREATE TABLE `ivertis` (
  `verte` int(11) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `fk_Atsiskaitymas` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `ivertis`
--

INSERT INTO `ivertis` (`verte`, `id`, `fk_Atsiskaitymas`, `fk_Vartotojas`) VALUES
(9, 26, 40, '212'),
(10, 27, 40, '657'),
(10, 28, 40, '689'),
(-1, 29, 40, '873'),
(8, 30, 40, 'stud'),
(-1, 31, 41, '212'),
(-1, 32, 41, '657'),
(-1, 33, 41, '689'),
(-1, 34, 41, '873'),
(9, 35, 41, 'stud'),
(-1, 37, 42, '212'),
(-1, 38, 42, '657'),
(-1, 39, 42, '689'),
(-1, 40, 42, '873'),
(7, 41, 42, 'stud'),
(8, 42, 43, 'stud'),
(5, 43, 44, 'stud'),
(6, 44, 45, 'stud'),
(3, 46, 41, '212');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `knyga`
--

CREATE TABLE `knyga` (
  `autorius` varchar(255) NOT NULL,
  `pavadinimas` varchar(255) NOT NULL,
  `leidimo_metai` date NOT NULL,
  `fk_Biblioteka` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `konsultacija`
--

CREATE TABLE `konsultacija` (
  `tema` varchar(255) DEFAULT NULL,
  `dalykas` varchar(255) DEFAULT NULL,
  `laikas` datetime DEFAULT NULL,
  `vieta` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `konsultacija`
--

INSERT INTO `konsultacija` (`tema`, `dalykas`, `laikas`, `vieta`, `id`, `fk_Vartotojas`) VALUES
('asdasdasd', 'asdasd', '2020-12-20 08:38:00', 'vieta', 5, 'testas');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `kontaktas`
--

CREATE TABLE `kontaktas` (
  `id_Kontaktas` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `lankomumas`
--

CREATE TABLE `lankomumas` (
  `buvo` varchar(1) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL,
  `fk_Paskaita` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `lankomumas`
--

INSERT INTO `lankomumas` (`buvo`, `id`, `fk_Vartotojas`, `fk_Paskaita`) VALUES
('+', 1, 'stud', 1),
('-', 3, '657', 5);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `modulis`
--

CREATE TABLE `modulis` (
  `pavadinimas` varchar(255) DEFAULT NULL,
  `kodas` varchar(255) NOT NULL,
  `reikalavimai` varchar(255) DEFAULT NULL,
  `aprasas` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `modulis`
--

INSERT INTO `modulis` (`pavadinimas`, `kodas`, `reikalavimai`, `aprasas`) VALUES
('sapien arcu', '1', 'consequat metus sapien ut nunc vestibulum ante ipsum primis', 'proin leo odio porttitor id'),
('quam', '10', 'convallis eget eleifend luctus ultricies eu nibh quisque id justo', 'amet eros suspendisse accumsan tortor quis turpis sed'),
('luctus', '2', 'luctus tincidunt nulla mollis molestie lorem quisque ut', 'amet cursus id turpis integer aliquet massa id lobortis'),
('diam cras', '3', 'morbi sem mauris laoreet ut rhoncus aliquet pulvinar', 'dui proin leo odio porttitor id consequat in consequat ut'),
('cras', '4', 'vestibulum ante ipsum primis in', 'nibh ligula nec sem duis aliquam convallis nunc proin at'),
('id ornare', '5', 'ultrices enim lorem ipsum dolor', 'proin at turpis a pede'),
('in hac', '6', 'in tempor turpis nec euismod', 'vitae mattis nibh ligula nec sem duis'),
('odio in', '7', 'habitasse platea dictumst morbi vestibulum velit id pretium iaculis', 'iaculis diam erat fermentum justo nec condimentum neque sapien placerat'),
('viverra pede', '8', 'ligula nec sem duis aliquam', 'primis in faucibus orci luctus et ultrices'),
('sociis', '9', 'justo pellentesque viverra pede ac diam cras pellentesque volutpat', 'natoque penatibus et magnis dis parturient montes nascetur');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `paskaita`
--

CREATE TABLE `paskaita` (
  `tema` varchar(255) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `id` int(11) NOT NULL,
  `fk_Modulis` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `paskaita`
--

INSERT INTO `paskaita` (`tema`, `data`, `id`, `fk_Modulis`) VALUES
('kazkas', '2020-12-02', 1, '1'),
('testas1', '2020-12-19', 2, '1'),
('testas2', '2020-12-22', 3, '1'),
('testas3', '2020-12-02', 4, '1'),
('testas4', '2020-12-29', 5, '2'),
('testas5', '2020-12-17', 6, '2'),
('testas6', '2020-12-26', 7, '2'),
('testas7', '2020-12-30', 8, '3'),
('testas8', '2020-12-14', 9, '3'),
('testas9', '2020-12-05', 10, '3');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `pranesimas`
--

CREATE TABLE `pranesimas` (
  `turinys` varchar(255) DEFAULT NULL,
  `fk_Irasas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `priklauso`
--

CREATE TABLE `priklauso` (
  `fk_Vartotojas` varchar(255) NOT NULL,
  `fk_Grupe` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `skelbimas`
--

CREATE TABLE `skelbimas` (
  `turinys` varchar(255) DEFAULT NULL,
  `fk_Irasas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `skelbimas`
--

INSERT INTO `skelbimas` (`turinys`, `fk_Irasas`) VALUES
('cia yra skelbimas', 2);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `sutartys`
--

CREATE TABLE `sutartys` (
  `data` datetime DEFAULT NULL,
  `numeris` varchar(255) DEFAULT NULL,
  `turinys` varchar(255) DEFAULT NULL,
  `fk_Irasas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `vartotojas`
--

CREATE TABLE `vartotojas` (
  `asmens_kodas` varchar(255) NOT NULL,
  `vardas` varchar(255) DEFAULT NULL,
  `pavarde` varchar(255) DEFAULT NULL,
  `slaptazodis` varchar(255) DEFAULT NULL,
  `vartotojo_tipas` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `vartotojas`
--

INSERT INTO `vartotojas` (`asmens_kodas`, `vardas`, `pavarde`, `slaptazodis`, `vartotojo_tipas`) VALUES
('212', 'Berthe', 'Maltster', 'neutral', 3),
('657', 'Jada', 'Abden', 'discrete', 3),
('689', 'Damian', 'Kynvin', 'Ameliorated', 3),
('873', 'Tersina', 'Cuffin', 'Monitored', 3),
('admin', 'admin', 'admin', 'admin', 1),
('dest', 'dest', 'dest', 'dest', 2),
('stud', 'stud', 'stud', 'stud', 3),
('testas', 'testas', 'testas', 'testas', 1),
('testas2', 'testas2', 'testas2', 'testas2', 1);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `vartotojo_tipas`
--

CREATE TABLE `vartotojo_tipas` (
  `id_Vartotojo_Tipas` int(11) NOT NULL,
  `name` char(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `vartotojo_tipas`
--

INSERT INTO `vartotojo_tipas` (`id_Vartotojo_Tipas`, `name`) VALUES
(1, 'Administratorius'),
(2, 'Destytojas'),
(3, 'Studentas');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `veda`
--

CREATE TABLE `veda` (
  `fk_Modulis` varchar(255) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sukurta duomenų kopija lentelei `veda`
--

INSERT INTO `veda` (`fk_Modulis`, `fk_Vartotojas`) VALUES
('1', 'dest'),
('2', 'dest');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `zinute`
--

CREATE TABLE `zinute` (
  `turinys` varchar(255) DEFAULT NULL,
  `data` datetime DEFAULT NULL,
  `priedas` varchar(255) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `fk_Vartotojas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `apklausa`
--
ALTER TABLE `apklausa`
  ADD PRIMARY KEY (`fk_Irasas`),
  ADD UNIQUE KEY `fk_Irasas` (`fk_Irasas`);

--
-- Indexes for table `atsiskaitymas`
--
ALTER TABLE `atsiskaitymas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Turi` (`fk_Modulis`);

--
-- Indexes for table `biblioteka`
--
ALTER TABLE `biblioteka`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `burelis`
--
ALTER TABLE `burelis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `VedaBurelis` (`fk_Vartotojas`);

--
-- Indexes for table `dalyvauja`
--
ALTER TABLE `dalyvauja`
  ADD PRIMARY KEY (`fk_Modulis`,`fk_Vartotojas`);

--
-- Indexes for table `eina_i_konsultacija`
--
ALTER TABLE `eina_i_konsultacija`
  ADD PRIMARY KEY (`fk_Konsultacija`,`fk_Vartotojas`);

--
-- Indexes for table `eina_i_mentorius`
--
ALTER TABLE `eina_i_mentorius`
  ADD PRIMARY KEY (`fk_Burelis`,`fk_Vartotojas`);

--
-- Indexes for table `gauna_grupe`
--
ALTER TABLE `gauna_grupe`
  ADD PRIMARY KEY (`fk_Grupe`,`fk_Zinute`);

--
-- Indexes for table `gauna_vartotojas`
--
ALTER TABLE `gauna_vartotojas`
  ADD PRIMARY KEY (`fk_Vartotojas`,`fk_Zinute`);

--
-- Indexes for table `grupe`
--
ALTER TABLE `grupe`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `imoka`
--
ALTER TABLE `imoka`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Atlieka` (`fk_Vartotojas`);

--
-- Indexes for table `irasas`
--
ALTER TABLE `irasas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Sukuria` (`fk_Vartotojas`);

--
-- Indexes for table `isakymas`
--
ALTER TABLE `isakymas`
  ADD PRIMARY KEY (`fk_Irasas`),
  ADD UNIQUE KEY `fk_Irasas` (`fk_Irasas`);

--
-- Indexes for table `ivertis`
--
ALTER TABLE `ivertis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `AtsiskaitymasIs` (`fk_Atsiskaitymas`),
  ADD KEY `Gaves` (`fk_Vartotojas`);

--
-- Indexes for table `knyga`
--
ALTER TABLE `knyga`
  ADD PRIMARY KEY (`leidimo_metai`,`autorius`,`pavadinimas`),
  ADD KEY `TuriKnyga` (`fk_Biblioteka`),
  ADD KEY `Pasiema` (`fk_Vartotojas`);

--
-- Indexes for table `konsultacija`
--
ALTER TABLE `konsultacija`
  ADD PRIMARY KEY (`id`),
  ADD KEY `VedaKonsultacija` (`fk_Vartotojas`);

--
-- Indexes for table `kontaktas`
--
ALTER TABLE `kontaktas`
  ADD PRIMARY KEY (`id_Kontaktas`),
  ADD UNIQUE KEY `fk_Vartotojas` (`fk_Vartotojas`);

--
-- Indexes for table `lankomumas`
--
ALTER TABLE `lankomumas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Sekamas` (`fk_Vartotojas`),
  ADD KEY `Seka` (`fk_Paskaita`);

--
-- Indexes for table `modulis`
--
ALTER TABLE `modulis`
  ADD PRIMARY KEY (`kodas`);

--
-- Indexes for table `paskaita`
--
ALTER TABLE `paskaita`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Sudaro` (`fk_Modulis`);

--
-- Indexes for table `pranesimas`
--
ALTER TABLE `pranesimas`
  ADD PRIMARY KEY (`fk_Irasas`),
  ADD UNIQUE KEY `fk_Irasas` (`fk_Irasas`);

--
-- Indexes for table `priklauso`
--
ALTER TABLE `priklauso`
  ADD PRIMARY KEY (`fk_Vartotojas`,`fk_Grupe`);

--
-- Indexes for table `skelbimas`
--
ALTER TABLE `skelbimas`
  ADD PRIMARY KEY (`fk_Irasas`),
  ADD UNIQUE KEY `fk_Irasas` (`fk_Irasas`);

--
-- Indexes for table `sutartys`
--
ALTER TABLE `sutartys`
  ADD PRIMARY KEY (`fk_Irasas`),
  ADD UNIQUE KEY `fk_Irasas` (`fk_Irasas`);

--
-- Indexes for table `vartotojas`
--
ALTER TABLE `vartotojas`
  ADD PRIMARY KEY (`asmens_kodas`),
  ADD KEY `vartotojo_tipas` (`vartotojo_tipas`);

--
-- Indexes for table `vartotojo_tipas`
--
ALTER TABLE `vartotojo_tipas`
  ADD PRIMARY KEY (`id_Vartotojo_Tipas`);

--
-- Indexes for table `veda`
--
ALTER TABLE `veda`
  ADD PRIMARY KEY (`fk_Modulis`,`fk_Vartotojas`);

--
-- Indexes for table `zinute`
--
ALTER TABLE `zinute`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Siuncia` (`fk_Vartotojas`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `atsiskaitymas`
--
ALTER TABLE `atsiskaitymas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `biblioteka`
--
ALTER TABLE `biblioteka`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `burelis`
--
ALTER TABLE `burelis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `grupe`
--
ALTER TABLE `grupe`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `imoka`
--
ALTER TABLE `imoka`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `irasas`
--
ALTER TABLE `irasas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `ivertis`
--
ALTER TABLE `ivertis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `konsultacija`
--
ALTER TABLE `konsultacija`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `lankomumas`
--
ALTER TABLE `lankomumas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `paskaita`
--
ALTER TABLE `paskaita`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `zinute`
--
ALTER TABLE `zinute`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Apribojimai eksportuotom lentelėm
--

--
-- Apribojimai lentelei `apklausa`
--
ALTER TABLE `apklausa`
  ADD CONSTRAINT `YraApklausa` FOREIGN KEY (`fk_Irasas`) REFERENCES `irasas` (`id`);

--
-- Apribojimai lentelei `atsiskaitymas`
--
ALTER TABLE `atsiskaitymas`
  ADD CONSTRAINT `Turi` FOREIGN KEY (`fk_Modulis`) REFERENCES `modulis` (`kodas`);

--
-- Apribojimai lentelei `burelis`
--
ALTER TABLE `burelis`
  ADD CONSTRAINT `VedaBurelis` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `dalyvauja`
--
ALTER TABLE `dalyvauja`
  ADD CONSTRAINT `Dalyvauja` FOREIGN KEY (`fk_Modulis`) REFERENCES `modulis` (`kodas`);

--
-- Apribojimai lentelei `eina_i_konsultacija`
--
ALTER TABLE `eina_i_konsultacija`
  ADD CONSTRAINT `Eina_i_konsultacija_c` FOREIGN KEY (`fk_Konsultacija`) REFERENCES `konsultacija` (`id`);

--
-- Apribojimai lentelei `eina_i_mentorius`
--
ALTER TABLE `eina_i_mentorius`
  ADD CONSTRAINT `Eina_i_mentorius_c` FOREIGN KEY (`fk_Burelis`) REFERENCES `burelis` (`id`);

--
-- Apribojimai lentelei `gauna_grupe`
--
ALTER TABLE `gauna_grupe`
  ADD CONSTRAINT `Gauna_grupe_c` FOREIGN KEY (`fk_Grupe`) REFERENCES `grupe` (`id`);

--
-- Apribojimai lentelei `gauna_vartotojas`
--
ALTER TABLE `gauna_vartotojas`
  ADD CONSTRAINT `Gauna_vartotojas_c` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `imoka`
--
ALTER TABLE `imoka`
  ADD CONSTRAINT `Atlieka` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `irasas`
--
ALTER TABLE `irasas`
  ADD CONSTRAINT `Sukuria` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `isakymas`
--
ALTER TABLE `isakymas`
  ADD CONSTRAINT `YraIsakymas` FOREIGN KEY (`fk_Irasas`) REFERENCES `irasas` (`id`);

--
-- Apribojimai lentelei `ivertis`
--
ALTER TABLE `ivertis`
  ADD CONSTRAINT `AtsiskaitymasIs` FOREIGN KEY (`fk_Atsiskaitymas`) REFERENCES `atsiskaitymas` (`id`),
  ADD CONSTRAINT `Gaves` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `knyga`
--
ALTER TABLE `knyga`
  ADD CONSTRAINT `Pasiema` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`),
  ADD CONSTRAINT `TuriKnyga` FOREIGN KEY (`fk_Biblioteka`) REFERENCES `biblioteka` (`id`);

--
-- Apribojimai lentelei `konsultacija`
--
ALTER TABLE `konsultacija`
  ADD CONSTRAINT `VedaKonsultacija` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `kontaktas`
--
ALTER TABLE `kontaktas`
  ADD CONSTRAINT `Yra` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `lankomumas`
--
ALTER TABLE `lankomumas`
  ADD CONSTRAINT `Seka` FOREIGN KEY (`fk_Paskaita`) REFERENCES `paskaita` (`id`),
  ADD CONSTRAINT `Sekamas` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `paskaita`
--
ALTER TABLE `paskaita`
  ADD CONSTRAINT `Sudaro` FOREIGN KEY (`fk_Modulis`) REFERENCES `modulis` (`kodas`);

--
-- Apribojimai lentelei `pranesimas`
--
ALTER TABLE `pranesimas`
  ADD CONSTRAINT `YraPranesimas` FOREIGN KEY (`fk_Irasas`) REFERENCES `irasas` (`id`);

--
-- Apribojimai lentelei `priklauso`
--
ALTER TABLE `priklauso`
  ADD CONSTRAINT `Priklauso` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);

--
-- Apribojimai lentelei `skelbimas`
--
ALTER TABLE `skelbimas`
  ADD CONSTRAINT `YraSkelbimas` FOREIGN KEY (`fk_Irasas`) REFERENCES `irasas` (`id`);

--
-- Apribojimai lentelei `sutartys`
--
ALTER TABLE `sutartys`
  ADD CONSTRAINT `YraSutartis` FOREIGN KEY (`fk_Irasas`) REFERENCES `irasas` (`id`);

--
-- Apribojimai lentelei `vartotojas`
--
ALTER TABLE `vartotojas`
  ADD CONSTRAINT `vartotojas_ibfk_1` FOREIGN KEY (`vartotojo_tipas`) REFERENCES `vartotojo_tipas` (`id_Vartotojo_Tipas`);

--
-- Apribojimai lentelei `veda`
--
ALTER TABLE `veda`
  ADD CONSTRAINT `VedaTable` FOREIGN KEY (`fk_Modulis`) REFERENCES `modulis` (`kodas`);

--
-- Apribojimai lentelei `zinute`
--
ALTER TABLE `zinute`
  ADD CONSTRAINT `Siuncia` FOREIGN KEY (`fk_Vartotojas`) REFERENCES `vartotojas` (`asmens_kodas`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
