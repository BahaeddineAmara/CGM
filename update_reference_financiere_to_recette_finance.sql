-- Script pour mettre à jour les ENUM de reference_financiere vers recette_finance
USE comptabilite_db;

-- Mettre à jour la table societes
ALTER TABLE societes MODIFY COLUMN type_tableau ENUM('teledeclaration', 'teleliquidation', 'recette_finance') DEFAULT 'teledeclaration';

-- Mettre à jour la table personnes
ALTER TABLE personnes MODIFY COLUMN type_tableau ENUM('teledeclaration', 'teleliquidation', 'recette_finance') DEFAULT 'teledeclaration';

-- Mettre à jour les valeurs existantes
UPDATE societes SET type_tableau = 'recette_finance' WHERE type_tableau = 'reference_financiere';
UPDATE personnes SET type_tableau = 'recette_finance' WHERE type_tableau = 'reference_financiere';

-- Vérifier les modifications
DESCRIBE societes;
DESCRIBE personnes; 