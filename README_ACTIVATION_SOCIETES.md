# Système d'Activation/Désactivation des Sociétés

## Vue d'ensemble

Le système d'activation/désactivation permet de gérer la présence des sociétés dans les tableaux de manière dynamique, tout en préservant l'historique des données passées.

## Fonctionnalités

### 1. **Gestion de l'État d'Activité**
- **Société Active** : Présente dans les tableaux futurs
- **Société Inactive** : Absente des tableaux futurs, mais historique conservé

### 2. **Boutons d'Action**
- **"Arrêter l'activité"** (rouge) : Désactive une société
- **"Activer"** (vert) : Réactive une société inactive

### 3. **Logique de Fonctionnement**

#### **À l'ajout d'une société :**
- La société est automatiquement **active**
- `active_since` = date du jour
- `inactive_since` = NULL
- Présente dans les tableaux à partir du mois en cours

#### **Lors de la désactivation :**
- `inactive_since` = date du jour
- La société disparaît des tableaux futurs
- L'historique des mois passés est conservé

#### **Lors de la réactivation :**
- `inactive_since` = NULL
- La société réapparaît dans les tableaux à partir du mois en cours

### 4. **Filtrage dans les Tableaux**
- Seules les sociétés **actives** sont affichées dans les tableaux
- Les sociétés inactives sont masquées mais leurs données historiques restent accessibles

## Structure de la Base de Données

### Nouveaux Champs dans la Table `societes`

```sql
ALTER TABLE societes ADD COLUMN active_since DATE NULL;
ALTER TABLE societes ADD COLUMN inactive_since DATE NULL;
```

### Logique de Détermination de l'État

Une société est considérée comme **active** si :
```sql
(inactive_since IS NULL OR inactive_since > CURDATE())
```

## Interface Utilisateur

### ListeSocietesForm
- **Colonne "Statut"** : Affiche "Active" ou "Inactive"
- **Bouton "Arrêter l'activité"** : Désactive la société sélectionnée
- **Bouton "Activer"** : Active la société sélectionnée

### Messages de Confirmation
- **Désactivation** : "Êtes-vous sûr de vouloir arrêter l'activité de la société 'X' ?"
- **Activation** : "Êtes-vous sûr de vouloir activer la société 'X' ?"

## Scripts SQL

### Ajout des Champs d'Activité
Exécutez le fichier `add_activity_fields.sql` :

```sql
USE comptabilite_db;

-- Ajouter les colonnes pour gérer l'activité des sociétés
ALTER TABLE societes ADD COLUMN active_since DATE NULL;
ALTER TABLE societes ADD COLUMN inactive_since DATE NULL;

-- Mettre à jour les sociétés existantes pour qu'elles soient actives depuis le 1er janvier 2024
UPDATE societes SET active_since = '2024-01-01' WHERE active_since IS NULL;
```

## Avantages du Système

1. **Préservation de l'Historique** : Les données passées ne sont jamais perdues
2. **Flexibilité** : Possibilité d'activer/désactiver à tout moment
3. **Traçabilité** : Suivi complet des périodes d'activité
4. **Sécurité** : Pas de suppression définitive des données

## Utilisation

1. **Désactiver une société** : Sélectionner la société → "Arrêter l'activité"
2. **Activer une société** : Sélectionner la société → "Activer"
3. **Vérifier le statut** : Regarder la colonne "Statut" dans la liste

## Notes Importantes

- Les changements d'état n'affectent que les tableaux futurs
- L'historique des mois passés reste intact
- Une société nouvellement ajoutée est automatiquement active
- Le système respecte l'intégrité référentielle des données 