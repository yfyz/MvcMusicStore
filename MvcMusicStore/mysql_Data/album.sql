/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : mymusic

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-06-28 15:34:09
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `album`
-- ----------------------------
DROP TABLE IF EXISTS `album`;
CREATE TABLE `album` (
  `AlbumId` int(11) NOT NULL AUTO_INCREMENT,
  `GenreId` int(11) NOT NULL,
  `ArtistId` int(11) NOT NULL,
  `Title` varchar(160) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `AlbumArtUrl` varchar(1024) DEFAULT NULL,
  PRIMARY KEY (`AlbumId`)
) ENGINE=InnoDB AUTO_INCREMENT=671 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of album
-- ----------------------------
INSERT INTO `album` VALUES ('386', '1', '1', 'For Those About To Rock We Salute You', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('387', '1', '1', 'Let There Be Rock', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('388', '1', '100', 'Greatest Hits', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('389', '1', '102', 'Misplaced Childhood', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('390', '1', '105', 'The Best Of Men At Work', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('392', '1', '110', 'Nevermind', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('393', '1', '111', 'Compositores', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('394', '1', '114', 'Bark at the Moon (Remastered)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('395', '1', '114', 'Blizzard of Ozz', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('396', '1', '114', 'Diary of a Madman (Remastered)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('397', '1', '114', 'No More Tears (Remastered)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('398', '1', '114', 'Speak of the Devil', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('399', '1', '115', 'Walking Into Clarksdale', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('400', '1', '117', 'The Beast Live', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('401', '1', '118', 'Live On Two Legs Live', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('402', '1', '118', 'Riot Act', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('403', '1', '118', 'Te', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('404', '1', '118', 'Vs.', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('405', '1', '120', 'Dark Side Of The Moo', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('406', '1', '124', 'New Adventures In Hi-Fi', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('407', '1', '126', 'Raul Seixas', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('408', '1', '127', 'By The Way', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('409', '1', '127', 'Californicatio', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('410', '1', '128', 'Retrospective I (1974-1980)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('411', '1', '130', 'Maquinarama', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('412', '1', '130', 'O Samba Poconé', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('413', '1', '132', 'A-Sides', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('414', '1', '134', 'Core', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('415', '1', '136', '1997 Black Light Syndrome', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('416', '1', '139', 'Beyond Good And Evil', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('418', '1', '140', 'The Doors', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('419', '1', '141', 'The Police Greatest Hits', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('420', '1', '142', 'Hot Rocks, 1964-1971 (Disc 1)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('421', '1', '142', 'No Security', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('422', '1', '142', 'Voodoo Lounge', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('423', '1', '144', 'My Generation - The Very Best Of The Who', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('424', '1', '150', 'Achtung Baby', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('425', '1', '150', 'B-Sides 1980-1990', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('426', '1', '150', 'How To Dismantle An Atomic Bomb', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('427', '1', '150', 'Pop', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('428', '1', '150', 'Rattle And Hum', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('429', '1', '150', 'The Best Of 1980-1990', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('430', '1', '150', 'War', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('431', '1', '150', 'Zooropa', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('432', '1', '152', 'Diver Dow', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('433', '1', '152', 'The Best Of Van Halen, Vol. I', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('434', '1', '152', 'Van Halen III', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('435', '1', '152', 'Van Hale', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('436', '1', '153', 'Contraband', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('437', '1', '157', 'Un-Led-Ed', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('439', '1', '2', 'Balls to the Wall', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('440', '1', '2', 'Restless and Wild', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('441', '1', '200', 'Every Kind of Light', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('442', '1', '22', 'BBC Sessions Disc 1 Live', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('443', '1', '22', 'BBC Sessions Disc 2 Live', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('444', '1', '22', 'Coda', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('445', '1', '22', 'Houses Of The Holy', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('446', '1', '22', 'In Through The Out Door', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('447', '1', '22', 'IV', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('448', '1', '22', 'Led Zeppelin I', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('449', '1', '22', 'Led Zeppelin II', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('450', '1', '22', 'Led Zeppelin III', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('451', '1', '22', 'Physical Graffiti Disc 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('452', '1', '22', 'Physical Graffiti Disc 2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('453', '1', '22', 'Presence', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('454', '1', '22', 'The Song Remains The Same (Disc 1)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('455', '1', '22', 'The Song Remains The Same (Disc 2)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('456', '1', '23', 'Bongo Fury', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('457', '1', '3', 'Big Ones', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('458', '1', '4', 'Jagged Little Pill', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('459', '1', '5', 'Facelift', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('460', '1', '51', 'Greatest Hits I', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('461', '1', '51', 'Greatest Hits II', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('462', '1', '51', 'News Of The World', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('463', '1', '52', 'Greatest Kiss', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('464', '1', '52', 'Unplugged Live', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('465', '1', '55', 'Into The Light', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('466', '1', '58', 'Come Taste The Band', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('467', '1', '58', 'Deep Purple In Rock', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('468', '1', '58', 'Fireball', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('469', '1', '58', 'Machine Head', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('470', '1', '58', 'MK III The Final Concerts Disc 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('471', '1', '58', 'Purpendicular', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('472', '1', '58', 'Slaves And Masters', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('473', '1', '58', 'Stormbringer', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('474', '1', '58', 'The Battle Rages O', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('475', '1', '58', 'The Final Concerts (Disc 2)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('476', '1', '59', 'Santana - As Years Go By', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('477', '1', '59', 'Santana Live', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('478', '1', '59', 'Supernatural', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('479', '1', '76', 'Chronicle, Vol. 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('480', '1', '76', 'Chronicle, Vol. 2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('481', '1', '8', 'Audioslave', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('482', '1', '82', 'King For A Day Fool For A Lifetime', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('483', '1', '84', 'In Your Honor Disc 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('484', '1', '84', 'In Your Honor Disc 2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('485', '1', '84', 'The Colour And The Shape', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('486', '1', '88', 'Appetite for Destructio', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('487', '1', '88', 'Use Your Illusion I', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('488', '1', '90', 'A Matter of Life and Death', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('489', '1', '90', 'Brave New World', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('490', '1', '90', 'Fear Of The Dark', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('491', '1', '90', 'Live At Donington 1992 (Disc 1)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('492', '1', '90', 'Live At Donington 1992 (Disc 2)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('493', '1', '90', 'Rock In Rio CD2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('494', '1', '90', 'The Number of The Beast', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('495', '1', '90', 'The X Factor', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('496', '1', '90', 'Virtual XI', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('497', '1', '92', 'Emergency On Planet Earth', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('498', '1', '94', 'Are You Experienced?', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('499', '1', '95', 'Surfing with the Alien (Remastered)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('500', '10', '203', 'The Best of Beethove', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('504', '10', '208', 'Pachelbel: Canon & Gigue', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('507', '10', '211', 'Bach: Goldberg Variations', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('508', '10', '212', 'Bach: The Cello Suites', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('509', '10', '213', 'Handel: The Messiah (Highlights)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('513', '10', '217', 'Haydn: Symphonies 99 - 104', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('515', '10', '219', 'A Soprano Inspired', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('517', '10', '221', 'Wagner: Favourite Overtures', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('519', '10', '223', 'Tchaikovsky: The Nutcracker', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('520', '10', '224', 'The Last Night of the Proms', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('523', '10', '226', 'Respighi:Pines of Rome', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('524', '10', '226', 'Strauss: Waltzes', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('525', '10', '229', 'Carmina Burana', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('526', '10', '230', 'A Copland Celebration, Vol. I', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('527', '10', '231', 'Bach: Toccata & Fugue in D Minor', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('528', '10', '232', 'Prokofiev: Symphony No.1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('529', '10', '233', 'Scheherazade', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('530', '10', '234', 'Bach: The Brandenburg Concertos', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('532', '10', '236', 'Mascagni: Cavalleria Rusticana', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('533', '10', '237', 'Sibelius: Finlandia', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('537', '10', '242', 'Adams, John: The Chairman Dances', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('539', '10', '245', 'Berlioz: Symphonie Fantastique', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('540', '10', '245', 'Prokofiev: Romeo & Juliet', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('542', '10', '247', 'English Renaissance', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('544', '10', '248', 'Mozart: Symphonies Nos. 40 & 41', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('546', '10', '250', 'SCRIABIN: Vers la flamme', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('548', '10', '255', 'Bartok: Violin & Viola Concertos', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('551', '10', '259', 'South American Getaway', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('552', '10', '260', 'Górecki: Symphony No. 3', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('553', '10', '261', 'Purcell: The Fairy Quee', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('556', '10', '264', 'Weill: The Seven Deadly Sins', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('558', '10', '266', 'Szymanowski: Piano Works, Vol. 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('559', '10', '267', 'Nielsen: The Six Symphonies', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('562', '10', '274', 'Mozart: Chamber Music', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('563', '2', '10', 'The Best Of Billy Cobham', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('564', '2', '197', 'Quiet Songs', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('565', '2', '202', 'Worlds', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('566', '2', '27', 'Quanta Gente Veio ver--B?nus De Carnaval', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('567', '2', '53', 'Heart of the Night', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('568', '2', '53', 'Morning Dance', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('569', '2', '6', 'Warner 25 Anos', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('570', '2', '68', 'Miles Ahead', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('571', '2', '68', 'The Essential Miles Davis Disc 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('572', '2', '68', 'The Essential Miles Davis Disc 2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('573', '2', '79', 'Outbreak', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('574', '2', '89', 'Blue Moods', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('575', '3', '100', 'Greatest Hits', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('576', '3', '106', 'Ace Of Spades', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('577', '3', '109', 'Motley Crue Greatest Hits', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('578', '3', '11', 'Alcohol Fueled Brewtality Live! Disc 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('579', '3', '11', 'Alcohol Fueled Brewtality Live! Disc 2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('580', '3', '114', 'Tribute', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('581', '3', '12', 'Black Sabbath Vol. 4 (Remaster)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('582', '3', '12', 'Black Sabbath', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('583', '3', '135', 'Mezmerize', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('584', '3', '14', 'Chemical Wedding', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('585', '3', '50', '...And Justice For All', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('586', '3', '50', 'Black Album', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('587', '3', '50', 'Garage Inc. (Disc 1)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('588', '3', '50', 'Garage Inc. (Disc 2)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('589', '3', '50', 'Load', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('590', '3', '50', 'Master Of Puppets', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('591', '3', '50', 'ReLoad', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('592', '3', '50', 'Ride The Lightning', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('593', '3', '50', 'St. Anger', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('594', '3', '7', 'Plays Metallica By Four Cellos', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('595', '3', '87', 'Faceless', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('596', '3', '88', 'Use Your Illusion II', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('597', '3', '90', 'A Real Dead One', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('598', '3', '90', 'A Real Live One', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('599', '3', '90', 'Live After Death', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('600', '3', '90', 'No Prayer For The Dying', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('601', '3', '90', 'Piece Of Mind', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('602', '3', '90', 'Powerslave', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('603', '3', '90', 'Rock In Rio CD1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('604', '3', '90', 'Rock In Rio CD2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('605', '3', '90', 'Seventh Son of a Seventh So', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('606', '3', '90', 'Somewhere in Time', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('607', '3', '90', 'The Number of The Beast', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('608', '3', '98', 'Living After Midnight', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('609', '4', '196', 'Cake: B-Sides and Rarities', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('610', '4', '204', 'Temple of the Dog', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('611', '4', '205', 'Carry O', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('612', '4', '253', 'Carried to Dust (Bonus Track Version)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('613', '4', '8', 'Revelations', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('614', '6', '133', 'In Step', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('615', '6', '137', 'Live Disc 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('616', '6', '137', 'Live Disc 2', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('618', '6', '81', 'The Cream Of Clapto', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('619', '6', '81', 'Unplugged', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('620', '6', '90', 'Iron Maide', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('623', '7', '103', 'Barulhinho Bom', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('624', '7', '112', 'Olodum', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('625', '7', '113', 'Acústico MTV', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('626', '7', '113', 'Arquivo II', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('627', '7', '113', 'Arquivo Os Paralamas Do Sucesso', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('628', '7', '145', 'Serie Sem Limite (Disc 1)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('629', '7', '145', 'Serie Sem Limite (Disc 2)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('630', '7', '155', 'Ao Vivo IMPORT', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('631', '7', '16', 'Prenda Minha', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('632', '7', '16', 'Sozinho Remix Ao Vivo', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('633', '7', '17', 'Minha Historia', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('634', '7', '18', 'Afrociberdelia', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('635', '7', '18', 'Da Lama Ao Caos', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('636', '7', '20', 'Na Pista', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('637', '7', '201', 'Duos II', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('638', '7', '21', 'Sambas De Enredo 2001', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('639', '7', '21', 'Vozes do MPB', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('640', '7', '24', 'Chill: Brazil (Disc 1)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('641', '7', '27', 'Quanta Gente Veio Ver (Live)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('642', '7', '37', 'The Best of Ed Motta', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('643', '7', '41', 'Elis Regina-Minha História', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('644', '7', '42', 'Milton Nascimento Ao Vivo', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('645', '7', '42', 'Minas', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('646', '7', '46', 'Jorge Ben Jor 25 Anos', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('647', '7', '56', 'Meus Momentos', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('648', '7', '6', 'Chill: Brazil (Disc 2)', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('649', '7', '72', 'Vinicius De Moraes', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('651', '7', '77', 'Cássia Eller - Sem Limite Disc 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('652', '7', '80', 'Djavan Ao Vivo - Vol. 02', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('653', '7', '80', 'Djavan Ao Vivo - Vol. 1', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('654', '7', '81', 'Unplugged', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('655', '7', '83', 'Deixa Entrar', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('656', '7', '86', 'Roda De Funk', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('657', '7', '96', 'Jota Quest-1995', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('659', '7', '99', 'Mais Do Mesmo', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('660', '8', '100', 'Greatest Hits', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('661', '8', '151', 'UB40 The Best Of - Volume Two UK', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('662', '8', '19', 'Acústico MTV Live', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('663', '8', '19', 'Cidade Negra - Hits', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('665', '9', '21', 'Axé Bahia 2001', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('666', '9', '252', 'Frank', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('667', '5', '276', 'Le Freak', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('668', '5', '278', 'MacArthur Park Suite', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('669', '5', '277', 'Ring My Bell', '8.99', '/Content/Images/placeholder.gif');
INSERT INTO `album` VALUES ('670', '8', '15', 'xinzz', '1.99', '/Content/Images/placeholder.gif');
