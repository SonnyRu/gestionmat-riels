![Logo LyonPalme](/Forms/Images/readme_logo.png)

# Gestion de Matériels - LyonPalme

## Sommaire

- [Description](#description)
- [Technologies Utilisées](#techno)
- [Diagramme d'activité](#activité)
- [Digramme de cas](#usecase)
- [Prérequis](#prerequis)
- [Installation](#installation)
- [Utilisation](#utilisation)
- [Dépendances](#dependances)



## Description <a id="description"></a>

L'application "Gestion de Matériels - LyonPalme" sert à gérer le matériel de l'association Lyon Palme ainsi que de le visualiser. Elle permet aussi de créer des prêts, de les voir ainsi que de voir les nageurs inscrits dans l'association.

## Technologies Utilisées <a id="techno"></a>

| **Nom** | **Description** |
| ------- | ------------- |
| ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) | Langage de programmation orienté objet. |
| ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white) | Base de données. |
| ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) | Framework .Net `6.0`. |
| ![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white) | Interface utilisateur avec Windows Forms |
| ![Git](https://img.shields.io/badge/git-%23F05033.svg?style=for-the-badge&logo=git&logoColor=white) | Contrôle de version. |


## Diagramme d'activité <a id="activité"></a>

![Diagramme d'activité](/Forms/Images/activité.png)


## Diagramme de cas <a id="usecase"></a>

![Diagramme de cas](/Forms/Images/usecase.png)


## Prérequis <a id="prerequis"></a>

Pour exécuter ce projet, vous devez avoir au minimum .Net 6.0 installé sur votre machine. Les versions inférieures à 6.0 ne sont pas compatibles avec ce projet.


## Installation <a id="installation"></a>

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
```

5. Assurez-vous que dans votre `.csproj` le code suivant soit bien présent. Si ce n'est pas le cas, créez-le :

```xml
<ItemGroup>
	  <Content Include="Config\logerror.txt">
		  <CopyToOutputDirectory>Always</CopyToOutputDirectory>
	  </Content>	
</ItemGroup>
```

6. Faites un clic droit sur le projet et cliquez sur “Publier”. Cela ouvrira une page. Comme cible, choisissez “Dossier”, puis cliquez sur “Suivant”. Pour la cible spécifique, choisissez “Dossier”, puis cliquez sur “Suivant”. Vous pouvez alors choisir l’emplacement du dossier de publication. Personnellement, je l’ai mis à la racine. Enfin, cliquez sur “Terminer”.

7. **Rappel important :** Assurez-vous d’être bien connecté au réseau de l’établissement ou utilisez un VPN pour vous y connecter. L’administrateur a été créé dans la base de données, donc si vous n’êtes pas connecté au réseau, l’application ne fonctionnera pas.

8. Voici donc l'utilisateur admin pour se connecter à l'application lorsque vous l'avez executer :

| **Login** | **Mot de passe** |
| ------- | ------------- |
| vromaine | C1Secret! |



## Utilisation <a id="utilisation"></a>

Pour utiliser l'application, il faut tout d'abord s'y connecter et seul l'administrateur le peut. Lorsqu'il se connecte, il se retrouve sur la page d'accueil où il retrouvera la liste de tout le matériel de l'association. Sur le côté, plusieurs boutons sont disponibles :

- Voir les prêts : affiche tous les emprunts que les nageurs ont faits à l'association. Cette page permet également l'accès à la page d'ajout d'un prêt.
- Ajout Combinaison : permet d'ajouter un nouveau matériel (une combinaison avec sa taille, sa saison et sa marque).
- Ajout Monopalme : ajoute un nouveau matériel (Monopalme, avec sa pointure, son type et sa marque).
- Voir Nageurs : où l'on peut voir la liste des nageurs.

## Dépendances <a id="dependances"></a>

L'application dépend d'une base de données. Si nous ne sommes pas connectés au réseau de l'établissement, l'accès ne se fera pas et l'application ne fonctionnera pas.


