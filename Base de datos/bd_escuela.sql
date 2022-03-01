-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-03-2022 a las 19:52:21
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
(1, '17340346', 'Jaime Alberto', 'Sanchez Martinez', '08/04/2000', 'Cuba 790', '6:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/7I16F8A12E0E8I.jpg'),
(2, '1231231', 'Jaime A', 'asdasd', '28/12/2021', 'asdasd', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/4B2I13E8G12G11H.jpg'),
(3, '123123', 'jnasdjsajd', 'kjsadjnds', '28/12/2021', 'jasjkdnas', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/6F0G7B13F11G16F.jpg'),
(4, '18347322', 'Diego Fernando C', 'Macias Diaz', '04/04/2000', 'Nuevo Nogales', '3:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/9E4C6A3F9I1B.jpg'),
(5, '123', 'as', 'asd', '28/12/2021', 'asd', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/4E1C12A12I19H18G.jpg'),
(6, '123123asd', 'hellouda', 'ajsdjasd', '28/12/2021', 'jasjdajsd', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/4C19F18E17A15E17G.jpg'),
(7, '12345', 'kjnaskdj', 'kajsdnj', '28/12/2021', 'kajnsdkjasd', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/7D12G11F15G16D10F.jpg'),
(8, '123556', 'askmd', 'kasdk', '28/12/2021', 'kmasdk', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/13H12D0A16B7A7E.jpg'),
(9, '1234', 'asd', 'asd', '28/12/2021', 'asdasd', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/8C11H3D18G7F3C.jpg'),
(10, '123124', 'asdasd', 'asdasd', '28/12/2021', 'asdasd', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/13D0G2E11D17A18B.jpg'),
(11, '1234212323', 'sadasdqwdas', 'asdasdwad', '28/12/2021', 'asdasdawds', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/0I8A13E19G15B17C.jpg'),
(12, '12232', 'asd', 'asd', '28/12/2021', 'asd', '1:A', 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/12I5A1A14G3F6H.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_empleados`
--

CREATE TABLE `tb_empleados` (
  `id_empleado` int(255) NOT NULL,
  `matricula` varchar(255) NOT NULL,
  `nombres` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `fecha_nacimiento` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `foto_perfil` varchar(255) NOT NULL,
  `rol` varchar(250) NOT NULL,
  `estatus` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_empleados`
--

INSERT INTO `tb_empleados` (`id_empleado`, `matricula`, `nombres`, `apellidos`, `fecha_nacimiento`, `direccion`, `correo`, `telefono`, `foto_perfil`, `rol`, `estatus`) VALUES
(2, '17340346', 'Jaime Alberto', 'Sánchez Martinez', '08/04/2000', 'Cuba 790', 'Jaimehbo13@hotmail.com', '6311987311', 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/7I16F8A12E0E8I.jpg', 'Administrador', 'Activo'),
(3, '17340347', 'Giovanny', 'Siqueiros', '00/00/00', 'NA', 'Giovanny@gmail.com', '6311987211', '', 'Administrador', 'Activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_empleados_usuarios`
--

CREATE TABLE `tb_empleados_usuarios` (
  `id_usuario` int(255) NOT NULL,
  `id_empleado` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_empleados_usuarios`
--

INSERT INTO `tb_empleados_usuarios` (`id_usuario`, `id_empleado`) VALUES
(11, '2'),
(12, '3');

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
(16, 'Jaime Alberto ', 'Sanchez Martinez ', 'Cuba 790 ', '6311987311', 'Jaimehbo13@hotmail.com', '08/04/2000', 1, 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/7I16F8A12E0E8I.jpg'),
(21, 'Helmer antonio', 'Gamez Castillo', 'Av los maestros', '6311987312', 'Helmer@gmail.com', '28/12/2021', 1, 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/15B18B12C5B14G9D.jpg'),
(22, 'Diego Fernando', 'Macias Diaz', 'jnajndsa', '123123123', 'ansjdnasdnasd', '28/12/2021', 1, 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/17I14G4I3F8A10G.jpg'),
(23, 'hbasjhdb', 'hashjdbsa', 'ajsbdhjads', '123123', 'jbahdjasd', '28/12/2021', 1, 1, 'C:/Users/Jaime/Desktop/Proyectos Jane Software/Git_hub_escuela/Proyecto_escuela/Imagenes/13E2H16A15A18B3I.jpg');

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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_registro`
--

CREATE TABLE `tb_registro` (
  `id_usuario` int(255) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `contraseña` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_registro`
--

INSERT INTO `tb_registro` (`id_usuario`, `correo`, `telefono`, `contraseña`) VALUES
(11, 'Jaimehbo13@hotmail.com', '6311987311', 'Jaimehbo13'),
(12, 'giovanny@gmail.com', '6311987211', '123');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_relacion_alumno_usuario`
--

CREATE TABLE `tb_relacion_alumno_usuario` (
  `id_relacion` int(11) NOT NULL,
  `id_alumno` varchar(35) NOT NULL,
  `id_usuario_alumno` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_relacion_alumno_usuario`
--

INSERT INTO `tb_relacion_alumno_usuario` (`id_relacion`, `id_alumno`, `id_usuario_alumno`) VALUES
(1, '8', '5'),
(2, '9', '8'),
(3, '11', '9'),
(4, '12', '10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_relacion_tutor_alumno`
--

CREATE TABLE `tb_relacion_tutor_alumno` (
  `id_relacion` int(11) NOT NULL,
  `Tutor` varchar(20) NOT NULL,
  `Alumno` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_relacion_tutor_alumno`
--

INSERT INTO `tb_relacion_tutor_alumno` (`id_relacion`, `Tutor`, `Alumno`) VALUES
(3, '16', '1'),
(4, '16', '5'),
(5, '22', '5'),
(6, '22', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_usuarios_alumnos`
--

CREATE TABLE `tb_usuarios_alumnos` (
  `id_usuario` int(11) NOT NULL,
  `matricula` varchar(255) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `contraseña` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_usuarios_alumnos`
--

INSERT INTO `tb_usuarios_alumnos` (`id_usuario`, `matricula`, `correo`, `contraseña`) VALUES
(4, '123556', 'Correo', 'Contraseña'),
(8, '1234', 'asd', 'asdasd'),
(9, '1234212323', 'asdwqdsad', 'asdasdasd'),
(10, '12232', 'Jaime@gmail.com', '123');

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
-- Indices de la tabla `tb_empleados`
--
ALTER TABLE `tb_empleados`
  ADD PRIMARY KEY (`id_empleado`);

--
-- Indices de la tabla `tb_empleados_usuarios`
--
ALTER TABLE `tb_empleados_usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Indices de la tabla `tb_padres`
--
ALTER TABLE `tb_padres`
  ADD PRIMARY KEY (`id_tutor`),
  ADD UNIQUE KEY `telefono` (`telefono`);

--
-- Indices de la tabla `tb_registro`
--
ALTER TABLE `tb_registro`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Indices de la tabla `tb_relacion_alumno_usuario`
--
ALTER TABLE `tb_relacion_alumno_usuario`
  ADD PRIMARY KEY (`id_relacion`),
  ADD UNIQUE KEY `id_alumno` (`id_alumno`);

--
-- Indices de la tabla `tb_relacion_tutor_alumno`
--
ALTER TABLE `tb_relacion_tutor_alumno`
  ADD PRIMARY KEY (`id_relacion`);

--
-- Indices de la tabla `tb_usuarios_alumnos`
--
ALTER TABLE `tb_usuarios_alumnos`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `matricula` (`matricula`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_alumnos`
--
ALTER TABLE `tb_alumnos`
  MODIFY `id_alumno` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `tb_empleados`
--
ALTER TABLE `tb_empleados`
  MODIFY `id_empleado` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_empleados_usuarios`
--
ALTER TABLE `tb_empleados_usuarios`
  MODIFY `id_usuario` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `tb_padres`
--
ALTER TABLE `tb_padres`
  MODIFY `id_tutor` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de la tabla `tb_registro`
--
ALTER TABLE `tb_registro`
  MODIFY `id_usuario` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `tb_relacion_alumno_usuario`
--
ALTER TABLE `tb_relacion_alumno_usuario`
  MODIFY `id_relacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tb_relacion_tutor_alumno`
--
ALTER TABLE `tb_relacion_tutor_alumno`
  MODIFY `id_relacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios_alumnos`
--
ALTER TABLE `tb_usuarios_alumnos`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
