/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : mymusic

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-06-28 15:34:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `musicorder`
-- ----------------------------
DROP TABLE IF EXISTS `musicorder`;
CREATE TABLE `musicorder` (
  `OrderId` int(11) NOT NULL AUTO_INCREMENT,
  `OrderDate` datetime NOT NULL,
  `Username` varchar(256) DEFAULT NULL,
  `FirstName` varchar(160) DEFAULT NULL,
  `LastName` varchar(160) DEFAULT NULL,
  `Address` varchar(70) DEFAULT NULL,
  `City` varchar(40) DEFAULT NULL,
  `State` varchar(40) DEFAULT NULL,
  `PostalCode` varchar(10) DEFAULT NULL,
  `Country` varchar(40) DEFAULT NULL,
  `Phone` varchar(24) DEFAULT NULL,
  `Email` varchar(160) DEFAULT NULL,
  `Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`OrderId`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of musicorder
-- ----------------------------
INSERT INTO `musicorder` VALUES ('1', '2017-03-23 15:08:58', 'admin', 'qwe', 'qwe', 'www', 'qwe', 'qwe', 'qwee', 'qw221', '1234123', '123@122.com', '1.00');
INSERT INTO `musicorder` VALUES ('2', '2017-03-23 15:33:41', 'admin', '123', '123', '33331', '1233', 'sdsd', '1123', '12333', '123332123', '123@123.com', '12.00');
INSERT INTO `musicorder` VALUES ('3', '2017-03-23 15:39:47', 'admin', '123', '123', '33331', '1233', 'sdsd', '1123', '12333', '123332123', '123@123.com', '12.00');
INSERT INTO `musicorder` VALUES ('4', '2017-03-23 15:44:59', 'admin', 'qwe', 'qwe', 'qwe', 'qe', 'qwe', 'qwe', 'qee', '12312333', '122@123.com', '1.00');
INSERT INTO `musicorder` VALUES ('5', '2017-03-23 15:46:43', 'admin', 'qwe', 'qwe', 'qwe', 'qe', 'qwe', 'qwe', 'qee', '12312333', '122@123.com', '1.00');
INSERT INTO `musicorder` VALUES ('6', '2017-03-23 15:53:10', 'admin', 'qwe', 'qee', 'qwee', 'qwee', 'wwww', 'qwee', 'qerr', '123321223', '1233@112.com', '1.00');
INSERT INTO `musicorder` VALUES ('7', '2017-03-23 17:03:16', 'admin', 'dd', 'asd', 'ad', 'wwe', 'sdad', 'aasd', 'asd', '1233212', '122@123.com', '1.00');
INSERT INTO `musicorder` VALUES ('8', '2017-03-23 17:07:46', 'admin', 's', 'asd', 'asd', 'ad', 'as', 'as', 'asd', '233', '123@122.com', '1.00');
INSERT INTO `musicorder` VALUES ('9', '2017-03-23 17:09:08', 'admin', 's', 'asd', 'asd', 'ad', 'as', 'as', 'asd', '233', '123@122.com', '1.00');
INSERT INTO `musicorder` VALUES ('10', '2017-03-23 17:09:27', 'admin', 's', 'asd', 'asd', 'ad', 'as', 'as', 'asd', '233', '123@122.com', '1.00');
INSERT INTO `musicorder` VALUES ('11', '2017-03-23 17:09:37', 'admin', 's', 'asd', 'asd', 'ad', 'as', 'as', 'asd', '233', '123@122.com', '1.00');
INSERT INTO `musicorder` VALUES ('12', '2017-03-23 17:14:48', 'admin', 'd', 'asd', 'asd', 'asd', 'asd', 'asd', 'asd', '1233321', '123@2.com', '1.00');
INSERT INTO `musicorder` VALUES ('13', '2017-03-23 17:23:43', 'admin', 'sdf', 'sdf', 'se', 'wer', 'sdf', 'sdf', 'sdf', '12131313', '123@13.com', '1.00');
INSERT INTO `musicorder` VALUES ('14', '2017-03-23 17:30:19', 'admin', 'asd', 'asd', 'asd', 'ad', 'ad', 'asd', 'dd', '123233', '123@123.com', '1.00');
INSERT INTO `musicorder` VALUES ('15', '2017-03-23 17:32:44', 'admin', 'df', 'sdf', 'sf', 'sdf', 'sdf', 'sdf', 'sf', '12313', '123@123.com', '1.00');
INSERT INTO `musicorder` VALUES ('16', '2017-03-23 17:35:27', 'admin', 'sdsf', 'sdfs', 'sdf', 'qqw', 'sf', 'sdf', 'sdf', '1233', '133@123.com', '1.00');
INSERT INTO `musicorder` VALUES ('17', '2017-03-24 15:29:29', 'admin', '123', '133', '123', '123', '123', '13', '13', '12333212', '123@1.com', '1.00');
