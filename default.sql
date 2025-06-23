SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

CREATE TABLE `afterservicefeedback` (
  `feedbackID` int(8) NOT NULL,
  `clientID` int(8) NOT NULL,
  `orderID` int(8) NOT NULL,
  `feedBackType` enum('Quality','Design','Instructions','Packaging','Features') NOT NULL,
  `feedbackDate` date NOT NULL DEFAULT current_timestamp(),
  `feedbackDetail` varchar(1000) NOT NULL,
  `contactType` enum('Email','Phone','Letter','Message') NOT NULL,
  `contactInfo` varchar(11) NOT NULL,
  `ProductID` int(8) NOT NULL,
  `StaffID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `afterservicefeedback` (`feedbackID`, `clientID`, `orderID`, `feedBackType`, `feedbackDate`, `feedbackDetail`, `contactType`, `contactInfo`, `ProductID`, `StaffID`) VALUES
(1, 1, 1, 'Quality', '2025-06-05', 'The toy car is very durable!', 'Email', 'alice.chan@', 1, 1),
(2, 2, 2, 'Design', '2025-06-06', 'Loved the design of the plush toy!', 'Phone', '92345678', 2, 2),
(3, 3, 3, 'Features', '2025-06-07', 'Great features in the construction set.', 'Letter', 'Cathy Wong', 3, 3);

CREATE TABLE `clientinformation` (
  `ClientID` int(11) NOT NULL,
  `ClientName` varchar(20) NOT NULL,
  `ClientPhoneNum` varchar(12) NOT NULL,
  `ClientEmail` varchar(20) NOT NULL,
  `ClientAddress` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `clientinformation` (`ClientID`, `ClientName`, `ClientPhoneNum`, `ClientEmail`, `ClientAddress`) VALUES
(1, 'Alice Chan', '91234567', 'alice.chan@example.c', '123 Nathan Road, Kowloon, HK'),
(2, 'Bob Lee', '92345678', 'bob.lee@example.com', '456 Queen\'s Road, Central, HK'),
(3, 'Cathy Wong', '93456789', 'cathy.wong@example.c', '789 King\'s Road, North Point, HK');

CREATE TABLE `customerorder` (
  `OrderID` int(8) NOT NULL,
  `OrderDate` date NOT NULL DEFAULT current_timestamp(),
  `ClientID` int(8) NOT NULL,
  `Requirement` varchar(100) NOT NULL,
  `Quantity` int(2) NOT NULL,
  `ProductID` int(8) NOT NULL,
  `TotalPrice` int(11) NOT NULL,
  `Payment` enum('Credit card','Alipay','Wechat Pay','Bank Transfer','Cheque','Cash') NOT NULL,
  `Delivertype` enum('Land Transportation','Air Way','Marine Transport','') NOT NULL,
  `StaffID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `customerorder` (`OrderID`, `OrderDate`, `ClientID`, `Requirement`, `Quantity`, `ProductID`, `TotalPrice`, `Payment`, `Delivertype`, `StaffID`) VALUES
(1, '2025-06-01', 1, 'Toy Cars', 3, 1, 450, 'Credit card', 'Land Transportation', 1),
(2, '2025-06-02', 2, 'Animal Plush', 2, 2, 400, 'Cash', 'Air Way', 2),
(3, '2025-06-03', 3, 'Construction Set', 1, 3, 300, 'Alipay', 'Marine Transport', 3);

CREATE TABLE `damagematerial` (
  `DamMatID` int(8) NOT NULL,
  `DamMatName` varchar(20) NOT NULL,
  `DamMatAmount` text NOT NULL,
  `StaffID` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `damagematerial` (`DamMatID`, `DamMatName`, `DamMatAmount`, `StaffID`) VALUES
(1, 'Plastic Sheets', '50', 1),
(2, 'Cotton Fabric', '30', 2),
(3, 'Wooden Blocks', '40', 3),
(4, 'Broken Toy Parts', '25', 1),
(5, 'Damaged Plush', '15', 2),
(6, 'Scrap Metal', '20', 3),
(7, 'Worn Out Tires', '10', 1),
(8, 'Defective Electronic', '8', 2),
(9, 'Torn Fabric', '12', 3),
(10, 'Cracked Plastic', '5', 1),
(11, 'Missing Parts', '3', 2),
(12, 'Scratched Surface', '7', 3),
(13, 'Moldy Material', '4', 1),
(14, 'Old Stock', '20', 2),
(15, 'Excess Plastic', '30', 3),
(16, 'Unused Components', '15', 1),
(17, 'Outdated Material', '25', 2),
(18, 'Broken Molds', '10', 3),
(19, 'Damaged Components', '5', 1),
(20, 'Expired Material', '12', 2),
(21, 'Leftover Parts', '8', 3),
(22, 'Contaminated Fabric', '6', 1),
(23, 'Overstocked Items', '9', 2),
(24, 'Faulty Electronics', '3', 3),
(25, 'Wasted Material', '20', 1),
(26, 'Scrap Pieces', '15', 2),
(27, 'Non-usable Parts', '7', 3),
(28, 'Defective Toys', '10', 1),
(29, 'Unused Stuffing', '5', 2),
(30, 'Recyclable Material', '25', 3);

CREATE TABLE `department` (
  `DeptID` int(2) NOT NULL,
  `DeptName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `department` (`DeptID`, `DeptName`) VALUES
(1, 'Administrator'),
(2, 'R&D Team Member'),
(3, 'Sales Representative'),
(4, 'Production Manager'),
(5, 'Inventory Manager'),
(6, 'Customer Service Representative'),
(7, 'Logistics Coordinator');

CREATE TABLE `event` (
  `event_id` int(255) NOT NULL,
  `event_type` enum('item_insert','item_update','item_delete','staff_login') NOT NULL,
  `event_date` datetime NOT NULL DEFAULT current_timestamp(),
  `event_content` varchar(100) NOT NULL,
  `StaffID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `event` (`event_id`, `event_type`, `event_date`, `event_content`, `StaffID`) VALUES
(1, 'item_insert', '2025-06-01 10:00:00', 'Inserted new toy car component', 1),
(2, 'item_update', '2025-06-02 11:00:00', 'Updated plush toy filling amount', 2),
(3, 'staff_login', '2025-06-03 09:00:00', 'Staff Alex logged in', 3),
(166, 'staff_login', '2025-06-13 11:24:10', '', 1),
(167, 'staff_login', '2025-06-13 11:25:24', '', 1),
(168, 'staff_login', '2025-06-13 11:37:20', '', 1),
(169, 'staff_login', '2025-06-13 11:38:47', '', 1),
(170, '', '2025-06-13 11:38:51', '', 1),
(171, '', '2025-06-13 11:39:14', '', 1),
(172, 'staff_login', '2025-06-13 11:43:16', '', 1),
(173, 'staff_login', '2025-06-13 11:45:18', '', 1),
(174, 'staff_login', '2025-06-13 11:48:52', '', 1),
(175, 'staff_login', '2025-06-13 11:49:49', '', 1),
(176, 'staff_login', '2025-06-13 11:50:59', '', 1),
(177, 'staff_login', '2025-06-13 11:56:03', '', 1);

CREATE TABLE `facilities` (
  `FacilitiesID` int(8) NOT NULL,
  `Location` varchar(20) NOT NULL,
  `StaffID` int(8) NOT NULL,
  `FacilitiesContactNum` varchar(12) NOT NULL,
  `FacilitiesEmail` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `facilities` (`FacilitiesID`, `Location`, `StaffID`, `FacilitiesContactNum`, `FacilitiesEmail`) VALUES
(1, 'Warehouse A', 1, '91234567', 'warehouseA@example.com'),
(2, 'Warehouse B', 2, '92345678', 'warehouseB@example.com');

CREATE TABLE `finishedcomponent` (
  `FCID` int(8) NOT NULL,
  `TotalAmount` int(11) NOT NULL,
  `FCName` varchar(30) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `ProductType` enum('car','Animals','Construction toys','Dolls','Food-related toys') NOT NULL,
  `WHID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `finishedcomponent` (`FCID`, `TotalAmount`, `FCName`, `ProductID`, `ProductType`, `WHID`) VALUES
(1, 500, 'Toy Car Component', 1, 'car', 1),
(2, 300, 'Plush Toy Filling', 2, 'Animals', 1),
(3, 400, 'Construction Set Parts', 3, 'Construction toys', 2),
(4, 450, 'Doll House Walls', 4, 'Dolls', 1),
(5, 200, 'Race Track Pieces', 5, 'car', 1),
(6, 350, 'Animal Figurines', 6, 'Animals', 2),
(7, 600, 'Toy Food Items', 7, 'Food-related toys', 1),
(8, 250, 'Robot Parts', 8, 'car', 1),
(9, 550, 'Puzzle Pieces', 9, 'Construction toys', 2),
(10, 300, 'Magic Accessories', 10, 'Dolls', 1),
(11, 400, 'Action Figure Parts', 11, 'Animals', 1),
(12, 500, 'Board Game Pieces', 12, 'Construction toys', 2),
(13, 600, 'Toy Train Components', 13, 'car', 1),
(14, 300, 'Building Block Sets', 14, 'Construction toys', 1),
(15, 400, 'Kite Frame', 15, 'Dolls', 2),
(16, 500, 'Water Gun Mechanism', 16, 'car', 1),
(17, 600, 'Mini Basketball Parts', 17, 'Dolls', 2),
(18, 700, 'Remote Control Parts', 18, 'car', 1),
(19, 800, 'Toy Kitchen Components', 19, 'Food-related toys', 2),
(20, 900, 'Play Dough Colors', 20, 'Food-related toys', 1),
(21, 500, 'Stuffed Bear Filling', 21, 'Animals', 1),
(22, 600, 'Toy Drum Parts', 22, 'Dolls', 2),
(23, 700, 'Drawing Board Components', 23, 'Construction toys', 1),
(24, 800, 'Helicopter Blades', 24, 'car', 1),
(25, 900, 'Fishing Game Items', 25, 'Food-related toys', 2),
(26, 500, 'Puzzle Cube Pieces', 26, 'Construction toys', 1),
(27, 600, 'Gardening Set Tools', 27, 'Dolls', 2),
(28, 700, 'Airplane Parts', 28, 'car', 1),
(29, 800, 'Candy Game Items', 29, 'Food-related toys', 2),
(30, 900, 'Castle Pieces', 30, 'Dolls', 1);

CREATE TABLE `internaltransferform` (
  `TransferFormNumber` int(8) NOT NULL,
  `DateOfInitiation` date NOT NULL DEFAULT current_timestamp(),
  `DestinationDepartment` varchar(20) NOT NULL,
  `TransferSource` varchar(20) NOT NULL,
  `TransferItemType` enum('Product','Material','Component','') NOT NULL,
  `TransferItemName` varchar(30) NOT NULL,
  `TransferAmount` int(4) NOT NULL,
  `OrderID` int(8) NOT NULL,
  `Descriptions` varchar(1000) NOT NULL,
  `Specifications` varchar(1000) NOT NULL,
  `TransferReason` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `internaltransferform` (`TransferFormNumber`, `DateOfInitiation`, `DestinationDepartment`, `TransferSource`, `TransferItemType`, `TransferItemName`, `TransferAmount`, `OrderID`, `Descriptions`, `Specifications`, `TransferReason`) VALUES
(1, '2025-06-01', 'Production', 'Warehouse A', 'Product', 'Toy Car Component', 100, 1, 'Transfer for production', 'Plastic, Red', 'Stock replenishment'),
(2, '2025-06-02', 'R&D Team', 'Warehouse B', 'Material', 'Cotton for plush toys', 50, 2, 'Transfer for testing', 'Soft cotton fabric', 'New design testing'),
(3, '2025-06-03', 'Production', 'Warehouse A', 'Component', 'Construction Set Parts', 75, 3, 'Transfer for assembly', 'Various parts', 'Assembly line needs');

CREATE TABLE `material` (
  `MaterialID` int(8) NOT NULL,
  `TotalAmount` int(8) NOT NULL,
  `Price` int(4) NOT NULL,
  `WHID` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `material` (`MaterialID`, `TotalAmount`, `Price`, `WHID`) VALUES
(1, 1000, 5, 1),
(2, 500, 10, 1),
(3, 300, 20, 2),
(4, 400, 15, 1),
(5, 600, 8, 2),
(6, 700, 12, 1),
(7, 800, 6, 2),
(8, 900, 7, 1),
(9, 200, 25, 1),
(10, 250, 18, 2),
(11, 150, 30, 1),
(12, 350, 14, 2),
(13, 450, 9, 1),
(14, 500, 11, 2),
(15, 600, 13, 1),
(16, 700, 12, 2),
(17, 800, 10, 1),
(18, 900, 15, 2),
(19, 1000, 8, 1),
(20, 1100, 12, 2),
(21, 1200, 20, 1),
(22, 1300, 18, 2),
(23, 1400, 14, 1),
(24, 1500, 16, 2),
(25, 1600, 11, 1),
(26, 1700, 9, 2),
(27, 1800, 15, 1),
(28, 1900, 13, 2),
(29, 2000, 20, 1),
(30, 2100, 17, 2);

CREATE TABLE `materialrequirementform` (
  `MaterialFormID` int(8) NOT NULL,
  `IssuanceDate` date NOT NULL,
  `ProductID` int(8) NOT NULL,
  `Descriptions` varchar(1000) NOT NULL,
  `Specification` varchar(1000) NOT NULL,
  `MaterialID` int(8) NOT NULL,
  `MaterialAmount` int(4) NOT NULL,
  `PriorityLevel` enum('normal','emergency','','') NOT NULL,
  `DeliveryDate` date NOT NULL DEFAULT current_timestamp(),
  `Remarks` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `materialrequirementform` (`MaterialFormID`, `IssuanceDate`, `ProductID`, `Descriptions`, `Specification`, `MaterialID`, `MaterialAmount`, `PriorityLevel`, `DeliveryDate`, `Remarks`) VALUES
(1, '2025-06-05', 1, 'Plastic for toy cars', 'High-quality plastic', 1, 50, 'normal', '2025-06-10', NULL),
(2, '2025-06-06', 2, 'Cotton for plush toys', 'Soft cotton fabric', 2, 30, 'emergency', '2025-06-11', NULL),
(3, '2025-06-07', 3, 'Wood for construction sets', 'Durable wooden material', 3, 20, 'normal', '2025-06-12', NULL);

CREATE TABLE `product` (
  `ProductID` int(8) NOT NULL,
  `ProductName` varchar(20) NOT NULL,
  `ProductPrice` int(4) NOT NULL,
  `ProductType` enum('car','Animals','Construction toys','Dolls','Food-related toys') NOT NULL,
  `ProductAmount` int(4) NOT NULL,
  `ProductionType` enum('designed by the company','requested by customers','','') NOT NULL,
  `Descriptions` varchar(40) NOT NULL,
  `ProductStatus` varchar(1000) NOT NULL,
  `Specification` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `product` (`ProductID`, `ProductName`, `ProductPrice`, `ProductType`, `ProductAmount`, `ProductionType`, `Descriptions`, `ProductStatus`, `Specification`) VALUES
(1, 'Toy Car', 150, 'car', 100, 'designed by the company', 'A small toy car for kids', 'Available', 'Plastic, Red'),
(2, 'Animal Plush', 200, 'Animals', 50, 'requested by customers', 'A soft plush toy', 'Available', 'Cotton, Various Colors'),
(3, 'Construction Set', 300, 'Construction toys', 75, 'designed by the company', 'Build your own structures', 'Available', 'Plastic, Various Parts'),
(4, 'Doll House', 450, 'Dolls', 30, 'designed by the company', 'A beautiful doll house', 'Available', 'Wood, Multi-color'),
(5, 'Car Racing Track', 500, 'car', 20, 'requested by customers', 'A racing track for toy cars', 'Available', 'Plastic, Black'),
(6, 'Animal Figures', 250, 'Animals', 100, 'designed by the company', 'Set of animal figures', 'Available', 'Plastic, Various'),
(7, 'Food-related Toy Set', 350, 'Food-related toys', 60, 'designed by the company', 'A toy food set', 'Available', 'Plastic, Multi-color'),
(8, 'Robot Toy', 400, 'car', 40, 'requested by customers', 'A fun robot toy', 'Available', 'Metal, Silver'),
(9, 'Puzzle Game', 150, 'Construction toys', 80, 'designed by the company', 'A challenging puzzle game', 'Available', 'Cardboard, Multi-color'),
(10, 'Magic Set', 300, 'Dolls', 25, 'requested by customers', 'A set of magic tricks', 'Available', 'Plastic, Various'),
(11, 'Action Figures', 200, 'Animals', 90, 'designed by the company', 'Superhero action figures', 'Available', 'Plastic, Various'),
(12, 'Board Game', 250, 'Construction toys', 55, 'designed by the company', 'A family board game', 'Available', 'Cardboard, Multi-color'),
(13, 'Toy Train', 350, 'car', 70, 'requested by customers', 'A toy train set', 'Available', 'Plastic, Red'),
(14, 'Building Blocks', 180, 'Construction toys', 120, 'designed by the company', 'Colorful building blocks', 'Available', 'Plastic, Various'),
(15, 'Kite', 100, 'Dolls', 40, 'designed by the company', 'A colorful kite', 'Available', 'Fabric, Multi-color'),
(16, 'Water Gun', 150, 'car', 60, 'designed by the company', 'A fun water gun', 'Available', 'Plastic, Blue'),
(17, 'Mini Basketball Set', 200, 'Dolls', 30, 'requested by customers', 'Mini basketball for kids', 'Available', 'Plastic, Multi-color'),
(18, 'Remote Control Car', 400, 'car', 20, 'designed by the company', 'A fast remote control car', 'Available', 'Plastic, Red'),
(19, 'Toy Kitchen Set', 250, 'Food-related toys', 50, 'designed by the company', 'A toy kitchen set', 'Available', 'Plastic, Multi-color'),
(20, 'Play Dough Set', 120, 'Food-related toys', 100, 'requested by customers', 'A set of colorful play dough', 'Available', 'Plastic, Various'),
(21, 'Stuffed Bear', 300, 'Animals', 45, 'designed by the company', 'A large stuffed bear', 'Available', 'Cotton, Brown'),
(22, 'Toy Drum', 180, 'Dolls', 60, 'requested by customers', 'A colorful toy drum', 'Available', 'Plastic, Various'),
(23, 'Magic Drawing Board', 200, 'Construction toys', 80, 'designed by the company', 'A drawing board with magic features', 'Available', 'Plastic, Multi-color'),
(24, 'Toy Helicopter', 350, 'car', 30, 'requested by customers', 'A flying toy helicopter', 'Available', 'Plastic, Yellow'),
(25, 'Fishing Game', 150, 'Food-related toys', 70, 'designed by the company', 'A fun fishing game', 'Available', 'Plastic, Multi-color'),
(26, 'Puzzle Cube', 220, 'Construction toys', 55, 'designed by the company', 'A challenging puzzle cube', 'Available', 'Plastic, Various'),
(27, 'Gardening Set', 170, 'Dolls', 40, 'requested by customers', 'A toy gardening set', 'Available', 'Plastic, Green'),
(28, 'Toy Airplane', 300, 'car', 20, 'designed by the company', 'A toy airplane that flies', 'Available', 'Plastic, White'),
(29, 'Candy Land Game', 250, 'Food-related toys', 50, 'designed by the company', 'A fun board game', 'Available', 'Cardboard, Multi-color'),
(30, 'Toy Castle', 400, 'Dolls', 30, 'requested by customers', 'A large toy castle', 'Available', 'Plastic, Multi-color');

CREATE TABLE `productorder` (
  `ProductionOrderID` int(8) NOT NULL,
  `IssueDate` date NOT NULL,
  `StaffID` int(8) NOT NULL,
  `FacilitiesID` int(8) NOT NULL,
  `ProductID` int(8) NOT NULL,
  `ProductName` varchar(20) NOT NULL,
  `Descriptions` varchar(1000) NOT NULL,
  `ProductSpecifications` varchar(1000) NOT NULL,
  `StartDate` date NOT NULL DEFAULT current_timestamp(),
  `EndDate` date NOT NULL DEFAULT current_timestamp(),
  `WorkInstructions` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `quotation` (
  `QuotationID` int(8) NOT NULL,
  `DateOfIssuance` date NOT NULL,
  `ClientID` int(9) NOT NULL,
  `ClientName` varchar(20) NOT NULL,
  `ClientAddress` varchar(30) NOT NULL,
  `ProductID` int(8) NOT NULL,
  `ProductName` varchar(20) NOT NULL,
  `QuotationPrice` int(8) NOT NULL,
  `DeliveryTimeframes` date NOT NULL DEFAULT current_timestamp(),
  `ShippingOptions` enum('Land Transportation','Air Way','Marine Transport','') NOT NULL,
  `StaffID` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `quotation` (`QuotationID`, `DateOfIssuance`, `ClientID`, `ClientName`, `ClientAddress`, `ProductID`, `ProductName`, `QuotationPrice`, `DeliveryTimeframes`, `ShippingOptions`, `StaffID`) VALUES
(1, '2025-06-01', 1, 'Alice Chan', '123 Nathan Road, Kowloon, HK', 1, 'Toy Car', 450, '2025-06-10', 'Land Transportation', 1),
(2, '2025-06-02', 2, 'Bob Lee', '456 Queen\'s Road, Central, HK', 2, 'Animal Plush', 400, '2025-06-11', 'Air Way', 2),
(3, '2025-06-03', 3, 'Cathy Wong', '789 King\'s Road, North Point, ', 3, 'Construction Set', 300, '2025-06-12', 'Marine Transport', 3);

CREATE TABLE `staff` (
  `StaffID` int(11) NOT NULL,
  `StaffName` varchar(40) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `PhoneNum` varchar(12) NOT NULL,
  `DeptID` int(2) NOT NULL,
  `JobTitle` varchar(50) NOT NULL,
  `Salary` int(8) NOT NULL,
  `Gender` enum('Male','Female','','') NOT NULL,
  `Address` varchar(30) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `JoinDate` date NOT NULL,
  `DateOfBirth` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `staff` (`StaffID`, `StaffName`, `Password`, `PhoneNum`, `DeptID`, `JobTitle`, `Salary`, `Gender`, `Address`, `Email`, `JoinDate`, `DateOfBirth`) VALUES
(1, 'root', '4813494d137e1631bba301d5acab6e7bb7aa74ce1185d456565ef51d737677b2', '', 1, '', 0, '', '', '', '0000-00-00', '0000-00-00'),
(2, 'peter', '026ad9b14a7453b7488daa0c6acbc258b1506f52c441c7c465474c1a564394ff', '', 2, '', 0, '', '', '', '0000-00-00', '0000-00-00'),
(3, 'alex', '4135aa9dc1b842a653dea846903ddb95bfb8c5a10c504a7fa16e10bc31d1fdf0', '', 3, '', 0, '', '', '', '0000-00-00', '0000-00-00'),
(4, 'merry', 'fc261a5e3e3c85a419825aad1ced0df53b9a3fa69bd439d1610eb99f8de6bcd6', '', 4, '', 0, '', '', '', '0000-00-00', '0000-00-00'),
(5, 'sam', 'e96e02d8e47f2a7c03be5117b3ed175c52aa30fb22028cf9c96f261563577605', '', 5, '', 0, '', '', '', '0000-00-00', '0000-00-00'),
(6, 'jason', '06b9a6eacd7a77b9361123fd19776455eb16b9c83426a1abbf514a414792b73f', '', 6, '', 0, '', '', '', '0000-00-00', '0000-00-00'),
(7, 'tom', 'e1608f75c5d7813f3d4031cb30bfb786507d98137538ff8e128a6ff74e84e643', '', 7, '', 0, '', '', '', '0000-00-00', '0000-00-00');

CREATE TABLE `transportation` (
  `TransportationID` int(8) NOT NULL,
  `CarriersName` varchar(50) NOT NULL,
  `CarriersContactNum` varchar(12) NOT NULL,
  `CarriersEmail` varchar(30) NOT NULL,
  `CargoStatus` varchar(50) NOT NULL,
  `DeliveryTimes` date NOT NULL DEFAULT current_timestamp(),
  `OrderID` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `transportation` (`TransportationID`, `CarriersName`, `CarriersContactNum`, `CarriersEmail`, `CargoStatus`, `DeliveryTimes`, `OrderID`) VALUES
(1, 'Speedy Couriers', '93456789', 'contact@speedycouriers.com', 'In Transit', '2025-06-10', 1),
(2, 'Ocean Freight', '94567890', 'info@oceanfreight.com', 'Scheduled', '2025-06-11', 2),
(3, 'Air Express', '95678901', 'support@airexpress.com', 'Delivered', '2025-06-12', 3);

CREATE TABLE `warehouse` (
  `WHID` int(8) NOT NULL,
  `WHLocation` varchar(20) NOT NULL,
  `StaffID` int(8) NOT NULL,
  `WHContactNum` varchar(12) NOT NULL,
  `WHEmail` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `warehouse` (`WHID`, `WHLocation`, `StaffID`, `WHContactNum`, `WHEmail`) VALUES
(1, 'Central Warehouse', 1, '91234567', 'central.warehouse@example.com'),
(2, 'Kowloon Warehouse', 2, '92345678', 'kowloon.warehouse@example.com');


ALTER TABLE `afterservicefeedback`
  ADD PRIMARY KEY (`feedbackID`),
  ADD KEY `fk_afterservicefeedback_StaffID` (`StaffID`);

ALTER TABLE `clientinformation`
  ADD PRIMARY KEY (`ClientID`);

ALTER TABLE `customerorder`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `fk_customerorder_StaffID` (`StaffID`),
  ADD KEY `fk_customerorder_ClientID` (`ClientID`),
  ADD KEY `fk_customerorder_ProductID` (`ProductID`);

ALTER TABLE `damagematerial`
  ADD PRIMARY KEY (`DamMatID`),
  ADD KEY `fk_damagematerial_StaffID` (`StaffID`);

ALTER TABLE `department`
  ADD PRIMARY KEY (`DeptID`);

ALTER TABLE `event`
  ADD PRIMARY KEY (`event_id`);

ALTER TABLE `facilities`
  ADD PRIMARY KEY (`FacilitiesID`),
  ADD KEY `fk_facilities_StaffID` (`StaffID`);

ALTER TABLE `finishedcomponent`
  ADD PRIMARY KEY (`FCID`),
  ADD KEY `fk_finishedcomponent_ProductID` (`ProductID`),
  ADD KEY `fk_finishedcomponent_WHID` (`WHID`);

ALTER TABLE `internaltransferform`
  ADD PRIMARY KEY (`TransferFormNumber`),
  ADD KEY `fk-internaltransferform_OrderID` (`OrderID`);

ALTER TABLE `material`
  ADD PRIMARY KEY (`MaterialID`),
  ADD KEY `fk_material_WHID` (`WHID`);

ALTER TABLE `materialrequirementform`
  ADD PRIMARY KEY (`MaterialFormID`),
  ADD KEY `fk_materialrequirementform_MaterialID` (`MaterialID`),
  ADD KEY `fk_materialrequirementform_ProductID` (`ProductID`);

ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`);

ALTER TABLE `productorder`
  ADD PRIMARY KEY (`ProductionOrderID`),
  ADD KEY `fk_productorder_StaffID` (`StaffID`),
  ADD KEY `fk_productorder_FacilitiesID` (`FacilitiesID`),
  ADD KEY `fk_fk_productorder_FacilitiesID_ProductID` (`ProductID`);

ALTER TABLE `quotation`
  ADD PRIMARY KEY (`QuotationID`),
  ADD KEY `fk_quotation_ClientID` (`ClientID`),
  ADD KEY `fk_quotation_ProductID` (`ProductID`),
  ADD KEY `fk_quotation_StaffID` (`StaffID`);

ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`),
  ADD KEY `fk_staff_DeptID` (`DeptID`);

ALTER TABLE `transportation`
  ADD PRIMARY KEY (`TransportationID`),
  ADD KEY `fk_transportation_OrderID` (`OrderID`);

ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`WHID`),
  ADD KEY `fk_warehouse_StaffID` (`StaffID`);


ALTER TABLE `afterservicefeedback`
  MODIFY `feedbackID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

ALTER TABLE `clientinformation`
  MODIFY `ClientID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

ALTER TABLE `customerorder`
  MODIFY `OrderID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `damagematerial`
  MODIFY `DamMatID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

ALTER TABLE `department`
  MODIFY `DeptID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

ALTER TABLE `event`
  MODIFY `event_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=178;

ALTER TABLE `facilities`
  MODIFY `FacilitiesID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `finishedcomponent`
  MODIFY `FCID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

ALTER TABLE `internaltransferform`
  MODIFY `TransferFormNumber` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `material`
  MODIFY `MaterialID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

ALTER TABLE `materialrequirementform`
  MODIFY `MaterialFormID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `product`
  MODIFY `ProductID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

ALTER TABLE `productorder`
  MODIFY `ProductionOrderID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `quotation`
  MODIFY `QuotationID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `staff`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

ALTER TABLE `transportation`
  MODIFY `TransportationID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `warehouse`
  MODIFY `WHID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;


ALTER TABLE `afterservicefeedback`
  ADD CONSTRAINT `fk_afterservicefeedback_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

ALTER TABLE `customerorder`
  ADD CONSTRAINT `fk_customerorder_ClientID` FOREIGN KEY (`ClientID`) REFERENCES `clientinformation` (`ClientID`),
  ADD CONSTRAINT `fk_customerorder_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `fk_customerorder_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

ALTER TABLE `damagematerial`
  ADD CONSTRAINT `fk_damagematerial_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

ALTER TABLE `facilities`
  ADD CONSTRAINT `fk_facilities_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

ALTER TABLE `finishedcomponent`
  ADD CONSTRAINT `fk_finishedcomponent_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `fk_finishedcomponent_WHID` FOREIGN KEY (`WHID`) REFERENCES `warehouse` (`WHID`);

ALTER TABLE `internaltransferform`
  ADD CONSTRAINT `fk-internaltransferform_OrderID` FOREIGN KEY (`OrderID`) REFERENCES `customerorder` (`OrderID`);

ALTER TABLE `material`
  ADD CONSTRAINT `fk_material_WHID` FOREIGN KEY (`WHID`) REFERENCES `warehouse` (`WHID`);

ALTER TABLE `materialrequirementform`
  ADD CONSTRAINT `fk_materialrequirementform_MaterialID` FOREIGN KEY (`MaterialID`) REFERENCES `material` (`MaterialID`),
  ADD CONSTRAINT `fk_materialrequirementform_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

ALTER TABLE `productorder`
  ADD CONSTRAINT `fk_fk_productorder_FacilitiesID_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `fk_productorder_FacilitiesID` FOREIGN KEY (`FacilitiesID`) REFERENCES `facilities` (`FacilitiesID`),
  ADD CONSTRAINT `fk_productorder_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

ALTER TABLE `quotation`
  ADD CONSTRAINT `fk_quotation_ClientID` FOREIGN KEY (`ClientID`) REFERENCES `clientinformation` (`ClientID`),
  ADD CONSTRAINT `fk_quotation_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `fk_quotation_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

ALTER TABLE `staff`
  ADD CONSTRAINT `fk_staff_DeptID` FOREIGN KEY (`DeptID`) REFERENCES `department` (`DeptID`);

ALTER TABLE `transportation`
  ADD CONSTRAINT `fk_transportation_OrderID` FOREIGN KEY (`OrderID`) REFERENCES `customerorder` (`OrderID`);

ALTER TABLE `warehouse`
  ADD CONSTRAINT `fk_warehouse_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

GRANT ALL PRIVILEGES ON `default`.* TO 'user'@'%' IDENTIFIED BY '6wS1Ah753ylT';
GRANT ALL PRIVILEGES ON `projectdb`.* TO 'user'@'%' IDENTIFIED BY '6wS1Ah753ylT';
FLUSH PRIVILEGES;

COMMIT;


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
