/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : mymusic

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-06-28 15:34:45
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `orderdetail`
-- ----------------------------
DROP TABLE IF EXISTS `orderdetail`;
CREATE TABLE `orderdetail` (
  `OrderDetailId` int(11) NOT NULL AUTO_INCREMENT,
  `OrderId` int(11) NOT NULL,
  `AlbumId` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `UnitPrice` decimal(10,2) NOT NULL,
  PRIMARY KEY (`OrderDetailId`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of orderdetail
-- ----------------------------
INSERT INTO `orderdetail` VALUES ('1', '0', '611', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('2', '0', '611', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('3', '0', '627', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('4', '0', '398', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('5', '0', '611', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('6', '0', '627', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('7', '0', '398', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('8', '0', '611', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('9', '0', '627', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('10', '0', '398', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('11', '0', '611', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('12', '0', '627', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('13', '0', '398', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('14', '0', '394', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('15', '0', '523', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('16', '0', '394', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('17', '0', '523', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('18', '0', '394', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('19', '0', '523', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('20', '0', '590', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('21', '0', '620', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('22', '0', '635', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('23', '15', '634', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('24', '15', '666', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('25', '16', '612', '1', '8.99');
INSERT INTO `orderdetail` VALUES ('26', '17', '637', '1', '8.99');
