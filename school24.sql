-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране: 11 юли 2024 в 08:15
-- Версия на сървъра: 10.4.27-MariaDB
-- Версия на PHP: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `school24`
--

-- --------------------------------------------------------

--
-- Структура на таблица `addresses`
--

CREATE TABLE `addresses` (
  `id` int(11) NOT NULL,
  `street_id` int(11) DEFAULT NULL,
  `ap_building` int(2) DEFAULT NULL,
  `entrance` int(1) DEFAULT NULL,
  `floor` int(1) DEFAULT NULL,
  `apartment` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура на таблица `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `admins`
--

INSERT INTO `admins` (`id`, `username`, `password`) VALUES
(1, 'alyara', '123'),
(2, 'ceylann', '123');

-- --------------------------------------------------------

--
-- Структура на таблица `courses`
--

CREATE TABLE `courses` (
  `id` int(11) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `teacher_id` int(11) NOT NULL,
  `Description` varchar(70) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `courses`
--

INSERT INTO `courses` (`id`, `Name`, `teacher_id`, `Description`) VALUES
(0, 'Духови инструменти', 0, 'Флейта: Яна Изова, Симеон Озо; Обой: Светла Ачева; Тромпет: Илия Косе '),
(1, 'Струнна група', 1, 'Цигулка: Румяна Маркова; Арфа: Лия Осева; Китара: Нина Цонева'),
(2, 'Задължително пиано', 2, 'Инна Иванова, Симеон Велков, Ена Енчева'),
(3, 'Вокална група', 3, 'Клас. пеене: Андрей Найденов; Народ. пееене: проф. Никола Мацов'),
(4, 'Ударни инструменти', 4, 'Комплект барабани: Атанас Попов'),
(5, 'Муз. Теоритична гр.', 5, 'Сплфеж: Теменужка Петрова; История на муз.: албена Безовска');

-- --------------------------------------------------------

--
-- Структура на таблица `courses_teacher`
--

CREATE TABLE `courses_teacher` (
  `id` int(11) NOT NULL,
  `Name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `courses_teacher`
--

INSERT INTO `courses_teacher` (`id`, `Name`) VALUES
(0, 'Духови инструменти'),
(1, 'Струнна група'),
(2, 'Задължително пиано'),
(3, 'Вокална група'),
(4, 'Ударни инструменти'),
(5, 'Муз. Теоритична гр.');

-- --------------------------------------------------------

--
-- Структура на таблица `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `name` varchar(16) DEFAULT NULL,
  `family` varchar(16) DEFAULT NULL,
  `birthday` varchar(10) DEFAULT NULL,
  `course_id` int(11) DEFAULT NULL,
  `number` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `students`
--

INSERT INTO `students` (`id`, `name`, `family`, `birthday`, `course_id`, `number`) VALUES
(1, 'Азра', 'Елинова', '30-12-2007', 0, 896345796),
(2, 'Бехчет', 'Бехчет', '6-7-2007', 0, 896346996),
(3, 'Виктория', 'Ганчева', '15-5-2006', 0, 896355996),
(4, 'Георги', 'Георгиев', '26-8-2008', 0, 896336476),
(5, 'Светлозар', 'Димитров', '7-3-2009', 0, 897146796),
(6, 'Айхан', 'Закиров', '19-9-2008', 0, 2147483647),
(7, 'Мирела', 'Илиева', '12-6-2005', 0, 89679346),
(8, 'Ербил', 'Исаев', '8-11-2006', 0, 899714796),
(9, 'Мехмедали', 'Ислям', '28-7-2006', 0, 893794158),
(10, 'Джунейт', 'Исмаилов', '11-12-2008', 0, 891479548),
(11, 'Радослава', 'Кавръкова', '7-2-2007', 1, 89469856),
(12, 'Хюсеин', 'Камбур', '14-2-2007', 1, 876248547),
(13, 'Красимир', 'Кунчев', '8-8-2007', 1, 877964852),
(14, 'Изел', 'Мехмедова', '11-5-2008', 1, 896547123),
(15, 'Микаела', 'Михайлова', '21-9-2009', 1, 897851696),
(16, 'Николай', 'Ненов', '8-3-2008', 1, 876458972),
(17, 'Петя', 'Панчева', '17-3-2006', 1, 897775698),
(18, 'Петко', 'Петков', '21-9-2006', 1, 2147483647),
(19, 'Сертан', 'Рафи', '30-5-2006', 1, 894459863),
(20, 'Ремзие', 'Реджеб', '1-6-2006', 1, 899985441),
(21, 'Алпер', 'Себайдинов', '14-8-2005', 1, 887965421),
(22, 'Юркие', 'Селяйдинова', '14-7-2005', 2, 896312452),
(23, 'Николай', 'Славеев', '12-1-2007', 2, 893364585),
(24, 'Яница', 'Стоянова', '8-11-2010', 2, 898856422),
(25, 'Сузан', 'Томова', '28-12-2011', 2, 879632841),
(26, 'Айлин', 'Алиева', '2-12-20012', 2, 896746951),
(27, 'Никола', 'Атанасов', '1-4-2009', 2, 892365489),
(28, 'Денис', 'Ахмедов', '3-5-2013', 2, 878451236),
(29, 'Семра', 'Ахмедова', '30-8-2012', 2, 89236485),
(30, 'Шукран', 'Бейтулова', '22-6-2010', 2, 896314528),
(31, 'Данчо', 'Боянов', '16-2-2006', 2, 87642589),
(32, 'Ния', 'Василева', '8-8-2005', 2, 89636261),
(33, 'Инна', 'Димова', '18-6-2007', 3, 896745213),
(34, 'Александър', 'Есатрян', '12-7-2010', 3, 89152634),
(35, 'Mехмед', 'Ибрахим', '16-7-2012', 3, 899966331),
(36, 'Невена', 'Йорданова', '13-2-2012', 3, 89445566),
(37, 'Румен', 'Каров', '28-1-2010', 3, 899911225),
(38, 'Максимилиян', 'Колев', '3-7-2006', 3, 896549871),
(39, 'Виктория', 'Колева', '12-12-2012', 3, 891246358),
(40, 'Назан', 'Мехмед', '6-8-2013', 3, 896345796),
(41, 'Зелиха', 'Миленова', '22-6-2013', 3, 873364859),
(42, 'Милен', 'Минчев', '19-3-2011', 3, 89664452),
(43, 'Конда', 'Митев', '13-11-2011', 3, 891122659),
(44, 'Николай', 'Николаев', '30-3-2010', 3, 878945613),
(45, 'Галина', 'Пенкова', '26-4-2012', 3, 891463598),
(46, 'Неслихан', 'Февзи', '20-6-2007', 4, 896345796),
(47, 'Севгин', 'Халил', '3-7-2005', 4, 895689341),
(48, 'Валери', 'Хараланов', '21-7-2008', 4, 896659877),
(49, 'Стефани', 'Цонева', '19-9-2005', 4, 89364196),
(50, 'Азем', 'Азем', '19-5-2009', 4, 87634859),
(51, 'Емилия', 'Александрова', '19-7-2008', 4, 893435456),
(52, 'Али', 'Али', '11-4-2011', 4, 874192568),
(53, 'Йоанна', 'Ангелова', '15-6-2012', 4, 896979859),
(54, 'Бернар', 'Бейза', '21-6-2013', 4, 89656237),
(55, 'Георги', 'Гецов', '19-12-2012', 4, 896345459),
(56, 'Десислава', 'Добринова', '6-9-2010', 4, 891126534),
(57, 'Калоян', 'Дянков', '23-12-2011', 5, 899988456),
(58, 'Кремена', 'Илиева', '24-1-2006', 5, 896334691),
(59, 'Теодора', 'Колева', '27-2-2007', 5, 890203651),
(60, 'Семра', 'Махмудова', '26-1-2012', 5, 892030652),
(61, 'Мелис', 'Мехдиева', '21-7-2011', 5, 896300657),
(62, 'Мухарем', 'Мухарем', '9-8-2013', 5, 89400563),
(63, 'Мюмюн', 'Мюмюн', '16-7-2009', 5, 890036450),
(65, 'Траяна', 'Петрова', '7-8-2007', 5, 896003001),
(66, 'Айлин', 'Ремзи', '8-10-2008', 5, 896796352),
(67, 'Айсун', 'Февзи', '1-3-2006', 5, 896300357),
(68, 'Фейзула', 'Фейзулов', '26-9-2010', 5, 898003021),
(69, 'Весиле', 'Фейзулова', '10-1-2013', 5, 899066092),
(70, 'Ипек', 'Хасан', '13-7-2013', 5, 89630037),
(71, 'Алис', 'Иванова', '2013-10-22', 1, 895791294),
(72, 'Ивана', 'Алексиева', '2008-04-19', 5, 896663322),
(73, 'Александра', 'Илиева', '2009-04-26', 5, 894126555);

-- --------------------------------------------------------

--
-- Структура на таблица `teachers`
--

CREATE TABLE `teachers` (
  `id` int(11) NOT NULL,
  `name` varchar(10) DEFAULT NULL,
  `family` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Схема на данните от таблица `teachers`
--

INSERT INTO `teachers` (`id`, `name`, `family`) VALUES
(0, 'Станислав', 'Илиев'),
(1, 'Румяна', 'Маркова'),
(2, 'Росица', 'Дачева'),
(3, 'Любов', 'Шишева'),
(4, 'Атанас', 'Попова'),
(5, 'д-р. Десис', 'Томов'),
(6, 'Яна', 'Димитрова'),
(7, 'Симеон', 'Шишманов'),
(8, 'Светлана', 'Анчева'),
(9, 'Илиян', 'Косев'),
(10, 'Явор', 'Гайдов'),
(11, 'Илия', 'Косев'),
(12, 'Родмила', 'Петрова'),
(13, 'Йордан', 'Стойчев'),
(14, 'Весела', 'Илиева'),
(15, 'Лилияна', 'Илиева'),
(16, 'Божидара', 'Троханова'),
(17, 'Инна', 'Иванова'),
(18, 'Симеон', 'Венков'),
(19, 'Ена', 'Енчева'),
(20, 'Андрей', 'Найденов'),
(21, 'Елена', 'Павлова'),
(22, 'проф. Нико', 'Моцов'),
(23, 'Биляна', 'Соколова'),
(24, 'Таня', 'Великова'),
(25, 'Никола', 'Петков'),
(26, 'Теменужка', 'Петрова'),
(27, 'Иван', 'Гайдаров'),
(28, 'Албена', 'Бенкова'),
(29, 'Силвия', 'Кръстева');

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Индекси за таблица `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `teacher_id` (`teacher_id`),
  ADD UNIQUE KEY `id` (`id`),
  ADD KEY `teacher_id_2` (`teacher_id`);

--
-- Индекси за таблица `courses_teacher`
--
ALTER TABLE `courses_teacher`
  ADD PRIMARY KEY (`id`);

--
-- Индекси за таблица `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`);

--
-- Индекси за таблица `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
