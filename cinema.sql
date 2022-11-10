-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Gazdă: 127.0.0.1
-- Timp de generare: mai 09, 2021 la 12:09 AM
-- Versiune server: 10.4.17-MariaDB
-- Versiune PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Bază de date: `cinema`
--

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `conturi`
--

CREATE TABLE `conturi` (
  `idU` int(11) NOT NULL,
  `Nume` mediumtext NOT NULL,
  `Functie` mediumtext NOT NULL,
  `Parola` mediumtext NOT NULL,
  `NumeU` mediumtext NOT NULL,
  `Telefon` mediumtext NOT NULL,
  `Scor` int(11) NOT NULL,
  `Recompensa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Eliminarea datelor din tabel `conturi`
--

INSERT INTO `conturi` (`idU`, `Nume`, `Functie`, `Parola`, `NumeU`, `Telefon`, `Scor`, `Recompensa`) VALUES
(1, 'Tarta Antonia', 'Administrator', 'AdmA', 'AdmA', '0764199093', 16, 0),
(2, 'Pop Vlad', 'Administrator', 'AdmV', 'AdmV', '0765858432', 1, 0),
(4, 'Ionescu Maria', 'Vanzator', 'VzM', 'VzM', '0743564265', 3, 0),
(5, 'Adam Alin', 'Client', 'alinn6', 'Alin', '0785556746', 3, 0),
(6, 'Ionescu Dan', 'Client', 'DaN25', 'Dan25', '0734563546', 4, 0);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `difuzari`
--

CREATE TABLE `difuzari` (
  `idD` int(11) NOT NULL,
  `idF` int(11) NOT NULL,
  `Data` datetime NOT NULL,
  `OraFinal` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Eliminarea datelor din tabel `difuzari`
--

INSERT INTO `difuzari` (`idD`, `idF`, `Data`, `OraFinal`) VALUES
(1, 1, '2021-05-20 14:00:00', '15:32:00'),
(2, 1, '2021-05-21 12:00:00', '13:32:00'),
(3, 2, '2021-05-23 15:30:00', '17:15:00'),
(8, 2, '2021-05-29 18:45:00', '20:30:00');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `filme`
--

CREATE TABLE `filme` (
  `idF` int(11) NOT NULL,
  `Denumire` mediumtext NOT NULL,
  `Gen` mediumtext NOT NULL,
  `Pret` int(11) NOT NULL,
  `An` int(11) NOT NULL,
  `Format` mediumtext NOT NULL,
  `Durata` int(11) NOT NULL,
  `Distributie` mediumtext NOT NULL,
  `Descriere` mediumtext NOT NULL,
  `Imagine` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Eliminarea datelor din tabel `filme`
--

INSERT INTO `filme` (`idF`, `Denumire`, `Gen`, `Pret`, `An`, `Format`, `Durata`, `Distributie`, `Descriere`, `Imagine`) VALUES
(1, 'The Knight Before Christmas', 'Crăciun', 22, 2019, '3D', 92, 'Vanessa Hudgens(Brooke), Josh Whitehouse(Sir Cole);', 'Un cavaler medieval englez ajunge în mod inexplicabil în timpurile noastre, în perioada sărbătorilor de iarnă, și se îndrăgostește de o profesoară de liceu care nu mai spera să fie vreodată fericită într-o relație.', 'filme/kbc1.jpg*filme/kbc2.jpg*filme/kbc3.jpg*filme/kbc4.jpg'),
(2, 'The Kissing Booth', 'Romantic', 20, 2018, '2D', 105, 'Jacob Elordi(Noah), Joey King(Elle), Joel Courtney(Lee);', 'Atunci când Elle Evans, o adolescentă frumoasă care nu a avut parte de experiența primului sărut, decide să participe la cabina cu săruturi din cadrul Carnavalului de Primăvară al liceului, ea îl sărută pe Noah, dragostea ei secretă. Scânteile zboară, dar există o mică problemă: Noah se întâmplă să fie fratele celui mai bun prieten al ei, Lee, și acest lucru este total în afara limitelor stabilite, conform pactului lor de prietenie. Elle dezvoltă o poveste de dragoste secretă cu Noah, o poveste care îi testează prietenia cu Lee. Viața lui Elle este dată peste cap atunci când își dă seama că în cele din urmă trebuie să facă o alegere: să urmeze regulile sau să-și urmeze inima.', 'filme/kb1.jpg*filme/kb2.jpg*filme/kb3.jpg');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `locuri`
--

CREATE TABLE `locuri` (
  `idl` int(11) NOT NULL,
  `idd` int(11) NOT NULL,
  `Loc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Eliminarea datelor din tabel `locuri`
--

INSERT INTO `locuri` (`idl`, `idd`, `Loc`) VALUES
(1, 2, 45),
(2, 2, 25),
(3, 1, 7),
(4, 3, 34),
(5, 3, 35),
(6, 3, 33),
(7, 1, 35),
(8, 3, 1),
(9, 2, 12),
(10, 1, 47),
(11, 1, 48),
(12, 1, 49),
(13, 3, 20),
(14, 3, 57),
(15, 3, 58);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `rezervari`
--

CREATE TABLE `rezervari` (
  `idr` int(11) NOT NULL,
  `idu` int(11) NOT NULL,
  `idd` int(11) NOT NULL,
  `Loc` mediumtext NOT NULL,
  `Total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Eliminarea datelor din tabel `rezervari`
--

INSERT INTO `rezervari` (`idr`, `idu`, `idd`, `Loc`, `Total`) VALUES
(1, 1, 3, '57,58', 40);

--
-- Indexuri pentru tabele eliminate
--

--
-- Indexuri pentru tabele `conturi`
--
ALTER TABLE `conturi`
  ADD PRIMARY KEY (`idU`);

--
-- Indexuri pentru tabele `difuzari`
--
ALTER TABLE `difuzari`
  ADD PRIMARY KEY (`idD`),
  ADD KEY `cod1` (`idF`);

--
-- Indexuri pentru tabele `filme`
--
ALTER TABLE `filme`
  ADD PRIMARY KEY (`idF`);

--
-- Indexuri pentru tabele `locuri`
--
ALTER TABLE `locuri`
  ADD PRIMARY KEY (`idl`),
  ADD KEY `idd` (`idd`);

--
-- Indexuri pentru tabele `rezervari`
--
ALTER TABLE `rezervari`
  ADD PRIMARY KEY (`idr`),
  ADD KEY `idc` (`idu`),
  ADD KEY `idd` (`idd`);

--
-- AUTO_INCREMENT pentru tabele eliminate
--

--
-- AUTO_INCREMENT pentru tabele `conturi`
--
ALTER TABLE `conturi`
  MODIFY `idU` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pentru tabele `difuzari`
--
ALTER TABLE `difuzari`
  MODIFY `idD` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pentru tabele `filme`
--
ALTER TABLE `filme`
  MODIFY `idF` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT pentru tabele `locuri`
--
ALTER TABLE `locuri`
  MODIFY `idl` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT pentru tabele `rezervari`
--
ALTER TABLE `rezervari`
  MODIFY `idr` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
