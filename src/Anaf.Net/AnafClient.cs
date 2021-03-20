using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anaf.Net.Bilant.Responses;
using Anaf.Net.Constants;
using Anaf.Net.Contracts;
using Anaf.Net.Internal;
using Anaf.Net.PlatitorTva.Requests;
using Anaf.Net.PlatitorTva.Responses;

namespace Anaf.Net
{
    public class AnafClient: JsonHttpClient, IAnafClient, IAnafClientAsync
    {
        public async Task<PlatitorTvaAnafResponse> GetInformatiiPlatitorTva(params int[] cui)
        {
            var request = cui.Select(c => new PlatitorTvaAnafRequest(c));

            var response = await PostAsync<IEnumerable<PlatitorTvaAnafRequest>, PlatitorTvaAnafResponse>(
                ApiConsts.EndPoints.PlatitorTva.V5.WsTvaSyncApiPath, request);

            return response;
        }



        public async Task<PlatitorTvaAnafAsyncResponse> InregistreazaCerereInformatiiPlatitorTvaAsync(params int[] cui)
        {
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
    }
}