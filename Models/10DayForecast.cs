using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models
{

        public class Features
        {

            [JsonProperty("forecast10day")]
            public int forecast10day { get; set; }
        }

        public class Response
        {

            [JsonProperty("version")]
            public string version { get; set; }

            [JsonProperty("termsofService")]
            public string termsofService { get; set; }

            [JsonProperty("features")]
            public Features features { get; set; }
        }
        [JsonObject("forecastday")]
        public class ForecastdayTxt
        {

            [JsonProperty("period")]
            public int period { get; set; }

            [JsonProperty("icon")]
            public string icon { get; set; }

            [JsonProperty("icon_url")]
            public string icon_url { get; set; }

            [JsonProperty("title")]
            public string title { get; set; }

            [JsonProperty("fcttext")]
            public string fcttext { get; set; }

            [JsonProperty("fcttext_metric")]
            public string fcttext_metric { get; set; }

            [JsonProperty("pop")]
            public string pop { get; set; }
        }

        public class TxtForecast
        {

            [JsonProperty("date")]
            public string date { get; set; }

            [JsonProperty("forecastday")]
            public IList<ForecastdayTxt> forecastday { get; set; }
        }

        public class Date
        {

            [JsonProperty("epoch")]
            public string epoch { get; set; }

            [JsonProperty("pretty")]
            public string pretty { get; set; }

            [JsonProperty("day")]
            public int day { get; set; }

            [JsonProperty("month")]
            public int month { get; set; }

            [JsonProperty("year")]
            public int year { get; set; }

            [JsonProperty("yday")]
            public int yday { get; set; }

            [JsonProperty("hour")]
            public int hour { get; set; }

            [JsonProperty("min")]
            public string min { get; set; }

            [JsonProperty("sec")]
            public int sec { get; set; }

            [JsonProperty("isdst")]
            public string isdst { get; set; }

            [JsonProperty("monthname")]
            public string monthname { get; set; }

            [JsonProperty("monthname_short")]
            public string monthname_short { get; set; }

            [JsonProperty("weekday_short")]
            public string weekday_short { get; set; }

            [JsonProperty("weekday")]
            public string weekday { get; set; }

            [JsonProperty("ampm")]
            public string ampm { get; set; }

            [JsonProperty("tz_short")]
            public string tz_short { get; set; }

            [JsonProperty("tz_long")]
            public string tz_long { get; set; }
        }

        public class High
        {

            [JsonProperty("fahrenheit")]
            public string fahrenheit { get; set; }

            [JsonProperty("celsius")]
            public string celsius { get; set; }
        }

        public class Low
        {

            [JsonProperty("fahrenheit")]
            public string fahrenheit { get; set; }

            [JsonProperty("celsius")]
            public string celsius { get; set; }
        }

        public class QpfAllday
        {

            [JsonProperty("in")]
            public double inches { get; set; }

            [JsonProperty("mm")]
            public int mm { get; set; }
        }

        public class QpfDay
        {

            [JsonProperty("in")]
            public double inches { get; set; }

            [JsonProperty("mm")]
            public int mm { get; set; }
        }

        public class QpfNight
        {

            [JsonProperty("in")]
            public double inches { get; set; }

            [JsonProperty("mm")]
            public int mm { get; set; }
        }

        public class SnowAllday
        {

            [JsonProperty("in")]
            public double inches { get; set; }

            [JsonProperty("cm")]
            public double cm { get; set; }
        }

        public class SnowDay
        {

            [JsonProperty("in")]
            public double inches { get; set; }

            [JsonProperty("cm")]
            public double cm { get; set; }
        }

        public class SnowNight
        {

            [JsonProperty("in")]
            public double inches { get; set; }

            [JsonProperty("cm")]
            public double cm { get; set; }
        }

        public class Maxwind
        {

            [JsonProperty("mph")]
            public int mph { get; set; }

            [JsonProperty("kph")]
            public int kph { get; set; }

            [JsonProperty("dir")]
            public string dir { get; set; }

            [JsonProperty("degrees")]
            public int degrees { get; set; }
        }

        public class Avewind
        {

            [JsonProperty("mph")]
            public int mph { get; set; }

            [JsonProperty("kph")]
            public int kph { get; set; }

            [JsonProperty("dir")]
            public string dir { get; set; }

            [JsonProperty("degrees")]
            public int degrees { get; set; }
        }

        public class Forecastday
        {

            [JsonProperty("date")]
            public Date date { get; set; }

            [JsonProperty("period")]
            public int period { get; set; }

            [JsonProperty("high")]
            public High high { get; set; }

            [JsonProperty("low")]
            public Low low { get; set; }

            [JsonProperty("conditions")]
            public string conditions { get; set; }

            [JsonProperty("icon")]
            public string icon { get; set; }

            [JsonProperty("icon_url")]
            public string icon_url { get; set; }

            [JsonProperty("skyicon")]
            public string skyicon { get; set; }

            [JsonProperty("pop")]
            public int pop { get; set; }

            [JsonProperty("qpf_allday")]
            public QpfAllday qpf_allday { get; set; }

            [JsonProperty("qpf_day")]
            public QpfDay qpf_day { get; set; }

            [JsonProperty("qpf_night")]
            public QpfNight qpf_night { get; set; }

            [JsonProperty("snow_allday")]
            public SnowAllday snow_allday { get; set; }

            [JsonProperty("snow_day")]
            public SnowDay snow_day { get; set; }

            [JsonProperty("snow_night")]
            public SnowNight snow_night { get; set; }

            [JsonProperty("maxwind")]
            public Maxwind maxwind { get; set; }

            [JsonProperty("avewind")]
            public Avewind avewind { get; set; }

            [JsonProperty("avehumidity")]
            public int avehumidity { get; set; }

            [JsonProperty("maxhumidity")]
            public int maxhumidity { get; set; }

            [JsonProperty("minhumidity")]
            public int minhumidity { get; set; }
        }

        public class Simpleforecast
        {

            [JsonProperty("forecastday")]
            public IList<Forecastday> forecastday { get; set; }
        }

        public class Forecast
        {

            [JsonProperty("txt_forecast")]
            public TxtForecast txt_forecast { get; set; }

            [JsonProperty("simpleforecast")]
            public Simpleforecast simpleforecast { get; set; }
        }

        public class TenDayForecast
        {

            [JsonProperty("response")]
            public Response response { get; set; }

            [JsonProperty("forecast")]
            public Forecast forecast { get; set; }
        }

}