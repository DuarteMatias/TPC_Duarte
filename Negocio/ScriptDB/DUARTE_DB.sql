use master
go
DROP DATABASE GESTION
GO
create database GESTION
GO
USE GESTION
GO
CREATE TABLE ALUMNOS(
LEGAJO INT NOT NULL PRIMARY KEY IDENTITY,
NOMBRE VARCHAR(30) NOT NULL,
APELLIDO VARCHAR(30) NOT NULL,
FNAC DATE NOT NULL,
EMAIL VARCHAR(40) NULL,
DIRECCION VARCHAR(50) NOT NULL,
TELEFONO BIGINT NULL,
DNI INT NOT NULL
)
GO
CREATE TABLE DOCENTES(
LEGAJO INT NOT NULL PRIMARY KEY IDENTITY,
NOMBRE VARCHAR(30) NOT NULL,
APELLIDO VARCHAR(30) NOT NULL,
FNAC DATE NOT NULL,
EMAIL VARCHAR(40) NULL,
DIRECCION VARCHAR(50) NOT NULL,
TELEFONO BIGINT NULL,
DNI INT NOT NULL
)

--INSERTS ALUMNOS
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MARIA','RUEDA','30/03/2000','MARU_66@LIVE.COM.AR','DE LA PTRIA 1123', 1130438748, 44567981)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('GERARDO','DUBAIN','19/01/2001','GDUBAIN@HOTMAIL.COM','PATRICIOS 112', 1156841266, 44422066)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ESTEBAN','SICALE','03/11/2000','ESTEBANSICALE@OUTLOOK.COM.AR','URQUIZA 2222',1124563877, 45956784)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('DARIO','LEDESMA','14/12/2001','DAROLEDESMA@LIVE.COM.AR','SALVADOR 3333', 1198563455, 44548965)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('JULIO','BAIGORRI','25/10/2000','JBAIGORRI@HOTMAIL.COM','MILAGROS 4459', 1153785433, 45854698)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('NATALIA','LOPEZ','2/8/2007','NATITO15@HOTMAIL.COM.AR','JUAN JOSE PASO 409', 115698730, 44426026)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MIRIAM','BONOMI','8/5/2002','MIMI25@GMAIL.COM.AR','HUMBERTO PRIMO 2356', 1163258966, 45567345)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ANDREA','PEREZ','22/10/2003','ANDDY_PHOTMAIL.COM.AR','CUENCA 456', 64328966, 46897356)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('SOLEDAD','BARRIOS','2/1/2004','SOLCITO15@HOTMAIL.COM.AR','SAN MARTIN 685', 1157843900, 44475697)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('EMMANUEL','GUAJARDO','5/3/2002','MAMU_G@LIVE.COM','VILLAGRA 695', 1163268744, 45246487)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('FABRIZIO','MAUTO','26/5/2005','FABRY_MAUTO@HOTMAIL.COM.AR','SARMIENTO 4862', 1145687344, 46586943)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('RODRIGO','CASANOVA','8/6/2006','RODRYCASANOVA@HOTMAIL.COM','LIBERTADOR 568', 1178564355, 46805328)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('CAMILA','NURE','30/9/2007','CAMI_NURE@HOTMAIL.COM.AR','PARANA 471', 1156874355, 44486428)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('FLAVIA','ROMERO','6/11/2002','FLAVIA_ROMERO@GMAIL.COM.AR','SALTA 7542', 1134685498, 45806537)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ANTONELLA','MENNA','13/7/2001','ANTONELITA_MENNA@HOTMAIL.COM','ROSARIO 658', 1168543788, 4578576)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ANALIA','CASTEL','10/11/2000','ANALIA_CASTEL14@HOTMAIL.COM.AR','ALVEAR 597', 1134985600, 45684265)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('NATALIA','LEDESMA','4/9/2007','NATY_LEDESMA@HOTMAIL.COM.AR','MARIANO MORENO 487', 1168439566, 44684326)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MIRNA','MANSO','12/2/2004','MMANSO_2004@HOTMAIL.COM.AR','CABILDO 4751', 1160957344, 46895634)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MACARENA','NEGRI','8/1/2001','MACA_NEGRI@HOTMAIL.COM','SAN MARTIN 5413', 1189453876, 44543763)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('AUGUSTO','COSE','15/3/2002','AUGUS_COSE@OUTLOOK.COM.AR','VILLANUEVA 452', 1189347544, 46789054)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('TOBIAS','WEDELTOFF','14/5/2003','TOBIAS_WEDELTOFF@HOTMAIL.COM.AR','EUGENIA TAPIA DE CRUZ 1254', 1190463866, 33532756)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('SERGIO','WEIMBER','10/1/2006','S_WEIMBER@LIVE.COM.AR','RIVADAVIA 4857', 1167392688, 44574298)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('RODOLFO','RODRIGUEZ','5/10/2001','R_RODRIGUEZ@OUTLOOK.COM.AR','CASTRO BARRIOS 5641', 1190462833, 44684865)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('RUBEN','CASALDO','18/6/2000','RUBEN_CASALDO@HOTMAIL.COM','12 DE OCTUBRE 4521', 118946845, 46635686)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ANALIA','MESTRE','21/2/2006','ANALIA.MESTRE06@HOTMAIL.COM.AR','LIBERTAD 452', 1178346597, 44864375)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MATIAS','TOLEDO','17/4/2005','TOLEDO_M@HOTMAIL.COM.AR','ALDERETE 524', 1139574936, 45975375)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('TOMAS','SANTOS','26/3/2002','SANTOS.TOMAS@LIVE.COM.AR','ESCALADA 265', 1184734955, 45697008)
INSERT INTO ALUMNOS (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('DANIELA','KROBOT','25/2/2004','DANIELA_K@HOTMAIL.COM','PIEDRAS 265', 1198453846, 44558327)

 
--INSERTS DOCENTES
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('CARINA','LIM','11/10/1971','CALIM@LIVE.COM.AR','MENDAL 1258', 1134850367, 22697368)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('FABIANA','JAIME','03/12/1988','FABIJ@OUTLOOK.COM','MENDAL 8943', 1194720472, 33508994)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('BEATRIZ','DIAZ','07/10/1975','BEATRIZ-DIAZ@GMAIL.COM','MENDAL 55', 1194538503, 25449776)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MARIA','CECARE','25/04/1980','MARIAC@HOTMAIL.COM.AR','MENDAL 139', 1174026394, 28770993)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('CELIA','BANETTE','29/05/1986','CELIA.BANETTE@LIVE.COM.AR','MENDAL 466', 117438538, 33586990)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MARIA','RODRIGUEZ','11/10/1971','MARA@LIVE.COM.AR','MENDAL 1258', 117493496, 22558369)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('LUCAS','ASTRADA','1/9/1970','LUASTRADA@LIVE.COM.AR','MENDAL 1258', 1152946305, 22990558)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MARIANO','SOUTO','8/1/1966','MARSOU@LIVE.COM.AR','MENDAL 1258', 1198463922, 184337669)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('JORGE','MESA','12/5/1975','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1184538564, 25338770)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('FLORENCIA','POGGI','20/9/1987','FPOGGI@LIVE.COM.AR','MENDAL 1258', 1162840953, 33338994)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('SABRINA','TOME','3/4/1973','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1109547397, 24006486)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MARTA','MENDEZ','17/10/1967','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1137549729, 20668943)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('SOFIA','MONTIEL','26/11/1986','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1174395385, 33337958)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('EDUARDO','CALZADA','25/12/1970','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1184375036, 22770584)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MACARENA','WILKINSON','7/11/1973','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1167439503, 24684694)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ELIZABETH','SIERRA','11/6/1965','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1160365839, 18690447)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ELENA','LEYES','16/9/1960','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1138504739, 15480685)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('AMELIA','WEIMBER','14/10/1971','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 115497609, 22790576)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('NANCY','CASTRO','11/3/1970','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1160254922, 22235974)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('LUANA','VENZA','1/2/1988','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1190563955, 33689643)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('SANTIAGO','NIEBAS','7/6/1983','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1149563066, 30680576)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('ROBERTO','SIEMBRA','8/10/1970','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1138573055, 22580537)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('NADIA','MORENO','1/11/1985','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1139564033, 32805836)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MIGUEL','CASADO','6/2/1988','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1160365924, 33690574)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MARCELA','YUCCA','23/1/1972','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1104928300, 23680386)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('GLORIA','MAMANI','26/8/1976','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1184937477, 26889557)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('MARCELO','ECHEGARAY','24/10/1977','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 1189374620, 27008367)
INSERT INTO DOCENTES (NOMBRE,APELLIDO,FNAC,EMAIL,DIRECCION,TELEFONO,DNI) VALUES ('SUSANA','TRADE','7/1/1969','DUARTE-MATIAS@LIVE.COM.AR','MENDAL 1258', 119304366, 21669772)
