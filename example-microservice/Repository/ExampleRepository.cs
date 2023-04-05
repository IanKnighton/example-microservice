using System;
using example_microservice.Common;
using example_microservice.Common.Models;

namespace example_microservice.Repository
{
	public class ExampleRepository : IExampleRepository
	{
		private string _connectionString;


		public ExampleRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public ExampleModel GetExampleModels()
		{
			// Goes to the DB and gets all models. 
			return new ExampleModel();
		}

		public ExampleModel GetExampleModel(int id)
		{
			// Goes to the DB and gets a single model by ID.
			return new ExampleModel();
		}

		public ExampleModel GetExampleModel(ExampleModel model)
		{
			// Not implementd, because reasons. 
			throw new NotImplementedException();
		}
	}
}

