# Covid-19 Tracker
[![GitHub stars](https://img.shields.io/github.com/haseeb-heaven/Covid-19-Tracker)](https://github.com/haseeb-heaven/Covid-19-Tracker/stargazers)
[![GitHub forks](https://img.shields.io/github.com/haseeb-heaven/Covid-19-Tracker)](https://github.com/haseeb-heaven/Covid-19-Tracker/network/members)
[![GitHub last commit](https://img.shields.io/github.com/haseeb-heaven/Covid-19-Tracker)](https://github.com/haseeb-heaven/Covid-19-Tracker/commits/master)

[Covid-19] (https://en.wikipedia.org/wiki/Coronavirus_disease_2019) is Corona virus disease tracker based on [CovidSharp](https://github.com/ExpDev07/coronavirus-tracker-api)
which tracks data of more than 140 countries around the world and provid detailed data for **Active,Fatal** cases. 

## API & Sources
Covid-19 Tracker uses [coronavirus-tracker-api](https://github.com/ExpDev07/coronavirus-tracker-api) and [CovidSharp SDK](https://github.com/ExpDev07/coronavirus-tracker-api)</br>

**Data sources ** </br>
[JHU](https://systems.jhu.edu/research/public-health/ncov/)  - Worldwide Data repository operated by the Johns Hopkins University Center for Systems Science and Engineering (JHU CSSE).</br>
[CSBS](https://www.csbs.org/information-covid-19-coronavirus) - U.S. County data that comes from the Conference of State Bank Supervisors.</br>

## Recovered cases showing 0
JHU [(our main data provider) no longer provides data for amount of recoveries](https://github.com/CSSEGISandData/COVID-19/issues/1250), and as a result, the API will be showing 0 for this statistic. Apolegies for any inconvenience. Hopefully we'll be able to find an alternative data-source that offers this.

## Application Showcase.
**Application shocase : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app.png) </br>
**Display active cases : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_active) </br>
**Display fatal cases : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_disp_fatal) </br>
**Export data to CSV : ** [](https://github.com/haseeb-heaven/Covid-19-Tracker/blob/master/resources/covid_app_csv) </br>

## Features
1)Get data for more than **140 countries** </br>
2)Export all the data to **CSV** file.  </br>
3)Display all the data sorted by most **active case**/**Fatal cases** globally.  </br>
4)Get global data by most **active case**/**Fatal cases** </br>

## Prerequisites
CovidSharp
RestSharp
Newtonsoft.json


Written and Maintained by Haseeb Mir (haseebmir.hm@gmail.com)