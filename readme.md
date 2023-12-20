![Logo LyonPalme](/Forms/Images/readme_logo.png)

# Gestion de Matériels - LyonPalme

## Description

L'application "Gestion de Matériels - LyonPalme" sert à gérer le matériel de l'association Lyon Palme ainsi que de le visualiser. Elle permet aussi de créer des prêts, de les voir ainsi que de voir les nageurs inscrits dans l'association.

## Technologies Utilisées

- **Langage de programmation** : C#
- **Base de données** : Microsoft SQL Server
- **Framework** : .Net
- **Interface utilisateur** : Windows Forms
- **Contrôle de version** : Git
- **Gestion des packages** : NuGet

## Installation

Pour installer l'application, suivez les étapes ci-dessous :

1. Clonez le dépôt Git sur votre machine locale.
2. Ouvrez le projet dans votre environnement de développement intégré (IDE).
3. Créez un nouveau fichier `App.config` dans le répertoire racine du projet.
4. Dans le fichier `App.config`, ajoutez le code nécessaire pour configurer l'accès à la base de données. Voici un exemple de ce à quoi pourrait ressembler votre fichier `App.config` :

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<startup>
		<supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
	</startup>
	<connectionStrings>
		<add name="sqlserver_gestionmatériel" connectionString="Data Source=192.168.100.236;Initial Catalog=sonnyrusso;User ID=LPSonny;Password=GEST10N_m@terIL!" providerName="System.Data.SqlClient" />
	</connectionStrings>
	<runtime>
		<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
			<dependentAssembly>
				<assemblyIdentity name="System.Runtime.CompilerServices.Unsafe" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
				<bindingRedirect oldVersion="0.0.0.0-6.0.0.0" newVersion="6.0.0.0" />
			</dependentAssembly>
			<dependentAssembly>
				<assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
				<bindingRedirect oldVersion="0.0.0.0-13.0.0.0" newVersion="13.0.0.0" />
			</dependentAssembly>
		</assemblyBinding>
	</runtime>
</configuration>

## Utilisation

Pour utiliser l'application, il faut tout d'abord s'y connecter et seul l'administrateur le peut. Lorsqu'il se connecte, il se retrouve sur la page d'accueil où il retrouvera la liste de tout le matériel de l'association. Sur le côté, plusieurs boutons sont disponibles :

- Voir les prêts : affiche tous les emprunts que les nageurs ont faits à l'association. Cette page permet également l'accès à la page d'ajout d'un prêt.
- Ajout Combinaison : permet d'ajouter un nouveau matériel (une combinaison avec sa taille, sa saison et sa marque).
- Ajout Monopalme : ajoute un nouveau matériel (Monopalme, avec sa pointure, son type et sa marque).
- Voir Nageurs : où l'on peut voir la liste des nageurs.

## Dépendances

L'application dépend d'une base de données. Si nous ne sommes pas connectés au réseau de l'établissement, l'accès ne se fera pas et l'application ne fonctionnera pas.


