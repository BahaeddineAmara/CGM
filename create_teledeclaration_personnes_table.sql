-- Script pour créer la table teledeclaration_personnes
USE comptabilite_db;

-- Créer la table teledeclaration_personnes avec la même structure que teledeclaration
CREATE TABLE teledeclaration_personnes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    personne_id INT NOT NULL,
    document_etat ENUM('non_arrive', 'en_cours', 'arrive') DEFAULT 'non_arrive',
    saisie_etat ENUM('non_fait', 'en_cours', 'fait') DEFAULT 'non_fait',
    declaration_etat ENUM('non_fait', 'en_cours', 'fait') DEFAULT 'non_fait',
    montant DECIMAL(10,2) NULL,
    banque VARCHAR(255) NULL,
    paiement_etat ENUM('non_fait', 'en_cours', 'fait') DEFAULT 'non_fait',
    quittance_numero VARCHAR(255) NULL,
    quittance_etat ENUM('non_recu', 'en_attente', 'recu') DEFAULT 'non_recu',
    last_modified_by INT NULL,
    last_modified_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    mois INT NOT NULL,
    annee INT NOT NULL,
    login VARCHAR(255) NULL,
    mot_de_passe VARCHAR(255) NULL,
    FOREIGN KEY (personne_id) REFERENCES personnes(id) ON DELETE CASCADE,
    FOREIGN KEY (last_modified_by) REFERENCES users(id) ON DELETE SET NULL
);

-- Insérer quelques données d'exemple
INSERT INTO teledeclaration_personnes (personne_id, document_etat, saisie_etat, declaration_etat, montant, banque, paiement_etat, quittance_numero, quittance_etat, last_modified_by, mois, annee, login, mot_de_passe) VALUES
(1, 'arrive', 'fait', 'fait', 5000.00, 'BNP Paribas', 'fait', 'QTN001', 'recu', 1, 1, 2024, 'jean.dupont', 'password123'),
(2, 'en_cours', 'en_cours', 'non_fait', 3500.00, 'Crédit Agricole', 'en_cours', NULL, 'en_attente', 1, 1, 2024, 'marie.martin', 'password456'),
(3, 'non_arrive', 'non_fait', 'non_fait', NULL, NULL, 'non_fait', NULL, 'non_recu', 1, 1, 2024, 'pierre.durand', 'password789');

-- Vérifier que la table a été créée
DESCRIBE teledeclaration_personnes;
SELECT * FROM teledeclaration_personnes; 