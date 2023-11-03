using System;

namespace Anaf.Net.Constants
{
    public static class ApiConsts
    {
        public const string Version = "1.1.0";

        public static class EndPoints
        {
            public const string BaseApiUrl = "https://webservicesp.anaf.ro";

            public static class Bilant
            {
                public const string BaseServiceSyncApiPath = BaseApiUrl + "/bilant";
                public const string BilantSyncApiPath = BaseServiceSyncApiPath + "?an={0}&cui={1}";
            }

            public static class PlatitorTva
            {
                public const string BaseServiceSyncApiPath = BaseApiUrl + "/PlatitorTvaRest";
                public const string BaseServiceAsyncApiPath = BaseApiUrl + "/AsynchWebService";

                /// <summary>
                /// https://static.anaf.ro/static/10/Anaf/Informatii_R/documentatie_SW_01112017.txt
                /// https://static.anaf.ro/static/10/Anaf/Informatii_R/documentatie_SWAsincron_01112017.txt
                /// </summary>
                [Obsolete("Se foloseste versiunea 8")]
                public static class V3
                {

                }

                [Obsolete("Se foloseste versiunea 8")]
                public static class V4
                {

                }

                /// <summary>
                /// 
                /// </summary>
                [Obsolete("Se foloseste versiunea 8")]
                public static class V5
                {
                    public const string WsTvaSyncApiPath = BaseServiceSyncApiPath + "/api/v5/ws/tva";

                    public const string WsTvaAsyncApiPath = BaseServiceAsyncApiPath + "/api/v5/ws/tva";
                    public const string WsTvaDescarcaRaspunsAsyncApiPath = BaseServiceAsyncApiPath + "/api/v5/ws/tva?id={0}";
                }

                [Obsolete("Se foloseste versiunea 8")]
                public static class V6
                {
                    public const string WsTvaSyncApiPath = BaseServiceSyncApiPath + "/api/v6/ws/tva";

                    public const string WsTvaAsyncApiPath = BaseServiceAsyncApiPath + "/api/v6/ws/tva";
                    public const string WsTvaDescarcaRaspunsAsyncApiPath = BaseServiceAsyncApiPath + "/api/v6/ws/tva?id={0}";
                }

                /// <summary>
                /// https://static.anaf.ro/static/10/Anaf/Informatii_R/Servicii_web/doc_WS_V7.txt
                /// </summary>
                [Obsolete("Se foloseste versiunea 8")]
                public static class V7
                {
                    public const string WsTvaSyncApiPath = BaseServiceSyncApiPath + "/api/v7/ws/tva";

                    public const string WsTvaAsyncApiPath = BaseServiceAsyncApiPath + "/api/v7/ws/tva";
                    public const string WsTvaDescarcaRaspunsAsyncApiPath = BaseServiceAsyncApiPath + "/api/v7/ws/tva?id={0}";
                }


                /// <summary>
                /// https://static.anaf.ro/static/10/Anaf/Informatii_R/Servicii_web/doc_WS_V8.txt
                /// </summary>
                public static class V8
                {
                    public const string WsTvaSyncApiPath = BaseServiceSyncApiPath + "/api/v8/ws/tva";

                    public const string WsTvaAsyncApiPath = BaseServiceAsyncApiPath + "/api/v8/ws/tva";
                    public const string WsTvaDescarcaRaspunsAsyncApiPath = BaseServiceAsyncApiPath + "/api/v8/ws/tva?id={0}";
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