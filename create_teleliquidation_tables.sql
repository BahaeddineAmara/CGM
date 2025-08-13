-- Table teleliquidation pour les sociétés (personnes morales)
CREATE TABLE teleliquidation (
    id INT AUTO_INCREMENT PRIMARY KEY,
    societe_id INT NOT NULL,
    document_etat ENUM('arrive', 'en_cours', 'non_arrive') DEFAULT 'non_arrive',
    saisie_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    declaration_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    montant DECIMAL(15,2) DEFAULT 0,
    paiement_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    numero_recu VARCHAR(255) NULL,
    recu_etat ENUM('recu', 'en_attente', 'non_recu') DEFAULT 'non_recu',
    login VARCHAR(255) NULL,
    mot_de_passe VARCHAR(255) NULL,
    last_modified_by INT NULL,
    mois INT NOT NULL,
    annee INT NOT NULL,
    FOREIGN KEY (societe_id) REFERENCES societes(id) ON DELETE CASCADE,
    FOREIGN KEY (last_modified_by) REFERENCES users(id) ON DELETE SET NULL
);

-- Table teleliquidation_personnes pour les personnes physiques
CREATE TABLE teleliquidation_personnes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    personne_id INT NOT NULL,
    document_etat ENUM('arrive', 'en_cours', 'non_arrive') DEFAULT 'non_arrive',
    saisie_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    declaration_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    montant DECIMAL(15,2) DEFAULT 0,
    paiement_etat ENUM('fait', 'en_cours', 'non_fait') DEFAULT 'non_fait',
    numero_recu VARCHAR(255) NULL,
    recu_etat ENUM('recu', 'en_attente', 'non_recu') DEFAULT 'non_recu',
    login VARCHAR(255) NULL,
    mot_de_passe VARCHAR(255) NULL,
    last_modified_by INT NULL,
    mois INT NOT NULL,
    annee INT NOT NULL,
    FOREIGN KEY (personne_id) REFERENCES personnes(id) ON DELETE CASCADE,
    FOREIGN KEY (last_modified_by) REFERENCES users(id) ON DELETE SET NULL
);