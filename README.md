FooYesWebApp

<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->

<h3 align="center">FooYes Restaurant Website</h3>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#functionalities">Functionalities</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About The Project

Final project for second year at IUT2 Grenoble.  `IUT2`, `Grenoble`, `C#`, `.net 4.5.2`, 
`Entity Framework 6`, `Identity 2.2.1`, `Autofac`, `Bootstrap 5.0`

<p align="right">(<a href="#top">back to top</a>)</p>

### Built With

* [JetBrains Rider](https://www.jetbrains.com/rider/)
* [.net framework 4.5.2](https://www.microsoft.com/en-us/download/details.aspx?id=42642)
* [Entity Framework 6](https://docs.microsoft.com/en-us/ef/ef6/)
* [Autofac](https://autofac.org/)
* [Bootstrap 5.0](https://getbootstrap.com/docs/5.0/getting-started/introduction/)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/urihani/FooYesWebApp.git
   ```
2. A database file is provided at FooYes.Data/Database/Test.mdf
3. Move it in another folder (Documents for example)
4. Change the path to the database in Web.config
    ```sh
    <connectionStrings>
      <add 
        name="RestaurantDataDBContext" 
        connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30" providerName="System.Data.SqlClient" />
    </connectionStrings>
    ```
5. In case you want to start from an empty database, you should delete related tables.
6. Deleting Restaurants table (in jetbrains rider => go to database panel => right click on a table => database tools => truncate) : 
    ```sh
    delete
    from RestaurantModels
    DBCC CHECKIDENT (RestaurantModels, RESEED, -1)
    go
    ```
7. Deleting Dishes table :
    ```sh
    delete
   from DishModels
   DBCC CHECKIDENT (DishModels, RESEED, -1)
   go
    ```
   It is important to reset primary keys to 0 when deleting tables
<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Functionalities
+ Responsive navigation bar
+ Dependency Injection using Autofac
+ Showing categories and dishes for restaurants
+ Filtering dishes by category
+ Shopping cart with delete and update functionalities
+ DB integration using entity framework
+ Authentificaton and identity classes
+ Admin user accessible by (UserName : admin@admin.com, Password : Admin38000&)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- CONTACT -->
## Contact

Julien Morelle - julien.morelle@etu.univ-grenoble-alpes.fr

Project Link: [https://github.com/urihani/FooYesWebApp](https://github.com/urihani/FooYesWebApp)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo_name.svg?style=for-the-badge
[contributors-url]: https://github.com/github_username/repo_name/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo_name.svg?style=for-the-badge
[forks-url]: https://github.com/github_username/repo_name/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo_name.svg?style=for-the-badge
[stars-url]: https://github.com/github_username/repo_name/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo_name.svg?style=for-the-badge
[issues-url]: https://github.com/github_username/repo_name/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo_name.svg?style=for-the-badge
[license-url]: https://github.com/github_username/repo_name/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
[product-screenshot]: images/screenshot.png