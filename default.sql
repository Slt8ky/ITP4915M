SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


CREATE TABLE `department` (
  `dept_id` int(2) NOT NULL,
  `dept_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `department` (`dept_id`, `dept_name`) VALUES
(1, 'Administrator');

CREATE TABLE `event` (
  `event_id` int(255) NOT NULL,
  `event_type` enum('login','insert_item','update_item','delete_item','view_report') NOT NULL,
  `event_date` datetime NOT NULL DEFAULT current_timestamp(),
  `event_content` varchar(255) NOT NULL,
  `staff_id` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `item` (
  `item_id` int(3) NOT NULL,
  `item_description` varchar(30) NOT NULL,
  `item_price` decimal(4,0) NOT NULL,
  `item_quantity` int(10) NOT NULL,
  `warehouse_id` int(2) NOT NULL,
  `created_at` date NOT NULL DEFAULT current_timestamp(),
  `updated_at` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `product` (
  `product_id` int(3) NOT NULL,
  `product_name` varchar(20) NOT NULL,
  `product_description` varchar(30) NOT NULL,
  `product_price` decimal(4,0) NOT NULL,
  `product_quantity` int(10) NOT NULL,
  `warehouse_id` int(2) NOT NULL,
  `item_id` int(3) NOT NULL,
  `created_at` date NOT NULL DEFAULT current_timestamp(),
  `updated_at` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `report` (
  `report_id` int(3) NOT NULL,
  `report_name` varchar(20) NOT NULL,
  `report_file` longblob NOT NULL,
  `created_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `staff` (
  `staff_id` int(2) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone_number` int(8) NOT NULL,
  `dept_id` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `staff` (`staff_id`, `username`, `password`, `email`, `phone_number`, `dept_id`) VALUES
(3, 'root', '4813494d137e1631bba301d5acab6e7bb7aa74ce1185d456565ef51d737677b2', '', 0, 1);

CREATE TABLE `warehouse` (
  `warehouse_id` int(2) NOT NULL,
  `warehouse_name` varchar(20) NOT NULL,
  `warehouse_location` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


ALTER TABLE `department`
  ADD PRIMARY KEY (`dept_id`);

ALTER TABLE `event`
  ADD PRIMARY KEY (`event_id`),
  ADD KEY `fk_staff_id` (`staff_id`);

ALTER TABLE `item`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `fk_item_warehouse_id` (`warehouse_id`);

ALTER TABLE `product`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `fk_item_id` (`item_id`),
  ADD KEY `fk_product_warehouse_id` (`warehouse_id`);

ALTER TABLE `report`
  ADD PRIMARY KEY (`report_id`);

ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`),
  ADD KEY `fk_dept_id` (`dept_id`);

ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`warehouse_id`);


ALTER TABLE `department`
  MODIFY `dept_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `event`
  MODIFY `event_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

ALTER TABLE `item`
  MODIFY `item_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `product`
  MODIFY `product_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `report`
  MODIFY `report_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=75;

ALTER TABLE `staff`
  MODIFY `staff_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

ALTER TABLE `warehouse`
  MODIFY `warehouse_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;


ALTER TABLE `event`
  ADD CONSTRAINT `fk_staff_id` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`);

ALTER TABLE `item`
  ADD CONSTRAINT `fk_item_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`);

ALTER TABLE `product`
  ADD CONSTRAINT `fk_product_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`),
  ADD CONSTRAINT `fk_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`);

ALTER TABLE `staff`
  ADD CONSTRAINT `fk_dept_id` FOREIGN KEY (`dept_id`) REFERENCES `department` (`dept_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
