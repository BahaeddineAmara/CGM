-- Script pour créer les tables recette_finance pour les sociétés et personnes
USE comptabilite_db;

-- Créer la table recette_finance pour les sociétés
CREATE TABLE recette_finance (
    id INT AUTO_INCREMENT PRIMARY KEY,
    societe_id INT NOT NULL,
    mois INT NOT NULL,
    annee INT NOT NULL,
    document_etat ENUM('arrive', 'en_cours', 'non_arrive') DEFAULT 'non_arrive',
    saisie_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    declaration_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    montant DECIMAL(10,2) NULL,
    paiement_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    date_paiement DATE NULL,
    numero_recu VARCHAR(255) NULL,
    recu_etat ENUM('recu', 'en_attente', 'non_recu') DEFAULT 'non_recu',
    last_modified_by INT NULL,
    last_modified_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (societe_id) REFERENCES societes(id),
    FOREIGN KEY (last_modified_by) REFERENCES users(id),
    UNIQUE KEY unique_societe_mois_annee (societe_id, mois, annee)
);

-- Créer la table recette_finance_personnes pour les personnes physiques
CREATE TABLE recette_finance_personnes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    personne_id INT NOT NULL,
    mois INT NOT NULL,
    annee INT NOT NULL,
    document_etat ENUM('arrive', 'en_cours', 'non_arrive') DEFAULT 'non_arrive',
    saisie_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    declaration_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    montant DECIMAL(10,2) NULL,
    paiement_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    date_paiement DATE NULL,
    numero_recu VARCHAR(255) NULL,
    recu_etat ENUM('recu', 'en_attente', 'non_recu') DEFAULT 'non_recu',
    last_modified_by INT NULL,
    last_modified_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (personne_id) REFERENCES personnes(id),
    FOREIGN KEY (last_modified_by) REFERENCES users(id),
    UNIQUE KEY unique_personne_mois_annee (personne_id, mois, annee)
);

-- Vérifier que les tables ont été créées
DESCRIBE recette_finance;
DESCRIBE recette_finance_personnes; 