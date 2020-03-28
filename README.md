# Covid-19 Tracker
[![GitHub stars](https://img.shields.io/github.com/haseeb-heaven/Covid-19-Tracker)](https://github.com/haseeb-heaven/Covid-19-Tracker/stargazers)
[![GitHub forks](https://img.shields.io/github.com/haseeb-heaven/Covid-19-Tracker)](https://github.com/haseeb-heaven/Covid-19-Tracker/network/members)
[![GitHub last commit](https://img.shields.io/github.com/haseeb-heaven/Covid-19-Tracker)](https://github.com/haseeb-heaven/Covid-19-Tracker/commits/master)

[Covid-19] (https://en.wikipedia.org/wiki/Coronavirus_disease_2019) is Corona virus disease tracker based on [CovidSharp](https://github.com/Abdirahiim/covidtrackerapiwrapper)
which tracks data of more than 170 countries around the world and provide detailed data for **Active,Fatal,Recovered** cases. 

## API & Sources
Covid-19 Tracker uses [coronavirus-tracker-api](https://github.com/ExpDev07/coronavirus-tracker-api) and [CovidSharp SDK](https://github.com/Abdirahiim/covidtrackerapiwrapper)</br>

**Data sources ** </br>
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
6)Network connection checker.

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

Written and Maintained by Haseeb Mir (haseebmir.hm@gmail.com)