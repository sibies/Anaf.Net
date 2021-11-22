using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Anaf.Net.PlatitorTva.Responses
{
    /// <summary>
    /// Serviciu web pentru verificarea contribuabililor care sunt inregistrati conform art. 316 din Codul Fiscal, 
    /// conform Registrului persoanelor impozabile care aplica sistemul Tva la incasare, 
    /// conform Registrului contribuabililor inactivi/reactivi si respectiv Registrului persoanelor care aplica plata defalcata a TVA.
    /// 
    /// Folosirea serviciului este supusa urmatoarelor reguli:
    /// a) Un request poate contine maxim 500 de CUI-uri. Un client poate executa maxim 1 request pe secunda.
    /// b) Orice tentativa de suprasolicitare a serverului va fi pedepsita conform reglementarilor in vigoare.
    /// 
    /// Campurile care se refera la calitatea de platitor in scopuri de Tva: 
    /// scpTVA, data_sfarsit_ScpTVA, data_anul_imp_ScpTVA, mesaj_ScpTVA  
    /// Campurile care se refera la calitatea de platitor Tva la incasare: 
    /// dataInceputTvaInc, dataSfarsitTvaInc, dataActualizareTvaInc, dataPublicareTvaInc, tipActTvaInc, statusTvaIncasare
    /// Campurile care se refera la calitatea de inactiv/reactiv: 
    /// dataInactivare, dataReactivare, dataPublicare, dataRadiere, statusInactivi
    /// Campurile referitoare la plata defalcata a TVA: 
    /// dataInceputSplitTVA, dataAnulareSplitTVA, statusSplitTVA, iban
    /// </summary>
    public class PlatitorTvaFoundAnafResponse
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
        /// true -pentru platitor in scopuri de tva 
        /// false in cazul in care nu e platitor  in scopuri de TVA la data cautata
        /// </summary>
        public bool ScpTva { get; set; }
        /// <summary>
        /// Data înregistrãrii în scopuri de TVA anterioarã
        /// </summary>
        public string data_inceput_ScpTVA { get; set; }

        [JsonIgnore]
        public DateTime? DataInceputScpTva => string.IsNullOrWhiteSpace(data_inceput_ScpTVA)
            ? (DateTime?)null
            : DateTime.ParseExact(data_inceput_ScpTVA, "yyyy-MM-dd", null);

        /// <summary>
        /// Data anulãrii înregistrãrii în scopuri de TVA
        /// </summary>
        public string data_sfarsit_ScpTVA { get; set; }

        [JsonIgnore]
        public DateTime? DataSfarsitScpTva => string.IsNullOrWhiteSpace(data_sfarsit_ScpTVA)
            ? (DateTime?)null
            : DateTime.ParseExact(data_sfarsit_ScpTVA, "yyyy-MM-dd", null);

        /// <summary>
        /// Data operarii anularii înregistrãrii în scopuri de TVA  
        /// </summary>
        public string data_anul_imp_ScpTVA { get; set; }

        [JsonIgnore]
        public DateTime? DataAnulImpScpTva => string.IsNullOrWhiteSpace(data_anul_imp_ScpTVA)
            ? (DateTime?)null
            : DateTime.ParseExact(data_anul_imp_ScpTVA, "yyyy-MM-dd", null);

        /// <summary>
        /// MESAJ:(ne)platitor de TVA la data cautata
        /// </summary>
        public string mesaj_ScpTVA { get; set; }
        /// <summary>
        /// Data de la care aplicã sistemul TVA la încasare
        /// </summary>
        public string DataInceputTvaInc { get; set; }

        [JsonIgnore]
        public DateTime? DataInceputTvaIncasare => string.IsNullOrWhiteSpace(DataInceputTvaInc)
            ? (DateTime?)null
            : DateTime.ParseExact(DataInceputTvaInc, "yyyy-MM-dd", null);

        /// <summary>
        /// Data pânã la care aplicã sistemul TVA la încasare
        /// </summary>
        public string DataSfarsitTvaInc { get; set; }

        [JsonIgnore]
        public DateTime? DataSfarsitTvaIncasare => string.IsNullOrWhiteSpace(DataSfarsitTvaInc)
            ? (DateTime?)null
            : DateTime.ParseExact(DataSfarsitTvaInc, "yyyy-MM-dd", null);

        /// <summary>
        /// Data actualizarii
        /// </summary>
        public string DataActualizareTvaInc { get; set; }

        [JsonIgnore]
        public DateTime? DataActualizareTvaIncasare => string.IsNullOrWhiteSpace(DataActualizareTvaInc)
            ? (DateTime?)null
            : DateTime.ParseExact(DataActualizareTvaInc, "yyyy-MM-dd", null);

        /// <summary>
        /// Data publicarii
        /// </summary>
        public string DataPublicareTvaInc { get; set; }

        [JsonIgnore]
        public DateTime? DataPublicareTvaIncasare => string.IsNullOrWhiteSpace(DataPublicareTvaInc)
            ? (DateTime?)null
            : DateTime.ParseExact(DataPublicareTvaInc, "yyyy-MM-dd", null);

        /// <summary>
        /// Tip actualizare
        /// </summary>
        public string TipActTvaInc { get; set; }
        /// <summary>
        /// true -pentru platitor TVA la incasare/ false in cazul in care nu e platitor de TVA la incasare
        /// </summary>
        public bool StatusTvaIncasare { get; set; }
        public string DataInactivare { get; set; }

        [JsonIgnore]
        public DateTime? DataInactivareFirma => string.IsNullOrWhiteSpace(DataInactivare)
            ? (DateTime?)null
            : DateTime.ParseExact(DataInactivare, "yyyy-MM-dd", null);

        public string DataReactivare { get; set; }

        [JsonIgnore]
        public DateTime? DataReactivareFirma => string.IsNullOrWhiteSpace(DataReactivare)
            ? (DateTime?)null
            : DateTime.ParseExact(DataReactivare, "yyyy-MM-dd", null);

        public string DataPublicare { get; set; }

        [JsonIgnore]
        public DateTime? DataPublicareFirma => string.IsNullOrWhiteSpace(DataPublicare)
            ? (DateTime?)null
            : DateTime.ParseExact(DataPublicare, "yyyy-MM-dd", null);

        public string DataRadiere { get; set; }

        [JsonIgnore]
        public DateTime? DataRadiereFirma => string.IsNullOrWhiteSpace(DataRadiere)
            ? (DateTime?)null
            : DateTime.ParseExact(DataRadiere, "yyyy-MM-dd", null);

        /// <summary>
        /// true -pentru inactiv / false in cazul in care nu este inactiv
        /// </summary>
        public bool StatusInactivi { get; set; }
        public string DataInceputSplitTva { get; set; }

        [JsonIgnore]
        public DateTime? DataInceputSplitTvaFirma => string.IsNullOrWhiteSpace(DataInceputSplitTva)
            ? (DateTime?)null
            : DateTime.ParseExact(DataInceputSplitTva, "yyyy-MM-dd", null);

        public string DataAnulareSplitTva { get; set; }

        [JsonIgnore]
        public DateTime? DataAnulareSplitTvaFirma => string.IsNullOrWhiteSpace(DataAnulareSplitTva)
            ? (DateTime?)null
            : DateTime.ParseExact(DataAnulareSplitTva, "yyyy-MM-dd", null);

        public bool StatusSplitTva { get; set; }
        /// <summary>
        /// codul IBAN
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// figureaza in Registrul RO e-Factura / false - nu figureaza in Registrul RO e-Factura la data cautata
        /// </summary>
        public bool statusRO_e_Factura { get; set; }
    }
}