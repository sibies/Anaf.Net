using System;
using Newtonsoft.Json;

namespace Anaf.Net.RegCult.Responses
{
    public class RegCultFoundAnafResponse
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
        public string DataInceputRegCult { get; set; }

        [JsonIgnore]
        public DateTime? DataInceputRegCultFirma => string.IsNullOrWhiteSpace(DataInceputRegCult)
            ? (DateTime?)null
            : DateTime.ParseExact(DataInceputRegCult, "yyyy-MM-dd", null);

        /// <summary>
        /// data radierii din registru
        /// </summary>
        public string DataAnulareRegCult { get; set; }

        [JsonIgnore]
        public DateTime? DataAnulareRegCultFirma => string.IsNullOrWhiteSpace(DataAnulareRegCult)
            ? (DateTime?)null
            : DateTime.ParseExact(DataAnulareRegCult, "yyyy-MM-dd", null);

        /// <summary>
        /// true -daca data cautata se afla in intervalul dataInceputRegCult - dataAnulareRegCult
        /// false -daca data cautata nu se afla in intervalul dataInceputRegCult - dataAnulareRegCult
        /// * daca data cautata este ulterioara datei curente, atunci informatiile de raspuns vor fi cele corespunzatoare datei curente
        /// </summary>
        public bool StatusRegCult { get; set; }
    }
}