# Covid-19 Tracker
[![GitHub stars](https://img.shields.io/github/stars/haseeb-heaven/Covid-19-Tracker)](https://github.com/Abdirahiim/covidtrackerapiwrapper/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/haseeb-heaven/Covid-19-Tracker)](https://github.com/Abdirahiim/covidtrackerapiwrapper/network/members)
[![GitHub Commit](https://img.shields.io/badge/Commits-5-blue)](https://github.com/haseeb-heaven/Covid-19-Tracker/network/members)

[Covid-19] (https://en.wikipedia.org/wiki/Coronavirus_disease_2019) is Corona virus disease tracker based on [CovidSharp](https://github.com/Abdirahiim/covidtrackerapiwrapper)
which tracks data of more than 170 countries around the world and provide detailed data for **Active,Fatal,Recovered** cases. 


## **_Your support is needed to keep this project alive, Feel free to donate._**
[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.me/AzimD)

## API & Sources
Covid-19 Tracker uses [coronavirus-tracker-api](https://github.com/ExpDev07/coronavirus-tracker-api) and [CovidSharp SDK](https://github.com/Abdirahiim/covidtrackerapiwrapper)</br>

**Data sources** </br>
[JHU](https://systems.jhu.edu/research/public-health/ncov/)  - Worldwide Data repository operated by the Johns Hopkins University Center for Systems Science and Engineering (JHU CSSE).</br>
[CSBS](https://www.csbs.org/information-covid-19-coronavirus) - U.S. County data that comes from the Conference of State Bank Supervisors.</br>

## Recovered cases showing 0
JHU [(our main data provider) no longer provides data for amount of recoveries](https://github.com/CSSEGISandData/COVID-19/issues/1250), and as a result, the API will be showing 0 for this statistic. Apologies for any inconvenience. Hopefully we'll be able to find an alternative data-source that offers this.

## Application Showcase.
**Application showcase : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app.png) </br>
**Select province : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_province.png) </br>
**Display active cases : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_active.png) </br>
**Display fatal cases : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_fatal.png) </br>
**Display fatal cases : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_fatal.png) </br>
**Export data to CSV : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_csv.png) </br>
**Application No connection error : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_no_connection.png) </br>
**Application Offline mode : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_offline.png) </br>

## Features
1)Get data for more than **170 countries** </br>
2)Export all the data to **CSV** file.  </br>
3)Display all the data sorted by most **active case**/**Fatal cases** globally.  </br>
4)Get global data by most **active case**/**Fatal cases** </br>
5)Clean and intuitive design </br>
6)Network connection checker.</br>

## Prerequisites
CovidSharp
RestSharp
Newtonsoft.json

## Credits.
Credits to [CRONOQUILL](https://github.com/CRONOQUILL) for Designing whole UI and give a new to whole application. 

## Changelogs

**Version 1.0:**
1)Initial version.

**Version 1.1:**
1)Updated whole application with new and **elegant UI design** changes . Thanks to [CRONOQUILL](https://github.com/CRONOQUILL) for Designing it.
2)Updated **country** and **province** list.
3)Added new **_country flags_** for almost all countries.
4)Added **Network connection** checker.
5)Added new **information viewer** with _6_ countries at a time.
6)Fixed minors **errors and exceptions** for no connections.


## Download
Download the application directly from here : [Covid-19 Tracker](https://bit.ly/C0v1dAppV1)

Written and Maintained by Haseeb Mir (haseebmir.hm@gmail.com)
