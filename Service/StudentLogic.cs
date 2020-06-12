using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApplication1.Model;

namespace Service
{
    public class StudentLogic : IStudentLogic
    {
        public async Task<Student> GetStudentAsync(Guid id)
        {
            List<Student> studentsList = new List<Student>();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //string token = await _tokenBuilder.GetAccessTokenAsync(cancellationToken);
                    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    string filter = $"?$filter=id eq {id}";
                    string url = "https://localhost:44372/odata/Students"+ filter;
                    var json = await httpClient.GetStringAsync(url);
                    var odata = JsonConvert.DeserializeObject<OData>(json);
                    studentsList = odata.Value;
                }
            }
            catch (Exception ex)
            {
                var error = ex;
            }

            return studentsList.FirstOrDefault();
        }

    }
}
