-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-05-2022 a las 20:42:23
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
  `foto_perfil` varchar(255) NOT NULL,
  `codigo_imagen` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_alumnos`
--

INSERT INTO `tb_alumnos` (`id_alumno`, `matricula`, `nombres`, `apellidos`, `fecha_nacimiento`, `direccion`, `grupo`, `estatus`, `foto_perfil`, `codigo_imagen`) VALUES
(36, '17340346', 'Jaime ', 'Sanchez', '11/05/2022', 'Cuba 790', '1:A', 1, 'http://189.204.133.38:8081/imagenes_escuela/imagenes_alumnos/10H13F15D1H10C15D.jpg', '10H13F15D1H10C15D'),
(37, '17340347', 'Diego fernando', 'Macias diaz', '11/05/2022', 'nuevo nogales', '1:A', 1, 'http://189.204.133.38:8081/imagenes_escuela/imagenes_alumnos/5I15F6H19E16A2D.jpg', '5I15F6H19E16A2D');

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
  `estatus` varchar(25) NOT NULL,
  `codigo_imagen` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_empleados`
--

INSERT INTO `tb_empleados` (`id_empleado`, `matricula`, `nombres`, `apellidos`, `fecha_nacimiento`, `direccion`, `correo`, `telefono`, `foto_perfil`, `rol`, `estatus`, `codigo_imagen`) VALUES
(1, '17340346', 'Jaime Alberto', 'Sanchez Martinez', '08/04/2000', 'Cuba 790 col esperanza', 'Jaime@gmail.com', '6311987311', 'http://189.204.133.38:8081/imagenes_escuela/imagenes_empleados/19B15I0G6B12D13G.jpg', '1', '1', '19B15I0G6B12D13G.jpg'),
(11, '17340347', 'Uriel', 'orozco', '11/05/2022', 'virreyes', 'uriel@gmail.com', '6311987312', 'http://189.204.133.38:8081/imagenes_escuela/imagenes_empleados/11H16F12G17D3H1D.jpg', '1', '1', '11H16F12G17D3H1D'),
(12, '17340348', 'Giovanny', 'Siqueiros', '11/05/2022', 'Colosio', 'Giovanny@gmail.com', '6311987313', 'http://189.204.133.38:8081/imagenes_escuela/imagenes_empleados/11I15D13C2F16I8E.jpg', '1', '1', '11I15D13C2F16I8E');

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
(1, '1'),
(16, '11'),
(17, '12');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estatus_salida`
--

CREATE TABLE `tb_estatus_salida` (
  `id_estatus_salida` int(40) NOT NULL,
  `estatus_salida` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estatus_salida`
--

INSERT INTO `tb_estatus_salida` (`id_estatus_salida`, `estatus_salida`) VALUES
(1, 'Tutor en cola'),
(2, 'Alumno en cola'),
(3, 'Alumno en salida'),
(4, 'Alumno entregado');

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
  `foto_perfil` varchar(255) NOT NULL,
  `codigo_imagen` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_padres`
--

INSERT INTO `tb_padres` (`id_tutor`, `nombres`, `apellidos`, `direccion`, `telefono`, `correo`, `fecha_nacimiento`, `parentesco`, `estatus`, `foto_perfil`, `codigo_imagen`) VALUES
(40, 'Jaime alberto', 'Sanchez Martinez', 'cuba 790', '6311987311', 'Jaime13@gmail.com', '08/04/2000', 1, 1, 'http://189.204.133.38:8081/imagenes_escuela/imagenes_tutores/5H18F13D1C12H16I.jpg', '5H18F13D1C12H16I'),
(41, 'Gabriel', 'Garcia', 'Virelles', '6311982111', 'gabriel@gmail.com', '11/05/2022', 1, 1, 'http://189.204.133.38:8081/imagenes_escuela/imagenes_tutores/5F19D4E16I10D15F.jpg', '5F19D4E16I10D15F');

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
(1, 'Jaime@gmail.com', '6311987311', '123'),
(16, 'Uriel@gmail.com', '6311987312', '123'),
(17, 'Giovanny@gmail.com', '6311987313', '123');

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
(7, '36', '13'),
(8, '37', '14');

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
(14, '40', '36'),
(15, '41', '37');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_salida`
--

CREATE TABLE `tb_salida` (
  `id_salida` int(40) NOT NULL,
  `id_tutor` int(40) NOT NULL,
  `id_alumno` int(40) NOT NULL,
  `fecha_peticion` datetime NOT NULL DEFAULT current_timestamp(),
  `id_estatus_salida` int(40) NOT NULL,
  `fecha_salida` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_salida`
--

INSERT INTO `tb_salida` (`id_salida`, `id_tutor`, `id_alumno`, `fecha_peticion`, `id_estatus_salida`, `fecha_salida`) VALUES
(1, 40, 36, '2022-05-11 11:27:00', 2, ''),
(3, 41, 37, '2022-05-11 11:27:00', 3, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_salida_bitacora`
--

CREATE TABLE `tb_salida_bitacora` (
  `id_salida` int(40) NOT NULL,
  `id_tutor` int(40) NOT NULL,
  `id_alumno` int(40) NOT NULL,
  `fecha_peticion` datetime NOT NULL DEFAULT current_timestamp(),
  `id_estatus_salida` int(40) NOT NULL,
  `fecha_salida` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
(13, '17340346', 'Jaimehbo13@gmail.com', '123'),
(14, '17340347', 'diego@gmail.com', '123');

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
-- Indices de la tabla `tb_estatus_salida`
--
ALTER TABLE `tb_estatus_salida`
  ADD PRIMARY KEY (`id_estatus_salida`);

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
-- Indices de la tabla `tb_salida`
--
ALTER TABLE `tb_salida`
  ADD PRIMARY KEY (`id_salida`);

--
-- Indices de la tabla `tb_salida_bitacora`
--
ALTER TABLE `tb_salida_bitacora`
  ADD PRIMARY KEY (`id_salida`);

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
  MODIFY `id_alumno` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de la tabla `tb_empleados`
--
ALTER TABLE `tb_empleados`
  MODIFY `id_empleado` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `tb_empleados_usuarios`
--
ALTER TABLE `tb_empleados_usuarios`
  MODIFY `id_usuario` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `tb_estatus_salida`
--
ALTER TABLE `tb_estatus_salida`
  MODIFY `id_estatus_salida` int(40) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tb_padres`
--
ALTER TABLE `tb_padres`
  MODIFY `id_tutor` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT de la tabla `tb_registro`
--
ALTER TABLE `tb_registro`
  MODIFY `id_usuario` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `tb_relacion_alumno_usuario`
--
ALTER TABLE `tb_relacion_alumno_usuario`
  MODIFY `id_relacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `tb_relacion_tutor_alumno`
--
ALTER TABLE `tb_relacion_tutor_alumno`
  MODIFY `id_relacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `tb_salida`
--
ALTER TABLE `tb_salida`
  MODIFY `id_salida` int(40) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_salida_bitacora`
--
ALTER TABLE `tb_salida_bitacora`
  MODIFY `id_salida` int(40) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios_alumnos`
--
ALTER TABLE `tb_usuarios_alumnos`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
