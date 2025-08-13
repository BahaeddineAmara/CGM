-- Script pour ajouter les champs d'activité à la table societes
USE comptabilite_db;

-- Ajouter les colonnes pour gérer l'activité des sociétés
ALTER TABLE societes ADD COLUMN active_since DATE NULL;
ALTER TABLE societes ADD COLUMN inactive_since DATE NULL;

-- Mettre à jour les sociétés existantes pour qu'elles soient actives depuis le 1er janvier 2024
UPDATE societes SET active_since = '2024-01-01' WHERE active_since IS NULL;

-- Vérifier que les colonnes ont été ajoutées
DESCRIBE societes; 