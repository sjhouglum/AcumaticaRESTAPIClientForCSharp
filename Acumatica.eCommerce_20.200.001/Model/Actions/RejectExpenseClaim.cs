using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class RejectExpenseClaim : EntityAction<ExpenseClaim>
	{
		public RejectExpenseClaim(ExpenseClaim entity) : base(entity)
		{ }
	}
}
