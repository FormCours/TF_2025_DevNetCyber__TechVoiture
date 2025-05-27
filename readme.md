# API TechVoiture

## Architecture : 3 tiers + Domain
- **API:** \
Interface vers l'exterieur. \
Traitre les requetes et renvoyer la réponse adapté
- **BLL:** \
Logique metier
- **DAL:** \
Acces aux données (DB, fichier, api externe, ...)
- **Domain:** \
Couche transversal (Connu de l'API, la BLL et la DAL) \
Défini le models des données, les execptions, les constantes, ...

## Structure de données

### Engine
```
id: int
name: string
fuel: string?
```

### Car
```
id: int
brand: string
model: string
year: int
price: decimal
kilometers: decimal
damaged: boolean
description: string?
engine: Engine
```

## Endpoints

### Engine
```
(GET)  /api/engine
(POST) /api/engine
(PUT)  /api/engine/{id}
```
