# Covid-19 Tracker [![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.me/AzimD)
[![GitHub stars](https://img.shields.io/github/stars/haseeb-heaven/Covid-19-Tracker)](https://github.com/Abdirahiim/covidtrackerapiwrapper/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/haseeb-heaven/Covid-19-Tracker)](https://github.com/Abdirahiim/covidtrackerapiwrapper/network/members)
[![GitHub Commit](https://img.shields.io/badge/Commits-5-blue)](https://github.com/haseeb-heaven/Covid-19-Tracker/network/members)</br>
          

The [Covid-19](https://en.wikipedia.org/wiki/Coronavirus_disease_2019) Tracker is Corona virus disease tracker based on [CovidSharp](https://github.com/Abdirahiim/covidtrackerapiwrapper)
which tracks data of more than 170 countries around the world and provide detailed data for **Active,Fatal,Recovered** cases. 

## API & Sources
Covid-19 Tracker uses [coronavirus-tracker-api](https://github.com/ExpDev07/coronavirus-tracker-api) and [CovidSharp SDK](https://github.com/Abdirahiim/covidtrackerapiwrapper) which is build in .NET </br>

**Data sources** </br>
[JHU](https://systems.jhu.edu/research/public-health/ncov/)  - Worldwide Data repository operated by the Johns Hopkins University Center for Systems Science and Engineering (JHU CSSE).</br>
[CSBS](https://www.csbs.org/information-covid-19-coronavirus) - U.S. County data that comes from the Conference of State Bank Supervisors.</br>

## Recovered cases showing 0
JHU [(our main data provider) no longer provides data for amount of recoveries](https://github.com/CSSEGISandData/COVID-19/issues/1250), and as a result, the API will be showing 0 for this statistic. Apologies :disappointed: for any inconvenience. Hopefully we'll be able to find an alternative data-source that offers this.

## Application Showcase.
### Application Main UI</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app.png?source=raw?source=raw) </br>

### Select province</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_province.png?source=raw) </br>

### Display active cases</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_active.png?source=raw) </br>

### Display fatal cases</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_fatal.png?source=raw) </br>

### Display Recover cases</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_recover.png?source=raw) </br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_recovered_error.png?source=raw) </br>

### Export data to CSV</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_csv.png?source=raw) </br>

### No connection error</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_no_connection.png?source=raw) </br>

### Offline mode</br>
![](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_offline.png?source=raw) </br>

## Features
* Get data for more than **170 countries** </br>
* Export all the data to **CSV** file.  </br>
* Display all the data sorted by most **active case**/**Fatal cases** globally.  </br>
* Get global data by most **active case**/**Fatal cases** </br>
* Clean and intuitive design </br>
* Network connection checker.</br>

## Prerequisites
* CovidSharp
* RestSharp
* Newtonsoft.json

## Credits.
Credits to [CRONOQUILL](https://github.com/CRONOQUILL) for Designing whole UI and give a new to whole application. 

## Changelogs
**Version 1.0:**</br>
* Initial version.</br>

**Version 1.1:**</br>
* Updated whole application with new and **elegant UI design** changes . Thanks to [CRONOQUILL](https://github.com/CRONOQUILL) for Designing it. :thumbsup:</br>
* Updated **country** and **province** list.</br>
* Added new **_country flags_** for almost all countries.</br>
* Added **Network connection** checker.</br>
* Added new **information viewer** with _6_ countries at a time.</br>
* Fixed minors **errors and exceptions** for no connections.</br>

# Application tutorial on YouTube :
[![Covid-19 Tutorial](https://img.youtube.com/vi/CFf3JKzsZcw/0.jpg)](https://www.youtube.com/watch?v=CFf3JKzsZcw)

## Download
Download the application directly from here : [Covid-19 Tracker](https://bit.ly/C0v1dAppV1)</br>

Written and Maintained by Haseeb Mir (haseebmir.hm@gmail.com)
