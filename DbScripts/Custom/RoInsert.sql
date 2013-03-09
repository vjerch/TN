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