-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-02-2022 a las 20:59:44
-- Versión del servidor: 10.4.22-MariaDB
-- Versión de PHP: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_escuela`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_alumnos`
--

CREATE TABLE `tb_alumnos` (
  `id_alumno` int(20) NOT NULL,
  `matricula` varchar(255) NOT NULL,
  `nombres` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `fecha_nacimiento` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `grupo` varchar(255) NOT NULL,
  `estatus` int(11) NOT NULL,
  `foto_perfil` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_alumnos`
--

INSERT INTO `tb_alumnos` (`id_alumno`, `matricula`, `nombres`, `apellidos`, `fecha_nacimiento`, `direccion`, `grupo`, `estatus`, `foto_perfil`) VALUES
(1, '17340346', 'Jaime Alberto', 'Sanchez Martinez', '08/04/2000', 'Cuba 790', '6:A', 2, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/7I16F8A12E0E8I.jpg'),
(2, '1231231', 'Jaime A', 'asdasd', '28/12/2021', 'asdasd', '1:A', 2, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/4B2I13E8G12G11H.jpg'),
(3, '123123', 'jnasdjsajd', 'kjsadjnds', '28/12/2021', 'jasjkdnas', '1:A', 2, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/6F0G7B13F11G16F.jpg'),
(4, '18347321', 'Diego Fernando', 'Macias Diaz', '04/04/2000', 'Nuevo Nogales', '3:A', 1, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/4B17E15A15G13A0C.jpg'),
(5, '123', 'as', 'asd', '28/12/2021', 'asd', '1:A', 2, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/16A12H2H2A18C4G.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_padres`
--

CREATE TABLE `tb_padres` (
  `id_tutor` int(25) NOT NULL,
  `nombres` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `fecha_nacimiento` varchar(255) NOT NULL,
  `parentesco` int(20) NOT NULL,
  `estatus` int(11) NOT NULL,
  `foto_perfil` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_padres`
--

INSERT INTO `tb_padres` (`id_tutor`, `nombres`, `apellidos`, `direccion`, `telefono`, `correo`, `fecha_nacimiento`, `parentesco`, `estatus`, `foto_perfil`) VALUES
(1, '', '', '', '', '', '', 0, 0, 'NA'),
(16, 'Jaime Alberto ', 'Sanchez Martinez ', 'Cuba 790 ', '6311987311', 'Jaimehbo13@hotmail.com', '08/04/2000', 1, 1, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/7I16F8A12E0E8I.jpg'),
(21, 'Helmer antonio', 'Gamez Castillo', 'Av los maestros', '6311987312', 'Helmer@gmail.com', '28/12/2021', 1, 1, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/15B18B12C5B14G9D.jpg'),
(22, 'Diego Fernando', 'Macias Diaz', 'jnajndsa', '123123123', 'ansjdnasdnasd', '28/12/2021', 1, 1, 'C:/Users/Jaime/Desktop/Git_hub_escuela/Proyecto_escuela/Imagenes/17I14G4I3F8A10G.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_parentesco`
--

CREATE TABLE `tb_parentesco` (
  `padre` int(11) NOT NULL,
  `madre` int(11) NOT NULL,
  `tutor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_parentesco`
--

INSERT INTO `tb_parentesco` (`padre`, `madre`, `tutor`) VALUES
(1, 2, 3);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_alumnos`
--
ALTER TABLE `tb_alumnos`
  ADD PRIMARY KEY (`id_alumno`),
  ADD UNIQUE KEY `matricula` (`matricula`);

--
-- Indices de la tabla `tb_padres`
--
ALTER TABLE `tb_padres`
  ADD PRIMARY KEY (`id_tutor`),
  ADD UNIQUE KEY `telefono` (`telefono`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_alumnos`
--
ALTER TABLE `tb_alumnos`
  MODIFY `id_alumno` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tb_padres`
--
ALTER TABLE `tb_padres`
  MODIFY `id_tutor` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;