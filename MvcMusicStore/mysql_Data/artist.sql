/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : mymusic

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-06-28 15:34:17
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `artist`
-- ----------------------------
DROP TABLE IF EXISTS `artist`;
CREATE TABLE `artist` (
  `ArtistId` int(11) NOT NULL,
  `Name` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`ArtistId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of artist
-- ----------------------------
INSERT INTO `artist` VALUES ('1', 'AC/DC');
INSERT INTO `artist` VALUES ('2', 'Accept');
INSERT INTO `artist` VALUES ('3', 'Aerosmith');
INSERT INTO `artist` VALUES ('4', 'Alanis Morissette');
INSERT INTO `artist` VALUES ('5', 'Alice In Chains');
INSERT INTO `artist` VALUES ('6', 'Ant?nio Carlos Jobim');
INSERT INTO `artist` VALUES ('7', 'Apocalyptica');
INSERT INTO `artist` VALUES ('8', 'Audioslave');
INSERT INTO `artist` VALUES ('10', 'Billy Cobham');
INSERT INTO `artist` VALUES ('11', 'Black Label Society');
INSERT INTO `artist` VALUES ('12', 'Black Sabbath');
INSERT INTO `artist` VALUES ('14', 'Bruce Dickinso');
INSERT INTO `artist` VALUES ('15', 'Buddy Guy');
INSERT INTO `artist` VALUES ('16', 'Caetano Veloso');
INSERT INTO `artist` VALUES ('17', 'Chico Buarque');
INSERT INTO `artist` VALUES ('18', 'Chico Science & Na??o Zumbi');
INSERT INTO `artist` VALUES ('19', 'Cidade Negra');
INSERT INTO `artist` VALUES ('20', 'Cláudio Zoli');
INSERT INTO `artist` VALUES ('21', 'Various Artists');
INSERT INTO `artist` VALUES ('22', 'Led Zeppeli');
INSERT INTO `artist` VALUES ('23', 'Frank Zappa & Captain Beefheart');
INSERT INTO `artist` VALUES ('24', 'Marcos Valle');
INSERT INTO `artist` VALUES ('27', 'Gilberto Gil');
INSERT INTO `artist` VALUES ('37', 'Ed Motta');
INSERT INTO `artist` VALUES ('41', 'Elis Regina');
INSERT INTO `artist` VALUES ('42', 'Milton Nascimento');
INSERT INTO `artist` VALUES ('46', 'Jorge Be');
INSERT INTO `artist` VALUES ('50', 'Metallica');
INSERT INTO `artist` VALUES ('51', 'Quee');
INSERT INTO `artist` VALUES ('52', 'Kiss');
INSERT INTO `artist` VALUES ('53', 'Spyro Gyra');
INSERT INTO `artist` VALUES ('55', 'David Coverdale');
INSERT INTO `artist` VALUES ('56', 'Gonzaguinha');
INSERT INTO `artist` VALUES ('58', 'Deep Purple');
INSERT INTO `artist` VALUES ('59', 'Santana');
INSERT INTO `artist` VALUES ('68', 'Miles Davis');
INSERT INTO `artist` VALUES ('72', 'Vinícius De Moraes');
INSERT INTO `artist` VALUES ('76', 'Creedence Clearwater Revival');
INSERT INTO `artist` VALUES ('77', 'Cássia Eller');
INSERT INTO `artist` VALUES ('79', 'Dennis Chambers');
INSERT INTO `artist` VALUES ('80', 'Djava');
INSERT INTO `artist` VALUES ('81', 'Eric Clapto');
INSERT INTO `artist` VALUES ('82', 'Faith No More');
INSERT INTO `artist` VALUES ('83', 'Falamansa');
INSERT INTO `artist` VALUES ('84', 'Foo Fighters');
INSERT INTO `artist` VALUES ('86', 'Funk Como Le Gusta');
INSERT INTO `artist` VALUES ('87', 'Godsmack');
INSERT INTO `artist` VALUES ('88', 'Guns \' Roses');
INSERT INTO `artist` VALUES ('89', 'Incognito');
INSERT INTO `artist` VALUES ('90', 'Iron Maide');
INSERT INTO `artist` VALUES ('92', 'Jamiroquai');
INSERT INTO `artist` VALUES ('94', 'Jimi Hendrix');
INSERT INTO `artist` VALUES ('95', 'Joe Satriani');
INSERT INTO `artist` VALUES ('96', 'Jota Quest');
INSERT INTO `artist` VALUES ('98', 'Judas Priest');
INSERT INTO `artist` VALUES ('99', 'Legi?o Urbana');
INSERT INTO `artist` VALUES ('100', 'Lenny Kravitz');
INSERT INTO `artist` VALUES ('101', 'Lulu Santos');
INSERT INTO `artist` VALUES ('102', 'Marillio');
INSERT INTO `artist` VALUES ('103', 'Marisa Monte');
INSERT INTO `artist` VALUES ('105', 'Men At Work');
INSERT INTO `artist` VALUES ('106', 'Mot?rhead');
INSERT INTO `artist` VALUES ('109', 'M?tley Crüe');
INSERT INTO `artist` VALUES ('110', 'Nirvana');
INSERT INTO `artist` VALUES ('111', 'O Ter?o');
INSERT INTO `artist` VALUES ('112', 'Olodum');
INSERT INTO `artist` VALUES ('113', 'Os Paralamas Do Sucesso');
INSERT INTO `artist` VALUES ('114', 'Ozzy Osbourne');
INSERT INTO `artist` VALUES ('115', 'Page & Plant');
INSERT INTO `artist` VALUES ('117', 'Paul D\'Ianno');
INSERT INTO `artist` VALUES ('118', 'Pearl Jam');
INSERT INTO `artist` VALUES ('120', 'Pink Floyd');
INSERT INTO `artist` VALUES ('124', 'R.E.M.');
INSERT INTO `artist` VALUES ('126', 'Raul Seixas');
INSERT INTO `artist` VALUES ('127', 'Red Hot Chili Peppers');
INSERT INTO `artist` VALUES ('128', 'Rush');
INSERT INTO `artist` VALUES ('130', 'Skank');
INSERT INTO `artist` VALUES ('132', 'Soundgarde');
INSERT INTO `artist` VALUES ('133', 'Stevie Ray Vaughan & Double Trouble');
INSERT INTO `artist` VALUES ('134', 'Stone Temple Pilots');
INSERT INTO `artist` VALUES ('135', 'System Of A Dow');
INSERT INTO `artist` VALUES ('136', 'Terry Bozzio, Tony Levin & Steve Stevens');
INSERT INTO `artist` VALUES ('137', 'The Black Crowes');
INSERT INTO `artist` VALUES ('139', 'The Cult');
INSERT INTO `artist` VALUES ('140', 'The Doors');
INSERT INTO `artist` VALUES ('141', 'The Police');
INSERT INTO `artist` VALUES ('142', 'The Rolling Stones');
INSERT INTO `artist` VALUES ('144', 'The Who');
INSERT INTO `artist` VALUES ('145', 'Tim Maia');
INSERT INTO `artist` VALUES ('150', 'U2');
INSERT INTO `artist` VALUES ('151', 'UB40');
INSERT INTO `artist` VALUES ('152', 'Van Hale');
INSERT INTO `artist` VALUES ('153', 'Velvet Revolver');
INSERT INTO `artist` VALUES ('155', 'Zeca Pagodinho');
INSERT INTO `artist` VALUES ('157', 'Dread Zeppeli');
INSERT INTO `artist` VALUES ('179', 'Scorpions');
INSERT INTO `artist` VALUES ('196', 'Cake');
INSERT INTO `artist` VALUES ('197', 'Aisha Duo');
INSERT INTO `artist` VALUES ('200', 'The Posies');
INSERT INTO `artist` VALUES ('201', 'Luciana Souza/Romero Lubambo');
INSERT INTO `artist` VALUES ('202', 'Aaron Goldberg');
INSERT INTO `artist` VALUES ('203', 'Nicolaus Esterhazy Sinfonia');
INSERT INTO `artist` VALUES ('204', 'Temple of the Dog');
INSERT INTO `artist` VALUES ('205', 'Chris Cornell');
INSERT INTO `artist` VALUES ('206', 'Alberto Turco & Nova Schola Gregoriana');
INSERT INTO `artist` VALUES ('208', 'English Concert & Trevor Pinnock');
INSERT INTO `artist` VALUES ('211', 'Wilhelm Kempff');
INSERT INTO `artist` VALUES ('212', 'Yo-Yo Ma');
INSERT INTO `artist` VALUES ('213', 'Scholars Baroque Ensemble');
INSERT INTO `artist` VALUES ('217', 'Royal Philharmonic Orchestra & Sir Thomas Beecham');
INSERT INTO `artist` VALUES ('219', 'Britten Sinfonia, Ivor Bolton & Lesley Garrett');
INSERT INTO `artist` VALUES ('221', 'Sir Georg Solti & Wiener Philharmoniker');
INSERT INTO `artist` VALUES ('223', 'London Symphony Orchestra & Sir Charles Mackerras');
INSERT INTO `artist` VALUES ('224', 'Barry Wordsworth & BBC Concert Orchestra');
INSERT INTO `artist` VALUES ('226', 'Eugene Ormandy');
INSERT INTO `artist` VALUES ('229', 'Boston Symphony Orchestra & Seiji Ozawa');
INSERT INTO `artist` VALUES ('230', 'Aaron Copland & London Symphony Orchestra');
INSERT INTO `artist` VALUES ('231', 'Ton Koopma');
INSERT INTO `artist` VALUES ('232', 'Sergei Prokofiev & Yuri Temirkanov');
INSERT INTO `artist` VALUES ('233', 'Chicago Symphony Orchestra & Fritz Reiner');
INSERT INTO `artist` VALUES ('234', 'Orchestra of The Age of Enlightenment');
INSERT INTO `artist` VALUES ('236', 'James Levine');
INSERT INTO `artist` VALUES ('237', 'Berliner Philharmoniker & Hans Rosbaud');
INSERT INTO `artist` VALUES ('238', 'Maurizio Pollini');
INSERT INTO `artist` VALUES ('240', 'Gustav Mahler');
INSERT INTO `artist` VALUES ('242', 'Edo de Waart & San Francisco Symphony');
INSERT INTO `artist` VALUES ('244', 'Choir Of Westminster Abbey & Simon Presto');
INSERT INTO `artist` VALUES ('245', 'Michael Tilson Thomas & San Francisco Symphony');
INSERT INTO `artist` VALUES ('247', 'The King\'s Singers');
INSERT INTO `artist` VALUES ('248', 'Berliner Philharmoniker & Herbert Von Karaja');
INSERT INTO `artist` VALUES ('250', 'Christopher O\'Riley');
INSERT INTO `artist` VALUES ('251', 'Fretwork');
INSERT INTO `artist` VALUES ('252', 'Amy Winehouse');
INSERT INTO `artist` VALUES ('253', 'Calexico');
INSERT INTO `artist` VALUES ('255', 'Yehudi Menuhi');
INSERT INTO `artist` VALUES ('258', 'Les Arts Florissants & William Christie');
INSERT INTO `artist` VALUES ('259', 'The 12 Cellists of The Berlin Philharmonic');
INSERT INTO `artist` VALUES ('260', 'Adrian Leaper & Doreen de Feis');
INSERT INTO `artist` VALUES ('261', 'Roger Norrington, London Classical Players');
INSERT INTO `artist` VALUES ('264', 'Kent Nagano and Orchestre de l\'Opéra de Lyo');
INSERT INTO `artist` VALUES ('265', 'Julian Bream');
INSERT INTO `artist` VALUES ('266', 'Martin Roscoe');
INSERT INTO `artist` VALUES ('267', 'G?teborgs Symfoniker & Neeme J?rvi');
INSERT INTO `artist` VALUES ('270', 'Gerald Moore');
INSERT INTO `artist` VALUES ('271', 'Mela Tenenbaum, Pro Musica Prague & Richard Kapp');
INSERT INTO `artist` VALUES ('274', 'Nash Ensemble');
INSERT INTO `artist` VALUES ('276', 'Chic');
INSERT INTO `artist` VALUES ('277', 'Anita Ward');
INSERT INTO `artist` VALUES ('278', 'Donna Summer');
