-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2025-06-09 00:09:58
-- 伺服器版本： 10.4.32-MariaDB
-- PHP 版本： 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `default`
--

-- --------------------------------------------------------

--
-- 資料表結構 `afterservicefeedback`
--

CREATE TABLE `afterservicefeedback` (
  `clientID` int(4) NOT NULL,
  `orderID` int(4) NOT NULL,
  `DataOfFeedback` varchar(20) NOT NULL,
  `feedbackType` varchar(50) NOT NULL,
  `feedbackDetail` text NOT NULL,
  `contactType` varchar(50) NOT NULL,
  `contactInfo` varchar(100) NOT NULL,
  `Interaction` text NOT NULL,
  `productID` int(4) NOT NULL,
  `staffID` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- 資料表結構 `department`
--

CREATE TABLE `department` (
  `dept_id` int(2) NOT NULL,
  `dept_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `department`
--

INSERT INTO `department` (`dept_id`, `dept_name`) VALUES
(1, 'Administrator'),
(2, 'Quality Controller'),
(3, 'Accounting Departmen'),
(4, 'Material Procurement and Management'),
(5, 'Production department'),
(6, 'Service Department');

-- --------------------------------------------------------

--
-- 資料表結構 `event`
--

CREATE TABLE `event` (
  `event_id` int(255) NOT NULL,
  `event_type` enum('login','insert_item','update_item','delete_item','generate_report') NOT NULL,
  `event_date` datetime NOT NULL DEFAULT current_timestamp(),
  `event_content` varchar(255) NOT NULL,
  `staff_id` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- 資料表結構 `item`
--

CREATE TABLE `item` (
  `item_id` int(3) NOT NULL,
  `item_description` varchar(30) NOT NULL,
  `item_quantity` int(10) NOT NULL,
  `item_weight` varchar(10) NOT NULL DEFAULT '0kg',
  `item_size` varchar(10) NOT NULL DEFAULT '0cm x 0cm',
  `warehouse_id` int(2) NOT NULL,
  `created_at` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- 資料表結構 `product`
--

CREATE TABLE `product` (
  `product_id` int(3) NOT NULL,
  `product_name` varchar(20) NOT NULL,
  `product_description` varchar(30) NOT NULL,
  `product_price` decimal(4,0) NOT NULL,
  `product_quantity` int(10) NOT NULL,
  `product_weight` varchar(10) NOT NULL DEFAULT '0kg',
  `product_size` varchar(10) NOT NULL DEFAULT '0cm x 0cm',
  `product_isFragile` tinyint(1) NOT NULL,
  `warehouse_id` int(2) NOT NULL,
  `item_id` int(3) NOT NULL,
  `created_at` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- 資料表結構 `report`
--

CREATE TABLE `report` (
  `report_id` int(3) NOT NULL,
  `report_name` varchar(20) NOT NULL,
  `report_file` longblob NOT NULL,
  `created_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- 資料表結構 `staff`
--

CREATE TABLE `staff` (
  `staff_id` int(2) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone_number` int(8) NOT NULL,
  `dept_id` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `staff`
--

INSERT INTO `staff` (`staff_id`, `username`, `password`, `email`, `phone_number`, `dept_id`) VALUES
(3, 'root', '4813494d137e1631bba301d5acab6e7bb7aa74ce1185d456565ef51d737677b2', '', 0, 1),
(6, 'peter', '026ad9b14a7453b7488daa0c6acbc258b1506f52c441c7c465474c1a564394ff', 'peter@gmail.com', 27436357, 2),
(7, 'cindy', '002340b41aee7da76f4201bf18776291a812f796e20678c563b77b5b6c47c8a1', 'cindy@gmail.com', 26484753, 3),
(8, 'alex', '4135aa9dc1b842a653dea846903ddb95bfb8c5a10c504a7fa16e10bc31d1fdf0', 'alex@gmail.com', 24679385, 4),
(9, 'leo', '8535e86c8118bbbb0a18ac72d15d3a2b37b18d1bce1611fc60165f322cf57386', 'leo@gmail.com', 28596385, 5),
(10, 'ivy', '254ac4523be56a1a724c4cd50437cfe343f0b4403d1c5a4def8ee8ce3259b9ad', 'ivy@gmail.com', 26479966, 6);

-- --------------------------------------------------------

--
-- 資料表結構 `warehouse`
--

CREATE TABLE `warehouse` (
  `warehouse_id` int(2) NOT NULL,
  `warehouse_name` varchar(20) NOT NULL,
  `warehouse_location` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `afterservicefeedback`
--
ALTER TABLE `afterservicefeedback`
  ADD PRIMARY KEY (`clientID`);

--
-- 資料表索引 `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`dept_id`);

--
-- 資料表索引 `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`event_id`),
  ADD KEY `fk_staff_id` (`staff_id`);

--
-- 資料表索引 `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `fk_item_warehouse_id` (`warehouse_id`);

--
-- 資料表索引 `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `fk_item_id` (`item_id`),
  ADD KEY `fk_product_warehouse_id` (`warehouse_id`);

--
-- 資料表索引 `report`
--
ALTER TABLE `report`
  ADD PRIMARY KEY (`report_id`);

--
-- 資料表索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`),
  ADD KEY `fk_dept_id` (`dept_id`);

--
-- 資料表索引 `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`warehouse_id`);

--
-- 在傾印的資料表使用自動遞增(AUTO_INCREMENT)
--

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `afterservicefeedback`
--
ALTER TABLE `afterservicefeedback`
  MODIFY `clientID` int(4) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `department`
--
ALTER TABLE `department`
  MODIFY `dept_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `event`
--
ALTER TABLE `event`
  MODIFY `event_id` int(255) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `item`
--
ALTER TABLE `item`
  MODIFY `item_id` int(3) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `product`
--
ALTER TABLE `product`
  MODIFY `product_id` int(3) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `report`
--
ALTER TABLE `report`
  MODIFY `report_id` int(3) NOT NULL AUTO_INCREMENT;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `staff`
--
ALTER TABLE `staff`
  MODIFY `staff_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `warehouse_id` int(2) NOT NULL AUTO_INCREMENT;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `fk_staff_id` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`);

--
-- 資料表的限制式 `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `fk_item_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`);

--
-- 資料表的限制式 `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `fk_product_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`),
  ADD CONSTRAINT `fk_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`);

--
-- 資料表的限制式 `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `fk_dept_id` FOREIGN KEY (`dept_id`) REFERENCES `department` (`dept_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
