-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 2020 m. Grd 22 d. 19:39
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
-- Database: `lab2`
--

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `asociacija`
--

CREATE TABLE `asociacija` (
  `imones_kodas` int(11) NOT NULL,
  `pavadinimas` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Sukurta duomenų kopija lentelei `asociacija`
--

INSERT INTO `asociacija` (`imones_kodas`, `pavadinimas`) VALUES
(1, 'Lietuvos taure'),
(2, 'Estijos taure'),
(5, 'Svedijos taureasd');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `dalyvauja`
--

CREATE TABLE `dalyvauja` (
  `fk_Sportininkasasmens_kodas` int(11) NOT NULL,
  `fk_Varzybospavadinimas` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Sukurta duomenų kopija lentelei `dalyvauja`
--

INSERT INTO `dalyvauja` (`fk_Sportininkasasmens_kodas`, `fk_Varzybospavadinimas`) VALUES
(9, 'Belekas'),
(3, 'Dabjam'),
(3, 'Camido'),
(9, 'Camido'),
(9, 'Dabjam'),
(10, 'Dabjam'),
(10, 'Camido'),
(11, 'Dabjam'),
(11, 'Camido'),
(24, 'Belekas'),
(24, 'Camido'),
(3, 'Beleka'),
(5, 'Beleka'),
(8, 'Beleka'),
(27, 'Dabjam');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `failed_jobs`
--

CREATE TABLE `failed_jobs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `uuid` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `connection` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `queue` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `payload` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `exception` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `failed_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `gynimas`
--

CREATE TABLE `gynimas` (
  `gynimas` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `kontraktas`
--

CREATE TABLE `kontraktas` (
  `kontrakto_numeris` int(11) NOT NULL,
  `galiojimo_pradzia` date NOT NULL,
  `galiojimo_pabaiga` date NOT NULL,
  `skiriami_pinigai` double NOT NULL,
  `fk_Sportininkasasmens_kodas` int(11) NOT NULL,
  `fk_Sponsoriusimones_kodas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Sukurta duomenų kopija lentelei `kontraktas`
--

INSERT INTO `kontraktas` (`kontrakto_numeris`, `galiojimo_pradzia`, `galiojimo_pabaiga`, `skiriami_pinigai`, `fk_Sportininkasasmens_kodas`, `fk_Sponsoriusimones_kodas`) VALUES
(3, '2016-07-01', '2024-07-18', 420636.74, 3, 5),
(5, '2018-04-29', '2021-05-30', 840716.18, 5, 2),
(8, '2018-09-14', '2022-09-03', 704181.83, 8, 4),
(9, '2017-12-24', '2022-01-28', 787373.18, 9, 3),
(10, '2018-01-07', '2021-06-04', 679445.87, 10, 2),
(11, '2016-11-02', '2020-07-01', 644311.16, 11, 4),
(13, '2017-06-10', '2025-07-13', 358560.75, 13, 2),
(14, '2018-01-28', '2024-05-12', 826733.57, 14, 4),
(16, '2018-02-08', '2021-07-07', 485945.44, 16, 4),
(17, '2018-01-06', '2023-10-10', 244087.17, 17, 2),
(19, '2017-04-12', '2017-04-12', 50, 3, 1);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Sukurta duomenų kopija lentelei `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '2014_10_12_000000_create_users_table', 1),
(2, '2014_10_12_100000_create_password_resets_table', 1),
(3, '2019_08_19_000000_create_failed_jobs_table', 1),
(4, '2020_11_24_002006_create_sponsorius_table', 1),
(5, '2020_11_24_090811_create_asociacija_table', 1),
(6, '2020_11_24_095106_create_sportininkas_table', 1),
(7, '2020_11_24_100108_create_kontraktas_table', 1),
(8, '2020_11_24_101224_create_varzybos_table', 1),
(9, '2020_11_24_101517_create_dalyvauja_table', 1),
(10, '2020_11_24_174623_create_gynimas_table', 1);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `sponsorius`
--

CREATE TABLE `sponsorius` (
  `imones_kodas` int(11) NOT NULL,
  `pavadinimas` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Sukurta duomenų kopija lentelei `sponsorius`
--

INSERT INTO `sponsorius` (`imones_kodas`, `pavadinimas`) VALUES
(1, 'Bavarija'),
(2, 'Gandrelis'),
(3, 'UAB Rapsiukas'),
(4, 'BeamerisJega'),
(5, 'VyraiNestabdom'),
(6, 'Karkasai yra jega');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `sportininkas`
--

CREATE TABLE `sportininkas` (
  `asmens_kodas` int(11) NOT NULL,
  `vardas` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pavarde` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `svoris` double NOT NULL,
  `lytis` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `lenktyninis_numeris` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tautybe` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `fk_Asociacijaimones_kodas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Sukurta duomenų kopija lentelei `sportininkas`
--

INSERT INTO `sportininkas` (`asmens_kodas`, `vardas`, `pavarde`, `svoris`, `lytis`, `lenktyninis_numeris`, `tautybe`, `fk_Asociacijaimones_kodas`) VALUES
(3, 'Gérald', 'Tunnicliff', 63.19, 'F', '838', 'France', 1),
(5, 'Estève', 'Nurse', 75.53, 'M', '247', 'Russia', 1),
(8, 'Ruì', 'Westmarland', 67.28, 'F', '574', 'South Korea', 2),
(9, 'Adèle', 'Parris', 77.75, 'M', '691', 'Lithuania', 2),
(10, 'Anaïs', 'Gregorowicz', 88.82, 'M', '475', 'France', 2),
(11, 'Kù', 'Ovanesian', 77.72, 'M', '955', 'Russia', 2),
(13, 'Marlène', 'Hackin', 65.12, 'M', '997', 'Belarus', 5),
(14, 'Cécile', 'Hendricks', 81.26, 'M', '813', 'China', 1),
(16, 'Mahélie', 'Murrhardt', 63.4, 'M', '308', 'Venezuela', 5),
(17, 'Lucrèce', 'Goodband', 89.35, 'F', '936', 'Philippines', 1),
(19, 'Anaé', 'Dei', 96.39, 'F', '907', 'Brazil', 1),
(21, 'TEST', 'asd', 69, 'VYRAS', '4240', 'TEST', 2),
(22, 'TEST', 'asd', 123, 'VYRAS', '4240', 'TEST', 2),
(23, 'TEST', 'asd', 123, 'VYRAS', '69', 'LIETUVA', 5),
(24, 'TEST', 'asd', 123, 'VYRAS', '69', 'LIETUVA', 5),
(27, 'TEST', 'asd', 69, 'TEST', '69', 'TEST', 2);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `remember_token` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `varzybos`
--

CREATE TABLE `varzybos` (
  `pavadinimas` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `salis` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `disciplina` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vandens_telkinys` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dalyviu_skaicius` int(11) NOT NULL,
  `fk_Asociacijaimones_kodas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Sukurta duomenų kopija lentelei `varzybos`
--

INSERT INTO `varzybos` (`pavadinimas`, `salis`, `disciplina`, `vandens_telkinys`, `dalyviu_skaicius`, `fk_Asociacijaimones_kodas`) VALUES
('Beleka', 'Germany', 'Rank', 'droplet', 2, 2),
('Belekas', 'GermanyThird', 'Rank', 'droplet', 2, 2),
('Camido', 'Nigeria', 'Bitchip', 'oval', 29, 1),
('Dabjam', 'Finland', 'Redhold', 'oval', 46, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asociacija`
--
ALTER TABLE `asociacija`
  ADD PRIMARY KEY (`imones_kodas`);

--
-- Indexes for table `dalyvauja`
--
ALTER TABLE `dalyvauja`
  ADD KEY `dalyvauja_fk_sportininkasasmens_kodas_foreign` (`fk_Sportininkasasmens_kodas`),
  ADD KEY `dalyvauja_fk_varzybospavadinimas_foreign` (`fk_Varzybospavadinimas`);

--
-- Indexes for table `failed_jobs`
--
ALTER TABLE `failed_jobs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `failed_jobs_uuid_unique` (`uuid`);

--
-- Indexes for table `kontraktas`
--
ALTER TABLE `kontraktas`
  ADD PRIMARY KEY (`kontrakto_numeris`),
  ADD KEY `kontraktas_fk_sportininkasasmens_kodas_foreign` (`fk_Sportininkasasmens_kodas`),
  ADD KEY `kontraktas_fk_sponsoriusimones_kodas_foreign` (`fk_Sponsoriusimones_kodas`);

--
-- Indexes for table `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Indexes for table `sponsorius`
--
ALTER TABLE `sponsorius`
  ADD PRIMARY KEY (`imones_kodas`);

--
-- Indexes for table `sportininkas`
--
ALTER TABLE `sportininkas`
  ADD PRIMARY KEY (`asmens_kodas`),
  ADD KEY `sportininkas_fk_asociacijaimones_kodas_foreign` (`fk_Asociacijaimones_kodas`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- Indexes for table `varzybos`
--
ALTER TABLE `varzybos`
  ADD PRIMARY KEY (`pavadinimas`),
  ADD KEY `varzybos_fk_asociacijaimones_kodas_foreign` (`fk_Asociacijaimones_kodas`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asociacija`
--
ALTER TABLE `asociacija`
  MODIFY `imones_kodas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `failed_jobs`
--
ALTER TABLE `failed_jobs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kontraktas`
--
ALTER TABLE `kontraktas`
  MODIFY `kontrakto_numeris` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `sponsorius`
--
ALTER TABLE `sponsorius`
  MODIFY `imones_kodas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `sportininkas`
--
ALTER TABLE `sportininkas`
  MODIFY `asmens_kodas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Apribojimai eksportuotom lentelėm
--

--
-- Apribojimai lentelei `dalyvauja`
--
ALTER TABLE `dalyvauja`
  ADD CONSTRAINT `dalyvauja_fk_sportininkasasmens_kodas_foreign` FOREIGN KEY (`fk_Sportininkasasmens_kodas`) REFERENCES `sportininkas` (`asmens_kodas`) ON DELETE CASCADE,
  ADD CONSTRAINT `dalyvauja_fk_varzybospavadinimas_foreign` FOREIGN KEY (`fk_Varzybospavadinimas`) REFERENCES `varzybos` (`pavadinimas`) ON DELETE CASCADE;

--
-- Apribojimai lentelei `kontraktas`
--
ALTER TABLE `kontraktas`
  ADD CONSTRAINT `kontraktas_fk_sponsoriusimones_kodas_foreign` FOREIGN KEY (`fk_Sponsoriusimones_kodas`) REFERENCES `sponsorius` (`imones_kodas`) ON DELETE CASCADE,
  ADD CONSTRAINT `kontraktas_fk_sportininkasasmens_kodas_foreign` FOREIGN KEY (`fk_Sportininkasasmens_kodas`) REFERENCES `sportininkas` (`asmens_kodas`) ON DELETE CASCADE;

--
-- Apribojimai lentelei `sportininkas`
--
ALTER TABLE `sportininkas`
  ADD CONSTRAINT `sportininkas_fk_asociacijaimones_kodas_foreign` FOREIGN KEY (`fk_Asociacijaimones_kodas`) REFERENCES `asociacija` (`imones_kodas`) ON DELETE CASCADE;

--
-- Apribojimai lentelei `varzybos`
--
ALTER TABLE `varzybos`
  ADD CONSTRAINT `varzybos_fk_asociacijaimones_kodas_foreign` FOREIGN KEY (`fk_Asociacijaimones_kodas`) REFERENCES `asociacija` (`imones_kodas`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
