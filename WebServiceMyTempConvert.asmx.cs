using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TareaLabWebAppTempConvert
{
    /// <summary>
    /// Summary description for WebServiceMyTempConvert
    /// </summary>
    [WebService(Namespace = "http://diamondisunbreakable.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMyTempConvert : System.Web.Services.WebService
    {
        public double fahrenheit, celsius, kelvin, number;
        public string key;
        public WebServiceMyTempConvert()
        {
            fahrenheit = 0;
            celsius = 0;
            kelvin = 0;
            number = 0;
            key = " ";
        }

        [WebMethod]
        public string ToFahrenheit(double number, string key)
        {
            WebServiceMyTempConvert temperatures = new WebServiceMyTempConvert();
            if (key == "fahrenheit")
            {
                temperatures.fahrenheit = number;
                temperatures.celsius = (double)(number - 32) * 5 / 9;
                temperatures.kelvin = (double)temperatures.celsius + 273.15;

                return "Fahrenheit: " + temperatures.fahrenheit + "\nCelsius: " + temperatures.celsius + "\nKelvin: " + temperatures.kelvin;
            }
            else
            {
                return "Error";
            }
        }

        [WebMethod]
        public string ToCelsius(double number, string key)
        {
            WebServiceMyTempConvert temperatures = new WebServiceMyTempConvert();
            if (key == "celsius")
            {
                temperatures.fahrenheit = (double)(number * 1.8) + 32;
                temperatures.celsius = number;
                temperatures.kelvin = (double)number + 273.15;

                return "Fahrenheit: " + temperatures.fahrenheit + "\nCelsius: " + temperatures.celsius + "\nKelvin: " + temperatures.kelvin;
            }
            else
            {
                return "Error";
            }
        }

        [WebMethod]
        public string ToKelvin(double number, string key)
        {
            WebServiceMyTempConvert temperatures = new WebServiceMyTempConvert();
            if (key == "kelvin")
            {
                temperatures.fahrenheit = (double)((number - 273.15) * 1.8) + 32;
                temperatures.celsius = (double)number - 273.15;
                temperatures.kelvin = number;

                return "Fahrenheit: " + temperatures.fahrenheit + "\nCelsius: " + temperatures.celsius + "\nKelvin: " + temperatures.kelvin;
            }
            else
            {
                return "Error";
            }
        }
    }
}
