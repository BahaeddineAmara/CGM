-- Script pour ajouter le champ type_tableau à la table societes
USE comptabilite_db;

-- Ajouter la colonne type_tableau avec une valeur par défaut
ALTER TABLE societes ADD COLUMN type_tableau ENUM('teledeclaration', 'teleliquidation', 'reference_financiere') DEFAULT 'teledeclaration';

-- Mettre à jour les sociétés existantes pour qu'elles soient de type teledeclaration par défaut
UPDATE societes SET type_tableau = 'teledeclaration' WHERE type_tableau IS NULL;

-- Vérifier que la colonne a été ajoutée
DESCRIBE societes; 