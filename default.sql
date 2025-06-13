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
(1, 1, 1, 'Design', '0001-01-01', 'rhrhreh', 'Email', 'fhjhhhhhhhh', 1, 1),
(2, 1, 1, 'Design', '0001-01-01', 'Email', 'Phone', '1', 1, 1),
(3, 1, 1, 'Quality', '0001-01-01', 'fgagggh', 'Letter', 'egisgbsi', 1, 1);

CREATE TABLE `clientinformation` (
  `ClientID` int(11) NOT NULL,
  `ClientName` varchar(20) NOT NULL,
  `ClientPhoneNum` varchar(12) NOT NULL,
  `ClientEmail` varchar(20) NOT NULL,
  `ClientAddress` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `clientinformation` (`ClientID`, `ClientName`, `ClientPhoneNum`, `ClientEmail`, `ClientAddress`) VALUES
(1, 'peter', '', '', '');

CREATE TABLE `customerorder` (
  `OrderID` int(8) NOT NULL,
  `OrderDate` date NOT NULL DEFAULT current_timestamp(),
  `ClientID` int(8) NOT NULL,
  `ClientName` varchar(20) NOT NULL,
  `Requitement` varchar(100) NOT NULL,
  `ProductID` int(8) NOT NULL,
  `TotalPrice` int(11) NOT NULL,
  `Payment` enum('Credit card','Alipay','Wechat Pay','Bank Transfer','Cheque','Cash') NOT NULL,
  `Delivertype` enum('Land Transportation','Air Way','Marine Transport','') NOT NULL,
  `StaffID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `damagematerial` (
  `DamMatID` int(8) NOT NULL,
  `DamMatName` varchar(20) NOT NULL,
  `DamMatAmount` text NOT NULL,
  `StaffID` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
(1, 'staff_login', '2025-06-12 23:12:05', '', 1),
(2, 'staff_login', '2025-06-12 23:12:42', '', 1),
(3, 'staff_login', '2025-06-12 23:17:34', '', 1),
(4, 'staff_login', '2025-06-12 23:22:57', '', 1),
(5, 'staff_login', '2025-06-12 23:23:17', '', 1),
(6, 'staff_login', '2025-06-13 00:17:53', '', 1),
(7, 'staff_login', '2025-06-13 00:33:03', '', 1),
(8, 'staff_login', '2025-06-13 01:23:10', '', 6),
(9, 'staff_login', '2025-06-13 01:23:42', '', 6),
(10, 'staff_login', '2025-06-13 01:26:47', '', 6),
(11, 'staff_login', '2025-06-13 01:40:00', '', 1),
(12, 'staff_login', '2025-06-13 01:49:47', '', 1),
(13, 'staff_login', '2025-06-13 01:50:16', '', 1),
(14, 'staff_login', '2025-06-13 01:52:33', '', 1),
(15, 'staff_login', '2025-06-13 01:55:27', '', 1),
(16, 'staff_login', '2025-06-13 01:57:45', '', 1),
(17, 'staff_login', '2025-06-13 02:00:50', '', 1),
(18, 'staff_login', '2025-06-13 02:02:13', '', 1),
(19, 'staff_login', '2025-06-13 02:05:42', '', 1),
(20, 'staff_login', '2025-06-13 02:07:18', '', 1),
(21, 'staff_login', '2025-06-13 02:15:22', '', 1),
(22, 'staff_login', '2025-06-13 02:15:43', '', 1),
(23, 'staff_login', '2025-06-13 02:16:36', '', 1);

CREATE TABLE `facilities` (
  `FacilitiesID` int(8) NOT NULL,
  `Location` varchar(20) NOT NULL,
  `StaffID` int(8) NOT NULL,
  `FacilitiesContactNum` varchar(12) NOT NULL,
  `FacilitiesEmail` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `finishedcomponent` (
  `FCID` int(8) NOT NULL,
  `TotalAmount` int(11) NOT NULL,
  `FCName` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `ProductType` enum('car','Animals','Construction toys','Dolls','Food-related toys') NOT NULL,
  `WHID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

CREATE TABLE `material` (
  `MaterialID` int(8) NOT NULL,
  `MWID` varchar(10000) NOT NULL,
  `TotalAmount` int(8) NOT NULL,
  `ProductID` int(8) NOT NULL,
  `Price` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

CREATE TABLE `product` (
  `ProductID` int(8) NOT NULL,
  `ProductName` varchar(20) NOT NULL,
  `ProductPrice` int(4) NOT NULL,
  `ProductType` enum('car','Animals','Construction toys','Dolls','Food-related toys') NOT NULL,
  `ProductAmount` int(4) NOT NULL,
  `ProductionType` enum('designed by the company','requested by customers','','') NOT NULL,
  `Descriptions` int(11) NOT NULL,
  `ProductStatus` varchar(1000) NOT NULL,
  `FCID` int(8) NOT NULL,
  `Specification` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

CREATE TABLE `warehouse` (
  `WHID` int(8) NOT NULL,
  `WHLocation` int(20) NOT NULL,
  `StaffID` int(8) NOT NULL,
  `WHContactNum` varchar(12) NOT NULL,
  `WHEmail` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


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
  ADD KEY `fk_material_ProductID` (`ProductID`);

ALTER TABLE `materialrequirementform`
  ADD PRIMARY KEY (`MaterialFormID`),
  ADD KEY `fk_materialrequirementform_MaterialID` (`MaterialID`),
  ADD KEY `fk_materialrequirementform_ProductID` (`ProductID`);

ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`),
  ADD KEY `fk_product_FCID` (`FCID`);

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
  MODIFY `ClientID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `customerorder`
  MODIFY `OrderID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `damagematerial`
  MODIFY `DamMatID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `department`
  MODIFY `DeptID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

ALTER TABLE `event`
  MODIFY `event_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

ALTER TABLE `facilities`
  MODIFY `FacilitiesID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `finishedcomponent`
  MODIFY `FCID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `internaltransferform`
  MODIFY `TransferFormNumber` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `material`
  MODIFY `MaterialID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `materialrequirementform`
  MODIFY `MaterialFormID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `product`
  MODIFY `ProductID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `productorder`
  MODIFY `ProductionOrderID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `quotation`
  MODIFY `QuotationID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `staff`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

ALTER TABLE `transportation`
  MODIFY `TransportationID` int(8) NOT NULL AUTO_INCREMENT;

ALTER TABLE `warehouse`
  MODIFY `WHID` int(8) NOT NULL AUTO_INCREMENT;


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
  ADD CONSTRAINT `fk_material_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

ALTER TABLE `materialrequirementform`
  ADD CONSTRAINT `fk_materialrequirementform_MaterialID` FOREIGN KEY (`MaterialID`) REFERENCES `material` (`MaterialID`),
  ADD CONSTRAINT `fk_materialrequirementform_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

ALTER TABLE `product`
  ADD CONSTRAINT `fk_product_FCID` FOREIGN KEY (`FCID`) REFERENCES `finishedcomponent` (`FCID`);

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
