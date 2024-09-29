-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-09-2024 a las 00:39:19
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `4pro`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos_liceo`
--

CREATE TABLE `datos_liceo` (
  `Matricula` int(10) NOT NULL,
  `Rut` varchar(10) NOT NULL,
  `Nombres` varchar(40) NOT NULL,
  `ApellidoP` varchar(40) NOT NULL,
  `ApellidoM` varchar(40) NOT NULL,
  `FNacimiento` varchar(15) NOT NULL,
  `Direccion` text NOT NULL,
  `Email` varchar(40) NOT NULL,
  `NCelular` varchar(13) NOT NULL,
  `RutA` varchar(10) NOT NULL,
  `NombresA` varchar(40) NOT NULL,
  `ApellidoPA` varchar(40) NOT NULL,
  `ApellidoMA` varchar(40) NOT NULL,
  `NCelularA` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos_personales`
--

CREATE TABLE `datos_personales` (
  `rut` varchar(10) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `user` varchar(10) NOT NULL,
  `pass` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`user`, `pass`) VALUES
('admin', 'admin'),
('user', 'user');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `datos_liceo`
--
ALTER TABLE `datos_liceo`
  ADD PRIMARY KEY (`Matricula`);

--
-- Indices de la tabla `datos_personales`
--
ALTER TABLE `datos_personales`
  ADD PRIMARY KEY (`rut`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`user`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
