using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anaf.Net.Bilant.Responses;
using Anaf.Net.Constants;
using Anaf.Net.Contracts;
using Anaf.Net.Internal;
using Anaf.Net.PlatitorTva.Requests;
using Anaf.Net.PlatitorTva.Responses;
using Anaf.Net.RegAgric.Requests;
using Anaf.Net.RegAgric.Responses;
using Anaf.Net.RegCult.Requests;
using Anaf.Net.RegCult.Responses;

namespace Anaf.Net
{
    public class AnafClient: JsonHttpClient, IAnafClient, IAnafClientAsync
    {
        public async Task<PlatitorTvaAnafResponse> GetInformatiiPlatitorTva(params int[] cui)
        {
            if (cui.Length > 500)
                throw new IndexOutOfRangeException("Numar prea mare de elemente. (max < 500)");

            var request = cui.Select(c => new PlatitorTvaAnafRequest(c));

            var response = await PostAsync<IEnumerable<PlatitorTvaAnafRequest>, PlatitorTvaAnafResponse>(
                ApiConsts.EndPoints.PlatitorTva.V5.WsTvaSyncApiPath, request);

            return response;
        }


        public async Task<PlatitorTvaAnafAsyncResponse> InregistreazaCerereInformatiiPlatitorTvaAsync(params int[] cui)
        {
            if (cui.Length > 500)
                throw new IndexOutOfRangeException("Numar prea mare de elemente. (max < 500)");

            var request = cui.Select(c => new PlatitorTvaAnafRequest(c));

            var response = await PostAsync<IEnumerable<PlatitorTvaAnafRequest>, PlatitorTvaAnafAsyncResponse>(
                ApiConsts.EndPoints.PlatitorTva.V5.WsTvaAsyncApiPath, request);

            return response;
        }

        public async Task<PlatitorTvaAnafResponse> GetInformatiiPlatitorTvaAsync(string id)
        {
            var response = await GetAsync<PlatitorTvaAnafResponse>(
                string.Format(ApiConsts.EndPoints.PlatitorTva.V5.WsTvaDescarcaRaspunsAsyncApiPath, id));

            return response;
        }

        public async Task<BilantAnafResponse> GetBilant(int cui, int an)
        {
            var response = await GetAsync<BilantAnafResponse>(
                string.Format(ApiConsts.EndPoints.Bilant.BilantSyncApiPath, an, cui));

            return response;
        }

        public async Task<RegAgricAnafResponse> GetInformatiiRegAgric(params int[] cui)
        {
            if (cui.Length > 500)
                throw new IndexOutOfRangeException("Numar prea mare de elemente. (max < 500)");

            var request = cui.Select(c => new RegAgricAnafRequest(c));

            var response = await PostAsync<IEnumerable<RegAgricAnafRequest>, RegAgricAnafResponse>(
                ApiConsts.EndPoints.RegAgric.V2.WsAgricSyncApiPath, request);

            return response;
        }

        public async Task<RegCultAnafResponse> GetInformatiiRegCult(params int[] cui)
        {
            if (cui.Length > 500)
                throw new IndexOutOfRangeException("Numar prea mare de elemente. (max < 500)");

            var request = cui.Select(c => new RegCultAnafRequest(c));

            var response = await PostAsync<IEnumerable<RegCultAnafRequest>, RegCultAnafResponse>(
                ApiConsts.EndPoints.RegCult.V2.WsCultSyncApiPath, request);

            return response;
        }
    }
}