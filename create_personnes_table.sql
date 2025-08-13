-- Script pour créer la table personnes
USE comptabilite_db;

-- Créer la table personnes avec la même structure que societes
CREATE TABLE personnes (
    id INT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    adresse TEXT NULL,
    numero_telephone VARCHAR(50) NULL,
    email VARCHAR(255) NULL,
    code_tva VARCHAR(50) NULL,
    nature_contrat TEXT NULL,
    type_tableau ENUM('teledeclaration', 'teleliquidation', 'reference_financiere') DEFAULT 'teledeclaration',
    active_since DATE NULL,
    inactive_since DATE NULL
);

-- Insérer quelques données d'exemple
INSERT INTO personnes (id, nom, adresse, numero_telephone, email, code_tva, nature_contrat, active_since) VALUES
(1, 'Jean Dupont', '123 Rue de la Paix, Paris', '01 23 45 67 89', 'jean.dupont@email.com', 'FR12345678901', 'Contrat de travail', '2024-01-01'),
(2, 'Marie Martin', '456 Avenue des Champs, Lyon', '04 56 78 90 12', 'marie.martin@email.com', 'FR98765432109', 'Consultant', '2024-01-01'),
(3, 'Pierre Durand', '789 Boulevard Central, Marseille', '04 91 23 45 67', 'pierre.durand@email.com', 'FR45678912345', 'Freelance', '2024-01-01');

-- Vérifier que la table a été créée
DESCRIBE personnes;
SELECT * FROM personnes; 