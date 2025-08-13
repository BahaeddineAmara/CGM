-- Script pour ajouter les colonnes login et mot_de_passe à la table teledeclaration
USE comptabilite_db;

-- Ajouter les colonnes login et mot_de_passe
ALTER TABLE teledeclaration ADD COLUMN login VARCHAR(255) NULL;
ALTER TABLE teledeclaration ADD COLUMN mot_de_passe VARCHAR(255) NULL;

-- Vérifier que les colonnes ont été ajoutées
DESCRIBE teledeclaration; 