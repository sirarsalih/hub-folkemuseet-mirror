# Augmented Reality for Norsk Folkemuseum

A pro bono Augmented Reality (AR) project developed for [Norsk Folkemuseum](https://norskfolkemuseum.no/) as part of the Hubs work at [Making Waves](https://www.makingwaves.com/).

## Weather PWA Sample Template

Jonathan Danylko's [Weather PWA sample](https://dzone.com/articles/building-progressive-web-applications-pwa-with-vis) is used as a template, we are thankful for his free contribution.

## Tech

ASP.NET Core MVC is used for the back-end and simple JavaScript is used for the front-end that harnesses a service worker.

## Setup

1. Clone repo.
2. Download and install the [.NET Core 1.0.4 executable](https://github.com/dotnet/core/blob/master/release-notes/download-archives/1.0.4-download.md).
3. Download and install [Node.js](https://nodejs.org/en/download/).
4. Install bower globally by executing the following command in cmd:

```
npm install -g bower
```

5. Clean, build and run solution.

## Continuous delivery

Visual Studio Team Services (VSTS) is used from the Azure Portal (click on the app service -> Continuous Delivery) for building and deploying the site. When code is pushed to the master branch, a build is automaticaly started. If the build succeeds, a deploy to the Staging environment is automatically started. If the deploy succeeds, the Staging deployed package slot is swapped with Production.