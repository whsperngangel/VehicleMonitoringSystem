-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 02, 2020 at 01:29 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vehicle`
--

-- --------------------------------------------------------

--
-- Table structure for table `fuel`
--

CREATE TABLE `fuel` (
  `FuelID` int(11) NOT NULL,
  `PlateNumber` varchar(8) NOT NULL,
  `FuelDate` date NOT NULL,
  `TypeOfFuel` text NOT NULL,
  `InvoiceNumber` text NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `Amount` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `fuel`
--

INSERT INTO `fuel` (`FuelID`, `PlateNumber`, `FuelDate`, `TypeOfFuel`, `InvoiceNumber`, `SupplierID`, `Amount`) VALUES
(1, 'AVA9894', '2020-02-28', 'Diesel', 'dfg345345', 2, 343);

-- --------------------------------------------------------

--
-- Table structure for table `insurance`
--

CREATE TABLE `insurance` (
  `InsuranceID` int(11) NOT NULL,
  `PlateNumber` varchar(8) NOT NULL,
  `Company` text NOT NULL,
  `DurationFrom` date NOT NULL,
  `DurationTo` date NOT NULL,
  `Renewal` date NOT NULL,
  `Amount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `insurance`
--

INSERT INTO `insurance` (`InsuranceID`, `PlateNumber`, `Company`, `DurationFrom`, `DurationTo`, `Renewal`, `Amount`) VALUES
(1, 'AAN 5191', 'Pacific Union IC', '2019-07-01', '2020-01-02', '2020-02-28', 3421),
(2, 'WDS 119', 'Bethel Gen. Insurance & Surety Corp', '2019-01-11', '2020-01-11', '2020-02-11', 123578),
(3, 'HIACE GL', 'Asia United IC', '2020-02-28', '2020-02-28', '2020-02-28', 2341);

-- --------------------------------------------------------

--
-- Table structure for table `maintenance`
--

CREATE TABLE `maintenance` (
  `MaintenanceID` int(11) NOT NULL,
  `PlateNumber` varchar(15) NOT NULL,
  `PartID` int(11) NOT NULL,
  `Status` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `maintenance`
--

INSERT INTO `maintenance` (`MaintenanceID`, `PlateNumber`, `PartID`, `Status`) VALUES
(1, 'AAN 5191', 3, 'For Repair'),
(2, 'AAN 5191', 6, 'On Going Repair'),
(3, 'AAN 5191', 6, 'For Replacement'),
(4, 'AAN 5191', 6, 'Repaired'),
(5, 'CAO 1585', 4, 'On Going Repair'),
(6, 'CAO 1585', 9, 'Replaced'),
(7, 'CAO 1585', 8, 'On Going Repair'),
(8, 'WDS 119', 8, 'For Repair'),
(9, 'WDS 119', 11, 'For Repair'),
(10, 'WDS 119', 12, 'For Replacement'),
(11, 'HIACE GL G', 7, 'For Repair'),
(12, 'HIACE GL G', 7, 'For Replacement'),
(13, 'HIACE GL G', 2, 'On Going Repair');

-- --------------------------------------------------------

--
-- Table structure for table `part`
--

CREATE TABLE `part` (
  `PartID` int(11) NOT NULL,
  `Description` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `part`
--

INSERT INTO `part` (`PartID`, `Description`) VALUES
(1, 'Tire'),
(2, 'Bulb'),
(3, 'Headlight Bulb'),
(4, '265 R20 GOODYEAR'),
(5, 'Bosh Battery'),
(6, 'Fully Syn Oil'),
(7, 'Brake Cleaner'),
(8, 'Oil Filter'),
(9, 'Windshiel'),
(10, 'C Oil'),
(11, 'Air Filter'),
(12, 'Cabin Filter');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `PaymentID` int(11) NOT NULL,
  `StatementID` int(11) NOT NULL,
  `DatePaid` int(11) NOT NULL,
  `AmountPaid` double NOT NULL,
  `PaidBy` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `RegistrationID` int(11) NOT NULL,
  `PlateNumber` varchar(8) NOT NULL,
  `RegisteredName` text NOT NULL,
  `ORNumber` text NOT NULL,
  `ORDate` date NOT NULL,
  `Renewal` date NOT NULL,
  `Amount` double NOT NULL,
  `Remarks` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`RegistrationID`, `PlateNumber`, `RegisteredName`, `ORNumber`, `ORDate`, `Renewal`, `Amount`, `Remarks`) VALUES
(1, 'AAN 5191', 'TFSPH LDS TO JESSIE D. CHAN', 'OR1', '2015-04-09', '2020-02-28', 129083, ''),
(2, 'AVA9894', 'Yichao Zhang', '1206262061', '2014-02-06', '2020-02-28', 129875, '3rd Party Liability/ With duplicate key on hand'),
(3, 'WDS 119', 'FST', '1531128060', '2014-04-03', '2020-02-28', 23456, '3rd Party Liability'),
(4, 'HIACE GL', 'FST', '1627776452', '2019-09-05', '2020-02-28', 65234, 'With duplicate key on hand'),
(5, 'CAO 1585', 'JAMJLE PROPS. SUBIC & DEV. CORP', '1544584963', '2018-03-02', '2020-02-28', 45698, '');

-- --------------------------------------------------------

--
-- Table structure for table `repair`
--

CREATE TABLE `repair` (
  `RepairID` int(11) NOT NULL,
  `MaintenanceID` int(11) NOT NULL,
  `RepairDate` date NOT NULL,
  `TypeOfRepair` text NOT NULL,
  `InvoiceNumber` varchar(15) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `Amount` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `repair`
--

INSERT INTO `repair` (`RepairID`, `MaintenanceID`, `RepairDate`, `TypeOfRepair`, `InvoiceNumber`, `SupplierID`, `Amount`) VALUES
(1, 4, '2020-02-28', 'General', 'GFD34', 3, 2134),
(2, 6, '2020-02-28', 'General', 'FSDF3434', 3, 324234);

-- --------------------------------------------------------

--
-- Table structure for table `repairdetail`
--

CREATE TABLE `repairdetail` (
  `RepairID` int(11) NOT NULL,
  `PartID` int(11) NOT NULL,
  `PurchasedDate` date NOT NULL,
  `Amount` double DEFAULT NULL,
  `InvoiceNumber` varchar(15) NOT NULL,
  `SupplierID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `repairdetail`
--

INSERT INTO `repairdetail` (`RepairID`, `PartID`, `PurchasedDate`, `Amount`, `InvoiceNumber`, `SupplierID`) VALUES
(1, 3, '2020-02-28', 255, 'SF34', 2),
(1, 6, '2020-02-28', 2255, 'SF34', 2),
(2, 9, '2020-02-28', 898, 'DSF34234', 4);

-- --------------------------------------------------------

--
-- Table structure for table `statement`
--

CREATE TABLE `statement` (
  `StatementID` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `Type` text NOT NULL,
  `InvoiceNumber` text NOT NULL,
  `Status` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`) VALUES
(1, 'J2 Tire Center'),
(2, 'Pacific Union'),
(3, 'Ongking'),
(4, 'Toyota'),
(5, 'Bethel Gen'),
(6, 'LTO'),
(7, 'R.E Valdez Auto'),
(8, 'TCY');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle`
--

CREATE TABLE `vehicle` (
  `PlateNumber` varchar(10) NOT NULL,
  `Listing` varchar(50) NOT NULL,
  `Brand` varchar(50) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `CRNumber` varchar(50) NOT NULL,
  `CRDate` date NOT NULL,
  `IssuedTo` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicle`
--

INSERT INTO `vehicle` (`PlateNumber`, `Listing`, `Brand`, `Category`, `CRNumber`, `CRDate`, `IssuedTo`) VALUES
('AAN 5191', 'Boss FST', 'FST1', 'PICK UP', '213625543', '2020-02-28', 'TFSPH LDS TO JESSIE D. CHAN'),
('AVA9894', 'BOSS FST', 'BMW', 'PICK UP', '213625543', '2020-02-28', 'Yichao Zhang'),
('CAO 1585', 'FST', 'BMW 730i', 'Boss FST', '335430944', '2020-02-28', 'JAMJLE PROPS. SUBIC & DEV. CORP'),
('HIACE GL G', 'VAN', '', 'Badihoy', '347266791', '2020-02-28', 'Badihoy'),
('WDS 119', 'Badihoy', 'GMC SAVANA', 'GMC SAVANA', '190918921', '2020-02-28', 'FST');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fuel`
--
ALTER TABLE `fuel`
  ADD PRIMARY KEY (`FuelID`);

--
-- Indexes for table `insurance`
--
ALTER TABLE `insurance`
  ADD PRIMARY KEY (`InsuranceID`);

--
-- Indexes for table `maintenance`
--
ALTER TABLE `maintenance`
  ADD PRIMARY KEY (`MaintenanceID`);

--
-- Indexes for table `part`
--
ALTER TABLE `part`
  ADD PRIMARY KEY (`PartID`),
  ADD UNIQUE KEY `PartID` (`PartID`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PaymentID`);

--
-- Indexes for table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`RegistrationID`);

--
-- Indexes for table `repair`
--
ALTER TABLE `repair`
  ADD PRIMARY KEY (`RepairID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- Indexes for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`PlateNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registration`
--
ALTER TABLE `registration`
  MODIFY `RegistrationID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
