using System;

namespace Anaf.Net.Constants
{
    public static class ApiConsts
    {
        public const string Version = "1.0.0";

        public static class EndPoints
        {
            public const string BaseApiUrl = "https://webservicesp.anaf.ro";
            public const string BaseApiPath = BaseApiUrl + "/payment/rest";
            public const string BaseRegisterApiPath = BaseApiPath + "/register.do";

            public static class Bilant
            {
                public const string BaseServiceSyncApiPath = BaseApiUrl + "/bilant";
                public const string BilantSyncApiPath = BaseServiceSyncApiPath;
            }

            public static class PlatitorTva
            {
                public const string BaseServiceSyncApiPath = BaseApiUrl + "/PlatitorTvaRest";
                public const string BaseServiceAsyncApiPath = BaseApiUrl + "/AsynchWebService";

                /// <summary>
                /// https://static.anaf.ro/static/10/Anaf/Informatii_R/documentatie_SW_01112017.txt
                /// https://static.anaf.ro/static/10/Anaf/Informatii_R/documentatie_SWAsincron_01112017.txt
                /// </summary>
                [Obsolete("Se foloseste versiunea 5")]
                public static class V3
                {

                }

                [Obsolete("Se foloseste versiunea 5")]
                public static class V4
                {

                }

                /// <summary>
                /// 
                /// </summary>
                public static class V5
                {
                    public const string WsTvaSyncApiPath = BaseServiceSyncApiPath + "/api/v5/ws/tva";

                    public const string WsTvaAsyncApiPath = BaseServiceAsyncApiPath + "/api/v5/ws/tva";
                    public const string WsTvaDescarcaRaspunsAsyncApiPath = BaseServiceAsyncApiPath + "/api/v5/ws/tva?id={0}";
                }
            }

            public static class RegAgric
            {
                public const string BaseServiceSyncApiPath = BaseApiUrl + "/RegAgric";
                public static class V2
                {
                    public const string WsAgricSyncApiPath = BaseServiceSyncApiPath + "/api/v2/ws/agric";
                }
            }

            public static class RegCult
            {
                public const string BaseServiceSyncApiPath = BaseApiUrl + "/RegCult";
                public static class V2
                {
                    public const string WsCultSyncApiPath = BaseServiceSyncApiPath + "/api/v2/ws/cult";
                }
            }
        }
    }
}