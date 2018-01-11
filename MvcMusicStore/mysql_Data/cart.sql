/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : mymusic

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-06-28 15:34:25
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `cart`
-- ----------------------------
DROP TABLE IF EXISTS `cart`;
CREATE TABLE `cart` (
  `RecordId` int(11) NOT NULL AUTO_INCREMENT,
  `CartId` varchar(50) NOT NULL,
  `AlbumId` int(11) NOT NULL,
  `Count` int(11) NOT NULL,
  `DateCreated` datetime NOT NULL,
  PRIMARY KEY (`RecordId`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cart
-- ----------------------------
INSERT INTO `cart` VALUES ('1', '1', '386', '1', '2017-03-20 13:43:33');
INSERT INTO `cart` VALUES ('2', '2', '387', '2', '2017-03-20 13:43:54');
INSERT INTO `cart` VALUES ('3', '1', '387', '2', '2017-03-20 13:44:45');
INSERT INTO `cart` VALUES ('4', '9868b44b-c401-4da3-b8a9-acb8821a59d5', '390', '1', '2017-03-20 16:51:30');
INSERT INTO `cart` VALUES ('5', '5b2126e1-506f-4394-bcd0-a0601f0b3619', '388', '1', '2017-03-20 17:01:59');
INSERT INTO `cart` VALUES ('6', '5665a7c0-5753-4ba5-bbe2-b589dc499d0b', '660', '2', '2017-03-20 17:09:56');
INSERT INTO `cart` VALUES ('7', '8c2e56f5-b533-4f0c-96b6-02b3fa5ba475', '388', '1', '2017-03-20 17:48:39');
INSERT INTO `cart` VALUES ('8', '6caa199d-d6b2-4fbf-9ac4-e1188b69b516', '665', '1', '2017-03-21 09:38:20');
INSERT INTO `cart` VALUES ('9', '0ad40a89-5286-40b4-b5a2-bfda7bc0816e', '402', '1', '2017-03-21 10:50:25');
INSERT INTO `cart` VALUES ('10', '46717626-e8d3-4762-8753-e377993fe7a9', '610', '1', '2017-03-21 11:10:18');
INSERT INTO `cart` VALUES ('11', '554a1cb2-3383-4b78-8360-f427318b1ee1', '667', '1', '2017-03-21 11:41:29');
INSERT INTO `cart` VALUES ('12', '62875d52-0548-4214-a524-07b767a164ac', '393', '7', '2017-03-21 13:29:32');
INSERT INTO `cart` VALUES ('13', '811794d5-5d2e-43b0-979b-19e2c4d7def8', '394', '2', '2017-03-21 13:55:33');
INSERT INTO `cart` VALUES ('14', '811794d5-5d2e-43b0-979b-19e2c4d7def8', '630', '1', '2017-03-21 13:56:44');
INSERT INTO `cart` VALUES ('15', '811794d5-5d2e-43b0-979b-19e2c4d7def8', '666', '1', '2017-03-21 14:00:18');
INSERT INTO `cart` VALUES ('18', '3c1c57ad-42d1-4094-8670-0ed8c1c9d156', '612', '1', '2017-03-23 14:11:51');
INSERT INTO `cart` VALUES ('19', '055ed5ac-9ce4-42aa-9982-d6d29d810c34', '663', '1', '2017-03-23 14:27:19');
INSERT INTO `cart` VALUES ('21', '452b4aa6-d262-418a-b59e-a4ebabef27c7', '610', '1', '2017-03-24 15:28:15');
INSERT INTO `cart` VALUES ('22', '452b4aa6-d262-418a-b59e-a4ebabef27c7', '609', '1', '2017-03-24 15:28:19');
INSERT INTO `cart` VALUES ('23', 'admin', '611', '1', '2017-03-24 15:47:10');
INSERT INTO `cart` VALUES ('24', 'admin', '610', '1', '2017-03-24 15:47:18');
INSERT INTO `cart` VALUES ('25', 'a5ca1bac-a9bd-4258-ad9a-46837099fc45', '661', '1', '2017-06-15 15:36:19');
