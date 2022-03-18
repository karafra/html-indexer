<div id="top" />
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/karafra/html-indexer">
    <img src="img/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Kari indexer</h3>

  <p align="center">
    Simple folder indexer with html output
    <br />
    <a href="https://github.com/karafra/html-indexer/wiki"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/karafra/html-indexer/issues">Report Bug</a>
    ·
    <a href="https://github.com/karafra/html-indexer/issues">Request Feature</a>
  </p>
</div>



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
      <li><a href="#installation">Installation</a></li>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

<div align="center">

  [![Product Name Screen Shot][product-screenshot]](https://github.com/karafra/html-indexer)

</div>

Simple folder indexer with html output file, very simple and highly customizable.
<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [.Net 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [Razor](https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c)
* [MiniRazor](https://github.com/Tyrrrz/MiniRazor)
* [Bootstrap (Icons)](https://icons.getbootstrap.com/)
* [GithubActions (CI)](https://github.com/features/actions)
* [XUnit](https://xunit.net/)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Installation

1. Install package
   ```sh
   $ dotnet add <Project> package KariIndexer.Net 
   ```
2. Enjoy 😊

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage
```cs
using HtmlIndexer;

public class Program
{
  public static async Task Main(string[] args)
  {
    var index = new IndexContext("../../img/", "index.html");
    await FolderIndexer.CreateWriter(index).GenerateIndex();
  }
}
```

_For more examples, please refer to the [Documentation](https://github.com/karafra/html-indexer)_

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Coverage
- [ ] Add CLI module

See the [open issues](https://github.com/karafra/html-indexer/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the Apache 2.0 License. See [license](LICENSE) for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Your Name - [@karafra](https://twitter.com/karafra) - dariusKralovic@protonmail.com

Project Link: [https://github.com/karafra/html-indexer](https://github.com/karafra/html-indexer)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/karafra/html-indexer.svg?style=for-the-badge
[contributors-url]: https://github.com/karafra/html-indexer/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/karafra/html-indexer.svg?style=for-the-badge
[forks-url]: https://github.com/karafra/html-indexer/network/members
[stars-shield]: https://img.shields.io/github/stars/karafra/html-indexer.svg?style=for-the-badge
[stars-url]: https://github.com/karafra/html-indexer/stargazers
[issues-shield]: https://img.shields.io/github/issues/karafra/html-indexer.svg?style=for-the-badge
[issues-url]: https://github.com/karafra/html-indexer/issues
[license-shield]: https://img.shields.io/github/license/karafra/html-indexer.svg?style=for-the-badge
[license-url]: https://github.com/karafra/html-indexer/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[product-screenshot]: img/screenshot.png
