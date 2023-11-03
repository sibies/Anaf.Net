using Newtonsoft.Json;
using System.Collections.Generic;

namespace Anaf.Net.PlatitorTva.Responses.V8
{
    public class PlatitorTvaV8FoundAnafResponse
    {
        [JsonProperty("date_generale")]
        public DateGenerale DateGenerale { get; set; }

        [JsonProperty("inregistrare_scop_Tva")]
        public InregistrareScopTva InregistrareScopTva { get; set; }

        [JsonProperty("inregistrare_RTVAI")]
        public InregistrareRtvai InregistrareRtvai { get; set; }

        [JsonProperty("stare_inactiv")]
        public StareInactiv StareInactiv { get; set; }

        [JsonProperty("inregistrare_SplitTVA")]
        public InregistrareSplitTva InregistrareSplitTva { get; set; }

        [JsonProperty("adresa_sediu_social")]
        public AdresaSediuSocial AdresaSediuSocial { get; set; }

        [JsonProperty("adresa_domiciliu_fiscal")]
        public AdresaDomiciliuFiscal AdresaDomiciliuFiscal { get; set; }
    }
    public class AdresaDomiciliuFiscal
    {
        [JsonProperty("ddenumire_Strada")]
        public string DdenumireStrada { get; set; }

        [JsonProperty("dnumar_Strada")]
        public string DnumarStrada { get; set; }

        [JsonProperty("ddenumire_Localitate")]
        public string DdenumireLocalitate { get; set; }

        [JsonProperty("dcod_Localitate")]
        public string DcodLocalitate { get; set; }

        [JsonProperty("ddenumire_Judet")]
        public string DdenumireJudet { get; set; }

        [JsonProperty("dcod_Judet")]
        public string DcodJudet { get; set; }

        [JsonProperty("dcod_JudetAuto")]
        public string DcodJudetAuto { get; set; }

        [JsonProperty("dtara")]
        public string Dtara { get; set; }

        [JsonProperty("ddetalii_Adresa")]
        public string DdetaliiAdresa { get; set; }

        [JsonProperty("dcod_Postal")]
        public string DcodPostal { get; set; }
    }

    public class AdresaSediuSocial
    {
        [JsonProperty("sdenumire_Strada")]
        public string SdenumireStrada { get; set; }

        [JsonProperty("snumar_Strada")]
        public string SnumarStrada { get; set; }

        [JsonProperty("sdenumire_Localitate")]
        public string SdenumireLocalitate { get; set; }

        [JsonProperty("scod_Localitate")]
        public string ScodLocalitate { get; set; }

        [JsonProperty("sdenumire_Judet")]
        public string SdenumireJudet { get; set; }

        [JsonProperty("scod_Judet")]
        public string ScodJudet { get; set; }

        [JsonProperty("scod_JudetAuto")]
        public string ScodJudetAuto { get; set; }

        [JsonProperty("stara")]
        public string Stara { get; set; }

        [JsonProperty("sdetalii_Adresa")]
        public string SdetaliiAdresa { get; set; }

        [JsonProperty("scod_Postal")]
        public string ScodPostal { get; set; }
    }

    public class DateGenerale
    {
        [JsonProperty("cui")]
        public int Cui { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("denumire")]
        public string Denumire { get; set; }

        [JsonProperty("adresa")]
        public string Adresa { get; set; }

        [JsonProperty("nrRegCom")]
        public string NrRegCom { get; set; }

        [JsonProperty("telefon")]
        public string Telefon { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("codPostal")]
        public string CodPostal { get; set; }

        [JsonProperty("act")]
        public string Act { get; set; }

        [JsonProperty("stare_inregistrare")]
        public string StareInregistrare { get; set; }

        [JsonProperty("data_inregistrare")]
        public string DataInregistrare { get; set; }

        [JsonProperty("cod_CAEN")]
        public string CodCaen { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("statusRO_e_Factura")]
        public bool StatusRoeFactura { get; set; }

        [JsonProperty("organFiscalCompetent")]
        public string OrganFiscalCompetent { get; set; }

        [JsonProperty("forma_de_proprietate")]
        public string FormaDeProprietate { get; set; }

        [JsonProperty("forma_organizare")]
        public string FormaOrganizare { get; set; }

        [JsonProperty("forma_juridica")]
        public string FormaJuridica { get; set; }
    }

    public class InregistrareRtvai
    {
        [JsonProperty("dataInceputTvaInc")]
        public string DataInceputTvaInc { get; set; }

        [JsonProperty("dataSfarsitTvaInc")]
        public string DataSfarsitTvaInc { get; set; }

        [JsonProperty("dataActualizareTvaInc")]
        public string DataActualizareTvaInc { get; set; }

        [JsonProperty("dataPublicareTvaInc")]
        public string DataPublicareTvaInc { get; set; }

        [JsonProperty("tipActTvaInc")]
        public string TipActTvaInc { get; set; }

        [JsonProperty("statusTvaIncasare")]
        public bool StatusTvaIncasare { get; set; }
    }

    public class InregistrareScopTva
    {
        [JsonProperty("scpTVA")]
        public bool ScpTva { get; set; }

        [JsonProperty("perioade_TVA")]
        public List<PerioadeTva> PerioadeTva { get; set; }
    }

    public class InregistrareSplitTva
    {
        [JsonProperty("dataInceputSplitTVA")]
        public string DataInceputSplitTva { get; set; }

        [JsonProperty("dataAnulareSplitTVA")]
        public string DataAnulareSplitTva { get; set; }

        [JsonProperty("statusSplitTVA")]
        public bool StatusSplitTva { get; set; }
    }

    public class PerioadeTva
    {
        [JsonProperty("data_inceput_ScpTVA")]
        public string DataInceputScpTva { get; set; }

        [JsonProperty("data_sfarsit_ScpTVA")]
        public string DataSfarsitScpTva { get; set; }

        [JsonProperty("data_anul_imp_ScpTVA")]
        public string DataAnulImpScpTva { get; set; }

        [JsonProperty("mesaj_ScpTVA")]
        public string MesajScpTva { get; set; }
    }


    public class StareInactiv
    {
        [JsonProperty("dataInactivare")]
        public string DataInactivare { get; set; }

        [JsonProperty("dataReactivare")]
        public string DataReactivare { get; set; }

        [JsonProperty("dataPublicare")]
        public string DataPublicare { get; set; }

        [JsonProperty("dataRadiere")]
        public string DataRadiere { get; set; }

        [JsonProperty("statusInactivi")]
        public bool StatusInactivi { get; set; }
    }



}