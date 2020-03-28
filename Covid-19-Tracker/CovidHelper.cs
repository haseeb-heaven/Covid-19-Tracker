using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_Tracker
{
    class CovidHelper
    {
        //Initiates client
        public static IRestClient client = new RestClient("https://coronavirus-tracker-api.herokuapp.com/");

        //Sends a GET request to the API
        public static IRestRequest request = new RestRequest("v2/latest", Method.GET);

        //Fetches the response from the API
        public IRestResponse response = client.Execute(request);

        private static string country_flags_url = "https://www.countryflags.io/";
        public static string country_error_url = "https://cdn3.iconfinder.com/data/icons/tango-icon-library/48/image-missing-64.png";
        public static string GetFlagsURL(string country_code, string style = "shiny", int size = 64)
        {
            string flag_url = null;
            if (String.IsNullOrEmpty(country_code))
            flag_url = country_error_url;
            else
                flag_url = flag_url + country_flags_url + country_code + "/" + style + "/" + size + ".png";
            return flag_url;
        }

        public static string GetCountryCode4mName(string country)
        {
            string country_code = null;
            try
            {
                //Sends a GET request to the API
                var request = new RestRequest("v2/locations?country=" + country, Method.GET);

                //Fetches the response from the API
                var response = client.Execute(request);

                //Deserializes the response
                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);

                //Stores the 'latest' node in the LatestData variable
                var locations = output["locations"];


                //The 'country_code' sub node of the 'locations' sub node  is fetched and converted into a string
                country_code = locations[0]["country_code"].ToString();
            }
            catch (NullReferenceException ex) { return null; }
            return country_code;
        }

        public static string FromCountryProvinceConfirmed(string province)
        {
            string data_type = "confirmed";
            string province_confirmed = FromCountryProvince(province, data_type);
            return province_confirmed;
        }

        public static string FromCountryProvinceRecovered(string province)
        {
            string data_type = "recovered";
            string province_recovered = FromCountryProvince(province, data_type);
            return province_recovered;
        }

        public static string FromCountryProvinceDeaths(string province)
        {
            string data_type = "deaths";
            string province_deaths = FromCountryProvince(province, data_type);
            return province_deaths;
        }

        private static string FromCountryProvince(string province, string data_type)
        {
            //Sends a GET request to the API
            var request = new RestRequest("v2/locations?province=" + province, Method.GET);

            //Fetches the response from the API
            var response = client.Execute(request);

            //Deserializes the response
            JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);

            //Stores the 'latest' node in the LatestData variable
            var LatestData = output["latest"];

            //The 'confirmed' sub node of the 'latest' sub node  is fetched and converted into a string
            var CountryConfirmedData = LatestData[data_type].ToString();
            return CountryConfirmedData;
        }


        //General method to get country province data.
        public static Dictionary<string, string> GetCountryProvinceData(string source = "jhu")
        {
            var province_list = new List<string>();
            var countries_province_list = new Dictionary<string, string>();

            try
            {
                //Sends a GET request to the API
                var request = new RestRequest("v2/locations?source=" + source, Method.GET);

                //Fetches the response from the API
                var response = client.Execute(request);

                //Deserializes the response
                JObject output = (JObject)JsonConvert.DeserializeObject(response.Content);

                //Stores the 'locations' node
                var locations = output["locations"];
                JArray loc_arr = (JArray)locations;

                string prev_country = null, curr_country = null;
                //Loop untill all countries and add them in HashSet to remove duplicates.
                for (int index = 0; index < loc_arr.Count; index++)
                {
                    string country_data = locations[index]["country"].ToString();
                    string province_data = locations[index]["province"].ToString();

                    if (prev_country == country_data || !String.IsNullOrEmpty(province_data))
                    {
                        if (!String.IsNullOrEmpty(province_data))
                        {
                            curr_country = country_data;
                            province_list.Add(province_data);
                        }
                    }

                    if (prev_country != country_data && !String.IsNullOrEmpty(prev_country) && province_list.Count > 1)
                    {
                        string province_list_str = string.Join("\n", province_list.ToArray());
                        countries_province_list.Add(curr_country, province_list_str);
                        province_list.Clear();
                    }

                    prev_country = country_data;
                }
            }
            catch (Exception ex) { }
            return countries_province_list;
        }

        public static string GetProvinceList4mCountry(string country)
        {
            Dictionary<string, string> province_data = new Dictionary<string, string>();
            string province = null;
            try
            {
                province_data = GetCountryProvinceData();
                if (province_data == null)
                    province_data = GetCountryProvinceData("csbs");
                province = province_data[country];
            }
            catch (KeyNotFoundException ex)
            {
                province = "Province not available";
            }
            return province;
        }
    }
}
