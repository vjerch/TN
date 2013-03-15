-- RoleRo
INSERT INTO "RoleRo" ("Code", "Name", "RoleId")
	VALUES('Admin', 'Admin', 1);

INSERT INTO "RoleRo" ("Code", "Name", "RoleId")
	VALUES('User', 'User', 2);
	
-- AuditInfoActionTypeRo
INSERT INTO "AuditInfoActionTypeRo" ("Code", "Name", "AuditInfoActionTypeId")
	VALUES('Insert', 'Insert', 1);
	
INSERT INTO "AuditInfoActionTypeRo" ("Code", "Name", "AuditInfoActionTypeId")
	VALUES('Update', 'Update', 2);
	
INSERT INTO "AuditInfoActionTypeRo" ("Code", "Name", "AuditInfoActionTypeId")
	VALUES('Delete', 'Delete', 3);
	
-- EntityRo
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('AuditInfo', 'AuditInfo', 1);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Rok', 'Rok', 2);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('TrgovanjeGlava', 'TrgovanjeGlava', 3);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('TrgovanjeStavka', 'TrgovanjeStavka', 4);

INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('User', 'User', 5);
	
-- ValutaRo
INSERT INTO "ValutaRo" ("Code", "Name", "ValutaId", "SifraSlog")
	VALUES('Kn', 'Kuna', 1, 'KN');

INSERT INTO "ValutaRo" ("Code", "Name", "ValutaId", "SifraSlog")
	VALUES('Chf', 'Švicarski franak', 2, 'CHF');

INSERT INTO "ValutaRo" ("Code", "Name", "ValutaId", "SifraSlog")
	VALUES('Eur', 'Euro', 3, 'EUR');

INSERT INTO "ValutaRo" ("Code", "Name", "ValutaId", "SifraSlog")
	VALUES('Usd', 'Amerièki dolar', 4, 'USD');

-- TrgovanjeVrstaRo
INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('Opoziv', 'Opoziv', 1, 'OPO');

INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('TomNext', 'TOM/NEXT', 2, 'T/N');
	
INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('SpotNext', 'SPOT/NEXT', 3, 'S/N');

INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('RocniDepozit', 'Roèni depozit', 4, '2-6');
	
INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('JedanTjedan', '1 tjedan', 5, '1TJ');

INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('DvaTjedna', '2 tjedna', 6, '2TJ');
	
INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('JedanMjesec', '1 mjesec', 7, '1MJ');
	
INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('TriMjeseca', '3 mjeseca', 8, '3MJ');
	
INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('ViseOdTriMjeseca', 'više od tri mjeseca', 9, '3M+');

INSERT INTO "TrgovanjeVrstaRo" ("Code", "Name", "TrgovanjeVrstaId", "SifraSlog")
	VALUES('Prekonocni', 'prekonoæni', 10, 'O/N');