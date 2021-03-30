using System;
using Newtonsoft.Json;

namespace Anaf.Net.RegAgric.Responses
{
    public class RegAgricFoundAnafResponse
    {
        public bool Success => !string.IsNullOrEmpty(Denumire);

        /// <summary>
        /// codul fiscal
        /// </summary>
        public int Cui { get; set; }
        /// <summary>
        /// data pentru care se efectueaza cautarea
        /// </summary>
        public string Data { get; set; }

        [JsonIgnore]
        public DateTime? DataCautare => string.IsNullOrWhiteSpace(Data)
            ? (DateTime?)null
            : DateTime.ParseExact(Data, "yyyy-MM-dd", null);

        /// <summary>
        /// denumire 
        /// </summary>
        public string Denumire { get; set; }
        /// <summary>
        /// adresa 
        /// </summary>
        public string Adresa { get; set; }
        /// <summary>
        /// numar de inmatriculare la Registrul Comertului
        /// </summary>
        public string NrRegCom { get; set; }
        /// <summary>
        /// Telefon 
        /// </summary>
        public string Telefon { get; set; }
        /// <summary>
        /// Fax 
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Codul Postal
        /// </summary>
        public string CodPostal { get; set; }
        /// <summary>
        ///  Act autorizare
        /// </summary>
        public string Act { get; set; }
        /// <summary>
        /// Stare Societate
        /// </summary>
        public string stare_inregistrare { get; set; }
        /// <summary>
        /// data inscrierii in regsitru 
        /// </summary>
        public string DataInceputRegAgric { get; set; }

        [JsonIgnore]
        public DateTime? DataInceputRegAgricFirma => string.IsNullOrWhiteSpace(DataInceputRegAgric)
            ? (DateTime?)null
            : DateTime.ParseExact(DataInceputRegAgric, "yyyy-MM-dd", null);

        /// <summary>
        /// data radierii din registru
        /// </summary>
        public string DataAnulareRegAgric { get; set; }

        [JsonIgnore]
        public DateTime? DataAnulareRegAgricFirma => string.IsNullOrWhiteSpace(DataAnulareRegAgric)
            ? (DateTime?)null
            : DateTime.ParseExact(DataAnulareRegAgric, "yyyy-MM-dd", null);

        /// <summary>
        /// true -daca data cautata se afla in intervalul dataInceputRegAgric - dataAnulareRegAgric
        /// false -daca data cautata nu se afla in intervalul dataInceputRegAgric - dataAnulareRegAgric
        /// </summary>
        public bool StatusRegAgric { get; set; }
    }
}