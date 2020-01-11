using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class ProjectApi : EntityAPI<Project>
    {
        public ProjectApi() : base()
        {
        }
        public ProjectApi(Configuration configuration) : base(configuration)
        {
        }
    }
}