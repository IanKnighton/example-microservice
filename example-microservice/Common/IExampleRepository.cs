using System;
using example_microservice.Common.Models;

namespace example_microservice.Common
{
	public interface IExampleRepository
	{
        ExampleModel GetExampleModels();
        ExampleModel GetExampleModel(int id);
        ExampleModel GetExampleModel(ExampleModel model);
    }
}

