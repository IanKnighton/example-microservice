using System;
using example_microservice.Common;
using example_microservice.Common.Models;
using example_microservice.Repository;

namespace example_microservice.Client
{
	public class ExampleClient : IExampleClient
	{
		private IExampleRepository _repository;

		public ExampleClient(ExampleRepository repository)
		{
			_repository = repository;
		}

		public ExampleModel GetExampleModels()
		{
			return _repository.GetExampleModels();
		}

		public ExampleModel GetExampleModel(int id)
		{
			return _repository.GetExampleModel(id);
		}

		public ExampleModel GetExampleModel(ExampleModel model)
		{
			return _repository.GetExampleModel(model);
		}
	}
}
