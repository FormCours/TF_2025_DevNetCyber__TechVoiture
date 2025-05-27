# API TechVoiture

## Architecture : 3 tiers + Domain
- **API:**
Interface vers l'exterieur.
Traitre les requetes et renvoyer la r�ponse adapt�
- **BLL:**
Logique metier
- **DAL:**
Acces aux donn�es (DB, fichier, api externe, ...)
- **Domain:**
Couche transversal (Connu de l'API, la BLL et la DAL)
D�fini le models des donn�es, les execptions, les constantes, ...

## Structure de donn�es

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